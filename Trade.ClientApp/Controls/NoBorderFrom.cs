using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Trade.ClientApp.Controls
{
    public partial class NoBorderFrom : Form
    {
        public NoBorderFrom()
        {
            InitializeComponent();
        }

        private int _radius = 5;

        [Description("获取或设置窗体上圆角半径"), Category("窗口样式扩展")]
        [DefaultValue(5)]
        public int Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }


        private bool canMove = true;
        [Description("获取或设置窗体是否可以拖动"), Category("窗口样式扩展")]
        [DefaultValue(true)]
        public bool CanMove
        {
            get { return canMove; }
            set { canMove = value; }
        }


        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Rectangle rect = this.ClientRectangle;
            IntPtr Rgn = Win32.CreateRoundRectRgn(rect.X, rect.Y, rect.Right, rect.Bottom, this._radius, this._radius);
            Win32.SetWindowRgn(this.Handle, Rgn, true);
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x201:
                    base.WndProc(ref m);
                    if (this.canMove)
                        this.BeginMove();
                    return;
                default :
                    base.WndProc(ref m);
                    break;
            }
 
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

        }


        public virtual void BeginMove()
        {
            Win32.ReleaseCapture();
            Win32.SendMessage(this.Handle, 0x0112, 0xF010 + 0x2, 0);
        }
    }
}
