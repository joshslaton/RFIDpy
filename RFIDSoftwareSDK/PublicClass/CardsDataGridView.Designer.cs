namespace ADSDK.Device.Reader
{
    partial class CardsDataGridView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDecCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHexByteSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHexCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.pnlMaxCard = new System.Windows.Forms.Panel();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.pnlDistinguish = new System.Windows.Forms.Panel();
            this.chkDivCard = new System.Windows.Forms.CheckBox();
            this.cmbStartPoint = new System.Windows.Forms.ComboBox();
            this.chkIsFour = new System.Windows.Forms.CheckBox();
            this.chkDivAlarm = new System.Windows.Forms.CheckBox();
            this.chkDivAddr = new System.Windows.Forms.CheckBox();
            this.chkDivAnt = new System.Windows.Forms.CheckBox();
            this.pnlCount = new System.Windows.Forms.Panel();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.pnlReadCount = new System.Windows.Forms.Panel();
            this.cmbReadCount = new System.Windows.Forms.ComboBox();
            this.lblReadCount = new System.Windows.Forms.Label();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.ttpAttention = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.pnlInfo.SuspendLayout();
            this.pnlMaxCard.SuspendLayout();
            this.pnlDistinguish.SuspendLayout();
            this.pnlCount.SuspendLayout();
            this.pnlReadCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvShow
            // 
            this.dgvShow.AllowUserToAddRows = false;
            this.dgvShow.AllowUserToDeleteRows = false;
            this.dgvShow.AllowUserToResizeColumns = false;
            this.dgvShow.AllowUserToResizeRows = false;
            this.dgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvShow.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvShow.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colAnt,
            this.colAddress,
            this.colDecCard,
            this.colHexByteSum,
            this.colHexCard,
            this.colTime,
            this.colCount});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShow.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShow.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvShow.Location = new System.Drawing.Point(0, 32);
            this.dgvShow.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.dgvShow.MultiSelect = false;
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.ReadOnly = true;
            this.dgvShow.RowHeadersVisible = false;
            this.dgvShow.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvShow.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShow.RowTemplate.Height = 23;
            this.dgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvShow.Size = new System.Drawing.Size(780, 648);
            this.dgvShow.TabIndex = 25;
            this.dgvShow.TabStop = false;
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colID.FillWeight = 120F;
            this.colID.HeaderText = "No.";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 48;
            // 
            // colAnt
            // 
            this.colAnt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colAnt.HeaderText = "Ant";
            this.colAnt.Name = "colAnt";
            this.colAnt.ReadOnly = true;
            this.colAnt.Width = 48;
            // 
            // colAddress
            // 
            this.colAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colAddress.HeaderText = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            this.colAddress.Width = 72;
            // 
            // colDecCard
            // 
            this.colDecCard.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colDecCard.HeaderText = "Hex/Dec/WG";
            this.colDecCard.Name = "colDecCard";
            this.colDecCard.ReadOnly = true;
            this.colDecCard.Width = 90;
            // 
            // colHexByteSum
            // 
            this.colHexByteSum.HeaderText = "Hex Length";
            this.colHexByteSum.Name = "colHexByteSum";
            this.colHexByteSum.ReadOnly = true;
            this.colHexByteSum.Width = 90;
            // 
            // colHexCard
            // 
            this.colHexCard.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colHexCard.FillWeight = 200F;
            this.colHexCard.HeaderText = "Hex Card";
            this.colHexCard.MinimumWidth = 200;
            this.colHexCard.Name = "colHexCard";
            this.colHexCard.ReadOnly = true;
            // 
            // colTime
            // 
            this.colTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colTime.HeaderText = "Last Time";
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            this.colTime.Width = 84;
            // 
            // colCount
            // 
            this.colCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colCount.HeaderText = "Count";
            this.colCount.Name = "colCount";
            this.colCount.ReadOnly = true;
            this.colCount.Width = 60;
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.pnlMaxCard);
            this.pnlInfo.Controls.Add(this.pnlDistinguish);
            this.pnlInfo.Controls.Add(this.pnlCount);
            this.pnlInfo.Controls.Add(this.pnlReadCount);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(780, 32);
            this.pnlInfo.TabIndex = 93;
            // 
            // pnlMaxCard
            // 
            this.pnlMaxCard.AutoSize = true;
            this.pnlMaxCard.Controls.Add(this.txtCount);
            this.pnlMaxCard.Controls.Add(this.lblCount);
            this.pnlMaxCard.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMaxCard.Location = new System.Drawing.Point(548, 0);
            this.pnlMaxCard.Name = "pnlMaxCard";
            this.pnlMaxCard.Padding = new System.Windows.Forms.Padding(3);
            this.pnlMaxCard.Size = new System.Drawing.Size(116, 32);
            this.pnlMaxCard.TabIndex = 87;
            // 
            // txtCount
            // 
            this.txtCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtCount.Location = new System.Drawing.Point(63, 3);
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(50, 21);
            this.txtCount.TabIndex = 89;
            this.txtCount.TabStop = false;
            this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCount.MouseEnter += new System.EventHandler(this.txtCount_MouseEnter);
            this.txtCount.MouseLeave += new System.EventHandler(this.AttentionMouseLeave);
            // 
            // lblCount
            // 
            this.lblCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCount.Location = new System.Drawing.Point(3, 3);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(60, 26);
            this.lblCount.TabIndex = 88;
            this.lblCount.Text = "Count:";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlDistinguish
            // 
            this.pnlDistinguish.AutoSize = true;
            this.pnlDistinguish.Controls.Add(this.chkDivCard);
            this.pnlDistinguish.Controls.Add(this.cmbStartPoint);
            this.pnlDistinguish.Controls.Add(this.chkIsFour);
            this.pnlDistinguish.Controls.Add(this.chkDivAlarm);
            this.pnlDistinguish.Controls.Add(this.chkDivAddr);
            this.pnlDistinguish.Controls.Add(this.chkDivAnt);
            this.pnlDistinguish.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDistinguish.Location = new System.Drawing.Point(126, 0);
            this.pnlDistinguish.Name = "pnlDistinguish";
            this.pnlDistinguish.Padding = new System.Windows.Forms.Padding(3);
            this.pnlDistinguish.Size = new System.Drawing.Size(382, 32);
            this.pnlDistinguish.TabIndex = 86;
            // 
            // chkDivCard
            // 
            this.chkDivCard.AutoSize = true;
            this.chkDivCard.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkDivCard.Location = new System.Drawing.Point(343, 3);
            this.chkDivCard.Name = "chkDivCard";
            this.chkDivCard.Size = new System.Drawing.Size(36, 26);
            this.chkDivCard.TabIndex = 91;
            this.chkDivCard.TabStop = false;
            this.chkDivCard.Text = "DC";
            this.chkDivCard.UseVisualStyleBackColor = true;
            this.chkDivCard.Visible = false;
            this.chkDivCard.MouseEnter += new System.EventHandler(this.chkDivCard_MouseEnter);
            this.chkDivCard.MouseLeave += new System.EventHandler(this.AttentionMouseLeave);
            // 
            // cmbStartPoint
            // 
            this.cmbStartPoint.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmbStartPoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartPoint.FormattingEnabled = true;
            this.cmbStartPoint.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbStartPoint.Location = new System.Drawing.Point(297, 3);
            this.cmbStartPoint.Name = "cmbStartPoint";
            this.cmbStartPoint.Size = new System.Drawing.Size(46, 20);
            this.cmbStartPoint.TabIndex = 88;
            this.cmbStartPoint.SelectionChangeCommitted += new System.EventHandler(this.cmbStartPoint_SelectionChangeCommitted);
            this.cmbStartPoint.MouseEnter += new System.EventHandler(this.cmbStartPoint_MouseEnter);
            this.cmbStartPoint.MouseLeave += new System.EventHandler(this.AttentionMouseLeave);
            // 
            // chkIsFour
            // 
            this.chkIsFour.AutoSize = true;
            this.chkIsFour.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkIsFour.Location = new System.Drawing.Point(237, 3);
            this.chkIsFour.Name = "chkIsFour";
            this.chkIsFour.Size = new System.Drawing.Size(60, 26);
            this.chkIsFour.TabIndex = 90;
            this.chkIsFour.TabStop = false;
            this.chkIsFour.Text = "4 Byte";
            this.chkIsFour.UseVisualStyleBackColor = true;
            this.chkIsFour.CheckedChanged += new System.EventHandler(this.chkIsFour_CheckedChanged);
            this.chkIsFour.MouseEnter += new System.EventHandler(this.chkIsFour_MouseEnter);
            this.chkIsFour.MouseLeave += new System.EventHandler(this.AttentionMouseLeave);
            // 
            // chkDivAlarm
            // 
            this.chkDivAlarm.AutoSize = true;
            this.chkDivAlarm.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkDivAlarm.Location = new System.Drawing.Point(159, 3);
            this.chkDivAlarm.Name = "chkDivAlarm";
            this.chkDivAlarm.Size = new System.Drawing.Size(78, 26);
            this.chkDivAlarm.TabIndex = 89;
            this.chkDivAlarm.TabStop = false;
            this.chkDivAlarm.Text = "Div Alarm";
            this.chkDivAlarm.UseVisualStyleBackColor = true;
            this.chkDivAlarm.MouseEnter += new System.EventHandler(this.chkDivAlarm_MouseEnter);
            this.chkDivAlarm.MouseLeave += new System.EventHandler(this.AttentionMouseLeave);
            // 
            // chkDivAddr
            // 
            this.chkDivAddr.AutoSize = true;
            this.chkDivAddr.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkDivAddr.Location = new System.Drawing.Point(69, 3);
            this.chkDivAddr.Name = "chkDivAddr";
            this.chkDivAddr.Size = new System.Drawing.Size(90, 26);
            this.chkDivAddr.TabIndex = 87;
            this.chkDivAddr.TabStop = false;
            this.chkDivAddr.Text = "Div Address";
            this.chkDivAddr.UseVisualStyleBackColor = true;
            this.chkDivAddr.MouseEnter += new System.EventHandler(this.chkDivAddr_MouseEnter);
            this.chkDivAddr.MouseLeave += new System.EventHandler(this.AttentionMouseLeave);
            // 
            // chkDivAnt
            // 
            this.chkDivAnt.AutoSize = true;
            this.chkDivAnt.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkDivAnt.Location = new System.Drawing.Point(3, 3);
            this.chkDivAnt.Name = "chkDivAnt";
            this.chkDivAnt.Size = new System.Drawing.Size(66, 26);
            this.chkDivAnt.TabIndex = 86;
            this.chkDivAnt.TabStop = false;
            this.chkDivAnt.Text = "Div Ant";
            this.chkDivAnt.UseVisualStyleBackColor = true;
            this.chkDivAnt.MouseEnter += new System.EventHandler(this.chkDivAnt_MouseEnter);
            this.chkDivAnt.MouseLeave += new System.EventHandler(this.AttentionMouseLeave);
            // 
            // pnlCount
            // 
            this.pnlCount.AutoSize = true;
            this.pnlCount.Controls.Add(this.txtSum);
            this.pnlCount.Controls.Add(this.lblSum);
            this.pnlCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCount.Location = new System.Drawing.Point(664, 0);
            this.pnlCount.Name = "pnlCount";
            this.pnlCount.Padding = new System.Windows.Forms.Padding(3);
            this.pnlCount.Size = new System.Drawing.Size(116, 32);
            this.pnlCount.TabIndex = 85;
            // 
            // txtSum
            // 
            this.txtSum.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSum.Location = new System.Drawing.Point(63, 3);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(50, 21);
            this.txtSum.TabIndex = 89;
            this.txtSum.TabStop = false;
            this.txtSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSum.MouseEnter += new System.EventHandler(this.txtSum_MouseEnter);
            this.txtSum.MouseLeave += new System.EventHandler(this.AttentionMouseLeave);
            // 
            // lblSum
            // 
            this.lblSum.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSum.Location = new System.Drawing.Point(3, 3);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(60, 26);
            this.lblSum.TabIndex = 88;
            this.lblSum.Text = "Sum:";
            this.lblSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlReadCount
            // 
            this.pnlReadCount.AutoSize = true;
            this.pnlReadCount.Controls.Add(this.cmbReadCount);
            this.pnlReadCount.Controls.Add(this.lblReadCount);
            this.pnlReadCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlReadCount.Enabled = false;
            this.pnlReadCount.Location = new System.Drawing.Point(0, 0);
            this.pnlReadCount.Name = "pnlReadCount";
            this.pnlReadCount.Padding = new System.Windows.Forms.Padding(3);
            this.pnlReadCount.Size = new System.Drawing.Size(126, 32);
            this.pnlReadCount.TabIndex = 84;
            this.pnlReadCount.Visible = false;
            // 
            // cmbReadCount
            // 
            this.cmbReadCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmbReadCount.FormattingEnabled = true;
            this.cmbReadCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.cmbReadCount.Location = new System.Drawing.Point(83, 3);
            this.cmbReadCount.Name = "cmbReadCount";
            this.cmbReadCount.Size = new System.Drawing.Size(40, 20);
            this.cmbReadCount.TabIndex = 88;
            this.cmbReadCount.Text = "5";
            this.cmbReadCount.MouseEnter += new System.EventHandler(this.cmbReadCount_MouseEnter);
            this.cmbReadCount.MouseLeave += new System.EventHandler(this.AttentionMouseLeave);
            // 
            // lblReadCount
            // 
            this.lblReadCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblReadCount.Location = new System.Drawing.Point(3, 3);
            this.lblReadCount.Name = "lblReadCount";
            this.lblReadCount.Size = new System.Drawing.Size(80, 26);
            this.lblReadCount.TabIndex = 87;
            this.lblReadCount.Text = "ReadCount:";
            this.lblReadCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmrClock
            // 
            this.tmrClock.Enabled = true;
            this.tmrClock.Interval = 300;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // ttpAttention
            // 
            this.ttpAttention.AutomaticDelay = 0;
            this.ttpAttention.AutoPopDelay = 3000;
            this.ttpAttention.InitialDelay = 300;
            this.ttpAttention.ReshowDelay = 0;
            this.ttpAttention.UseFading = false;
            // 
            // CardsDataGridView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.pnlInfo);
            this.Name = "CardsDataGridView";
            this.Size = new System.Drawing.Size(780, 680);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlMaxCard.ResumeLayout(false);
            this.pnlMaxCard.PerformLayout();
            this.pnlDistinguish.ResumeLayout(false);
            this.pnlDistinguish.PerformLayout();
            this.pnlCount.ResumeLayout(false);
            this.pnlCount.PerformLayout();
            this.pnlReadCount.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Panel pnlMaxCard;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Panel pnlDistinguish;
        private System.Windows.Forms.CheckBox chkDivAnt;
        private System.Windows.Forms.Panel pnlCount;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Panel pnlReadCount;
        private System.Windows.Forms.Label lblReadCount;
        private System.Windows.Forms.CheckBox chkDivAddr;
        private System.Windows.Forms.ComboBox cmbReadCount;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.CheckBox chkDivAlarm;
        private System.Windows.Forms.CheckBox chkIsFour;
        private System.Windows.Forms.ComboBox cmbStartPoint;
        private System.Windows.Forms.CheckBox chkDivCard;
        private System.Windows.Forms.ToolTip ttpAttention;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDecCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHexByteSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHexCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCount;
    }
}
