// Shader created with Shader Forge v1.18 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.18;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:1,spmd:0,trmd:0,grmd:1,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False;n:type:ShaderForge.SFN_Final,id:6347,x:34099,y:32709,varname:node_6347,prsc:2|diff-9508-OUT,emission-3084-OUT,alpha-8069-OUT;n:type:ShaderForge.SFN_Color,id:6252,x:32168,y:32822,ptovrint:False,ptlb:Outside Color,ptin:_OutsideColor,varname:node_6252,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.1265139,c2:0.2530277,c3:0.8602941,c4:1;n:type:ShaderForge.SFN_Lerp,id:9508,x:32820,y:32734,varname:node_9508,prsc:2|A-4848-OUT,B-3794-OUT,T-8477-OUT;n:type:ShaderForge.SFN_FragmentPosition,id:450,x:31830,y:33082,varname:node_450,prsc:2;n:type:ShaderForge.SFN_ViewPosition,id:8615,x:31830,y:33255,varname:node_8615,prsc:2;n:type:ShaderForge.SFN_Distance,id:309,x:32069,y:33211,varname:node_309,prsc:2|A-450-XYZ,B-8615-XYZ;n:type:ShaderForge.SFN_Divide,id:2139,x:32243,y:33263,varname:node_2139,prsc:2|A-309-OUT,B-8214-OUT;n:type:ShaderForge.SFN_Vector1,id:8214,x:32069,y:33344,varname:node_8214,prsc:2,v1:7.5;n:type:ShaderForge.SFN_Power,id:194,x:32412,y:33263,varname:node_194,prsc:2|VAL-2139-OUT,EXP-6366-OUT;n:type:ShaderForge.SFN_Vector1,id:6366,x:32412,y:33392,varname:node_6366,prsc:2,v1:2;n:type:ShaderForge.SFN_Clamp01,id:8477,x:32642,y:33050,varname:node_8477,prsc:2|IN-194-OUT;n:type:ShaderForge.SFN_DepthBlend,id:2908,x:32563,y:33550,varname:node_2908,prsc:2|DIST-7053-OUT;n:type:ShaderForge.SFN_Dot,id:3846,x:32132,y:33520,varname:node_3846,prsc:2,dt:1|A-9656-OUT,B-3578-OUT;n:type:ShaderForge.SFN_Vector1,id:3578,x:31977,y:33610,varname:node_3578,prsc:2,v1:1.5;n:type:ShaderForge.SFN_Normalize,id:9656,x:31823,y:33528,varname:node_9656,prsc:2|IN-194-OUT;n:type:ShaderForge.SFN_Color,id:4507,x:32204,y:32514,ptovrint:False,ptlb:Inside Color,ptin:_InsideColor,varname:_node_6252_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5352509,c2:0.5570636,c3:0.6617647,c4:1;n:type:ShaderForge.SFN_Vector1,id:7443,x:32132,y:33795,varname:node_7443,prsc:2,v1:2.5;n:type:ShaderForge.SFN_Add,id:8069,x:32813,y:33456,varname:node_8069,prsc:2|A-8477-OUT,B-2908-OUT;n:type:ShaderForge.SFN_Tex2d,id:7750,x:32022,y:31963,ptovrint:False,ptlb:Inside,ptin:_Inside,varname:node_7750,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:5011e6aecde38144cb5d947915238680,ntxv:0,isnm:False|UVIN-6188-UVOUT;n:type:ShaderForge.SFN_TexCoord,id:212,x:31506,y:31659,varname:node_212,prsc:2,uv:0;n:type:ShaderForge.SFN_Panner,id:6188,x:31757,y:31769,varname:node_6188,prsc:2,spu:1,spv:0|UVIN-212-UVOUT,DIST-3589-TSL;n:type:ShaderForge.SFN_Time,id:3589,x:31506,y:31846,varname:node_3589,prsc:2;n:type:ShaderForge.SFN_Tex2d,id:2067,x:31743,y:32302,ptovrint:False,ptlb:Outside,ptin:_Outside,varname:_node_7750_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:6d09fe43ddc56f1418f74b86a7dd4983,ntxv:0,isnm:False|UVIN-8654-UVOUT;n:type:ShaderForge.SFN_TexCoord,id:5200,x:31273,y:32112,varname:node_5200,prsc:2,uv:0;n:type:ShaderForge.SFN_Panner,id:8654,x:31540,y:32284,varname:node_8654,prsc:2,spu:0.5,spv:0|UVIN-5200-UVOUT,DIST-6336-OUT;n:type:ShaderForge.SFN_Time,id:485,x:30901,y:32121,varname:node_485,prsc:2;n:type:ShaderForge.SFN_Blend,id:3794,x:32400,y:32720,varname:node_3794,prsc:2,blmd:10,clmp:True|SRC-2067-RGB,DST-6252-RGB;n:type:ShaderForge.SFN_Blend,id:6672,x:32407,y:32398,varname:node_6672,prsc:2,blmd:10,clmp:True|SRC-7750-RGB,DST-4507-RGB;n:type:ShaderForge.SFN_Divide,id:1579,x:31091,y:32210,varname:node_1579,prsc:2|A-485-T,B-9411-OUT;n:type:ShaderForge.SFN_Vector1,id:9411,x:30901,y:32292,varname:node_9411,prsc:2,v1:40;n:type:ShaderForge.SFN_Power,id:7053,x:32376,y:33550,varname:node_7053,prsc:2|VAL-3846-OUT,EXP-7443-OUT;n:type:ShaderForge.SFN_Tex2d,id:4696,x:33016,y:31775,ptovrint:False,ptlb:Outside_copy,ptin:_Outside_copy,varname:_Outside_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:e958c6041cfe445e987c73751e8d4082,ntxv:0,isnm:False|UVIN-4928-UVOUT;n:type:ShaderForge.SFN_Panner,id:4928,x:32834,y:31724,varname:node_4928,prsc:2,spu:0.75,spv:0|UVIN-1705-UVOUT,DIST-9956-OUT;n:type:ShaderForge.SFN_TexCoord,id:1705,x:32472,y:31414,varname:node_1705,prsc:2,uv:0;n:type:ShaderForge.SFN_Divide,id:9908,x:32474,y:31724,varname:node_9908,prsc:2|A-5508-T,B-2571-OUT;n:type:ShaderForge.SFN_Vector1,id:2571,x:32278,y:31737,varname:node_2571,prsc:2,v1:16;n:type:ShaderForge.SFN_Time,id:5508,x:32299,y:31585,varname:node_5508,prsc:2;n:type:ShaderForge.SFN_Multiply,id:7613,x:33532,y:31576,varname:node_7613,prsc:2|A-6244-OUT,B-6516-OUT;n:type:ShaderForge.SFN_Lerp,id:3084,x:33453,y:32528,varname:node_3084,prsc:2|A-7613-OUT,B-9508-OUT,T-7946-OUT;n:type:ShaderForge.SFN_Vector1,id:7946,x:33453,y:32678,varname:node_7946,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Panner,id:3882,x:31862,y:31251,varname:node_3882,prsc:2,spu:0.1,spv:0;n:type:ShaderForge.SFN_ComponentMask,id:2014,x:32089,y:31322,varname:node_2014,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-3882-UVOUT;n:type:ShaderForge.SFN_Multiply,id:1768,x:33117,y:31314,cmnt:Glow,varname:node_1768,prsc:2|A-5002-RGB,B-8910-OUT,C-4747-OUT;n:type:ShaderForge.SFN_Color,id:5002,x:32888,y:30973,ptovrint:False,ptlb:Glow Color,ptin:_GlowColor,varname:_GlowColor,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Lerp,id:6244,x:33353,y:31576,varname:node_6244,prsc:2|A-1768-OUT,B-4696-RGB,T-7247-OUT;n:type:ShaderForge.SFN_Vector1,id:8910,x:32854,y:31222,varname:node_8910,prsc:2,v1:0.8;n:type:ShaderForge.SFN_Multiply,id:6753,x:32342,y:31187,varname:node_6753,prsc:2|A-2660-OUT,B-2014-OUT;n:type:ShaderForge.SFN_Vector1,id:2660,x:32113,y:31090,varname:node_2660,prsc:2,v1:4;n:type:ShaderForge.SFN_Sin,id:1132,x:32530,y:31227,varname:node_1132,prsc:2|IN-6753-OUT;n:type:ShaderForge.SFN_RemapRange,id:8489,x:32698,y:31256,varname:node_8489,prsc:2,frmn:-1,frmx:1,tomn:0,tomx:1|IN-1132-OUT;n:type:ShaderForge.SFN_Clamp01,id:4747,x:32870,y:31314,varname:node_4747,prsc:2|IN-8489-OUT;n:type:ShaderForge.SFN_Blend,id:4848,x:32636,y:32532,varname:node_4848,prsc:2,blmd:10,clmp:True|SRC-6672-OUT,DST-3794-OUT;n:type:ShaderForge.SFN_Sin,id:5649,x:32624,y:31724,varname:node_5649,prsc:2|IN-9908-OUT;n:type:ShaderForge.SFN_Slider,id:6516,x:33353,y:31460,ptovrint:False,ptlb:Emission,ptin:_Emission,varname:node_6516,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:2;n:type:ShaderForge.SFN_Vector1,id:7247,x:33353,y:31711,varname:node_7247,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Add,id:9956,x:32701,y:31935,varname:node_9956,prsc:2|A-5649-OUT,B-2786-OUT;n:type:ShaderForge.SFN_Divide,id:2786,x:32474,y:31861,varname:node_2786,prsc:2|A-5508-T,B-2668-OUT;n:type:ShaderForge.SFN_Vector1,id:2668,x:32278,y:31810,varname:node_2668,prsc:2,v1:12;n:type:ShaderForge.SFN_Add,id:6336,x:31320,y:32460,varname:node_6336,prsc:2|A-5345-OUT,B-1353-OUT;n:type:ShaderForge.SFN_Divide,id:1353,x:31091,y:32419,varname:node_1353,prsc:2|A-485-T,B-170-OUT;n:type:ShaderForge.SFN_Vector1,id:170,x:30901,y:32419,varname:node_170,prsc:2,v1:32;n:type:ShaderForge.SFN_Sin,id:5345,x:31273,y:32290,varname:node_5345,prsc:2|IN-1579-OUT;n:type:ShaderForge.SFN_Tex2dAsset,id:6104,x:31512,y:32523,ptovrint:False,ptlb:Outside,ptin:_Outside,varname:node_6104,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:6d09fe43ddc56f1418f74b86a7dd4983,ntxv:0,isnm:True;n:type:ShaderForge.SFN_Tex2d,id:7138,x:31713,y:32523,varname:_node_7750_copy,prsc:2,tex:6d09fe43ddc56f1418f74b86a7dd4983,ntxv:0,isnm:False|TEX-6104-TEX;n:type:ShaderForge.SFN_TexCoord,id:8977,x:31282,y:32648,varname:node_8977,prsc:2,uv:0;n:type:ShaderForge.SFN_Panner,id:6481,x:31549,y:32820,varname:node_6481,prsc:2,spu:1,spv:0|UVIN-8977-UVOUT,DIST-8233-OUT;n:type:ShaderForge.SFN_Time,id:5224,x:30910,y:32657,varname:node_5224,prsc:2;n:type:ShaderForge.SFN_Divide,id:9029,x:31100,y:32746,varname:node_9029,prsc:2|A-5224-T,B-7950-OUT;n:type:ShaderForge.SFN_Vector1,id:7950,x:30910,y:32828,varname:node_7950,prsc:2,v1:40;n:type:ShaderForge.SFN_Add,id:8233,x:31329,y:32996,varname:node_8233,prsc:2|A-6932-OUT,B-3334-OUT;n:type:ShaderForge.SFN_Divide,id:3334,x:31100,y:32955,varname:node_3334,prsc:2|A-5224-T,B-1013-OUT;n:type:ShaderForge.SFN_Vector1,id:1013,x:30910,y:32955,varname:node_1013,prsc:2,v1:32;n:type:ShaderForge.SFN_Sin,id:6932,x:31282,y:32826,varname:node_6932,prsc:2|IN-9029-OUT;proporder:6252-4507-7750-4696-5002-6516-6104-2067;pass:END;sub:END;*/

