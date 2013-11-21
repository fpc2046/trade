using System;

namespace Trade.Model
{
    /// <summary>
    /// Announcement:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Announcement
    {
        public Announcement()
        { }
        #region Model
        private int _id;
        private int _seriesnum;
        private string _institution;
        private string _theme;
        private string _contenttext;
        private DateTime _createtime;
        private DateTime _overtime;
        private string _username;
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
        public int SeriesNum
        {
            set { _seriesnum = value; }
            get { return _seriesnum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Institution
        {
            set { _institution = value; }
            get { return _institution; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Theme
        {
            set { _theme = value; }
            get { return _theme; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ContentText
        {
            set { _contenttext = value; }
            get { return _contenttext; }
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
        public DateTime Overtime
        {
            set { _overtime = value; }
            get { return _overtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }
        #endregion Model

    }
}
