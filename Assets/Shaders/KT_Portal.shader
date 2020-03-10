// Shader created with Shader Forge v1.40 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.40;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,cpap:True,lico:1,lgpr:1,limd:0,spmd:1,trmd:1,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:0,bdst:0,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:5149,x:33659,y:32095,varname:node_5149,prsc:2|emission-9814-OUT,alpha-6080-OUT;n:type:ShaderForge.SFN_Color,id:3428,x:31929,y:32720,ptovrint:False,ptlb:Secondary Colour,ptin:_SecondaryColour,varname:node_3428,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0.8888173,c3:1,c4:1;n:type:ShaderForge.SFN_TexCoord,id:1984,x:31806,y:32970,varname:node_1984,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_RemapRange,id:7771,x:31975,y:32970,varname:node_7771,prsc:2,frmn:0,frmx:1,tomn:-1,tomx:1|IN-1984-UVOUT;n:type:ShaderForge.SFN_Multiply,id:4040,x:32145,y:32970,varname:node_4040,prsc:2|A-7771-OUT,B-7771-OUT;n:type:ShaderForge.SFN_ComponentMask,id:9453,x:32297,y:32970,varname:node_9453,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-4040-OUT;n:type:ShaderForge.SFN_Lerp,id:9023,x:32288,y:32609,varname:node_9023,prsc:2|A-3433-RGB,B-3428-RGB,T-6196-OUT;n:type:ShaderForge.SFN_Rotator,id:9769,x:31929,y:32305,varname:node_9769,prsc:2|UVIN-2599-UVOUT,ANG-7706-OUT,SPD-7706-OUT;n:type:ShaderForge.SFN_Time,id:4916,x:31373,y:32661,varname:node_4916,prsc:2;n:type:ShaderForge.SFN_TexCoord,id:2599,x:31662,y:32309,varname:node_2599,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:8856,x:33008,y:32509,varname:node_8856,prsc:2|A-9530-OUT,B-9023-OUT;n:type:ShaderForge.SFN_Slider,id:6608,x:31250,y:32522,ptovrint:False,ptlb:RotationSpeed,ptin:_RotationSpeed,varname:node_6608,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.184625,max:1;n:type:ShaderForge.SFN_Multiply,id:7706,x:31628,y:32520,varname:node_7706,prsc:2|A-6608-OUT,B-4916-TSL;n:type:ShaderForge.SFN_Color,id:3433,x:31929,y:32519,ptovrint:False,ptlb:Primary Colour,ptin:_PrimaryColour,varname:_SecondaryColour_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Panner,id:5495,x:32065,y:32057,varname:node_5495,prsc:2,spu:5,spv:5|UVIN-2599-UVOUT,DIST-3041-OUT;n:type:ShaderForge.SFN_Multiply,id:9530,x:32503,y:32143,varname:node_9530,prsc:2|A-5157-RGB,B-8039-RGB;n:type:ShaderForge.SFN_Multiply,id:4032,x:32514,y:32424,varname:node_4032,prsc:2|A-9530-OUT,B-9023-OUT;n:type:ShaderForge.SFN_RemapRange,id:2183,x:31693,y:32137,varname:node_2183,prsc:2,frmn:0,frmx:1,tomn:0,tomx:10|IN-6608-OUT;n:type:ShaderForge.SFN_Tex2d,id:5157,x:32261,y:32057,ptovrint:False,ptlb:Distortion Noise Multiply,ptin:_DistortionNoiseMultiply,varname:_DistortionNoise_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-5495-UVOUT;n:type:ShaderForge.SFN_Add,id:9814,x:33381,y:32185,varname:node_9814,prsc:2|A-8326-OUT,B-4032-OUT;n:type:ShaderForge.SFN_Slider,id:7146,x:32398,y:31933,ptovrint:False,ptlb:Fresnel Strength,ptin:_FresnelStrength,varname:node_7146,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_RemapRange,id:5667,x:32754,y:31934,varname:node_5667,prsc:2,frmn:0,frmx:1,tomn:4,tomx:0|IN-7146-OUT;n:type:ShaderForge.SFN_Fresnel,id:8149,x:32973,y:31934,varname:node_8149,prsc:2|EXP-5667-OUT;n:type:ShaderForge.SFN_Tex2d,id:8039,x:32266,y:32315,ptovrint:False,ptlb:Distortion Noise,ptin:_DistortionNoise,varname:_DistortionNoiseMultiply_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-9769-UVOUT;n:type:ShaderForge.SFN_Sin,id:7708,x:31693,y:31982,varname:node_7708,prsc:2|IN-6608-OUT;n:type:ShaderForge.SFN_Multiply,id:3041,x:31872,y:32043,varname:node_3041,prsc:2|A-7708-OUT,B-2183-OUT;n:type:ShaderForge.SFN_Color,id:9481,x:32973,y:31759,ptovrint:False,ptlb:Fresnel Colour,ptin:_FresnelColour,varname:node_9481,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:1,c3:0.16855,c4:1;n:type:ShaderForge.SFN_Multiply,id:8326,x:33174,y:31868,varname:node_8326,prsc:2|A-9481-RGB,B-8149-OUT;n:type:ShaderForge.SFN_Add,id:6196,x:32469,y:32970,varname:node_6196,prsc:2|A-9453-R,B-9453-G;n:type:ShaderForge.SFN_ComponentMask,id:6080,x:33207,y:32509,varname:node_6080,prsc:2,cc1:1,cc2:-1,cc3:-1,cc4:-1|IN-8856-OUT;proporder:3433-3428-8039-5157-6608-9481-7146;pass:END;sub:END;*/

