using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Trade.ClientApp.ClientService;

namespace Trade.ClientApp
{
    public partial class UcReport : UserControl
    {
        public UcReport()
        {
            InitializeComponent();
            dtpStart.Value = DateTime.Parse(DateTime.Now.ToString("yyyy/MM/") + "01");
            this.reportViewer1.LocalReport.DisplayName = "Report_Client";
        }

        public string _userNo = "183107001027301";

        public string _userName = "";

        private void BtnQueryClick(object sender, EventArgs e)
        {
            if (dtpEnd.Value < dtpStart.Value)
            {
                MessageBox.Show("开始日期不能大于结束日期!", "提示");
                return;
            }
            if ((dtpEnd.Value - dtpStart.Value).TotalDays > 31)
            {
                MessageBox.Show("查询时间段不能大于31天!", "提示");
                return;
            }
            
            btnQuery.Enabled = false;
            string condition = " UserNo='" + _userNo + "' " +
                               "and SettleDate>='" + dtpStart.Value.ToString("yyyy/MM/dd") + "' " +
                               "and SettleDate<='" + dtpEnd.Value.ToString("yyyy/MM/dd") + "'";
            
            
            reportViewer1.LocalReport.DataSources.Clear();
            var srv = new ClientSrv();
            if (!string.IsNullOrEmpty(Program.ServiceUrl))
            {
                srv.Url = Program.ServiceUrl;
            }
            var sales = srv.GetListSale(condition, "ID");
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsMain", new DataTable()));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1_Sales", sales));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1_Deals", srv.GetListDeal(condition, "ID")));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1_Holds", srv.GetListHold(condition, "ID")));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1_Funds", srv.GetListFund(condition, "ID")));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1_FundDetail", srv.GetListFundDetail(condition, "ID")));
            var salesVisible = new ReportParameter("SalesVisible");
            salesVisible.Values.Add(chkSales.Checked.ToString());

            var dealsVisible = new ReportParameter("DealsVisible");
            dealsVisible.Values.Add(chkDelas.Checked.ToString());

            var holdsVisible = new ReportParameter("HoldsVisible");
            holdsVisible.Values.Add(chkHold.Checked.ToString());

            var fundsVisible = new ReportParameter("FundsVisible");
            fundsVisible.Values.Add(chkFund.Checked.ToString());

            var fundDetailVisible = new ReportParameter("FundDetailVisible");
            fundDetailVisible.Values.Add(chkFundDetail.Checked.ToString());

            var userno = new ReportParameter("UserNo");
            userno.Values.Add(_userNo);

            var customNa = new ReportParameter("CustomNa");
            customNa.Values.Add(_userName);

            var startDate = new ReportParameter("StartDate");
            startDate.Values.Add(dtpStart.Value.ToString("yyyy-MM-dd"));

            var endDate = new ReportParameter("EndDate");
            endDate.Values.Add(dtpEnd.Value.ToString("yyyy-MM-dd"));

            reportViewer1.LocalReport.SetParameters(new[]
                                                        {
                                                            salesVisible, dealsVisible, holdsVisible, fundsVisible,
                                                            fundDetailVisible, userno, customNa, startDate, endDate
                                                        });
            reportViewer1.RefreshReport();
            reportViewer1.Refresh();
            btnQuery.Enabled = true;
        }

        private void BtnResetClick(object sender, EventArgs e)
        {
            dtpStart.Value = DateTime.Parse(DateTime.Now.ToString("yyyy/MM/") + "01");
            dtpEnd.Value = DateTime.Now;
            chkSales.Checked = true;
            chkDelas.Checked = true;
            chkHold.Checked = true;
            chkFund.Checked = true;
            chkFundDetail.Checked = true;
        }

    }
}
