
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
    public sealed partial class DemoType1 : LuBan.Runtime.BeanBase
    {
        public DemoType1(JSONNode _buf)
        {
            { if(!_buf["x1"].IsNumber) { throw new SerializationException(); }  X1 = _buf["x1"]; }
            PostInit();
        }

        public static DemoType1 DeserializeDemoType1(JSONNode _buf)
        {
            return new test.DemoType1(_buf);
        }

        public readonly int X1;
        public const int __ID__ = -367048296;
        public override int GetTypeId() => __ID__;

        public  void ResolveRef(TablesComponent tables)
        {
            
        }

        public override string ToString()
        {
            return "{ "
            + "x1:" + X1 + ","
            + "}";
        }

        partial void PostInit();
    }
}
