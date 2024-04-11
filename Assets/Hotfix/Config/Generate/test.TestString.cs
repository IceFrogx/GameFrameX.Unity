
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
    public sealed partial class TestString : LuBan.Runtime.BeanBase
    {
        public TestString(JSONNode _buf)
        {
            { if(!_buf["id"].IsString) { throw new SerializationException(); }  Id = _buf["id"]; }
            { if(!_buf["s1"].IsString) { throw new SerializationException(); }  S1 = _buf["s1"]; }
            { if(!_buf["s2"].IsString) { throw new SerializationException(); }  S2 = _buf["s2"]; }
            { if(!_buf["cs1"].IsObject) { throw new SerializationException(); }  Cs1 = test.CompactString.DeserializeCompactString(_buf["cs1"]);  }
            { if(!_buf["cs2"].IsObject) { throw new SerializationException(); }  Cs2 = test.CompactString.DeserializeCompactString(_buf["cs2"]);  }
            PostInit();
        }

        public static TestString DeserializeTestString(JSONNode _buf)
        {
            return new test.TestString(_buf);
        }

        public readonly string Id;
        public readonly string S1;
        public readonly string S2;
        public readonly test.CompactString Cs1;
        public readonly test.CompactString Cs2;
        public const int __ID__ = 338485823;
        public override int GetTypeId() => __ID__;

        public  void ResolveRef(TablesComponent tables)
        {
            
            
            
            Cs1?.ResolveRef(tables);
            Cs2?.ResolveRef(tables);
        }

        public override string ToString()
        {
            return "{ "
            + "id:" + Id + ","
            + "s1:" + S1 + ","
            + "s2:" + S2 + ","
            + "cs1:" + Cs1 + ","
            + "cs2:" + Cs2 + ","
            + "}";
        }

        partial void PostInit();
    }
}
