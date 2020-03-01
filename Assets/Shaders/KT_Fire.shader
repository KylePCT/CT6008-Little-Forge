// Shader created with Shader Forge v1.40 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.40;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,cpap:True,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:True,hqlp:False,rprd:True,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:0,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:1,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:2865,x:33079,y:32695,varname:node_2865,prsc:2|diff-4928-OUT,spec-2866-OUT,gloss-4997-OUT,emission-4928-OUT,alpha-4917-OUT,clip-4917-OUT;n:type:ShaderForge.SFN_Tex2d,id:4534,x:32185,y:32617,ptovrint:False,ptlb:Main Texture,ptin:_MainTexture,varname:node_4534,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:9281612ae28a5c64e8e8dda9de3b9b81,ntxv:2,isnm:False|UVIN-3725-OUT;n:type:ShaderForge.SFN_Slider,id:2866,x:32115,y:32844,ptovrint:False,ptlb:Metallic,ptin:_Metallic,varname:node_2866,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Slider,id:4997,x:32115,y:32955,ptovrint:False,ptlb:Roughness,ptin:_Roughness,varname:_Metallic_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Color,id:7916,x:32185,y:32455,ptovrint:False,ptlb:Main Colour,ptin:_MainColour,varname:node_7916,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.8301887,c2:0.5140741,c3:0,c4:1;n:type:ShaderForge.SFN_Multiply,id:4928,x:32388,y:32517,varname:node_4928,prsc:2|A-7916-RGB,B-4534-RGB;n:type:ShaderForge.SFN_Tex2d,id:4980,x:32185,y:32242,ptovrint:False,ptlb:Noise Texture,ptin:_NoiseTexture,varname:node_4980,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-6049-UVOUT;n:type:ShaderForge.SFN_Panner,id:6049,x:31997,y:32242,varname:node_6049,prsc:2,spu:0.05,spv:-0.2|UVIN-877-OUT;n:type:ShaderForge.SFN_TexCoord,id:2091,x:31625,y:32112,varname:node_2091,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Lerp,id:2968,x:32382,y:32242,varname:node_2968,prsc:2|A-4980-RGB,B-3451-UVOUT,T-7343-OUT;n:type:ShaderForge.SFN_TexCoord,id:3451,x:32186,y:32074,varname:node_3451,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Slider,id:7343,x:32382,y:32157,ptovrint:False,ptlb:Distortion Intensity,ptin:_DistortionIntensity,varname:node_7343,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.7304348,max:1;n:type:ShaderForge.SFN_ComponentMask,id:3725,x:31995,y:32621,varname:node_3725,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-2968-OUT;n:type:ShaderForge.SFN_Time,id:5912,x:31635,y:32373,varname:node_5912,prsc:2;n:type:ShaderForge.SFN_Add,id:877,x:31835,y:32266,varname:node_877,prsc:2|A-2091-UVOUT,B-5912-TSL;n:type:ShaderForge.SFN_Tex2d,id:9377,x:32287,y:33067,ptovrint:False,ptlb:Opacity Mask,ptin:_OpacityMask,varname:node_9377,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:02dad39598b874647b3d4a7c65350c6a,ntxv:0,isnm:False|UVIN-3725-OUT;n:type:ShaderForge.SFN_Add,id:7000,x:32462,y:33046,varname:node_7000,prsc:2|A-4928-OUT,B-9377-RGB;n:type:ShaderForge.SFN_ComponentMask,id:4917,x:32819,y:33000,varname:node_4917,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-2307-OUT;n:type:ShaderForge.SFN_Multiply,id:8973,x:33193,y:33794,varname:node_8973,prsc:2|A-3141-R,B-2962-OUT;n:type:ShaderForge.SFN_VertexColor,id:3141,x:32957,y:33741,varname:node_3141,prsc:2;n:type:ShaderForge.SFN_Multiply,id:2962,x:33225,y:33980,varname:node_2962,prsc:2|A-1166-OUT;n:type:ShaderForge.SFN_Multiply,id:1166,x:32940,y:33960,varname:node_1166,prsc:2|A-9072-OUT,B-7477-OUT;n:type:ShaderForge.SFN_Multiply,id:7477,x:32776,y:33838,varname:node_7477,prsc:2|A-7387-OUT,B-4509-OUT;n:type:ShaderForge.SFN_Cos,id:4509,x:32626,y:33942,varname:node_4509,prsc:2|IN-176-OUT;n:type:ShaderForge.SFN_Multiply,id:176,x:32429,y:34010,varname:node_176,prsc:2|A-1851-TDB;n:type:ShaderForge.SFN_Time,id:1851,x:32221,y:33957,varname:node_1851,prsc:2;n:type:ShaderForge.SFN_TexCoord,id:280,x:32334,y:33766,varname:node_280,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_OneMinus,id:7387,x:32548,y:33776,varname:node_7387,prsc:2|IN-280-V;n:type:ShaderForge.SFN_FragmentPosition,id:7810,x:32536,y:34191,varname:node_7810,prsc:2;n:type:ShaderForge.SFN_Sin,id:9072,x:32742,y:34191,varname:node_9072,prsc:2|IN-7810-X;n:type:ShaderForge.SFN_Multiply,id:5325,x:33257,y:33858,varname:node_5325,prsc:2|A-8709-R,B-12-OUT;n:type:ShaderForge.SFN_VertexColor,id:8709,x:33021,y:33805,varname:node_8709,prsc:2;n:type:ShaderForge.SFN_Multiply,id:12,x:33289,y:34044,varname:node_12,prsc:2|A-7204-OUT;n:type:ShaderForge.SFN_Multiply,id:7204,x:33004,y:34024,varname:node_7204,prsc:2|A-9118-OUT,B-5336-OUT;n:type:ShaderForge.SFN_Multiply,id:5336,x:32840,y:33902,varname:node_5336,prsc:2|A-1482-OUT,B-6085-OUT;n:type:ShaderForge.SFN_Cos,id:6085,x:32690,y:34006,varname:node_6085,prsc:2|IN-3466-OUT;n:type:ShaderForge.SFN_Multiply,id:3466,x:32493,y:34074,varname:node_3466,prsc:2|A-8097-TDB;n:type:ShaderForge.SFN_Time,id:8097,x:32285,y:34021,varname:node_8097,prsc:2;n:type:ShaderForge.SFN_TexCoord,id:7116,x:32398,y:33830,varname:node_7116,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_OneMinus,id:1482,x:32612,y:33840,varname:node_1482,prsc:2|IN-7116-V;n:type:ShaderForge.SFN_FragmentPosition,id:7338,x:32600,y:34255,varname:node_7338,prsc:2;n:type:ShaderForge.SFN_Sin,id:9118,x:32806,y:34255,varname:node_9118,prsc:2|IN-7338-X;n:type:ShaderForge.SFN_Multiply,id:8218,x:33321,y:33922,varname:node_8218,prsc:2|A-32-R,B-8707-OUT;n:type:ShaderForge.SFN_VertexColor,id:32,x:33085,y:33869,varname:node_32,prsc:2;n:type:ShaderForge.SFN_Multiply,id:8707,x:33353,y:34108,varname:node_8707,prsc:2|A-3893-OUT;n:type:ShaderForge.SFN_Multiply,id:3893,x:33068,y:34088,varname:node_3893,prsc:2|A-4397-OUT,B-9210-OUT;n:type:ShaderForge.SFN_Multiply,id:9210,x:32904,y:33966,varname:node_9210,prsc:2|A-4305-OUT,B-3958-OUT;n:type:ShaderForge.SFN_Cos,id:3958,x:32754,y:34070,varname:node_3958,prsc:2|IN-8641-OUT;n:type:ShaderForge.SFN_Multiply,id:8641,x:32557,y:34138,varname:node_8641,prsc:2|A-1408-TDB;n:type:ShaderForge.SFN_Time,id:1408,x:32349,y:34085,varname:node_1408,prsc:2;n:type:ShaderForge.SFN_TexCoord,id:2945,x:32462,y:33894,varname:node_2945,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_OneMinus,id:4305,x:32676,y:33904,varname:node_4305,prsc:2|IN-2945-V;n:type:ShaderForge.SFN_FragmentPosition,id:5830,x:32664,y:34319,varname:node_5830,prsc:2;n:type:ShaderForge.SFN_Sin,id:4397,x:32870,y:34319,varname:node_4397,prsc:2|IN-5830-X;n:type:ShaderForge.SFN_Multiply,id:5646,x:33385,y:33986,varname:node_5646,prsc:2|A-4757-R,B-1183-OUT;n:type:ShaderForge.SFN_VertexColor,id:4757,x:33149,y:33933,varname:node_4757,prsc:2;n:type:ShaderForge.SFN_Multiply,id:1183,x:33417,y:34172,varname:node_1183,prsc:2|A-3602-OUT;n:type:ShaderForge.SFN_Multiply,id:3602,x:33132,y:34152,varname:node_3602,prsc:2|A-8600-OUT,B-2546-OUT;n:type:ShaderForge.SFN_Multiply,id:2546,x:32968,y:34030,varname:node_2546,prsc:2|A-1735-OUT,B-5724-OUT;n:type:ShaderForge.SFN_Cos,id:5724,x:32818,y:34134,varname:node_5724,prsc:2|IN-2552-OUT;n:type:ShaderForge.SFN_Multiply,id:2552,x:32621,y:34202,varname:node_2552,prsc:2|A-7291-TDB;n:type:ShaderForge.SFN_Time,id:7291,x:32413,y:34149,varname:node_7291,prsc:2;n:type:ShaderForge.SFN_TexCoord,id:216,x:32526,y:33958,varname:node_216,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_OneMinus,id:1735,x:32740,y:33968,varname:node_1735,prsc:2|IN-216-V;n:type:ShaderForge.SFN_FragmentPosition,id:6002,x:32728,y:34383,varname:node_6002,prsc:2;n:type:ShaderForge.SFN_Sin,id:8600,x:32934,y:34383,varname:node_8600,prsc:2|IN-6002-X;n:type:ShaderForge.SFN_Multiply,id:5894,x:33449,y:34050,varname:node_5894,prsc:2|A-2448-R,B-7979-OUT;n:type:ShaderForge.SFN_VertexColor,id:2448,x:33213,y:33997,varname:node_2448,prsc:2;n:type:ShaderForge.SFN_Multiply,id:7979,x:33481,y:34236,varname:node_7979,prsc:2|A-623-OUT;n:type:ShaderForge.SFN_Multiply,id:623,x:33196,y:34216,varname:node_623,prsc:2|A-193-OUT,B-4764-OUT;n:type:ShaderForge.SFN_Multiply,id:4764,x:33032,y:34094,varname:node_4764,prsc:2|A-9825-OUT,B-2561-OUT;n:type:ShaderForge.SFN_Cos,id:2561,x:32882,y:34198,varname:node_2561,prsc:2|IN-2294-OUT;n:type:ShaderForge.SFN_Multiply,id:2294,x:32685,y:34266,varname:node_2294,prsc:2|A-1007-TDB;n:type:ShaderForge.SFN_Time,id:1007,x:32477,y:34213,varname:node_1007,prsc:2;n:type:ShaderForge.SFN_TexCoord,id:782,x:32590,y:34022,varname:node_782,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_OneMinus,id:9825,x:32804,y:34032,varname:node_9825,prsc:2|IN-782-V;n:type:ShaderForge.SFN_FragmentPosition,id:4846,x:32792,y:34447,varname:node_4846,prsc:2;n:type:ShaderForge.SFN_Sin,id:193,x:32998,y:34447,varname:node_193,prsc:2|IN-4846-X;n:type:ShaderForge.SFN_Multiply,id:9895,x:33513,y:34114,varname:node_9895,prsc:2|A-9228-R,B-9549-OUT;n:type:ShaderForge.SFN_VertexColor,id:9228,x:33277,y:34061,varname:node_9228,prsc:2;n:type:ShaderForge.SFN_Multiply,id:9549,x:33545,y:34300,varname:node_9549,prsc:2|A-8576-OUT;n:type:ShaderForge.SFN_Multiply,id:8576,x:33260,y:34280,varname:node_8576,prsc:2|A-2930-OUT,B-5834-OUT;n:type:ShaderForge.SFN_Multiply,id:5834,x:33096,y:34158,varname:node_5834,prsc:2|A-1347-OUT,B-2176-OUT;n:type:ShaderForge.SFN_Cos,id:2176,x:32946,y:34262,varname:node_2176,prsc:2|IN-5226-OUT;n:type:ShaderForge.SFN_Multiply,id:5226,x:32749,y:34330,varname:node_5226,prsc:2|A-9418-TDB;n:type:ShaderForge.SFN_Time,id:9418,x:32541,y:34277,varname:node_9418,prsc:2;n:type:ShaderForge.SFN_TexCoord,id:1447,x:32654,y:34086,varname:node_1447,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_OneMinus,id:1347,x:32868,y:34096,varname:node_1347,prsc:2|IN-1447-V;n:type:ShaderForge.SFN_FragmentPosition,id:6647,x:32856,y:34511,varname:node_6647,prsc:2;n:type:ShaderForge.SFN_Sin,id:2930,x:33062,y:34511,varname:node_2930,prsc:2|IN-6647-X;n:type:ShaderForge.SFN_Multiply,id:6693,x:33577,y:34178,varname:node_6693,prsc:2|A-3322-R,B-5510-OUT;n:type:ShaderForge.SFN_VertexColor,id:3322,x:33341,y:34125,varname:node_3322,prsc:2;n:type:ShaderForge.SFN_Multiply,id:5510,x:33609,y:34364,varname:node_5510,prsc:2|A-7254-OUT;n:type:ShaderForge.SFN_Multiply,id:7254,x:33324,y:34344,varname:node_7254,prsc:2|A-447-OUT,B-1806-OUT;n:type:ShaderForge.SFN_Multiply,id:1806,x:33160,y:34222,varname:node_1806,prsc:2|A-5329-OUT,B-2230-OUT;n:type:ShaderForge.SFN_Cos,id:2230,x:33010,y:34326,varname:node_2230,prsc:2|IN-5949-OUT;n:type:ShaderForge.SFN_Multiply,id:5949,x:32813,y:34394,varname:node_5949,prsc:2|A-239-TDB;n:type:ShaderForge.SFN_Time,id:239,x:32605,y:34341,varname:node_239,prsc:2;n:type:ShaderForge.SFN_TexCoord,id:8082,x:32718,y:34150,varname:node_8082,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_OneMinus,id:5329,x:32932,y:34160,varname:node_5329,prsc:2|IN-8082-V;n:type:ShaderForge.SFN_FragmentPosition,id:3386,x:32920,y:34575,varname:node_3386,prsc:2;n:type:ShaderForge.SFN_Sin,id:447,x:33126,y:34575,varname:node_447,prsc:2|IN-3386-X;n:type:ShaderForge.SFN_Multiply,id:7553,x:33641,y:34242,varname:node_7553,prsc:2|A-871-R,B-2613-OUT;n:type:ShaderForge.SFN_VertexColor,id:871,x:33405,y:34189,varname:node_871,prsc:2;n:type:ShaderForge.SFN_Multiply,id:2613,x:33673,y:34428,varname:node_2613,prsc:2|A-6173-OUT;n:type:ShaderForge.SFN_Multiply,id:6173,x:33388,y:34408,varname:node_6173,prsc:2|A-2634-OUT,B-2303-OUT;n:type:ShaderForge.SFN_Multiply,id:2303,x:33224,y:34286,varname:node_2303,prsc:2|A-4484-OUT,B-4835-OUT;n:type:ShaderForge.SFN_Cos,id:4835,x:33074,y:34390,varname:node_4835,prsc:2|IN-113-OUT;n:type:ShaderForge.SFN_Multiply,id:113,x:32877,y:34458,varname:node_113,prsc:2|A-2231-TDB;n:type:ShaderForge.SFN_Time,id:2231,x:32669,y:34405,varname:node_2231,prsc:2;n:type:ShaderForge.SFN_TexCoord,id:7160,x:32782,y:34214,varname:node_7160,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_OneMinus,id:4484,x:32996,y:34224,varname:node_4484,prsc:2|IN-7160-V;n:type:ShaderForge.SFN_FragmentPosition,id:7712,x:32984,y:34639,varname:node_7712,prsc:2;n:type:ShaderForge.SFN_Sin,id:2634,x:33190,y:34639,varname:node_2634,prsc:2|IN-7712-X;n:type:ShaderForge.SFN_Multiply,id:8803,x:33705,y:34306,varname:node_8803,prsc:2|A-1542-R,B-9139-OUT;n:type:ShaderForge.SFN_VertexColor,id:1542,x:33469,y:34253,varname:node_1542,prsc:2;n:type:ShaderForge.SFN_Multiply,id:9139,x:33737,y:34492,varname:node_9139,prsc:2|A-5344-OUT;n:type:ShaderForge.SFN_Multiply,id:5344,x:33452,y:34472,varname:node_5344,prsc:2|A-3865-OUT,B-48-OUT;n:type:ShaderForge.SFN_Multiply,id:48,x:33288,y:34350,varname:node_48,prsc:2|A-8873-OUT,B-5944-OUT;n:type:ShaderForge.SFN_Cos,id:5944,x:33138,y:34454,varname:node_5944,prsc:2|IN-5218-OUT;n:type:ShaderForge.SFN_Multiply,id:5218,x:32941,y:34522,varname:node_5218,prsc:2|A-6491-TDB;n:type:ShaderForge.SFN_Time,id:6491,x:32733,y:34469,varname:node_6491,prsc:2;n:type:ShaderForge.SFN_TexCoord,id:1606,x:32846,y:34278,varname:node_1606,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_OneMinus,id:8873,x:33060,y:34288,varname:node_8873,prsc:2|IN-1606-V;n:type:ShaderForge.SFN_FragmentPosition,id:6630,x:33048,y:34703,varname:node_6630,prsc:2;n:type:ShaderForge.SFN_Sin,id:3865,x:33254,y:34703,varname:node_3865,prsc:2|IN-6630-X;n:type:ShaderForge.SFN_Multiply,id:2307,x:32592,y:32905,varname:node_2307,prsc:2|A-4980-RGB,B-7000-OUT;proporder:4534-2866-4997-7916-4980-7343-9377;pass:END;sub:END;*/

