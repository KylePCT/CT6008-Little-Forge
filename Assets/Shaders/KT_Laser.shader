// Shader created with Shader Forge v1.40 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.40;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,cpap:True,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:4013,x:34107,y:32700,varname:node_4013,prsc:2|diff-2843-OUT,emission-199-OUT,alpha-6923-OUT;n:type:ShaderForge.SFN_Color,id:1304,x:32969,y:32502,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_1304,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0.08433735,c3:0,c4:1;n:type:ShaderForge.SFN_Tex2d,id:5630,x:32128,y:32631,ptovrint:False,ptlb:Beam Texture,ptin:_BeamTexture,varname:node_5630,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:b756aa1b0975fbd4caa65e91cb0c9772,ntxv:0,isnm:False|UVIN-8171-UVOUT;n:type:ShaderForge.SFN_Multiply,id:3314,x:33165,y:32703,varname:node_3314,prsc:2|A-222-OUT,B-1304-RGB;n:type:ShaderForge.SFN_Slider,id:3477,x:32848,y:33217,ptovrint:False,ptlb:Line Opacity,ptin:_LineOpacity,varname:node_3477,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Multiply,id:1896,x:32927,y:32989,varname:node_1896,prsc:2|A-5823-OUT,B-3477-OUT;n:type:ShaderForge.SFN_VertexColor,id:2398,x:33165,y:32829,varname:node_2398,prsc:2;n:type:ShaderForge.SFN_Multiply,id:6923,x:33165,y:32989,varname:node_6923,prsc:2|A-2398-A,B-1896-OUT;n:type:ShaderForge.SFN_Multiply,id:2843,x:33423,y:32717,varname:node_2843,prsc:2|A-3314-OUT,B-2398-RGB;n:type:ShaderForge.SFN_TexCoord,id:9529,x:31347,y:32959,varname:node_9529,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Time,id:5758,x:31503,y:32635,varname:node_5758,prsc:2;n:type:ShaderForge.SFN_Panner,id:8171,x:31905,y:32631,varname:node_8171,prsc:2,spu:1,spv:0|UVIN-9529-UVOUT,DIST-6489-OUT;n:type:ShaderForge.SFN_Multiply,id:6489,x:31684,y:32711,varname:node_6489,prsc:2|A-5758-T,B-7854-OUT;n:type:ShaderForge.SFN_Slider,id:7854,x:31346,y:32798,ptovrint:False,ptlb:Laser Speed,ptin:_LaserSpeed,varname:node_7854,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-5,cur:0,max:5;n:type:ShaderForge.SFN_Panner,id:1602,x:31930,y:32884,varname:node_1602,prsc:2,spu:0.5,spv:0|UVIN-9529-UVOUT,DIST-2456-OUT;n:type:ShaderForge.SFN_Multiply,id:2456,x:31684,y:33021,varname:node_2456,prsc:2|A-5758-T,B-3402-OUT;n:type:ShaderForge.SFN_Slider,id:3402,x:31347,y:33181,ptovrint:False,ptlb:Noise Speed,ptin:_NoiseSpeed,varname:_LaserSpeed_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-5,cur:-5,max:5;n:type:ShaderForge.SFN_Multiply,id:7977,x:32662,y:32921,varname:node_7977,prsc:2|A-5630-A,B-2738-OUT;n:type:ShaderForge.SFN_Multiply,id:2045,x:32662,y:32761,varname:node_2045,prsc:2|A-5630-RGB,B-9759-OUT;n:type:ShaderForge.SFN_Multiply,id:199,x:33721,y:32798,varname:node_199,prsc:2|A-2843-OUT,B-3269-OUT;n:type:ShaderForge.SFN_Slider,id:3269,x:33363,y:32898,ptovrint:False,ptlb:Emissive Intensity,ptin:_EmissiveIntensity,varname:node_3269,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:5,max:5;n:type:ShaderForge.SFN_Multiply,id:5357,x:31884,y:33396,varname:node_5357,prsc:2|A-5758-T,B-3402-OUT;n:type:ShaderForge.SFN_Tex2d,id:7481,x:32246,y:33319,varname:node_7481,prsc:2,tex:382494a056184334c8c481a06a4e6662,ntxv:0,isnm:False|UVIN-9495-UVOUT,TEX-556-TEX;n:type:ShaderForge.SFN_Tex2dAsset,id:556,x:32060,y:33131,ptovrint:False,ptlb:Noise Texture,ptin:_NoiseTexture,varname:node_556,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:382494a056184334c8c481a06a4e6662,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Panner,id:9495,x:32060,y:33329,varname:node_9495,prsc:2,spu:1,spv:0|UVIN-9529-UVOUT,DIST-5357-OUT;n:type:ShaderForge.SFN_Multiply,id:9759,x:32435,y:33052,varname:node_9759,prsc:2|A-6875-RGB,B-7481-RGB;n:type:ShaderForge.SFN_Multiply,id:2738,x:32435,y:33232,varname:node_2738,prsc:2|A-6875-A,B-7481-A;n:type:ShaderForge.SFN_Tex2d,id:6875,x:32253,y:33007,varname:node_6875,prsc:2,tex:382494a056184334c8c481a06a4e6662,ntxv:0,isnm:False|UVIN-1602-UVOUT,TEX-556-TEX;n:type:ShaderForge.SFN_SwitchProperty,id:222,x:32662,y:32547,ptovrint:False,ptlb:Noise?,ptin:_Noise,varname:node_222,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:True|A-5630-RGB,B-2045-OUT;n:type:ShaderForge.SFN_SwitchProperty,id:5823,x:32662,y:33160,ptovrint:False,ptlb:Noise Alpha?,ptin:_NoiseAlpha,varname:_Noise_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-5630-R,B-2738-OUT;proporder:5630-1304-3477-7854-3402-3269-556-222-5823;pass:END;sub:END;*/

