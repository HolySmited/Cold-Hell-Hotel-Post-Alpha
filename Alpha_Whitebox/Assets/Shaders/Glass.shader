// Shader created with Shader Forge v1.18 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.18;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:3,spmd:1,trmd:0,grmd:1,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False;n:type:ShaderForge.SFN_Final,id:2370,x:34329,y:32826,varname:node_2370,prsc:2|diff-3704-OUT,spec-262-OUT,gloss-1027-OUT,normal-9318-OUT,emission-9903-OUT,transm-8557-OUT,lwrap-6434-OUT,amdfl-492-OUT,amspl-6358-OUT,alpha-2110-OUT,refract-7316-OUT;n:type:ShaderForge.SFN_Tex2d,id:6227,x:31800,y:32289,ptovrint:False,ptlb:base_diff,ptin:_base_diff,varname:node_6227,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:d4394a3fa81db0e4cb422e2a03bbf240,ntxv:2,isnm:False|UVIN-4676-OUT;n:type:ShaderForge.SFN_Tex2d,id:8522,x:31800,y:32720,ptovrint:False,ptlb:detail_diff,ptin:_detail_diff,varname:node_8522,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:44fd3d702330daf4191d743d22dce462,ntxv:0,isnm:False|UVIN-997-OUT;n:type:ShaderForge.SFN_Color,id:8506,x:31800,y:32915,ptovrint:False,ptlb:color_detail,ptin:_color_detail,varname:node_8506,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Slider,id:1027,x:34303,y:32588,ptovrint:False,ptlb:roughness,ptin:_roughness,varname:node_1027,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.3,max:1;n:type:ShaderForge.SFN_Color,id:480,x:31800,y:32492,ptovrint:False,ptlb:color_base,ptin:_color_base,varname:node_480,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.3897059,c2:0.4011678,c3:0.4011678,c4:1;n:type:ShaderForge.SFN_Multiply,id:4479,x:32018,y:32389,varname:node_4479,prsc:2|A-6227-RGB,B-480-RGB;n:type:ShaderForge.SFN_TexCoord,id:9145,x:31248,y:32606,varname:node_9145,prsc:2,uv:0;n:type:ShaderForge.SFN_TexCoord,id:652,x:31244,y:33132,varname:node_652,prsc:2,uv:0;n:type:ShaderForge.SFN_Slider,id:3495,x:31100,y:32971,ptovrint:False,ptlb:detailUV_Scaling,ptin:_detailUV_Scaling,varname:node_3495,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:10;n:type:ShaderForge.SFN_Multiply,id:997,x:31545,y:32941,varname:node_997,prsc:2|A-3495-OUT,B-652-UVOUT;n:type:ShaderForge.SFN_Slider,id:1443,x:31091,y:32433,ptovrint:False,ptlb:baseUV_Scaling,ptin:_baseUV_Scaling,varname:node_1443,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:10;n:type:ShaderForge.SFN_Multiply,id:4676,x:31534,y:32502,varname:node_4676,prsc:2|A-1443-OUT,B-9145-UVOUT;n:type:ShaderForge.SFN_Multiply,id:7002,x:33218,y:33665,varname:node_7002,prsc:2|A-6669-OUT,B-6458-OUT;n:type:ShaderForge.SFN_Multiply,id:7316,x:33450,y:33584,varname:node_7316,prsc:2|A-2073-OUT,B-7002-OUT;n:type:ShaderForge.SFN_Vector1,id:6434,x:34303,y:32434,varname:node_6434,prsc:2,v1:1;n:type:ShaderForge.SFN_Lerp,id:9318,x:33218,y:33353,varname:node_9318,prsc:2|A-5295-OUT,B-6334-RGB,T-2938-OUT;n:type:ShaderForge.SFN_ComponentMask,id:2073,x:33218,y:33513,varname:node_2073,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-6334-RGB;n:type:ShaderForge.SFN_Tex2d,id:6334,x:32980,y:33428,ptovrint:False,ptlb:base_normal,ptin:_base_normal,varname:_Refraction,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:08eda33d724cfb84c9bc03b82a6d737e,ntxv:3,isnm:True|UVIN-4676-OUT;n:type:ShaderForge.SFN_Vector3,id:5295,x:32980,y:33307,varname:node_5295,prsc:2,v1:0,v2:0,v3:1;n:type:ShaderForge.SFN_Slider,id:6669,x:32820,y:33743,ptovrint:False,ptlb:refraction,ptin:_refraction,varname:_RefractionIntensity,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.5,max:1;n:type:ShaderForge.SFN_Vector1,id:6458,x:33218,y:33830,varname:node_6458,prsc:2,v1:0.2;n:type:ShaderForge.SFN_Tex2d,id:5322,x:31158,y:31062,ptovrint:False,ptlb:base_emission,ptin:_base_emission,varname:node_5322,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Color,id:9327,x:31158,y:31281,ptovrint:False,ptlb:color_emission,ptin:_color_emission,varname:node_9327,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.9400728,c2:0.9705882,c3:0.7493512,c4:1;n:type:ShaderForge.SFN_Multiply,id:3193,x:31605,y:31306,varname:node_3193,prsc:2|A-6268-OUT,B-5719-OUT;n:type:ShaderForge.SFN_Multiply,id:6268,x:31401,y:31234,varname:node_6268,prsc:2|A-5013-OUT,B-9327-RGB;n:type:ShaderForge.SFN_Slider,id:5719,x:31158,y:31510,ptovrint:False,ptlb:emission_value,ptin:_emission_value,varname:node_5719,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1.751592,max:5;n:type:ShaderForge.SFN_FogColor,id:6596,x:32515,y:32713,varname:node_6596,prsc:2;n:type:ShaderForge.SFN_SwitchProperty,id:3125,x:32325,y:31299,ptovrint:False,ptlb:detail_blockLight,ptin:_detail_blockLight,varname:node_3125,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:True|A-3431-OUT,B-9734-OUT;n:type:ShaderForge.SFN_Fresnel,id:910,x:31918,y:31452,varname:node_910,prsc:2|EXP-926-OUT;n:type:ShaderForge.SFN_Multiply,id:9734,x:32117,y:31299,varname:node_9734,prsc:2|A-3431-OUT,B-5878-OUT;n:type:ShaderForge.SFN_OneMinus,id:5878,x:31965,y:31797,varname:node_5878,prsc:2|IN-8522-A;n:type:ShaderForge.SFN_Lerp,id:3431,x:31918,y:31299,varname:node_3431,prsc:2|A-3193-OUT,B-7316-OUT,T-910-OUT;n:type:ShaderForge.SFN_Slider,id:926,x:31558,y:31515,ptovrint:False,ptlb:emission_size,ptin:_emission_size,varname:node_926,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.5965691,max:1;n:type:ShaderForge.SFN_Multiply,id:2603,x:32004,y:31946,varname:node_2603,prsc:2|A-5296-OUT,B-5878-OUT;n:type:ShaderForge.SFN_Slider,id:2495,x:31454,y:31946,ptovrint:False,ptlb:opacityCenter,ptin:_opacityCenter,varname:node_2495,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.2186107,max:1;n:type:ShaderForge.SFN_Vector1,id:1067,x:32203,y:31867,varname:node_1067,prsc:2,v1:1;n:type:ShaderForge.SFN_Subtract,id:8967,x:32214,y:31946,varname:node_8967,prsc:2|A-1067-OUT,B-2603-OUT;n:type:ShaderForge.SFN_Add,id:2846,x:32610,y:31456,varname:node_2846,prsc:2|A-107-OUT,B-8847-OUT;n:type:ShaderForge.SFN_Multiply,id:2334,x:32098,y:31620,varname:node_2334,prsc:2|A-8104-OUT,B-3618-OUT;n:type:ShaderForge.SFN_Slider,id:3618,x:31558,y:31805,ptovrint:False,ptlb:opacityEdge,ptin:_opacityEdge,varname:node_3618,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Multiply,id:3764,x:32083,y:32776,varname:node_3764,prsc:2|A-8522-RGB,B-8506-RGB;n:type:ShaderForge.SFN_Lerp,id:3704,x:32282,y:32593,varname:node_3704,prsc:2|A-4479-OUT,B-3764-OUT,T-8522-A;n:type:ShaderForge.SFN_Multiply,id:4819,x:32737,y:32692,varname:node_4819,prsc:2|A-2110-OUT,B-6596-RGB;n:type:ShaderForge.SFN_Fresnel,id:8104,x:31903,y:31620,varname:node_8104,prsc:2;n:type:ShaderForge.SFN_Vector1,id:262,x:34303,y:32500,varname:node_262,prsc:2,v1:0;n:type:ShaderForge.SFN_Cubemap,id:9654,x:32630,y:32878,ptovrint:False,ptlb:cubemap_diff,ptin:_cubemap_diff,varname:node_9654,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,cube:505ad1f2167b27940a32891f3199ea68,pvfc:0|DIR-115-OUT;n:type:ShaderForge.SFN_NormalVector,id:115,x:32403,y:32878,prsc:2,pt:True;n:type:ShaderForge.SFN_ViewReflectionVector,id:3915,x:32403,y:33044,varname:node_3915,prsc:2;n:type:ShaderForge.SFN_Cubemap,id:7962,x:32630,y:33044,ptovrint:False,ptlb:cubemap_spec,ptin:_cubemap_spec,varname:_node_9654_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,cube:2df07c7503737d043bffc7dc781fb2ca,pvfc:0|DIR-3915-OUT;n:type:ShaderForge.SFN_Multiply,id:768,x:32960,y:32922,varname:node_768,prsc:2|A-4819-OUT,B-9654-RGB;n:type:ShaderForge.SFN_Multiply,id:1675,x:33234,y:31648,varname:node_1675,prsc:2|A-2556-OUT,B-768-OUT;n:type:ShaderForge.SFN_Add,id:9903,x:33561,y:31529,varname:node_9903,prsc:2|A-3125-OUT,B-1675-OUT;n:type:ShaderForge.SFN_Vector1,id:2556,x:33040,y:31648,varname:node_2556,prsc:2,v1:0.1;n:type:ShaderForge.SFN_Slider,id:2938,x:32798,y:33597,ptovrint:False,ptlb:normals,ptin:_normals,varname:_refraction_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.2,max:1;n:type:ShaderForge.SFN_Clamp01,id:2110,x:32836,y:31708,varname:node_2110,prsc:2|IN-566-OUT;n:type:ShaderForge.SFN_Multiply,id:492,x:33259,y:32872,varname:node_492,prsc:2|A-636-RGB,B-9654-RGB;n:type:ShaderForge.SFN_Color,id:636,x:32950,y:32706,ptovrint:False,ptlb:cubemap_color,ptin:_cubemap_color,varname:node_636,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Multiply,id:6358,x:33259,y:33039,varname:node_6358,prsc:2|A-636-RGB,B-7962-RGB;n:type:ShaderForge.SFN_Vector1,id:8557,x:34303,y:32680,varname:node_8557,prsc:2,v1:0.5;n:type:ShaderForge.SFN_OneMinus,id:5296,x:31800,y:31946,varname:node_5296,prsc:2|IN-2495-OUT;n:type:ShaderForge.SFN_Subtract,id:107,x:32325,y:31452,varname:node_107,prsc:2|A-8967-OUT,B-8636-OUT;n:type:ShaderForge.SFN_OneMinus,id:8636,x:32117,y:31452,varname:node_8636,prsc:2|IN-3431-OUT;n:type:ShaderForge.SFN_SwitchProperty,id:566,x:32610,y:31708,ptovrint:False,ptlb:emission_opacity,ptin:_emission_opacity,varname:node_566,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-1293-OUT,B-2846-OUT;n:type:ShaderForge.SFN_Subtract,id:2956,x:32413,y:31946,varname:node_2956,prsc:2|A-8967-OUT,B-2334-OUT;n:type:ShaderForge.SFN_Add,id:1293,x:32610,y:31946,varname:node_1293,prsc:2|A-2956-OUT,B-8847-OUT;n:type:ShaderForge.SFN_Add,id:8847,x:32325,y:31620,varname:node_8847,prsc:2|A-2334-OUT,B-2334-OUT;n:type:ShaderForge.SFN_Multiply,id:5013,x:31401,y:31079,varname:node_5013,prsc:2|A-5322-RGB,B-5322-A;proporder:1443-3495-1027-480-8506-6227-8522-2495-3618-926-5719-9327-566-3125-5322-2938-6669-6334-636-9654-7962;pass:END;sub:END;*/

