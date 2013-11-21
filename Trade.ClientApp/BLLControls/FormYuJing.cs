using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Trade.ClientApp.BLL;
using Trade.ClientApp.Controls;

namespace Trade.ClientApp.BLLControls
{
    public partial class FormYuJing : Form
    {
        public FormYuJing(PriceData data, DataRowView view = null)
        {
            InitializeComponent();
            this.Icon = App.Logo;
            this.priceData = data;
            this.view = view;
        }

        private PriceData priceData;
        private DataRowView view;

        private void chkVoice_CheckedChanged(object sender, EventArgs e)
        {
            this.txtVoiceFileName.Enabled = this.btnSelectVoice.Enabled = this.chkVoice.Checked;
            if (!this.chkVoice.Checked)
            {
                this.txtVoiceFileName.Clear();
            }
        }

        private void btnSelectVoice_Click(object sender, EventArgs e)
        {
            if (opdFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtVoiceFileName.Text = opdFile.FileName;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.cboTimeScope.SelectedIndex = 0;
            this.cboType.SelectedIndex = 0;

            Application.DoEvents();

            if (this.view != null)
            {
                try
                {
                    int index = 0;
                    int.TryParse(this.view["YJLX"].ToString(), out index);
                    this.cboType.SelectedIndex = (index >= 0 ? index : 0);
                    if (index != 0)
                    {
                        int.TryParse(this.view["YJX"].ToString(), out index);
                        this.cboItem.SelectedIndex = (index >= 0 ? index : 0);
                    }
                    else
                    {
                        this.cboItem.SelectedValue = this.view["YJX"].ToString();
                    }
                    int.TryParse(this.view["YJTJ"].ToString(), out index);
                    this.cboFilter.SelectedIndex = (index >= 0 ? index : 0);
                    this.txtFaValue.Text = view["YJFZ"].ToString();

                    string value = view["YJFS"].ToString() + "00";
                    //e.Value = ((value[0] == '0' ? "弹出窗口" : "") + "/" + (value[1] == '0' ? "发出声音" : "")).Trim('/');
                    this.chkShowWindow.Checked = value[0] == '0';
                    this.chkVoice.Checked = value[1] == '0';
                    this.txtVoiceFileName.Text = (view["SYDZ"] != null) ? view["SYDZ"].ToString() : "";
                    this.chkIsValid.Checked = view["SFYX"].ToString() == "Y";
                }
                catch
                {
                }
            }
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cboItem.DataSource = null;

            if (cboType.SelectedIndex == 0)
            {
                this.cboItem.ValueMember = "CommodityID";
                this.cboItem.DisplayMember = "CommodityName";
                this.cboItem.DataSource = App.CurrentApp.Data.Commodity;
                this.cboFilter.DataSource = new string[] { "买价>", "买价=", "买价<", "卖价>", "卖价=", "卖价<" };
            }
            else if (cboType.SelectedIndex > 0)
            {
                this.cboItem.ValueMember = null;
                this.cboItem.DisplayMember = null;

                string[][] array = new string[][] { 
                    new string[] { "风险值" },
                    new string[] { "当前权益" },
                    new string[] { "可用保证金" }, 
                    new string[] { "总浮动盈亏" } 
                };
                this.cboItem.DataSource = array[this.cboType.SelectedIndex - 1];

                this.cboFilter.DataSource = new string[] { ">", "=", "<" };

            }
            this.lblBaiFenBi.Visible = (cboType.SelectedIndex == 1);
        }

        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtFaValue.Clear();
            if (this.cboType.SelectedIndex == 0)
            {
                string id = this.cboItem.SelectedValue as string;
                if (id != null && id.Trim().Length > 0)
                {
                    DataRow[] rows = this.priceData.HqTable.Select("[CommodityID]='" + id + "'");
                    if (rows != null && rows.Length > 0)
                    {
                        if (this.cboFilter.SelectedIndex < 3)
                        {
                            this.txtFaValue.Text = rows[0]["BuyPrice"] as string;
                        }
                        else
                        {
                            this.txtFaValue.Text = rows[0]["SellPrice"] as string;
                        }
                    }
                }
            }
        }



        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (this.dtpStartTime.Value.TimeOfDay > this.dtpEndTime.Value.TimeOfDay)
            {
                MessageBoxEx.Show("有效时间段设置有误,请确保开始时间小于终止", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(this.txtFaValue.Text) || this.txtFaValue.Text.Trim().Length < 1)
            {
                MessageBoxEx.Show("请确保您的阈值不为空!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double fvalue = 0;
            if (!double.TryParse(this.txtFaValue.Text, out fvalue))
            {
                return;
            }

            try
            {

                Context.yjRow row = this.view != null ? (Context.yjRow)this.view.Row : App.CurrentApp.YuJingInfo.CreateRow();
                row.YJLX = this.cboType.SelectedIndex.ToString();
                row.YJX = this.cboType.SelectedIndex == 0 ?
                    this.cboItem.SelectedValue.ToString() : this.cboItem.SelectedIndex.ToString();
                row.YJTJ = this.cboFilter.SelectedIndex.ToString();
                row.YJFZ = this.txtFaValue.Text.ToString();
                row.YJFS = (this.chkShowWindow.Checked ? "1" : "0") + (this.chkVoice.Checked ? "1" : "0");
                row.SYDZ = this.txtVoiceFileName.Text;
                row.YJYXSD = this.dtpStartTime.Value.ToString("HH:mm:ss") + "--" + this.dtpEndTime.Value.ToString("HH:mm:ss");
                row.SFYX = this.chkIsValid.Checked ? "Y" : "N";
                row.XDSJD = this.cboTimeScope.SelectedIndex.ToString();
                row.CFCS = this.nuMaxRenum.Value.ToString();
                App.CurrentApp.YuJingInfo.UpdateRow(row);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("预警设置失败!" + ex.Message, "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }




    }
}
