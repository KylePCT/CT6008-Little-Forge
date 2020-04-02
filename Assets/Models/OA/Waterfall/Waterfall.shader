// Shader created with Shader Forge v1.40 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.40;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,cpap:True,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:4013,x:33995,y:32636,varname:node_4013,prsc:2|diff-8772-OUT,transm-7422-OUT,lwrap-7422-OUT;n:type:ShaderForge.SFN_Color,id:1304,x:32927,y:32891,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_1304,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.3378426,c2:0.8605636,c3:0.9811321,c4:1;n:type:ShaderForge.SFN_Tex2d,id:9739,x:32689,y:32869,ptovrint:False,ptlb:WaterTex,ptin:_WaterTex,varname:node_9739,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:9048f1e42ea6fe84a875bbbfb9ce11fc,ntxv:0,isnm:False|UVIN-4712-OUT;n:type:ShaderForge.SFN_Append,id:5144,x:32096,y:32876,varname:node_5144,prsc:2|A-4221-OUT,B-5885-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5885,x:31889,y:32962,ptovrint:False,ptlb:V Speed,ptin:_VSpeed,varname:node_5885,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.5;n:type:ShaderForge.SFN_ValueProperty,id:4221,x:31889,y:32876,ptovrint:False,ptlb:U Speed,ptin:_USpeed,varname:node_4221,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Multiply,id:8830,x:32289,y:32886,varname:node_8830,prsc:2|A-5144-OUT,B-3844-T;n:type:ShaderForge.SFN_Time,id:3844,x:32096,y:33055,varname:node_3844,prsc:2;n:type:ShaderForge.SFN_Add,id:4712,x:32474,y:32897,varname:node_4712,prsc:2|A-8830-OUT,B-8032-UVOUT;n:type:ShaderForge.SFN_TexCoord,id:8032,x:32289,y:33055,varname:node_8032,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_ValueProperty,id:7422,x:33081,y:33045,ptovrint:False,ptlb:Light,ptin:_Light,varname:node_7422,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1.5;n:type:ShaderForge.SFN_OneMinus,id:8833,x:32508,y:33113,varname:node_8833,prsc:2|IN-8032-V;n:type:ShaderForge.SFN_Clamp01,id:490,x:32689,y:33126,varname:node_490,prsc:2|IN-8833-OUT;n:type:ShaderForge.SFN_Vector1,id:1922,x:32947,y:33155,varname:node_1922,prsc:2,v1:1;n:type:ShaderForge.SFN_SwitchProperty,id:4827,x:33090,y:33271,ptovrint:False,ptlb:Use Gradient,ptin:_UseGradient,varname:node_4827,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:True|A-1922-OUT,B-490-OUT;n:type:ShaderForge.SFN_Multiply,id:1809,x:33312,y:33374,varname:node_1809,prsc:2|A-4827-OUT,B-8194-R;n:type:ShaderForge.SFN_Tex2d,id:8194,x:32843,y:33520,ptovrint:False,ptlb:node_8194,ptin:_node_8194,varname:node_8194,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:24b09c91e320b264bac805eb4fe52a43,ntxv:0,isnm:False|UVIN-4712-OUT;n:type:ShaderForge.SFN_RemapRange,id:2660,x:33516,y:33374,varname:node_2660,prsc:2,frmn:0,frmx:1,tomn:-5,tomx:10|IN-1809-OUT;n:type:ShaderForge.SFN_Clamp01,id:8049,x:33697,y:33374,varname:node_8049,prsc:2|IN-2660-OUT;n:type:ShaderForge.SFN_Add,id:3358,x:33448,y:32697,varname:node_3358,prsc:2|A-7372-OUT,B-8049-OUT;n:type:ShaderForge.SFN_Clamp01,id:8772,x:33666,y:32644,varname:node_8772,prsc:2|IN-3358-OUT;n:type:ShaderForge.SFN_Multiply,id:7372,x:33095,y:32661,varname:node_7372,prsc:2|A-9739-R,B-1304-RGB;proporder:1304-9739-5885-4221-7422-4827-8194;pass:END;sub:END;*/

