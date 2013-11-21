using System;
using System.Collections.Generic;
using System.Text;

namespace Trade.Model
{
    /// <summary>
    /// TradeAccountFund:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public  class TradeAccountFund
    {
        public TradeAccountFund()
        { }
        #region Model
        private int _id;
        private string _tradeaccount;
        private decimal _qcqy;
        private decimal _drcrq;
        private decimal _dqkcje;
        private decimal _kybzj;
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
        public string TradeAccount
        {
            set { _tradeaccount = value; }
            get { return _tradeaccount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal QCQY
        {
            set { _qcqy = value; }
            get { return _qcqy; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal DRCRQ
        {
            set { _drcrq = value; }
            get { return _drcrq; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal DQKCJE
        {
            set { _dqkcje = value; }
            get { return _dqkcje; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal KYBZJ
        {
            set { _kybzj = value; }
            get { return _kybzj; }
        }
        #endregion Model

    }
}
