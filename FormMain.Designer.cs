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
            components = new System.ComponentModel.Container();
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
            splitContainer1 = new SplitContainer();
            txtOut = new TextBox();
            txtKeyList = new TextBox();
            brnKeyRevert = new Button();
            btnKeyGEN = new Button();
            btnKey = new Button();
            btnKeyRevertGEN = new Button();
            label1 = new Label();
            txtCountFrom = new TextBox();
            txtCountTo = new TextBox();
            btnSAVE = new Button();
            contextMenuOut = new ContextMenuStrip(components);
            toolStripOutClear = new ToolStripMenuItem();
            toolStripOutSeparator = new ToolStripSeparator();
            toolStripOutSave = new ToolStripMenuItem();
            contextMenuKey = new ContextMenuStrip(components);
            toolStripKeyClear = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripKeySave = new ToolStripMenuItem();
            btnLOAD = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            contextMenuOut.SuspendLayout();
            contextMenuKey.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.Location = new Point(1041, 466);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(105, 23);
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
            txtKEY.AcceptsReturn = true;
            txtKEY.Location = new Point(323, 25);
            txtKEY.Name = "txtKEY";
            txtKEY.Size = new Size(241, 23);
            txtKEY.TabIndex = 2;
            txtKEY.Text = "xxb8d355400b01e3dd521535acf0e110";
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
            txtDATA.Text = "49492a0010000000435202004ab20000";
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
            lblDATA.Size = new Size(36, 15);
            lblDATA.TabIndex = 7;
            lblDATA.Text = "DATA";
            // 
            // btnRun
            // 
            btnRun.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRun.Location = new Point(932, 466);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(105, 23);
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
            radioEncode.Location = new Point(89, 468);
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
            btnCopy.Location = new Point(333, 466);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(80, 23);
            btnCopy.TabIndex = 12;
            btnCopy.Text = "&Clipboard";
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
            txtKEYStack.Text = "930b3abb7099e355bf562b9503fa309b";
            txtKEYStack.Click += txtKEYStack_Click;
            txtKEYStack.DoubleClick += txtKEYStack_DoubleClick;
            // 
            // txtDATAStack
            // 
            txtDATAStack.Location = new Point(637, 53);
            txtDATAStack.Name = "txtDATAStack";
            txtDATAStack.Size = new Size(241, 23);
            txtDATAStack.TabIndex = 23;
            txtDATAStack.Text = "2fcb3dd0eb2210a6896e1286ac673b0f";
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
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(18, 102);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(txtOut);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtKeyList);
            splitContainer1.Size = new Size(1128, 358);
            splitContainer1.SplitterDistance = 499;
            splitContainer1.TabIndex = 30;
            // 
            // txtOut
            // 
            txtOut.AcceptsReturn = true;
            txtOut.Dock = DockStyle.Fill;
            txtOut.Font = new Font("Cascadia Mono SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            txtOut.Location = new Point(0, 0);
            txtOut.Multiline = true;
            txtOut.Name = "txtOut";
            txtOut.ScrollBars = ScrollBars.Both;
            txtOut.Size = new Size(499, 358);
            txtOut.TabIndex = 33;
            txtOut.DoubleClick += txtOut_DoubleClick;
            // 
            // txtKeyList
            // 
            txtKeyList.AcceptsReturn = true;
            txtKeyList.Dock = DockStyle.Fill;
            txtKeyList.Font = new Font("Cascadia Mono SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            txtKeyList.Location = new Point(0, 0);
            txtKeyList.Multiline = true;
            txtKeyList.Name = "txtKeyList";
            txtKeyList.ScrollBars = ScrollBars.Both;
            txtKeyList.Size = new Size(625, 358);
            txtKeyList.TabIndex = 34;
            txtKeyList.DoubleClick += txtKeyList_DoubleClick;
            // 
            // brnKeyRevert
            // 
            brnKeyRevert.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            brnKeyRevert.Location = new Point(246, 466);
            brnKeyRevert.Name = "brnKeyRevert";
            brnKeyRevert.Size = new Size(80, 23);
            brnKeyRevert.TabIndex = 32;
            brnKeyRevert.Text = "Key &Revert";
            brnKeyRevert.UseVisualStyleBackColor = true;
            brnKeyRevert.Click += btnKeyRevert_Click;
            // 
            // btnKeyGEN
            // 
            btnKeyGEN.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnKeyGEN.Location = new Point(714, 466);
            btnKeyGEN.Name = "btnKeyGEN";
            btnKeyGEN.Size = new Size(105, 23);
            btnKeyGEN.TabIndex = 31;
            btnKeyGEN.Text = "&Key GEN";
            btnKeyGEN.UseVisualStyleBackColor = true;
            btnKeyGEN.Click += btnKeyGEN_Click;
            // 
            // btnKey
            // 
            btnKey.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnKey.Location = new Point(159, 466);
            btnKey.Name = "btnKey";
            btnKey.Size = new Size(80, 23);
            btnKey.TabIndex = 33;
            btnKey.Text = "&Key";
            btnKey.UseVisualStyleBackColor = true;
            btnKey.Click += btnKey_Click;
            // 
            // btnKeyRevertGEN
            // 
            btnKeyRevertGEN.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnKeyRevertGEN.Location = new Point(823, 466);
            btnKeyRevertGEN.Name = "btnKeyRevertGEN";
            btnKeyRevertGEN.Size = new Size(105, 23);
            btnKeyRevertGEN.TabIndex = 34;
            btnKeyRevertGEN.Text = "&Key Revert GEN";
            btnKeyRevertGEN.UseVisualStyleBackColor = true;
            btnKeyRevertGEN.Click += btnKeyRevertGEN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(934, 8);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 36;
            label1.Text = "COUNT";
            // 
            // txtCountFrom
            // 
            txtCountFrom.Location = new Point(934, 26);
            txtCountFrom.Name = "txtCountFrom";
            txtCountFrom.Size = new Size(42, 23);
            txtCountFrom.TabIndex = 35;
            txtCountFrom.Text = "00";
            txtCountFrom.TextAlign = HorizontalAlignment.Center;
            txtCountFrom.TextChanged += txtCountFrom_TextChanged;
            // 
            // txtCountTo
            // 
            txtCountTo.Location = new Point(982, 25);
            txtCountTo.Name = "txtCountTo";
            txtCountTo.Size = new Size(42, 23);
            txtCountTo.TabIndex = 37;
            txtCountTo.Text = "ff";
            txtCountTo.TextAlign = HorizontalAlignment.Center;
            txtCountTo.TextChanged += txtCountTo_TextChanged;
            // 
            // btnSAVE
            // 
            btnSAVE.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSAVE.Location = new Point(472, 466);
            btnSAVE.Name = "btnSAVE";
            btnSAVE.Size = new Size(45, 23);
            btnSAVE.TabIndex = 38;
            btnSAVE.Text = "&Save";
            btnSAVE.UseVisualStyleBackColor = true;
            btnSAVE.Click += btnSAVE_Click;
            // 
            // contextMenuOut
            // 
            contextMenuOut.Items.AddRange(new ToolStripItem[] { toolStripOutClear, toolStripOutSeparator, toolStripOutSave });
            contextMenuOut.Name = "contextMenuOut";
            contextMenuOut.Size = new Size(113, 54);
            // 
            // toolStripOutClear
            // 
            toolStripOutClear.Name = "toolStripOutClear";
            toolStripOutClear.Size = new Size(112, 22);
            toolStripOutClear.Text = "&Vyčistit";
            toolStripOutClear.Click += toolStripOutClear_Click;
            // 
            // toolStripOutSeparator
            // 
            toolStripOutSeparator.Name = "toolStripOutSeparator";
            toolStripOutSeparator.Size = new Size(109, 6);
            // 
            // toolStripOutSave
            // 
            toolStripOutSave.Name = "toolStripOutSave";
            toolStripOutSave.Size = new Size(112, 22);
            toolStripOutSave.Text = "&Save";
            toolStripOutSave.Click += toolStripOutSave_Click;
            // 
            // contextMenuKey
            // 
            contextMenuKey.Items.AddRange(new ToolStripItem[] { toolStripKeyClear, toolStripSeparator1, toolStripKeySave });
            contextMenuKey.Name = "contextMenuOut";
            contextMenuKey.Size = new Size(113, 54);
            // 
            // toolStripKeyClear
            // 
            toolStripKeyClear.Name = "toolStripKeyClear";
            toolStripKeyClear.Size = new Size(112, 22);
            toolStripKeyClear.Text = "&Vyčistit";
            toolStripKeyClear.Click += toolStripMenuItem1_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(109, 6);
            // 
            // toolStripKeySave
            // 
            toolStripKeySave.Name = "toolStripKeySave";
            toolStripKeySave.Size = new Size(112, 22);
            toolStripKeySave.Text = "&Save";
            toolStripKeySave.Click += toolStripKeySave_Click;
            // 
            // btnLOAD
            // 
            btnLOAD.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLOAD.Location = new Point(420, 466);
            btnLOAD.Name = "btnLOAD";
            btnLOAD.Size = new Size(45, 23);
            btnLOAD.TabIndex = 39;
            btnLOAD.Text = "&Load";
            btnLOAD.UseVisualStyleBackColor = true;
            btnLOAD.Click += btnLOAD_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 499);
            Controls.Add(btnLOAD);
            Controls.Add(btnSAVE);
            Controls.Add(txtCountTo);
            Controls.Add(label1);
            Controls.Add(txtCountFrom);
            Controls.Add(btnKeyRevertGEN);
            Controls.Add(btnKey);
            Controls.Add(brnKeyRevert);
            Controls.Add(btnKeyGEN);
            Controls.Add(splitContainer1);
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
            contextMenuOut.ResumeLayout(false);
            contextMenuKey.ResumeLayout(false);
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
        private SplitContainer splitContainer1;
        private TextBox txtOut;
        private Button brnKeyRevert;
        private Button btnKeyGEN;
        private Button btnKey;
        private Button btnKeyRevertGEN;
        private TextBox txtKeyList;
        private Label label1;
        private TextBox txtCountFrom;
        private TextBox txtCountTo;
        private Button btnSAVE;
        private ContextMenuStrip contextMenuOut;
        private ToolStripMenuItem toolStripOutClear;
        private ToolStripSeparator toolStripOutSeparator;
        private ToolStripMenuItem toolStripOutSave;
        private ContextMenuStrip contextMenuKey;
        private ToolStripMenuItem toolStripKeyClear;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripKeySave;
        private Button btnLOAD;
    }
}
