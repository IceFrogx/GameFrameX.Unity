
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
    public abstract partial class KeyQueryOperator : LuBan.Runtime.BeanBase
    {
        public KeyQueryOperator(JSONNode _buf)
        {
            PostInit();
        }

        public static KeyQueryOperator DeserializeKeyQueryOperator(JSONNode _buf)
        {
            switch ((string)_buf["$type"])
            {
                case "IsSet2": return new ai.IsSet2(_buf);
                case "IsNotSet": return new ai.IsNotSet(_buf);
                case "BinaryOperator": return new ai.BinaryOperator(_buf);
                default: throw new SerializationException();
            }
        }


        public virtual void ResolveRef(TablesComponent tables)
        {
        }

        public override string ToString()
        {
            return "{ "
            + "}";
        }

        partial void PostInit();
    }
}
