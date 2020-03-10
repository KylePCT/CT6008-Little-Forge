// Shader created with Shader Forge v1.40 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.40;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,cpap:True,lico:1,lgpr:1,limd:3,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:True,hqlp:False,rprd:True,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:False,igpj:True,qofs:1,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:2865,x:33292,y:32716,varname:node_2865,prsc:2|diff-3039-RGB,spec-9092-R,gloss-9092-A,normal-827-RGB,emission-1358-OUT,difocc-233-R,alpha-8806-OUT;n:type:ShaderForge.SFN_Tex2d,id:3039,x:32115,y:32086,ptovrint:False,ptlb:BaseColour,ptin:_BaseColour,varname:node_3039,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:827,x:32115,y:32264,ptovrint:False,ptlb:Normal,ptin:_Normal,varname:node_827,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:3,isnm:True;n:type:ShaderForge.SFN_Tex2d,id:9092,x:32115,y:32449,ptovrint:False,ptlb:Metallic_RoughnessOrGloss,ptin:_Metallic_RoughnessOrGloss,varname:node_9092,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:233,x:32115,y:32627,ptovrint:False,ptlb:AmbientOcclusion,ptin:_AmbientOcclusion,varname:node_233,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Fresnel,id:4837,x:31521,y:33012,varname:node_4837,prsc:2|NRM-6815-OUT,EXP-7257-OUT;n:type:ShaderForge.SFN_Slider,id:7257,x:31113,y:33047,ptovrint:False,ptlb:Fresnel Amount,ptin:_FresnelAmount,varname:node_7257,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:3.057401,max:10;n:type:ShaderForge.SFN_Color,id:9320,x:31307,y:32194,ptovrint:False,ptlb:Colour,ptin:_Colour,varname:node_9320,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.03448272,c2:1,c3:0,c4:1;n:type:ShaderForge.SFN_Multiply,id:729,x:32115,y:32790,varname:node_729,prsc:2|A-1773-OUT,B-4837-OUT;n:type:ShaderForge.SFN_SwitchProperty,id:8806,x:31851,y:33083,ptovrint:False,ptlb:Opacity,ptin:_Opacity,varname:node_8806,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-7327-OUT,B-4837-OUT;n:type:ShaderForge.SFN_Vector1,id:7327,x:31646,y:33213,varname:node_7327,prsc:2,v1:1;n:type:ShaderForge.SFN_NormalVector,id:3096,x:31020,y:32864,prsc:2,pt:False;n:type:ShaderForge.SFN_NormalBlend,id:2034,x:31307,y:32652,varname:node_2034,prsc:2|BSE-827-RGB,DTL-3096-OUT;n:type:ShaderForge.SFN_SwitchProperty,id:6815,x:31307,y:32815,ptovrint:False,ptlb:Mode,ptin:_Mode,varname:node_6815,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-2034-OUT,B-3096-OUT;n:type:ShaderForge.SFN_Time,id:4177,x:30958,y:32513,varname:node_4177,prsc:2;n:type:ShaderForge.SFN_Color,id:7386,x:31251,y:32355,ptovrint:False,ptlb:Colour 2,ptin:_Colour2,varname:node_7386,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_ValueProperty,id:5536,x:30958,y:32446,ptovrint:False,ptlb:Strobe_Speed,ptin:_Strobe_Speed,varname:node_5536,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:3;n:type:ShaderForge.SFN_Multiply,id:2240,x:31137,y:32513,varname:node_2240,prsc:2|A-5536-OUT,B-4177-T;n:type:ShaderForge.SFN_Sin,id:1322,x:31307,y:32513,varname:node_1322,prsc:2|IN-2240-OUT;n:type:ShaderForge.SFN_RemapRange,id:5671,x:31476,y:32513,varname:node_5671,prsc:2,frmn:-1,frmx:1,tomn:0,tomx:1|IN-1322-OUT;n:type:ShaderForge.SFN_Lerp,id:2997,x:31643,y:32390,varname:node_2997,prsc:2|A-9320-RGB,B-7386-RGB,T-5671-OUT;n:type:ShaderForge.SFN_SwitchProperty,id:1773,x:31805,y:32354,ptovrint:False,ptlb:Between Two Colours,ptin:_BetweenTwoColours,varname:node_1773,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-9320-RGB,B-2997-OUT;n:type:ShaderForge.SFN_Multiply,id:9981,x:32651,y:32945,varname:node_9981,prsc:2|A-1655-OUT,B-3387-OUT;n:type:ShaderForge.SFN_Slider,id:3387,x:32227,y:33185,ptovrint:False,ptlb:Emissive,ptin:_Emissive,varname:node_3387,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:1,cur:1,max:15;n:type:ShaderForge.SFN_TexCoord,id:6707,x:32095,y:33313,varname:node_6707,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Tex2d,id:1263,x:32433,y:33458,ptovrint:False,ptlb:Noise,ptin:_Noise,varname:node_1263,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-234-OUT;n:type:ShaderForge.SFN_Multiply,id:6869,x:32433,y:33315,varname:node_6869,prsc:2|A-729-OUT,B-1263-RGB;n:type:ShaderForge.SFN_Slider,id:3707,x:31567,y:33431,ptovrint:False,ptlb:U Panning Speed,ptin:_UPanningSpeed,varname:node_3707,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-1,cur:0,max:1;n:type:ShaderForge.SFN_Slider,id:5555,x:31567,y:33523,ptovrint:False,ptlb:V Panning Speed,ptin:_VPanningSpeed,varname:_UPanningSpeed_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-1,cur:0,max:1;n:type:ShaderForge.SFN_Append,id:4191,x:31908,y:33458,varname:node_4191,prsc:2|A-3707-OUT,B-5555-OUT;n:type:ShaderForge.SFN_Multiply,id:6336,x:32095,y:33458,varname:node_6336,prsc:2|A-4191-OUT,B-4177-T;n:type:ShaderForge.SFN_Add,id:234,x:32265,y:33458,varname:node_234,prsc:2|A-6707-UVOUT,B-6336-OUT;n:type:ShaderForge.SFN_SwitchProperty,id:1655,x:32418,y:32945,ptovrint:False,ptlb:UV_Panning,ptin:_UV_Panning,varname:node_1655,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-729-OUT,B-6869-OUT;n:type:ShaderForge.SFN_Vector1,id:3896,x:32761,y:33134,varname:node_3896,prsc:2,v1:0;n:type:ShaderForge.SFN_SwitchProperty,id:1358,x:32972,y:32962,ptovrint:False,ptlb:Fresnel,ptin:_Fresnel,varname:_Opacity_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-3896-OUT,B-9981-OUT;proporder:3039-827-9092-233-1263-6815-7257-8806-1773-9320-7386-5536-3387-1655-3707-5555-1358;pass:END;sub:END;*/

