using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using Trade.Collector.Model;
using Trade.Collector.ClientService;

namespace Trade.Collector
{
    internal class PriceUploader
    {
        public PriceUploader()
        {
            //status
            this.status = new UploadStatus();
            //compare
            this.compare = new PriceCompare();
            //service
            this.service = new ClientSrv();
            this.service.CookieContainer = new System.Net.CookieContainer();
            this.service.UpdatePricesCompleted += new UpdatePricesCompletedEventHandler(service_UpdatePricesCompleted);
        }

        public event Action<UploadStatus> IsStopChanged;
        public event Action<int> UpLoaded;

        private int upNum;
        private int upCount;

        private bool isStop = true;
        private int upSpan = 200;
        private Timer timer = null;
        private UploadStatus status;
        private PriceCompare compare;
        private ClientSrv service = null;

        private Dictionary<string, string> upQueueMust = new Dictionary<string, string>();
        private Dictionary<string, DataRow> upQueueDic = new Dictionary<string, DataRow>();

        private Dictionary<string, string> upHistoty = new Dictionary<string, string>();

        private void StartTimer()
        {
            if (this.timer == null)
            {
                this.timer = new Timer();
                timer.Interval = this.upSpan;
                timer.Tick += new EventHandler(QueueTimer_Tick);
            }
            if (!this.timer.Enabled)
            {
                this.timer.Enabled = true;
            }
        }

        private void QueueTimer_Tick(object sender, EventArgs e)
        {
            this.UpLoadQueue();
            (sender as Timer).Stop();
        }

        /// <summary>
        /// 状态
        /// </summary>
        public UploadStatus Status
        {
            get { return status; }
        }

        /// <summary>
        /// 是否已停止上传
        /// </summary>
        public bool IsStop
        {
            get { return this.isStop; }
            set
            {
                if (this.isStop != value)
                {
                    this.isStop = value;
                    if (this.IsStopChanged != null)
                    {
                        this.IsStopChanged(this.status);
                    }
                }
            }
        }

        /// <summary>
        /// 上传数据数
        /// </summary>
        public int UpCount
        {
            get { return upCount; }
        }
        /// <summary>
        /// 上传次数
        /// </summary>
        public int UpNum
        {
            get { return upNum; }
        }

        /// <summary>
        /// 排队更新行情表
        /// </summary>
        /// <param name="table"></param>
        /// <param name="compare">是否对比,如果为true,值改变才会引发更新</param>
        public void QueueUpdate(DataTable table, bool compare = false)
        {
            foreach (DataRow row in table.Rows)
            {
                this.QueueUpdate(row, compare);
            }
        }

        /// <summary>
        /// 排队更新一行
        /// </summary>
        /// <param name="row"></param>
        /// <param name="compare">是否对比,如果为true,值改变才会引发更新</param>
        public void QueueUpdate(DataRow row, bool compare)
        {
            this.StartTimer();

            string key = this.compare.GetRowName(row);
            if (!compare)
            {
                //强制下次更新,无需对比
                this.upQueueMust[key] = key;
            }
            //加入更新列表
            upQueueDic[key] = row;
        }

        private void UpLoadQueue()
        {
            if (this.isStop)
            {
                return;
            }

            Dictionary<string, string> needUpdate = new Dictionary<string, string>();

            foreach (KeyValuePair<string, DataRow> pair in this.upQueueDic)
            {
                bool mustUp = this.upQueueMust.ContainsKey(pair.Key);
                string newValue = this.compare.RowToString(pair.Value);
                if (mustUp ||
                    this.compare.IsChanged(newValue, upHistoty.ContainsKey(pair.Key) ? upHistoty[pair.Key] : string.Empty))
                {
                    needUpdate[pair.Key] = newValue;
                }
            }
            this.upQueueDic.Clear();
            this.upQueueMust.Clear();
            string[] upDatas = new string[needUpdate.Count];
            int index = 0;
            foreach (KeyValuePair<string, string> pair in needUpdate)
            {
                upDatas[index++] = pair.Value;
                this.upHistoty[pair.Key] = pair.Value;
            }

            if (upDatas.Length > 0)
            {
                this.UpLoad(upDatas);
            }
        }

        private void UpLoad(string[] rows)
        {
            if (rows != null && rows.Length > 0)
            {
                this.upNum++;
                this.upCount += rows.Length;
                this.service.UpdatePricesAsync(rows, new object());
                if (this.UpLoaded != null)
                {
                    this.UpLoaded(rows.Length);
                }
            }

        }

        private void service_UpdatePricesCompleted(object sender, UpdatePricesCompletedEventArgs e)
        {
            this.StartTimer();
            bool errorMax = this.status.Set(e.Error,
                (e.Error == null ? e.Result : null));
            this.IsStop = errorMax;
        }

    }
}
