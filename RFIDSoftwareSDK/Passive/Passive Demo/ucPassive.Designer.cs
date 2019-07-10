namespace ADSDKDemo
{
    partial class ucPassive
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
            this.tabPassive = new System.Windows.Forms.TabControl();
            this.tabReadDemo = new System.Windows.Forms.TabPage();
            this.tabBaseSettings = new System.Windows.Forms.TabPage();
            this.tabSeniorSettings = new System.Windows.Forms.TabPage();
            this.tabWriteISO = new System.Windows.Forms.TabPage();
            this.tabWriteEPC = new System.Windows.Forms.TabPage();
            this.tabWifiSettings = new System.Windows.Forms.TabPage();
            this.tabPassive.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPassive
            // 
            this.tabPassive.Controls.Add(this.tabReadDemo);
            this.tabPassive.Controls.Add(this.tabBaseSettings);
            this.tabPassive.Controls.Add(this.tabSeniorSettings);
            this.tabPassive.Controls.Add(this.tabWriteISO);
            this.tabPassive.Controls.Add(this.tabWriteEPC);
            this.tabPassive.Controls.Add(this.tabWifiSettings);
            this.tabPassive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPassive.Location = new System.Drawing.Point(0, 0);
            this.tabPassive.Name = "tabPassive";
            this.tabPassive.SelectedIndex = 0;
            this.tabPassive.Size = new System.Drawing.Size(958, 513);
            this.tabPassive.TabIndex = 1;
            // 
            // tabReadDemo
            // 
            this.tabReadDemo.Location = new System.Drawing.Point(4, 22);
            this.tabReadDemo.Name = "tabReadDemo";
            this.tabReadDemo.Padding = new System.Windows.Forms.Padding(3);
            this.tabReadDemo.Size = new System.Drawing.Size(950, 487);
            this.tabReadDemo.TabIndex = 1;
            this.tabReadDemo.Text = "Read Demo";
            this.tabReadDemo.UseVisualStyleBackColor = true;
            // 
            // tabBaseSettings
            // 
            this.tabBaseSettings.Location = new System.Drawing.Point(4, 22);
            this.tabBaseSettings.Name = "tabBaseSettings";
            this.tabBaseSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabBaseSettings.Size = new System.Drawing.Size(950, 487);
            this.tabBaseSettings.TabIndex = 0;
            this.tabBaseSettings.Text = "Base Parameters";
            this.tabBaseSettings.UseVisualStyleBackColor = true;
            // 
            // tabSeniorSettings
            // 
            this.tabSeniorSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSeniorSettings.Name = "tabSeniorSettings";
            this.tabSeniorSettings.Size = new System.Drawing.Size(950, 487);
            this.tabSeniorSettings.TabIndex = 4;
            this.tabSeniorSettings.Text = "Senior Parameters";
            this.tabSeniorSettings.UseVisualStyleBackColor = true;
            // 
            // tabWriteISO
            // 
            this.tabWriteISO.Location = new System.Drawing.Point(4, 22);
            this.tabWriteISO.Name = "tabWriteISO";
            this.tabWriteISO.Size = new System.Drawing.Size(950, 487);
            this.tabWriteISO.TabIndex = 2;
            this.tabWriteISO.Text = "ISO18000-6B";
            this.tabWriteISO.UseVisualStyleBackColor = true;
            // 
            // tabWriteEPC
            // 
            this.tabWriteEPC.Location = new System.Drawing.Point(4, 22);
            this.tabWriteEPC.Name = "tabWriteEPC";
            this.tabWriteEPC.Size = new System.Drawing.Size(950, 487);
            this.tabWriteEPC.TabIndex = 3;
            this.tabWriteEPC.Text = "EPC(GEN 2)";
            this.tabWriteEPC.UseVisualStyleBackColor = true;
            // 
            // tabWifiSettings
            // 
            this.tabWifiSettings.Location = new System.Drawing.Point(4, 22);
            this.tabWifiSettings.Name = "tabWifiSettings";
            this.tabWifiSettings.Size = new System.Drawing.Size(950, 487);
            this.tabWifiSettings.TabIndex = 5;
            this.tabWifiSettings.Text = "WIFI SETTINGS";
            this.tabWifiSettings.UseVisualStyleBackColor = true;
            // 
            // ucPassive
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.tabPassive);
            this.Name = "ucPassive";
            this.Size = new System.Drawing.Size(958, 513);
            this.Load += new System.EventHandler(this.ucPassive_Load);
            this.tabPassive.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPassive;
        private System.Windows.Forms.TabPage tabBaseSettings;
        private System.Windows.Forms.TabPage tabSeniorSettings;
        private System.Windows.Forms.TabPage tabWriteISO;
        private System.Windows.Forms.TabPage tabWriteEPC;
        private System.Windows.Forms.TabPage tabReadDemo;
        private System.Windows.Forms.TabPage tabWifiSettings;
    }
}
