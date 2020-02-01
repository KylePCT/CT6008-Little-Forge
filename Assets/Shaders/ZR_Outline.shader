Shader "Unlit/Outline"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
		_ScreenRender("Screen Texture", 2D) = "white" {}
		_OutlineRadius("OutlineRadius", int) = 5
		_OutlineColour("OutlineColour", Color) = (0, 0, 0, 1)
		_Depth("Depth", float) = 0
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100

        Pass
        {
			Blend SrcAlpha OneMinusSrcAlpha
			ZTest Off
			ZWrite On

            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;
			sampler2D _CameraDepthTexture;
			sampler2D _LastCameraDepthTexture;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                return o;
            }

			float4 _OutlineColour;
			uint _OutlineRadius;

			float GetAlpha(v2f a_i, float2 a_offset)
			{
				float2 samplePoint = a_i.uv + (a_offset / _ScreenParams.xy);
				
				fixed4 mainCol = tex2D(_MainTex, samplePoint).a;

				float depth = SAMPLE_DEPTH_TEXTURE(_LastCameraDepthTexture, samplePoint);
				float pixelDepth = SAMPLE_DEPTH_TEXTURE(_CameraDepthTexture, a_i.uv);

				return step(pixelDepth, depth) * mainCol.a;
			}

            fixed4 frag (v2f i) : SV_Target
            {
				fixed4 col = tex2D(_MainTex, i.uv);
				
				int radius = 5;

				uint buffer = 5;

				if (col.a == 1)
					return fixed4(0, 0, 0, 0);

				col = fixed4(_OutlineColour.xyz, 0);

				int diameter = radius * radius;
				for (int y = -radius; y <= radius; ++y)
				{
					for (int x = -radius; x <= radius; ++x)
					{
						if (x*x + y*y <= diameter)
						{
							if( GetAlpha(i, float2(x, y)))
							{
								col.a = 1;
								break;
							}
						}
					}
				}

                return col;
            }
            ENDCG
        }
    }
}
