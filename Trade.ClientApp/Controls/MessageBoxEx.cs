using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Trade.ClientApp.Controls
{
    public partial class MessageBoxEx : Form
    {
        private string text;
        private string caption;
        private MessageBoxButtons buttons;
        private MessageBoxIcon icon;

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            MessageBoxEx form = new MessageBoxEx(text, caption, buttons, icon);
            return form.ShowDialog();
        }

        public MessageBoxEx()
        {
            InitializeComponent();
        }

        public MessageBoxEx(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon) :
            this()
        {
            // TODO: Complete member initialization
            this.text = text;
            this.caption = caption;
            this.buttons = buttons;
            this.icon = icon;

            this.Text = caption ?? string.Empty;
            this.label1.Text = text ?? string.Empty;

            if (this.buttons == MessageBoxButtons.OK)
            {
                this.btnCancel.Dispose();
                this.btnOK.Left = (this.ClientSize.Width - this.btnOK.Width) / 2;
                this.btnOK.Text = "确定";
            }
            else if (this.buttons == MessageBoxButtons.YesNo)
            {
                this.btnOK.Text = "是";
                this.btnCancel.Text = "否";
            }

            if (this.icon == MessageBoxIcon.Error)
            {
                this.pictureBox1.Image = Properties.Resources.MS_Error;
            }
            else if (this.icon == MessageBoxIcon.Warning)
            {
                this.pictureBox1.Image = Properties.Resources.MS_Warning;
            }
            else if (this.icon == MessageBoxIcon.Asterisk)
            {
                this.pictureBox1.Image = Properties.Resources.MS_Asterisk;
            }
            else if (this.icon == MessageBoxIcon.Information)
            {
                this.pictureBox1.Image = Properties.Resources.MS_Information;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (this.buttons == MessageBoxButtons.OKCancel)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
            else if (this.buttons == MessageBoxButtons.YesNo)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.No;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.buttons == MessageBoxButtons.YesNo)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Yes;
            }
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
    }
}
