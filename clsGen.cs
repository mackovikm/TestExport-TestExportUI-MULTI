using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExportUI
{
    internal class clsGen
    {
        public string GenString { get; private set; }
        public Dictionary<int, Dictionary<string, clsGenItem>> GenRows { get; private set; }

        public clsGen(string genString)
        {
            GenString = genString;
            GenRows = ParseKey(GenString);
        }

        public clsGenItem? GetValueByRoundType(int roundGen, string typeGen)
        {
            if (GenRows.ContainsKey(roundGen))
            {
                Dictionary<string, clsGenItem> genRound = GenRows[roundGen];
                if(genRound.ContainsKey(typeGen))
                {
                    return genRound[typeGen];
                }
            }

            return null;
        }

        private Dictionary<int, Dictionary<string, clsGenItem>> ParseKey(string genString)
        {
            List<string> currentGenList = genString.Split("\n").ToList();
            Dictionary<int, Dictionary<string, clsGenItem>> genList = new Dictionary<int, Dictionary<string, clsGenItem>>();

            foreach (string rowGen in currentGenList)
            {
                if(rowGen.Contains("round"))
                {
                    clsGenItem genItem = new clsGenItem(rowGen);
                    Dictionary<string, clsGenItem> typeGen = new Dictionary<string, clsGenItem>();
                    typeGen.Add(genItem.TypeRow, genItem);

                    if (!genList.TryAdd(genItem.Round, typeGen))
                    {
                        Dictionary<string, clsGenItem> genListRoundItem = genList[genItem.Round];
                        if(String.IsNullOrEmpty(genItem.TypeRow))
                        {
                            string itemTypeTmpKey = String.Format("EMPTYVALUE-{0:000}", genListRoundItem.Count);
                            genListRoundItem.Add(itemTypeTmpKey, genItem);
                        }
                        else
                        {
                            genListRoundItem.Add(genItem.TypeRow, genItem);
                        }
                    }
                }
            }

            return genList;
        }
    }
}
