using System;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace ADSDKDemo
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        
        private SerialPort sp;

        private void frmMain_Load(object sender, System.EventArgs e)
        {
            sp = new SerialPort("COM1",9600);
            sp.DataReceived += Sp_DataReceived;
            try
            {
                sp.Open();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void Sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int intDataCount = sp.BytesToRead;
            byte[] byteBuff = new byte[intDataCount];
            sp.Read(byteBuff, 0, intDataCount);
            string msg = ByteArrayToHexString(byteBuff, 0, intDataCount);
            Console.WriteLine(msg);

            this.BeginInvoke(new MethodInvoker(delegate ()
            {
                ShowResultState(msg);
            }));
        }

        /// <summary>
        /// 字节数组转换十六进制
        /// </summary>
        /// <param name="bytArray">字节数组</param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string ByteArrayToHexString(byte[] bytArray, int start, int length)
        {
            StringBuilder sbResult = new StringBuilder(bytArray.Length * 3);
            for (int i = start; i < length + start; i++)
            {
                try
                {
                    sbResult.Append(Convert.ToString(bytArray[i], 16).PadLeft(2, '0'));
                    //sbResult.Append(" ");
                }
                catch { }
            }
            return sbResult.ToString().ToUpper();
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
    }
}
