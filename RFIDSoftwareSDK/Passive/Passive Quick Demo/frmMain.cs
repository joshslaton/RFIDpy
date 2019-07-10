using ADSDK;
using ADSDK.Device;
using ADSDK.Device.Reader.Passive;
using System;
using System.Text;
using System.Windows.Forms;

namespace ADSDKDemo
{
    public partial class frmMain : Form
    {
        //ActiveXPCOM adx = new ActiveXPCOM();        //串口版
        //ActiveXPNET adx = new ActiveXPNET();      //网络版
        //ActiveXPUSB adx = new ActiveXPUSB();      //USB版
        ADActiveX adx = new ADActiveX();      //通用版

        int FCount = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            adx.RxRspParsed += adx_RxRspParsed; //主动工作模式下,可使用这个功能,被动模式下可取消此命令
            adx.StatusConnected += adx_StatusConnected;
        }
       
        void adx_StatusConnected(object sender, ConnectEventArg e)
        {
            try
            {
                this.BeginInvoke(new MethodInvoker(delegate()
                {
                    switch (e.Status)
                    {
                        case CommState.CONNECT_OK:
                            ShowResultState("通讯连接正常,设备未确定连接成功,需要发送通讯指令有回复确定!");
                            break;
                        case CommState.DISCONNECT_OK:
                            ShowResultState("断开链接成功!");
                            break;
                        case CommState.CONNECT_FAIL:
                            ShowResultState("链接失败!");
                            break;
                        case CommState.DISCONNECT_FAIL:
                            ShowResultState("断开成功!");
                            break;
                        case CommState.DISCONNECT_EXCEPT:
                            ShowResultState("远程异常断开!");
                            break;
                        default:
                            break;
                    }
                    btnConnect.Text = adx.IsConnected ? "DisConnect" : "Connect";
                }));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        void adx_RxRspParsed(object sender, ProtocolEventArg e)
        {
            this.BeginInvoke (new MethodInvoker(delegate()
            {
                //-----异步返回代码----
                //ShowResultState(ByteArrayToHexString(e.Protocol.ToArray()));
                //-------------------

                //-----主动上送-------
                switch (e.Protocol.Code)
                {
                    case PassiveRcp.RCP_CMD_ISO6B_IDEN:
                    case PassiveRcp.RCP_CMD_EPC_IDEN:
                        if (e.Protocol.Length > 0 && e.Protocol.Type == 0x32)
                        {
                            ShowResultState(ByteArrayToHexString(e.Protocol.Payload, 1, e.Protocol.Length - 1));
                        }
                        break;
                }
                //-------------------
            }));
        }

        private void ShowResultState(string str)
        {
            if (txtRes.Lines.Length > 5000)
            {
                txtRes.Clear();
            }
            txtRes.Text += DateTime.Now.ToString() + " " + str + Environment.NewLine;

            txtRes.SelectionStart = txtRes.TextLength;
            txtRes.ScrollToCaret();
        }
        
        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            if (!adx.IsConnected)
            {
                adx.Connect(txtIP.Text, Convert.ToInt32(txtport.Text));
            }
            else
            {
                adx.DisConnect();
            }
            btnConnect.Text = adx.IsConnected ? "DisConnect" : "Connect";
            btnConnect.Enabled = true;
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            //int cAddress = 65535;
            //string cVersion = "";
            //string cMode = "";
            //FCount = adx.Information(ref cAddress, ref cVersion, ref cMode);
            //if (FCount == 0)
            //{
            //    ShowResultState("Mode :" + cMode + " - Address :" + cAddress + " - Version :" + cVersion);
            //}

            FCount = adx.Information();
            if (FCount == 0)
            {
                ShowResultState(adx.RecvString);
            }
            ShowResultState(adx.GetReturnCode(FCount));
        }

        private void btnInitActive_Click(object sender, EventArgs e)
        {
            byte[] bytdata = new byte[18];
            if (adx.GetType() == new ActiveXANET().GetType())
            {
                //Reference communication protocol
                bytdata = new byte[] { 0x1E,0x01,0x6E,0x54,0x5D,
                                        0x66,0x6F,0x78,0x82,0x02 ,
                                        0x0A,0x00,0x03,0x00,0x1E ,
                                        0x0A,0x0F,0x01,0x10,0x01 ,
                                        0x01,0x02,0x00,0x02,0x00 ,
                                        0x00,0x00,0x20};
            }
            else
            {
                //Reference communication protocol
                bytdata = new byte[] { 0x1E,0x01,0x6E,0x54,0x5D,
                                        0x66,0x6F,0x78,0x82,0x02 ,
                                        0x0A,0x00,0x01,0x00,0x1E ,
                                        0x0A,0x0F,0x01,0x10,0x01 ,
                                        0x01,0x02,0x00,0x02,0x00 ,
                                        0x00,0x00,0x20};
            }
            FCount = adx.pSetConfig(bytdata);

            ShowResultState(adx.GetReturnCode(FCount));
        }

        private void btnInitPassive_Click(object sender, EventArgs e)
        {
            byte[] bytdata = new byte[18];
            //Reference communication protocol
            bytdata = new byte[] {  0x1E,0x01,0x6E,0x54,0x5D,
                                        0x66,0x6F,0x78,0x82,0x03 ,
                                        0x0A,0x00,0x01,0x00,0x1E ,
                                        0x0A,0x0F,0x01,0x10,0x01 ,
                                        0x01,0x02,0x00,0x02,0x00 ,
                                        0x00,0x00,0x20 };

            FCount = adx.pSetConfig(bytdata);

            ShowResultState(adx.GetReturnCode(FCount));
        }

        private void btnGetConfig_Click(object sender, EventArgs e)
        {          
            byte[] bytdata = new byte[28];
            //Reference communication protocol
            FCount = adx.pGetConfig(ref bytdata);
            if (FCount == 0)
            {
                ShowResultState(ByteArrayToHexString(bytdata));
            }
            ShowResultState(adx.GetReturnCode(FCount));
        }

        private void btnIdentify_Click(object sender, EventArgs e)
        {
            utxtCard.Text = "";
            Application.DoEvents();
            byte[] bytdata = new byte[28];

            FCount = adx.pIdentify6C(ref bytdata);
            if (FCount == 0)
            {
                utxtCard.Text = ByteArrayToHexString(bytdata).Substring(2);
            }
            else
            {
                utxtCard.Text = adx.GetReturnCode(FCount);
            }
            ShowResultState(adx.GetReturnCode(FCount));
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            utxtReadData.Text = "";
            Application.DoEvents();
            byte[] bytdata = new byte[28];

            byte mem = Convert.ToByte(cmbReadBlock.SelectedIndex);
            byte start = Convert.ToByte(ltxtReadAddress.Text);
            byte len = Convert.ToByte(ltxtReadLength.Text);

            FCount = adx.pRead6C(mem, start, len,ref bytdata);
            if (FCount == 0)
            {
                utxtReadData.Text = ByteArrayToHexString(bytdata).Substring(2);
            }
            else
            {
                utxtReadData.Text = adx.GetReturnCode(FCount);
            }
            ShowResultState(adx.GetReturnCode(FCount));
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            byte mem = Convert.ToByte(cmbWriteBlock.SelectedIndex);
            byte state = Convert.ToByte(ltxtWriteAddress.Text);
            byte len = Convert.ToByte(ltxtWriteLength.Text);
            byte[] sndData = HexStringToByteArray(utxtWriteData.Text.Replace("-", ""));

            FCount = adx.pWrite6C(mem, state, len, sndData);

            ShowResultState(adx.GetReturnCode(FCount));
        }
        
        private void btnIdentify6B_Click(object sender, EventArgs e)
        {
            utxtCard6B.Text = "";
            Application.DoEvents();
            byte[] bytdata = new byte[28];

            FCount = adx.pIdentify6B(ref bytdata);
            if (FCount==0)
            {
                utxtCard6B.Text = ByteArrayToHexString(bytdata).Substring(2);
            }
            else
            {
                utxtCard6B.Text = adx.GetReturnCode(FCount);
            }

            ShowResultState(adx.GetReturnCode(FCount));
        }

        private void btnRead6B_Click(object sender, EventArgs e)
        {
            utxtReadData6B.Text = "";
            Application.DoEvents();
            byte[] bytdata = new byte[28];

            byte start = Convert.ToByte(ltxtReadAddress6B.Text);
            byte len = Convert.ToByte(ltxtReadLength6B.Text);

            FCount = adx.pRead6B(start, len,ref bytdata);
            if (FCount == 0)
            {
                utxtReadData6B.Text = ByteArrayToHexString(bytdata).Substring(2);
            }
            else
            {
                utxtReadData6B.Text = adx.GetReturnCode(FCount);
            }

            ShowResultState(adx.GetReturnCode(FCount));
        }

        private void btnWrite6B_Click(object sender, EventArgs e)
        {
            byte start = Convert.ToByte(ltxtWriteAddress6B.Text);
            byte len = Convert.ToByte(ltxtWriteLength6B.Text);
            byte[] sndData = HexStringToByteArray(utxtWriteData6B.Text.Replace("-", ""));


            FCount = adx.pWrite6B(start, len, sndData);
            
            ShowResultState(adx.GetReturnCode(FCount));
        }

        private void txtIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtport_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 字节数组转换十六进制
        /// </summary>
        /// <param name="bytArray">字节数组</param>
        /// <returns></returns>
        public static string ByteArrayToHexString(byte[] bytArray)
        {
            StringBuilder sbResult = new StringBuilder(bytArray.Length * 3);
            foreach (byte b in bytArray)
            {
                try
                {
                    sbResult.Append(Convert.ToString(b, 16).PadLeft(2, '0'));
                }
                catch { }
            }
            return sbResult.ToString().ToUpper();
        }

        /// <summary>
         /// 字节数组转16进制字符串
         /// </summary>
         /// <param name="bytes"></param>
         /// <param name="index"></param>
         /// <param name="count"></param>
         /// <returns></returns>
        public static string ByteArrayToHexString(byte[] bytes, int index, int count)
        {
            try
            {
                string str = "";
                for (int i = 0; i < count; i++)
                {
                    str += bytes[i + index].ToString("X2");
                }
                return str;
            }
            catch (System.Exception ex)
            {
                throw (new Exception(ex.Message));
            }
        }

        /// <summary>
        /// 字节数组转16进制字符串
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static byte[] HexStringToByteArray(string str)
        {
            try
            {
                str = str.Replace(" ", "");
                if ((str.Length & 0x01) > 0)
                    throw (new Exception("string length must be even"));
                byte[] bytes = new byte[str.Length / 2];
                for (int i = 0; i < str.Length; i += 2)
                {
                    bytes[i / 2] = Convert.ToByte(str.Substring(i, 2), 16);
                }
                return bytes;
            }
            catch (System.Exception ex)
            {
                throw (new Exception(ex.Message));
            }
        }
    }
}