Shader "Custom/NewShader" {
    Properties {
        _OutsideColor ("Outside Color", Color) = (0.1265139,0.2530277,0.8602941,1)
        _InsideColor ("Inside Color", Color) = (0.5352509,0.5570636,0.6617647,1)
        _Inside ("Inside", 2D) = "white" {}
        _Outside_copy ("Outside_copy", 2D) = "white" {}
        _GlowColor ("Glow Color", Color) = (1,1,1,1)
        _Emission ("Emission", Range(0, 2)) = 1
        _Outside ("Outside", 2D) = "white" {}
        _Outside ("Outside", 2D) = "white" {}
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        LOD 200
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
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _CameraDepthTexture;
            uniform float4 _TimeEditor;
            uniform float4 _OutsideColor;
            uniform float4 _InsideColor;
            uniform sampler2D _Inside; uniform float4 _Inside_ST;
            uniform sampler2D _Outside; uniform float4 _Outside_ST;
            uniform sampler2D _Outside_copy; uniform float4 _Outside_copy_ST;
            uniform float4 _GlowColor;
            uniform float _Emission;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float4 projPos : TEXCOORD3;
                UNITY_FOG_COORDS(4)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float sceneZ = max(0,LinearEyeDepth (UNITY_SAMPLE_DEPTH(tex2Dproj(_CameraDepthTexture, UNITY_PROJ_COORD(i.projPos)))) - _ProjectionParams.g);
                float partZ = max(0,i.projPos.z - _ProjectionParams.g);
/////// Vectors:
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
                float4 node_3589 = _Time + _TimeEditor;
                float2 node_6188 = (i.uv0+node_3589.r*float2(1,0));
                float4 _Inside_var = tex2D(_Inside,TRANSFORM_TEX(node_6188, _Inside));
                float4 node_485 = _Time + _TimeEditor;
                float2 node_8654 = (i.uv0+(sin((node_485.g/40.0))+(node_485.g/32.0))*float2(0.5,0));
                float4 _Outside_var = tex2D(_Outside,TRANSFORM_TEX(node_8654, _Outside));
                float3 node_3794 = saturate(( _OutsideColor.rgb > 0.5 ? (1.0-(1.0-2.0*(_OutsideColor.rgb-0.5))*(1.0-_Outside_var.rgb)) : (2.0*_OutsideColor.rgb*_Outside_var.rgb) ));
                float node_194 = pow((distance(i.posWorld.rgb,_WorldSpaceCameraPos)/7.5),2.0);
                float node_8477 = saturate(node_194);
                float3 node_9508 = lerp(saturate(( node_3794 > 0.5 ? (1.0-(1.0-2.0*(node_3794-0.5))*(1.0-saturate(( _InsideColor.rgb > 0.5 ? (1.0-(1.0-2.0*(_InsideColor.rgb-0.5))*(1.0-_Inside_var.rgb)) : (2.0*_InsideColor.rgb*_Inside_var.rgb) )))) : (2.0*node_3794*saturate(( _InsideColor.rgb > 0.5 ? (1.0-(1.0-2.0*(_InsideColor.rgb-0.5))*(1.0-_Inside_var.rgb)) : (2.0*_InsideColor.rgb*_Inside_var.rgb) ))) )),node_3794,node_8477);
                float3 diffuseColor = node_9508;
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
////// Emissive:
                float4 node_7804 = _Time + _TimeEditor;
                float4 node_5508 = _Time + _TimeEditor;
                float2 node_4928 = (i.uv0+(sin((node_5508.g/16.0))+(node_5508.g/12.0))*float2(0.75,0));
                float4 _Outside_copy_var = tex2D(_Outside_copy,TRANSFORM_TEX(node_4928, _Outside_copy));
                float3 emissive = lerp((lerp((_GlowColor.rgb*0.8*saturate((sin((4.0*(i.uv0+node_7804.g*float2(0.1,0)).r))*0.5+0.5))),_Outside_copy_var.rgb,0.5)*_Emission),node_9508,0.5);
/// Final Color:
                float3 finalColor = diffuse + emissive;
                fixed4 finalRGBA = fixed4(finalColor,(node_8477+saturate((sceneZ-partZ)/pow(max(0,dot(normalize(node_194),1.5)),2.5))));
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
            #pragma multi_compile_fwdadd
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _CameraDepthTexture;
            uniform float4 _TimeEditor;
            uniform float4 _OutsideColor;
            uniform float4 _InsideColor;
            uniform sampler2D _Inside; uniform float4 _Inside_ST;
            uniform sampler2D _Outside; uniform float4 _Outside_ST;
            uniform sampler2D _Outside_copy; uniform float4 _Outside_copy_ST;
            uniform float4 _GlowColor;
            uniform float _Emission;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float4 projPos : TEXCOORD3;
                LIGHTING_COORDS(4,5)
                UNITY_FOG_COORDS(6)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float sceneZ = max(0,LinearEyeDepth (UNITY_SAMPLE_DEPTH(tex2Dproj(_CameraDepthTexture, UNITY_PROJ_COORD(i.projPos)))) - _ProjectionParams.g);
                float partZ = max(0,i.projPos.z - _ProjectionParams.g);
/////// Vectors:
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
/////// Diffuse:
                float NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float4 node_3589 = _Time + _TimeEditor;
                float2 node_6188 = (i.uv0+node_3589.r*float2(1,0));
                float4 _Inside_var = tex2D(_Inside,TRANSFORM_TEX(node_6188, _Inside));
                float4 node_485 = _Time + _TimeEditor;
                float2 node_8654 = (i.uv0+(sin((node_485.g/40.0))+(node_485.g/32.0))*float2(0.5,0));
                float4 _Outside_var = tex2D(_Outside,TRANSFORM_TEX(node_8654, _Outside));
                float3 node_3794 = saturate(( _OutsideColor.rgb > 0.5 ? (1.0-(1.0-2.0*(_OutsideColor.rgb-0.5))*(1.0-_Outside_var.rgb)) : (2.0*_OutsideColor.rgb*_Outside_var.rgb) ));
                float node_194 = pow((distance(i.posWorld.rgb,_WorldSpaceCameraPos)/7.5),2.0);
                float node_8477 = saturate(node_194);
                float3 node_9508 = lerp(saturate(( node_3794 > 0.5 ? (1.0-(1.0-2.0*(node_3794-0.5))*(1.0-saturate(( _InsideColor.rgb > 0.5 ? (1.0-(1.0-2.0*(_InsideColor.rgb-0.5))*(1.0-_Inside_var.rgb)) : (2.0*_InsideColor.rgb*_Inside_var.rgb) )))) : (2.0*node_3794*saturate(( _InsideColor.rgb > 0.5 ? (1.0-(1.0-2.0*(_InsideColor.rgb-0.5))*(1.0-_Inside_var.rgb)) : (2.0*_InsideColor.rgb*_Inside_var.rgb) ))) )),node_3794,node_8477);
                float3 diffuseColor = node_9508;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse;
                fixed4 finalRGBA = fixed4(finalColor * (node_8477+saturate((sceneZ-partZ)/pow(max(0,dot(normalize(node_194),1.5)),2.5))),0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