Shader "Shader Forge/KT_Fire" {
    Properties {
        _MainTexture ("Main Texture", 2D) = "black" {}
        _Metallic ("Metallic", Range(0, 1)) = 0
        _Roughness ("Roughness", Range(0, 1)) = 0
        _MainColour ("Main Colour", Color) = (0.8301887,0.5140741,0,1)
        _NoiseTexture ("Noise Texture", 2D) = "white" {}
        _DistortionIntensity ("Distortion Intensity", Range(0, 1)) = 0.7304348
        _OpacityMask ("Opacity Mask", 2D) = "white" {}
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
            Cull Front
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
            uniform sampler2D _MainTexture; uniform float4 _MainTexture_ST;
            uniform sampler2D _NoiseTexture; uniform float4 _NoiseTexture_ST;
            uniform sampler2D _OpacityMask; uniform float4 _OpacityMask_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _Metallic)
                UNITY_DEFINE_INSTANCED_PROP( float, _Roughness)
                UNITY_DEFINE_INSTANCED_PROP( float4, _MainColour)
                UNITY_DEFINE_INSTANCED_PROP( float, _DistortionIntensity)
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
                o.normalDir = UnityObjectToWorldNormal(-v.normal);
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
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float4 node_8753 = _Time;
                float4 node_5912 = _Time;
                float2 node_6049 = ((i.uv0+node_5912.r)+node_8753.g*float2(0.05,-0.2));
                float4 _NoiseTexture_var = tex2D(_NoiseTexture,TRANSFORM_TEX(node_6049, _NoiseTexture));
                float4 _MainColour_var = UNITY_ACCESS_INSTANCED_PROP( Props, _MainColour );
                float _DistortionIntensity_var = UNITY_ACCESS_INSTANCED_PROP( Props, _DistortionIntensity );
                float2 node_3725 = lerp(_NoiseTexture_var.rgb,float3(i.uv0,0.0),_DistortionIntensity_var).rg;
                float4 _MainTexture_var = tex2D(_MainTexture,TRANSFORM_TEX(node_3725, _MainTexture));
                float3 node_4928 = (_MainColour_var.rgb*_MainTexture_var.rgb);
                float4 _OpacityMask_var = tex2D(_OpacityMask,TRANSFORM_TEX(node_3725, _OpacityMask));
                float3 node_7000 = (node_4928+_OpacityMask_var.rgb);
                float node_4917 = (_NoiseTexture_var.rgb*node_7000).r;
                clip(node_4917 - 0.5);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = 1;
                float3 attenColor = attenuation * _LightColor0.xyz;
///////// Gloss:
                float _Roughness_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Roughness );
                float gloss = _Roughness_var;
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
                float _Metallic_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Metallic );
                float3 specularColor = float3(_Metallic_var,_Metallic_var,_Metallic_var);
                float3 directSpecular = attenColor * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularColor;
                float3 indirectSpecular = (gi.indirect.specular)*specularColor;
                float3 specular = (directSpecular + indirectSpecular);
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += gi.indirect.diffuse;
                float3 diffuseColor = node_4928;
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
////// Emissive:
                float3 emissive = node_4928;
