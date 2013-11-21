using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Drawing;
using System.Data;

namespace Trade.ClientApp.BLL
{
    public class PriceData
    {
        public static PriceData Current { get; private set; }

        public PriceData()
        {
            this.hqDic = new Dictionary<string, DataRow>();
            this.hqText = new Dictionary<string, string>();
            PriceData.Current = this;
            this.images = new Image[] { 
                Properties.Resources.arr0,
                Properties.Resources.arr1,
                Properties.Resources.arr2,
            };
            this.hqTable = new DataTable();
            this.hqTable.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ColImage",typeof(Image)),
                new DataColumn("ColImageID"),
                new DataColumn("CommodityName"),
                new DataColumn("SellPrice"),
                new DataColumn("BuyPrice"),
                new DataColumn("HightPrice"),
                new DataColumn("LowPrice"),
                new DataColumn("PriceTime"),
                new DataColumn("CommodityID")
            });

        }

        public event Action<DataRow> RowAdded;
        public event Action<DataRow> RowUpdated;

        private Image[] images;
        private DataTable hqTable;
        private bool finished = false;
        private Dictionary<string, string> hqText;
        private Dictionary<string, DataRow> hqDic;

        public DataTable HqTable
        {
            get
            {
                return hqTable;
            }
        }

        public void InitRow()
        {
            if (App.CurrentApp.Data == null || App.CurrentApp.Data.Commodity == null)
            {
                return;
            }
            foreach (DataRow row in App.CurrentApp.Data.Commodity.Rows)
            {
                string name = row["CommodityName"].ToString();
                string id = row["CommodityID"].ToString();
                string value = string.Format("R@{0}@--@--@--@--@--@{1}", (name ?? string.Empty).Trim(), id);
                this.hqText[id] = string.Format("A@{0}@--@--@--@--@--@{1}", (name ?? string.Empty).Trim(), id);
                this.AddRow(value);
            }
        }

        public void EndInitRow()
        {
            this.finished = true;
            List<string> values = new List<string>();
            foreach (string text in this.hqText.Values)
            {
                values.Add(text);
            }
            foreach (string text in values)
            {
                this.UpdateRow(text);
            }
        }

        private void AddRow(string value)
        {
            int colcount = this.hqTable.Columns.Count;
            string[] cells = value.Split('@');
            string name = cells[7];
            int imageIndex = Math.Max(0, "ARG".IndexOf(cells[0][0]));

            DataRow row = this.hqTable.NewRow();
            row[0] = this.images[imageIndex];
            for (int i = 0; i < colcount - 1; i++)
            {
                row[i + 1] = cells[i];
            }
            this.hqTable.Rows.Add(row);
            this.hqDic[name] = row;

            if (this.RowAdded != null)
            {
                this.RowAdded(row);
            }
        }

        public void UpdateRow(string value)
        {
            int colcount = this.hqTable.Columns.Count;
            string[] cells = value.Split('@');
            string name = cells[7];
            this.hqText[name] = value;

            if (!this.finished)
            {
                cells[0] = "R";
            }

            DataRow row = null;
            if (!this.hqDic.TryGetValue(name, out row))
            {
                return;
            }
            else if (row == null ||
                row.RowState == (DataRowState.Deleted) || row.RowState == (DataRowState.Detached))
            {
                this.AddRow(value);
            }
            else
            {
                int same = 0;
                for (int i = 0; i < colcount - 1; i++)
                {
                    if (cells[i].Equals(row[i + 1]))
                    {
                        same++;
                    }
                }
                if (same != colcount)
                {
                    int imageIndex = Math.Max(0, "ARG".IndexOf(cells[0][0]));
                    row[0] = this.images[imageIndex];
                    for (int i = 0; i < colcount - 1; i++)
                    {
                        if (i == 1)
                        {
                            //不改名字
                            continue;
                        }
                        row[i + 1] = cells[i];
                    }
                    if (this.RowUpdated != null)
                    {
                        this.RowUpdated(row);
                    }
                }
            }
        }

        public void UpdateRows(params string[] values)
        {
            if (values == null || values.Length < 1)
            {
                return;
            }
            foreach (string str in values)
            {
                this.UpdateRow(str);
            }
        }

        public static int GetImageIndex(string str)
        {
            return Math.Max(0, "ARG".IndexOf((str ?? "A").Trim()[0]));
        }

    }
}

