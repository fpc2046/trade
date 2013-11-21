using System;
using System.Windows.Forms;
using Trade.ClientApp.ClientService;

namespace Trade.ClientApp.BLL
{
    internal class PriceListenor
    {
        internal PriceListenor(Timer timer, Session session)
        {
            if (timer == null)
            {
                throw new Exception("timer不能为空");
            }
            this._timer = timer;
            this._session = session;

            this._timer.Interval = this._timerSpan;
            this._timer.Tick += new EventHandler(timer_Tick);

            this._service = new ClientSrv();
            if (!string.IsNullOrEmpty(Program.ServiceUrl))
            {
                this._service.Url = Program.ServiceUrl;
            }
            this._service.CookieContainer = (session == null ? null : session.Cookie);
            this._service.GetPriceCompleted += new GetPriceCompletedEventHandler(Service_GetPriceCompleted);
        }

        public event Action<string> Errored;
        public event Action<string> Exceptioned;

        private ClientSrv _service;
        private PriceData priceDatas;
        private Session _session;
        private Timer _timer;
        private int _version = 0;
        private bool _enable = false;
        private int _timerSpan = 1000;

        public PriceData PriceDatas
        {
            get { return priceDatas; }
            set { priceDatas = value; }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this._timer.Stop();
            if (this._enable)
            {
                this._service.GetPriceAsync(this._version, new object());
            }
        }

        private void Service_GetPriceCompleted(object sender, GetPriceCompletedEventArgs e)
        {
            this._timer.Interval = this._timerSpan;
            if (!_enable || e.Cancelled)
            {
                return;
            }
            if (e.Error != null)
            {
                this.OnExceptioned(e.Error);
                return;
            }

            if (e.Result == null)
            {
                this._timer.Start();
                return;
            }

            if (!string.IsNullOrEmpty(e.Result.Error))
            {
                this.OnErrored(e.Result.Error);
            }
            else
            {
                this._version = e.Result.Version;
                this.OnPricesChanged(e.Result.Value);
            }
            if (this._enable)
            {
                this._timer.Start();
            }
        }

        private void OnExceptioned(Exception ex)
        {
            this._timer.Interval = 5000;
            this._timer.Start();
            if (this.Exceptioned != null)
            {
                this.Exceptioned(ex.Message);
            }
        }

        private void OnErrored(string error)
        {
            if (this.Errored != null)
            {
                this.Errored(error);
            }
        }

        private void OnPricesChanged(string[] prices)
        {
            if (prices == null || prices.Length < 1)
            {
                return;
            }
            if (this.priceDatas != null)
            {
                this.priceDatas.UpdateRows(prices);
            }
        }

        internal void BeginGetPrice()
        {
            this._enable = true;
            this._service.GetPriceAsync(this._version, new object());
        }

        internal void EndGetPrice()
        {
            this._enable = false;
        }
    }



}
