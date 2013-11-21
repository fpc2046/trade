using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using Trade.Manager.Uitls;
using Trade.Manager.localhost;

namespace Trade.Manager.UcContorls
{
    public partial class UcImport : UserControl
    {
        public UcImport()
        {
            InitializeComponent();

            btnFile.Click += BtnFileClick;
            btnImport.Click += BtnImportClick;
        }

        private string _userno;

        /// <summary>
        /// 导入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnImportClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAccount.Text))
            {
                MessageBox.Show("请输入要导入的交易账号", "提示");
                txtAccount.Focus();
                return;
            }
            _file = txtFile.Text;
            _userno = txtAccount.Text;
            SetEnabled(false);
            var td = new Thread(Import);
            td.Start();
            
        }

        /// <summary>
        /// 
        /// </summary>
        private string _file;

        readonly List<Sale> _sales = new List<Sale>();
        readonly List<Deal> _deals = new List<Deal>();
        readonly List<Hold> _holds = new List<Hold>();
        readonly List<Fund> _funds = new List<Fund>();
        readonly List<FundDetail> _fundDetails = new List<FundDetail>();

        /// <summary>
        /// 
        /// </summary>
        private void Import()
        {
            var ds = LoadDataFromExcel(_file);
            if (ds == null || ds.Tables.Count == 0)
            {
                SetEnabled(true);
                return;
            }

            DataBinding(ds.Tables[0]);
            
            _sales.Clear();
            _deals.Clear();
            _holds.Clear();
            _funds.Clear();
            _fundDetails.Clear();

            int index = 5;
            //DataRow row3 = ds.Tables[0].Rows[index];
            //第3行
            //string userno =row3[4].ToString();
            //index += 4;
            DataRow row = ds.Tables[0].Rows[index];
            var errors = new StringBuilder();

            #region "平仓明细"

            while (!row[0].ToString().Equals("总计"))
            {
                try
                {
                    var sale = new Sale();
                    sale.ID = int.Parse(row[0].ToString());
                    sale.SettleDate = DateTime.Parse(TimerConverter.FormatTime(row[1].ToString()));
                    sale.SaleDate = DateTime.Parse(TimerConverter.FormatTime(row[6].ToString()));
                    sale.Goods = row[10].ToString();
                    sale.SaleNo = row[17].ToString();
                    sale.SaleAmount = int.Parse(row[22].ToString());
                    sale.SalePrice = decimal.Parse(row[26].ToString());
                    sale.HoldPrice = decimal.Parse(row[32].ToString());
                    sale.SaleProfitLoss = decimal.Parse(row[39].ToString());
                    sale.SaleCommission = decimal.Parse(row[43].ToString());
                    sale.BuyNo = row[50].ToString();
                    sale.BuyPrice = decimal.Parse(row[53].ToString());
                    sale.BuyTime = DateTime.Parse(TimerConverter.FormatTime(row[58].ToString()));
                    sale.SaleType = row[61].ToString();
                    sale.Direction = row[63].ToString();
                    sale.Operate = row[65].ToString();
                    sale.UserNo = _userno;
                    _sales.Add(sale);
                }
                catch (Exception ex)
                {
                    errors.Append(string.Format("[平仓明细]数据无效,行号:{0},{1}\r\n", (index + 1),ex.Message));
                }
                index += 1;
                row = ds.Tables[0].Rows[index];
            }

            #endregion

            #region "成交明细"

            index += 5;
            row = ds.Tables[0].Rows[index];
            while (!row[0].ToString().Equals("总计"))
            {
                try
                {
                    var deal = new Deal();
                    deal.ID = int.Parse(row[0].ToString());
                    deal.SettleDate = DateTime.Parse(TimerConverter.FormatTime(row[1].ToString()));
                    deal.DealNo = row[5].ToString();
                    deal.Goods = row[6].ToString();
                    deal.DealAmount = int.Parse(row[11].ToString());
                    deal.DealPrice = decimal.Parse(row[15].ToString());
                    deal.DealMoney = decimal.Parse(row[22].ToString());
                    deal.Commission = decimal.Parse(row[31].ToString());
                    deal.DealTime = DateTime.Parse(TimerConverter.FormatTime(row[36].ToString()));
                    deal.Direction = row[42].ToString();
                    deal.UserNo = _userno;

                    _deals.Add(deal);
                }
                catch (Exception ex)
                {
                    errors.Append(string.Format("[成交明细]数据无效,行号:{0},{1}\r\n", (index + 1), ex.Message));
                }
                index += 1;
                row = ds.Tables[0].Rows[index];
            }

            #endregion

            #region "持仓明细"

            index += 4;
            row = ds.Tables[0].Rows[index];
            while (!row[0].ToString().Equals("总计"))
            {
                try
                {
                    var hold = new Hold();
                    hold.ID = int.Parse(row[0].ToString());
                    hold.SettleDate = DateTime.Parse(TimerConverter.FormatTime(row[1].ToString()));
                    hold.Goods = row[6].ToString();
                    hold.HoldNo = row[11].ToString();
                    hold.HoldAmount = int.Parse(row[15].ToString());
                    hold.HoldPrice = decimal.Parse(row[19].ToString());
                    hold.BuyPrice = decimal.Parse(row[25].ToString());
                    hold.DealPrice = decimal.Parse(row[31].ToString());
                    hold.HoldProfitLoss = decimal.Parse(row[36].ToString());
                    hold.HoldBailRate = decimal.Parse(row[41].ToString());
                    hold.HoldEmploy = decimal.Parse(row[52].ToString());
                    hold.DelayMoney = decimal.Parse(row[57].ToString());
                    hold.CreateTime = DateTime.Parse(TimerConverter.FormatTime(row[61].ToString()));
                    hold.CreateNo = row[63].ToString();
                    hold.Direction = row[65].ToString();
                    hold.UserNo = _userno;
                    _holds.Add(hold);
                }
                catch (Exception)
                {
                    errors.Append(string.Format("[持仓明细]数据无效,行号:{0}\r\n", (index + 1)));
                }

                index += 1;
                row = ds.Tables[0].Rows[index];
            }

            #endregion

            #region "资金流水"

            index += 5;
            row = ds.Tables[0].Rows[index];
            while (!row[0].ToString().Equals("总计"))
            {
                try
                {
                    var fund = new Fund();

                    fund.ID = int.Parse(row[0].ToString());
                    fund.SettleDate = DateTime.Parse(TimerConverter.FormatTime(row[1].ToString()));
                    fund.No = row[5].ToString();
                    fund.ChangeMoney = decimal.Parse(row[8].ToString());
                    fund.ChangedMoney = decimal.Parse(row[16].ToString());
                    fund.RelevanceNo = row[24].ToString();
                    fund.CType = row[30].ToString();
                    fund.CTime = DateTime.Parse(TimerConverter.FormatTime(row[45].ToString()));
                    fund.UserNo = _userno;
                    _funds.Add(fund);
                }
                catch (Exception)
                {
                    errors.Append(string.Format("[资金流水]数据无效,行号:{0}\r\n", (index + 1)));
                }
                index += 1;
                row = ds.Tables[0].Rows[index];
            }

            #endregion

            #region "资金状况"

            index += 5;
            row = ds.Tables[0].Rows[index];
            while (!row[0].ToString().Equals("总计"))
            {
                try
                {
                    var funddetail = new FundDetail();
                    funddetail.ID = int.Parse(row[0].ToString());
                    funddetail.SettleDate = DateTime.Parse(TimerConverter.FormatTime(row[1].ToString()));
                    funddetail.BeginRights = decimal.Parse(row[5].ToString());
                    funddetail.InOutMoney = decimal.Parse(row[6].ToString());
                    funddetail.SaleProfitLoss = decimal.Parse(row[10].ToString());
                    funddetail.HoldProfitLoss = decimal.Parse(row[14].ToString());
                    funddetail.Commission = decimal.Parse(row[19].ToString());
                    funddetail.DelayMoney = decimal.Parse(row[26].ToString());
                    funddetail.HoldEmploy = decimal.Parse(row[32].ToString());
                    funddetail.EndRights = decimal.Parse(row[38].ToString());
                    funddetail.RiskRate = row[42].ToString();
                    funddetail.UserNo = _userno;
                    _fundDetails.Add(funddetail);
                }
                catch (Exception)
                {
                    errors.Append(string.Format("[资金状况]数据无效,行号:{0}\r\n", (index + 1)));
                }
                index += 1;
                row = ds.Tables[0].Rows[index];
            }

            #endregion

            if (errors.Length > 0)
                PrintMsg(errors.ToString());

            Print("从EXCEL读取完成.");
            Save();
        }

