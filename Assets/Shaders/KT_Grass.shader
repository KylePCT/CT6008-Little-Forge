// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Shader created with Shader Forge v1.40 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.40;sub:START;pass:START;ps:flbk:,iptp:1,cusa:True,bamd:0,cgin:,cpap:True,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:2,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:True,tesm:0,olmd:1,culm:2,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:True,atwp:True,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:1873,x:33229,y:32719,varname:node_1873,prsc:2|emission-1749-OUT,alpha-2022-B,voffset-5792-OUT;n:type:ShaderForge.SFN_Tex2d,id:4805,x:32551,y:32729,ptovrint:False,ptlb:MainTex,ptin:_MainTex,varname:_MainTex_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:True,tagnsco:False,tagnrm:False,tex:f92dae6af310c124c82b4c415dc12dd2,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:1086,x:32812,y:32818,cmnt:RGB,varname:node_1086,prsc:2|A-4805-RGB,B-5983-RGB,C-5376-RGB;n:type:ShaderForge.SFN_Color,id:5983,x:32551,y:32915,ptovrint:False,ptlb:Color,ptin:_Color,varname:_Color_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.9973962,c2:0.7735849,c3:1,c4:1;n:type:ShaderForge.SFN_VertexColor,id:5376,x:32551,y:33079,varname:node_5376,prsc:2;n:type:ShaderForge.SFN_Multiply,id:1749,x:33025,y:32818,cmnt:Premultiply Alpha,varname:node_1749,prsc:2|A-1086-OUT,B-603-OUT;n:type:ShaderForge.SFN_Multiply,id:603,x:32812,y:32992,cmnt:A,varname:node_603,prsc:2|A-4805-A,B-5983-A,C-5376-A;n:type:ShaderForge.SFN_Tex2d,id:2022,x:32925,y:33207,ptovrint:False,ptlb:Opacity Mask,ptin:_OpacityMask,varname:node_2022,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:7566ebc11ab5b174999213a53158f00b,ntxv:0,isnm:False|UVIN-7426-OUT;n:type:ShaderForge.SFN_TexCoord,id:1975,x:32589,y:33299,varname:node_1975,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Vector2,id:523,x:32588,y:33478,varname:node_523,prsc:2,v1:-1,v2:-1;n:type:ShaderForge.SFN_Multiply,id:7426,x:32778,y:33374,varname:node_7426,prsc:2|A-1975-UVOUT,B-523-OUT;n:type:ShaderForge.SFN_Slider,id:4495,x:32043,y:34069,ptovrint:False,ptlb:Wind Speed,ptin:_WindSpeed,varname:node_9893,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.61481,max:20;n:type:ShaderForge.SFN_Time,id:6980,x:32159,y:33886,varname:node_6980,prsc:2;n:type:ShaderForge.SFN_TexCoord,id:8182,x:32272,y:33695,varname:node_8182,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_OneMinus,id:7816,x:32486,y:33705,varname:node_7816,prsc:2|IN-8182-V;n:type:ShaderForge.SFN_Multiply,id:1475,x:32367,y:33939,varname:node_1475,prsc:2|A-6980-TDB,B-4495-OUT;n:type:ShaderForge.SFN_Cos,id:1249,x:32564,y:33871,varname:node_1249,prsc:2|IN-1475-OUT;n:type:ShaderForge.SFN_FragmentPosition,id:5771,x:32474,y:34120,varname:node_5771,prsc:2;n:type:ShaderForge.SFN_Sin,id:4812,x:32680,y:34120,varname:node_4812,prsc:2|IN-5771-X;n:type:ShaderForge.SFN_Slider,id:542,x:32695,y:34322,ptovrint:False,ptlb:Wind Intensity,ptin:_WindIntensity,varname:node_5833,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.0220459,max:1;n:type:ShaderForge.SFN_Multiply,id:5426,x:33163,y:33909,varname:node_5426,prsc:2|A-4453-OUT,B-542-OUT;n:type:ShaderForge.SFN_Multiply,id:5792,x:33131,y:33723,varname:node_5792,prsc:2|A-7264-R,B-5426-OUT;n:type:ShaderForge.SFN_VertexColor,id:7264,x:32895,y:33670,varname:node_7264,prsc:2;n:type:ShaderForge.SFN_Multiply,id:4453,x:32878,y:33889,varname:node_4453,prsc:2|A-4812-OUT,B-693-OUT;n:type:ShaderForge.SFN_Multiply,id:693,x:32714,y:33767,varname:node_693,prsc:2|A-7816-OUT,B-1249-OUT;proporder:4805-5983-2022-4495-542;pass:END;sub:END;*/

