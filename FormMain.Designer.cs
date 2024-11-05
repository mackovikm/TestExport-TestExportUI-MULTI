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
            lblIVLen = new Label();
            lblKEYLen = new Label();
            lblDATALen = new Label();
            btnIVReset = new Button();
            btnKEYReset = new Button();
            btnDATAReset = new Button();
            txtIVStack = new TextBox();
            txtKEYStack = new TextBox();
            txtDATAStack = new TextBox();
            btnIVStack = new Button();
            btnKeyStack = new Button();
            btnDataStack = new Button();
            btnKey = new Button();
            brnKeyRevert = new Button();
            splitContainer1 = new SplitContainer();
            txtOut2 = new TextBox();
            txtOut1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.Location = new Point(1066, 466);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(80, 23);
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
            txtIV.Click += txtIV_Click;
            txtIV.TextChanged += txtIV_TextChanged;
            txtIV.DoubleClick += txtIV_DoubleClick;
            txtIV.KeyPress += txtIV_KeyPress;
            // 
            // txtKEY
            // 
            txtKEY.Location = new Point(323, 25);
            txtKEY.Name = "txtKEY";
            txtKEY.Size = new Size(241, 23);
            txtKEY.TabIndex = 2;
            txtKEY.Text = "aab8d355400b01e3dd521535acf0e110";
            txtKEY.Click += txtKEY_Click;
            txtKEY.TextChanged += txtKEY_TextChanged;
            txtKEY.DoubleClick += txtKEY_DoubleClick;
            txtKEY.KeyPress += txtKEY_KeyPress;
            // 
            // txtDATA
            // 
            txtDATA.Location = new Point(637, 25);
            txtDATA.Name = "txtDATA";
            txtDATA.Size = new Size(241, 23);
            txtDATA.TabIndex = 3;
            txtDATA.Text = "2fcb3dd0eb2210a6896e1286ac673b0f";
            txtDATA.Click += txtDATA_Click;
            txtDATA.TextChanged += txtDATA_TextChanged;
            txtDATA.DoubleClick += txtDATA_DoubleClick;
            txtDATA.KeyPress += txtDATA_KeyPress;
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
            btnRun.Location = new Point(982, 466);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(80, 23);
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
            radioDecode.Location = new Point(18, 468);
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
            radioEncode.Location = new Point(100, 468);
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
            btnCopy.Location = new Point(571, 468);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(130, 23);
            btnCopy.TabIndex = 12;
            btnCopy.Text = "&Do clipboardu";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
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
            btnIVReset.Size = new Size(23, 23);
            btnIVReset.TabIndex = 18;
            btnIVReset.Text = "R";
            btnIVReset.UseVisualStyleBackColor = true;
            btnIVReset.Click += btnIVReset_Click;
            // 
            // btnKEYReset
            // 
            btnKEYReset.Location = new Point(570, 25);
            btnKEYReset.Name = "btnKEYReset";
            btnKEYReset.Size = new Size(23, 23);
            btnKEYReset.TabIndex = 19;
            btnKEYReset.Text = "R";
            btnKEYReset.UseVisualStyleBackColor = true;
            btnKEYReset.Click += btnKEYReset_Click;
            // 
            // btnDATAReset
            // 
            btnDATAReset.Location = new Point(884, 25);
            btnDATAReset.Name = "btnDATAReset";
            btnDATAReset.Size = new Size(23, 23);
            btnDATAReset.TabIndex = 20;
            btnDATAReset.Text = "R";
            btnDATAReset.UseVisualStyleBackColor = true;
            btnDATAReset.Click += btnDATAReset_Click;
            // 
            // txtIVStack
            // 
            txtIVStack.Location = new Point(18, 53);
            txtIVStack.Name = "txtIVStack";
            txtIVStack.Size = new Size(241, 23);
            txtIVStack.TabIndex = 21;
            txtIVStack.Text = "2436372c6566892db1ddbd65bc657082";
            txtIVStack.Click += txtIVStack_Click;
            txtIVStack.DoubleClick += txtIVStack_DoubleClick;
            // 
            // txtKEYStack
            // 
            txtKEYStack.Location = new Point(323, 53);
            txtKEYStack.Name = "txtKEYStack";
            txtKEYStack.Size = new Size(241, 23);
            txtKEYStack.TabIndex = 22;
            txtKEYStack.Text = "aab8d355400b01e3dd521535acf0e110";
            txtKEYStack.Click += txtKEYStack_Click;
            txtKEYStack.DoubleClick += txtKEYStack_DoubleClick;
            // 
            // txtDATAStack
            // 
            txtDATAStack.Location = new Point(637, 53);
            txtDATAStack.Name = "txtDATAStack";
            txtDATAStack.Size = new Size(241, 23);
            txtDATAStack.TabIndex = 23;
            txtDATAStack.Text = "49492a0010000000435202004ab20000";
            txtDATAStack.Click += txtDATAStack_Click;
            txtDATAStack.DoubleClick += txtDATAStack_DoubleClick;
            // 
            // btnIVStack
            // 
            btnIVStack.Location = new Point(264, 53);
            btnIVStack.Name = "btnIVStack";
            btnIVStack.Size = new Size(23, 23);
            btnIVStack.TabIndex = 24;
            btnIVStack.Text = "X";
            btnIVStack.UseVisualStyleBackColor = true;
            btnIVStack.Click += btnIVStack_Click;
            // 
            // btnKeyStack
            // 
            btnKeyStack.Location = new Point(571, 53);
            btnKeyStack.Name = "btnKeyStack";
            btnKeyStack.Size = new Size(23, 23);
            btnKeyStack.TabIndex = 25;
            btnKeyStack.Text = "X";
            btnKeyStack.UseVisualStyleBackColor = true;
            btnKeyStack.Click += btnKeyStack_Click;
            // 
            // btnDataStack
            // 
            btnDataStack.Location = new Point(884, 53);
            btnDataStack.Name = "btnDataStack";
            btnDataStack.Size = new Size(23, 23);
            btnDataStack.TabIndex = 27;
            btnDataStack.Text = "X";
            btnDataStack.UseVisualStyleBackColor = true;
            btnDataStack.Click += btnDataStack_Click;
            // 
            // btnKey
            // 
            btnKey.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnKey.Location = new Point(778, 468);
            btnKey.Name = "btnKey";
            btnKey.Size = new Size(80, 23);
            btnKey.TabIndex = 28;
            btnKey.Text = "&Key";
            btnKey.UseVisualStyleBackColor = true;
            btnKey.Click += btnKey_Click;
            // 
            // brnKeyRevert
            // 
            brnKeyRevert.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            brnKeyRevert.Location = new Point(864, 468);
            brnKeyRevert.Name = "brnKeyRevert";
            brnKeyRevert.Size = new Size(80, 23);
            brnKeyRevert.TabIndex = 29;
            brnKeyRevert.Text = "Key &Revert";
            brnKeyRevert.UseVisualStyleBackColor = true;
            brnKeyRevert.Click += brnKeyRevert_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(18, 102);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(txtOut2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtOut1);
            splitContainer1.Size = new Size(1128, 358);
            splitContainer1.SplitterDistance = 564;
            splitContainer1.TabIndex = 30;
            // 
            // txtOut2
            // 
            txtOut2.Dock = DockStyle.Fill;
            txtOut2.Font = new Font("Cascadia Mono SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            txtOut2.Location = new Point(0, 0);
            txtOut2.Multiline = true;
            txtOut2.Name = "txtOut2";
            txtOut2.ScrollBars = ScrollBars.Both;
            txtOut2.Size = new Size(564, 358);
            txtOut2.TabIndex = 33;
            // 
            // txtOut1
            // 
            txtOut1.Dock = DockStyle.Fill;
            txtOut1.Font = new Font("Cascadia Mono SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            txtOut1.Location = new Point(0, 0);
            txtOut1.Multiline = true;
            txtOut1.Name = "txtOut1";
            txtOut1.ScrollBars = ScrollBars.Both;
            txtOut1.Size = new Size(560, 358);
            txtOut1.TabIndex = 15;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 499);
            Controls.Add(splitContainer1);
            Controls.Add(brnKeyRevert);
            Controls.Add(btnKey);
            Controls.Add(btnDataStack);
            Controls.Add(btnKeyStack);
            Controls.Add(btnIVStack);
            Controls.Add(txtDATAStack);
            Controls.Add(txtKEYStack);
            Controls.Add(txtIVStack);
            Controls.Add(btnDATAReset);
            Controls.Add(btnKEYReset);
            Controls.Add(btnIVReset);
            Controls.Add(lblDATALen);
            Controls.Add(lblKEYLen);
            Controls.Add(lblIVLen);
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
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
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
        private Label lblIVLen;
        private Label lblKEYLen;
        private Label lblDATALen;
        private Button btnIVReset;
        private Button btnKEYReset;
        private Button btnDATAReset;
        private TextBox txtIVStack;
        private TextBox txtKEYStack;
        private TextBox txtDATAStack;
        private Button btnIVStack;
        private Button btnKeyStack;
        private Button btnDataStack;
        private Button btnKey;
        private Button brnKeyRevert;
        private SplitContainer splitContainer1;
        private TextBox txtOut2;
        private TextBox txtOut1;
    }
}
