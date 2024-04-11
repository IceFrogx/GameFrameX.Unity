
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

namespace Hotfix.Config.ai
{
    public sealed partial class BinaryOperator : ai.KeyQueryOperator
    {
        public BinaryOperator(JSONNode _buf) : base(_buf) 
        {
            { if(!_buf["oper"].IsNumber) { throw new SerializationException(); }  Oper = (ai.EOperator)_buf["oper"].AsInt; }
            { if(!_buf["data"].IsObject) { throw new SerializationException(); }  Data = ai.KeyData.DeserializeKeyData(_buf["data"]);  }
            PostInit();
        }

        public static BinaryOperator DeserializeBinaryOperator(JSONNode _buf)
        {
            return new ai.BinaryOperator(_buf);
        }

        public readonly ai.EOperator Oper;
        public readonly ai.KeyData Data;
        public const int __ID__ = -979891605;
        public override int GetTypeId() => __ID__;

        public override void ResolveRef(TablesComponent tables)
        {
            base.ResolveRef(tables);
            
            Data?.ResolveRef(tables);
        }

        public override string ToString()
        {
            return "{ "
            + "oper:" + Oper + ","
            + "data:" + Data + ","
            + "}";
        }

        partial void PostInit();
    }
}
