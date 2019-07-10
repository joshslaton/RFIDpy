using ADSDK.Initializer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ADSDK.Bases.Controls
{
    public partial class QuickHexControl : UserControl
    {
        public QuickHexControl()
        {
            InitializeComponent();
        }

        [Browsable(true), DefaultValue("Text1")]
        public override string Text
        {
            get
            {
                return lblText.Text;
            }
            set
            {
                lblText.Text = value;
                base.Text = value;
                lblDec.Text = IniSettings.GetLanguageString("DEC", "十进制");
                lblHex.Text = IniSettings.GetLanguageString("HEX", "十六进制");
                lblWg.Text = IniSettings.GetLanguageString("WG", "标准韦根");
            }
        }

        private ulong mValue = 0;
        [Browsable(true), DefaultValue(0)]
        public ulong Value
        {
            get
            {
                return mValue;
            }
            set
            {
                mValue = value;
                blnChangeFlag = false;
                RefrashCard();
                blnChangeFlag = false;
            }
        }

        public string Dec
        {
            get
            {
                return getDec();
            }
        }
        public string Hex
        {
            get
            {
                return getHex(); 
            }
        }
        public string WG
        {
            get
            {
                return getWg();
            }
        }

        public enum MaskType
        {
            /// <summary>
            /// 
            /// </summary>
            WG26,
            /// <summary>
            /// 
            /// </summary>
            WG34,
            /// <summary>
            /// 
            /// </summary>
            WG66
        }

        private MaskType m_maskType = MaskType.WG34;

        [Browsable(true), DefaultValue(MaskType.WG34)]
        public MaskType StdMask
        {
            get { return m_maskType; }
            set
            {
                blnChangeFlag = true;
                m_maskType = value;
                switch (m_maskType)
                {
                    case MaskType.WG26:
                        pnlDEC.Width = pnlWG.Width;
                        pnlHEX.Width = pnlWG.Width;
                        pnlWG.Visible = true;
                        utxtDec.InputMask = "00000000";
                        utxtHex.InputMask = "HH-HH-HH";
                        utxtWg.InputMask = "000,00000";
                        break;
                    case MaskType.WG66:
                        pnlWG.Visible = false;
                        pnlDEC.Width = pnlWG.Width * 3 / 2;
                        pnlHEX.Width = pnlWG.Width * 3 / 2;
                        utxtDec.InputMask = "000000000000000000";
                        utxtHex.InputMask = "HH-HH-HH-HH-HH-HH-HH-HH";
                        break;
                    case MaskType.WG34:
                    default:
                        pnlDEC.Width = pnlWG.Width;
                        pnlHEX.Width = pnlWG.Width;
                        pnlWG.Visible = true;
                        utxtDec.InputMask = "0000000000";
                        utxtHex.InputMask = "HH-HH-HH-HH";
                        utxtWg.InputMask = "00000,00000";
                        break;
                }
                RefrashCard();
                blnChangeFlag = false;
            }
        }

        private bool mIsHexPlus = false;
        [Browsable(true), DefaultValue(false)]
        public bool IsHexPlus
        {
            get { return mIsHexPlus; }
            set
            {
                mIsHexPlus = value;
                utxtWg.Enabled = utxtDec.Enabled = !mIsHexPlus;
                
                RefrashCard();
            }
        }
        
        /// <summary>
        /// Whether can be Auto Change Data
        /// </summary>
        bool blnChangeFlag = false;

        private void utxtDec_TextChanged(object sender, EventArgs e)
        {
            if (!blnChangeFlag)
            {
                blnChangeFlag = true;
                mValue = ConvertData.DecStringToDecLong(utxtDec.Value.Trim(), (int)m_maskType);
                RefrashCard();
                blnChangeFlag = false;
            }
        }

        private void utxtHex_TextChanged(object sender, EventArgs e)
        {
            if (!blnChangeFlag)
            {
                blnChangeFlag = true;
                if (mIsHexPlus)
                {
                    try
                    {
                        mValue = Convert.ToUInt64(utxtHex.Text.Replace("-", ""));
                    }
                    catch 
                    {
                        utxtHex.Text = "000001";
                    }
                }
                else
                    mValue = ConvertData.HexStringToDecLong(utxtHex.Text.Replace("-", ""), (int)m_maskType);

                RefrashCard();
                blnChangeFlag = false;
            }
        }

        private void utxtWg_TextChanged(object sender, EventArgs e)
        {
            if (!blnChangeFlag)
            {
                blnChangeFlag = true;
                string[] str = utxtWg.Text.Trim().Split(',');
                ulong lngfirst = Convert.ToUInt64(str[0]);
                ulong lngsecond = Convert.ToUInt64(str[1]);
                if(m_maskType == MaskType.WG34)
                {
                    if (lngfirst > 65535) lngfirst = 65535;
                }
                else if(m_maskType == MaskType.WG26)
                {
                    if (lngfirst > 255) lngfirst = 255;
                }
                if (lngsecond > 65535) lngsecond = 65535;
                mValue = lngfirst * 65536 + lngsecond;
                RefrashCard();
                blnChangeFlag = false;
            }
        }

        private void RefrashCard()
        {
            if (mValue < 0) mValue = 0;
            if (mIsHexPlus)
            {
                if (m_maskType == MaskType.WG34)
                {
                    if (mValue > 99999999) mValue = mValue % 100000000;
                }
                else if (m_maskType == MaskType.WG26)
                {
                    if (mValue > 999999) mValue = mValue % 1000000;
                }
                else if (m_maskType == MaskType.WG66)
                {
                    if (mValue > 9999999999999999) mValue = mValue % 10000000000000000;
                }
            }
            else
            {
                if (m_maskType == MaskType.WG34)
                {
                    if (mValue > 0xffffffff) mValue = mValue % 0x100000000;
                }
                else if (m_maskType == MaskType.WG26)
                {
                    if (mValue > 0xffffff) mValue = mValue % 0x1000000;
                }
                else if (m_maskType == MaskType.WG66)
                {
                    if (mValue > 0x0DE0B6B3A763FFFF) mValue = 0x0DE0B6B3A763FFFF;
                }
            }
            utxtDec.Value = getDec();
            utxtHex.Value = getHex();
            if (m_maskType != MaskType.WG66) utxtWg.Value = getWg();
        }

        private string getDec()
        {
            return mValue.ToString(utxtDec.InputMask);
        }

        private string getHex()
        {
            if (mIsHexPlus)
            {
                switch (m_maskType)
                {
                    case MaskType.WG34:
                        return mValue.ToString("00000000");
                    case MaskType.WG66:
                        return mValue.ToString("0000000000000000");
                    default:
                        return mValue.ToString("000000");
                }
            }
            else
            {
                return ConvertData.DecLongToHexString(mValue, (int)m_maskType);
            }
        }

        private string getWg()
        {
            ulong lngfirst = mValue / 65536;
            ulong lngsecond = mValue % 65536;
            ulong lngwg = lngfirst * 100000 + lngsecond;
            if (m_maskType == MaskType.WG34)
                return lngwg.ToString("0000000000");
            else
                return lngwg.ToString("00000000");
        }

        public void Plus()
        {
            mValue += 1;
            RefrashCard();
        }

        public void Minus()
        {
            mValue -= 1;
            RefrashCard();
        }

        private void QuickHexControl_Resize(object sender, EventArgs e)
        {
            pnlTitleSpet.Height = (this.Height - 44) / 2;
        }
    }
}
