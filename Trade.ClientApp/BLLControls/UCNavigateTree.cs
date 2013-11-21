using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Trade.ClientApp
{
    public partial class UCNavigateTree : TreeView
    {
        public UCNavigateTree()
        {
            this.ForeColor = Color.White;
            this.LineColor = Color.White;
            this.BackColor = Color.FromArgb(70, 130, 180);

            this.Indent = 25;
            this.ItemHeight = 30;
            this.DrawMode = TreeViewDrawMode.OwnerDrawText;

        }

        [DefaultValue(typeof(Color), "70，130，180")]
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
            }
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            if (this.SelectedNode != null)
            {
                this.SelectedNode = null;
                Application.DoEvents();
            }
        }

        protected override void OnDrawNode(DrawTreeNodeEventArgs e)
        {
            Color backcolor = (e.State & TreeNodeStates.Focused) == TreeNodeStates.Focused ? Color.FromArgb(51, 153, 255) : this.BackColor;
            using (Brush brush = new SolidBrush(backcolor))
            {
                e.Graphics.FillRectangle(brush, e.Bounds);
            }
            using (StringFormat sf = new StringFormat(StringFormatFlags.NoWrap))
            {
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString(e.Node.Text, this.Font, Brushes.White,
                    new RectangleF(e.Bounds.X, e.Bounds.Y + 1, e.Bounds.Width, e.Bounds.Height), sf);
            }
            base.OnDrawNode(e);
        }


        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
