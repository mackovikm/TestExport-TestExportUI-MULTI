using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TestExportUI
{
    public partial class frmMain : Form
    {
        private const string cIV = "2436372c6566892db1ddbd65bc657082";
        private const string cKEY = "aab8d355400b01e3dd521535acf0e110";
        private const string cDATA = "2fcb3dd0eb2210a6896e1286ac673b0f";
        private const string cDATASource = "49492a0010000000435202004ab20000";

        private string strAkce = string.Empty;
        private string strIV = string.Empty;
        private string strKey = string.Empty;
        private string strData = string.Empty;

        private string strFrom = string.Empty;
        private string strTo = string.Empty;

        private int intFrom = 0x00;
        private int intTo = 0xFF;


        private clsKeyList keyList = new clsKeyList();
        private clsGenList genList = new clsGenList();

        public frmMain()
        {
            InitializeComponent();

            strAkce = "-d";
            strIV = txtIV.Text;
            strKey = txtKEY.Text;
            strData = txtDATA.Text;
            strFrom = txtCountFrom.Text;
            strTo = txtCountTo.Text;

            SetLengthInfo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioDecode_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDecode.Checked)
            {
                radioEncode.Checked = false;
                strAkce = "-d";
            }
        }

        private void radioEncode_CheckedChanged(object sender, EventArgs e)
        {
            if (radioEncode.Checked)
            {
                radioDecode.Checked = false;
                strAkce = "-e";
            }
        }

        private void txtIV_TextChanged(object sender, EventArgs e)
        {
            txtIV.Text = ClearInput(txtIV.Text);
            strIV = txtIV.Text;
            SetLengthInfo();
        }

        private void txtKEY_TextChanged(object sender, EventArgs e)
        {
            txtKEY.Text = ClearInput(txtKEY.Text);
            strKey = txtKEY.Text;
            SetLengthInfo();
        }

        private void txtDATA_TextChanged(object sender, EventArgs e)
        {
            txtDATA.Text = ClearInput(txtDATA.Text);
            strData = txtDATA.Text;
            SetLengthInfo();
        }

        private void txtCountFrom_TextChanged(object sender, EventArgs e)
        {
            if (!HexToInt(txtCountFrom.Text, 0x00, out intFrom))
            {
                txtCountFrom.Text = "00";
            }
        }

        private void txtCountTo_TextChanged(object sender, EventArgs e)
        {
            if (!HexToInt(txtCountTo.Text, 0xff, out intTo))
            {
                txtCountTo.Text = "ff";
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            clsGenItem? genItemObject = null;
            uint counter = (uint)intFrom;

            if (keyList.KeyList.Count <= 0)
            {
                MessageBox.Show("Nejsou vygenerované žádné klièw", "CHYBA VSTUPNÍCH DAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtOut.Clear();
            txtKeyList.Clear();

            genList = new clsGenList();

            foreach (clsKey cKey in keyList.KeyList)
            {
                string strFilename = String.Format("Export_{0}_{1:X2}.txt", now.ToString("yyyyMMdd-HHmmss"), counter++);

                string keyCurrent = cKey.KeyMaster;
                string strGen = GenCrypt(strAkce, strIV, keyCurrent, strData, true, strFilename);
                string strOut = string.Empty;

                clsGen genObject = genList.Add(strGen);

                if (!String.IsNullOrEmpty(txtKeyList.Text))
                {
                    strOut += "---------------------------------------------------------";
                    strOut += "\r\n";
                }


                if (strAkce == "-d")
                {
                    //SOURCE       round:10|2fcb3dd0-eb2210a6-896e1286-ac673b0f
                    //ROUNDKEY     round:10|000b3abb-7099e355-bf562b95-03fa309b
                    //ADDROUNDKEY  round:10|2fc0076b-9bbbf3f3-36383913-af9d0b94
                    //
                    genItemObject = genObject.GetValueByRoundType(10, "SOURCE");
                    if (genItemObject != null)
                    {
                        strOut += String.Format("{0}round:{1:00}|{2}\r\n", genItemObject.TypeRow.PadRight(13), genItemObject.Round, genItemObject.ValFormat);
                    }

                    genItemObject = genObject.GetValueByRoundType(10, "ROUNDKEY");
                    if (genItemObject != null)
                    {
                        strOut += String.Format("{0}round:{1:00}|{2}\r\n", genItemObject.TypeRow.PadRight(13), genItemObject.Round, genItemObject.ValFormat);
                    }

                    genItemObject = genObject.GetValueByRoundType(10, "ADDROUNDKEY");
                    if (genItemObject != null)
                    {
                        strOut += String.Format("{0}round:{1:00}|{2}\r\n", genItemObject.TypeRow.PadRight(13), genItemObject.Round, genItemObject.ValFormat);
                    }
                }
                else
                {
                    //SHIFTROWS    round:10|bcc0076b-9bbbf3f3-36383913-af9d0b94
                    //ROUNDKEY     round:10|930b3abb-7099e355-bf562b95-03fa309b
                    //DESC         round:10|2fcb3dd0-eb2210a6-896e1286-ac673b0f
                    //
                    genItemObject = genObject.GetValueByRoundType(10, "SHIFTROWS");
                    if (genItemObject != null)
                    {
                        strOut += String.Format("{0}round:{1:00}|{2}\r\n", genItemObject.TypeRow.PadRight(13), genItemObject.Round, genItemObject.ValFormat);
                    }

                    genItemObject = genObject.GetValueByRoundType(10, "ROUNDKEY");
                    if (genItemObject != null)
                    {
                        strOut += String.Format("{0}round:{1:00}|{2}\r\n", genItemObject.TypeRow.PadRight(13), genItemObject.Round, genItemObject.ValFormat);
                    }

                    genItemObject = genObject.GetValueByRoundType(10, "DESC");
                    if (genItemObject != null)
                    {
                        strOut += String.Format("{0}round:{1:00}|{2}\r\n", genItemObject.TypeRow.PadRight(13), genItemObject.Round, genItemObject.ValFormat);
                    }
                }

                txtOut.Refresh();


                txtKeyList.AppendText(strOut);
                txtKeyList.Refresh();
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtOut.Text);
        }

        private void SetLengthInfo()
        {
            lblIVLen.Text = strIV.Length.ToString();
            lblKEYLen.Text = strKey.Length.ToString();
            lblDATALen.Text = strData.Length.ToString();
        }

        private string ClearInput(string input)
        {
            string strOut = input;
            strOut = strOut.Replace(".", "");
            strOut = strOut.Replace(",", "");
            strOut = strOut.Replace(";", "");
            strOut = strOut.Replace("-", "");
            strOut = strOut.Replace("|", "");
            strOut = strOut.Replace(" ", "");
            strOut = strOut.Replace("0x", "");

            return strOut;
        }

        private bool HexToInt(string input, int defaultValue, out int returnValue)
        {
            bool retVal = true;
            int intValue = defaultValue;

            try
            {
                intValue = Convert.ToInt32(input, 16);
                if (intValue < 0)
                {
                    intValue = defaultValue;
                    retVal = false;
                }

                if (intValue > 255)
                {
                    intValue = defaultValue;
                    retVal = false;
                }
            }
            catch
            {
                intValue = defaultValue;
                retVal = false;
            }
            finally
            {
                returnValue = intValue;
            }

            return retVal;
        }

        private bool ValidData()
        {
            if (strIV.Length != 32)
            {
                return false;
            }

            if (strData.Length != 32)
            {
                return false;
            }

            if ((strKey.Length != 32) && (keyList.KeyList.Count <= 0))
            {
                return false;
            }

            return true;
        }

        private void btnIVReset_Click(object sender, EventArgs e)
        {
            txtIV.Text = cIV;
        }

        private void btnKEYReset_Click(object sender, EventArgs e)
        {
            txtKEY.Text = cKEY;
        }

        private void btnDATAReset_Click(object sender, EventArgs e)
        {
            txtDATA.Text = cDATASource;
        }

        private void btnIVStack_Click(object sender, EventArgs e)
        {
            string origIV = txtIV.Text;
            txtIV.Text = txtIVStack.Text;
            txtIVStack.Text = origIV;
        }

        private void btnKeyStack_Click(object sender, EventArgs e)
        {
            string origKey = txtKEY.Text;
            txtKEY.Text = txtKEYStack.Text;
            txtKEYStack.Text = origKey;
        }

        private void btnDataStack_Click(object sender, EventArgs e)
        {
            string origData = txtDATA.Text;
            txtDATA.Text = txtDATAStack.Text;
            txtDATAStack.Text = origData;
        }

        private void txtIV_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtIV.Text = ClearInput(txtIV.Text);
        }

        private void txtKEY_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtKEY.Text = ClearInput(txtKEY.Text);
        }

        private void txtDATA_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDATA.Text = ClearInput(txtDATA.Text);
        }

        private void txtIV_DoubleClick(object sender, EventArgs e)
        {
            ((System.Windows.Forms.TextBox)sender).SelectAll();
            ((System.Windows.Forms.TextBox)sender).Focus();
            Clipboard.SetText(((System.Windows.Forms.TextBox)sender).Text);
        }

        private void txtKEY_DoubleClick(object sender, EventArgs e)
        {
            ((System.Windows.Forms.TextBox)sender).SelectAll();
            ((System.Windows.Forms.TextBox)sender).Focus();
            Clipboard.SetText(((System.Windows.Forms.TextBox)sender).Text);
        }

        private void txtDATA_DoubleClick(object sender, EventArgs e)
        {
            ((System.Windows.Forms.TextBox)sender).SelectAll();
            ((System.Windows.Forms.TextBox)sender).Focus();
            Clipboard.SetText(((System.Windows.Forms.TextBox)sender).Text);
        }

        private void txtIVStack_DoubleClick(object sender, EventArgs e)
        {
            ((System.Windows.Forms.TextBox)sender).SelectAll();
            ((System.Windows.Forms.TextBox)sender).Focus();
            Clipboard.SetText(((System.Windows.Forms.TextBox)sender).Text);
        }

        private void txtKEYStack_DoubleClick(object sender, EventArgs e)
        {
            ((System.Windows.Forms.TextBox)sender).SelectAll();
            ((System.Windows.Forms.TextBox)sender).Focus();
            Clipboard.SetText(((System.Windows.Forms.TextBox)sender).Text);
        }

        private void txtDATAStack_DoubleClick(object sender, EventArgs e)
        {
            ((System.Windows.Forms.TextBox)sender).SelectAll();
            ((System.Windows.Forms.TextBox)sender).Focus();
            Clipboard.SetText(((System.Windows.Forms.TextBox)sender).Text);
        }

        private void txtIV_Click(object sender, EventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Control))
            {
                ((System.Windows.Forms.TextBox)sender).Text = Clipboard.GetText();
            }
        }

        private void txtKEY_Click(object sender, EventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Control))
            {
                ((System.Windows.Forms.TextBox)sender).Text = Clipboard.GetText();
            }
        }

        private void txtDATA_Click(object sender, EventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Control))
            {
                ((System.Windows.Forms.TextBox)sender).Text = Clipboard.GetText();
            }
        }

        private void txtIVStack_Click(object sender, EventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Control))
            {
                ((System.Windows.Forms.TextBox)sender).Text = Clipboard.GetText();
            }
        }

        private void txtKEYStack_Click(object sender, EventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Control))
            {
                ((System.Windows.Forms.TextBox)sender).Text = Clipboard.GetText();
            }
        }

        private void txtDATAStack_Click(object sender, EventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Control))
            {
                ((System.Windows.Forms.TextBox)sender).Text = Clipboard.GetText();
            }
        }

        private string GenKey(string strKey, bool EnabledOtputForm = true, string fileNameExternal = "")
        {
            string outStr = string.Empty;

            strAkce = "-k";

            if (!ValidData())
            {
                MessageBox.Show("Neplatná vstupní data", "CHYBA VSTUPNÍCH DAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return outStr;
            }

            string? exePath = Path.GetFullPath(@"d:\develop\TestExport\x64\Debug\TestExport.exe");
            string exeFind = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "TestExport.exe");
            if (File.Exists(exeFind))
            {
                exePath = Path.GetFullPath(exeFind);
            }

            string strFilename = String.Format("Export_{0}.txt", DateTime.Now.ToString("yyyyMMdd-HHmmss"));
            if (!String.IsNullOrEmpty(fileNameExternal))
            {
                strFilename = fileNameExternal;
            }
            string exeParams = String.Concat(strAkce, " ", strKey, " ", strFilename);

            ProcessStartInfo startInfo = new ProcessStartInfo(exePath);
            startInfo.Arguments = exeParams;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.CreateNoWindow = true;

            Process? exeProcess = Process.Start(startInfo);

            if (exeProcess != null)
            {
                // Synchronously read the standard output of the spawned process.
                StreamReader reader = exeProcess.StandardOutput;
                outStr = reader.ReadToEnd();

                if (exeProcess.WaitForExit(500))
                {
                    if (EnabledOtputForm)
                    {
                        txtOut.Text += outStr;
                    }
                }
            }

            if (radioDecode.Checked)
            {
                strAkce = "-d";
            }

            if (radioEncode.Checked)
            {
                strAkce = "-e";
            }

            return outStr;
        }

        private string GenKeyRevert(string strKey, bool EnabledOtputForm = true, string fileNameExternal = "")
        {
            string outStr = string.Empty;

            strAkce = "-r";

            if (!ValidData())
            {
                MessageBox.Show("Neplatná vstupní data", "CHYBA VSTUPNÍCH DAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return outStr;
            }

            string? exePath = Path.GetFullPath(@"d:\develop\TestExport\x64\Debug\TestExport.exe");
            string exeFind = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "TestExport.exe");
            if (File.Exists(exeFind))
            {
                exePath = Path.GetFullPath(exeFind);
            }

            string strFilename = String.Format("Export_{0}.txt", DateTime.Now.ToString("yyyyMMdd-HHmmss"));
            if (!String.IsNullOrEmpty(fileNameExternal))
            {
                strFilename = fileNameExternal;
            }
            string exeParams = String.Concat(strAkce, " ", strKey, " ", strFilename);

            ProcessStartInfo startInfo = new ProcessStartInfo(exePath);
            startInfo.Arguments = exeParams;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.CreateNoWindow = true;

            Process? exeProcess = Process.Start(startInfo);

            if (exeProcess != null)
            {
                // Synchronously read the standard output of the spawned process.
                StreamReader reader = exeProcess.StandardOutput;
                outStr = reader.ReadToEnd();

                if (exeProcess.WaitForExit(500))
                {
                    if (EnabledOtputForm)
                    {
                        txtOut.Text += outStr;
                    }
                }
            }

            if (radioDecode.Checked)
            {
                strAkce = "-d";
            }

            if (radioEncode.Checked)
            {
                strAkce = "-e";
            }
            return outStr;
        }

        private string GenCrypt(string strAkceParam, string strIVParam, string strKeyParam, string strDataParam, bool EnabledOtputForm = true, string fileName = "")
        {
            string outStr = string.Empty;

            if (!ValidData())
            {
                MessageBox.Show("Neplatná vstupní data", "CHYBA VSTUPNÍCH DAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return outStr;
            }

            string? exePath = Path.GetFullPath(@"d:\develop\TestExport\x64\Debug\TestExport.exe");
            string exeFind = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "TestExport.exe");
            if (File.Exists(exeFind))
            {
                exePath = Path.GetFullPath(exeFind);
            }

            string strFilename = String.Format("Export_{0}.txt", DateTime.Now.ToString("yyyyMMdd-HHmmss"));
            if (!String.IsNullOrEmpty(fileName))
            {
                strFilename = fileName;
            }
            string exeParams = String.Concat(strAkceParam, " ", strIVParam, " ", strKeyParam, " ", strDataParam, " ", strFilename);

            ProcessStartInfo startInfo = new ProcessStartInfo(exePath);
            startInfo.Arguments = exeParams;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.CreateNoWindow = true;

            Process? exeProcess = Process.Start(startInfo);

            if (exeProcess != null)
            {
                // Synchronously read the standard output of the spawned process.
                StreamReader reader = exeProcess.StandardOutput;
                outStr = reader.ReadToEnd();

                if (exeProcess.WaitForExit(10000))
                {
                    if (EnabledOtputForm)
                    {
                        txtOut.Text += outStr;
                    }
                }
            }

            return outStr;
        }

        private void btnKey_Click(object sender, EventArgs e)
        {
            GenKey(txtKEY.Text);
        }

        private void btnKeyRevert_Click(object sender, EventArgs e)
        {
            GenKeyRevert(txtKEY.Text);
        }

        private void btnKeyGEN_Click(object sender, EventArgs e)
        {
            string keySource = txtKEY.Text;
            string keyCurrent = keySource;

            string keyGen = string.Empty;

            keyList = new clsKeyList();

            txtOut.Clear();
            txtKeyList.Clear();

            //                     91 91b8d355400b01e3dd521535acf0e110 56658d364236aa938e29439b18bfb350
            txtKeyList.AppendText("   Last                             Master\r\n");

            if (keyCurrent.ToUpper().Contains("XX"))
            {
                DateTime now = DateTime.Now;
                string strHexVal = string.Empty;

                for (uint counter = (uint)intFrom; counter <= (uint)intTo; counter++)
                {
                    string strFilename = String.Format("Export_{0}_{1:X2}.txt", now.ToString("yyyyMMdd-HHmmss"), counter);

                    strHexVal = String.Format("{0:X2}", counter);
                    keyCurrent = keySource.Replace("x", "X").Replace("XX", strHexVal);

                    keyGen = GenKey(keyCurrent, false, strFilename);
                    txtOut.Text += keyGen;
                    txtOut.Refresh();

                    clsKey cKey = keyList.Add(keyGen);

                    txtKeyList.AppendText(String.Format("{0:X2} {1} {2}\r\n", counter, cKey.KeyLast, cKey.KeyMaster));
                    txtKeyList.Refresh();
                }
            }
            else
            {
                keyGen = GenKey(keyCurrent, false);
                txtOut.Text += keyGen;
                txtOut.Refresh();

                clsKey cKey = keyList.Add(keyGen);

                txtKeyList.AppendText(String.Format("XX {0} {1}\r\n", cKey.KeyLast, cKey.KeyMaster));
                txtKeyList.Refresh();
            }

            return;
        }

        private void btnKeyRevertGEN_Click(object sender, EventArgs e)
        {
            string keySource = txtKEY.Text;
            string keyCurrent = keySource;

            string keyGen = string.Empty;

            keyList = new clsKeyList();

            txtOut.Clear();
            txtKeyList.Clear();

            //                     91 91b8d355400b01e3dd521535acf0e110 56658d364236aa938e29439b18bfb350
            txtKeyList.AppendText("   Last                             Master\r\n");

            if (keyCurrent.ToUpper().Contains("XX"))
            {
                DateTime now = DateTime.Now;
                string strHexVal = string.Empty;

                for (uint counter = (uint)intFrom; counter <= (uint)intTo; counter++)
                {
                    string strFilename = String.Format("Export_{0}_{1:X2}.txt", now.ToString("yyyyMMdd-HHmmss"), counter);

                    strHexVal = String.Format("{0:X2}", counter);
                    keyCurrent = keySource.Replace("x", "X").Replace("XX", strHexVal);

                    keyGen = GenKeyRevert(keyCurrent, false, strFilename);
                    txtOut.Text += keyGen;
                    txtOut.Refresh();

                    clsKey cKey = keyList.Add(keyGen);

                    txtKeyList.AppendText(String.Format("{0:X2} {1} {2}\r\n", counter, cKey.KeyLast, cKey.KeyMaster));
                    txtKeyList.Refresh();
                }
            }
            else
            {
                keyGen = GenKeyRevert(keyCurrent, false);
                txtOut.Text += keyGen;
                txtOut.Refresh();

                clsKey cKey = keyList.Add(keyGen);

                txtKeyList.AppendText(String.Format("XX {0} {1}\r\n", cKey.KeyLast, cKey.KeyMaster));
                txtKeyList.Refresh();
            }
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            toolStripOutSave_Click(sender, e);
        }

        private void btnLOAD_Click(object sender, EventArgs e)
        {
            toolStripOutLoad_Click(sender, e);
        }

        private void toolStripOutClear_Click(object sender, EventArgs e)
        {
            txtOut.Clear();
        }

        private void toolStripOutSave_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            string defaultPath = Path.GetDirectoryName(Application.ExecutablePath);
            string strFilename = String.Format("Export_{0}.txt", now.ToString("yyyyMMdd-HHmmss"));

            saveFileDialog.FileName = strFilename;
            saveFileDialog.Filter = "TXT files (*.txt)|*.txt|LOAD Config (Load.config)|Load.config|Config files(*.config)|*.config|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.InitialDirectory = defaultPath;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, txtOut.Text);
            }
        }

        private void toolStripOutLoad_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            string defaultPath = Path.GetDirectoryName(Application.ExecutablePath);
            string strFilename = "Load.config";

            openFileDialog.FileName = strFilename;
            openFileDialog.Filter = "Load files (Load.config)|Load.config|Config files (*.config)|*.config|TXT files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.InitialDirectory = defaultPath;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.CheckFileExists = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtOut.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            keyList.KeyList.Clear();
            txtKeyList.Clear();
        }

        private void toolStripKeySave_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            string strFilename = String.Format("Export_{0}.txt", now.ToString("yyyyMMdd-HHmmss"));

            saveFileDialog.FileName = strFilename;
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(strFilename, txtKeyList.Text);
            }
        }

        private void txtOut_DoubleClick(object sender, EventArgs e)
        {
            contextMenuOut.Show(Cursor.Position);
        }

        private void txtKeyList_DoubleClick(object sender, EventArgs e)
        {
            contextMenuKey.Show(Cursor.Position);
        }

        private void btnDir_Click(object sender, EventArgs e)
        {
            string defaultPath = Path.GetDirectoryName(Application.ExecutablePath);
            string archivPath = Path.Combine(defaultPath, "Archiv");

            try
            {
                if (!Directory.Exists(archivPath))
                {
                    Directory.CreateDirectory(archivPath);
                }
                Process.Start("totalcmd64.exe", "\"/O \"" + defaultPath + " \" " + archivPath + "\"");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show(exception.Message, "TOTALCOMANDER nelze spustit", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            string defaultPath = Path.GetDirectoryName(Application.ExecutablePath);
            string ExcelXORPath = Path.Combine(defaultPath, "XOR table.xlsx");

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = ExcelXORPath;
                psi.WorkingDirectory = defaultPath;
                psi.UseShellExecute = true;
                Process.Start(psi);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show(exception.Message, "EXCEL XOR table.xlsx nelze spustit", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
    