using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Trade.ClientApp.BLL;

namespace Trade.ClientApp.BLLControls
{
    public partial class UCFunction7 : UserControl
    {
        public UCFunction7()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);


            if (App.CurrentApp != null && App.CurrentApp.Data != null)
            {
                DataTable dt = App.CurrentApp.Data.Account;
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    ShowRow(row);
                }
            }
        }

        private void ShowRow(DataRow row)
        {
            DataTable dtnew = new DataTable();
            dtnew.Columns.AddRange(new DataColumn[]
                        { 
                            new DataColumn("key1"),
                            new DataColumn("value1"),
                            new DataColumn("key2"),
                            new DataColumn("value2"),
                        });
            dtnew.Rows.Add("帐户名称", row["AccountName"], "登录帐号", row["LoginName"]);
            dtnew.Rows.Add("期初权益", TableFormat.FormatDoubleN2(row["QCQY"]), "当前权益", TableFormat.FormatDoubleN2(row["DQQY"]));
            dtnew.Rows.Add("当日出入金", TableFormat.FormatDoubleN2(row["DRCRJ"]), "浮动盈亏", TableFormat.FormatDoubleN2(row["FDYK"]));
            dtnew.Rows.Add("当日平仓盈亏合计", TableFormat.FormatDoubleN2(row["DRPCYKHJ"]), "可用保证金", TableFormat.FormatDoubleN2(row["KYBZJ"]));
            dtnew.Rows.Add("当日手续费合计", TableFormat.FormatDoubleN2(row["DRSXFHJ"]), "占用保证金", TableFormat.FormatDoubleN2(row["ZYBZJ"]));
            dtnew.Rows.Add("上日延期费", TableFormat.FormatDoubleN2(row["SRYQF"]), "冻结保证金", TableFormat.FormatDoubleN2(row["DJBZJ"]));
            dtnew.Rows.Add("风险率", TableFormat.FormatDouble(row["FXL"], "P2"), "冻结手续费", row["DJSXF"]);
            dtnew.Rows.Add("帐号状态", row["ZHZT"], "", "");
            this.dataGridView1.DataSource = dtnew;
        }



    }
}
