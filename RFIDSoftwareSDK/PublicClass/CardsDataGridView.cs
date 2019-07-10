using ADSDK.Bases;
using ADSDK.Initializer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ADSDK.Device.Reader
{
    public partial class CardsDataGridView : UserControl
    {
        #region ---Base Config---
        public void ChangeLanguage()
        {

            string[] m_def_en = new string[] { "No.","Ant","Address","Hex/Dec/WG","Length","Hex Card","Last Time","Repeat Count","Mult Count","Div Ant","Div Address","Div Alarm","Count","Sum"};
            string[] m_def_cn = new string[] { "序号", "天线", "地址", "16进制/10进制/标准韦根", "长度", "十六进制", "读卡时间", "读卡次数", "读数量", "区分天线", "区分地址", "区分报警", "数量", "合计"};
            string[] m_def_tw = new string[] { "序號", "天線", "地址", "16進制/10進制/標準維根", "長度", "十六進制", "讀卡時間", "讀卡次數", "數量", "區分天線", "區分地址", "區分報警", "數量", "合計" };

            string[] MainValue = IniSettings.LoadLanguage("cardview", m_def_en, m_def_cn, m_def_tw);
            int index = 0;

            colID.HeaderText =  MainValue[index++];
            colAnt.HeaderText =  MainValue[index++];
            colAddress.HeaderText =  MainValue[index++];
            colDecCard.HeaderText =  MainValue[index++];
            colHexByteSum.HeaderText = MainValue[index++];
            colHexCard.HeaderText =  MainValue[index++];
            colTime.HeaderText = MainValue[index++];
            colCount.HeaderText =  MainValue[index++];

            lblReadCount.Text =  MainValue[index++];
            chkDivAnt.Text =  MainValue[index++];
            chkDivAddr.Text =  MainValue[index++];
            chkDivAlarm.Text =  MainValue[index++];
            lblCount.Text =  MainValue[index++];
            lblSum.Text = MainValue[index++];
        }
        #endregion

        public CardsDataGridView()
        {
            InitializeComponent();
            ChangeLanguage();
        }

        [Description("读多卡数量"), Category("Behavior"), DefaultValue(5)]
        public int MultCount
        {
            set
            {
                if (value == 0) cmbReadCount.SelectedIndex = 4;
                else cmbReadCount.SelectedIndex = value - 1;
            }
            get { return cmbReadCount.SelectedIndex + 1; }
        }
        [Description("读多卡数量使能"), Category("Behavior"), DefaultValue(false)]
        public bool MultEnabled
        {
            set { pnlReadCount.Enabled = value; }
            get { return pnlReadCount.Enabled; }
        }
        [Description("读多卡数量显示"), Category("Behavior"), DefaultValue(false)]
        public bool MultVisible
        {
            set { pnlReadCount.Visible = value; }
            get { return pnlReadCount.Visible; }
        }

        public void Clear()
        {
            dgvShow.Rows.Clear();
        }

        public DataGridView View
        {
            get { return dgvShow; }
        }

        public void Add(List<CardParameters> infoArray)
        {
            for (int i = 0; i < infoArray.Count; i++)
            {
                Add(infoArray[i]);
            }
        }

        public void Add(CardParameters info)
        {
            if (chkDivCard.Checked)
            {
                if (info.Length > 4)
                {
                    for (int m = 0; m < info.DataString.Length / 8; m++)
                    {
                        CardParameters cp = (CardParameters)info.Clone();
                        cp.Length = 4;
                        cp.DataString = info.DataString.Substring(m * 8, 8);
                        AddData(cp);
                    }
                }
                else
                {
                    AddData(info);
                }
            }
            else
            {
                AddData(info);
            }
        }

        public void AddData(CardParameters info)
        {
            txtCount.Text = info.Count.ToString();
            for (int m = 0; m < dgvShow.Rows.Count; m++)
            {
                if ((info.DataString == Convert.ToString(dgvShow["colHexCard", m].Value)) &&
                    (chkDivAnt.Checked ? (info.Antenna == Convert.ToInt32(dgvShow["colAnt", m].Value)) : true) &&
                    (chkDivAddr.Checked ? (info.Address == Convert.ToInt32(dgvShow["colAddress", m].Value)) : true))
                {
                    PulsData(m, (chkDivAlarm.Checked ? (info.Alarm > 0) : false));
                    return;
                }
            }
            PulsData(dgvShow.Rows.Count + 1, info);
        }

        private void PulsData(int index,CardParameters info)
        {
            string strCard = GetShortCard(info.DataString);

            dgvShow.Rows.Add(index,
                info.Antenna,
                info.Address,
                strCard,
                info.Length,
                info.DataString, 
                DateTime.Now.ToLongTimeString(), 
                1);
            if (chkDivAlarm.Checked ? (info.Alarm > 0) : false)
                this.dgvShow.Rows[dgvShow.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;
            else
                this.dgvShow.Rows[dgvShow.Rows.Count - 1].DefaultCellStyle.BackColor = Color.OldLace;
            this.dgvShow.Rows[dgvShow.Rows.Count - 1].Cells[2].Selected = true;

            txtSum.Text = dgvShow.Rows.Count.ToString();
        }

        private void PulsData(int index,bool alarm)
        {
            dgvShow["colCount", index].Value = Convert.ToInt32(dgvShow["colCount", index].Value) + 1;
            dgvShow["colTime", index].Value = DateTime.Now.ToLongTimeString();

            if (alarm)
            {
                this.dgvShow.Rows[index].DefaultCellStyle.BackColor = Color.Red;
            }
            else if (this.dgvShow.Rows[index].DefaultCellStyle.BackColor != Color.OldLace && this.dgvShow.Rows[index].DefaultCellStyle.BackColor != Color.Red)
            {
                this.dgvShow.Rows[index].DefaultCellStyle.BackColor = Color.OldLace;
                this.dgvShow.Rows[index].Cells[2].Selected = true;
            }
        }

        #region ---卡号获取超时变色显示---
        private int intActiveCount = 0;
        private const int ACTIVEMARK = 10;
        /// <summary>
        /// 卡号获取超时过程
        /// </summary>
        private void ActiveTime()
        {
            intActiveCount++;
            if (intActiveCount > ACTIVEMARK)
            {
                intActiveCount = 0;
                for (int i = 0; i < dgvShow.Rows.Count; i++)
                {
                    if (this.dgvShow.Rows[i].DefaultCellStyle.BackColor == Color.OldLace)
                    {
                        this.dgvShow.Rows[i].DefaultCellStyle.BackColor = Color.Lavender;
                    }
                    else if (this.dgvShow.Rows[i].DefaultCellStyle.BackColor == Color.Lavender)
                    {
                        this.dgvShow.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
        }
        #endregion

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            ActiveTime();
        }

        private void chkIsFour_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvShow.Rows.Count; i++)
            {
                dgvShow["colDecCard", i].Value = GetShortCard(Convert.ToString(dgvShow["colHexCard", i].Value));
            }
        }

        private void cmbStartPoint_SelectionChangeCommitted(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvShow.Rows.Count; i++)
            {
                dgvShow["colDecCard", i].Value = GetShortCard(Convert.ToString(dgvShow["colHexCard", i].Value));
            }
        }


        private string GetShortCard(string datastring)
        {

            ulong lngCard = ConvertData.HexStringToDecLong(datastring, cmbStartPoint.SelectedIndex < 0 ? 0 : cmbStartPoint.SelectedIndex, chkIsFour.Checked ? 4 : 3);
            ulong wgCard = ConvertData.HexStringToWGLong(datastring, cmbStartPoint.SelectedIndex < 0 ? 0 : cmbStartPoint.SelectedIndex, chkIsFour.Checked ? 4 : 3);
            string strCard =  ConvertData.DecLongToHexString(lngCard, chkIsFour.Checked ? 4 : 3);
            return "[" + strCard + "][" + lngCard + "][" + (chkIsFour.Checked?wgCard.ToString("0000000000"): wgCard.ToString("00000000")) + "]";
        }
        #region ---Attention----
        private string aMsg = "";
        private void AttentionMouseLeave(object sender, EventArgs e)
        {
            aMsg = "";
            this.ttpAttention.Active = false;
        }

        private void cmbReadCount_MouseEnter(object sender, EventArgs e)
        {
            aMsg = "Polling card number";
            if (IniSettings.AppsLanguage == LngType.CHN)
            {
                aMsg = "轮询读卡数量";
            }
            this.ttpAttention.Show(aMsg, (ComboBox)sender, 10, 30);
            this.ttpAttention.Active = true;
        }

        private void chkDivAnt_MouseEnter(object sender, EventArgs e)
        {
            aMsg = "The distinction between antenna";
            if (IniSettings.AppsLanguage == LngType.CHN)
            {
                aMsg = "区分不同天线读取数据";
            }
            this.ttpAttention.Show(aMsg, (CheckBox)sender, 10, 30);
            this.ttpAttention.Active = true;
        }

        private void chkDivAddr_MouseEnter(object sender, EventArgs e)
        {
            aMsg = "The distinction between address";
            if (IniSettings.AppsLanguage == LngType.CHN)
            {
                aMsg = "区分不同读卡器地址读取数据";
            }
            this.ttpAttention.Show(aMsg, (CheckBox)sender, 10, 30);
            this.ttpAttention.Active = true;
        }

        private void chkDivAlarm_MouseEnter(object sender, EventArgs e)
        {
            aMsg = "The distinction between alarm of card";
            if (IniSettings.AppsLanguage == LngType.CHN)
            {
                aMsg = "区分卡片低电压报警";
            }
            this.ttpAttention.Show(aMsg, (CheckBox)sender, 10, 30);
            this.ttpAttention.Active = true;
        }

        private void chkIsFour_MouseEnter(object sender, EventArgs e)
        {
            aMsg = "Decimal conversion data is 4 byte or 3 byte";
            if (IniSettings.AppsLanguage == LngType.CHN)
            {
                aMsg = "十进制转换数据是否为4字节或者3字节";
            }
            this.ttpAttention.Show(aMsg, (CheckBox)sender, 10, 30);
            this.ttpAttention.Active = true;
        }

        private void cmbStartPoint_MouseEnter(object sender, EventArgs e)
        {
            aMsg = "Start position which hex convert to decimal";
            if (IniSettings.AppsLanguage == LngType.CHN)
            {
                aMsg = "十进制转换数据起始位置";
            }
            this.ttpAttention.Show(aMsg, (ComboBox)sender, 10, 30);
            this.ttpAttention.Active = true;
        }

        private void chkDivCard_MouseEnter(object sender, EventArgs e)
        {
            aMsg = "The distinction between continuous number of Active card";
            if (IniSettings.AppsLanguage == LngType.CHN)
            {
                aMsg = "有源卡片是否区分连续卡号";
            }
            this.ttpAttention.Show(aMsg, (CheckBox)sender, 10, 30);
            this.ttpAttention.Active = true;
        }

        private void txtCount_MouseEnter(object sender, EventArgs e)
        {
            aMsg = "Display counts of card at a time";
            if (IniSettings.AppsLanguage == LngType.CHN)
            {
                aMsg = "单次显示卡号记录数量";
            }
            this.ttpAttention.Show(aMsg, (TextBox)sender, 10, 30);
            this.ttpAttention.Active = true;
        }

        private void txtSum_MouseEnter(object sender, EventArgs e)
        {
            aMsg = "Display counts of card at all time";
            if (IniSettings.AppsLanguage == LngType.CHN)
            {
                aMsg = "当前识别卡号记录总数量";
            }
            this.ttpAttention.Show(aMsg, (TextBox)sender, 10, 30);
            this.ttpAttention.Active = true;
        }
        #endregion

    }
}
