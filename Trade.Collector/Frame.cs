using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Data;
using Trade.Collector.Model;

namespace Trade.Collector
{
    internal class Frame
    {
        public Frame()
        {
            this.status = new Model.FrameStatus();
            this.status.Flags = FrameStatusFlags.NoConnected;
        }

        private Form mainForm;
        private Timer tmrMonitorFrame;
        private FrameStatus status;
        public event Action<DataTable> TableChanged;
        public event Action<DataRow> RowChanged;
        private DataTable priceTable;

        public DataTable PriceTable
        {
            get { return priceTable; }
        }

        public FrameStatus Status
        {
            get { return status; }
        }

        public void Show()
        {
            if (this.mainForm == null || this.mainForm.IsDisposed)
            {
                if (null == this.OnCreateMainFrom())
                {
                    MessageBox.Show("系统文件不存在或损坏,请重新安装");
                    return;
                }
            }
            LoginPlug plug = new LoginPlug();
            plug.StartMonitorLogin();
            this.StartMonitorFrame();
            this.mainForm.Show();
        }

        private Form OnCreateMainFrom()
        {
            try
            {
                Assembly asbFrame = Assembly.LoadFile(Application.StartupPath + "\\SysFrame.exe");
                Assembly asbBizComm = Assembly.LoadFile(Application.StartupPath + "\\BizComm.dll");

                object obj = System.Activator.CreateInstance(asbBizComm.GetType("BizComm.BizCommCenter"));
                asbFrame.GetType("SysFrame.Program").GetField("g_cBizCommCenter").SetValue(null, obj);

                Type mainFream = asbFrame.GetType("SysFrame.Frame");
                this.mainForm = (Form)System.Activator.CreateInstance(mainFream, new object[] { new string[0] });

                this.mainForm.FormClosed += new FormClosedEventHandler(mainForm_FormClosed);

                return this.mainForm;
            }
            catch
            {
                return null;
            }
        }

        #region GridData

        private void StartMonitorFrame()
        {
            if (this.tmrMonitorFrame == null)
            {
                this.tmrMonitorFrame = new Timer();
                this.tmrMonitorFrame.Interval = 5000;
                this.tmrMonitorFrame.Tick += new EventHandler(MonitorLogin_Tick);
            }
            this.tmrMonitorFrame.Start();
            this.status.Flags = FrameStatusFlags.Connecting;
        }

        private void MonitorLogin_Tick(object sender, EventArgs e)
        {
            Form mainFrom = this.mainForm;

            if (mainFrom != null && mainFrom.GetType().Name.Equals("Frame"))
            {
                DataGridView hqGrid = this.GetHQ_DataGrid(mainForm);

                if (hqGrid != null)
                {
                    this.OnDataGridViewChanged(hqGrid);
                }
            }
        }

        private DataGridView GetHQ_DataGrid(Control mainFrom)
        {
            if (mainForm != null)
            {
                List<Control> parents = new List<Control>(new Control[] { mainFrom });
                while (parents.Count > 0)
                {
                    List<Control> nextParents = new List<Control>();
                    foreach (Control con in parents)
                    {
                        if ("HQ_DataGrid".Equals(con.Name, StringComparison.CurrentCultureIgnoreCase)
                            && "DataGridView".Equals(con.GetType().Name, StringComparison.CurrentCultureIgnoreCase))
                        {
                            return con as DataGridView;
                        }
                        foreach (Control child in con.Controls)
                        {
                            nextParents.Add(child);
                        }
                    }
                    parents = nextParents;
                }
            }
            return null;
        }

        //获取到控件或控件改变
        private void OnDataGridViewChanged(DataGridView hqGrid)
        {
            DataTable hqtable = hqGrid.DataSource as DataTable;
            hqGrid.DataSourceChanged -= new EventHandler(OnGridSourceChanged);
            hqGrid.DataSourceChanged += new EventHandler(OnGridSourceChanged);

            this.OnTableChanged(hqtable);

            if (hqtable != null)
            {
                hqGrid.Disposed -= new EventHandler(mianFrom_GridDisposed);
                hqGrid.VisibleChanged -= new EventHandler(mianFrom_GridDisposed);

                hqGrid.Disposed += new EventHandler(mianFrom_GridDisposed);
                hqGrid.VisibleChanged += new EventHandler(mianFrom_GridDisposed);

                this.OnGridTableChanged(hqGrid, hqtable);

                this.tmrMonitorFrame.Stop();
            }
        }

        //数据源改变
        private void OnGridSourceChanged(object sender, EventArgs e)
        {
            DataGridView grid = sender as DataGridView;
            if (grid != null)
            {
                DataTable dt = grid.DataSource as DataTable;
                if (dt != null)
                {
                    this.OnGridTableChanged(grid, dt);
                }
            }
        }

        //获取到数据数据源改变
        private void OnGridTableChanged(DataGridView grid, DataTable dt)
        {
            if (grid == null || grid.IsDisposed || !grid.Visible)
            {
                return;
            }
            this.status.Flags = FrameStatusFlags.Connected;
            dt.RowChanged -= new DataRowChangeEventHandler(OnRowChanged);
            dt.RowChanged += new DataRowChangeEventHandler(OnRowChanged);
        }

        private void OnTableChanged(DataTable hqtable)
        {
            if (hqtable == null || hqtable.Rows.Count < 1)
            {
                this.status.Flags = FrameStatusFlags.NoConnected;
            }
            else
            {
                this.status.Flags = FrameStatusFlags.Connected;
            }

            this.priceTable = hqtable;

            if (this.TableChanged != null)
            {
                this.TableChanged(hqtable);
            }
        }

        private void OnRowChanged(object sender, DataRowChangeEventArgs e)
        {
            if (this.RowChanged != null)
            {
                this.RowChanged(e.Row);
            }
        }

        #endregion


        private void mianFrom_GridDisposed(object sender, EventArgs e)
        {
            DataGridView grid = sender as DataGridView;
            if (grid == null || grid.IsDisposed)
            {
                this.status.Flags = FrameStatusFlags.Connecting;
                //待完善
                this.StartMonitorFrame();
            }
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.tmrMonitorFrame.Dispose();
            this.tmrMonitorFrame = null;
            this.status.Flags = FrameStatusFlags.Closed;
        }

    }
}
