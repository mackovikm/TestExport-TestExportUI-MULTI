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
            strIV = txtIV.Text;
            SetLengthInfo();
        }

        private void txtKEY_TextChanged(object sender, EventArgs e)
        {
            strKey = txtKEY.Text;
            SetLengthInfo();
        }

        private void txtDATA_TextChanged(object sender, EventArgs e)
        {
            strData = txtDATA.Text;
            SetLengthInfo();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if(!ValidData())
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

        private bool ValidData()
        {
            if(strIV.Length != 32)
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
    }
}
