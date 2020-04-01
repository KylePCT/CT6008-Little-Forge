// Shader created with Shader Forge v1.40 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.40;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,cpap:True,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:4013,x:34211,y:32439,varname:node_4013,prsc:2|diff-9-OUT,emission-5639-OUT,alpha-979-OUT;n:type:ShaderForge.SFN_Tex2d,id:7361,x:32326,y:32581,varname:node_7361,prsc:2,tex:0720b0829dad0964e82955a2ae986627,ntxv:0,isnm:False|UVIN-4753-OUT,TEX-5590-TEX;n:type:ShaderForge.SFN_FragmentPosition,id:8905,x:31288,y:32840,varname:node_8905,prsc:2;n:type:ShaderForge.SFN_Append,id:4779,x:31469,y:32840,varname:node_4779,prsc:2|A-8905-X,B-8905-Z;n:type:ShaderForge.SFN_Time,id:4864,x:31293,y:33145,varname:node_4864,prsc:2;n:type:ShaderForge.SFN_Append,id:6044,x:31657,y:33145,varname:node_6044,prsc:2|A-5765-OUT,B-5765-OUT;n:type:ShaderForge.SFN_Add,id:7473,x:31848,y:33145,varname:node_7473,prsc:2|A-4779-OUT,B-6044-OUT;n:type:ShaderForge.SFN_Tex2dAsset,id:5590,x:32038,y:32615,ptovrint:False,ptlb:Noise Texture,ptin:_NoiseTexture,varname:_NoiseTexture,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:0720b0829dad0964e82955a2ae986627,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Subtract,id:1081,x:31671,y:32840,varname:node_1081,prsc:2|A-4779-OUT,B-6044-OUT;n:type:ShaderForge.SFN_Vector1,id:1151,x:31671,y:32747,varname:node_1151,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Multiply,id:8497,x:31856,y:32840,varname:node_8497,prsc:2|A-1151-OUT,B-1081-OUT;n:type:ShaderForge.SFN_Tex2d,id:2911,x:32326,y:32712,varname:node_2911,prsc:2,tex:0720b0829dad0964e82955a2ae986627,ntxv:0,isnm:False|UVIN-2145-OUT,TEX-5590-TEX;n:type:ShaderForge.SFN_Multiply,id:9134,x:32520,y:32694,varname:node_9134,prsc:2|A-7361-RGB,B-2911-RGB;n:type:ShaderForge.SFN_RemapRangeAdvanced,id:296,x:32919,y:32859,varname:node_296,prsc:2|IN-6421-OUT,IMIN-6184-OUT,IMAX-7268-OUT,OMIN-981-OUT,OMAX-2053-OUT;n:type:ShaderForge.SFN_Slider,id:6184,x:32491,y:32943,ptovrint:False,ptlb:Cloud Cutoff Min,ptin:_CloudCutoffMin,varname:_CloudCutoffMin,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.1,max:1;n:type:ShaderForge.SFN_Slider,id:7268,x:32491,y:33046,ptovrint:False,ptlb:Cloud Cutoff Max,ptin:_CloudCutoffMax,varname:_CloudCutoffMax,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.4,max:1;n:type:ShaderForge.SFN_Desaturate,id:4975,x:33126,y:32859,varname:node_4975,prsc:2|COL-296-OUT;n:type:ShaderForge.SFN_Power,id:3188,x:33310,y:32859,varname:node_3188,prsc:2|VAL-4975-OUT,EXP-5418-OUT;n:type:ShaderForge.SFN_Slider,id:5418,x:33171,y:33060,ptovrint:False,ptlb:Cloud Softness,ptin:_CloudSoftness,varname:_CloudSoftness,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:5;n:type:ShaderForge.SFN_Slider,id:981,x:32491,y:33154,ptovrint:False,ptlb:Cloud Remap Min,ptin:_CloudRemapMin,varname:_CloudRemapMin,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.15,max:1;n:type:ShaderForge.SFN_Slider,id:2053,x:32491,y:33259,ptovrint:False,ptlb:Cloud Remap Max,ptin:_CloudRemapMax,varname:_CloudRemapMax,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.8,max:1;n:type:ShaderForge.SFN_Multiply,id:5765,x:31484,y:33145,varname:node_5765,prsc:2|A-4864-TSL,B-6021-OUT;n:type:ShaderForge.SFN_Slider,id:6021,x:31170,y:33303,ptovrint:False,ptlb:Cloud Blend Speed,ptin:_CloudBlendSpeed,varname:node_6021,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:1,cur:11.34653,max:20;n:type:ShaderForge.SFN_Tex2d,id:2160,x:32520,y:32511,ptovrint:False,ptlb:Circular Fade Texture,ptin:_CircularFadeTexture,varname:node_2160,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:533f1a91cd8fe6249ba6e6eb661466d5,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Clamp01,id:3845,x:33558,y:32945,varname:node_3845,prsc:2|IN-3188-OUT;n:type:ShaderForge.SFN_Multiply,id:6421,x:32736,y:32694,varname:node_6421,prsc:2|A-9134-OUT,B-2160-RGB;n:type:ShaderForge.SFN_OneMinus,id:979,x:33558,y:32769,varname:node_979,prsc:2|IN-3845-OUT;n:type:ShaderForge.SFN_Color,id:1208,x:33183,y:32452,ptovrint:False,ptlb:Cloud Colour,ptin:_CloudColour,varname:node_1208,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Multiply,id:4121,x:33416,y:32452,varname:node_4121,prsc:2|A-1208-RGB,B-979-OUT;n:type:ShaderForge.SFN_Multiply,id:2530,x:33632,y:32452,varname:node_2530,prsc:2|A-4121-OUT,B-6082-OUT;n:type:ShaderForge.SFN_Slider,id:3275,x:33084,y:32257,ptovrint:False,ptlb:Cloud Colour Intensity,ptin:_CloudColourIntensity,varname:node_3275,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_RemapRange,id:6082,x:33416,y:32257,varname:node_6082,prsc:2,frmn:0,frmx:1,tomn:10,tomx:150|IN-3275-OUT;n:type:ShaderForge.SFN_Divide,id:5639,x:33849,y:32540,varname:node_5639,prsc:2|A-2530-OUT,B-8167-OUT;n:type:ShaderForge.SFN_Vector1,id:8167,x:33681,y:32601,varname:node_8167,prsc:2,v1:25;n:type:ShaderForge.SFN_Desaturate,id:9,x:33849,y:32407,varname:node_9,prsc:2|COL-2530-OUT;n:type:ShaderForge.SFN_TexCoord,id:5178,x:31576,y:33397,varname:node_5178,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Panner,id:1489,x:31775,y:33397,varname:node_1489,prsc:2,spu:1,spv:0|UVIN-5178-UVOUT,DIST-1014-OUT;n:type:ShaderForge.SFN_Panner,id:4012,x:32003,y:33397,varname:node_4012,prsc:2,spu:0,spv:1|UVIN-1489-UVOUT,DIST-821-OUT;n:type:ShaderForge.SFN_Slider,id:6779,x:31309,y:33607,ptovrint:False,ptlb:X Speed,ptin:_XSpeed,varname:node_6779,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:10;n:type:ShaderForge.SFN_Color,id:1532,x:33512,y:32567,ptovrint:False,ptlb:node_8062_copy,ptin:_node_8062_copy,varname:_node_8062_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Slider,id:7854,x:31593,y:33713,ptovrint:False,ptlb:Y Speed,ptin:_YSpeed,varname:_node_6779_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:10;n:type:ShaderForge.SFN_Add,id:4753,x:32046,y:33145,varname:node_4753,prsc:2|A-7473-OUT,B-4012-UVOUT;n:type:ShaderForge.SFN_Multiply,id:2145,x:32038,y:32840,varname:node_2145,prsc:2|A-8497-OUT,B-4012-UVOUT;n:type:ShaderForge.SFN_RemapRange,id:1014,x:31627,y:33542,varname:node_1014,prsc:2,frmn:0,frmx:10,tomn:0,tomx:30|IN-6779-OUT;n:type:ShaderForge.SFN_RemapRange,id:821,x:31959,y:33679,varname:node_821,prsc:2,frmn:0,frmx:10,tomn:0,tomx:30|IN-7854-OUT;proporder:5590-6184-7268-981-2053-2160-5418-1208-3275-6021-6779-7854;pass:END;sub:END;*/