Shader "Shader Forge/Shader" {
    Properties {
        _Color ("Color", Color) = (0.3378426,0.8605636,0.9811321,1)
        _WaterTex ("WaterTex", 2D) = "white" {}
        _VSpeed ("V Speed", Float ) = 0.5
        _USpeed ("U Speed", Float ) = 0
        _Light ("Light", Float ) = 1.5
        [MaterialToggle] _UseGradient ("Use Gradient", Float ) = 1
        _node_8194 ("node_8194", 2D) = "white" {}
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Cull Off
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _WaterTex; uniform float4 _WaterTex_ST;
            uniform sampler2D _node_8194; uniform float4 _node_8194_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float4, _Color)
                UNITY_DEFINE_INSTANCED_PROP( float, _VSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float, _USpeed)
                UNITY_DEFINE_INSTANCED_PROP( float, _Light)
                UNITY_DEFINE_INSTANCED_PROP( fixed, _UseGradient)
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
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
/////// Diffuse:
                float NdotL = dot( normalDirection, lightDirection );
                float _Light_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Light );
                float3 w = float3(_Light_var,_Light_var,_Light_var)*0.5; // Light wrapping
                float3 NdotLWrap = NdotL * ( 1.0 - w );
                float3 forwardLight = max(float3(0.0,0.0,0.0), NdotLWrap + w );
                float3 backLight = max(float3(0.0,0.0,0.0), -NdotLWrap + w ) * float3(_Light_var,_Light_var,_Light_var);
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = (forwardLight+backLight) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float _USpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _USpeed );
                float _VSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _VSpeed );
                float4 node_3844 = _Time;
                float2 node_4712 = ((float2(_USpeed_var,_VSpeed_var)*node_3844.g)+i.uv0);
                float4 _WaterTex_var = tex2D(_WaterTex,TRANSFORM_TEX(node_4712, _WaterTex));
                float4 _Color_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Color );
                float _UseGradient_var = lerp( 1.0, saturate((1.0 - i.uv0.g)), UNITY_ACCESS_INSTANCED_PROP( Props, _UseGradient ) );
                float4 _node_8194_var = tex2D(_node_8194,TRANSFORM_TEX(node_4712, _node_8194));
                float3 diffuseColor = saturate(((_WaterTex_var.r*_Color_var.rgb)+saturate(((_UseGradient_var*_node_8194_var.r)*15.0+-5.0))));
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse;
                return fixed4(finalColor,1);
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
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _WaterTex; uniform float4 _WaterTex_ST;
            uniform sampler2D _node_8194; uniform float4 _node_8194_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float4, _Color)
                UNITY_DEFINE_INSTANCED_PROP( float, _VSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float, _USpeed)
                UNITY_DEFINE_INSTANCED_PROP( float, _Light)
                UNITY_DEFINE_INSTANCED_PROP( fixed, _UseGradient)
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
                float NdotL = dot( normalDirection, lightDirection );
                float _Light_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Light );
                float3 w = float3(_Light_var,_Light_var,_Light_var)*0.5; // Light wrapping
                float3 NdotLWrap = NdotL * ( 1.0 - w );
                float3 forwardLight = max(float3(0.0,0.0,0.0), NdotLWrap + w );
                float3 backLight = max(float3(0.0,0.0,0.0), -NdotLWrap + w ) * float3(_Light_var,_Light_var,_Light_var);
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = (forwardLight+backLight) * attenColor;
                float _USpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _USpeed );
                float _VSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _VSpeed );
                float4 node_3844 = _Time;
                float2 node_4712 = ((float2(_USpeed_var,_VSpeed_var)*node_3844.g)+i.uv0);
                float4 _WaterTex_var = tex2D(_WaterTex,TRANSFORM_TEX(node_4712, _WaterTex));
                float4 _Color_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Color );
                float _UseGradient_var = lerp( 1.0, saturate((1.0 - i.uv0.g)), UNITY_ACCESS_INSTANCED_PROP( Props, _UseGradient ) );
                float4 _node_8194_var = tex2D(_node_8194,TRANSFORM_TEX(node_4712, _node_8194));
                float3 diffuseColor = saturate(((_WaterTex_var.r*_Color_var.rgb)+saturate(((_UseGradient_var*_node_8194_var.r)*15.0+-5.0))));
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse;
                return fixed4(finalColor * 1,0);
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
