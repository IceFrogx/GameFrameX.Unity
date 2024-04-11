
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
    public abstract partial class Service : ai.Node
    {
        public Service(JSONNode _buf) : base(_buf) 
        {
            PostInit();
        }

        public static Service DeserializeService(JSONNode _buf)
        {
            switch ((string)_buf["$type"])
            {
                case "UeSetDefaultFocus": return new ai.UeSetDefaultFocus(_buf);
                case "ExecuteTimeStatistic": return new ai.ExecuteTimeStatistic(_buf);
                case "ChooseTarget": return new ai.ChooseTarget(_buf);
                case "KeepFaceTarget": return new ai.KeepFaceTarget(_buf);
                case "GetOwnerPlayer": return new ai.GetOwnerPlayer(_buf);
                case "UpdateDailyBehaviorProps": return new ai.UpdateDailyBehaviorProps(_buf);
                default: throw new SerializationException();
            }
        }


        public override void ResolveRef(TablesComponent tables)
        {
            base.ResolveRef(tables);
        }

        public override string ToString()
        {
            return "{ "
            + "id:" + Id + ","
            + "nodeName:" + NodeName + ","
            + "}";
        }

        partial void PostInit();
    }
}