Shader "Shader Forge/KT_Laser" {
    Properties {
        _BeamTexture ("Beam Texture", 2D) = "white" {}
        _Color ("Color", Color) = (1,0.08433735,0,1)
        _LineOpacity ("Line Opacity", Range(0, 1)) = 1
        _LaserSpeed ("Laser Speed", Range(-5, 5)) = 0
        _NoiseSpeed ("Noise Speed", Range(-5, 5)) = -5
        _EmissiveIntensity ("Emissive Intensity", Range(0, 5)) = 5
        _NoiseTexture ("Noise Texture", 2D) = "white" {}
        [MaterialToggle] _Noise ("Noise?", Float ) = 0
        [MaterialToggle] _NoiseAlpha ("Noise Alpha?", Float ) = 0
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            Cull Off
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _BeamTexture; uniform float4 _BeamTexture_ST;
            uniform sampler2D _NoiseTexture; uniform float4 _NoiseTexture_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float4, _Color)
                UNITY_DEFINE_INSTANCED_PROP( float, _LineOpacity)
                UNITY_DEFINE_INSTANCED_PROP( float, _LaserSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float, _NoiseSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float, _EmissiveIntensity)
                UNITY_DEFINE_INSTANCED_PROP( fixed, _Noise)
                UNITY_DEFINE_INSTANCED_PROP( fixed, _NoiseAlpha)
            UNITY_INSTANCING_BUFFER_END( Props )
            struct VertexInput {
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float4 vertexColor : COLOR;
                UNITY_FOG_COORDS(3)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
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
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = 1;
                float3 attenColor = attenuation * _LightColor0.xyz;
/////// Diffuse:
                float NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float4 node_5758 = _Time;
                float _LaserSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _LaserSpeed );
                float2 node_8171 = (i.uv0+(node_5758.g*_LaserSpeed_var)*float2(1,0));
                float4 _BeamTexture_var = tex2D(_BeamTexture,TRANSFORM_TEX(node_8171, _BeamTexture));
                float _NoiseSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _NoiseSpeed );
                float2 node_1602 = (i.uv0+(node_5758.g*_NoiseSpeed_var)*float2(0.5,0));
                float4 node_6875 = tex2D(_NoiseTexture,TRANSFORM_TEX(node_1602, _NoiseTexture));
                float2 node_9495 = (i.uv0+(node_5758.g*_NoiseSpeed_var)*float2(1,0));
                float4 node_7481 = tex2D(_NoiseTexture,TRANSFORM_TEX(node_9495, _NoiseTexture));
                float3 _Noise_var = lerp( _BeamTexture_var.rgb, (_BeamTexture_var.rgb*(node_6875.rgb*node_7481.rgb)), UNITY_ACCESS_INSTANCED_PROP( Props, _Noise ) );
                float4 _Color_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Color );
                float3 node_2843 = ((_Noise_var*_Color_var.rgb)*i.vertexColor.rgb);
                float3 diffuseColor = node_2843;
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
////// Emissive:
                float _EmissiveIntensity_var = UNITY_ACCESS_INSTANCED_PROP( Props, _EmissiveIntensity );
                float3 emissive = (node_2843*_EmissiveIntensity_var);
