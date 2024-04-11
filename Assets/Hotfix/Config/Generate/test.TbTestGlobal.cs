
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
    public partial class TbTestGlobal : BaseDataTable<test.TestGlobal>
    {
    
        private test.TestGlobal _data;
        public test.TestGlobal Data => _data;
        private readonly System.Func<System.Threading.Tasks.Task<JSONNode>> _loadFunc;
    
        public TbTestGlobal(System.Func<System.Threading.Tasks.Task<JSONNode>> loadFunc)
        {
            _loadFunc = loadFunc;
        }
    
        public override async System.Threading.Tasks.Task LoadAsync()
        {
            JSONNode _json = await _loadFunc();
            int n = _json.Count;
            if (n != 1) throw new SerializationException("table mode=one, but size != 1");
            { if(!_json[0].IsObject) { throw new SerializationException(); }  _data = test.TestGlobal.DeserializeTestGlobal(_json[0]);  }
        }
    
        public int UnlockEquip => _data.UnlockEquip;
        public int UnlockHero => _data.UnlockHero;
    
        public void ResolveRef(TablesComponent tables)
        {
            _data.ResolveRef(tables);
        }
    
        partial void PostInit();
    }
}

