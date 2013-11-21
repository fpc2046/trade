using System;

namespace Trade.Model
{
    /// <summary>
    /// FundDetail:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class FundDetail
    {
        public FundDetail()
        { }
        #region Model
        private int _id;
        private DateTime _settledate;
        private decimal _beginrights;
        private decimal _inoutmoney;
        private decimal _saleprofitloss;
        private decimal _holdprofitloss;
        private decimal _commission;
        private decimal _delaymoney;
        private decimal _holdemploy;
        private decimal _endrights;
        private string _riskrate;
        public string UserNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime SettleDate
        {
            set { _settledate = value; }
            get { return _settledate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal BeginRights
        {
            set { _beginrights = value; }
            get { return _beginrights; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal InOutMoney
        {
            set { _inoutmoney = value; }
            get { return _inoutmoney; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal SaleProfitLoss
        {
            set { _saleprofitloss = value; }
            get { return _saleprofitloss; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal HoldProfitLoss
        {
            set { _holdprofitloss = value; }
            get { return _holdprofitloss; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal Commission
        {
            set { _commission = value; }
            get { return _commission; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal DelayMoney
        {
            set { _delaymoney = value; }
            get { return _delaymoney; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal HoldEmploy
        {
            set { _holdemploy = value; }
            get { return _holdemploy; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal EndRights
        {
            set { _endrights = value; }
            get { return _endrights; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RiskRate
        {
            set { _riskrate = value; }
            get { return _riskrate; }
        }
        #endregion Model

    }
}
