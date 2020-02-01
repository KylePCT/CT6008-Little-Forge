Shader "Unlit/Blur_Quality"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
		_PixelSize("Pixel Size", range(1,32)) = 16
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100

        Pass
        {
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

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                return o;
            }

			float _PixelSize;

            fixed4 frag (v2f i) : SV_Target
            {
				uint pixelSize = round(_PixelSize);
				int pixelSizeHalf = pixelSize / 2;
                fixed4 col = fixed4(0, 0, 0, 0);

				float2 screenPixelCoords = i.uv * _ScreenParams.xy;

				uint newXPos = round(screenPixelCoords.x / pixelSize) * pixelSize;
				uint newYPos = round(screenPixelCoords.y / pixelSize) * pixelSize;

				uint counter = 0;

				for (int x = 0; x < pixelSize; ++x)
				{
					for (int y = 0; y < pixelSize; ++y)
					{
						col += tex2D(_MainTex, i.uv + (float2(x - pixelSizeHalf, y - pixelSizeHalf) / _ScreenParams.xy));
						++counter;
					}
				}

				col = col / counter;

                return col;
            }
            ENDCG
        }
    }
}
