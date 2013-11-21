using System;

namespace Trade.Model
{
    /// <summary>
    /// Sales:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Sale
    {
        public Sale()
        { }
        #region Model
        private int _id;
        private DateTime _settledate;
        private DateTime _saledate;
        private string _goods;
        private string _saleno;
        private int _saleamount;
        private decimal _saleprice;
        private decimal _holdprice;
        private decimal _saleprofitloss;
        private decimal _salecommission;
        private string _buyno;
        private decimal _buyprice;
        private DateTime _buytime;
        private string _saletype;
        private string _direction;
        private string _operate;

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
        public DateTime SaleDate
        {
            set { _saledate = value; }
            get { return _saledate; }
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
        public string SaleNo
        {
            set { _saleno = value; }
            get { return _saleno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int SaleAmount
        {
            set { _saleamount = value; }
            get { return _saleamount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal SalePrice
        {
            set { _saleprice = value; }
            get { return _saleprice; }
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
        public decimal SaleProfitLoss
        {
            set { _saleprofitloss = value; }
            get { return _saleprofitloss; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal SaleCommission
        {
            set { _salecommission = value; }
            get { return _salecommission; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BuyNo
        {
            set { _buyno = value; }
            get { return _buyno; }
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
        public DateTime BuyTime
        {
            set { _buytime = value; }
            get { return _buytime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SaleType
        {
            set { _saletype = value; }
            get { return _saletype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Direction
        {
            set { _direction = value; }
            get { return _direction; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Operate
        {
            set { _operate = value; }
            get { return _operate; }
        }
        #endregion Model

    }
}
