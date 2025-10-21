using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestExportUI
{
    internal class clsGenItem
    {
        public string GenRow { get; private set; }
        public string TypeRow { get; private set; }
        public string ValRow { get; private set; }
        public int Round { get; private set; }
        public string ValFormat
        {
            get
            {
                string valFormated = String.Empty;

                valFormated += ValRow.Substring(0, 8);
                valFormated += "-";
                valFormated += ValRow.Substring(8, 8);
                valFormated += "-";
                valFormated += ValRow.Substring(16, 8);
                valFormated += "-";
                valFormated += ValRow.Substring(24, 8);

                return valFormated;
            }
        }

        //1-0 SOURCE      round:10|2fcb3dd0-eb2210a6-896e1286-ac673b0f
        //1-2 ROUNDKEY    round:10|930b3abb-7099e355-bf562b95-03fa309b
        //1-2 ADDROUNDKEY round:10|bcc0076b-9bbbf3f3-36383913-af9d0b94
        //3-1 SHIFTROWS   round:10|bc9d39f3-9bc00b13-36bb0794-af38f36b
        //3-2 SUBBYTES    round:10|78755b7e-e81f9e82-24fe38e7-1b767e05

        //3-0 SOURCE      round:09|78755b7e-e81f9e82-24fe38e7-1b767e05
        //3-1 ROUNDKEY    round:09|34a491de-e392d9ee-cfcfc8c0-bcac1b0e
        //3-1 ADDROUNDKEY round:09|4cd1caa0-0b8d476c-eb31f027-a7da650b
        //3-2 MIXCOLUMNS  round:09|4d363eb2-851988b9-4d954c99-f35d17aa
        //3-3 SHIFTROWS   round:09|4d5d4cb9-85361799-4d193eaa-f39588b2
        //3-4 SUBBYTES    round:09|658d5ddb-672487f9-658ed162-7ead973e
        //
        //                         -------- VVVVVVVVVVVVVVVVV --------    
        //
        //3-0 SOURCE      round:01|175e719b-3f6a97b1-df825f67-b7c4f27f
        //3-1 ROUNDKEY    round:01|274019c4-674b1827-ba190d12-16e9ec02
        //3-1 ADDROUNDKEY round:01|301e685f-58218f96-659b5275-a12d1e7d
        //3-2 MIXCOLUMNS  round:01|c63cac4f-96c181b6-15cc8b8b-bec6c453
        //3-3 SHIFTROWS   round:01|c6c68bb6-963cc48b-15c1ac53-becc814f
        //3-4 SUBBYTES    round:01|c7c7ce79-356d88ce-2fddaa50-5a279192
        //
        //3-0 SOURCE      round:00|c7c7ce79-356d88ce-2fddaa50-5a279192
        //3-1 ROUNDKEY    round:00|aab8d355-400b01e3-dd521535-acf0e110
        //3-1 ADDROUNDKEY round:00|6d7f1d2c-7566892d-f28fbf65-f6d77082

        //5-1 IV                   |2436372c-6566892d-b1ddbd65-bc657082
        //5-2 AFTER XOR-IV         |49492a00-10000000-43520200-4ab20000

        public clsGenItem() : this("")
        {
        }

        public clsGenItem(string genRow)
        {
            GenRow = SetGenRow(genRow);
            TypeRow = SetGenType(GenRow);
            ValRow = SetGenVal(GenRow);
            Round = SetGenRound(GenRow);
        }

        private string SetGenRow(string genRow)
        {
            string genRowOut = genRow;

            genRowOut = genRowOut.Replace("\n", "");
            genRowOut = genRowOut.Replace("\r", "");
            genRowOut = genRowOut.Trim();

            return genRowOut;
        }

        private string SetGenType(string genRow)
        {
            string genOut = string.Empty;
            string strSwitch = string.Empty;

            switch (genRow)
            {
                case string sw1 when sw1.Contains("SOURCE"):
                case string sw2 when sw2.Contains("ROUNDKEY"):
                case string sw3 when sw3.Contains("ADDROUNDKEY"):
                case string sw4 when sw4.Contains("MIXCOLUMNS"):
                case string sw5 when sw5.Contains("SHIFTROWS"):
                case string sw6 when sw6.Contains("SUBBYTES"):
                case string sw7 when sw7.Contains("DESC"):
                case string sw8 when sw8.Contains("IV"):
                case string sw9 when sw9.Contains("AFTER-XOR-IV"):
                    string[] genSplit = genRow.Split(" ");
                    genOut = genSplit[1];
                    genOut = genOut.Trim();
                    break;

                default:
                    break;
            }

            return genOut;
        }

        private string SetGenVal(string genRow)
        {
            string genOut = string.Empty;
            if (genRow.Contains("|"))
            {
                string[] genSplit = genRow.Split("|");
                genOut = genSplit[1];
                genOut = genOut.Replace(".", "");
                genOut = genOut.Replace("_", "");
                genOut = genOut.Replace("-", "");
                genOut = genOut.Replace(" ", "");
                genOut = genOut.Trim();
            }

            return genOut;
        }

        private int SetGenRound(string genRow)
        {
            int keyRoundOut = -1;

            if (genRow.Contains("round:"))
            {
                string[] keySplit = genRow.Split("round:");
                keySplit = keySplit[1].Split("|");

                if(int.TryParse(keySplit[0], out int numberRound))
                {
                    keyRoundOut = numberRound;
                }
            }

            return keyRoundOut;
        }
    }
}