/// Final Color:
                float3 finalColor = diffuse + specular + emissive;
                fixed4 finalRGBA = fixed4(finalColor,node_4917);
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
            Cull Front
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
            uniform sampler2D _MainTexture; uniform float4 _MainTexture_ST;
            uniform sampler2D _NoiseTexture; uniform float4 _NoiseTexture_ST;
            uniform sampler2D _OpacityMask; uniform float4 _OpacityMask_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _Metallic)
                UNITY_DEFINE_INSTANCED_PROP( float, _Roughness)
                UNITY_DEFINE_INSTANCED_PROP( float4, _MainColour)
                UNITY_DEFINE_INSTANCED_PROP( float, _DistortionIntensity)
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
                o.normalDir = UnityObjectToWorldNormal(-v.normal);
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
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float4 node_9750 = _Time;
                float4 node_5912 = _Time;
                float2 node_6049 = ((i.uv0+node_5912.r)+node_9750.g*float2(0.05,-0.2));
                float4 _NoiseTexture_var = tex2D(_NoiseTexture,TRANSFORM_TEX(node_6049, _NoiseTexture));
                float4 _MainColour_var = UNITY_ACCESS_INSTANCED_PROP( Props, _MainColour );
                float _DistortionIntensity_var = UNITY_ACCESS_INSTANCED_PROP( Props, _DistortionIntensity );
                float2 node_3725 = lerp(_NoiseTexture_var.rgb,float3(i.uv0,0.0),_DistortionIntensity_var).rg;
                float4 _MainTexture_var = tex2D(_MainTexture,TRANSFORM_TEX(node_3725, _MainTexture));
                float3 node_4928 = (_MainColour_var.rgb*_MainTexture_var.rgb);
                float4 _OpacityMask_var = tex2D(_OpacityMask,TRANSFORM_TEX(node_3725, _OpacityMask));
                float3 node_7000 = (node_4928+_OpacityMask_var.rgb);
                float node_4917 = (_NoiseTexture_var.rgb*node_7000).r;
                clip(node_4917 - 0.5);
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
///////// Gloss:
                float _Roughness_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Roughness );
                float gloss = _Roughness_var;
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float _Metallic_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Metallic );
                float3 specularColor = float3(_Metallic_var,_Metallic_var,_Metallic_var);
                float3 directSpecular = attenColor * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularColor;
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float3 diffuseColor = node_4928;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                fixed4 finalRGBA = fixed4(finalColor * node_4917,0);
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
            Cull Front
            
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
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma target 3.0
            uniform sampler2D _MainTexture; uniform float4 _MainTexture_ST;
            uniform sampler2D _NoiseTexture; uniform float4 _NoiseTexture_ST;
            uniform sampler2D _OpacityMask; uniform float4 _OpacityMask_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float4, _MainColour)
                UNITY_DEFINE_INSTANCED_PROP( float, _DistortionIntensity)
            UNITY_INSTANCING_BUFFER_END( Props )
            struct VertexInput {
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float4 vertex : POSITION;
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
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float4 node_5634 = _Time;
                float4 node_5912 = _Time;
                float2 node_6049 = ((i.uv0+node_5912.r)+node_5634.g*float2(0.05,-0.2));
                float4 _NoiseTexture_var = tex2D(_NoiseTexture,TRANSFORM_TEX(node_6049, _NoiseTexture));
                float4 _MainColour_var = UNITY_ACCESS_INSTANCED_PROP( Props, _MainColour );
                float _DistortionIntensity_var = UNITY_ACCESS_INSTANCED_PROP( Props, _DistortionIntensity );
                float2 node_3725 = lerp(_NoiseTexture_var.rgb,float3(i.uv0,0.0),_DistortionIntensity_var).rg;
                float4 _MainTexture_var = tex2D(_MainTexture,TRANSFORM_TEX(node_3725, _MainTexture));
                float3 node_4928 = (_MainColour_var.rgb*_MainTexture_var.rgb);
                float4 _OpacityMask_var = tex2D(_OpacityMask,TRANSFORM_TEX(node_3725, _OpacityMask));
                float3 node_7000 = (node_4928+_OpacityMask_var.rgb);
                float node_4917 = (_NoiseTexture_var.rgb*node_7000).r;
                clip(node_4917 - 0.5);
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
            uniform sampler2D _MainTexture; uniform float4 _MainTexture_ST;
            uniform sampler2D _NoiseTexture; uniform float4 _NoiseTexture_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _Metallic)
                UNITY_DEFINE_INSTANCED_PROP( float, _Roughness)
                UNITY_DEFINE_INSTANCED_PROP( float4, _MainColour)
                UNITY_DEFINE_INSTANCED_PROP( float, _DistortionIntensity)
            UNITY_INSTANCING_BUFFER_END( Props )
            struct VertexInput {
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float4 vertex : POSITION;
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
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityMetaVertexPosition(v.vertex, v.texcoord1.xy, v.texcoord2.xy, unity_LightmapST, unity_DynamicLightmapST );
                return o;
            }
            float4 frag(VertexOutput i) : SV_Target {
                UNITY_SETUP_INSTANCE_ID( i );
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                UnityMetaInput o;
                UNITY_INITIALIZE_OUTPUT( UnityMetaInput, o );
                
                float4 _MainColour_var = UNITY_ACCESS_INSTANCED_PROP( Props, _MainColour );
                float4 node_5151 = _Time;
                float4 node_5912 = _Time;
                float2 node_6049 = ((i.uv0+node_5912.r)+node_5151.g*float2(0.05,-0.2));
                float4 _NoiseTexture_var = tex2D(_NoiseTexture,TRANSFORM_TEX(node_6049, _NoiseTexture));
                float _DistortionIntensity_var = UNITY_ACCESS_INSTANCED_PROP( Props, _DistortionIntensity );
                float2 node_3725 = lerp(_NoiseTexture_var.rgb,float3(i.uv0,0.0),_DistortionIntensity_var).rg;
                float4 _MainTexture_var = tex2D(_MainTexture,TRANSFORM_TEX(node_3725, _MainTexture));
                float3 node_4928 = (_MainColour_var.rgb*_MainTexture_var.rgb);
                o.Emission = node_4928;
                
                float3 diffColor = node_4928;
                float _Metallic_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Metallic );
                float3 specColor = float3(_Metallic_var,_Metallic_var,_Metallic_var);
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
