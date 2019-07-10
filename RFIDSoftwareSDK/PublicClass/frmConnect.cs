using ADSDK.Bases;
using ADSDK.Device;
using ADSDK.Initializer;
using System;
using System.Drawing;
using System.IO.Ports;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;

namespace ADSDKDemo
{
    public partial class frmConnect : Form
    {
        public frmConnect()
        {
            InitializeComponent();
        }

        private void frmConnect_Load(object sender, EventArgs e)
        {
            LoadCommLanguage();
            LoadCommunication();

            //加载通讯状态事件
            SystemPub.ADRcp.StatusConnected += ADRcp_StatusConnected;
        }

        #region ---Communication Choice---

        /// <summary>
        /// 重复加载限制标志
        /// </summary>
        private bool mChangeCommFlag = false;

        /// <summary>
        /// 加载界面语言选择
        /// </summary>
        public void LoadCommLanguage()
        {
            try
            {
                string[] m_def_en = new string[] { "Configuration",
                                                    "Serial Interface","Net Interface","USB Interface",
                                                    "PortName","BaudRate","Remote IP","Remote Port"};

                string[] m_def_cn = new string[] { "通讯参数配置",
                                                    "串口通讯(RS232/RS485)", "网络通讯(TCP/WIFI)", "USB通讯(虚拟键盘/编程模式)", 
                                                    "串口选择","波特率","远程IP地址","远程IP端口"};

                string[] m_def_tw = new string[] { "通訊參數設定", 
                                                    "串口通訊(RS232/RS485)", "網絡通訊(TCP/WIFI)", "USB通訊(虛擬鍵盤/編程模式)",
                                                    "串行埠選擇", "串行傳輸速率", "遠程IP地址", "遠程IP埠" };

                string[] MainValue = IniSettings.LoadLanguage("sioconfig", m_def_en, m_def_cn, m_def_tw);
                int index = 0;

                this.Text = IniSettings.GetLanguageString("Select the device connection mode", "设备连接方式选择");
                grbComm.Text = MainValue[index++];

                rdbSerial.Text = MainValue[index++];
                rdbNet.Text = MainValue[index++];
                rdbUsb.Text = MainValue[index++];
                rdbSerial.Font = rdbNet.Font = rdbUsb.Font = new Font(IniSettings.AppsFont.FontFamily, 9, FontStyle.Bold);
                grbSerial.Text = rdbSerial.Text;
                grbNet.Text = rdbNet.Text;
                grbUsb.Text = rdbUsb.Text;

                lblPortName.Text = MainValue[index++];
                lblBaudRate.Text = MainValue[index++];

                lblRemoteIP.Text = MainValue[index++];
                lblRemotePort.Text = MainValue[index++];
            }
            catch { }
        }

        /// <summary>
        /// 加载通讯选项显示
        /// </summary>
        /// <param name="type"></param>
        private void LoadCommType(CommType type)
        {
            IniSettings.Communication = type;

            mChangeCommFlag = true;

            rdbSerial.ForeColor =
            rdbNet.ForeColor =
            rdbUsb.ForeColor = Color.Black;

            switch (IniSettings.Communication)
            {
                case CommType.SERIAL:
                    rdbSerial.Checked = true;
                    rdbSerial.ForeColor = Color.Blue;
                    break;
                case CommType.NET:
                    rdbNet.Checked = true;
                    rdbNet.ForeColor = Color.Blue;
                    break;
                case CommType.USB:
                    chkAutoConnect.Enabled = true;
                    rdbUsb.Checked = true;
                    rdbUsb.ForeColor = Color.Blue;
                    break;
                default:
                    break;
            }
            grbSerial.Visible = rdbSerial.Checked;
            grbNet.Visible = rdbNet.Checked;
            grbUsb.Visible = rdbUsb.Checked;
            mChangeCommFlag = false;
            if (!SystemPub.ADRcp.bConnected)
            {
                SystemPub.ADRcp.Send("AutoConnectStop");
            }
        }

