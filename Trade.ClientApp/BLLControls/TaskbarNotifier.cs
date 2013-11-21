using System;
using System.Drawing;
using System.Windows.Forms;

namespace Trade.ClientApp.BLLControls
{
    public partial class TaskbarNotifier : Form
    {
        public TaskbarNotifier()
        {
            InitializeComponent();

            this.InitCloseButton();

            contentFormat = new StringFormat();
            contentFormat.Alignment = StringAlignment.Center;
            contentFormat.LineAlignment = StringAlignment.Center;
            contentFormat.FormatFlags = StringFormatFlags.MeasureTrailingSpaces;
            normalContentFont = new Font(this.Font.FontFamily, 11f, FontStyle.Regular, GraphicsUnit.Pixel);
        }
        private Font normalContentFont = null;
        private string contentText;

        protected override bool ShowWithoutActivation
        {
            get
            {
                return false;
            }
        }

        public void ShowNotifier(Control parent, string ip, string time)
        {
            this.contentText = "上次登录时间：" + time + "\r\n上次登录IP：" + ip;

            Rectangle rect = Screen.GetWorkingArea(parent);
            int num = 10;
            Timer timer = new Timer();
            timer.Interval = 70;
            timer.Tick += new EventHandler((o, e) =>
            {
                Size size = this.Size;
                this.Location = new Point(rect.Right - size.Width - 30, (rect.Bottom - (size.Height / num--)));
                this.Visible = true;
                if (num == 0)
                {
                    timer.Stop();

                    Timer timer2 = new Timer();
                    timer2.Interval = 5000;
                    timer2.Tick += new EventHandler((o2, e2) =>
                    {
                        timer2.Stop();
                        if (!this.IsDisposed)
                        {
                            int num3 = 1;
                            Timer timer3 = new Timer();
                            timer3.Interval = 70;
                            timer3.Tick += new EventHandler((o3, e3) =>
                            {
                                Size size3 = this.Size;
                                this.Location = new Point(rect.Right - size3.Width - 30, (rect.Bottom - (size3.Height / num3++)));
                                if (num3 >= 10)
                                {
                                    timer3.Stop();
                                    this.Close();
                                }
                            });
                            timer3.Start();
                        }
                    });
                    timer2.Start();
                }
            });
            timer.Start();

        }

        #region content

        private bool isHoverContent;
        private StringFormat contentFormat;

        private void lblContent_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, lblContent.Width, lblContent.Height);
            Color normalContentColor = Color.FromArgb(0, 0, 0);
            if (this.isHoverContent)
            {
                normalContentColor = Color.FromArgb(0, 0, 102);
                ControlPaint.DrawBorder3D(e.Graphics, rect, Border3DStyle.Etched, Border3DSide.Left | Border3DSide.Top | Border3DSide.Right | Border3DSide.Bottom);
            }
            if (!string.IsNullOrEmpty(this.contentText))
            {
                using (Brush brush = new SolidBrush(normalContentColor))
                {
                    e.Graphics.DrawString(this.contentText, normalContentFont, brush, rect, this.contentFormat);
                }
            }
        }

        private void lblContent_MouseLeave(object sender, EventArgs e)
        {
            this.isHoverContent = false;
            this.lblContent.Invalidate();
        }

        private void lblContent_MouseEnter(object sender, EventArgs e)
        {
            this.isHoverContent = true;
            this.lblContent.Invalidate();
        }
        #endregion

        #region closeButton

        private bool isDownClose;
        private bool isHoverClose;
        private Bitmap bmpCloseButton;

        private void InitCloseButton()
        {
            this.bmpCloseButton = Properties.Resources.taskNotifer_close_bg;
            Label lblClose = new Label();
            lblClose.BackColor = Color.Transparent;
            lblClose.SetBounds(180, 0, this.bmpCloseButton.Width / 3, this.bmpCloseButton.Height);
            lblClose.Paint += new PaintEventHandler(lblClose_Paint);
            lblClose.MouseEnter += new EventHandler(lblClose_MouseEnter);
            lblClose.MouseLeave += new EventHandler(lblClose_MouseLeave);
            lblClose.MouseDown += new MouseEventHandler(lblClose_MouseDown);
            lblClose.MouseUp += new MouseEventHandler(lblClose_MouseUp);
            lblClose.MouseClick += new MouseEventHandler(lblClose_MouseClick);
            this.Controls.Add(lblClose);
        }

        private void lblClose_MouseUp(object sender, MouseEventArgs e)
        {
            this.isDownClose = false;
            ((Label)sender).Invalidate();
        }

        void lblClose_MouseDown(object sender, MouseEventArgs e)
        {
            this.isDownClose = true;
            ((Label)sender).Invalidate();
        }

        private void lblClose_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            this.isHoverClose = false;
            ((Label)sender).Invalidate();
        }

        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            this.isHoverClose = true;
            ((Label)sender).Invalidate();
        }

        private void lblClose_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = ((Label)sender);
            int x = (this.isDownClose ? lbl.Width : 0) + (this.isHoverClose ? lbl.Width : 0);
            Rectangle destRect = new Rectangle(0, 0, lbl.Width, lbl.Height);
            Rectangle srcRect = new Rectangle(x, 0, lbl.Width, lbl.Height);
            e.Graphics.DrawImage(this.bmpCloseButton, destRect, srcRect, GraphicsUnit.Pixel);
        }
        #endregion

    }
}