Shader "Shader Forge/KT_Clouds" {
    Properties {
        _NoiseTexture ("Noise Texture", 2D) = "white" {}
        _CloudCutoffMin ("Cloud Cutoff Min", Range(0, 1)) = 0.1
        _CloudCutoffMax ("Cloud Cutoff Max", Range(0, 1)) = 0.4
        _CloudRemapMin ("Cloud Remap Min", Range(0, 1)) = 0.15
        _CloudRemapMax ("Cloud Remap Max", Range(0, 1)) = 0.8
        _CircularFadeTexture ("Circular Fade Texture", 2D) = "white" {}
        _CloudSoftness ("Cloud Softness", Range(0, 5)) = 0
        _CloudColour ("Cloud Colour", Color) = (1,1,1,1)
        _CloudColourIntensity ("Cloud Colour Intensity", Range(0, 1)) = 1
        _CloudBlendSpeed ("Cloud Blend Speed", Range(1, 20)) = 11.34653
        _XSpeed ("X Speed", Range(0, 10)) = 0
        _YSpeed ("Y Speed", Range(0, 10)) = 0
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
            Blend One OneMinusSrcAlpha
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
            uniform sampler2D _NoiseTexture; uniform float4 _NoiseTexture_ST;
            uniform sampler2D _CircularFadeTexture; uniform float4 _CircularFadeTexture_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _CloudCutoffMin)
                UNITY_DEFINE_INSTANCED_PROP( float, _CloudCutoffMax)
                UNITY_DEFINE_INSTANCED_PROP( float, _CloudSoftness)
                UNITY_DEFINE_INSTANCED_PROP( float, _CloudRemapMin)
                UNITY_DEFINE_INSTANCED_PROP( float, _CloudRemapMax)
                UNITY_DEFINE_INSTANCED_PROP( float, _CloudBlendSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float4, _CloudColour)
                UNITY_DEFINE_INSTANCED_PROP( float, _CloudColourIntensity)
                UNITY_DEFINE_INSTANCED_PROP( float, _XSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float, _YSpeed)
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
                UNITY_FOG_COORDS(3)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
                i.normalDir = normalize(i.normalDir);
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
                float4 _CloudColour_var = UNITY_ACCESS_INSTANCED_PROP( Props, _CloudColour );
                float2 node_4779 = float2(i.posWorld.r,i.posWorld.b);
                float4 node_4864 = _Time;
                float _CloudBlendSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _CloudBlendSpeed );
                float node_5765 = (node_4864.r*_CloudBlendSpeed_var);
                float2 node_6044 = float2(node_5765,node_5765);
                float _YSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _YSpeed );
                float _XSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _XSpeed );
                float2 node_4012 = ((i.uv0+(_XSpeed_var*3.0+0.0)*float2(1,0))+(_YSpeed_var*3.0+0.0)*float2(0,1));
                float2 node_4753 = ((node_4779+node_6044)+node_4012);
                float4 node_7361 = tex2D(_NoiseTexture,TRANSFORM_TEX(node_4753, _NoiseTexture));
                float2 node_2145 = ((0.5*(node_4779-node_6044))*node_4012);
                float4 node_2911 = tex2D(_NoiseTexture,TRANSFORM_TEX(node_2145, _NoiseTexture));
                float4 _CircularFadeTexture_var = tex2D(_CircularFadeTexture,TRANSFORM_TEX(i.uv0, _CircularFadeTexture));
                float _CloudCutoffMin_var = UNITY_ACCESS_INSTANCED_PROP( Props, _CloudCutoffMin );
                float _CloudCutoffMax_var = UNITY_ACCESS_INSTANCED_PROP( Props, _CloudCutoffMax );
                float _CloudRemapMin_var = UNITY_ACCESS_INSTANCED_PROP( Props, _CloudRemapMin );
                float _CloudRemapMax_var = UNITY_ACCESS_INSTANCED_PROP( Props, _CloudRemapMax );
                float _CloudSoftness_var = UNITY_ACCESS_INSTANCED_PROP( Props, _CloudSoftness );
                float node_979 = (1.0 - saturate(pow(dot((_CloudRemapMin_var + ( (((node_7361.rgb*node_2911.rgb)*_CircularFadeTexture_var.rgb) - _CloudCutoffMin_var) * (_CloudRemapMax_var - _CloudRemapMin_var) ) / (_CloudCutoffMax_var - _CloudCutoffMin_var)),float3(0.3,0.59,0.11)),_CloudSoftness_var)));
                float _CloudColourIntensity_var = UNITY_ACCESS_INSTANCED_PROP( Props, _CloudColourIntensity );
                float3 node_2530 = ((_CloudColour_var.rgb*node_979)*(_CloudColourIntensity_var*140.0+10.0));
                float node_9 = dot(node_2530,float3(0.3,0.59,0.11));
                float3 diffuseColor = float3(node_9,node_9,node_9);
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
////// Emissive:
                float3 emissive = (node_2530/25.0);
