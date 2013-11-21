using System;

namespace Trade.Model
{
    /// <summary>
    /// FundFlow:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public  class FundFlow
    {
    
        #region Model
        private int _id;
        private string _loginname;
        private int _flowid;
        private DateTime _happentime;
        private string _bankname;
        private decimal _outfund;
        private decimal _infund;
        private string _status;
        private string _remark;
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
        public string LoginName
        {
            set { _loginname = value; }
            get { return _loginname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int FlowID
        {
            set { _flowid = value; }
            get { return _flowid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime HappenTime
        {
            set { _happentime = value; }
            get { return _happentime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BankName
        {
            set { _bankname = value; }
            get { return _bankname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal OutFund
        {
            set { _outfund = value; }
            get { return _outfund; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal InFund
        {
            set { _infund = value; }
            get { return _infund; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Status
        {
            set { _status = value; }
            get { return _status; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        #endregion Model

    }
}
