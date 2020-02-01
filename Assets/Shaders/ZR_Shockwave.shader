//////////////////////////////////////////////////
// Author: Zack Raeburn
// Date created: 23/01/20
// Last edit: 23/01/20
// Description: A shader for a screen space shockwave
// Comments: I need to finish the maths on this shader and add a system to dynamically add multiple shockwaves
//////////////////////////////////////////////////

Shader "Hidden/Shockwave"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
		_ShockSize("Shockwave Size", float) = 0
		_ShockThickness("Shockwave Thickness", float) = 50
		_ShockStrength("Shockwave strength", Range(0, 1)) = 1
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

			float _ShockSize;
			float _ShockThickness;
			float _ShockStrength;

            fixed4 frag (v2f i) : SV_Target
            {
				// Big math time lets go
				float2 targetPixelPos = float2(0.5, 0.5) * _ScreenParams.xy;
				float2 screenPixelCoords = i.uv * _ScreenParams.xy;

				float2 targetDir = normalize(screenPixelCoords - targetPixelPos);
				float targetDirSign = sign(length(screenPixelCoords - targetPixelPos) - _ShockSize);
				float2 targetAdjustedPixelPos = targetPixelPos + (targetDir * (_ShockSize - _ShockThickness));

				float pixelDist = distance(screenPixelCoords, targetAdjustedPixelPos);
				
				float shockAmount = min(pixelDist - _ShockThickness, 0);
				// I dont know how this works but it does
				fixed4 col = tex2D(_MainTex, i.uv + ((targetDir * targetDirSign) / _ScreenParams.xy * shockAmount * _ShockStrength));

                return col;
            }
            ENDCG
        }
    }
}