/// Final Color:
                float3 finalColor = diffuse + emissive;
                fixed4 finalRGBA = fixed4(finalColor,node_979);
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
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdadd
            #pragma multi_compile_fog
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _NoiseTexture; uniform float4 _NoiseTexture_ST;
            uniform sampler2D _CircularFadeTexture; uniform float4 _CircularFadeTexture_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _CloudCutoffMin)
                UNITY_DEFINE_INSTANCED_PROP( float, _CloudCutoffMax)
                UNITY_DEFINE_INSTANCED_PROP( float, _CloudSoftness)
                UNITY_DEFINE_INSTANCED_PROP( float, _CloudRemapMin)
                UNITY_DEFINE_INSTANCED_PROP( float, _CloudRemapMax)
                UNITY_DEFINE_INSTANCED_PROP( float, _CloudBlendSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float4, _CloudColour)
                UNITY_DEFINE_INSTANCED_PROP( float, _CloudColourIntensity)
                UNITY_DEFINE_INSTANCED_PROP( float, _XSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float, _YSpeed)
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
                LIGHTING_COORDS(3,4)
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
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
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
/////// Diffuse:
                float NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float4 _CloudColour_var = UNITY_ACCESS_INSTANCED_PROP( Props, _CloudColour );
                float2 node_4779 = float2(i.posWorld.r,i.posWorld.b);
                float4 node_4864 = _Time;
                float _CloudBlendSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _CloudBlendSpeed );
                float node_5765 = (node_4864.r*_CloudBlendSpeed_var);
                float2 node_6044 = float2(node_5765,node_5765);
                float _YSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _YSpeed );
                float _XSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _XSpeed );
                float2 node_4012 = ((i.uv0+(_XSpeed_var*3.0+0.0)*float2(1,0))+(_YSpeed_var*3.0+0.0)*float2(0,1));
                float2 node_4753 = ((node_4779+node_6044)+node_4012);
                float4 node_7361 = tex2D(_NoiseTexture,TRANSFORM_TEX(node_4753, _NoiseTexture));
                float2 node_2145 = ((0.5*(node_4779-node_6044))*node_4012);
                float4 node_2911 = tex2D(_NoiseTexture,TRANSFORM_TEX(node_2145, _NoiseTexture));
                float4 _CircularFadeTexture_var = tex2D(_CircularFadeTexture,TRANSFORM_TEX(i.uv0, _CircularFadeTexture));
                float _CloudCutoffMin_var = UNITY_ACCESS_INSTANCED_PROP( Props, _CloudCutoffMin );
                float _CloudCutoffMax_var = UNITY_ACCESS_INSTANCED_PROP( Props, _CloudCutoffMax );
                float _CloudRemapMin_var = UNITY_ACCESS_INSTANCED_PROP( Props, _CloudRemapMin );
                float _CloudRemapMax_var = UNITY_ACCESS_INSTANCED_PROP( Props, _CloudRemapMax );
                float _CloudSoftness_var = UNITY_ACCESS_INSTANCED_PROP( Props, _CloudSoftness );
                float node_979 = (1.0 - saturate(pow(dot((_CloudRemapMin_var + ( (((node_7361.rgb*node_2911.rgb)*_CircularFadeTexture_var.rgb) - _CloudCutoffMin_var) * (_CloudRemapMax_var - _CloudRemapMin_var) ) / (_CloudCutoffMax_var - _CloudCutoffMin_var)),float3(0.3,0.59,0.11)),_CloudSoftness_var)));
                float _CloudColourIntensity_var = UNITY_ACCESS_INSTANCED_PROP( Props, _CloudColourIntensity );
                float3 node_2530 = ((_CloudColour_var.rgb*node_979)*(_CloudColourIntensity_var*140.0+10.0));
                float node_9 = dot(node_2530,float3(0.3,0.59,0.11));
                float3 diffuseColor = float3(node_9,node_9,node_9);
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse;
                fixed4 finalRGBA = fixed4(finalColor * node_979,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
