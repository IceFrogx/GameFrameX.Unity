
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
    public sealed partial class MoveToLocation : ai.Task
    {
        public MoveToLocation(JSONNode _buf) : base(_buf) 
        {
            { if(!_buf["acceptable_radius"].IsNumber) { throw new SerializationException(); }  AcceptableRadius = _buf["acceptable_radius"]; }
            PostInit();
        }

        public static MoveToLocation DeserializeMoveToLocation(JSONNode _buf)
        {
            return new ai.MoveToLocation(_buf);
        }

        public readonly float AcceptableRadius;
        public const int __ID__ = -969953113;
        public override int GetTypeId() => __ID__;

        public override void ResolveRef(TablesComponent tables)
        {
            base.ResolveRef(tables);
            
        }

        public override string ToString()
        {
            return "{ "
            + "id:" + Id + ","
            + "nodeName:" + NodeName + ","
            + "decorators:" + StringUtil.CollectionToString(Decorators) + ","
            + "services:" + StringUtil.CollectionToString(Services) + ","
            + "ignoreRestartSelf:" + IgnoreRestartSelf + ","
            + "acceptableRadius:" + AcceptableRadius + ","
            + "}";
        }

        partial void PostInit();
    }
}