Shader "Shader Forge/KT_Portal" {
    Properties {
        _PrimaryColour ("Primary Colour", Color) = (0,0,0,1)
        _SecondaryColour ("Secondary Colour", Color) = (0,0.8888173,1,1)
        _DistortionNoise ("Distortion Noise", 2D) = "white" {}
        _DistortionNoiseMultiply ("Distortion Noise Multiply", 2D) = "white" {}
        _RotationSpeed ("RotationSpeed", Range(0, 1)) = 0.184625
        _FresnelColour ("Fresnel Colour", Color) = (0,1,0.16855,1)
        _FresnelStrength ("Fresnel Strength", Range(0, 1)) = 0
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        LOD 100
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend One One
            Cull Off
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma target 3.0
            uniform sampler2D _DistortionNoiseMultiply; uniform float4 _DistortionNoiseMultiply_ST;
            uniform sampler2D _DistortionNoise; uniform float4 _DistortionNoise_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float4, _SecondaryColour)
                UNITY_DEFINE_INSTANCED_PROP( float, _RotationSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float4, _PrimaryColour)
                UNITY_DEFINE_INSTANCED_PROP( float, _FresnelStrength)
                UNITY_DEFINE_INSTANCED_PROP( float4, _FresnelColour)
            UNITY_INSTANCING_BUFFER_END( Props )
            struct VertexInput {
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                i.normalDir = normalize(i.normalDir);
                i.normalDir *= faceSign;
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
////// Lighting:
////// Emissive:
                float4 _FresnelColour_var = UNITY_ACCESS_INSTANCED_PROP( Props, _FresnelColour );
                float _FresnelStrength_var = UNITY_ACCESS_INSTANCED_PROP( Props, _FresnelStrength );
                float _RotationSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _RotationSpeed );
                float2 node_5495 = (i.uv0+(sin(_RotationSpeed_var)*(_RotationSpeed_var*10.0+0.0))*float2(5,5));
                float4 _DistortionNoiseMultiply_var = tex2D(_DistortionNoiseMultiply,TRANSFORM_TEX(node_5495, _DistortionNoiseMultiply));
                float4 node_4916 = _Time;
                float node_7706 = (_RotationSpeed_var*node_4916.r);
                float node_9769_ang = node_7706;
                float node_9769_spd = node_7706;
                float node_9769_cos = cos(node_9769_spd*node_9769_ang);
                float node_9769_sin = sin(node_9769_spd*node_9769_ang);
                float2 node_9769_piv = float2(0.5,0.5);
                float2 node_9769 = (mul(i.uv0-node_9769_piv,float2x2( node_9769_cos, -node_9769_sin, node_9769_sin, node_9769_cos))+node_9769_piv);
                float4 _DistortionNoise_var = tex2D(_DistortionNoise,TRANSFORM_TEX(node_9769, _DistortionNoise));
                float3 node_9530 = (_DistortionNoiseMultiply_var.rgb*_DistortionNoise_var.rgb);
                float4 _PrimaryColour_var = UNITY_ACCESS_INSTANCED_PROP( Props, _PrimaryColour );
                float4 _SecondaryColour_var = UNITY_ACCESS_INSTANCED_PROP( Props, _SecondaryColour );
                float2 node_7771 = (i.uv0*2.0+-1.0);
                float2 node_9453 = (node_7771*node_7771).rg;
                float3 node_9023 = lerp(_PrimaryColour_var.rgb,_SecondaryColour_var.rgb,(node_9453.r+node_9453.g));
                float3 emissive = ((_FresnelColour_var.rgb*pow(1.0-max(0,dot(normalDirection, viewDirection)),(_FresnelStrength_var*-4.0+4.0)))+(node_9530*node_9023));
                float3 finalColor = emissive;
                float3 node_8856 = (node_9530*node_9023);
                return fixed4(finalColor,node_8856.g);
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            Cull Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma target 3.0
            struct VertexInput {
                float4 vertex : POSITION;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
