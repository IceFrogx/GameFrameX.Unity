
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LuBan.Runtime;
using GameFrameX.Config.Runtime;
using SimpleJSON;

namespace Hotfix.Config
{
    public sealed partial class DefineFromExcel2 : LuBan.Runtime.BeanBase
    {
        public DefineFromExcel2(JSONNode _buf)
        {
            { if(!_buf["id"].IsNumber) { throw new SerializationException(); }  Id = _buf["id"]; }
            { if(!_buf["x1"].IsBoolean) { throw new SerializationException(); }  X1 = _buf["x1"]; }
            { if(!_buf["x5"].IsNumber) { throw new SerializationException(); }  X5 = _buf["x5"]; }
            { if(!_buf["x6"].IsNumber) { throw new SerializationException(); }  X6 = _buf["x6"]; }
            { if(!_buf["x8"].IsNumber) { throw new SerializationException(); }  X8 = _buf["x8"]; }
            { if(!_buf["x10"].IsString) { throw new SerializationException(); }  X10 = _buf["x10"]; }
            { if(!_buf["x13"].IsNumber) { throw new SerializationException(); }  X13 = (test.DemoEnum)_buf["x13"].AsInt; }
            { if(!_buf["x13_2"].IsNumber) { throw new SerializationException(); }  X132 = (test.DemoFlag)_buf["x13_2"].AsInt; }
            { if(!_buf["x14"].IsObject) { throw new SerializationException(); }  X14 = test.DemoDynamic.DeserializeDemoDynamic(_buf["x14"]);  }
            { if(!_buf["x15"].IsObject) { throw new SerializationException(); }  X15 = test.Shape.DeserializeShape(_buf["x15"]);  }
            { if(!_buf["v2"].IsObject) { throw new SerializationException(); }  V2 = ExternalTypeUtil.NewVector2(vec2.Deserializevec2(_buf["v2"]));  }
            { if(!_buf["t1"].IsNumber) { throw new SerializationException(); }  T1 = _buf["t1"]; }
            { var __json0 = _buf["k1"]; if(!__json0.IsArray) { throw new SerializationException(); } int _n0 = __json0.Count; K1 = new int[_n0]; int __index0=0; foreach(JSONNode __e0 in __json0.Children) { int __v0;  { if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = __e0; }  K1[__index0++] = __v0; }   }
            { var __json0 = _buf["k2"]; if(!__json0.IsArray) { throw new SerializationException(); } int _n0 = __json0.Count; K2 = new int[_n0]; int __index0=0; foreach(JSONNode __e0 in __json0.Children) { int __v0;  { if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = __e0; }  K2[__index0++] = __v0; }   }
            { var __json0 = _buf["k8"]; if(!__json0.IsArray) { throw new SerializationException(); } K8 = new System.Collections.Generic.Dictionary<int, int>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { int _k0;  { if(!__e0[0].IsNumber) { throw new SerializationException(); }  _k0 = __e0[0]; } int _v0;  { if(!__e0[1].IsNumber) { throw new SerializationException(); }  _v0 = __e0[1]; }  K8.Add(_k0, _v0); }   }
            { var __json0 = _buf["k9"]; if(!__json0.IsArray) { throw new SerializationException(); } K9 = new System.Collections.Generic.List<test.DemoE2>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { test.DemoE2 __v0;  { if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = test.DemoE2.DeserializeDemoE2(__e0);  }  K9.Add(__v0); }   }
            { var __json0 = _buf["k10"]; if(!__json0.IsArray) { throw new SerializationException(); } K10 = new System.Collections.Generic.List<UnityEngine.Vector3>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { UnityEngine.Vector3 __v0;  { if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = ExternalTypeUtil.NewVector3(vec3.Deserializevec3(__e0));  }  K10.Add(__v0); }   }
            { var __json0 = _buf["k11"]; if(!__json0.IsArray) { throw new SerializationException(); } K11 = new System.Collections.Generic.List<UnityEngine.Vector4>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { UnityEngine.Vector4 __v0;  { if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = ExternalTypeUtil.NewVector4(vec4.Deserializevec4(__e0));  }  K11.Add(__v0); }   }
            { var _j = _buf["v11"]; if (_j.Tag != JSONNodeType.None && _j.Tag != JSONNodeType.NullValue) { { if(!_j.IsObject) { throw new SerializationException(); }  V11 = ExternalTypeUtil.NewVector3(vec3.Deserializevec3(_j));  } } else { V11 = null; } }
            PostInit();
        }

        public static DefineFromExcel2 DeserializeDefineFromExcel2(JSONNode _buf)
        {
            return new DefineFromExcel2(_buf);
        }

        /// <summary>
        /// 这是id
        /// </summary>
        public readonly int Id;
        /// <summary>
        /// 字段x1
        /// </summary>
        public readonly bool X1;
        public readonly long X5;
        public readonly float X6;
        public readonly int X8;
        public readonly string X10;
        public readonly test.DemoEnum X13;
        public readonly test.DemoFlag X132;
        public readonly test.DemoDynamic X14;
        public readonly test.Shape X15;
        public readonly UnityEngine.Vector2 V2;
        public readonly long T1;
        public readonly int[] K1;
        public readonly int[] K2;
        public readonly System.Collections.Generic.Dictionary<int, int> K8;
        public readonly System.Collections.Generic.List<test.DemoE2> K9;
        public readonly System.Collections.Generic.List<UnityEngine.Vector3> K10;
        public readonly System.Collections.Generic.List<UnityEngine.Vector4> K11;
        public readonly UnityEngine.Vector3? V11;
        public const int __ID__ = 482045152;
        public override int GetTypeId() => __ID__;

        public  void ResolveRef(TablesComponent tables)
        {
            
            
            
            
            
            
            
            
            X14?.ResolveRef(tables);
            X15?.ResolveRef(tables);
            
            
            
            
            
            
            
            
            
        }

        public override string ToString()
        {
            return "{ "
            + "id:" + Id + ","
            + "x1:" + X1 + ","
            + "x5:" + X5 + ","
            + "x6:" + X6 + ","
            + "x8:" + X8 + ","
            + "x10:" + X10 + ","
            + "x13:" + X13 + ","
            + "x132:" + X132 + ","
            + "x14:" + X14 + ","
            + "x15:" + X15 + ","
            + "v2:" + V2 + ","
            + "t1:" + T1 + ","
            + "k1:" + StringUtil.CollectionToString(K1) + ","
            + "k2:" + StringUtil.CollectionToString(K2) + ","
            + "k8:" + StringUtil.CollectionToString(K8) + ","
            + "k9:" + StringUtil.CollectionToString(K9) + ","
            + "k10:" + StringUtil.CollectionToString(K10) + ","
            + "k11:" + StringUtil.CollectionToString(K11) + ","
            + "v11:" + V11 + ","
            + "}";
        }

        partial void PostInit();
    }
}
