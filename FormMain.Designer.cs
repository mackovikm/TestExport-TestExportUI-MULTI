namespace TestExportUI
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnClose = new Button();
            txtIV = new TextBox();
            txtKEY = new TextBox();
            txtDATA = new TextBox();
            lblIV = new Label();
            lblKEY = new Label();
            lblDATA = new Label();
            btnRun = new Button();
            radioDecode = new RadioButton();
            radioEncode = new RadioButton();
            btnCopy = new Button();
            txtOut2 = new TextBox();
            txtOut1 = new TextBox();
            lblIVLen = new Label();
            lblKEYLen = new Label();
            lblDATALen = new Label();
            btnIVReset = new Button();
            btnKEYReset = new Button();
            btnDATAReset = new Button();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.Location = new Point(1072, 464);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 0;
            btnClose.Text = "&Zavřít";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtIV
            // 
            txtIV.Location = new Point(17, 25);
            txtIV.Name = "txtIV";
            txtIV.Size = new Size(241, 23);
            txtIV.TabIndex = 1;
            txtIV.Text = "2436372c6566892db1ddbd65bc657082";
            txtIV.TextChanged += txtIV_TextChanged;
            // 
            // txtKEY
            // 
            txtKEY.Location = new Point(323, 25);
            txtKEY.Name = "txtKEY";
            txtKEY.Size = new Size(241, 23);
            txtKEY.TabIndex = 2;
            txtKEY.Text = "aab8d355400b01e3dd521535acf0e110";
            txtKEY.TextChanged += txtKEY_TextChanged;
            // 
            // txtDATA
            // 
            txtDATA.Location = new Point(637, 25);
            txtDATA.Name = "txtDATA";
            txtDATA.Size = new Size(241, 23);
            txtDATA.TabIndex = 3;
            txtDATA.Text = "2fcb3dd0eb2210a6896e1286ac673b0f";
            txtDATA.TextChanged += txtDATA_TextChanged;
            // 
            // lblIV
            // 
            lblIV.AutoSize = true;
            lblIV.Location = new Point(17, 7);
            lblIV.Name = "lblIV";
            lblIV.Size = new Size(17, 15);
            lblIV.TabIndex = 5;
            lblIV.Text = "IV";
            // 
            // lblKEY
            // 
            lblKEY.AutoSize = true;
            lblKEY.Location = new Point(323, 7);
            lblKEY.Name = "lblKEY";
            lblKEY.Size = new Size(27, 15);
            lblKEY.TabIndex = 6;
            lblKEY.Text = "KEY";
            // 
            // lblDATA
            // 
            lblDATA.AutoSize = true;
            lblDATA.Location = new Point(637, 7);
            lblDATA.Name = "lblDATA";
            lblDATA.Size = new Size(35, 15);
            lblDATA.TabIndex = 7;
            lblDATA.Text = "DATA";
            // 
            // btnRun
            // 
            btnRun.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRun.Location = new Point(991, 464);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(75, 23);
            btnRun.TabIndex = 8;
            btnRun.Text = "&Spustit";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // radioDecode
            // 
            radioDecode.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioDecode.AutoSize = true;
            radioDecode.Checked = true;
            radioDecode.Location = new Point(28, 468);
            radioDecode.Name = "radioDecode";
            radioDecode.Size = new Size(65, 19);
            radioDecode.TabIndex = 9;
            radioDecode.TabStop = true;
            radioDecode.Text = "Decode";
            radioDecode.UseVisualStyleBackColor = true;
            radioDecode.CheckedChanged += radioDecode_CheckedChanged;
            // 
            // radioEncode
            // 
            radioEncode.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioEncode.AutoSize = true;
            radioEncode.Location = new Point(115, 468);
            radioEncode.Name = "radioEncode";
            radioEncode.Size = new Size(64, 19);
            radioEncode.TabIndex = 10;
            radioEncode.Text = "Encode";
            radioEncode.UseVisualStyleBackColor = true;
            radioEncode.CheckedChanged += radioEncode_CheckedChanged;
            // 
            // btnCopy
            // 
            btnCopy.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCopy.Location = new Point(831, 464);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(129, 23);
            btnCopy.TabIndex = 12;
            btnCopy.Text = "&Do clipboardu";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // txtOut2
            // 
            txtOut2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtOut2.Font = new Font("Cascadia Mono SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            txtOut2.Location = new Point(17, 65);
            txtOut2.Multiline = true;
            txtOut2.Name = "txtOut2";
            txtOut2.ScrollBars = ScrollBars.Both;
            txtOut2.Size = new Size(562, 376);
            txtOut2.TabIndex = 13;
            // 
            // txtOut1
            // 
            txtOut1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtOut1.Font = new Font("Cascadia Mono SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            txtOut1.Location = new Point(571, 65);
            txtOut1.Multiline = true;
            txtOut1.Name = "txtOut1";
            txtOut1.ScrollBars = ScrollBars.Both;
            txtOut1.Size = new Size(576, 376);
            txtOut1.TabIndex = 14;
            // 
            // lblIVLen
            // 
            lblIVLen.AutoSize = true;
            lblIVLen.Location = new Point(244, 7);
            lblIVLen.Name = "lblIVLen";
            lblIVLen.Size = new Size(14, 15);
            lblIVLen.TabIndex = 15;
            lblIVLen.Text = "X";
            // 
            // lblKEYLen
            // 
            lblKEYLen.AutoSize = true;
            lblKEYLen.Location = new Point(550, 7);
            lblKEYLen.Name = "lblKEYLen";
            lblKEYLen.Size = new Size(14, 15);
            lblKEYLen.TabIndex = 16;
            lblKEYLen.Text = "X";
            // 
            // lblDATALen
            // 
            lblDATALen.AutoSize = true;
            lblDATALen.Location = new Point(864, 7);
            lblDATALen.Name = "lblDATALen";
            lblDATALen.Size = new Size(14, 15);
            lblDATALen.TabIndex = 17;
            lblDATALen.Text = "X";
            // 
            // btnIVReset
            // 
            btnIVReset.Location = new Point(264, 25);
            btnIVReset.Name = "btnIVReset";
            btnIVReset.Size = new Size(23, 21);
            btnIVReset.TabIndex = 18;
            btnIVReset.Text = "R";
            btnIVReset.UseVisualStyleBackColor = true;
            btnIVReset.Click += btnIVReset_Click;
            // 
            // btnKEYReset
            // 
            btnKEYReset.Location = new Point(570, 25);
            btnKEYReset.Name = "btnKEYReset";
            btnKEYReset.Size = new Size(23, 21);
            btnKEYReset.TabIndex = 19;
            btnKEYReset.Text = "R";
            btnKEYReset.UseVisualStyleBackColor = true;
            btnKEYReset.Click += btnKEYReset_Click;
            // 
            // btnDATAReset
            // 
            btnDATAReset.Location = new Point(884, 27);
            btnDATAReset.Name = "btnDATAReset";
            btnDATAReset.Size = new Size(23, 21);
            btnDATAReset.TabIndex = 20;
            btnDATAReset.Text = "R";
            btnDATAReset.UseVisualStyleBackColor = true;
            btnDATAReset.Click += btnDATAReset_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 499);
            Controls.Add(btnDATAReset);
            Controls.Add(btnKEYReset);
            Controls.Add(btnIVReset);
            Controls.Add(lblDATALen);
            Controls.Add(lblKEYLen);
            Controls.Add(lblIVLen);
            Controls.Add(txtOut1);
            Controls.Add(txtOut2);
            Controls.Add(btnCopy);
            Controls.Add(radioEncode);
            Controls.Add(radioDecode);
            Controls.Add(btnRun);
            Controls.Add(lblDATA);
            Controls.Add(lblKEY);
            Controls.Add(lblIV);
            Controls.Add(txtDATA);
            Controls.Add(txtKEY);
            Controls.Add(txtIV);
            Controls.Add(btnClose);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CBC Test";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnClose;
        private TextBox txtIV;
        private TextBox txtKEY;
        private TextBox txtDATA;
        private Label lblIV;
        private Label lblKEY;
        private Label lblDATA;
        private Button btnRun;
        private RadioButton radioDecode;
        private RadioButton radioEncode;
        private Button btnCopy;
        private TextBox txtOut2;
        private TextBox txtOut1;
        private Label lblIVLen;
        private Label lblKEYLen;
        private Label lblDATALen;
        private Button btnIVReset;
        private Button btnKEYReset;
        private Button btnDATAReset;
    }
}
