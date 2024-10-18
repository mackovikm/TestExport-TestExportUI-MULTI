using System;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TestExportUI
{
    public partial class frmMain : Form
    {
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
        }

        private void txtKEY_TextChanged(object sender, EventArgs e)
        {
            strKey = txtKEY.Text;
        }

        private void txtDATA_TextChanged(object sender, EventArgs e)
        {
            strData = txtDATA.Text;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string? exePath = Path.GetFullPath(@"d:\develop\TestExport\x64\Debug\TestExport.exe");
            string  exeFind = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "TestExport.exe");
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
    }
}
