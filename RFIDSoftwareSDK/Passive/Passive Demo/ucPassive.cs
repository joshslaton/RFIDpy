using ADSDK.Device;
using ADSDK.Device.Reader.Passive;
using ADSDK.Initializer;
using ADSDK.Wifi;
using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ADSDKDemo
{
    public partial class ucPassive : UserControl
    {
        ucPReadDemo ucPReadDemo1 = new ucPReadDemo();
        ucPBaseSettings ucPBaseSettings1 = new ucPBaseSettings();
        ucPSeniorSettings ucPSeniorSettings1 = new ucPSeniorSettings();
        ucPWriteISO ucPWriteISO1 = new ucPWriteISO();
        ucPWriteEPC ucPWriteEPC1 = new ucPWriteEPC();

        ucWifiSettings ucWifiSettings1 = new ucWifiSettings();
        public ucPassive()
        {
            InitializeComponent();
        }

        #region ---PUBLIC----
        public void ChangeLanguage()
        {
            try
            {
                string[] m_def_en = new string[] {" READ DEMO ",
                    " BASE SETTINGS ",
                    " SENIOR SETTINGS ",
                    " ISO18000-6B READ&&WRITE ",
                    " EPC(GEN 2) READ&&WRITE ",
                    " WIFI SETTINGS "};

                string[] m_def_cn = new string[] { "读卡演示", "基本参数", "高级参数", "ISO18000-6B 读写操作", "EPC(GEN 2) 读写操作", "WIFI参数" };

                string[] m_def_tw = new string[] { "讀卡演示", "基本參數", "高級參數", "ISO18000-6B 讀寫操作", "EPC(GEN 2) 讀寫操作", "WIFI參數" };

                string[] MainValue = IniSettings.LoadLanguage(@"passive/passive", m_def_en, m_def_cn, m_def_tw);
                int index = 0;

                tabReadDemo.Text = MainValue[index++];
                tabBaseSettings.Text = MainValue[index++];
                tabSeniorSettings.Text = MainValue[index++];
                tabWriteISO.Text = MainValue[index++];
                tabWriteEPC.Text = MainValue[index++];
                tabWifiSettings.Text = MainValue[index++];
            }
            catch { }

            ucPBaseSettings1.ChangeLanguage();
            ucPSeniorSettings1.ChangeLanguage();
            ucPReadDemo1.ChangeLanguage();
            ucPWriteISO1.ChangeLanguage();
            ucPWriteEPC1.ChangeLanguage();
            ucWifiSettings1.ChangeLanguage();
        }
        #endregion

        #region ---local----
        public void ParseRsp(ProtocolStruct Data)
        {
            switch (Data.Code)
            {
                case PassiveRcp.RCP_CMD_INFO:
                    if (Data.Length > 0 && Data.Type == 0)
                    {
                        #region ---Parameter---
                        string strInfo = Encoding.ASCII.GetString(Data.Payload, 0, Data.Length);

                        if (Data.Payload[17] == 'W' && IniSettings.Communication == CommType.SERIAL)
                        {
                            if (!this.tabPassive.TabPages.Contains(this.tabWifiSettings))
                            {
                                this.tabPassive.TabPages.Add(this.tabWifiSettings);
                                this.tabPassive.Refresh();
                                ucWifiSettings1.mADRcp = SystemPub.ADRcp;
                            }
                        }
                        #endregion

                        ResetOperation();
                    }
                    ucPSeniorSettings1.ParseRsp(Data);
                    break;
                case PassiveRcp.RCP_CMD_PARA:
                case PassiveRcp.RCP_CMD_OUTCARD:
                    ucPBaseSettings1.ParseRsp(Data);
                    break;
                case PassiveRcp.RCP_CMD_EPC_IDEN:
                case PassiveRcp.RCP_CMD_EPC_MULT:
                    if (tabWriteEPC == tabPassive.SelectedTab)
                        ucPWriteEPC1.ParseRsp(Data);
                    else
                        ucPReadDemo1.ParseRsp(Data);
                    break;
                case PassiveRcp.RCP_CMD_ISO6B_IDEN:
                    if (tabWriteISO == tabPassive.SelectedTab)
                        ucPWriteISO1.ParseRsp(Data);
                    else
                        ucPReadDemo1.ParseRsp(Data);
                    break;
                case PassiveRcp.RCP_CMD_ISO6B_RW:
                    ucPWriteISO1.ParseRsp(Data);
                    break;
                case PassiveRcp.RCP_CMD_SECRET:
                    if (tabWriteEPC == tabPassive.SelectedTab)
                        ucPWriteEPC1.ParseRsp(Data);
                    else
                        ucPSeniorSettings1.ParseRsp(Data);
                    break;
                case PassiveRcp.RCP_CMD_EPC_RW:
                    ucPWriteEPC1.ParseRsp(Data);
                    break;
                case PassiveRcp.RCP_CMD_TIME:
                case PassiveRcp.RCP_CMD_TCPIP:
                    ucPSeniorSettings1.ParseRsp(Data);
                    break;
                case PassiveRcp.RCP_CMD_WIFI_DOWNLOAD:
                case PassiveRcp.RCP_CMD_WIFI_PUB:
                case PassiveRcp.RCP_CMD_WIFI_STA:
                case PassiveRcp.RCP_CMD_WIFI_AP:
                    ucWifiSettings1.ParseRsp(Data);
                    break;
                default:
                    break;
            }
        }

        private bool processing = false;

        private Thread SyncThread = null;
        private void ResetOperation()
        {
            Application.DoEvents();
            Thread.Sleep(200);
            if (processing) return;

            if (SyncThread == null || SyncThread.IsAlive == false)
            {
                SyncThread = new Thread(new ThreadStart(syncParameters));
                SyncThread.Start();
            }
        }

        private void syncParameters()
        {
            processing = true;
            System.Threading.Thread.Sleep(20);

            // Protocol Parameters
            PassiveCommand.GetConfig(SystemPub.ADRcp);
            //if (!SystemPub.ADRcp.SendBytePkt(PassiveRcp.GetConfig(SystemPub.ADRcp.Address))) { }

            System.Threading.Thread.Sleep(20);

            if (IniSettings.Communication != CommType.USB)
            {
                if (SystemPub.ADRcp != null && SystemPub.ADRcp.Type == "T")
                PassiveCommand.GetTcpip(SystemPub.ADRcp);
                //if (!SystemPub.ADRcp.SendBytePkt(PassiveRcp.GetTcpip(SystemPub.ADRcp.Address))) { }
            }
            processing = false;
        }
        #endregion

        private void ucPassive_Load(object sender, EventArgs e)
        {
            ucPBaseSettings1.Parent = tabBaseSettings;
            ucPSeniorSettings1.Parent = tabSeniorSettings;
            ucPReadDemo1.Parent = tabReadDemo;
            ucPWriteISO1.Parent = tabWriteISO;
            ucPWriteEPC1.Parent = tabWriteEPC;
            ucWifiSettings1.Parent = tabWifiSettings;


            ucPBaseSettings1.Dock = DockStyle.Fill;
            ucPSeniorSettings1.Dock = DockStyle.Fill;
            ucPReadDemo1.Dock = DockStyle.Fill;
            ucPWriteISO1.Dock = DockStyle.Fill;
            ucPWriteEPC1.Dock = DockStyle.Fill;
            ucWifiSettings1.Dock = DockStyle.Fill;


            tabPassive.Controls.Remove(tabWifiSettings);
            if (IniSettings.Communication == CommType.USB)
            {
                this.tabPassive.TabPages.Remove(this.tabSeniorSettings);
            }
        }
    }
}
