// Shader created with Shader Forge v1.18 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.18;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:3,spmd:1,trmd:0,grmd:1,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False;n:type:ShaderForge.SFN_Final,id:2370,x:32714,y:32699,varname:node_2370,prsc:2|diff-8735-OUT,spec-3887-OUT,gloss-3349-OUT,normal-8516-OUT,difocc-8423-R;n:type:ShaderForge.SFN_Tex2d,id:6227,x:31514,y:32262,ptovrint:False,ptlb:base_diff,ptin:_base_diff,varname:node_6227,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:8d6587bc02e41b64983e2bed28b913cd,ntxv:0,isnm:False|UVIN-4676-OUT;n:type:ShaderForge.SFN_Tex2d,id:8522,x:31515,y:32646,ptovrint:False,ptlb:detail_diff,ptin:_detail_diff,varname:node_8522,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:0052cf7f71eda95478c573cfc11b5205,ntxv:0,isnm:False|UVIN-997-OUT;n:type:ShaderForge.SFN_Color,id:8506,x:31515,y:32841,ptovrint:False,ptlb:color_detail,ptin:_color_detail,varname:node_8506,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Multiply,id:8201,x:31753,y:32749,varname:node_8201,prsc:2|A-8522-RGB,B-8506-RGB;n:type:ShaderForge.SFN_Slider,id:7653,x:31462,y:33651,ptovrint:False,ptlb:slider_baseMetal,ptin:_slider_baseMetal,varname:node_7653,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Slider,id:1027,x:31467,y:34020,ptovrint:False,ptlb:slider_baseRoughness,ptin:_slider_baseRoughness,varname:node_1027,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.5,max:1;n:type:ShaderForge.SFN_Color,id:480,x:31514,y:32465,ptovrint:False,ptlb:color_base,ptin:_color_base,varname:node_480,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Multiply,id:4479,x:31732,y:32362,varname:node_4479,prsc:2|A-6227-RGB,B-480-RGB;n:type:ShaderForge.SFN_Tex2d,id:2965,x:31584,y:33785,ptovrint:False,ptlb:base_metal,ptin:_base_metal,varname:node_2965,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:1,isnm:False|UVIN-4676-OUT;n:type:ShaderForge.SFN_Multiply,id:6796,x:31832,y:33703,varname:node_6796,prsc:2|A-7653-OUT,B-2965-RGB;n:type:ShaderForge.SFN_Multiply,id:9147,x:31832,y:33868,varname:node_9147,prsc:2|A-2965-A,B-1027-OUT;n:type:ShaderForge.SFN_Lerp,id:8735,x:32106,y:32718,varname:node_8735,prsc:2|A-4479-OUT,B-8201-OUT,T-8522-A;n:type:ShaderForge.SFN_Tex2d,id:5506,x:31502,y:33100,ptovrint:False,ptlb:base_normal,ptin:_base_normal,varname:node_5506,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:3,isnm:True|UVIN-4676-OUT;n:type:ShaderForge.SFN_TexCoord,id:9145,x:30718,y:33002,varname:node_9145,prsc:2,uv:0;n:type:ShaderForge.SFN_Tex2d,id:8423,x:31973,y:32977,ptovrint:False,ptlb:base_AO,ptin:_base_AO,varname:node_8423,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:1,isnm:False|UVIN-9145-UVOUT;n:type:ShaderForge.SFN_Tex2d,id:3531,x:31502,y:33306,ptovrint:False,ptlb:detail_normal,ptin:_detail_normal,varname:_normal_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:3,isnm:True|UVIN-997-OUT;n:type:ShaderForge.SFN_Lerp,id:8516,x:31788,y:33194,varname:node_8516,prsc:2|A-5506-RGB,B-3531-RGB,T-66-OUT;n:type:ShaderForge.SFN_Vector1,id:66,x:31502,y:33476,varname:node_66,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Slider,id:9965,x:31468,y:34188,ptovrint:False,ptlb:slider_detailMetal,ptin:_slider_detailMetal,varname:_metal_slider_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Slider,id:9361,x:31473,y:34553,ptovrint:False,ptlb:slider_detailRoughness,ptin:_slider_detailRoughness,varname:_roughness_slider_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.5,max:1;n:type:ShaderForge.SFN_Tex2d,id:5009,x:31572,y:34321,ptovrint:False,ptlb:detail_metal,ptin:_detail_metal,varname:_metal_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:1,isnm:False|UVIN-997-OUT;n:type:ShaderForge.SFN_Multiply,id:7095,x:31837,y:34240,varname:node_7095,prsc:2|A-9965-OUT,B-5009-RGB;n:type:ShaderForge.SFN_Multiply,id:2715,x:31837,y:34405,varname:node_2715,prsc:2|A-5009-A,B-9361-OUT;n:type:ShaderForge.SFN_Lerp,id:3887,x:32281,y:33701,varname:node_3887,prsc:2|A-6796-OUT,B-7095-OUT,T-7095-OUT;n:type:ShaderForge.SFN_Lerp,id:3349,x:32281,y:33884,varname:node_3349,prsc:2|A-9147-OUT,B-2715-OUT,T-5009-A;n:type:ShaderForge.SFN_TexCoord,id:652,x:30714,y:33528,varname:node_652,prsc:2,uv:0;n:type:ShaderForge.SFN_Slider,id:3495,x:30570,y:33367,ptovrint:False,ptlb:slider_detailUV,ptin:_slider_detailUV,varname:node_3495,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:10;n:type:ShaderForge.SFN_Multiply,id:997,x:30971,y:33429,varname:node_997,prsc:2|A-3495-OUT,B-652-UVOUT;n:type:ShaderForge.SFN_Slider,id:1443,x:30561,y:32829,ptovrint:False,ptlb:slider_baseUV,ptin:_slider_baseUV,varname:node_1443,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:10;n:type:ShaderForge.SFN_Multiply,id:4676,x:31004,y:32898,varname:node_4676,prsc:2|A-1443-OUT,B-9145-UVOUT;proporder:480-8506-1443-7653-1027-3495-9965-9361-6227-5506-2965-8423-8522-3531-5009;pass:END;sub:END;*/

