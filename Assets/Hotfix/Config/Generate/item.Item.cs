
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

namespace Hotfix.Config.item
{
    /// <summary>
    /// 道具
    /// </summary>
    public sealed partial class Item : LuBan.Runtime.BeanBase
    {
        public Item(JSONNode _buf)
        {
            { if(!_buf["id"].IsNumber) { throw new SerializationException(); }  Id = _buf["id"]; }
            { if(!_buf["name"].IsString) { throw new SerializationException(); }  Name = _buf["name"]; }
            { if(!_buf["major_type"].IsNumber) { throw new SerializationException(); }  MajorType = (item.EMajorType)_buf["major_type"].AsInt; }
            { if(!_buf["minor_type"].IsNumber) { throw new SerializationException(); }  MinorType = (item.EMinorType)_buf["minor_type"].AsInt; }
            { if(!_buf["quality"].IsNumber) { throw new SerializationException(); }  Quality = (item.EItemQuality)_buf["quality"].AsInt; }
            { if(!_buf["icon"].IsString) { throw new SerializationException(); }  Icon = _buf["icon"]; }
            { if(!_buf["icon_backgroud"].IsString) { throw new SerializationException(); }  IconBackgroud = _buf["icon_backgroud"]; }
            { if(!_buf["icon_mask"].IsString) { throw new SerializationException(); }  IconMask = _buf["icon_mask"]; }
            { if(!_buf["desc"].IsString) { throw new SerializationException(); }  Desc = _buf["desc"]; }
            { if(!_buf["show_order"].IsNumber) { throw new SerializationException(); }  ShowOrder = _buf["show_order"]; }
            PostInit();
        }

        public static Item DeserializeItem(JSONNode _buf)
        {
            return new item.Item(_buf);
        }

        /// <summary>
        /// 道具id
        /// </summary>
        public readonly int Id;
        public readonly string Name;
        public readonly item.EMajorType MajorType;
        public readonly item.EMinorType MinorType;
        public readonly item.EItemQuality Quality;
        public readonly string Icon;
        public readonly string IconBackgroud;
        public readonly string IconMask;
        public readonly string Desc;
        public readonly int ShowOrder;
        public const int __ID__ = 2107285806;
        public override int GetTypeId() => __ID__;

        public  void ResolveRef(TablesComponent tables)
        {
            
            
            
            
            
            
            
            
            
            
        }

        public override string ToString()
        {
            return "{ "
            + "id:" + Id + ","
            + "name:" + Name + ","
            + "majorType:" + MajorType + ","
            + "minorType:" + MinorType + ","
            + "quality:" + Quality + ","
            + "icon:" + Icon + ","
            + "iconBackgroud:" + IconBackgroud + ","
            + "iconMask:" + IconMask + ","
            + "desc:" + Desc + ","
            + "showOrder:" + ShowOrder + ","
            + "}";
        }

        partial void PostInit();
    }
}
