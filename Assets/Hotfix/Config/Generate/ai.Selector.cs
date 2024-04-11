
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
    public sealed partial class Selector : ai.ComposeNode
    {
        public Selector(JSONNode _buf) : base(_buf) 
        {
            { var __json0 = _buf["children"]; if(!__json0.IsArray) { throw new SerializationException(); } Children = new System.Collections.Generic.List<ai.FlowNode>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { ai.FlowNode __v0;  { if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = ai.FlowNode.DeserializeFlowNode(__e0);  }  Children.Add(__v0); }   }
            PostInit();
        }

        public static Selector DeserializeSelector(JSONNode _buf)
        {
            return new ai.Selector(_buf);
        }

        public readonly System.Collections.Generic.List<ai.FlowNode> Children;
        public const int __ID__ = -1946981627;
        public override int GetTypeId() => __ID__;

        public override void ResolveRef(TablesComponent tables)
        {
            base.ResolveRef(tables);
            foreach (var _e in Children) { _e?.ResolveRef(tables); }
        }

        public override string ToString()
        {
            return "{ "
            + "id:" + Id + ","
            + "nodeName:" + NodeName + ","
            + "decorators:" + StringUtil.CollectionToString(Decorators) + ","
            + "services:" + StringUtil.CollectionToString(Services) + ","
            + "children:" + StringUtil.CollectionToString(Children) + ","
            + "}";
        }

        partial void PostInit();
    }
}