Shader "Custom/Glass" {
    Properties {
        _color_base ("color_base", Color) = (1,1,1,1)
        _color_detail ("color_detail", Color) = (1,1,1,1)
        _slider_baseUV ("slider_baseUV", Range(0, 10)) = 1
        _slider_baseMetal ("slider_baseMetal", Range(0, 1)) = 0
        _slider_baseRoughness ("slider_baseRoughness", Range(0, 1)) = 0.5
        _slider_detailUV ("slider_detailUV", Range(0, 10)) = 1
        _slider_detailMetal ("slider_detailMetal", Range(0, 1)) = 0
        _slider_detailRoughness ("slider_detailRoughness", Range(0, 1)) = 0.5
        _base_diff ("base_diff", 2D) = "white" {}
        _base_normal ("base_normal", 2D) = "bump" {}
        _base_metal ("base_metal", 2D) = "gray" {}
        _base_AO ("base_AO", 2D) = "gray" {}
        _detail_diff ("detail_diff", 2D) = "white" {}
        _detail_normal ("detail_normal", 2D) = "bump" {}
        _detail_metal ("detail_metal", 2D) = "gray" {}
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        LOD 200
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform sampler2D _base_diff; uniform float4 _base_diff_ST;
            uniform sampler2D _detail_diff; uniform float4 _detail_diff_ST;
            uniform float4 _color_detail;
            uniform float _slider_baseMetal;
            uniform float _slider_baseRoughness;
            uniform float4 _color_base;
            uniform sampler2D _base_metal; uniform float4 _base_metal_ST;
            uniform sampler2D _base_normal; uniform float4 _base_normal_ST;
            uniform sampler2D _base_AO; uniform float4 _base_AO_ST;
            uniform sampler2D _detail_normal; uniform float4 _detail_normal_ST;
            uniform float _slider_detailMetal;
            uniform float _slider_detailRoughness;
            uniform sampler2D _detail_metal; uniform float4 _detail_metal_ST;
            uniform float _slider_detailUV;
            uniform float _slider_baseUV;
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
                LIGHTING_COORDS(5,6)
                UNITY_FOG_COORDS(7)
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
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
/////// Vectors:
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float2 node_4676 = (_slider_baseUV*i.uv0);
                float3 _base_normal_var = UnpackNormal(tex2D(_base_normal,TRANSFORM_TEX(node_4676, _base_normal)));
                float2 node_997 = (_slider_detailUV*i.uv0);
                float3 _detail_normal_var = UnpackNormal(tex2D(_detail_normal,TRANSFORM_TEX(node_997, _detail_normal)));
                float3 normalLocal = lerp(_base_normal_var.rgb,_detail_normal_var.rgb,0.5);
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float4 _base_metal_var = tex2D(_base_metal,TRANSFORM_TEX(node_4676, _base_metal));
                float4 _detail_metal_var = tex2D(_detail_metal,TRANSFORM_TEX(node_997, _detail_metal));
                float gloss = 1.0 - lerp((_base_metal_var.a*_slider_baseRoughness),(_detail_metal_var.a*_slider_detailRoughness),_detail_metal_var.a); // Convert roughness to gloss
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
                float4 _detail_diff_var = tex2D(_detail_diff,TRANSFORM_TEX(node_997, _detail_diff));
                float3 diffuseColor = lerp((_base_diff_var.rgb*_color_base.rgb),(_detail_diff_var.rgb*_color_detail.rgb),_detail_diff_var.a); // Need this for specular when using metallic
                float specularMonochrome;
                float3 specularColor;
                float3 node_7095 = (_slider_detailMetal*_detail_metal_var.rgb);
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, lerp((_slider_baseMetal*_base_metal_var.rgb),node_7095,node_7095).r, specularColor, specularMonochrome );
                specularMonochrome = 1-specularMonochrome;
                float NdotV = max(0.0,dot( normalDirection, viewDirection ));
                float NdotH = max(0.0,dot( normalDirection, halfDirection ));
                float VdotH = max(0.0,dot( viewDirection, halfDirection ));
                float visTerm = SmithBeckmannVisibilityTerm( NdotL, NdotV, 1.0-gloss );
                float normTerm = max(0.0, NDFBlinnPhongNormalizedTerm(NdotH, RoughnessToSpecPower(1.0-gloss)));
                float specularPBL = max(0, (NdotL*visTerm*normTerm) * unity_LightGammaCorrectionConsts_PIDiv4 );
                float3 directSpecular = (floor(attenuation) * _LightColor0.xyz) * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularPBL*lightColor*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float3 directDiffuse = ((1 +(fd90 - 1)*pow((1.00001-NdotL), 5)) * (1 + (fd90 - 1)*pow((1.00001-NdotV), 5)) * NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float4 _base_AO_var = tex2D(_base_AO,TRANSFORM_TEX(i.uv0, _base_AO));
                indirectDiffuse *= _base_AO_var.r; // Diffuse AO
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                fixed4 finalRGBA = fixed4(finalColor,1);
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
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform sampler2D _base_diff; uniform float4 _base_diff_ST;
            uniform sampler2D _detail_diff; uniform float4 _detail_diff_ST;
            uniform float4 _color_detail;
            uniform float _slider_baseMetal;
            uniform float _slider_baseRoughness;
            uniform float4 _color_base;
            uniform sampler2D _base_metal; uniform float4 _base_metal_ST;
            uniform sampler2D _base_normal; uniform float4 _base_normal_ST;
            uniform sampler2D _detail_normal; uniform float4 _detail_normal_ST;
            uniform float _slider_detailMetal;
            uniform float _slider_detailRoughness;
            uniform sampler2D _detail_metal; uniform float4 _detail_metal_ST;
            uniform float _slider_detailUV;
            uniform float _slider_baseUV;
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
                LIGHTING_COORDS(5,6)
                UNITY_FOG_COORDS(7)
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
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
/////// Vectors:
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float2 node_4676 = (_slider_baseUV*i.uv0);
                float3 _base_normal_var = UnpackNormal(tex2D(_base_normal,TRANSFORM_TEX(node_4676, _base_normal)));
                float2 node_997 = (_slider_detailUV*i.uv0);
                float3 _detail_normal_var = UnpackNormal(tex2D(_detail_normal,TRANSFORM_TEX(node_997, _detail_normal)));
                float3 normalLocal = lerp(_base_normal_var.rgb,_detail_normal_var.rgb,0.5);
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
                float4 _base_metal_var = tex2D(_base_metal,TRANSFORM_TEX(node_4676, _base_metal));
                float4 _detail_metal_var = tex2D(_detail_metal,TRANSFORM_TEX(node_997, _detail_metal));
                float gloss = 1.0 - lerp((_base_metal_var.a*_slider_baseRoughness),(_detail_metal_var.a*_slider_detailRoughness),_detail_metal_var.a); // Convert roughness to gloss
                float specPow = exp2( gloss * 10.0+1.0);
////// Specular:
                float NdotL = max(0, dot( normalDirection, lightDirection ));
                float LdotH = max(0.0,dot(lightDirection, halfDirection));
                float4 _base_diff_var = tex2D(_base_diff,TRANSFORM_TEX(node_4676, _base_diff));
                float4 _detail_diff_var = tex2D(_detail_diff,TRANSFORM_TEX(node_997, _detail_diff));
                float3 diffuseColor = lerp((_base_diff_var.rgb*_color_base.rgb),(_detail_diff_var.rgb*_color_detail.rgb),_detail_diff_var.a); // Need this for specular when using metallic
                float specularMonochrome;
                float3 specularColor;
                float3 node_7095 = (_slider_detailMetal*_detail_metal_var.rgb);
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, lerp((_slider_baseMetal*_base_metal_var.rgb),node_7095,node_7095).r, specularColor, specularMonochrome );
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
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float3 directDiffuse = ((1 +(fd90 - 1)*pow((1.00001-NdotL), 5)) * (1 + (fd90 - 1)*pow((1.00001-NdotV), 5)) * NdotL) * attenColor;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                fixed4 finalRGBA = fixed4(finalColor * 1,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
