using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Trade.ClientApp.BLLControls
{
    public partial class FormAnnouncementItem : Form
    {
        public FormAnnouncementItem(DataRowView row)
        {
            InitializeComponent();
            try
            {
                this.Icon = App.Logo;

                this.lblfbjg.Text = row["Institution"].ToString();
                try
                {
                    this.lblfbsj.Text = Convert.ToDateTime(row["CreateTime"]).ToString("yyyy-MM-dd HH:mm:ss");
                    this.lblsxsj.Text = Convert.ToDateTime(row["Overtime"]).ToString("yyyy-MM-dd");
                }
                catch
                {
                }
                this.lblggzt.Text = row["Theme"].ToString();
                this.txtggnr.Text = (row["ContentText"].ToString() ?? string.Empty).Replace("\n", "\r\n");
            }
            catch
            {
            }
        }


    }
}
