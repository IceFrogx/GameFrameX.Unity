
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

namespace Hotfix.Config.test
{
    public sealed partial class TestScriptableObject : LuBan.Runtime.BeanBase
    {
        public TestScriptableObject(JSONNode _buf)
        {
            { if(!_buf["id"].IsNumber) { throw new SerializationException(); }  Id = _buf["id"]; }
            { if(!_buf["desc"].IsString) { throw new SerializationException(); }  Desc = _buf["desc"]; }
            { if(!_buf["rate"].IsNumber) { throw new SerializationException(); }  Rate = _buf["rate"]; }
            { if(!_buf["num"].IsNumber) { throw new SerializationException(); }  Num = _buf["num"]; }
            { if(!_buf["v2"].IsObject) { throw new SerializationException(); }  V2 = ExternalTypeUtil.NewVector2(vec2.Deserializevec2(_buf["v2"]));  }
            { if(!_buf["v3"].IsObject) { throw new SerializationException(); }  V3 = ExternalTypeUtil.NewVector3(vec3.Deserializevec3(_buf["v3"]));  }
            { if(!_buf["v4"].IsObject) { throw new SerializationException(); }  V4 = ExternalTypeUtil.NewVector4(vec4.Deserializevec4(_buf["v4"]));  }
            PostInit();
        }

        public static TestScriptableObject DeserializeTestScriptableObject(JSONNode _buf)
        {
            return new test.TestScriptableObject(_buf);
        }

        public readonly int Id;
        public readonly string Desc;
        public readonly float Rate;
        public readonly int Num;
        public readonly UnityEngine.Vector2 V2;
        public readonly UnityEngine.Vector3 V3;
        public readonly UnityEngine.Vector4 V4;
        public const int __ID__ = -1896814350;
        public override int GetTypeId() => __ID__;

        public  void ResolveRef(TablesComponent tables)
        {
            
            
            
            
            
            
            
        }

        public override string ToString()
        {
            return "{ "
            + "id:" + Id + ","
            + "desc:" + Desc + ","
            + "rate:" + Rate + ","
            + "num:" + Num + ","
            + "v2:" + V2 + ","
            + "v3:" + V3 + ","
            + "v4:" + V4 + ","
            + "}";
        }

        partial void PostInit();
    }
}
