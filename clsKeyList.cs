using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExportUI
{
    internal class clsKeyList
    {
        public List<clsKey> KeyList { get; private set; }

        public clsKeyList()
        {
            KeyList = new List<clsKey>();
        }

        public clsKeyList(string keyString) : this()
        {
            clsKey cKey = new clsKey(keyString);
            KeyList.Add(cKey);
        }

        public clsKey Add(string keyString)
        {
            clsKey cKey = new clsKey(keyString);
            KeyList.Add(cKey);

            return cKey;
        }
    }
}
