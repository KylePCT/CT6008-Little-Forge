Shader "Custom/ModelOutline"
{
	Properties{
		_Color("Color", Color) = (1, 1, 1, 1)
		_Glossiness("Smoothness", Range(0, 1)) = 0.5
		_Metallic("Metallic", Range(0, 1)) = 0

		_OutlineColor("Outline Color", Color) = (0, 0, 0, 1)
		_OutlineWidth("Outline Width", Range(0, 5)) = 0.03
	}
    SubShader
    {
        Tags { "RenderType"="Opaque" }

		CGPROGRAM

		#pragma surface surf Standard fullforwardshadows
		#pragma target 3.0
		#include "UnityCG.cginc"

		struct Input
		{
			float4 color : COLOR;
		};

		half4 _Color;
		half _Glossiness;
		half _Metallic;

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			o.Albedo = _Color.rgb * IN.color.rgb;
			o.Smoothness = _Glossiness;
			o.Metallic = _Metallic;
			o.Alpha = _Color.a * IN.color.a;
		}

		ENDCG

			Pass
		{
			Cull Front

			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			half _OutlineWidth;

            float4 vert (float4 position : POSITION, float3 normal : NORMAL) : SV_POSITION
            {
				float4 clipPosition = UnityObjectToClipPos(position);
				float3 clipNormal = mul((float3x3)UNITY_MATRIX_VP, mul((float3x3)UNITY_MATRIX_M, normal));

				float2 offset = normalize(clipNormal.xy) / _ScreenParams.xy * _OutlineWidth * clipPosition.w * 2;
				clipPosition.xy += offset;

				return clipPosition;
            }

			half4 _OutlineColor;

            half4 frag () : SV_Target
            {
				return _OutlineColor;
            }
            ENDCG
        }
    }
}