/// Final Color:
                float3 finalColor = diffuse + emissive;
                float node_2738 = (node_6875.a*node_7481.a);
                float _NoiseAlpha_var = lerp( _BeamTexture_var.r, node_2738, UNITY_ACCESS_INSTANCED_PROP( Props, _NoiseAlpha ) );
                float _LineOpacity_var = UNITY_ACCESS_INSTANCED_PROP( Props, _LineOpacity );
                fixed4 finalRGBA = fixed4(finalColor,(i.vertexColor.a*(_NoiseAlpha_var*_LineOpacity_var)));
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            Cull Off
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdadd
            #pragma multi_compile_fog
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _BeamTexture; uniform float4 _BeamTexture_ST;
            uniform sampler2D _NoiseTexture; uniform float4 _NoiseTexture_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float4, _Color)
                UNITY_DEFINE_INSTANCED_PROP( float, _LineOpacity)
                UNITY_DEFINE_INSTANCED_PROP( float, _LaserSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float, _NoiseSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float, _EmissiveIntensity)
                UNITY_DEFINE_INSTANCED_PROP( fixed, _Noise)
                UNITY_DEFINE_INSTANCED_PROP( fixed, _NoiseAlpha)
            UNITY_INSTANCING_BUFFER_END( Props )
            struct VertexInput {
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float4 vertexColor : COLOR;
                LIGHTING_COORDS(3,4)
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
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
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
/////// Diffuse:
                float NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float4 node_5758 = _Time;
                float _LaserSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _LaserSpeed );
                float2 node_8171 = (i.uv0+(node_5758.g*_LaserSpeed_var)*float2(1,0));
                float4 _BeamTexture_var = tex2D(_BeamTexture,TRANSFORM_TEX(node_8171, _BeamTexture));
                float _NoiseSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _NoiseSpeed );
                float2 node_1602 = (i.uv0+(node_5758.g*_NoiseSpeed_var)*float2(0.5,0));
                float4 node_6875 = tex2D(_NoiseTexture,TRANSFORM_TEX(node_1602, _NoiseTexture));
                float2 node_9495 = (i.uv0+(node_5758.g*_NoiseSpeed_var)*float2(1,0));
                float4 node_7481 = tex2D(_NoiseTexture,TRANSFORM_TEX(node_9495, _NoiseTexture));
                float3 _Noise_var = lerp( _BeamTexture_var.rgb, (_BeamTexture_var.rgb*(node_6875.rgb*node_7481.rgb)), UNITY_ACCESS_INSTANCED_PROP( Props, _Noise ) );
                float4 _Color_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Color );
                float3 node_2843 = ((_Noise_var*_Color_var.rgb)*i.vertexColor.rgb);
                float3 diffuseColor = node_2843;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse;
                float node_2738 = (node_6875.a*node_7481.a);
                float _NoiseAlpha_var = lerp( _BeamTexture_var.r, node_2738, UNITY_ACCESS_INSTANCED_PROP( Props, _NoiseAlpha ) );
                float _LineOpacity_var = UNITY_ACCESS_INSTANCED_PROP( Props, _LineOpacity );
                fixed4 finalRGBA = fixed4(finalColor * (i.vertexColor.a*(_NoiseAlpha_var*_LineOpacity_var)),0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
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
            #pragma multi_compile_fog
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
