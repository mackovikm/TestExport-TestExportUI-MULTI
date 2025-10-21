using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExportUI
{
    internal class clsKey
    {
        public string KeyString { get; private set; }
        public Dictionary<int, clsKeyItem> KeyRows { get; private set; }
        public string KeyMaster { get; private set; }
        public string KeyLast { get; private set; }

        public clsKey(string keyString)
        {
            KeyString = keyString;
            KeyRows = ParseKey(KeyString);

            KeyMaster = GetKeyValueByIndex(0);
            KeyLast = GetKeyValueByIndex(10);
        }

        private string GetKeyValueByIndex(int index)
        {
            string outStr = string.Empty;

            if (KeyRows.ContainsKey(index))
            {
                outStr = KeyRows[index].Key;
            }

            return outStr;
        }

        private Dictionary<int, clsKeyItem> ParseKey(string key)
        {
            List<string> currentKeyList = KeyString.Split("\n").ToList();
            Dictionary<int, clsKeyItem> keyList = new Dictionary<int, clsKeyItem>();

            foreach (string rowKey in currentKeyList)
            {
                if(rowKey.Contains("round"))
                {
                    clsKeyItem keyItem = new clsKeyItem(rowKey);
                    keyList.Add(keyItem.Round, keyItem);
                }
            }

            CheckKey(keyList);

            return keyList;
        }

        private void CheckKey(Dictionary<int, clsKeyItem> keyList)
        {
            for (int index = 0; index <= 10; index++)
            {
                if (!keyList.ContainsKey(index))
                {
                    throw new Exception("Neplatná definice klíče !!!");
                }
            }
        }
    }
}
