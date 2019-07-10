using ADSDK.Bases;
using ADSDK.Device;
using ADSDK.Device.Reader.Passive;
using ADSDK.Initializer;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ADSDKDemo
{
    public partial class frmMain : Form
    {
        ucPassive ucPassive1 = new ucPassive();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (ucPassive1 != null)
            {
                ucPassive1 = new ucPassive();
                ucPassive1.Parent = pnlInformation;
                ucPassive1.Dock = DockStyle.Fill;
            }
            IniSettings.LoadLanguage();
            IniSettings.LngCount = 2;
            UInt16 languageid = Languages.UserDefaultUILanguage;
            switch (languageid)
            {
                case 0x0804:
                    LoadLanguage(1);
                    break;
                case 0x0C04:
                case 0x0404:
                    LoadLanguage(2);
                    break;
                default:
                    LoadLanguage(0);
                    break;
            }

            SystemPub.ADRcp = new PassiveRcp();
            SystemPub.ADRcp.RcpLogEventReceived += RcpLogEventReceived;
            SystemPub.ADRcp.RxRspParsed += RxRspEventReceived;
            
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SystemPub.ADRcp.bConnected)
            {
                SystemPub.ADRcp.DisConnect();
            }
        }

        #region ---Language---
        public void ChangeLanguage()
        {
            switch (IniSettings.AppsLanguage)
            {
                case LngType.CHN:
                    this.Text = "读卡器演示程序 (dev) - 简体中文 - " + IniSettings.Communication.ToString();

                    #region ---菜单栏----
                    if (tsmiConnect.Text == "DIS&CONNECT")
                    {
                        tsmiConnect.Text = "断开(&C)";
                    }
                    else
                    {
                        tsmiConnect.Text =  "联机(&C)";
                    }
                    tsmiHelp.Text = "帮助(&H)";

                    tsmiMsg.Text = "实时信息显示";
                    tsmiAboutMe.Text = "关于  读卡器演示程序(&A)";
                    tsmiUserManual.Text = "用户手册(&U)";
                    listViewMsg.Columns[0].Text = "时间";
                    listViewMsg.Columns[1].Text = "类型";
                    listViewMsg.Columns[2].Text = "数据包(16进制)";
                    listViewMsg.Columns[3].Text = "细节";
                    #endregion
                    break;
                default:
                    this.Text = "RFID Demo (dev) - English - " + IniSettings.Communication.ToString();

                    #region ---菜单栏----
                    if (tsmiConnect.Text == "断开(&C)")
                    {
                        tsmiConnect.Text = "DIS&CONNECT";
                    }
                    else
                    {
                        tsmiConnect.Text = "&CONNECT";
                    }
                    tsmiHelp.Text = "&HELP";

                    tsmiMsg.Text = "Display Realtime Message";
                    tsmiAboutMe.Text = "About  RFID Demo(&A)";
                    tsmiUserManual.Text = "User Manual";
                    listViewMsg.Columns[0].Text = "Time";
                    listViewMsg.Columns[1].Text = "Type";
                    listViewMsg.Columns[2].Text = "RCP Packet(HEX)";
                    listViewMsg.Columns[3].Text = "Details";
                    #endregion
                    break;
            }
            if (ucPassive1 != null) ucPassive1.ChangeLanguage();
        }

        private void LoadLanguage(int language)
        {
            IniSettings.Language = language;

            tsmiLngEng.Checked = false;
            tsmiLngChn.Checked = false;
            switch (language)
            {
                case 0:
                    tsmiLngEng.Checked = true;
                    break;
                case 1:
                    tsmiLngChn.Checked = true;
                    break;
            }
            ChangeLanguage();
        }

        private void tsmiLngChn_Click(object sender, EventArgs e)
        {
            LoadLanguage(1);
        }

        private void tsmiLngEng_Click(object sender, EventArgs e)
        {
            LoadLanguage(0);
        }
        #endregion
        
        #region ---Help---
        private void tsmiMsg_Click(object sender, EventArgs e)
        {
            listViewMsg.Visible = !listViewMsg.Visible;
            tsmiMsg.Checked = listViewMsg.Visible;
        }
        private void tsmiAboutMe_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region ---Attention----
        private string aMsg = "";
        private void AttentionMouseLeave(object sender, EventArgs e)
        {
            aMsg = "";
            this.ttpAttention.Active = false;
        }

        private void tsStatusPortOpen_MouseEnter(object sender, EventArgs e)
        {
            aMsg = "Device connection state";
            if (IniSettings.AppsLanguage == LngType.CHN)
            {
                aMsg = "读卡器当前连接状态";
            }
            this.ttpAttention.Show(aMsg, this.statusBar, 10, -30);
            this.ttpAttention.Active = true;
        }

        private void tsStatusPort_MouseEnter(object sender, EventArgs e)
        {
            aMsg = "Device host name(portname,ip or device type)";
            if (IniSettings.AppsLanguage == LngType.CHN)
            {
                aMsg = "串口模式: 串口号" + Environment.NewLine +
                        "网络模式: IP地址";
            }
            this.ttpAttention.Show(aMsg, this.statusBar, 110, -30);
            this.ttpAttention.Active = true;
        }

        private void tsStatusBr_MouseEnter(object sender, EventArgs e)
        {
            aMsg = "Device host port(baudrate,ipport or device handle)";
            if (IniSettings.AppsLanguage == LngType.CHN)
            {
                aMsg = "串口模式: 波特率" + Environment.NewLine +
                        "网络模式: IP端口";
            }
            this.ttpAttention.Show(aMsg, this.statusBar, 230, -30);
            this.ttpAttention.Active = true;
        }

        private void tsFWVersion_MouseEnter(object sender, EventArgs e)
        {
            aMsg = "device type,version and address" + Environment.NewLine +
                                    "type P is 915MHz Reader" + Environment.NewLine +
                                    "type A is 2.4GHz Reader" + Environment.NewLine +
                                    "type R is R2000 Reader";
            if (IniSettings.AppsLanguage == LngType.CHN)
            {
                aMsg = "读卡器类别,软件版本以及地址" + Environment.NewLine +
                                    "类型 P 为915MHz读卡器(普通)" + Environment.NewLine +
                                    "类型 A 为2.4GHz读卡器(普通)" + Environment.NewLine +
                                    "类型 R 为915MHz读卡器(高级)";
            }
            this.ttpAttention.Show(aMsg, this.statusBar, 310, -80);
            this.ttpAttention.Active = true;
        }

        private void tsStatusInfo_MouseEnter(object sender, EventArgs e)
        {
            aMsg = "Communication Status";
            if (IniSettings.AppsLanguage == LngType.CHN)
            {
                aMsg = "当前通讯状态";
            }
            this.ttpAttention.Show(aMsg, this.mnuBar, 560, -30);
            this.ttpAttention.Active = true;
        }


        private void tsmiConnect_MouseEnter(object sender, EventArgs e)
        {
            aMsg = "Connect or Disconnect the reader";
            if (IniSettings.AppsLanguage == LngType.CHN)
            {
                aMsg = "连接或者断开读卡器";
            }
            this.ttpAttention.Show(aMsg, this.mnuBar, 10, 30);
            this.ttpAttention.Active = true;
        }

        private void tsmiComm_MouseEnter(object sender, EventArgs e)
        {
            aMsg = "Config communication parameters" + Environment.NewLine +
                    "Select communication type;" + Environment.NewLine +
                    "set portname,baudrate,ip address and ip port";
            if (IniSettings.AppsLanguage == LngType.CHN)
            {
                aMsg = "配置通讯参数" + Environment.NewLine +
                       "选择通讯类型,并配置相关参数" + Environment.NewLine +
                       "比如端口号,波特率,IP地址,IP端口等" + Environment.NewLine +
                       "通过下方状态栏查看设置参数";
            }
            this.ttpAttention.Show(aMsg, this.mnuBar, 10, 30);
            this.ttpAttention.Active = true;
        }
        
        private void tsmiLanguage_MouseEnter(object sender, EventArgs e)
        {
            aMsg = "Switch the display language";
            if (IniSettings.AppsLanguage == LngType.CHN)
            {
                aMsg = "切换界面显示语言";
            }
            this.ttpAttention.Show(aMsg, this.mnuBar, 10, 30);
            this.ttpAttention.Active = true;
        }

        private void tsmiHelp_MouseEnter(object sender, EventArgs e)
        {
            aMsg = "Support";
            if (IniSettings.AppsLanguage == LngType.CHN)
            {
                aMsg = "软件帮助";
            }
            this.ttpAttention.Show(aMsg, this.mnuBar, 10, 30);
            this.ttpAttention.Active = true;
        }
        #endregion
        
        #region ---DispalyMsg---
        private StringBuilder msgSb = new StringBuilder();
        private bool bDisposed = false;
        public void DisplayMsgString(string s)
        {
            if (bDisposed)
                return;

            if (!InvokeRequired)
            {
                __DisplayMsgString(s);
                return;
            }

            this.Invoke(new MethodInvoker(delegate()
            {
                __DisplayMsgString(s);
            }));
        }

        private void __DisplayMsgString(string s)
        {
            if (!bDisposed)
            {
                msgSb.Append(s);
                s = s.TrimEnd(new char[] { '\r', '\n', ')', ' ' });

                ListViewItem lvt = new ListViewItem(DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00") + " " + DateTime.Now.Millisecond.ToString("000"));
                string[] msg = s.Split(new char[] { '>', '(' }, 3, StringSplitOptions.None);

                if (msg.Length == 1 && msg[0] == "") return;

                Color bc = Color.White;
                for (int i = 0; i < msg.Length; i++)
                {
                    if (i == 0)
                    {
                        switch (msg[0])
                        {
                            case "RCP CMD":
                                bc = Color.OldLace;
                                break;
                            case "RCP RSP":
                                bc = Color.Lavender;
                                break;
                            case "RCP AUTO":
                                bc = Color.LemonChiffon;
                                break;
                            case "ERROR":
                                bc = Color.LightGray;
                                break;
                        }
                    }

                    lvt.SubItems.Add(msg[i]);
                }

                lvt.BackColor = bc;
                lvt.Font = new Font(IniSettings.AppsFont.FontFamily, 8);

                // listViewMsg.Visible = false;
                if (listViewMsg.Items.Count > 5000)
                {
                    for (int i = 0; i < 500; i++)
                    {
                        listViewMsg.Items.RemoveAt(0);
                    }
                }
                else
                {
                    listViewMsg.Items.Add(lvt).EnsureVisible();
                }
                listViewMsg.Update();
                //listViewMsg.Visible = true;
            }
        }

        private void tsMenuItemClear_Click(object sender, EventArgs e)
        {
            listViewMsg.Items.Clear();
            msgSb.Remove(0, msgSb.Length);
        }

        private void tsMenuItemCopy_Click(object sender, EventArgs e)
        {
            if (listViewMsg.SelectedItems != null && listViewMsg.SelectedItems.Count != 0)
            {
                string strmsg = "";
                for (int i = 0; i < listViewMsg.Columns.Count; i++)
                {
                    strmsg += listViewMsg.SelectedItems[0].SubItems[i].Text + "\t";
                }
                Clipboard.SetText(strmsg);
            }
        }

        private void tsMenuItemCopyAll_Click(object sender, EventArgs e)
        {
            msgSb.Remove(0, msgSb.Length);
            foreach (ListViewItem lvi in listViewMsg.Items)
            {
                string strmsg = "";
                for (int i = 0; i < listViewMsg.Columns.Count; i++)
                {
                    try
                    {
                        strmsg += lvi.SubItems[i].Text + "\t";
                    }
                    catch { }
                }
                msgSb.Append(strmsg + Environment.NewLine);
            }
            if (msgSb != null && msgSb.Length != 0) Clipboard.SetText(msgSb.ToString());
        }

        #endregion

        #region ---Communication---
        void RcpLogEventReceived(object sender, StringEventArg e)
        {
            DisplayMsgString(e.Data);
        }

        void RxRspEventReceived(object sender, ProtocolEventArg e)
        {
            if (this.IsDisposed)
                return;

            if (!this.InvokeRequired)
            {
                __ParseRsp(e.Protocol);
                return;
            }

            this.Invoke(new MethodInvoker(delegate()
            {
                __ParseRsp(e.Protocol);
            }));
        }

        private void __ParseRsp(ProtocolStruct Data)
        {
            tsStatusPortOpen.Text ="CONNECTED";
            switch (Data.Code)
            {
                case PassiveRcp.RCP_CMD_INFO:
                    if (Data.Length > 0 && Data.Type == 0)
                    {
                        #region ---Parameter---
                        string strInfo = Encoding.ASCII.GetString(Data.Payload, 0, Data.Length);
                       
                        tsFWVersion.Text = IniSettings.AppsLanguage == LngType.ENG ?
                            "Type:" + SystemPub.ADRcp.Mode+ SystemPub.ADRcp.Type + " - Version:" + SystemPub.ADRcp.Version + " - Address: " + SystemPub.ADRcp.Address :
                            "类型:" + SystemPub.ADRcp.Mode + SystemPub.ADRcp.Type  + " - 版本:" + SystemPub.ADRcp.Version + " - 地址: " + SystemPub.ADRcp.Address;
                        #endregion

                        switch (SystemPub.ADRcp.Mode)
                        {
                            case "P":
                                ucPassive1.Show();
                                ucPassive1.Parent = pnlInformation;
                                ucPassive1.Dock = DockStyle.Fill;
                                break;
                        }
                    }
                    break;
            }

            if (ucPassive1 != null) ucPassive1.ParseRsp(Data);
            pDisplayStatusInfo(Data.Code, Data.Type, Data.Length);
        }

        private void pDisplayStatusInfo(byte code, byte type, byte len)
        {
            bool blnStatus = (type == 0x21 || type == 0x00 || type == 0x32);
            string strStatus = blnStatus ?
                    IniSettings.GetLanguageString("Success ", "成功 ") :
                    IniSettings.GetLanguageString("Fail ", "失败 ");
            bool blnAction = len > 0;
            string strAction = IniSettings.GetLanguageString("Action ", "操作 ");
            string strType = "";
            switch (code)
            {
                case PassiveRcp.RCP_CMD_INFO:
                    strType = blnAction ?
                        IniSettings.GetLanguageString("Information ", "基本信息 ") :
                        IniSettings.GetLanguageString("Address ", "通讯地址 ");
                    break;
                case PassiveRcp.RCP_CMD_ISO6B_RW:
                    strType = "ISO6B ";
                    break;
                case PassiveRcp.RCP_CMD_EPC_RW:
                    strType = "EPC ";
                    break;
                case PassiveRcp.RCP_CMD_ISO6B_IDEN:
                    strType = IniSettings.GetLanguageString("ISO6B Identify ", "ISO6B 识别 ");
                    break;
                case PassiveRcp.RCP_CMD_EPC_IDEN:
                    strType = IniSettings.GetLanguageString("EPC Identify ", "EPC 识别 ");
                    break;
                case PassiveRcp.RCP_CMD_EPC_MULT:
                    strType = IniSettings.GetLanguageString("Mult EPC Identify ", "多卡识别 ");
                    break;
                case PassiveRcp.RCP_CMD_PARA:
                    strType = IniSettings.GetLanguageString("BASE Parameters ", "基本参数 ");
                    break;
                case PassiveRcp.RCP_CMD_TCPIP:
                    strType = IniSettings.GetLanguageString("TCPIP Parameters ", "TCPIP参数 ");
                    break;
                case PassiveRcp.RCP_CMD_OUTCARD:
                    strType = IniSettings.GetLanguageString("Output Type ", "输出参数 ");
                    break;
                case PassiveRcp.RCP_CMD_SECRET:
                    strType = IniSettings.GetLanguageString("Secret ", "加密操作 ");
                    break;
                case PassiveRcp.RCP_CMD_SOFTRESET:
                    strType = IniSettings.GetLanguageString("Soft reset ", "软重启 ");
                    break;
                case PassiveRcp.RCP_CMD_INITSYRIS:
                    strType = IniSettings.GetLanguageString("Init syris number ", "初始化SYRIS序号 ");
                    break;
                case PassiveRcp.RCP_CMD_REMOTE:
                    strType = IniSettings.GetLanguageString("Remote IO ", "远程IO操作 ");
                    break;
                case PassiveRcp.RCP_CMD_TIME:
                    strType = IniSettings.GetLanguageString("Time ", "设备时间 ");
                    break;
                case PassiveRcp.RCP_CMD_WIFI_DOWNLOAD:
                    strType = IniSettings.GetLanguageString("WIFI Para ", "WIFI参数... ");
                    if (type == 0x00) strStatus = IniSettings.GetLanguageString("Success ", "成功 ");
                    else strStatus = type.ToString() + " " + IniSettings.GetLanguageString("Step ", "阶段 ");
                    blnStatus = true;
                    break;
                default:
                    break;
            }
            if (blnStatus) tsStatusInfo.ForeColor = Color.Green; else tsStatusInfo.ForeColor = Color.Red;
            tsStatusInfo.Text = strAction + strType + strStatus;
        }
        #endregion

        private void tsmiConnect_Click(object sender, EventArgs e)
        {
            if (SystemPub.ADRcp.bConnected)
            {
                SystemPub.ADRcp.DisConnect();
                return;
            }
            new frmConnect().ShowDialog();
            ChangeLanguage();
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            tsmiConnect.Text = SystemPub.ADRcp.bConnected ? "DisConnect(断开)" : "Connect(联机)";
            if (SystemPub.ADRcp.bConnected)
            {
                tsmiInfo.Visible = SystemPub.ADRcp.bConnected;
                ucPassive1.Enabled = SystemPub.ADRcp.bConnected;
            }
            else
            {
                tsmiInfo.Visible = false;
                ucPassive1.Enabled = false;
            }
            tsStatusPort.Text = IniSettings.HostName;
            tsStatusBr.Text = IniSettings.HostPort.ToString();
        }

        private void tsmiInfo_Click(object sender, EventArgs e)
        {
            PassiveCommand.GetInformation(SystemPub.ADRcp);
        }
    }
}
