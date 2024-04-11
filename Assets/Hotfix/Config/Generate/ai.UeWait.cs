
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
    public sealed partial class UeWait : ai.Task
    {
        public UeWait(JSONNode _buf) : base(_buf) 
        {
            { if(!_buf["wait_time"].IsNumber) { throw new SerializationException(); }  WaitTime = _buf["wait_time"]; }
            { if(!_buf["random_deviation"].IsNumber) { throw new SerializationException(); }  RandomDeviation = _buf["random_deviation"]; }
            PostInit();
        }

        public static UeWait DeserializeUeWait(JSONNode _buf)
        {
            return new ai.UeWait(_buf);
        }

        public readonly float WaitTime;
        public readonly float RandomDeviation;
        public const int __ID__ = -512994101;
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
            + "waitTime:" + WaitTime + ","
            + "randomDeviation:" + RandomDeviation + ","
            + "}";
        }

        partial void PostInit();
    }
}
