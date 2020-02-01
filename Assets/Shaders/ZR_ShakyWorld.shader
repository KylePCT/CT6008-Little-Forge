Shader "Unlit/ShakyWorld"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
		_PixelAmount("Pixel Amount", Range(0, 10)) = 1
		_Thickness("Thickness", Range(0, 16)) = 8
		_Speed("Speed", Range(0, 1000)) = 1000
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

			float _PixelAmount;
			float _Thickness;
			float _Speed;

            fixed4 frag (v2f i) : SV_Target
            {
				float thicknessHalf = _Thickness * 0.5f;

				float2 screenPixelCoords = i.uv * _ScreenParams.xy;

				float testY = sign(sin(_Time * _Speed)) * ((screenPixelCoords.x % _Thickness) - thicknessHalf);
				if (testY > 0)
				{
					i.uv.x = screenPixelCoords.x / (_ScreenParams.x + _PixelAmount);
				}
				else
				{
					i.uv.x = screenPixelCoords.x / (_ScreenParams.x - _PixelAmount);
				}

				// sample the texture
				fixed4 col = tex2D(_MainTex, i.uv);

                return col;
            }
            ENDCG
        }
    }
}
