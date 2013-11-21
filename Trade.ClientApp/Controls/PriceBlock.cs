using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using Trade.ClientApp.BLL;

namespace Trade.ClientApp.Controls
{
    /// <summary>
    /// 报价牌控件
    /// </summary>
    public class PriceBlock : Control
    {
        public PriceBlock()
            : base()
        {
            this.InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.ContainerControl, false);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.UserMouse, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.UseTextForAccessibility, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackgroundImage = Properties.Resources.priceblock_bg;

            this.centerFormat = new StringFormat();
            this.centerFormat.Alignment = StringAlignment.Center;
            this.centerFormat.LineAlignment = StringAlignment.Center;
            this.centerFormat.FormatFlags = StringFormatFlags.NoWrap | StringFormatFlags.NoClip;

            this.lefterFromat = new StringFormat();
            this.lefterFromat.Alignment = StringAlignment.Near;
            this.lefterFromat.LineAlignment = StringAlignment.Center;
            this.lefterFromat.FormatFlags = StringFormatFlags.NoWrap | StringFormatFlags.NoClip;

            this.brushARG = new Brush[] 
            {
                Brushes.Black,
                Brushes.Red,
                Brushes.Green,
            };
        }

        private string imageIndex;
        private string commodityName;
        private string commodityID;
        private string sellPrice;
        private string buyPrice;
        private string hightPrice;
        private string lowPrice;
        private string priceTime;
        private Image icon;
        private StringFormat centerFormat;
        private StringFormat lefterFromat;
        private char[] splitChar = new char[] { '.' };
        private Brush[] brushARG;


        public string CommodityName
        {
            get { return this.commodityName; }
        }

        public string CommodityID
        {
            get { return this.commodityID; }
        }

        protected override Size DefaultSize
        {
            get
            {
                return new Size(170, 119);
            }
        }

        protected override Padding DefaultMargin
        {
            get
            {
                return new Padding(15, 10, 5, 10); ;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.InterpolationMode = InterpolationMode.High;

            if (this.commodityName != null)
            {
                e.Graphics.DrawString(this.commodityName, this.Font, Brushes.White, new Rectangle(30, 7, 138, 16), this.centerFormat);
            }
            //e.Graphics.DrawRectangle(Pens.Red, new Rectangle(30, 5, 138, 17));

            if (this.icon != null)
            {
                e.Graphics.DrawImage(this.icon, new Rectangle(16, 63, icon.Width, icon.Height));
                e.Graphics.DrawImage(this.icon, new Rectangle(98, 63, icon.Width, icon.Height));
            }

            int imgIndex = PriceData.GetImageIndex(this.imageIndex);
            Brush curBrush = this.brushARG[imgIndex];

            string[] texts = this.GetValue(this.sellPrice);

            e.Graphics.DrawString(texts[0], this.Font, Brushes.Black, new Rectangle(34, 40, 46, 15), lefterFromat);
            e.Graphics.DrawString(texts[1], this.Font, curBrush, new Rectangle(34, 66, 46, 15), lefterFromat);

            //e.Graphics.DrawRectangle(Pens.Red, new Rectangle(34, 40, 46, 15));
            //e.Graphics.DrawRectangle(Pens.Red, new Rectangle(34, 66, 46, 15));

            texts = this.GetValue(this.buyPrice);

            e.Graphics.DrawString(texts[0], this.Font, Brushes.Black, new Rectangle(116, 40, 46, 15), lefterFromat);
            e.Graphics.DrawString(texts[1], this.Font, curBrush, new Rectangle(116, 66, 46, 15), lefterFromat);

            //e.Graphics.DrawRectangle(Pens.Red, new Rectangle(116, 40, 46, 15));
            //e.Graphics.DrawRectangle(Pens.Red, new Rectangle(116, 66, 46, 15));

            e.Graphics.DrawString("最高", this.Font, Brushes.Black, new Rectangle(7, 98, 40, 15), lefterFromat);
            e.Graphics.DrawString("最低", this.Font, Brushes.Black, new Rectangle(88, 98, 40, 15), lefterFromat);

            //e.Graphics.DrawRectangle(Pens.Red, new Rectangle(8, 98, 35, 15));
            //e.Graphics.DrawRectangle(Pens.Red, new Rectangle(90, 98, 35, 15));

            e.Graphics.DrawString(this.hightPrice, this.Font, this.brushARG[1], new Rectangle(39, 96, 42, 15), lefterFromat);
            e.Graphics.DrawString(this.lowPrice, this.Font, this.brushARG[2], new Rectangle(119, 96, 42, 15), lefterFromat);

            //e.Graphics.DrawRectangle(Pens.Red, new Rectangle(40, 96, 42, 15));
            //e.Graphics.DrawRectangle(Pens.Red, new Rectangle(122, 96, 42, 15));
        }

        private string[] GetValue(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return new string[] { "__", "__" };
            }
            value = value.Trim();
            int index = value.IndexOf('.');
            if (index > 0)
            {
                return new string[] { value.Substring(0, index + 1), value.Substring(index + 1) };
            }
            return new String[] { value + ".", "00" };
        }

        internal void Update(DataRow row)
        {
            this.icon = row["ColImage"] as Image;
            this.imageIndex = row["ColImageID"].ToString();
            this.commodityName = row["CommodityName"].ToString();
            this.commodityID = row["CommodityID"].ToString();
            this.sellPrice = row["SellPrice"].ToString();
            this.buyPrice = row["BuyPrice"].ToString();
            this.hightPrice = row["HightPrice"].ToString();
            this.lowPrice = row["LowPrice"].ToString();
            this.priceTime = row["PriceTime"].ToString();
            this.Invalidate();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // PriceBlock
            // 
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResumeLayout(false);

        }
    }
}
