
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
    public sealed partial class TestGlobal : LuBan.Runtime.BeanBase
    {
        public TestGlobal(JSONNode _buf)
        {
            { if(!_buf["unlock_equip"].IsNumber) { throw new SerializationException(); }  UnlockEquip = _buf["unlock_equip"]; }
            { if(!_buf["unlock_hero"].IsNumber) { throw new SerializationException(); }  UnlockHero = _buf["unlock_hero"]; }
            PostInit();
        }

        public static TestGlobal DeserializeTestGlobal(JSONNode _buf)
        {
            return new test.TestGlobal(_buf);
        }

        public readonly int UnlockEquip;
        public readonly int UnlockHero;
        public const int __ID__ = -12548655;
        public override int GetTypeId() => __ID__;

        public  void ResolveRef(TablesComponent tables)
        {
            
            
        }

        public override string ToString()
        {
            return "{ "
            + "unlockEquip:" + UnlockEquip + ","
            + "unlockHero:" + UnlockHero + ","
            + "}";
        }

        partial void PostInit();
    }
}
