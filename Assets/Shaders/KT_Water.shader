// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Shader created with Shader Forge v1.40 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.40;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,cpap:True,lico:1,lgpr:1,limd:3,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:True,hqlp:False,rprd:True,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:2865,x:34754,y:32890,varname:node_2865,prsc:2|diff-4234-OUT,spec-1279-OUT,gloss-2806-OUT,alpha-4954-OUT,voffset-1120-OUT,tess-423-OUT;n:type:ShaderForge.SFN_ValueProperty,id:1279,x:34323,y:32955,ptovrint:False,ptlb:Metallic,ptin:_Metallic,varname:node_1279,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:2806,x:34323,y:33042,ptovrint:False,ptlb:Roughness,ptin:_Roughness,varname:_Metallic_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Color,id:3681,x:31862,y:32116,ptovrint:False,ptlb:Foam Colour,ptin:_FoamColour,varname:node_3681,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0,c3:0.5,c4:1;n:type:ShaderForge.SFN_Color,id:8607,x:31430,y:32289,ptovrint:False,ptlb:Water Colour,ptin:_WaterColour,varname:_RiverBase_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:1,c3:0.5,c4:1;n:type:ShaderForge.SFN_Lerp,id:9742,x:32156,y:32398,varname:node_9742,prsc:2|A-3681-RGB,B-1385-OUT,T-2943-OUT;n:type:ShaderForge.SFN_ValueProperty,id:8568,x:31185,y:32820,ptovrint:False,ptlb:Depth Value,ptin:_DepthValue,varname:node_8568,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:10;n:type:ShaderForge.SFN_DepthBlend,id:4369,x:31466,y:32826,varname:node_4369,prsc:2|DIST-8568-OUT;n:type:ShaderForge.SFN_Divide,id:7369,x:31720,y:32794,varname:node_7369,prsc:2|A-4369-OUT,B-3698-OUT;n:type:ShaderForge.SFN_Dot,id:3698,x:31428,y:33015,varname:node_3698,prsc:2,dt:0|A-3561-OUT,B-8493-OUT;n:type:ShaderForge.SFN_ViewVector,id:3561,x:31214,y:32948,varname:node_3561,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:8493,x:31214,y:33107,prsc:2,pt:False;n:type:ShaderForge.SFN_RemapRangeAdvanced,id:5407,x:31707,y:33054,varname:node_5407,prsc:2|IN-2943-OUT,IMIN-2227-OUT,IMAX-2069-OUT,OMIN-2446-OUT,OMAX-704-OUT;n:type:ShaderForge.SFN_Clamp01,id:2943,x:31955,y:32794,varname:node_2943,prsc:2|IN-7369-OUT;n:type:ShaderForge.SFN_Slider,id:2227,x:31245,y:33358,ptovrint:False,ptlb:Foam Minimum,ptin:_FoamMinimum,varname:node_2227,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Slider,id:2069,x:31245,y:33462,ptovrint:False,ptlb:Foam Maximum,ptin:_FoamMaximum,varname:_FoamMinimum_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Vector1,id:2446,x:31245,y:33554,varname:node_2446,prsc:2,v1:0;n:type:ShaderForge.SFN_Vector1,id:704,x:31402,y:33554,varname:node_704,prsc:2,v1:1;n:type:ShaderForge.SFN_RemapRangeAdvanced,id:5036,x:32424,y:33412,varname:node_5036,prsc:2|IN-2943-OUT,IMIN-7286-OUT,IMAX-8393-OUT,OMIN-552-OUT,OMAX-3187-OUT;n:type:ShaderForge.SFN_Vector1,id:552,x:31808,y:33835,varname:node_552,prsc:2,v1:0;n:type:ShaderForge.SFN_Vector1,id:3187,x:31960,y:33835,varname:node_3187,prsc:2,v1:1;n:type:ShaderForge.SFN_Slider,id:7286,x:31803,y:33639,ptovrint:False,ptlb:Depth Minimum,ptin:_DepthMinimum,varname:node_7286,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Slider,id:8393,x:31803,y:33754,ptovrint:False,ptlb:Depth Maximum,ptin:_DepthMaximum,varname:node_8393,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Clamp01,id:3114,x:31872,y:33054,varname:node_3114,prsc:2|IN-5407-OUT;n:type:ShaderForge.SFN_ComponentMask,id:2880,x:32550,y:33019,varname:node_2880,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-8988-OUT;n:type:ShaderForge.SFN_Multiply,id:4505,x:32723,y:33019,varname:node_4505,prsc:2|A-2880-OUT,B-2498-OUT;n:type:ShaderForge.SFN_Vector1,id:2498,x:32550,y:33194,varname:node_2498,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Clamp01,id:4954,x:33082,y:33019,varname:node_4954,prsc:2|IN-4969-OUT;n:type:ShaderForge.SFN_Multiply,id:6377,x:32339,y:33063,varname:node_6377,prsc:2|A-2515-OUT,B-4629-OUT;n:type:ShaderForge.SFN_ValueProperty,id:4629,x:32154,y:33204,ptovrint:False,ptlb:Foam Intensity,ptin:_FoamIntensity,varname:node_4629,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:8;n:type:ShaderForge.SFN_Add,id:4234,x:32737,y:32717,varname:node_4234,prsc:2|A-9742-OUT,B-8988-OUT;n:type:ShaderForge.SFN_Add,id:4969,x:32899,y:33019,varname:node_4969,prsc:2|A-4505-OUT,B-5036-OUT;n:type:ShaderForge.SFN_OneMinus,id:7200,x:32040,y:33054,varname:node_7200,prsc:2|IN-3114-OUT;n:type:ShaderForge.SFN_Clamp01,id:8988,x:32424,y:32859,varname:node_8988,prsc:2|IN-6377-OUT;n:type:ShaderForge.SFN_Multiply,id:6242,x:32365,y:32399,varname:node_6242,prsc:2|A-9742-OUT,B-3473-RGB;n:type:ShaderForge.SFN_Tex2d,id:3473,x:32156,y:32572,ptovrint:False,ptlb:Foam Texture,ptin:_FoamTexture,varname:node_3473,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-4125-OUT;n:type:ShaderForge.SFN_Multiply,id:2515,x:32545,y:32399,varname:node_2515,prsc:2|A-6242-OUT,B-7200-OUT;n:type:ShaderForge.SFN_Slider,id:423,x:34155,y:33293,ptovrint:False,ptlb:Plane Tessellation,ptin:_PlaneTessellation,varname:node_423,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:10;n:type:ShaderForge.SFN_TexCoord,id:7272,x:32779,y:33363,varname:node_7272,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Time,id:8728,x:32401,y:33560,varname:node_8728,prsc:2;n:type:ShaderForge.SFN_Panner,id:7278,x:33007,y:33466,varname:node_7278,prsc:2,spu:0.5,spv:0.5|UVIN-7272-UVOUT,DIST-8728-TSL;n:type:ShaderForge.SFN_Tex2d,id:2753,x:33192,y:33466,ptovrint:False,ptlb:Wave Noise,ptin:_WaveNoise,varname:node_2753,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:877bc628b69844ba081a63095156a6f1,ntxv:0,isnm:False|UVIN-7278-UVOUT;n:type:ShaderForge.SFN_FragmentPosition,id:6659,x:32806,y:33730,varname:node_6659,prsc:2;n:type:ShaderForge.SFN_Add,id:4808,x:32986,y:33667,varname:node_4808,prsc:2|A-249-OUT,B-6659-XYZ;n:type:ShaderForge.SFN_Multiply,id:554,x:33167,y:33667,varname:node_554,prsc:2|A-4808-OUT,B-1667-OUT;n:type:ShaderForge.SFN_ValueProperty,id:1667,x:32962,y:33897,ptovrint:False,ptlb:Wave Count,ptin:_WaveCount,varname:node_1667,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:10;n:type:ShaderForge.SFN_Sin,id:2396,x:33336,y:33667,varname:node_2396,prsc:2|IN-554-OUT;n:type:ShaderForge.SFN_Multiply,id:8373,x:33504,y:33667,varname:node_8373,prsc:2|A-2396-OUT,B-5244-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5244,x:33318,y:33901,ptovrint:False,ptlb:Wave Spread,ptin:_WaveSpread,varname:_WaveCount_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.3;n:type:ShaderForge.SFN_Add,id:339,x:33682,y:33667,varname:node_339,prsc:2|A-8373-OUT,B-8872-OUT;n:type:ShaderForge.SFN_ValueProperty,id:8872,x:33524,y:33901,ptovrint:False,ptlb:Wave Intensity,ptin:_WaveIntensity,varname:_WaveSpread_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:10;n:type:ShaderForge.SFN_RemapRange,id:2222,x:33870,y:33667,varname:node_2222,prsc:2,frmn:-1,frmx:1,tomn:0,tomx:1|IN-339-OUT;n:type:ShaderForge.SFN_Multiply,id:6003,x:33999,y:33491,varname:node_6003,prsc:2|A-2753-RGB,B-2222-OUT;n:type:ShaderForge.SFN_Multiply,id:2144,x:34209,y:33491,varname:node_2144,prsc:2|A-6003-OUT,B-819-OUT;n:type:ShaderForge.SFN_Slider,id:1690,x:33760,y:33885,ptovrint:False,ptlb:Wave Height,ptin:_WaveHeight,varname:node_1690,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.5,max:1;n:type:ShaderForge.SFN_Multiply,id:249,x:32594,y:33652,varname:node_249,prsc:2|A-8728-TSL,B-7233-OUT;n:type:ShaderForge.SFN_ValueProperty,id:7233,x:32411,y:33788,ptovrint:False,ptlb:Wave Speed,ptin:_WaveSpeed,varname:node_7233,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Vector1,id:4410,x:34209,y:33625,varname:node_4410,prsc:2,v1:0;n:type:ShaderForge.SFN_Append,id:1120,x:34437,y:33491,varname:node_1120,prsc:2|A-4410-OUT,B-2144-OUT;n:type:ShaderForge.SFN_Tex2d,id:4698,x:31430,y:32109,ptovrint:False,ptlb:Water Texture,ptin:_WaterTexture,varname:node_4698,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:f92dae6af310c124c82b4c415dc12dd2,ntxv:0,isnm:False|UVIN-4125-OUT;n:type:ShaderForge.SFN_Multiply,id:1385,x:31618,y:32208,varname:node_1385,prsc:2|A-4698-RGB,B-8607-RGB;n:type:ShaderForge.SFN_TexCoord,id:8676,x:31033,y:32163,varname:node_8676,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Slider,id:4848,x:30484,y:32292,ptovrint:False,ptlb:U Tiling Amount,ptin:_UTilingAmount,varname:node_4848,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Slider,id:6162,x:30484,y:32385,ptovrint:False,ptlb:V Tiling Amount,ptin:_VTilingAmount,varname:_node_4848_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Append,id:4704,x:30842,y:32312,varname:node_4704,prsc:2|A-4848-OUT,B-6162-OUT;n:type:ShaderForge.SFN_Multiply,id:3456,x:31033,y:32312,varname:node_3456,prsc:2|A-4704-OUT,B-1838-TSL;n:type:ShaderForge.SFN_Time,id:1838,x:30842,y:32468,varname:node_1838,prsc:2;n:type:ShaderForge.SFN_Add,id:4125,x:31208,y:32312,varname:node_4125,prsc:2|A-8676-UVOUT,B-3456-OUT;n:type:ShaderForge.SFN_RemapRange,id:819,x:34103,y:33884,varname:node_819,prsc:2,frmn:0,frmx:1,tomn:0,tomx:0.05|IN-1690-OUT;proporder:4698-8607-3681-1279-2806-423-8568-7286-8393-3473-2227-2069-4629-2753-1667-5244-1690-7233-8872-4848-6162;pass:END;sub:END;*/

