using System;

namespace Trade.Model
{
    /// <summary>
    /// Funds:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Fund
    {
        public Fund()
        { }
        #region Model
        private int _id;
        private DateTime _settledate;
        private string _no;
        private decimal _changemoney;
        private decimal _changedmoney;
        private string _relevanceno;
        private string _ctype;
        private DateTime _ctime;
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
        public string No
        {
            set { _no = value; }
            get { return _no; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal ChangeMoney
        {
            set { _changemoney = value; }
            get { return _changemoney; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal ChangedMoney
        {
            set { _changedmoney = value; }
            get { return _changedmoney; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RelevanceNo
        {
            set { _relevanceno = value; }
            get { return _relevanceno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CType
        {
            set { _ctype = value; }
            get { return _ctype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CTime
        {
            set { _ctime = value; }
            get { return _ctime; }
        }
        #endregion Model

    }
}
