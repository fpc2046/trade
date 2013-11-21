using System;

namespace Trade.Model
{
    /// <summary>
    /// Deals:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Deal
    {
        public Deal()
        { }
        #region Model
        private int _id;
        private DateTime _settledate;
        private string _dealno;
        private string _goods;
        private int _dealamount;
        private decimal _dealprice;
        private decimal _dealmoney;
        private decimal _commission;
        private DateTime _dealtime;
        private string _direction;
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
        public string DealNo
        {
            set { _dealno = value; }
            get { return _dealno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods
        {
            set { _goods = value; }
            get { return _goods; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int DealAmount
        {
            set { _dealamount = value; }
            get { return _dealamount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal DealPrice
        {
            set { _dealprice = value; }
            get { return _dealprice; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal DealMoney
        {
            set { _dealmoney = value; }
            get { return _dealmoney; }
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
        public DateTime DealTime
        {
            set { _dealtime = value; }
            get { return _dealtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Direction
        {
            set { _direction = value; }
            get { return _direction; }
        }
        #endregion Model

    }
}
