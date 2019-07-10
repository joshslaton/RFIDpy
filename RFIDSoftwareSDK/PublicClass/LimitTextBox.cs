using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ADSDK.Bases.Components
{
    /// <summary>
    /// 
    /// </summary>
    public partial class LimitTextBox : TextBox
    {
        /// <summary>
        /// 
        /// </summary>
        public LimitTextBox():base()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pe"></param>
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
         private string _limitText = "1234567890";

        /// <summary>
        /// 
        /// </summary>
        [Category("LimitText")]
        public string LimitText
        {
            get { return _limitText; }
            set { _limitText = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [Category("IntText")]
        public int IntText
        {
            get
            {
                try
                { return Convert.ToInt32(this.Text); }
                catch { return 0; }

            }
            set { this.Text = value.ToString(); }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            //if (Char.IsDigit(e.KeyChar))
            if (e.KeyChar != 0x16 && e.KeyChar != 0x03)
                e.KeyChar = ValiText(e.KeyChar, _limitText, true);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyValue == 107)
            {
                this.IntText += 1;
            }
            else if (e.KeyCode == Keys.Down || e.KeyValue == 109)
            {
                this.IntText -= 1;
            }
        }

        private char ValiText(char KeyIn, string VaLidateString, bool Editable)
        {
            string ValidateList = "";
            char KeyOut;
            if (Editable)
            {
                ValidateList = VaLidateString.ToUpper() + Convert.ToChar(8);
            }
            else
            {
                ValidateList = VaLidateString.ToUpper();
            }
            if (ValidateList.IndexOf(char.ToUpper(KeyIn)) >= 0)
            {
                KeyOut = char.ToUpper(KeyIn);
            }
            else
            {
                KeyOut = Convert.ToChar(0);
            }
            return KeyOut;
        }
    }
}