Shader "Shader Forge/KT_Grass" {
    Properties {
        [PerRendererData]_MainTex ("MainTex", 2D) = "white" {}
        _Color ("Color", Color) = (0.9973962,0.7735849,1,1)
        _OpacityMask ("Opacity Mask", 2D) = "white" {}
        _WindSpeed ("Wind Speed", Range(0, 20)) = 0.61481
        _WindIntensity ("Wind Intensity", Range(0, 1)) = 0.0220459
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
        [MaterialToggle] PixelSnap ("Pixel snap", Float) = 0
        _Stencil ("Stencil ID", Float) = 0
        _StencilReadMask ("Stencil Read Mask", Float) = 255
        _StencilWriteMask ("Stencil Write Mask", Float) = 255
        _StencilComp ("Stencil Comparison", Float) = 8
        _StencilOp ("Stencil Operation", Float) = 0
        _StencilOpFail ("Stencil Fail Operation", Float) = 0
        _StencilOpZFail ("Stencil Z-Fail Operation", Float) = 0
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
            "CanUseSpriteAtlas"="True"
            "PreviewType"="Plane"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            Cull Off
            ZWrite Off
            
            Stencil {
                Ref [_Stencil]
                ReadMask [_StencilReadMask]
                WriteMask [_StencilWriteMask]
                Comp [_StencilComp]
                Pass [_StencilOp]
                Fail [_StencilOpFail]
                ZFail [_StencilOpZFail]
            }
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma multi_compile_instancing
            #pragma multi_compile _ PIXELSNAP_ON
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma target 3.0
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform sampler2D _OpacityMask; uniform float4 _OpacityMask_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float4, _Color)
                UNITY_DEFINE_INSTANCED_PROP( float, _WindSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float, _WindIntensity)
            UNITY_INSTANCING_BUFFER_END( Props )
            struct VertexInput {
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float4 vertexColor : COLOR;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                float4 node_6980 = _Time;
                float _WindSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _WindSpeed );
                float _WindIntensity_var = UNITY_ACCESS_INSTANCED_PROP( Props, _WindIntensity );
                float node_5792 = (o.vertexColor.r*((sin(mul(unity_ObjectToWorld, v.vertex).r)*((1.0 - o.uv0.g)*cos((node_6980.b*_WindSpeed_var))))*_WindIntensity_var));
                v.vertex.xyz += float3(node_5792,node_5792,node_5792);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float4x4 bbmv = UNITY_MATRIX_MV;
                bbmv._m00 = -1.0/length(unity_WorldToObject[0].xyz);
                bbmv._m10 = 0.0f;
                bbmv._m20 = 0.0f;
                bbmv._m01 = 0.0f;
                bbmv._m11 = -1.0/length(unity_WorldToObject[1].xyz);
                bbmv._m21 = 0.0f;
                bbmv._m02 = 0.0f;
                bbmv._m12 = 0.0f;
                bbmv._m22 = -1.0/length(unity_WorldToObject[2].xyz);
                o.pos = mul( UNITY_MATRIX_P, mul( bbmv, v.vertex ));
                #ifdef PIXELSNAP_ON
                    o.pos = UnityPixelSnap(o.pos);
                #endif
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
////// Lighting:
////// Emissive:
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(i.uv0, _MainTex));
                float4 _Color_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Color );
                float3 emissive = ((_MainTex_var.rgb*_Color_var.rgb*i.vertexColor.rgb)*(_MainTex_var.a*_Color_var.a*i.vertexColor.a));
                float3 finalColor = emissive;
                float2 node_7426 = (i.uv0*float2(-1,-1));
                float4 _OpacityMask_var = tex2D(_OpacityMask,TRANSFORM_TEX(node_7426, _OpacityMask));
                return fixed4(finalColor,_OpacityMask_var.b);
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
            #pragma multi_compile_instancing
            #pragma multi_compile _ PIXELSNAP_ON
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma target 3.0
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _WindSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float, _WindIntensity)
            UNITY_INSTANCING_BUFFER_END( Props )
            struct VertexInput {
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                UNITY_VERTEX_INPUT_INSTANCE_ID
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
                float4 posWorld : TEXCOORD2;
                float4 vertexColor : COLOR;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                float4 node_6980 = _Time;
                float _WindSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _WindSpeed );
                float _WindIntensity_var = UNITY_ACCESS_INSTANCED_PROP( Props, _WindIntensity );
                float node_5792 = (o.vertexColor.r*((sin(mul(unity_ObjectToWorld, v.vertex).r)*((1.0 - o.uv0.g)*cos((node_6980.b*_WindSpeed_var))))*_WindIntensity_var));
                v.vertex.xyz += float3(node_5792,node_5792,node_5792);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float4x4 bbmv = UNITY_MATRIX_MV;
                bbmv._m00 = -1.0/length(unity_WorldToObject[0].xyz);
                bbmv._m10 = 0.0f;
                bbmv._m20 = 0.0f;
                bbmv._m01 = 0.0f;
                bbmv._m11 = -1.0/length(unity_WorldToObject[1].xyz);
                bbmv._m21 = 0.0f;
                bbmv._m02 = 0.0f;
                bbmv._m12 = 0.0f;
                bbmv._m22 = -1.0/length(unity_WorldToObject[2].xyz);
                o.pos = mul( UNITY_MATRIX_P, mul( bbmv, v.vertex ));
                #ifdef PIXELSNAP_ON
                    o.pos = UnityPixelSnap(o.pos);
                #endif
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
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
