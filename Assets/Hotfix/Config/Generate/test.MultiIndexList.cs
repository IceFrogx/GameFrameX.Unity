
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
    public sealed partial class MultiIndexList : LuBan.Runtime.BeanBase
    {
        public MultiIndexList(JSONNode _buf)
        {
            { if(!_buf["id1"].IsNumber) { throw new SerializationException(); }  Id1 = _buf["id1"]; }
            { if(!_buf["id2"].IsNumber) { throw new SerializationException(); }  Id2 = _buf["id2"]; }
            { if(!_buf["id3"].IsString) { throw new SerializationException(); }  Id3 = _buf["id3"]; }
            { if(!_buf["num"].IsNumber) { throw new SerializationException(); }  Num = _buf["num"]; }
            { if(!_buf["desc"].IsString) { throw new SerializationException(); }  Desc = _buf["desc"]; }
            PostInit();
        }

        public static MultiIndexList DeserializeMultiIndexList(JSONNode _buf)
        {
            return new test.MultiIndexList(_buf);
        }

        public readonly int Id1;
        public readonly long Id2;
        public readonly string Id3;
        public readonly int Num;
        public readonly string Desc;
        public const int __ID__ = 2016237651;
        public override int GetTypeId() => __ID__;

        public  void ResolveRef(TablesComponent tables)
        {
            
            
            
            
            
        }

        public override string ToString()
        {
            return "{ "
            + "id1:" + Id1 + ","
            + "id2:" + Id2 + ","
            + "id3:" + Id3 + ","
            + "num:" + Num + ","
            + "desc:" + Desc + ","
            + "}";
        }

        partial void PostInit();
    }
}
