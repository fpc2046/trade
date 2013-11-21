using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Trade.Collector.Model;

namespace Trade.Collector
{
    public partial class HQForm : Form
    {
        public HQForm()
        {
            InitializeComponent();

            this.priceUpload = new PriceUploader();
            this.priceUpload.IsStopChanged += new Action<UploadStatus>(priceUpload_IsStopChanged);
            this.priceUpload.UpLoaded += new Action<int>(priceUpload_UpLoaded);
            this.priceUpload.Status.ErrorAdded += new Action<UploadStatus>(Status_ErrorAdded);
            this.priceUpload.IsStop = false;

            //tradeFrame
            this.tradeFrame = new Frame();
            this.tradeFrame.Status.FlagsChanged += new Action<FrameStatus>(Status_FlagsChanged);
            this.tradeFrame.TableChanged += new Action<DataTable>(tradeFrame_TableChanged);
            this.tradeFrame.RowChanged += new Action<DataRow>(tradeFrame_RowChanged);
        }

        private int timerCount = 0;
        private Frame tradeFrame;
        private PriceUploader priceUpload;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Timer tmrLoad = new Timer();
            tmrLoad.Interval = 100;
            tmrLoad.Tick += new EventHandler((o, e2) =>
            {
                tmrLoad.Dispose();
                this.tradeFrame.Show();
            });
            tmrLoad.Start();
        }

        /// <summary>
        /// 主框架状态改变
        /// </summary>
        /// <param name="status"></param>
        private void Status_FlagsChanged(FrameStatus status)
        {
            this.txtFreamStatus.Text = status.FlagText;
        }

        private void priceUpload_IsStopChanged(UploadStatus obj)
        {
            this.txtUpStatus.Text = this.priceUpload.IsStop ? "已停止" : "正常";
        }

        private void priceUpload_UpLoaded(int obj)
        {
            this.txtUpCi.Text = this.priceUpload.UpNum.ToString();
            this.txtUpCount.Text = this.priceUpload.UpCount.ToString();
        }

        private void Status_ErrorAdded(UploadStatus obj)
        {
            this.txtErrorTotal.Text = obj.ErrorTotal.ToString();
            this.txtErrorCounte.Text = (obj.ErrorCountContinue + obj.ExceptionCountContinue).ToString();
            this.txtError.Text = (obj.ExceptionCountContinue > 0 && obj.LastException != null) ? obj.LastException.Message : obj.LastError;
        }



        /// <summary>
        /// 全量更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrUpAll_Tick(object sender, EventArgs e)
        {
            this.UpdateTable((++this.timerCount % 10 == 0));
        }

        //获取或丢失行情
        private void tradeFrame_TableChanged(DataTable dt)
        {
            this.Activate();
            this.UpdateTable(true);
            this.ucPriceTable1.SetDataTable(dt);
            if (dt != null)
            {
                this.tmrUpAll.Start();
            }
        }

        //全量上传行情
        private void UpdateTable(bool upAll)
        {
            if (this.tradeFrame.PriceTable != null)
            {
                this.priceUpload.QueueUpdate(this.tradeFrame.PriceTable, !upAll);
            }
        }

        //行改变时发生
        private void tradeFrame_RowChanged(DataRow row)
        {
            this.priceUpload.QueueUpdate(row, true);
        }

    }
}
