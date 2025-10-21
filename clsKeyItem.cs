using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestExportUI
{
    internal class clsKeyItem
    {
        public string KeyRow { get; private set; }
        public string Key { get; private set; }
        public int Round { get; private set; }

        //round:10   2fcb3dd0-eb2210a6-896e1286-ac673b0f
        //round:09   186e9aef-c4e92d76-624c0220-25092989
        //round:08   6d9f494f-dc87b799-a6a52f56-47452ba9
        //round:07   0c6d5fb7-b118fed6-7a2298cf-e1e004ff
        //round:06   69b35ba3-bd75a161-cb3a6619-9bc29c30
        //round:05   089efef0-d4c6fac2-764fc778-50f8fa29
        //round:04   b1b92f07-dc580432-a2893dba-26b73d51
        //round:03   0bdac658-6de12b35-7ed13988-843e00eb
        //round:02   d0c83d75-663bed6d-133012bd-faef3963
        //round:01   4c39206b-b6f3d018-750bffd0-e9df2bde
        //round:00   05718bb5-facaf073-c3f82fc8-9cd4d40e

        public clsKeyItem() : this("")
        {
        }

        public clsKeyItem(string keyRow)
        {
            KeyRow = SetKeyRow(keyRow);
            Key = SetKey(KeyRow);
            Round = SetKeyRound(KeyRow);
        }

        private string SetKeyRow(string keyRow)
        {
            string keyRowOut = keyRow;

            keyRowOut = keyRowOut.Replace("\n", "");
            keyRowOut = keyRowOut.Replace("\r", "");
            keyRowOut = keyRowOut.Trim();

            return keyRowOut;
        }

        private string SetKey(string keyRow)
        {
            string keyOut = string.Empty;
            if(KeyRow.Contains("round:"))
            {
                string[] keySplit = keyRow.Split("   ");
                keyOut = keySplit[1];
                keyOut = keyOut.Replace(".", "");
                keyOut = keyOut.Replace("_", "");
                keyOut = keyOut.Replace("-", "");
                keyOut = keyOut.Replace(" ", "");

                keyOut = keyOut.Trim();
            }

            return keyOut;
        }

        private int SetKeyRound(string keyRow)
        {
            int keyRoundOut = -1;

            if (KeyRow.Contains("round:"))
            {
                string[] keySplit = keyRow.Split("   ");
                keySplit = keySplit[0].Split(":");

                if(int.TryParse(keySplit[1], out int numberRound))
                {
                    keyRoundOut = numberRound;
                }
            }

            return keyRoundOut;
        }
    }
}