Shader "Shader Forge/KT_Water" {
    Properties {
        _WaterTexture ("Water Texture", 2D) = "white" {}
        _WaterColour ("Water Colour", Color) = (0.5,1,0.5,1)
        _FoamColour ("Foam Colour", Color) = (0.5,0,0.5,1)
        _Metallic ("Metallic", Float ) = 0
        _Roughness ("Roughness", Float ) = 0
        _PlaneTessellation ("Plane Tessellation", Range(0, 10)) = 0
        _DepthValue ("Depth Value", Float ) = 10
        _DepthMinimum ("Depth Minimum", Range(0, 1)) = 0
        _DepthMaximum ("Depth Maximum", Range(0, 1)) = 0
        _FoamTexture ("Foam Texture", 2D) = "white" {}
        _FoamMinimum ("Foam Minimum", Range(0, 1)) = 0
        _FoamMaximum ("Foam Maximum", Range(0, 1)) = 0
        _FoamIntensity ("Foam Intensity", Float ) = 8
        _WaveNoise ("Wave Noise", 2D) = "white" {}
        _WaveCount ("Wave Count", Float ) = 10
        _WaveSpread ("Wave Spread", Float ) = 0.3
        _WaveHeight ("Wave Height", Range(0, 1)) = 0.5
        _WaveSpeed ("Wave Speed", Float ) = 0
        _WaveIntensity ("Wave Intensity", Float ) = 10
        _UTilingAmount ("U Tiling Amount", Range(0, 1)) = 1
        _VTilingAmount ("V Tiling Amount", Range(0, 1)) = 1
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
            ZWrite Off
            
            CGPROGRAM
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "Tessellation.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma target 5.0
            uniform sampler2D _CameraDepthTexture;
            uniform sampler2D _FoamTexture; uniform float4 _FoamTexture_ST;
            uniform sampler2D _WaveNoise; uniform float4 _WaveNoise_ST;
            uniform sampler2D _WaterTexture; uniform float4 _WaterTexture_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _Metallic)
                UNITY_DEFINE_INSTANCED_PROP( float, _Roughness)
                UNITY_DEFINE_INSTANCED_PROP( float4, _FoamColour)
                UNITY_DEFINE_INSTANCED_PROP( float4, _WaterColour)
                UNITY_DEFINE_INSTANCED_PROP( float, _DepthValue)
                UNITY_DEFINE_INSTANCED_PROP( float, _FoamMinimum)
                UNITY_DEFINE_INSTANCED_PROP( float, _FoamMaximum)
                UNITY_DEFINE_INSTANCED_PROP( float, _DepthMinimum)
                UNITY_DEFINE_INSTANCED_PROP( float, _DepthMaximum)
                UNITY_DEFINE_INSTANCED_PROP( float, _FoamIntensity)
                UNITY_DEFINE_INSTANCED_PROP( float, _PlaneTessellation)
                UNITY_DEFINE_INSTANCED_PROP( float, _WaveCount)
                UNITY_DEFINE_INSTANCED_PROP( float, _WaveSpread)
                UNITY_DEFINE_INSTANCED_PROP( float, _WaveIntensity)
                UNITY_DEFINE_INSTANCED_PROP( float, _WaveHeight)
                UNITY_DEFINE_INSTANCED_PROP( float, _WaveSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float, _UTilingAmount)
                UNITY_DEFINE_INSTANCED_PROP( float, _VTilingAmount)
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
                float4 projPos : TEXCOORD7;
                UNITY_FOG_COORDS(8)
                #if defined(LIGHTMAP_ON) || defined(UNITY_SHOULD_SAMPLE_SH)
                    float4 ambientOrLightmapUV : TEXCOORD9;
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
                float4 node_8728 = _Time;
                float2 node_7278 = (o.uv0+node_8728.r*float2(0.5,0.5));
                float4 _WaveNoise_var = tex2Dlod(_WaveNoise,float4(TRANSFORM_TEX(node_7278, _WaveNoise),0.0,0));
                float _WaveSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _WaveSpeed );
                float _WaveCount_var = UNITY_ACCESS_INSTANCED_PROP( Props, _WaveCount );
                float _WaveSpread_var = UNITY_ACCESS_INSTANCED_PROP( Props, _WaveSpread );
                float _WaveIntensity_var = UNITY_ACCESS_INSTANCED_PROP( Props, _WaveIntensity );
                float _WaveHeight_var = UNITY_ACCESS_INSTANCED_PROP( Props, _WaveHeight );
                v.vertex.xyz += float4(0.0,((_WaveNoise_var.rgb*(((sin((((node_8728.r*_WaveSpeed_var)+mul(unity_ObjectToWorld, v.vertex).rgb)*_WaveCount_var))*_WaveSpread_var)+_WaveIntensity_var)*0.5+0.5))*(_WaveHeight_var*0.05+0.0))).rgb;
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                    float2 texcoord1 : TEXCOORD1;
                    float2 texcoord2 : TEXCOORD2;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    o.texcoord0 = v.texcoord0;
                    o.texcoord1 = v.texcoord1;
                    o.texcoord2 = v.texcoord2;
                    return o;
                }
                float Tessellation(TessVertex v){
                    float _PlaneTessellation_var = UNITY_ACCESS_INSTANCED_PROP( Props, _PlaneTessellation );
                    return _PlaneTessellation_var;
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o = (OutputPatchConstant)0;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v = (VertexInput)0;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    v.texcoord0 = vi[0].texcoord0*bary.x + vi[1].texcoord0*bary.y + vi[2].texcoord0*bary.z;
                    v.texcoord1 = vi[0].texcoord1*bary.x + vi[1].texcoord1*bary.y + vi[2].texcoord1*bary.z;
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float sceneZ = max(0,LinearEyeDepth (UNITY_SAMPLE_DEPTH(tex2Dproj(_CameraDepthTexture, UNITY_PROJ_COORD(i.projPos)))) - _ProjectionParams.g);
                float partZ = max(0,i.projPos.z - _ProjectionParams.g);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = 1;
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float _Roughness_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Roughness );
                float gloss = _Roughness_var;
                float perceptualRoughness = 1.0 - _Roughness_var;
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
                float _Metallic_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Metallic );
                float3 specularColor = _Metallic_var;
                float specularMonochrome;
                float4 _FoamColour_var = UNITY_ACCESS_INSTANCED_PROP( Props, _FoamColour );
                float _UTilingAmount_var = UNITY_ACCESS_INSTANCED_PROP( Props, _UTilingAmount );
                float _VTilingAmount_var = UNITY_ACCESS_INSTANCED_PROP( Props, _VTilingAmount );
                float4 node_1838 = _Time;
                float2 node_4125 = (i.uv0+(float2(_UTilingAmount_var,_VTilingAmount_var)*node_1838.r));
                float4 _WaterTexture_var = tex2D(_WaterTexture,TRANSFORM_TEX(node_4125, _WaterTexture));
                float4 _WaterColour_var = UNITY_ACCESS_INSTANCED_PROP( Props, _WaterColour );
                float _DepthValue_var = UNITY_ACCESS_INSTANCED_PROP( Props, _DepthValue );
                float node_2943 = saturate((saturate((sceneZ-partZ)/_DepthValue_var)/dot(viewDirection,i.normalDir)));
                float3 node_9742 = lerp(_FoamColour_var.rgb,(_WaterTexture_var.rgb*_WaterColour_var.rgb),node_2943);
                float4 _FoamTexture_var = tex2D(_FoamTexture,TRANSFORM_TEX(node_4125, _FoamTexture));
                float _FoamMinimum_var = UNITY_ACCESS_INSTANCED_PROP( Props, _FoamMinimum );
                float _FoamMaximum_var = UNITY_ACCESS_INSTANCED_PROP( Props, _FoamMaximum );
                float node_2446 = 0.0;
                float _FoamIntensity_var = UNITY_ACCESS_INSTANCED_PROP( Props, _FoamIntensity );
                float3 node_8988 = saturate((((node_9742*_FoamTexture_var.rgb)*(1.0 - saturate((node_2446 + ( (node_2943 - _FoamMinimum_var) * (1.0 - node_2446) ) / (_FoamMaximum_var - _FoamMinimum_var)))))*_FoamIntensity_var));
                float3 diffuseColor = (node_9742+node_8988); // Need this for specular when using metallic
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
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                float _DepthMinimum_var = UNITY_ACCESS_INSTANCED_PROP( Props, _DepthMinimum );
                float _DepthMaximum_var = UNITY_ACCESS_INSTANCED_PROP( Props, _DepthMaximum );
                float node_552 = 0.0;
                fixed4 finalRGBA = fixed4(finalColor,saturate(((node_8988.r*0.5)+(node_552 + ( (node_2943 - _DepthMinimum_var) * (1.0 - node_552) ) / (_DepthMaximum_var - _DepthMinimum_var)))));
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
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #include "Tessellation.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdadd
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma target 5.0
            uniform sampler2D _CameraDepthTexture;
            uniform sampler2D _FoamTexture; uniform float4 _FoamTexture_ST;
            uniform sampler2D _WaveNoise; uniform float4 _WaveNoise_ST;
            uniform sampler2D _WaterTexture; uniform float4 _WaterTexture_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _Metallic)
                UNITY_DEFINE_INSTANCED_PROP( float, _Roughness)
                UNITY_DEFINE_INSTANCED_PROP( float4, _FoamColour)
                UNITY_DEFINE_INSTANCED_PROP( float4, _WaterColour)
                UNITY_DEFINE_INSTANCED_PROP( float, _DepthValue)
                UNITY_DEFINE_INSTANCED_PROP( float, _FoamMinimum)
                UNITY_DEFINE_INSTANCED_PROP( float, _FoamMaximum)
                UNITY_DEFINE_INSTANCED_PROP( float, _DepthMinimum)
                UNITY_DEFINE_INSTANCED_PROP( float, _DepthMaximum)
                UNITY_DEFINE_INSTANCED_PROP( float, _FoamIntensity)
                UNITY_DEFINE_INSTANCED_PROP( float, _PlaneTessellation)
                UNITY_DEFINE_INSTANCED_PROP( float, _WaveCount)
                UNITY_DEFINE_INSTANCED_PROP( float, _WaveSpread)
                UNITY_DEFINE_INSTANCED_PROP( float, _WaveIntensity)
                UNITY_DEFINE_INSTANCED_PROP( float, _WaveHeight)
                UNITY_DEFINE_INSTANCED_PROP( float, _WaveSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float, _UTilingAmount)
                UNITY_DEFINE_INSTANCED_PROP( float, _VTilingAmount)
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
                float4 projPos : TEXCOORD7;
                LIGHTING_COORDS(8,9)
                UNITY_FOG_COORDS(10)
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
                float4 node_8728 = _Time;
                float2 node_7278 = (o.uv0+node_8728.r*float2(0.5,0.5));
                float4 _WaveNoise_var = tex2Dlod(_WaveNoise,float4(TRANSFORM_TEX(node_7278, _WaveNoise),0.0,0));
                float _WaveSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _WaveSpeed );
                float _WaveCount_var = UNITY_ACCESS_INSTANCED_PROP( Props, _WaveCount );
                float _WaveSpread_var = UNITY_ACCESS_INSTANCED_PROP( Props, _WaveSpread );
                float _WaveIntensity_var = UNITY_ACCESS_INSTANCED_PROP( Props, _WaveIntensity );
                float _WaveHeight_var = UNITY_ACCESS_INSTANCED_PROP( Props, _WaveHeight );
                v.vertex.xyz += float4(0.0,((_WaveNoise_var.rgb*(((sin((((node_8728.r*_WaveSpeed_var)+mul(unity_ObjectToWorld, v.vertex).rgb)*_WaveCount_var))*_WaveSpread_var)+_WaveIntensity_var)*0.5+0.5))*(_WaveHeight_var*0.05+0.0))).rgb;
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                    float2 texcoord1 : TEXCOORD1;
                    float2 texcoord2 : TEXCOORD2;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    o.texcoord0 = v.texcoord0;
                    o.texcoord1 = v.texcoord1;
                    o.texcoord2 = v.texcoord2;
                    return o;
                }
                float Tessellation(TessVertex v){
                    float _PlaneTessellation_var = UNITY_ACCESS_INSTANCED_PROP( Props, _PlaneTessellation );
                    return _PlaneTessellation_var;
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o = (OutputPatchConstant)0;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v = (VertexInput)0;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    v.texcoord0 = vi[0].texcoord0*bary.x + vi[1].texcoord0*bary.y + vi[2].texcoord0*bary.z;
                    v.texcoord1 = vi[0].texcoord1*bary.x + vi[1].texcoord1*bary.y + vi[2].texcoord1*bary.z;
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float sceneZ = max(0,LinearEyeDepth (UNITY_SAMPLE_DEPTH(tex2Dproj(_CameraDepthTexture, UNITY_PROJ_COORD(i.projPos)))) - _ProjectionParams.g);
                float partZ = max(0,i.projPos.z - _ProjectionParams.g);
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float _Roughness_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Roughness );
                float gloss = _Roughness_var;
                float perceptualRoughness = 1.0 - _Roughness_var;
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float _Metallic_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Metallic );
                float3 specularColor = _Metallic_var;
                float specularMonochrome;
                float4 _FoamColour_var = UNITY_ACCESS_INSTANCED_PROP( Props, _FoamColour );
                float _UTilingAmount_var = UNITY_ACCESS_INSTANCED_PROP( Props, _UTilingAmount );
                float _VTilingAmount_var = UNITY_ACCESS_INSTANCED_PROP( Props, _VTilingAmount );
                float4 node_1838 = _Time;
                float2 node_4125 = (i.uv0+(float2(_UTilingAmount_var,_VTilingAmount_var)*node_1838.r));
                float4 _WaterTexture_var = tex2D(_WaterTexture,TRANSFORM_TEX(node_4125, _WaterTexture));
                float4 _WaterColour_var = UNITY_ACCESS_INSTANCED_PROP( Props, _WaterColour );
                float _DepthValue_var = UNITY_ACCESS_INSTANCED_PROP( Props, _DepthValue );
                float node_2943 = saturate((saturate((sceneZ-partZ)/_DepthValue_var)/dot(viewDirection,i.normalDir)));
                float3 node_9742 = lerp(_FoamColour_var.rgb,(_WaterTexture_var.rgb*_WaterColour_var.rgb),node_2943);
                float4 _FoamTexture_var = tex2D(_FoamTexture,TRANSFORM_TEX(node_4125, _FoamTexture));
                float _FoamMinimum_var = UNITY_ACCESS_INSTANCED_PROP( Props, _FoamMinimum );
                float _FoamMaximum_var = UNITY_ACCESS_INSTANCED_PROP( Props, _FoamMaximum );
                float node_2446 = 0.0;
                float _FoamIntensity_var = UNITY_ACCESS_INSTANCED_PROP( Props, _FoamIntensity );
                float3 node_8988 = saturate((((node_9742*_FoamTexture_var.rgb)*(1.0 - saturate((node_2446 + ( (node_2943 - _FoamMinimum_var) * (1.0 - node_2446) ) / (_FoamMaximum_var - _FoamMinimum_var)))))*_FoamIntensity_var));
                float3 diffuseColor = (node_9742+node_8988); // Need this for specular when using metallic
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
                float _DepthMinimum_var = UNITY_ACCESS_INSTANCED_PROP( Props, _DepthMinimum );
                float _DepthMaximum_var = UNITY_ACCESS_INSTANCED_PROP( Props, _DepthMaximum );
                float node_552 = 0.0;
                fixed4 finalRGBA = fixed4(finalColor * saturate(((node_8988.r*0.5)+(node_552 + ( (node_2943 - _DepthMinimum_var) * (1.0 - node_552) ) / (_DepthMaximum_var - _DepthMinimum_var)))),0);
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
            Cull Back
            
            CGPROGRAM
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "Tessellation.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma target 5.0
            uniform sampler2D _WaveNoise; uniform float4 _WaveNoise_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _PlaneTessellation)
                UNITY_DEFINE_INSTANCED_PROP( float, _WaveCount)
                UNITY_DEFINE_INSTANCED_PROP( float, _WaveSpread)
                UNITY_DEFINE_INSTANCED_PROP( float, _WaveIntensity)
                UNITY_DEFINE_INSTANCED_PROP( float, _WaveHeight)
                UNITY_DEFINE_INSTANCED_PROP( float, _WaveSpeed)
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
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
                float2 uv1 : TEXCOORD2;
                float2 uv2 : TEXCOORD3;
                float4 posWorld : TEXCOORD4;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                float4 node_8728 = _Time;
                float2 node_7278 = (o.uv0+node_8728.r*float2(0.5,0.5));
                float4 _WaveNoise_var = tex2Dlod(_WaveNoise,float4(TRANSFORM_TEX(node_7278, _WaveNoise),0.0,0));
                float _WaveSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _WaveSpeed );
                float _WaveCount_var = UNITY_ACCESS_INSTANCED_PROP( Props, _WaveCount );
                float _WaveSpread_var = UNITY_ACCESS_INSTANCED_PROP( Props, _WaveSpread );
                float _WaveIntensity_var = UNITY_ACCESS_INSTANCED_PROP( Props, _WaveIntensity );
                float _WaveHeight_var = UNITY_ACCESS_INSTANCED_PROP( Props, _WaveHeight );
                v.vertex.xyz += float4(0.0,((_WaveNoise_var.rgb*(((sin((((node_8728.r*_WaveSpeed_var)+mul(unity_ObjectToWorld, v.vertex).rgb)*_WaveCount_var))*_WaveSpread_var)+_WaveIntensity_var)*0.5+0.5))*(_WaveHeight_var*0.05+0.0))).rgb;
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                    float2 texcoord1 : TEXCOORD1;
                    float2 texcoord2 : TEXCOORD2;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    o.texcoord0 = v.texcoord0;
                    o.texcoord1 = v.texcoord1;
                    o.texcoord2 = v.texcoord2;
                    return o;
                }
                float Tessellation(TessVertex v){
                    float _PlaneTessellation_var = UNITY_ACCESS_INSTANCED_PROP( Props, _PlaneTessellation );
                    return _PlaneTessellation_var;
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o = (OutputPatchConstant)0;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v = (VertexInput)0;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    v.texcoord0 = vi[0].texcoord0*bary.x + vi[1].texcoord0*bary.y + vi[2].texcoord0*bary.z;
                    v.texcoord1 = vi[0].texcoord1*bary.x + vi[1].texcoord1*bary.y + vi[2].texcoord1*bary.z;
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                SHADOW_CASTER_FRAGMENT(i)
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
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define UNITY_PASS_META 1
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "Tessellation.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #include "UnityMetaPass.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma target 5.0
            uniform sampler2D _CameraDepthTexture;
            uniform sampler2D _FoamTexture; uniform float4 _FoamTexture_ST;
            uniform sampler2D _WaveNoise; uniform float4 _WaveNoise_ST;
            uniform sampler2D _WaterTexture; uniform float4 _WaterTexture_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _Metallic)
                UNITY_DEFINE_INSTANCED_PROP( float, _Roughness)
                UNITY_DEFINE_INSTANCED_PROP( float4, _FoamColour)
                UNITY_DEFINE_INSTANCED_PROP( float4, _WaterColour)
                UNITY_DEFINE_INSTANCED_PROP( float, _DepthValue)
                UNITY_DEFINE_INSTANCED_PROP( float, _FoamMinimum)
                UNITY_DEFINE_INSTANCED_PROP( float, _FoamMaximum)
                UNITY_DEFINE_INSTANCED_PROP( float, _FoamIntensity)
                UNITY_DEFINE_INSTANCED_PROP( float, _PlaneTessellation)
                UNITY_DEFINE_INSTANCED_PROP( float, _WaveCount)
                UNITY_DEFINE_INSTANCED_PROP( float, _WaveSpread)
                UNITY_DEFINE_INSTANCED_PROP( float, _WaveIntensity)
                UNITY_DEFINE_INSTANCED_PROP( float, _WaveHeight)
                UNITY_DEFINE_INSTANCED_PROP( float, _WaveSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float, _UTilingAmount)
                UNITY_DEFINE_INSTANCED_PROP( float, _VTilingAmount)
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
                float4 projPos : TEXCOORD5;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 node_8728 = _Time;
                float2 node_7278 = (o.uv0+node_8728.r*float2(0.5,0.5));
                float4 _WaveNoise_var = tex2Dlod(_WaveNoise,float4(TRANSFORM_TEX(node_7278, _WaveNoise),0.0,0));
                float _WaveSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _WaveSpeed );
                float _WaveCount_var = UNITY_ACCESS_INSTANCED_PROP( Props, _WaveCount );
                float _WaveSpread_var = UNITY_ACCESS_INSTANCED_PROP( Props, _WaveSpread );
                float _WaveIntensity_var = UNITY_ACCESS_INSTANCED_PROP( Props, _WaveIntensity );
                float _WaveHeight_var = UNITY_ACCESS_INSTANCED_PROP( Props, _WaveHeight );
                v.vertex.xyz += float4(0.0,((_WaveNoise_var.rgb*(((sin((((node_8728.r*_WaveSpeed_var)+mul(unity_ObjectToWorld, v.vertex).rgb)*_WaveCount_var))*_WaveSpread_var)+_WaveIntensity_var)*0.5+0.5))*(_WaveHeight_var*0.05+0.0))).rgb;
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityMetaVertexPosition(v.vertex, v.texcoord1.xy, v.texcoord2.xy, unity_LightmapST, unity_DynamicLightmapST );
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                    float2 texcoord1 : TEXCOORD1;
                    float2 texcoord2 : TEXCOORD2;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    o.texcoord0 = v.texcoord0;
                    o.texcoord1 = v.texcoord1;
                    o.texcoord2 = v.texcoord2;
                    return o;
                }
                float Tessellation(TessVertex v){
                    float _PlaneTessellation_var = UNITY_ACCESS_INSTANCED_PROP( Props, _PlaneTessellation );
                    return _PlaneTessellation_var;
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o = (OutputPatchConstant)0;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v = (VertexInput)0;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    v.texcoord0 = vi[0].texcoord0*bary.x + vi[1].texcoord0*bary.y + vi[2].texcoord0*bary.z;
                    v.texcoord1 = vi[0].texcoord1*bary.x + vi[1].texcoord1*bary.y + vi[2].texcoord1*bary.z;
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : SV_Target {
                UNITY_SETUP_INSTANCE_ID( i );
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float sceneZ = max(0,LinearEyeDepth (UNITY_SAMPLE_DEPTH(tex2Dproj(_CameraDepthTexture, UNITY_PROJ_COORD(i.projPos)))) - _ProjectionParams.g);
                float partZ = max(0,i.projPos.z - _ProjectionParams.g);
                UnityMetaInput o;
                UNITY_INITIALIZE_OUTPUT( UnityMetaInput, o );
                
                o.Emission = 0;
                
                float4 _FoamColour_var = UNITY_ACCESS_INSTANCED_PROP( Props, _FoamColour );
                float _UTilingAmount_var = UNITY_ACCESS_INSTANCED_PROP( Props, _UTilingAmount );
                float _VTilingAmount_var = UNITY_ACCESS_INSTANCED_PROP( Props, _VTilingAmount );
                float4 node_1838 = _Time;
                float2 node_4125 = (i.uv0+(float2(_UTilingAmount_var,_VTilingAmount_var)*node_1838.r));
                float4 _WaterTexture_var = tex2D(_WaterTexture,TRANSFORM_TEX(node_4125, _WaterTexture));
                float4 _WaterColour_var = UNITY_ACCESS_INSTANCED_PROP( Props, _WaterColour );
                float _DepthValue_var = UNITY_ACCESS_INSTANCED_PROP( Props, _DepthValue );
                float node_2943 = saturate((saturate((sceneZ-partZ)/_DepthValue_var)/dot(viewDirection,i.normalDir)));
                float3 node_9742 = lerp(_FoamColour_var.rgb,(_WaterTexture_var.rgb*_WaterColour_var.rgb),node_2943);
                float4 _FoamTexture_var = tex2D(_FoamTexture,TRANSFORM_TEX(node_4125, _FoamTexture));
                float _FoamMinimum_var = UNITY_ACCESS_INSTANCED_PROP( Props, _FoamMinimum );
                float _FoamMaximum_var = UNITY_ACCESS_INSTANCED_PROP( Props, _FoamMaximum );
                float node_2446 = 0.0;
                float _FoamIntensity_var = UNITY_ACCESS_INSTANCED_PROP( Props, _FoamIntensity );
                float3 node_8988 = saturate((((node_9742*_FoamTexture_var.rgb)*(1.0 - saturate((node_2446 + ( (node_2943 - _FoamMinimum_var) * (1.0 - node_2446) ) / (_FoamMaximum_var - _FoamMinimum_var)))))*_FoamIntensity_var));
                float3 diffColor = (node_9742+node_8988);
                float specularMonochrome;
                float3 specColor;
                float _Metallic_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Metallic );
                diffColor = DiffuseAndSpecularFromMetallic( diffColor, _Metallic_var, specColor, specularMonochrome );
                float _Roughness_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Roughness );
                float roughness = 1.0 - _Roughness_var;
                o.Albedo = diffColor + specColor * roughness * roughness * 0.5;
                
                return UnityMetaFragment( o );
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
