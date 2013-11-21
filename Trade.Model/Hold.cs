using System;

namespace Trade.Model
{
    /// <summary>
    /// Holds:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Hold
    {
        public Hold()
        { }
        #region Model
        private int _id;
        private DateTime _settledate;
        private string _goods;
        private string _holdno;
        private decimal _holdamount;
        private decimal _holdprice;
        private decimal _buyprice;
        private decimal _dealprice;
        private decimal _holdprofitloss;
        private decimal _holdbailrate;
        private decimal _holdemploy;
        private decimal _delaymoney;
        private DateTime _createtime;
        private string _createno;
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
        public string Goods
        {
            set { _goods = value; }
            get { return _goods; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string HoldNo
        {
            set { _holdno = value; }
            get { return _holdno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal HoldAmount
        {
            set { _holdamount = value; }
            get { return _holdamount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal HoldPrice
        {
            set { _holdprice = value; }
            get { return _holdprice; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal BuyPrice
        {
            set { _buyprice = value; }
            get { return _buyprice; }
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
        public decimal HoldProfitLoss
        {
            set { _holdprofitloss = value; }
            get { return _holdprofitloss; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal HoldBailRate
        {
            set { _holdbailrate = value; }
            get { return _holdbailrate; }
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
        public decimal DelayMoney
        {
            set { _delaymoney = value; }
            get { return _delaymoney; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateTime
        {
            set { _createtime = value; }
            get { return _createtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CreateNo
        {
            set { _createno = value; }
            get { return _createno; }
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