Shader "Custom/Glass" {
    Properties {
        _baseUV_Scaling ("baseUV_Scaling", Range(0, 10)) = 1
        _detailUV_Scaling ("detailUV_Scaling", Range(0, 10)) = 1
        _roughness ("roughness", Range(0, 1)) = 0.3
        _color_base ("color_base", Color) = (0.3897059,0.4011678,0.4011678,1)
        _color_detail ("color_detail", Color) = (1,1,1,1)
        _base_diff ("base_diff", 2D) = "black" {}
        _detail_diff ("detail_diff", 2D) = "white" {}
        _opacityCenter ("opacityCenter", Range(0, 1)) = 0.2186107
        _opacityEdge ("opacityEdge", Range(0, 1)) = 1
        _emission_size ("emission_size", Range(0, 1)) = 0.5965691
        _emission_value ("emission_value", Range(0, 5)) = 1.751592
        _color_emission ("color_emission", Color) = (0.9400728,0.9705882,0.7493512,1)
        [MaterialToggle] _emission_opacity ("emission_opacity", Float ) = 2
        [MaterialToggle] _detail_blockLight ("detail_blockLight", Float ) = 0
        _base_emission ("base_emission", 2D) = "white" {}
        _normals ("normals", Range(0, 1)) = 0.2
        _refraction ("refraction", Range(0, 1)) = 0.5
        _base_normal ("base_normal", 2D) = "bump" {}
        _cubemap_color ("cubemap_color", Color) = (1,1,1,1)
        _cubemap_diff ("cubemap_diff", Cube) = "_Skybox" {}
        _cubemap_spec ("cubemap_spec", Cube) = "_Skybox" {}
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        LOD 200
        GrabPass{ }
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
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform sampler2D _GrabTexture;
            uniform sampler2D _base_diff; uniform float4 _base_diff_ST;
            uniform sampler2D _detail_diff; uniform float4 _detail_diff_ST;
            uniform float4 _color_detail;
            uniform float _roughness;
            uniform float4 _color_base;
            uniform float _detailUV_Scaling;
            uniform float _baseUV_Scaling;
            uniform sampler2D _base_normal; uniform float4 _base_normal_ST;
            uniform float _refraction;
            uniform sampler2D _base_emission; uniform float4 _base_emission_ST;
            uniform float4 _color_emission;
            uniform float _emission_value;
            uniform fixed _detail_blockLight;
            uniform float _emission_size;
            uniform float _opacityCenter;
            uniform float _opacityEdge;
            uniform samplerCUBE _cubemap_diff;
            uniform samplerCUBE _cubemap_spec;
            uniform float _normals;
            uniform float4 _cubemap_color;
            uniform fixed _emission_opacity;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                float4 screenPos : TEXCOORD5;
                UNITY_FOG_COORDS(6)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( _Object2World, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                UNITY_TRANSFER_FOG(o,o.pos);
                o.screenPos = o.pos;
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                #if UNITY_UV_STARTS_AT_TOP
                    float grabSign = -_ProjectionParams.x;
                #else
                    float grabSign = _ProjectionParams.x;
                #endif
                i.normalDir = normalize(i.normalDir);
                i.screenPos = float4( i.screenPos.xy / i.screenPos.w, 0, 0 );
                i.screenPos.y *= _ProjectionParams.x;
                float2 node_4676 = (_baseUV_Scaling*i.uv0);
                float3 _base_normal_var = UnpackNormal(tex2D(_base_normal,TRANSFORM_TEX(node_4676, _base_normal)));
                float2 node_7316 = (_base_normal_var.rgb.rg*(_refraction*0.2));
                float2 sceneUVs = float2(1,grabSign)*i.screenPos.xy*0.5+0.5 + node_7316;
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
/////// Vectors:
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalLocal = lerp(float3(0,0,1),_base_normal_var.rgb,_normals);
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
                float gloss = 1.0 - _roughness; // Convert roughness to gloss
                float specPow = exp2( gloss * 10.0+1.0);
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
                UnityGI gi = UnityGlobalIllumination (d, 1, gloss, normalDirection);
                lightDirection = gi.light.dir;
                lightColor = gi.light.color;
////// Specular:
                float NdotL = max(0, dot( normalDirection, lightDirection ));
                float LdotH = max(0.0,dot(lightDirection, halfDirection));
                float4 _base_diff_var = tex2D(_base_diff,TRANSFORM_TEX(node_4676, _base_diff));
                float2 node_997 = (_detailUV_Scaling*i.uv0);
                float4 _detail_diff_var = tex2D(_detail_diff,TRANSFORM_TEX(node_997, _detail_diff));
                float3 diffuseColor = lerp((_base_diff_var.rgb*_color_base.rgb),(_detail_diff_var.rgb*_color_detail.rgb),_detail_diff_var.a); // Need this for specular when using metallic
                float specularMonochrome;
                float3 specularColor;
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, 0.0, specularColor, specularMonochrome );
                specularMonochrome = 1-specularMonochrome;
                float NdotV = max(0.0,dot( normalDirection, viewDirection ));
                float NdotH = max(0.0,dot( normalDirection, halfDirection ));
                float VdotH = max(0.0,dot( viewDirection, halfDirection ));
                float visTerm = SmithBeckmannVisibilityTerm( NdotL, NdotV, 1.0-gloss );
                float normTerm = max(0.0, NDFBlinnPhongNormalizedTerm(NdotH, RoughnessToSpecPower(1.0-gloss)));
                float specularPBL = max(0, (NdotL*visTerm*normTerm) * unity_LightGammaCorrectionConsts_PIDiv4 );
                float3 directSpecular = (floor(attenuation) * _LightColor0.xyz) * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularPBL*lightColor*FresnelTerm(specularColor, LdotH);
                half grazingTerm = saturate( gloss + specularMonochrome );
                float3 indirectSpecular = (0 + (_cubemap_color.rgb*texCUBE(_cubemap_spec,viewReflectDirection).rgb));
                indirectSpecular *= FresnelLerp (specularColor, grazingTerm, NdotV);
                float3 specular = (directSpecular + indirectSpecular);
/////// Diffuse:
                NdotL = dot( normalDirection, lightDirection );
                float node_6434 = 1.0;
                float3 w = float3(node_6434,node_6434,node_6434)*0.5; // Light wrapping
                float3 NdotLWrap = NdotL * ( 1.0 - w );
                float3 forwardLight = max(float3(0.0,0.0,0.0), NdotLWrap + w );
                float node_8557 = 0.5;
                float3 backLight = max(float3(0.0,0.0,0.0), -NdotLWrap + w ) * float3(node_8557,node_8557,node_8557);
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                NdotLWrap = max(float3(0,0,0), NdotLWrap);
                float3 directDiffuse = ((forwardLight+backLight) + ((1 +(fd90 - 1)*pow((1.00001-NdotLWrap), 5)) * (1 + (fd90 - 1)*pow((1.00001-NdotV), 5)) * NdotL))*(0.5-max(w.r,max(w.g,w.b))*0.5) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float4 _cubemap_diff_var = texCUBE(_cubemap_diff,normalDirection);
                indirectDiffuse += (_cubemap_color.rgb*_cubemap_diff_var.rgb); // Diffuse Ambient Light
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
////// Emissive:
                float4 _base_emission_var = tex2D(_base_emission,TRANSFORM_TEX(i.uv0, _base_emission));
                float3 node_3431 = lerp((((_base_emission_var.rgb*_base_emission_var.a)*_color_emission.rgb)*_emission_value),float3(node_7316,0.0),pow(1.0-max(0,dot(normalDirection, viewDirection)),_emission_size));
                float node_5878 = (1.0 - _detail_diff_var.a);
                float node_8967 = (1.0-((1.0 - _opacityCenter)*node_5878));
                float node_2334 = ((1.0-max(0,dot(normalDirection, viewDirection)))*_opacityEdge);
                float node_8847 = (node_2334+node_2334);
                float3 node_2110 = saturate(lerp( ((node_8967-node_2334)+node_8847), ((node_8967-(1.0 - node_3431))+node_8847), _emission_opacity ));
                float3 emissive = (lerp( node_3431, (node_3431*node_5878), _detail_blockLight )+(0.1*((node_2110*unity_FogColor.rgb)*_cubemap_diff_var.rgb)));
/// Final Color:
                float3 finalColor = diffuse + specular + emissive;
                fixed4 finalRGBA = fixed4(lerp(sceneColor.rgb, finalColor,node_2110),1);
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
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdadd
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform sampler2D _GrabTexture;
            uniform sampler2D _base_diff; uniform float4 _base_diff_ST;
            uniform sampler2D _detail_diff; uniform float4 _detail_diff_ST;
            uniform float4 _color_detail;
            uniform float _roughness;
            uniform float4 _color_base;
            uniform float _detailUV_Scaling;
            uniform float _baseUV_Scaling;
            uniform sampler2D _base_normal; uniform float4 _base_normal_ST;
            uniform float _refraction;
            uniform sampler2D _base_emission; uniform float4 _base_emission_ST;
            uniform float4 _color_emission;
            uniform float _emission_value;
            uniform fixed _detail_blockLight;
            uniform float _emission_size;
            uniform float _opacityCenter;
            uniform float _opacityEdge;
            uniform samplerCUBE _cubemap_diff;
            uniform float _normals;
            uniform fixed _emission_opacity;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                float4 screenPos : TEXCOORD5;
                LIGHTING_COORDS(6,7)
                UNITY_FOG_COORDS(8)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( _Object2World, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                UNITY_TRANSFER_FOG(o,o.pos);
                o.screenPos = o.pos;
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                #if UNITY_UV_STARTS_AT_TOP
                    float grabSign = -_ProjectionParams.x;
                #else
                    float grabSign = _ProjectionParams.x;
                #endif
                i.normalDir = normalize(i.normalDir);
                i.screenPos = float4( i.screenPos.xy / i.screenPos.w, 0, 0 );
                i.screenPos.y *= _ProjectionParams.x;
                float2 node_4676 = (_baseUV_Scaling*i.uv0);
                float3 _base_normal_var = UnpackNormal(tex2D(_base_normal,TRANSFORM_TEX(node_4676, _base_normal)));
                float2 node_7316 = (_base_normal_var.rgb.rg*(_refraction*0.2));
                float2 sceneUVs = float2(1,grabSign)*i.screenPos.xy*0.5+0.5 + node_7316;
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
/////// Vectors:
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalLocal = lerp(float3(0,0,1),_base_normal_var.rgb,_normals);
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
                float gloss = 1.0 - _roughness; // Convert roughness to gloss
                float specPow = exp2( gloss * 10.0+1.0);
////// Specular:
                float NdotL = max(0, dot( normalDirection, lightDirection ));
                float LdotH = max(0.0,dot(lightDirection, halfDirection));
                float4 _base_diff_var = tex2D(_base_diff,TRANSFORM_TEX(node_4676, _base_diff));
                float2 node_997 = (_detailUV_Scaling*i.uv0);
                float4 _detail_diff_var = tex2D(_detail_diff,TRANSFORM_TEX(node_997, _detail_diff));
                float3 diffuseColor = lerp((_base_diff_var.rgb*_color_base.rgb),(_detail_diff_var.rgb*_color_detail.rgb),_detail_diff_var.a); // Need this for specular when using metallic
                float specularMonochrome;
                float3 specularColor;
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, 0.0, specularColor, specularMonochrome );
                specularMonochrome = 1-specularMonochrome;
                float NdotV = max(0.0,dot( normalDirection, viewDirection ));
                float NdotH = max(0.0,dot( normalDirection, halfDirection ));
                float VdotH = max(0.0,dot( viewDirection, halfDirection ));
                float visTerm = SmithBeckmannVisibilityTerm( NdotL, NdotV, 1.0-gloss );
                float normTerm = max(0.0, NDFBlinnPhongNormalizedTerm(NdotH, RoughnessToSpecPower(1.0-gloss)));
                float specularPBL = max(0, (NdotL*visTerm*normTerm) * unity_LightGammaCorrectionConsts_PIDiv4 );
                float3 directSpecular = attenColor * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularPBL*lightColor*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = dot( normalDirection, lightDirection );
                float node_6434 = 1.0;
                float3 w = float3(node_6434,node_6434,node_6434)*0.5; // Light wrapping
                float3 NdotLWrap = NdotL * ( 1.0 - w );
                float3 forwardLight = max(float3(0.0,0.0,0.0), NdotLWrap + w );
                float node_8557 = 0.5;
                float3 backLight = max(float3(0.0,0.0,0.0), -NdotLWrap + w ) * float3(node_8557,node_8557,node_8557);
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                NdotLWrap = max(float3(0,0,0), NdotLWrap);
                float3 directDiffuse = ((forwardLight+backLight) + ((1 +(fd90 - 1)*pow((1.00001-NdotLWrap), 5)) * (1 + (fd90 - 1)*pow((1.00001-NdotV), 5)) * NdotL))*(0.5-max(w.r,max(w.g,w.b))*0.5) * attenColor;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                float node_5878 = (1.0 - _detail_diff_var.a);
                float node_8967 = (1.0-((1.0 - _opacityCenter)*node_5878));
                float node_2334 = ((1.0-max(0,dot(normalDirection, viewDirection)))*_opacityEdge);
                float node_8847 = (node_2334+node_2334);
                float4 _base_emission_var = tex2D(_base_emission,TRANSFORM_TEX(i.uv0, _base_emission));
                float3 node_3431 = lerp((((_base_emission_var.rgb*_base_emission_var.a)*_color_emission.rgb)*_emission_value),float3(node_7316,0.0),pow(1.0-max(0,dot(normalDirection, viewDirection)),_emission_size));
                float3 node_2110 = saturate(lerp( ((node_8967-node_2334)+node_8847), ((node_8967-(1.0 - node_3431))+node_8847), _emission_opacity ));
                fixed4 finalRGBA = fixed4(finalColor * node_2110,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
