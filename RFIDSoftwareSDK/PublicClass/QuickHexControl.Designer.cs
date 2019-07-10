namespace ADSDK.Bases.Controls
{
    partial class QuickHexControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblText = new System.Windows.Forms.Label();
            this.pnlText = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDEC = new System.Windows.Forms.Panel();
            this.lblDec = new System.Windows.Forms.Label();
            this.pnlHEX = new System.Windows.Forms.Panel();
            this.pnlWG = new System.Windows.Forms.Panel();
            this.lblHex = new System.Windows.Forms.Label();
            this.lblWg = new System.Windows.Forms.Label();
            this.utxtWg = new ADSDK.Bases.Components.FormatTextBox();
            this.utxtHex = new ADSDK.Bases.Components.FormatTextBox();
            this.utxtDec = new ADSDK.Bases.Components.FormatTextBox();
            this.pnlTitleSpet = new System.Windows.Forms.Panel();
            this.pnlText.SuspendLayout();
            this.pnlDEC.SuspendLayout();
            this.pnlHEX.SuspendLayout();
            this.pnlWG.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblText.Location = new System.Drawing.Point(0, 20);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(120, 30);
            this.lblText.TabIndex = 26;
            this.lblText.Text = "Write No.:";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlText
            // 
            this.pnlText.Controls.Add(this.lblText);
            this.pnlText.Controls.Add(this.label1);
            this.pnlText.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlText.Location = new System.Drawing.Point(0, 0);
            this.pnlText.Name = "pnlText";
            this.pnlText.Size = new System.Drawing.Size(120, 44);
            this.pnlText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 28;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlDEC
            // 
            this.pnlDEC.Controls.Add(this.utxtDec);
            this.pnlDEC.Controls.Add(this.lblDec);
            this.pnlDEC.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDEC.Location = new System.Drawing.Point(120, 0);
            this.pnlDEC.Name = "pnlDEC";
            this.pnlDEC.Size = new System.Drawing.Size(120, 44);
            this.pnlDEC.TabIndex = 5;
            // 
            // lblDec
            // 
            this.lblDec.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDec.Location = new System.Drawing.Point(0, 0);
            this.lblDec.Name = "lblDec";
            this.lblDec.Size = new System.Drawing.Size(120, 20);
            this.lblDec.TabIndex = 18;
            this.lblDec.Text = "DEC";
            this.lblDec.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pnlHEX
            // 
            this.pnlHEX.Controls.Add(this.utxtHex);
            this.pnlHEX.Controls.Add(this.lblHex);
            this.pnlHEX.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlHEX.Location = new System.Drawing.Point(240, 0);
            this.pnlHEX.Name = "pnlHEX";
            this.pnlHEX.Size = new System.Drawing.Size(120, 44);
            this.pnlHEX.TabIndex = 6;
            // 
            // pnlWG
            // 
            this.pnlWG.Controls.Add(this.utxtWg);
            this.pnlWG.Controls.Add(this.lblWg);
            this.pnlWG.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlWG.Location = new System.Drawing.Point(360, 0);
            this.pnlWG.Name = "pnlWG";
            this.pnlWG.Size = new System.Drawing.Size(120, 44);
            this.pnlWG.TabIndex = 7;
            // 
            // lblHex
            // 
            this.lblHex.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHex.Location = new System.Drawing.Point(0, 0);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(120, 20);
            this.lblHex.TabIndex = 19;
            this.lblHex.Text = "HEX";
            this.lblHex.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblWg
            // 
            this.lblWg.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWg.Location = new System.Drawing.Point(0, 0);
            this.lblWg.Name = "lblWg";
            this.lblWg.Size = new System.Drawing.Size(120, 20);
            this.lblWg.TabIndex = 25;
            this.lblWg.Text = "WG";
            this.lblWg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // utxtWg
            // 
            this.utxtWg.Dock = System.Windows.Forms.DockStyle.Top;
            this.utxtWg.ErrorInvalid = false;
            this.utxtWg.InputChar = '0';
            this.utxtWg.InputMask = "00000,00000";
            this.utxtWg.Location = new System.Drawing.Point(0, 20);
            this.utxtWg.MaxLength = 11;
            this.utxtWg.Name = "utxtWg";
            this.utxtWg.Size = new System.Drawing.Size(120, 21);
            this.utxtWg.StdInputMask = ADSDK.Bases.Components.FormatTextBox.InputMaskType.Custom;
            this.utxtWg.TabIndex = 25;
            this.utxtWg.TabStop = false;
            this.utxtWg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.utxtWg.TextChanged += new System.EventHandler(this.utxtWg_TextChanged);
            // 
            // utxtHex
            // 
            this.utxtHex.Dock = System.Windows.Forms.DockStyle.Top;
            this.utxtHex.ErrorInvalid = false;
            this.utxtHex.InputChar = '0';
            this.utxtHex.InputMask = "HH-HH-HH-HH";
            this.utxtHex.Location = new System.Drawing.Point(0, 20);
            this.utxtHex.MaxLength = 11;
            this.utxtHex.Name = "utxtHex";
            this.utxtHex.Size = new System.Drawing.Size(120, 21);
            this.utxtHex.StdInputMask = ADSDK.Bases.Components.FormatTextBox.InputMaskType.Custom;
            this.utxtHex.TabIndex = 24;
            this.utxtHex.TabStop = false;
            this.utxtHex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.utxtHex.TextChanged += new System.EventHandler(this.utxtHex_TextChanged);
            // 
            // utxtDec
            // 
            this.utxtDec.Dock = System.Windows.Forms.DockStyle.Top;
            this.utxtDec.ErrorInvalid = false;
            this.utxtDec.InputChar = '0';
            this.utxtDec.InputMask = "0000000000";
            this.utxtDec.Location = new System.Drawing.Point(0, 20);
            this.utxtDec.MaxLength = 10;
            this.utxtDec.Name = "utxtDec";
            this.utxtDec.Size = new System.Drawing.Size(120, 21);
            this.utxtDec.StdInputMask = ADSDK.Bases.Components.FormatTextBox.InputMaskType.Custom;
            this.utxtDec.TabIndex = 27;
            this.utxtDec.TabStop = false;
            this.utxtDec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.utxtDec.TextChanged += new System.EventHandler(this.utxtDec_TextChanged);
            // 
            // pnlTitleSpet
            // 
            this.pnlTitleSpet.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleSpet.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleSpet.Name = "pnlTitleSpet";
            this.pnlTitleSpet.Size = new System.Drawing.Size(480, 0);
            this.pnlTitleSpet.TabIndex = 8;
            // 
            // QuickHexControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.pnlWG);
            this.Controls.Add(this.pnlHEX);
            this.Controls.Add(this.pnlDEC);
            this.Controls.Add(this.pnlText);
            this.Controls.Add(this.pnlTitleSpet);
            this.Name = "QuickHexControl";
            this.Size = new System.Drawing.Size(480, 44);
            this.Resize += new System.EventHandler(this.QuickHexControl_Resize);
            this.pnlText.ResumeLayout(false);
            this.pnlDEC.ResumeLayout(false);
            this.pnlDEC.PerformLayout();
            this.pnlHEX.ResumeLayout(false);
            this.pnlHEX.PerformLayout();
            this.pnlWG.ResumeLayout(false);
            this.pnlWG.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Components.FormatTextBox utxtWg;
        private Components.FormatTextBox utxtHex;
        private System.Windows.Forms.Label lblText;
        private Components.FormatTextBox utxtDec;
        private System.Windows.Forms.Panel pnlText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDEC;
        private System.Windows.Forms.Label lblDec;
        private System.Windows.Forms.Panel pnlHEX;
        private System.Windows.Forms.Panel pnlWG;
        private System.Windows.Forms.Label lblHex;
        private System.Windows.Forms.Label lblWg;
        private System.Windows.Forms.Panel pnlTitleSpet;
    }
}
