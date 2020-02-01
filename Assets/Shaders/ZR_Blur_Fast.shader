Shader "Unlit/Blur_Fast"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
		_BlurAmount("BlurAmount", range(0, 10)) = 1
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

			float _BlurAmount;

            fixed4 frag (v2f i) : SV_Target
            {
                // sample the texture
                //fixed4 col = tex2D(_MainTex, i.uv);
				//float2 screenPixelCoords = i.uv * _ScreenParams.xy;

				fixed4 col = fixed4(0, 0, 0, 0);

				col += tex2D(_MainTex, i.uv + (float2(-_BlurAmount, _BlurAmount) / _ScreenParams.xy));
				col += tex2D(_MainTex, i.uv + (float2(0, _BlurAmount) / _ScreenParams.xy));
				col += tex2D(_MainTex, i.uv + (float2(_BlurAmount, _BlurAmount) / _ScreenParams.xy));
				col += tex2D(_MainTex, i.uv + (float2(-_BlurAmount, 0) / _ScreenParams.xy));
				col += tex2D(_MainTex, i.uv + (float2(_BlurAmount, 0) / _ScreenParams.xy));
				col += tex2D(_MainTex, i.uv + (float2(-_BlurAmount, -_BlurAmount) / _ScreenParams.xy));
				col += tex2D(_MainTex, i.uv + (float2(0, -_BlurAmount) / _ScreenParams.xy));
				col += tex2D(_MainTex, i.uv + (float2(_BlurAmount, -_BlurAmount) / _ScreenParams.xy));

				col = col / 8;

                return col;
            }
            ENDCG
        }
    }
}
