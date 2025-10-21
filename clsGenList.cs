using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExportUI
{
    internal class clsGenList
    {
        public List<clsGen> GenList { get; private set; }

        public clsGenList()
        {
            GenList = new List<clsGen>();
        }

        public clsGenList(string genString) : this()
        {
            clsGen cGen = new clsGen(genString);
            GenList.Add(cGen);
        }

        public clsGen Add(string genString)
        {
            clsGen cGen = new clsGen(genString);
            GenList.Add(cGen);

            return cGen;
        }
    }
}