        /// <summary>
        /// 
        /// </summary>
        private void Save()
        {
            var srv = new ReportSrv();
            Print("开始导入数据库.[平仓明细]");
            {
                for (int i = 0; i < _sales.Count; i++)
                {
                    srv.AddSale(_sales[i]);
                }
            }
            Print("开始导入数据库.[成交明细]");
            {
                for (int i = 0; i < _deals.Count; i++)
                {
                    srv.AddDeal(_deals[i]);
                }
            }
            Print("开始导入数据库.[持仓明细]");
            {
                for (int i = 0; i < _holds.Count; i++)
                {
                    srv.AddHold(_holds[i]);
                }
            }
            Print("开始导入数据库.[资金流水]");
            {
                for (int i = 0; i < _funds.Count; i++)
                {
                    srv.AddFund(_funds[i]);
                }
            }
            Print("开始导入数据库.[资金状况]");
            {
                for (int i = 0; i < _fundDetails.Count; i++)
                {
                    srv.AddFundDetail(_fundDetails[i]);
                }
            }
            Print("导入完成");
            SetEnabled(true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        private delegate void PrintCallback(string msg);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        void Print(string msg)
        {
            if (labProcess.InvokeRequired)
            {
                PrintCallback cls = new PrintCallback(Print);
                labProcess.Invoke(cls, new object[] { msg });
            }
            else
            {
                labProcess.Text = msg;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        void PrintMsg(string msg)
        {
            if (labProcess.InvokeRequired)
            {
                PrintCallback cls = new PrintCallback(PrintMsg);
                rtxtMsg.Invoke(cls, new object[] { msg });
            }
            else
            {
                rtxtMsg.Text = msg;
            }
        }

        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dt"></param>
        private delegate void DataBindingCallback(DataTable dt);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dt"></param>
        void DataBinding(DataTable dt)
        {
            if(dgvMain.InvokeRequired)
            {
                DataBindingCallback cls = new DataBindingCallback(DataBinding);
                dgvMain.Invoke(cls, new object[] {dt});
            }
            else
            {
                dgvMain.DataSource = dt;
            }
        }

        private delegate void SetEnabledCallback(bool val);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        void SetEnabled(bool val)
        {
            if (btnImport.InvokeRequired)
            {
                SetEnabledCallback cls = new SetEnabledCallback(SetEnabled);
                btnImport.Invoke(cls, new object[] { val });
            }
            else
            {
                btnImport.Enabled = val;
            }
        }

        /// <summary>
        /// 选择文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFileClick(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                InitialDirectory = "c://",
                Filter = "*.*|*.xls|所有文件|*.*",
                RestoreDirectory = true,
                FilterIndex = 1
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = openFileDialog.FileName;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public DataSet LoadDataFromExcel(string filePath)
        {
            try
            {
                RegistryKey reg_TypeGuessRows = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Jet\4.0\Engines\Excel");
                reg_TypeGuessRows.SetValue("TypeGuessRows", 10000);
                string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath +
                                 ";Extended Properties='Excel 8.0;HDR=False;IMEX=1'";
                var oleConn = new OleDbConnection(strConn);
                oleConn.Open();
                const string sql = "SELECT * FROM  [Sheet1$]"; //可是更改Sheet名称，比如sheet2，等等   

                var oleDaExcel = new OleDbDataAdapter(sql, oleConn);
                var oleDsExcle = new DataSet();
                oleDaExcel.Fill(oleDsExcle, "Report_Client");
                oleConn.Close();
                return oleDsExcle;
            }
            catch (Exception err)
            {
                MessageBox.Show("数据绑定Excel失败!失败原因：" + err.Message, "提示信息",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }
    }
}
