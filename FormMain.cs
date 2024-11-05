using System;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TestExportUI
{
    public partial class frmMain : Form
    {
        private const string cIV = "2436372c6566892db1ddbd65bc657082";
        private const string cKEY = "aab8d355400b01e3dd521535acf0e110";
        private const string cDATA = "2fcb3dd0eb2210a6896e1286ac673b0f";

        private string strAkce = string.Empty;
        private string strIV = string.Empty;
        private string strKey = string.Empty;
        private string strData = string.Empty;


        public frmMain()
        {
            InitializeComponent();

            strAkce = "-d";
            strIV = txtIV.Text;
            strKey = txtKEY.Text;
            strData = txtDATA.Text;

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

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (!ValidData())
            {
                MessageBox.Show("Neplatná vstupní data", "CHYBA VSTUPNÍCH DAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string? exePath = Path.GetFullPath(@"d:\develop\TestExport\x64\Debug\TestExport.exe");
            string exeFind = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "TestExport.exe");
            if (File.Exists(exeFind))
            {
                exePath = Path.GetFullPath(exeFind);
            }

            string strFilename = String.Format("Export_{0}.txt", DateTime.Now.ToString("yyyyMMdd-HHmmss"));
            string exeParams = String.Concat(strAkce, " ", strIV, " ", strKey, " ", strData, " ", strFilename);

            ProcessStartInfo startInfo = new ProcessStartInfo(exePath);
            startInfo.Arguments = exeParams;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;

            Process? exeProcess = Process.Start(startInfo);

            if (exeProcess != null)
            {
                // Synchronously read the standard output of the spawned process.
                StreamReader reader = exeProcess.StandardOutput;
                string output = reader.ReadToEnd();

                if (exeProcess.WaitForExit(10000))
                {
                    txtOut2.Text = txtOut1.Text;
                    txtOut1.Text = output;
                }
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtOut1.Text);
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

        private bool ValidData()
        {
            if (strIV.Length != 32)
            {
                return false;
            }

            if (strKey.Length != 32)
            {
                return false;
            }

            if (strData.Length != 32)
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
            txtDATA.Text = cDATA;
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

        private void btnKey_Click(object sender, EventArgs e)
        {
            strAkce = "-k";
            strKey = txtKEY.Text;

            if (!ValidData())
            {
                MessageBox.Show("Neplatná vstupní data", "CHYBA VSTUPNÍCH DAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string? exePath = Path.GetFullPath(@"d:\develop\TestExport\x64\Debug\TestExport.exe");
            string exeFind = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "TestExport.exe");
            if (File.Exists(exeFind))
            {
                exePath = Path.GetFullPath(exeFind);
            }

            string strFilename = String.Format("Export_{0}.txt", DateTime.Now.ToString("yyyyMMdd-HHmmss"));
            string exeParams = String.Concat(strAkce, " ", strKey, " ", strFilename);

            ProcessStartInfo startInfo = new ProcessStartInfo(exePath);
            startInfo.Arguments = exeParams;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;

            Process? exeProcess = Process.Start(startInfo);

            if (exeProcess != null)
            {
                // Synchronously read the standard output of the spawned process.
                StreamReader reader = exeProcess.StandardOutput;
                string output = reader.ReadToEnd();

                if (exeProcess.WaitForExit(30000))
                {
                    txtOut2.Text = txtOut1.Text;
                    txtOut1.Text = output;
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
        }

        private void brnKeyRevert_Click(object sender, EventArgs e)
        {
            strAkce = "-r";
            strKey = txtKEY.Text;

            if (!ValidData())
            {
                MessageBox.Show("Neplatná vstupní data", "CHYBA VSTUPNÍCH DAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string? exePath = Path.GetFullPath(@"d:\develop\TestExport\x64\Debug\TestExport.exe");
            string exeFind = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "TestExport.exe");
            if (File.Exists(exeFind))
            {
                exePath = Path.GetFullPath(exeFind);
            }

            string strFilename = String.Format("Export_{0}.txt", DateTime.Now.ToString("yyyyMMdd-HHmmss"));
            string exeParams = String.Concat(strAkce, " ", strKey, " ", strFilename);

            ProcessStartInfo startInfo = new ProcessStartInfo(exePath);
            startInfo.Arguments = exeParams;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;

            Process? exeProcess = Process.Start(startInfo);

            if (exeProcess != null)
            {
                // Synchronously read the standard output of the spawned process.
                StreamReader reader = exeProcess.StandardOutput;
                string output = reader.ReadToEnd();

                if (exeProcess.WaitForExit(30000))
                {
                    txtOut2.Text = txtOut1.Text;
                    txtOut1.Text = output;
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
        }

        private void txtOut2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    