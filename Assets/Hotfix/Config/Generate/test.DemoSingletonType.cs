
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
    public sealed partial class DemoSingletonType : LuBan.Runtime.BeanBase
    {
        public DemoSingletonType(JSONNode _buf)
        {
            { if(!_buf["id"].IsNumber) { throw new SerializationException(); }  Id = _buf["id"]; }
            { if(!_buf["name"].IsString) { throw new SerializationException(); }  Name = _buf["name"]; }
            { if(!_buf["date"].IsObject) { throw new SerializationException(); }  Date = test.DemoDynamic.DeserializeDemoDynamic(_buf["date"]);  }
            PostInit();
        }

        public static DemoSingletonType DeserializeDemoSingletonType(JSONNode _buf)
        {
            return new test.DemoSingletonType(_buf);
        }

        public readonly int Id;
        public readonly string Name;
        public readonly test.DemoDynamic Date;
        public const int __ID__ = 539196998;
        public override int GetTypeId() => __ID__;

        public  void ResolveRef(TablesComponent tables)
        {
            
            
            Date?.ResolveRef(tables);
        }

        public override string ToString()
        {
            return "{ "
            + "id:" + Id + ","
            + "name:" + Name + ","
            + "date:" + Date + ","
            + "}";
        }

        partial void PostInit();
    }
}