Shader "Shader Forge/Colour_Tint_Shader_PBR" {
    Properties {
        _BaseColour ("BaseColour", 2D) = "white" {}
        _Normal ("Normal", 2D) = "bump" {}
        _Metallic_RoughnessOrGloss ("Metallic_RoughnessOrGloss", 2D) = "white" {}
        _AmbientOcclusion ("AmbientOcclusion", 2D) = "white" {}
        _Noise ("Noise", 2D) = "white" {}
        [MaterialToggle] _Mode ("Mode", Float ) = 0
        _FresnelAmount ("Fresnel Amount", Range(0, 10)) = 3.057401
        [MaterialToggle] _Opacity ("Opacity", Float ) = 1
        [MaterialToggle] _BetweenTwoColours ("Between Two Colours", Float ) = 0.03448272
        _Colour ("Colour", Color) = (0.03448272,1,0,1)
        _Colour2 ("Colour 2", Color) = (1,1,1,1)
        _Strobe_Speed ("Strobe_Speed", Float ) = 3
        _Emissive ("Emissive", Range(1, 15)) = 1
        [MaterialToggle] _UV_Panning ("UV_Panning", Float ) = 0
        _UPanningSpeed ("U Panning Speed", Range(-1, 1)) = 0
        _VPanningSpeed ("V Panning Speed", Range(-1, 1)) = 0
        [MaterialToggle] _Fresnel ("Fresnel", Float ) = 0
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent+1"
            "RenderType"="Transparent"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma target 3.0
            uniform sampler2D _BaseColour; uniform float4 _BaseColour_ST;
            uniform sampler2D _Normal; uniform float4 _Normal_ST;
            uniform sampler2D _Metallic_RoughnessOrGloss; uniform float4 _Metallic_RoughnessOrGloss_ST;
            uniform sampler2D _AmbientOcclusion; uniform float4 _AmbientOcclusion_ST;
            uniform sampler2D _Noise; uniform float4 _Noise_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _FresnelAmount)
                UNITY_DEFINE_INSTANCED_PROP( float4, _Colour)
                UNITY_DEFINE_INSTANCED_PROP( fixed, _Opacity)
                UNITY_DEFINE_INSTANCED_PROP( fixed, _Mode)
                UNITY_DEFINE_INSTANCED_PROP( float4, _Colour2)
                UNITY_DEFINE_INSTANCED_PROP( float, _Strobe_Speed)
                UNITY_DEFINE_INSTANCED_PROP( fixed, _BetweenTwoColours)
                UNITY_DEFINE_INSTANCED_PROP( float, _Emissive)
                UNITY_DEFINE_INSTANCED_PROP( float, _UPanningSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float, _VPanningSpeed)
                UNITY_DEFINE_INSTANCED_PROP( fixed, _UV_Panning)
                UNITY_DEFINE_INSTANCED_PROP( fixed, _Fresnel)
            UNITY_INSTANCING_BUFFER_END( Props )
            struct VertexInput {
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
                float3 tangentDir : TEXCOORD5;
                float3 bitangentDir : TEXCOORD6;
                UNITY_FOG_COORDS(7)
                #if defined(LIGHTMAP_ON) || defined(UNITY_SHOULD_SAMPLE_SH)
                    float4 ambientOrLightmapUV : TEXCOORD8;
                #endif
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                #ifdef LIGHTMAP_ON
                    o.ambientOrLightmapUV.xy = v.texcoord1.xy * unity_LightmapST.xy + unity_LightmapST.zw;
                    o.ambientOrLightmapUV.zw = 0;
                #elif UNITY_SHOULD_SAMPLE_SH
                #endif
                #ifdef DYNAMICLIGHTMAP_ON
                    o.ambientOrLightmapUV.zw = v.texcoord2.xy * unity_DynamicLightmapST.xy + unity_DynamicLightmapST.zw;
                #endif
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 _Normal_var = UnpackNormal(tex2D(_Normal,TRANSFORM_TEX(i.uv0, _Normal)));
                float3 normalLocal = _Normal_var.rgb;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = 1;
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float4 _Metallic_RoughnessOrGloss_var = tex2D(_Metallic_RoughnessOrGloss,TRANSFORM_TEX(i.uv0, _Metallic_RoughnessOrGloss));
                float gloss = _Metallic_RoughnessOrGloss_var.a;
                float perceptualRoughness = 1.0 - _Metallic_RoughnessOrGloss_var.a;
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
/////// GI Data:
                UnityLight light;
                #ifdef LIGHTMAP_OFF
                    light.color = lightColor;
                    light.dir = lightDirection;
                    light.ndotl = LambertTerm (normalDirection, light.dir);
                #else
                    light.color = half3(0.f, 0.f, 0.f);
                    light.ndotl = 0.0f;
                    light.dir = half3(0.f, 0.f, 0.f);
                #endif
                UnityGIInput d;
                d.light = light;
                d.worldPos = i.posWorld.xyz;
                d.worldViewDir = viewDirection;
                d.atten = attenuation;
                #if defined(LIGHTMAP_ON) || defined(DYNAMICLIGHTMAP_ON)
                    d.ambient = 0;
                    d.lightmapUV = i.ambientOrLightmapUV;
                #else
                    d.ambient = i.ambientOrLightmapUV;
                #endif
                #if UNITY_SPECCUBE_BLENDING || UNITY_SPECCUBE_BOX_PROJECTION
                    d.boxMin[0] = unity_SpecCube0_BoxMin;
                    d.boxMin[1] = unity_SpecCube1_BoxMin;
                #endif
                #if UNITY_SPECCUBE_BOX_PROJECTION
                    d.boxMax[0] = unity_SpecCube0_BoxMax;
                    d.boxMax[1] = unity_SpecCube1_BoxMax;
                    d.probePosition[0] = unity_SpecCube0_ProbePosition;
                    d.probePosition[1] = unity_SpecCube1_ProbePosition;
                #endif
                d.probeHDR[0] = unity_SpecCube0_HDR;
                d.probeHDR[1] = unity_SpecCube1_HDR;
                Unity_GlossyEnvironmentData ugls_en_data;
                ugls_en_data.roughness = 1.0 - gloss;
                ugls_en_data.reflUVW = viewReflectDirection;
                UnityGI gi = UnityGlobalIllumination(d, 1, normalDirection, ugls_en_data );
                lightDirection = gi.light.dir;
                lightColor = gi.light.color;
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float3 specularColor = _Metallic_RoughnessOrGloss_var.r;
                float specularMonochrome;
                float4 _BaseColour_var = tex2D(_BaseColour,TRANSFORM_TEX(i.uv0, _BaseColour));
                float3 diffuseColor = _BaseColour_var.rgb; // Need this for specular when using metallic
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, specularColor, specularColor, specularMonochrome );
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                half surfaceReduction;
                #ifdef UNITY_COLORSPACE_GAMMA
                    surfaceReduction = 1.0-0.28*roughness*perceptualRoughness;
                #else
                    surfaceReduction = 1.0/(roughness*roughness + 1.0);
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                half grazingTerm = saturate( gloss + specularMonochrome );
                float3 indirectSpecular = (gi.indirect.specular);
                indirectSpecular *= FresnelLerp (specularColor, grazingTerm, NdotV);
                indirectSpecular *= surfaceReduction;
                float3 specular = (directSpecular + indirectSpecular);
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += gi.indirect.diffuse;
                float4 _AmbientOcclusion_var = tex2D(_AmbientOcclusion,TRANSFORM_TEX(i.uv0, _AmbientOcclusion));
                indirectDiffuse *= _AmbientOcclusion_var.r; // Diffuse AO
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
////// Emissive:
                float4 _Colour_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Colour );
                float4 _Colour2_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Colour2 );
                float _Strobe_Speed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Strobe_Speed );
                float4 node_4177 = _Time;
                float3 _BetweenTwoColours_var = lerp( _Colour_var.rgb, lerp(_Colour_var.rgb,_Colour2_var.rgb,(sin((_Strobe_Speed_var*node_4177.g))*0.5+0.5)), UNITY_ACCESS_INSTANCED_PROP( Props, _BetweenTwoColours ) );
                float3 node_2034_nrm_base = _Normal_var.rgb + float3(0,0,1);
                float3 node_2034_nrm_detail = i.normalDir * float3(-1,-1,1);
                float3 node_2034_nrm_combined = node_2034_nrm_base*dot(node_2034_nrm_base, node_2034_nrm_detail)/node_2034_nrm_base.z - node_2034_nrm_detail;
                float3 node_2034 = node_2034_nrm_combined;
                float3 _Mode_var = lerp( node_2034, i.normalDir, UNITY_ACCESS_INSTANCED_PROP( Props, _Mode ) );
                float _FresnelAmount_var = UNITY_ACCESS_INSTANCED_PROP( Props, _FresnelAmount );
                float node_4837 = pow(1.0-max(0,dot(_Mode_var, viewDirection)),_FresnelAmount_var);
                float3 node_729 = (_BetweenTwoColours_var*node_4837);
                float _UPanningSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _UPanningSpeed );
                float _VPanningSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _VPanningSpeed );
                float2 node_234 = (i.uv0+(float2(_UPanningSpeed_var,_VPanningSpeed_var)*node_4177.g));
                float4 _Noise_var = tex2D(_Noise,TRANSFORM_TEX(node_234, _Noise));
                float3 _UV_Panning_var = lerp( node_729, (node_729*_Noise_var.rgb), UNITY_ACCESS_INSTANCED_PROP( Props, _UV_Panning ) );
                float _Emissive_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Emissive );
                float3 _Fresnel_var = lerp( 0.0, (_UV_Panning_var*_Emissive_var), UNITY_ACCESS_INSTANCED_PROP( Props, _Fresnel ) );
                float3 emissive = _Fresnel_var;
