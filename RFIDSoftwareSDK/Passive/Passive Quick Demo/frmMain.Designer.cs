namespace ADSDKDemo
{
    partial class frmMain
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnect = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ltxtWriteLength6B = new System.Windows.Forms.TextBox();
            this.ltxtWriteAddress6B = new System.Windows.Forms.TextBox();
            this.utxtWriteData6B = new System.Windows.Forms.TextBox();
            this.btnWrite6B = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ltxtReadLength6B = new System.Windows.Forms.TextBox();
            this.ltxtReadAddress6B = new System.Windows.Forms.TextBox();
            this.utxtReadData6B = new System.Windows.Forms.TextBox();
            this.btnRead6B = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.utxtCard6B = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIdentify6B = new System.Windows.Forms.Button();
            this.grbWrite = new System.Windows.Forms.GroupBox();
            this.ltxtWriteLength = new System.Windows.Forms.TextBox();
            this.ltxtWriteAddress = new System.Windows.Forms.TextBox();
            this.utxtWriteData = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.cmbWriteBlock = new System.Windows.Forms.ComboBox();
            this.lblWriteBlock = new System.Windows.Forms.Label();
            this.lblWriteMark = new System.Windows.Forms.Label();
            this.lblWriteAddress = new System.Windows.Forms.Label();
            this.lblWriteLength = new System.Windows.Forms.Label();
            this.lblWriteData = new System.Windows.Forms.Label();
            this.grbRead = new System.Windows.Forms.GroupBox();
            this.ltxtReadLength = new System.Windows.Forms.TextBox();
            this.ltxtReadAddress = new System.Windows.Forms.TextBox();
            this.utxtReadData = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.cmbReadBlock = new System.Windows.Forms.ComboBox();
            this.lblReadBlock = new System.Windows.Forms.Label();
            this.lblReadMark = new System.Windows.Forms.Label();
            this.lblReadAddress = new System.Windows.Forms.Label();
            this.lblReadData = new System.Windows.Forms.Label();
            this.lblReadLength = new System.Windows.Forms.Label();
            this.grbIdentify = new System.Windows.Forms.GroupBox();
            this.utxtCard = new System.Windows.Forms.TextBox();
            this.lblCard = new System.Windows.Forms.Label();
            this.btnIdentify = new System.Windows.Forms.Button();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnGetConfig = new System.Windows.Forms.Button();
            this.btnInitPassive = new System.Windows.Forms.Button();
            this.btnInitActive = new System.Windows.Forms.Button();
            this.btnInformation = new System.Windows.Forms.Button();
            this.txtport = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlBody.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbWrite.SuspendLayout();
            this.grbRead.SuspendLayout();
            this.grbIdentify.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(560, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(95, 30);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.txtRes);
            this.pnlBody.Controls.Add(this.groupBox3);
            this.pnlBody.Controls.Add(this.groupBox2);
            this.pnlBody.Controls.Add(this.groupBox1);
            this.pnlBody.Controls.Add(this.grbWrite);
            this.pnlBody.Controls.Add(this.grbRead);
            this.pnlBody.Controls.Add(this.grbIdentify);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 72);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(770, 511);
            this.pnlBody.TabIndex = 2;
            // 
            // txtRes
            // 
            this.txtRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRes.Location = new System.Drawing.Point(0, 432);
            this.txtRes.Multiline = true;
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(770, 79);
            this.txtRes.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ltxtWriteLength6B);
            this.groupBox3.Controls.Add(this.ltxtWriteAddress6B);
            this.groupBox3.Controls.Add(this.utxtWriteData6B);
            this.groupBox3.Controls.Add(this.btnWrite6B);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 350);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(770, 82);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "6B Write";
            // 
            // ltxtWriteLength6B
            // 
            this.ltxtWriteLength6B.Location = new System.Drawing.Point(424, 18);
            this.ltxtWriteLength6B.Name = "ltxtWriteLength6B";
            this.ltxtWriteLength6B.Size = new System.Drawing.Size(100, 21);
            this.ltxtWriteLength6B.TabIndex = 13;
            this.ltxtWriteLength6B.Text = "12";
            // 
            // ltxtWriteAddress6B
            // 
            this.ltxtWriteAddress6B.Location = new System.Drawing.Point(253, 19);
            this.ltxtWriteAddress6B.Name = "ltxtWriteAddress6B";
            this.ltxtWriteAddress6B.Size = new System.Drawing.Size(100, 21);
            this.ltxtWriteAddress6B.TabIndex = 12;
            this.ltxtWriteAddress6B.Text = "18";
            // 
            // utxtWriteData6B
            // 
            this.utxtWriteData6B.Location = new System.Drawing.Point(100, 49);
            this.utxtWriteData6B.Name = "utxtWriteData6B";
            this.utxtWriteData6B.Size = new System.Drawing.Size(528, 21);
            this.utxtWriteData6B.TabIndex = 10;
            // 
            // btnWrite6B
            // 
            this.btnWrite6B.Location = new System.Drawing.Point(634, 45);
            this.btnWrite6B.Name = "btnWrite6B";
            this.btnWrite6B.Size = new System.Drawing.Size(120, 30);
            this.btnWrite6B.TabIndex = 4;
            this.btnWrite6B.TabStop = false;
            this.btnWrite6B.Text = "Writ&e";
            this.btnWrite6B.UseVisualStyleBackColor = true;
            this.btnWrite6B.Click += new System.EventHandler(this.btnWrite6B_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "Block:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(549, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "(Address start 2,Length not more 16)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(194, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "Address:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(371, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "Length:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 12);
            this.label11.TabIndex = 9;
            this.label11.Text = "Data:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ltxtReadLength6B);
            this.groupBox2.Controls.Add(this.ltxtReadAddress6B);
            this.groupBox2.Controls.Add(this.utxtReadData6B);
            this.groupBox2.Controls.Add(this.btnRead6B);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(770, 82);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "6B Read";
            // 
            // ltxtReadLength6B
            // 
            this.ltxtReadLength6B.Location = new System.Drawing.Point(424, 17);
            this.ltxtReadLength6B.Name = "ltxtReadLength6B";
            this.ltxtReadLength6B.Size = new System.Drawing.Size(100, 21);
            this.ltxtReadLength6B.TabIndex = 12;
            this.ltxtReadLength6B.Text = "12";
            // 
            // ltxtReadAddress6B
            // 
            this.ltxtReadAddress6B.Location = new System.Drawing.Point(250, 18);
            this.ltxtReadAddress6B.Name = "ltxtReadAddress6B";
            this.ltxtReadAddress6B.Size = new System.Drawing.Size(100, 21);
            this.ltxtReadAddress6B.TabIndex = 11;
            this.ltxtReadAddress6B.Text = "18";
            // 
            // utxtReadData6B
            // 
            this.utxtReadData6B.Location = new System.Drawing.Point(100, 49);
            this.utxtReadData6B.Name = "utxtReadData6B";
            this.utxtReadData6B.Size = new System.Drawing.Size(528, 21);
            this.utxtReadData6B.TabIndex = 10;
            // 
            // btnRead6B
            // 
            this.btnRead6B.Location = new System.Drawing.Point(634, 45);
            this.btnRead6B.Name = "btnRead6B";
            this.btnRead6B.Size = new System.Drawing.Size(120, 30);
            this.btnRead6B.TabIndex = 4;
            this.btnRead6B.TabStop = false;
            this.btnRead6B.Text = "&Read";
            this.btnRead6B.UseVisualStyleBackColor = true;
            this.btnRead6B.Click += new System.EventHandler(this.btnRead6B_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Block:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "(Length not more 16)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "Length:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.utxtCard6B);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnIdentify6B);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 52);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "6B Identify";
            // 
            // utxtCard6B
            // 
            this.utxtCard6B.Location = new System.Drawing.Point(100, 19);
            this.utxtCard6B.Name = "utxtCard6B";
            this.utxtCard6B.Size = new System.Drawing.Size(528, 21);
            this.utxtCard6B.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Card No:";
            // 
            // btnIdentify6B
            // 
            this.btnIdentify6B.Location = new System.Drawing.Point(634, 15);
            this.btnIdentify6B.Name = "btnIdentify6B";
            this.btnIdentify6B.Size = new System.Drawing.Size(120, 30);
            this.btnIdentify6B.TabIndex = 1;
            this.btnIdentify6B.TabStop = false;
            this.btnIdentify6B.Text = "&Identify";
            this.btnIdentify6B.UseVisualStyleBackColor = true;
            this.btnIdentify6B.Click += new System.EventHandler(this.btnIdentify6B_Click);
            // 
            // grbWrite
            // 
            this.grbWrite.Controls.Add(this.ltxtWriteLength);
            this.grbWrite.Controls.Add(this.ltxtWriteAddress);
            this.grbWrite.Controls.Add(this.utxtWriteData);
            this.grbWrite.Controls.Add(this.btnWrite);
            this.grbWrite.Controls.Add(this.cmbWriteBlock);
            this.grbWrite.Controls.Add(this.lblWriteBlock);
            this.grbWrite.Controls.Add(this.lblWriteMark);
            this.grbWrite.Controls.Add(this.lblWriteAddress);
            this.grbWrite.Controls.Add(this.lblWriteLength);
            this.grbWrite.Controls.Add(this.lblWriteData);
            this.grbWrite.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbWrite.Location = new System.Drawing.Point(0, 134);
            this.grbWrite.Name = "grbWrite";
            this.grbWrite.Size = new System.Drawing.Size(770, 82);
            this.grbWrite.TabIndex = 5;
            this.grbWrite.TabStop = false;
            this.grbWrite.Text = "EPC(GEN 2) Write";
            // 
            // ltxtWriteLength
            // 
            this.ltxtWriteLength.Location = new System.Drawing.Point(424, 18);
            this.ltxtWriteLength.Name = "ltxtWriteLength";
            this.ltxtWriteLength.Size = new System.Drawing.Size(100, 21);
            this.ltxtWriteLength.TabIndex = 13;
            this.ltxtWriteLength.Text = "12";
            // 
            // ltxtWriteAddress
            // 
            this.ltxtWriteAddress.Location = new System.Drawing.Point(253, 19);
            this.ltxtWriteAddress.Name = "ltxtWriteAddress";
            this.ltxtWriteAddress.Size = new System.Drawing.Size(100, 21);
            this.ltxtWriteAddress.TabIndex = 12;
            this.ltxtWriteAddress.Text = "02";
            // 
            // utxtWriteData
            // 
            this.utxtWriteData.Location = new System.Drawing.Point(100, 49);
            this.utxtWriteData.Name = "utxtWriteData";
            this.utxtWriteData.Size = new System.Drawing.Size(528, 21);
            this.utxtWriteData.TabIndex = 10;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(634, 45);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(120, 30);
            this.btnWrite.TabIndex = 4;
            this.btnWrite.TabStop = false;
            this.btnWrite.Text = "Writ&e";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // cmbWriteBlock
            // 
            this.cmbWriteBlock.FormattingEnabled = true;
            this.cmbWriteBlock.Items.AddRange(new object[] {
            "0-Reserved",
            "1-EPC",
            "2-TID",
            "3-User"});
            this.cmbWriteBlock.Location = new System.Drawing.Point(100, 18);
            this.cmbWriteBlock.Name = "cmbWriteBlock";
            this.cmbWriteBlock.Size = new System.Drawing.Size(86, 20);
            this.cmbWriteBlock.TabIndex = 0;
            this.cmbWriteBlock.TabStop = false;
            this.cmbWriteBlock.Text = "1-EPC";
            // 
            // lblWriteBlock
            // 
            this.lblWriteBlock.AutoSize = true;
            this.lblWriteBlock.Location = new System.Drawing.Point(12, 22);
            this.lblWriteBlock.Name = "lblWriteBlock";
            this.lblWriteBlock.Size = new System.Drawing.Size(41, 12);
            this.lblWriteBlock.TabIndex = 5;
            this.lblWriteBlock.Text = "Block:";
            // 
            // lblWriteMark
            // 
            this.lblWriteMark.AutoSize = true;
            this.lblWriteMark.Location = new System.Drawing.Point(549, 22);
            this.lblWriteMark.Name = "lblWriteMark";
            this.lblWriteMark.Size = new System.Drawing.Size(221, 12);
            this.lblWriteMark.TabIndex = 8;
            this.lblWriteMark.Text = "(Address start 2,Length not more 16)";
            // 
            // lblWriteAddress
            // 
            this.lblWriteAddress.AutoSize = true;
            this.lblWriteAddress.Location = new System.Drawing.Point(194, 22);
            this.lblWriteAddress.Name = "lblWriteAddress";
            this.lblWriteAddress.Size = new System.Drawing.Size(53, 12);
            this.lblWriteAddress.TabIndex = 6;
            this.lblWriteAddress.Text = "Address:";
            // 
            // lblWriteLength
            // 
            this.lblWriteLength.AutoSize = true;
            this.lblWriteLength.Location = new System.Drawing.Point(371, 22);
            this.lblWriteLength.Name = "lblWriteLength";
            this.lblWriteLength.Size = new System.Drawing.Size(47, 12);
            this.lblWriteLength.TabIndex = 7;
            this.lblWriteLength.Text = "Length:";
            // 
            // lblWriteData
            // 
            this.lblWriteData.AutoSize = true;
            this.lblWriteData.Location = new System.Drawing.Point(12, 52);
            this.lblWriteData.Name = "lblWriteData";
            this.lblWriteData.Size = new System.Drawing.Size(35, 12);
            this.lblWriteData.TabIndex = 9;
            this.lblWriteData.Text = "Data:";
            // 
            // grbRead
            // 
            this.grbRead.Controls.Add(this.ltxtReadLength);
            this.grbRead.Controls.Add(this.ltxtReadAddress);
            this.grbRead.Controls.Add(this.utxtReadData);
            this.grbRead.Controls.Add(this.btnRead);
            this.grbRead.Controls.Add(this.cmbReadBlock);
            this.grbRead.Controls.Add(this.lblReadBlock);
            this.grbRead.Controls.Add(this.lblReadMark);
            this.grbRead.Controls.Add(this.lblReadAddress);
            this.grbRead.Controls.Add(this.lblReadData);
            this.grbRead.Controls.Add(this.lblReadLength);
            this.grbRead.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbRead.Location = new System.Drawing.Point(0, 52);
            this.grbRead.Name = "grbRead";
            this.grbRead.Size = new System.Drawing.Size(770, 82);
            this.grbRead.TabIndex = 4;
            this.grbRead.TabStop = false;
            this.grbRead.Text = "EPC(GEN 2) Read";
            // 
            // ltxtReadLength
            // 
            this.ltxtReadLength.Location = new System.Drawing.Point(424, 17);
            this.ltxtReadLength.Name = "ltxtReadLength";
            this.ltxtReadLength.Size = new System.Drawing.Size(100, 21);
            this.ltxtReadLength.TabIndex = 12;
            this.ltxtReadLength.Text = "12";
            // 
            // ltxtReadAddress
            // 
            this.ltxtReadAddress.Location = new System.Drawing.Point(250, 18);
            this.ltxtReadAddress.Name = "ltxtReadAddress";
            this.ltxtReadAddress.Size = new System.Drawing.Size(100, 21);
            this.ltxtReadAddress.TabIndex = 11;
            this.ltxtReadAddress.Text = "02";
            // 
            // utxtReadData
            // 
            this.utxtReadData.Location = new System.Drawing.Point(100, 49);
            this.utxtReadData.Name = "utxtReadData";
            this.utxtReadData.Size = new System.Drawing.Size(528, 21);
            this.utxtReadData.TabIndex = 10;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(634, 45);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(120, 30);
            this.btnRead.TabIndex = 4;
            this.btnRead.TabStop = false;
            this.btnRead.Text = "&Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // cmbReadBlock
            // 
            this.cmbReadBlock.FormattingEnabled = true;
            this.cmbReadBlock.Items.AddRange(new object[] {
            "0-Reserved",
            "1-EPC",
            "2-TID",
            "3-User"});
            this.cmbReadBlock.Location = new System.Drawing.Point(100, 18);
            this.cmbReadBlock.Name = "cmbReadBlock";
            this.cmbReadBlock.Size = new System.Drawing.Size(86, 20);
            this.cmbReadBlock.TabIndex = 0;
            this.cmbReadBlock.TabStop = false;
            this.cmbReadBlock.Text = "1-EPC";
            // 
            // lblReadBlock
            // 
            this.lblReadBlock.AutoSize = true;
            this.lblReadBlock.Location = new System.Drawing.Point(12, 22);
            this.lblReadBlock.Name = "lblReadBlock";
            this.lblReadBlock.Size = new System.Drawing.Size(41, 12);
            this.lblReadBlock.TabIndex = 5;
            this.lblReadBlock.Text = "Block:";
            // 
            // lblReadMark
            // 
            this.lblReadMark.AutoSize = true;
            this.lblReadMark.Location = new System.Drawing.Point(549, 22);
            this.lblReadMark.Name = "lblReadMark";
            this.lblReadMark.Size = new System.Drawing.Size(125, 12);
            this.lblReadMark.TabIndex = 8;
            this.lblReadMark.Text = "(Length not more 16)";
            // 
            // lblReadAddress
            // 
            this.lblReadAddress.AutoSize = true;
            this.lblReadAddress.Location = new System.Drawing.Point(194, 22);
            this.lblReadAddress.Name = "lblReadAddress";
            this.lblReadAddress.Size = new System.Drawing.Size(53, 12);
            this.lblReadAddress.TabIndex = 6;
            this.lblReadAddress.Text = "Address:";
            // 
            // lblReadData
            // 
            this.lblReadData.AutoSize = true;
            this.lblReadData.Location = new System.Drawing.Point(12, 52);
            this.lblReadData.Name = "lblReadData";
            this.lblReadData.Size = new System.Drawing.Size(35, 12);
            this.lblReadData.TabIndex = 9;
            this.lblReadData.Text = "Data:";
            // 
            // lblReadLength
            // 
            this.lblReadLength.AutoSize = true;
            this.lblReadLength.Location = new System.Drawing.Point(371, 22);
            this.lblReadLength.Name = "lblReadLength";
            this.lblReadLength.Size = new System.Drawing.Size(47, 12);
            this.lblReadLength.TabIndex = 7;
            this.lblReadLength.Text = "Length:";
            // 
            // grbIdentify
            // 
            this.grbIdentify.Controls.Add(this.utxtCard);
            this.grbIdentify.Controls.Add(this.lblCard);
            this.grbIdentify.Controls.Add(this.btnIdentify);
            this.grbIdentify.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbIdentify.Location = new System.Drawing.Point(0, 0);
            this.grbIdentify.Name = "grbIdentify";
            this.grbIdentify.Size = new System.Drawing.Size(770, 52);
            this.grbIdentify.TabIndex = 3;
            this.grbIdentify.TabStop = false;
            this.grbIdentify.Text = "EPC(GEN 2) Identify";
            // 
            // utxtCard
            // 
            this.utxtCard.Location = new System.Drawing.Point(100, 19);
            this.utxtCard.Name = "utxtCard";
            this.utxtCard.Size = new System.Drawing.Size(528, 21);
            this.utxtCard.TabIndex = 3;
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.Location = new System.Drawing.Point(12, 22);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(53, 12);
            this.lblCard.TabIndex = 2;
            this.lblCard.Text = "Card No:";
            // 
            // btnIdentify
            // 
            this.btnIdentify.Location = new System.Drawing.Point(634, 15);
            this.btnIdentify.Name = "btnIdentify";
            this.btnIdentify.Size = new System.Drawing.Size(120, 30);
            this.btnIdentify.TabIndex = 1;
            this.btnIdentify.TabStop = false;
            this.btnIdentify.Text = "&Identify";
            this.btnIdentify.UseVisualStyleBackColor = true;
            this.btnIdentify.Click += new System.EventHandler(this.btnIdentify_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.AutoSize = true;
            this.pnlTitle.Controls.Add(this.btnGetConfig);
            this.pnlTitle.Controls.Add(this.btnInitPassive);
            this.pnlTitle.Controls.Add(this.btnInitActive);
            this.pnlTitle.Controls.Add(this.btnInformation);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 36);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(770, 36);
            this.pnlTitle.TabIndex = 3;
            // 
            // btnGetConfig
            // 
            this.btnGetConfig.Location = new System.Drawing.Point(661, 3);
            this.btnGetConfig.Name = "btnGetConfig";
            this.btnGetConfig.Size = new System.Drawing.Size(95, 30);
            this.btnGetConfig.TabIndex = 6;
            this.btnGetConfig.TabStop = false;
            this.btnGetConfig.Text = "GetConfig";
            this.btnGetConfig.UseVisualStyleBackColor = true;
            this.btnGetConfig.Click += new System.EventHandler(this.btnGetConfig_Click);
            // 
            // btnInitPassive
            // 
            this.btnInitPassive.Location = new System.Drawing.Point(560, 3);
            this.btnInitPassive.Name = "btnInitPassive";
            this.btnInitPassive.Size = new System.Drawing.Size(95, 30);
            this.btnInitPassive.TabIndex = 5;
            this.btnInitPassive.TabStop = false;
            this.btnInitPassive.Text = "Init Passive";
            this.btnInitPassive.UseVisualStyleBackColor = true;
            this.btnInitPassive.Click += new System.EventHandler(this.btnInitPassive_Click);
            // 
            // btnInitActive
            // 
            this.btnInitActive.Location = new System.Drawing.Point(459, 3);
            this.btnInitActive.Name = "btnInitActive";
            this.btnInitActive.Size = new System.Drawing.Size(95, 30);
            this.btnInitActive.TabIndex = 4;
            this.btnInitActive.TabStop = false;
            this.btnInitActive.Text = "Init Active";
            this.btnInitActive.UseVisualStyleBackColor = true;
            this.btnInitActive.Click += new System.EventHandler(this.btnInitActive_Click);
            // 
            // btnInformation
            // 
            this.btnInformation.Location = new System.Drawing.Point(358, 3);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(95, 30);
            this.btnInformation.TabIndex = 3;
            this.btnInformation.TabStop = false;
            this.btnInformation.Text = "Information";
            this.btnInformation.UseVisualStyleBackColor = true;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // txtport
            // 
            this.txtport.Location = new System.Drawing.Point(431, 9);
            this.txtport.Name = "txtport";
            this.txtport.Size = new System.Drawing.Size(74, 21);
            this.txtport.TabIndex = 2;
            this.txtport.Text = "9600";
            this.txtport.TextChanged += new System.EventHandler(this.txtport_TextChanged);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(155, 9);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(139, 21);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "COM1";
            this.txtIP.TextChanged += new System.EventHandler(this.txtIP_TextChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.txtIP);
            this.panel1.Controls.Add(this.txtport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 36);
            this.panel1.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(300, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 12);
            this.label12.TabIndex = 5;
            this.label12.Text = "IP Port or Baudrate:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 12);
            this.label13.TabIndex = 4;
            this.label13.Text = "IP Address or Comport:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 583);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passive Quick Demo";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbWrite.ResumeLayout(false);
            this.grbWrite.PerformLayout();
            this.grbRead.ResumeLayout(false);
            this.grbRead.PerformLayout();
            this.grbIdentify.ResumeLayout(false);
            this.grbIdentify.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.GroupBox grbWrite;
        private System.Windows.Forms.TextBox utxtWriteData;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.ComboBox cmbWriteBlock;
        private System.Windows.Forms.Label lblWriteBlock;
        private System.Windows.Forms.Label lblWriteMark;
        private System.Windows.Forms.Label lblWriteAddress;
        private System.Windows.Forms.Label lblWriteLength;
        private System.Windows.Forms.Label lblWriteData;
        private System.Windows.Forms.GroupBox grbRead;
        private System.Windows.Forms.TextBox utxtReadData;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.ComboBox cmbReadBlock;
        private System.Windows.Forms.Label lblReadBlock;
        private System.Windows.Forms.Label lblReadMark;
        private System.Windows.Forms.Label lblReadAddress;
        private System.Windows.Forms.Label lblReadData;
        private System.Windows.Forms.Label lblReadLength;
        private System.Windows.Forms.GroupBox grbIdentify;
        private System.Windows.Forms.TextBox utxtCard;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.Button btnIdentify;
        private System.Windows.Forms.TextBox ltxtWriteLength;
        private System.Windows.Forms.TextBox ltxtWriteAddress;
        private System.Windows.Forms.TextBox ltxtReadLength;
        private System.Windows.Forms.TextBox ltxtReadAddress;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtport;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox ltxtWriteLength6B;
        private System.Windows.Forms.TextBox ltxtWriteAddress6B;
        private System.Windows.Forms.TextBox utxtWriteData6B;
        private System.Windows.Forms.Button btnWrite6B;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ltxtReadLength6B;
        private System.Windows.Forms.TextBox ltxtReadAddress6B;
        private System.Windows.Forms.TextBox utxtReadData6B;
        private System.Windows.Forms.Button btnRead6B;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox utxtCard6B;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIdentify6B;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Button btnInitActive;
        private System.Windows.Forms.Button btnInformation;
        private System.Windows.Forms.Button btnInitPassive;
        private System.Windows.Forms.Button btnGetConfig;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

