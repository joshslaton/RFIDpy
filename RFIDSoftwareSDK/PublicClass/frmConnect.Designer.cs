namespace ADSDKDemo
{
    partial class frmConnect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlComm = new System.Windows.Forms.Panel();
            this.grbUsb = new System.Windows.Forms.GroupBox();
            this.lblUsbAttention = new System.Windows.Forms.Label();
            this.chkAutoConnect = new System.Windows.Forms.CheckBox();
            this.grbNet = new System.Windows.Forms.GroupBox();
            this.btnPing = new System.Windows.Forms.Button();
            this.txtRemotePort = new System.Windows.Forms.TextBox();
            this.txtRemoteIP = new System.Windows.Forms.TextBox();
            this.lblRemotePort = new System.Windows.Forms.Label();
            this.lblRemoteIP = new System.Windows.Forms.Label();
            this.grbSerial = new System.Windows.Forms.GroupBox();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.lblPortName = new System.Windows.Forms.Label();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.grbComm = new System.Windows.Forms.GroupBox();
            this.rdbUsb = new System.Windows.Forms.RadioButton();
            this.rdbSerial = new System.Windows.Forms.RadioButton();
            this.rdbNet = new System.Windows.Forms.RadioButton();
            this.btnConnected = new System.Windows.Forms.Button();
            this.btnDisConnect = new System.Windows.Forms.Button();
            this.pnlConnect = new System.Windows.Forms.Panel();
            this.rtxtRes = new System.Windows.Forms.RichTextBox();
            this.pnlComm.SuspendLayout();
            this.grbUsb.SuspendLayout();
            this.grbNet.SuspendLayout();
            this.grbSerial.SuspendLayout();
            this.grbComm.SuspendLayout();
            this.pnlConnect.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlComm
            // 
            this.pnlComm.AutoSize = true;
            this.pnlComm.Controls.Add(this.grbUsb);
            this.pnlComm.Controls.Add(this.grbNet);
            this.pnlComm.Controls.Add(this.grbSerial);
            this.pnlComm.Controls.Add(this.grbComm);
            this.pnlComm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlComm.Location = new System.Drawing.Point(3, 3);
            this.pnlComm.Name = "pnlComm";
            this.pnlComm.Padding = new System.Windows.Forms.Padding(3);
            this.pnlComm.Size = new System.Drawing.Size(678, 248);
            this.pnlComm.TabIndex = 8;
            // 
            // grbUsb
            // 
            this.grbUsb.AutoSize = true;
            this.grbUsb.Controls.Add(this.lblUsbAttention);
            this.grbUsb.Controls.Add(this.chkAutoConnect);
            this.grbUsb.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbUsb.Location = new System.Drawing.Point(3, 159);
            this.grbUsb.Name = "grbUsb";
            this.grbUsb.Size = new System.Drawing.Size(672, 86);
            this.grbUsb.TabIndex = 3;
            this.grbUsb.TabStop = false;
            this.grbUsb.Text = "USB";
            // 
            // lblUsbAttention
            // 
            this.lblUsbAttention.AutoSize = true;
            this.lblUsbAttention.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUsbAttention.ForeColor = System.Drawing.Color.Red;
            this.lblUsbAttention.Location = new System.Drawing.Point(11, 50);
            this.lblUsbAttention.Name = "lblUsbAttention";
            this.lblUsbAttention.Size = new System.Drawing.Size(562, 17);
            this.lblUsbAttention.TabIndex = 6;
            this.lblUsbAttention.Text = "Note : Please re plug USB devices, and repeat click connect, until a successful c" +
    "onnection!!";
            // 
            // chkAutoConnect
            // 
            this.chkAutoConnect.AutoSize = true;
            this.chkAutoConnect.Enabled = false;
            this.chkAutoConnect.Location = new System.Drawing.Point(14, 22);
            this.chkAutoConnect.Name = "chkAutoConnect";
            this.chkAutoConnect.Size = new System.Drawing.Size(105, 21);
            this.chkAutoConnect.TabIndex = 5;
            this.chkAutoConnect.TabStop = false;
            this.chkAutoConnect.Text = "Auto Connect";
            this.chkAutoConnect.UseVisualStyleBackColor = true;
            // 
            // grbNet
            // 
            this.grbNet.Controls.Add(this.btnPing);
            this.grbNet.Controls.Add(this.txtRemotePort);
            this.grbNet.Controls.Add(this.txtRemoteIP);
            this.grbNet.Controls.Add(this.lblRemotePort);
            this.grbNet.Controls.Add(this.lblRemoteIP);
            this.grbNet.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbNet.Location = new System.Drawing.Point(3, 107);
            this.grbNet.Name = "grbNet";
            this.grbNet.Size = new System.Drawing.Size(672, 52);
            this.grbNet.TabIndex = 2;
            this.grbNet.TabStop = false;
            this.grbNet.Text = "Net(TCPIP)";
            // 
            // btnPing
            // 
            this.btnPing.AutoSize = true;
            this.btnPing.Location = new System.Drawing.Point(441, 17);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(100, 27);
            this.btnPing.TabIndex = 4;
            this.btnPing.TabStop = false;
            this.btnPing.Text = "Ping";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // txtRemotePort
            // 
            this.txtRemotePort.Location = new System.Drawing.Point(355, 19);
            this.txtRemotePort.MaxLength = 5;
            this.txtRemotePort.Name = "txtRemotePort";
            this.txtRemotePort.Size = new System.Drawing.Size(80, 23);
            this.txtRemotePort.TabIndex = 1;
            this.txtRemotePort.TabStop = false;
            this.txtRemotePort.Text = "49152";
            this.txtRemotePort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRemoteIP
            // 
            this.txtRemoteIP.Location = new System.Drawing.Point(132, 19);
            this.txtRemoteIP.MaxLength = 18;
            this.txtRemoteIP.Name = "txtRemoteIP";
            this.txtRemoteIP.Size = new System.Drawing.Size(110, 23);
            this.txtRemoteIP.TabIndex = 0;
            this.txtRemoteIP.TabStop = false;
            this.txtRemoteIP.Text = "192.168.1.115";
            this.txtRemoteIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRemotePort
            // 
            this.lblRemotePort.AutoSize = true;
            this.lblRemotePort.Location = new System.Drawing.Point(248, 22);
            this.lblRemotePort.Name = "lblRemotePort";
            this.lblRemotePort.Size = new System.Drawing.Size(81, 17);
            this.lblRemotePort.TabIndex = 3;
            this.lblRemotePort.Text = "Remote Port";
            // 
            // lblRemoteIP
            // 
            this.lblRemoteIP.AutoSize = true;
            this.lblRemoteIP.Location = new System.Drawing.Point(11, 22);
            this.lblRemoteIP.Name = "lblRemoteIP";
            this.lblRemoteIP.Size = new System.Drawing.Size(68, 17);
            this.lblRemoteIP.TabIndex = 2;
            this.lblRemoteIP.Text = "Remote IP";
            // 
            // grbSerial
            // 
            this.grbSerial.Controls.Add(this.lblBaudRate);
            this.grbSerial.Controls.Add(this.lblPortName);
            this.grbSerial.Controls.Add(this.cmbBaudRate);
            this.grbSerial.Controls.Add(this.cmbPortName);
            this.grbSerial.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbSerial.Location = new System.Drawing.Point(3, 55);
            this.grbSerial.Name = "grbSerial";
            this.grbSerial.Size = new System.Drawing.Size(672, 52);
            this.grbSerial.TabIndex = 1;
            this.grbSerial.TabStop = false;
            this.grbSerial.Text = "SerialPort";
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(248, 21);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(64, 17);
            this.lblBaudRate.TabIndex = 1;
            this.lblBaudRate.Text = "BaudRate";
            // 
            // lblPortName
            // 
            this.lblPortName.AutoSize = true;
            this.lblPortName.Location = new System.Drawing.Point(11, 22);
            this.lblPortName.Name = "lblPortName";
            this.lblPortName.Size = new System.Drawing.Size(67, 17);
            this.lblPortName.TabIndex = 0;
            this.lblPortName.Text = "PortName";
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Items.AddRange(new object[] {
            "9600",
            "38400",
            "57600",
            "115200"});
            this.cmbBaudRate.Location = new System.Drawing.Point(355, 18);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(80, 25);
            this.cmbBaudRate.TabIndex = 4;
            this.cmbBaudRate.TabStop = false;
            // 
            // cmbPortName
            // 
            this.cmbPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.Location = new System.Drawing.Point(132, 18);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(110, 25);
            this.cmbPortName.TabIndex = 3;
            this.cmbPortName.TabStop = false;
            // 
            // grbComm
            // 
            this.grbComm.Controls.Add(this.rdbUsb);
            this.grbComm.Controls.Add(this.rdbSerial);
            this.grbComm.Controls.Add(this.rdbNet);
            this.grbComm.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbComm.Location = new System.Drawing.Point(3, 3);
            this.grbComm.Name = "grbComm";
            this.grbComm.Size = new System.Drawing.Size(672, 52);
            this.grbComm.TabIndex = 0;
            this.grbComm.TabStop = false;
            this.grbComm.Text = "Comm.(通信)";
            // 
            // rdbUsb
            // 
            this.rdbUsb.AutoSize = true;
            this.rdbUsb.Location = new System.Drawing.Point(351, 22);
            this.rdbUsb.Name = "rdbUsb";
            this.rdbUsb.Size = new System.Drawing.Size(104, 21);
            this.rdbUsb.TabIndex = 2;
            this.rdbUsb.Text = "Usb Interface";
            this.rdbUsb.UseVisualStyleBackColor = true;
            this.rdbUsb.CheckedChanged += new System.EventHandler(this.rdbCheckedChanged);
            // 
            // rdbSerial
            // 
            this.rdbSerial.AutoSize = true;
            this.rdbSerial.Location = new System.Drawing.Point(11, 22);
            this.rdbSerial.Name = "rdbSerial";
            this.rdbSerial.Size = new System.Drawing.Size(113, 21);
            this.rdbSerial.TabIndex = 0;
            this.rdbSerial.Text = "Serial Interface";
            this.rdbSerial.UseVisualStyleBackColor = true;
            this.rdbSerial.CheckedChanged += new System.EventHandler(this.rdbCheckedChanged);
            // 
            // rdbNet
            // 
            this.rdbNet.AutoSize = true;
            this.rdbNet.Location = new System.Drawing.Point(186, 22);
            this.rdbNet.Name = "rdbNet";
            this.rdbNet.Size = new System.Drawing.Size(102, 21);
            this.rdbNet.TabIndex = 1;
            this.rdbNet.Text = "Net Interface";
            this.rdbNet.UseVisualStyleBackColor = true;
            this.rdbNet.CheckedChanged += new System.EventHandler(this.rdbCheckedChanged);
            // 
            // btnConnected
            // 
            this.btnConnected.Location = new System.Drawing.Point(156, 6);
            this.btnConnected.Name = "btnConnected";
            this.btnConnected.Size = new System.Drawing.Size(100, 32);
            this.btnConnected.TabIndex = 9;
            this.btnConnected.Text = "CONNECT";
            this.btnConnected.UseVisualStyleBackColor = true;
            this.btnConnected.Click += new System.EventHandler(this.btnConnected_Click);
            // 
            // btnDisConnect
            // 
            this.btnDisConnect.Enabled = false;
            this.btnDisConnect.Location = new System.Drawing.Point(378, 6);
            this.btnDisConnect.Name = "btnDisConnect";
            this.btnDisConnect.Size = new System.Drawing.Size(100, 32);
            this.btnDisConnect.TabIndex = 10;
            this.btnDisConnect.Text = "DISCONNECT";
            this.btnDisConnect.UseVisualStyleBackColor = true;
            this.btnDisConnect.Click += new System.EventHandler(this.btnDisConnect_Click);
            // 
            // pnlConnect
            // 
            this.pnlConnect.Controls.Add(this.btnDisConnect);
            this.pnlConnect.Controls.Add(this.btnConnected);
            this.pnlConnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConnect.Location = new System.Drawing.Point(3, 251);
            this.pnlConnect.Name = "pnlConnect";
            this.pnlConnect.Size = new System.Drawing.Size(678, 44);
            this.pnlConnect.TabIndex = 12;
            // 
            // rtxtRes
            // 
            this.rtxtRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtRes.Location = new System.Drawing.Point(3, 295);
            this.rtxtRes.Name = "rtxtRes";
            this.rtxtRes.Size = new System.Drawing.Size(678, 138);
            this.rtxtRes.TabIndex = 13;
            this.rtxtRes.Text = "";
            // 
            // frmConnect
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(684, 436);
            this.Controls.Add(this.rtxtRes);
            this.Controls.Add(this.pnlConnect);
            this.Controls.Add(this.pnlComm);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConnect";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select the device connection mode";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConnect_FormClosing);
            this.Load += new System.EventHandler(this.frmConnect_Load);
            this.pnlComm.ResumeLayout(false);
            this.pnlComm.PerformLayout();
            this.grbUsb.ResumeLayout(false);
            this.grbUsb.PerformLayout();
            this.grbNet.ResumeLayout(false);
            this.grbNet.PerformLayout();
            this.grbSerial.ResumeLayout(false);
            this.grbSerial.PerformLayout();
            this.grbComm.ResumeLayout(false);
            this.grbComm.PerformLayout();
            this.pnlConnect.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlComm;
        private System.Windows.Forms.GroupBox grbUsb;
        private System.Windows.Forms.Label lblUsbAttention;
        private System.Windows.Forms.CheckBox chkAutoConnect;
        private System.Windows.Forms.GroupBox grbNet;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.TextBox txtRemotePort;
        private System.Windows.Forms.TextBox txtRemoteIP;
        private System.Windows.Forms.Label lblRemotePort;
        private System.Windows.Forms.Label lblRemoteIP;
        private System.Windows.Forms.GroupBox grbSerial;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.Label lblPortName;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.ComboBox cmbPortName;
        private System.Windows.Forms.GroupBox grbComm;
        private System.Windows.Forms.RadioButton rdbUsb;
        private System.Windows.Forms.RadioButton rdbSerial;
        private System.Windows.Forms.RadioButton rdbNet;
        private System.Windows.Forms.Button btnConnected;
        private System.Windows.Forms.Button btnDisConnect;
        private System.Windows.Forms.Panel pnlConnect;
        private System.Windows.Forms.RichTextBox rtxtRes;
    }
}