/// Final Color:
                float3 finalColor = diffuse + specular + emissive;
                float _Opacity_var = lerp( 1.0, node_4837, UNITY_ACCESS_INSTANCED_PROP( Props, _Opacity ) );
                fixed4 finalRGBA = fixed4(finalColor,_Opacity_var);
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
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdadd
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma target 3.0
            uniform sampler2D _BaseColour; uniform float4 _BaseColour_ST;
            uniform sampler2D _Normal; uniform float4 _Normal_ST;
            uniform sampler2D _Metallic_RoughnessOrGloss; uniform float4 _Metallic_RoughnessOrGloss_ST;
            uniform sampler2D _Noise; uniform float4 _Noise_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _FresnelAmount)
                UNITY_DEFINE_INSTANCED_PROP( float4, _Colour)
                UNITY_DEFINE_INSTANCED_PROP( fixed, _Opacity)
                UNITY_DEFINE_INSTANCED_PROP( fixed, _Mode)
                UNITY_DEFINE_INSTANCED_PROP( float4, _Colour2)
                UNITY_DEFINE_INSTANCED_PROP( float, _Strobe_Speed)
                UNITY_DEFINE_INSTANCED_PROP( fixed, _BetweenTwoColours)
                UNITY_DEFINE_INSTANCED_PROP( float, _Emissive)
                UNITY_DEFINE_INSTANCED_PROP( float, _UPanningSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float, _VPanningSpeed)
                UNITY_DEFINE_INSTANCED_PROP( fixed, _UV_Panning)
                UNITY_DEFINE_INSTANCED_PROP( fixed, _Fresnel)
            UNITY_INSTANCING_BUFFER_END( Props )
            struct VertexInput {
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
                float3 tangentDir : TEXCOORD5;
                float3 bitangentDir : TEXCOORD6;
                LIGHTING_COORDS(7,8)
                UNITY_FOG_COORDS(9)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 _Normal_var = UnpackNormal(tex2D(_Normal,TRANSFORM_TEX(i.uv0, _Normal)));
                float3 normalLocal = _Normal_var.rgb;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float4 _Metallic_RoughnessOrGloss_var = tex2D(_Metallic_RoughnessOrGloss,TRANSFORM_TEX(i.uv0, _Metallic_RoughnessOrGloss));
                float gloss = _Metallic_RoughnessOrGloss_var.a;
                float perceptualRoughness = 1.0 - _Metallic_RoughnessOrGloss_var.a;
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float3 specularColor = _Metallic_RoughnessOrGloss_var.r;
                float specularMonochrome;
                float4 _BaseColour_var = tex2D(_BaseColour,TRANSFORM_TEX(i.uv0, _BaseColour));
                float3 diffuseColor = _BaseColour_var.rgb; // Need this for specular when using metallic
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, specularColor, specularColor, specularMonochrome );
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                float3 node_2034_nrm_base = _Normal_var.rgb + float3(0,0,1);
                float3 node_2034_nrm_detail = i.normalDir * float3(-1,-1,1);
                float3 node_2034_nrm_combined = node_2034_nrm_base*dot(node_2034_nrm_base, node_2034_nrm_detail)/node_2034_nrm_base.z - node_2034_nrm_detail;
                float3 node_2034 = node_2034_nrm_combined;
                float3 _Mode_var = lerp( node_2034, i.normalDir, UNITY_ACCESS_INSTANCED_PROP( Props, _Mode ) );
                float _FresnelAmount_var = UNITY_ACCESS_INSTANCED_PROP( Props, _FresnelAmount );
                float node_4837 = pow(1.0-max(0,dot(_Mode_var, viewDirection)),_FresnelAmount_var);
                float _Opacity_var = lerp( 1.0, node_4837, UNITY_ACCESS_INSTANCED_PROP( Props, _Opacity ) );
                fixed4 finalRGBA = fixed4(finalColor * _Opacity_var,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "Meta"
            Tags {
                "LightMode"="Meta"
            }
            Cull Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_META 1
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #include "UnityMetaPass.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma target 3.0
            uniform sampler2D _BaseColour; uniform float4 _BaseColour_ST;
            uniform sampler2D _Normal; uniform float4 _Normal_ST;
            uniform sampler2D _Metallic_RoughnessOrGloss; uniform float4 _Metallic_RoughnessOrGloss_ST;
            uniform sampler2D _Noise; uniform float4 _Noise_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _FresnelAmount)
                UNITY_DEFINE_INSTANCED_PROP( float4, _Colour)
                UNITY_DEFINE_INSTANCED_PROP( fixed, _Mode)
                UNITY_DEFINE_INSTANCED_PROP( float4, _Colour2)
                UNITY_DEFINE_INSTANCED_PROP( float, _Strobe_Speed)
                UNITY_DEFINE_INSTANCED_PROP( fixed, _BetweenTwoColours)
                UNITY_DEFINE_INSTANCED_PROP( float, _Emissive)
                UNITY_DEFINE_INSTANCED_PROP( float, _UPanningSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float, _VPanningSpeed)
                UNITY_DEFINE_INSTANCED_PROP( fixed, _UV_Panning)
                UNITY_DEFINE_INSTANCED_PROP( fixed, _Fresnel)
            UNITY_INSTANCING_BUFFER_END( Props )
            struct VertexInput {
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityMetaVertexPosition(v.vertex, v.texcoord1.xy, v.texcoord2.xy, unity_LightmapST, unity_DynamicLightmapST );
                return o;
            }
            float4 frag(VertexOutput i) : SV_Target {
                UNITY_SETUP_INSTANCE_ID( i );
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                UnityMetaInput o;
                UNITY_INITIALIZE_OUTPUT( UnityMetaInput, o );
                
                float4 _Colour_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Colour );
                float4 _Colour2_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Colour2 );
                float _Strobe_Speed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Strobe_Speed );
                float4 node_4177 = _Time;
                float3 _BetweenTwoColours_var = lerp( _Colour_var.rgb, lerp(_Colour_var.rgb,_Colour2_var.rgb,(sin((_Strobe_Speed_var*node_4177.g))*0.5+0.5)), UNITY_ACCESS_INSTANCED_PROP( Props, _BetweenTwoColours ) );
                float3 _Normal_var = UnpackNormal(tex2D(_Normal,TRANSFORM_TEX(i.uv0, _Normal)));
                float3 node_2034_nrm_base = _Normal_var.rgb + float3(0,0,1);
                float3 node_2034_nrm_detail = i.normalDir * float3(-1,-1,1);
                float3 node_2034_nrm_combined = node_2034_nrm_base*dot(node_2034_nrm_base, node_2034_nrm_detail)/node_2034_nrm_base.z - node_2034_nrm_detail;
                float3 node_2034 = node_2034_nrm_combined;
                float3 _Mode_var = lerp( node_2034, i.normalDir, UNITY_ACCESS_INSTANCED_PROP( Props, _Mode ) );
                float _FresnelAmount_var = UNITY_ACCESS_INSTANCED_PROP( Props, _FresnelAmount );
                float node_4837 = pow(1.0-max(0,dot(_Mode_var, viewDirection)),_FresnelAmount_var);
                float3 node_729 = (_BetweenTwoColours_var*node_4837);
                float _UPanningSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _UPanningSpeed );
                float _VPanningSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _VPanningSpeed );
                float2 node_234 = (i.uv0+(float2(_UPanningSpeed_var,_VPanningSpeed_var)*node_4177.g));
                float4 _Noise_var = tex2D(_Noise,TRANSFORM_TEX(node_234, _Noise));
                float3 _UV_Panning_var = lerp( node_729, (node_729*_Noise_var.rgb), UNITY_ACCESS_INSTANCED_PROP( Props, _UV_Panning ) );
                float _Emissive_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Emissive );
                float3 _Fresnel_var = lerp( 0.0, (_UV_Panning_var*_Emissive_var), UNITY_ACCESS_INSTANCED_PROP( Props, _Fresnel ) );
                o.Emission = _Fresnel_var;
                
                float4 _BaseColour_var = tex2D(_BaseColour,TRANSFORM_TEX(i.uv0, _BaseColour));
                float3 diffColor = _BaseColour_var.rgb;
                float specularMonochrome;
                float3 specColor;
                float4 _Metallic_RoughnessOrGloss_var = tex2D(_Metallic_RoughnessOrGloss,TRANSFORM_TEX(i.uv0, _Metallic_RoughnessOrGloss));
                diffColor = DiffuseAndSpecularFromMetallic( diffColor, _Metallic_RoughnessOrGloss_var.r, specColor, specularMonochrome );
                float roughness = 1.0 - _Metallic_RoughnessOrGloss_var.a;
                o.Albedo = diffColor + specColor * roughness * roughness * 0.5;
                
                return UnityMetaFragment( o );
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
