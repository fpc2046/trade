using System;

namespace Trade.Model
{
    /// <summary>
    /// BankAccountFound:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class BankAccountFound
    {
        public BankAccountFound()
        { }
        #region Model
        private int _id;
        private string _loginname;
        private string _account;
        private string _bankname;
        private string _accountproperty;
        private decimal _qcqy;
        private decimal _drcrj;
        private decimal _dqzdkcje;
        private decimal _ztzj;
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
        public string Account
        {
            set { _account = value; }
            get { return _account; }
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
        public string AccountProperty
        {
            set { _accountproperty = value; }
            get { return _accountproperty; }
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
        public decimal DRCRJ
        {
            set { _drcrj = value; }
            get { return _drcrj; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal DQZDKCJE
        {
            set { _dqzdkcje = value; }
            get { return _dqzdkcje; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal ZTZJ
        {
            set { _ztzj = value; }
            get { return _ztzj; }
        }
        #endregion Model

    }
}
