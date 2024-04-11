
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
    public sealed partial class UeBlackboard : ai.Decorator
    {
        public UeBlackboard(JSONNode _buf) : base(_buf) 
        {
            { if(!_buf["notify_observer"].IsNumber) { throw new SerializationException(); }  NotifyObserver = (ai.ENotifyObserverMode)_buf["notify_observer"].AsInt; }
            { if(!_buf["blackboard_key"].IsString) { throw new SerializationException(); }  BlackboardKey = _buf["blackboard_key"]; }
            { if(!_buf["key_query"].IsObject) { throw new SerializationException(); }  KeyQuery = ai.KeyQueryOperator.DeserializeKeyQueryOperator(_buf["key_query"]);  }
            PostInit();
        }

        public static UeBlackboard DeserializeUeBlackboard(JSONNode _buf)
        {
            return new ai.UeBlackboard(_buf);
        }

        public readonly ai.ENotifyObserverMode NotifyObserver;
        public readonly string BlackboardKey;
        public readonly ai.KeyQueryOperator KeyQuery;
        public const int __ID__ = -315297507;
        public override int GetTypeId() => __ID__;

        public override void ResolveRef(TablesComponent tables)
        {
            base.ResolveRef(tables);
            
            
            KeyQuery?.ResolveRef(tables);
        }

        public override string ToString()
        {
            return "{ "
            + "id:" + Id + ","
            + "nodeName:" + NodeName + ","
            + "flowAbortMode:" + FlowAbortMode + ","
            + "notifyObserver:" + NotifyObserver + ","
            + "blackboardKey:" + BlackboardKey + ","
            + "keyQuery:" + KeyQuery + ","
            + "}";
        }

        partial void PostInit();
    }
}