        /// <summary>
        /// 加载通讯默认值
        /// </summary>
        private void LoadCommunication()
        {
            IniSettings.LoadCommunication();

            cmbPortName.Items.Clear();
            foreach (string st in SerialPort.GetPortNames())
            {
                int i = 0;
                for (i = st.Length - 1; i > 3; i--)
                {
                    if (RegexBase.IsUint(st.Substring(i, 1)))
                    {
                        break;
                    }
                }
                cmbPortName.Items.Add(st.Substring(0, (i + 1)));
            }

            try
            {
                cmbPortName.Text = IniSettings.PortName;
                cmbBaudRate.Text = IniSettings.BaudRate.ToString();
                txtRemoteIP.Text = IniSettings.IP;
                txtRemotePort.Text = IniSettings.IPPort.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            LoadCommType((CommType)IniSettings.Communication);

            if (!SystemPub.ADRcp.bConnected)
            {
                btnDisConnect.Enabled = false;
                btnConnected.Enabled = true;
            }
            else
            {
                btnDisConnect.Enabled = true;
                btnConnected.Enabled = false;
            }
        }
        #endregion

        /// <summary>
        /// 通讯状态异步显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        void ADRcp_StatusConnected(object sender, ConnectEventArg e)
        {
            try
            {
                this.Invoke(new MethodInvoker(delegate()
                {
                    pnlConnect.Enabled = true;
                    Application.DoEvents();

                    switch (e.Status)
                    {
                        case CommState.CONNECT_OK:
                            if (IniSettings.Communication == CommType.USB)
                            {
                                try
                                {
                                    int intVer = Convert.ToInt32(e.Msg);
                                    rtxtRes.AppendText("USB Version> :V" + intVer / 256 + "." + intVer % 256 / 16 + intVer % 16);
                                }
                                catch { }
                            }
                            btnDisConnect.Enabled = true;
                            btnConnected.Enabled = false;
                            rtxtRes.AppendText("CONNECTED OK> " + e.Msg + "(" + SystemPub.ADRcp.ToString() + ")\r\n");
                            this.BeginInvoke(new MethodInvoker(delegate ()
                            {
                                Application.DoEvents();
                                Thread.Sleep(200);
                                Application.DoEvents();
                                Thread.Sleep(200);
                                Application.DoEvents();
                                Thread.Sleep(200);
                                Application.DoEvents();
                                this.Close();
                            }));
                            break;
                        case CommState.CONNECT_FAIL:
                            btnDisConnect.Enabled = false;
                            btnConnected.Enabled = true;
                            rtxtRes.AppendText("ERROR> " + e.Msg + "(" + SystemPub.ADRcp.ToString() + ")\r\n");
                            break;
                        case CommState.DISCONNECT_OK:
                            btnDisConnect.Enabled = false;
                            btnConnected.Enabled = true;
                            rtxtRes.AppendText("DISCONNECT OK> " + e.Msg + "(" + SystemPub.ADRcp.ToString() + ")\r\n");
                            break;
                        case CommState.DISCONNECT_FAIL:
                            btnDisConnect.Enabled = false;
                            btnConnected.Enabled = true;
                            rtxtRes.AppendText("ERROR> " + e.Msg + "(" + SystemPub.ADRcp.ToString() + ")\r\n");
                            break;
                        case CommState.DISCONNECT_EXCEPT:
                            btnDisConnect.Enabled = false;
                            btnConnected.Enabled = true;
                            rtxtRes.AppendText("ERROR> " + e.Msg + "(" + SystemPub.ADRcp.ToString() + ")\r\n");
                            break;
                        default:
                            break;
                    }
                }));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void rdbCheckedChanged(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked) return;
            if (mChangeCommFlag) return;
            if (rdbSerial.Checked)
            {
                LoadCommType(CommType.SERIAL);
            }
            else if (rdbNet.Checked)
            {
                LoadCommType(CommType.NET);
            }
            else if (rdbUsb.Checked)
            {
                LoadCommType(CommType.USB);
            }
        }

        private void btnConnected_Click(object sender, EventArgs e)
        {

            IniSettings.PortName = cmbPortName.Text;
            IniSettings.BaudRate = Convert.ToInt32(cmbBaudRate.Text);
            IniSettings.IP = txtRemoteIP.Text;
            IniSettings.IPPort = Convert.ToInt32(txtRemotePort.Text);

            if (!SystemPub.ADRcp.bConnected)
            {
                if (IniSettings.Communication == CommType.NET)
                {
                    IPStatus ipsta = SystemBase.Ping(IniSettings.HostName);
                    if (ipsta != IPStatus.Success)
                    {
                        MessageBox.Show("PING:" + txtRemoteIP.Text + " " + ipsta.ToString());
                        return;
                    }
                }

                SystemPub.ADRcp.Connect(IniSettings.HostName, IniSettings.HostPort,(int)IniSettings.Communication);
                Application.DoEvents();

                if (IniSettings.Communication == CommType.USB)
                {
                    if (!chkAutoConnect.Enabled)
                    {
                        chkAutoConnect.Enabled = true;
                    }
                    else
                    {
                        if (chkAutoConnect.Checked)
                        {
                            chkAutoConnect.Enabled = false;
                            if (SystemPub.ADRcp.bConnected) SystemPub.ADRcp.Send("AutoConnectStart");
                        }

                    }
                }
                Application.DoEvents();
            }
        }

        private void btnDisConnect_Click(object sender, EventArgs e)
        {
            chkAutoConnect.Enabled = true;
            chkAutoConnect.Checked = false;
            rtxtRes.AppendText(IniSettings.GetLanguageString("CONNECT: DisConnected.", "联机: 已经断开读卡器."));
            Application.DoEvents();
            //Thread.Sleep(100);
            if(SystemPub.ADRcp.bConnected)SystemPub.ADRcp.DisConnect();
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PING:" + txtRemoteIP.Text + " " + SystemBase.Ping(txtRemoteIP.Text).ToString());
        }

        private void frmConnect_FormClosing(object sender, FormClosingEventArgs e)
        {
            //卸载通讯状态事件
            if(SystemPub.ADRcp != null)SystemPub.ADRcp.StatusConnected -= ADRcp_StatusConnected;
        }
    }
}
