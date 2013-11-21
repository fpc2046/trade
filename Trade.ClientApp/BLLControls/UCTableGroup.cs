using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Trade.ClientApp.BLLControls
{
    public partial class UCTableGroup : UserControl
    {
        public UCTableGroup()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.tabPage1.Tag = this.ucFunction21;
            this.tableGroup.Tag = this.ucFunction21;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (this.DesignMode)
            {
                return;
            }
            try
            {
                Form mainForm = this.FindForm();
                mainForm.KeyDown -= new KeyEventHandler(mainForm_KeyDown);
                mainForm.KeyDown += new KeyEventHandler(mainForm_KeyDown);
            }
            catch
            {
            }
        }

        private void mainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.IsDisposed || !this.Visible)
            {
                Form mainForm = sender as Form;
                if (mainForm != null)
                {
                    mainForm.KeyDown -= new KeyEventHandler(mainForm_KeyDown);
                }
                return;
            }
            switch (e.KeyCode)
            {
                case Keys.F2:
                    this.tableGroup.SelectedIndex = 0;
                    break;
                case Keys.F3:
                    this.tableGroup.SelectedIndex = 1;
                    break;
                case Keys.F4:
                    this.tableGroup.SelectedIndex = 2;
                    break;
                case Keys.F5:
                    this.tableGroup.SelectedIndex = 3;
                    break;
                case Keys.F6:
                    this.tableGroup.SelectedIndex = 4;
                    break;
                case Keys.F7:
                    this.tableGroup.SelectedIndex = 5;
                    break;
                case Keys.F8:
                    this.tableGroup.SelectedIndex = 6;
                    break;
                case Keys.F9:
                    this.tableGroup.SelectedIndex = 7;
                    break;
            }

        }

        private void UCTableGroup_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            MessageBox.Show(e.KeyCode.ToString());
        }

        private void tbcFunction_SelectedIndexChanged(object sender, EventArgs e)
        {
            Control curPage = this.tableGroup.Tag as Control;
            if (curPage != null)
            {
                curPage.Visible = false;
            }
            TabPage page = this.tableGroup.SelectedTab;

            if (page != null && (page.Tag as Control) == null)
            {
                switch (page.Text.Substring(0, 2))
                {
                    case "F2":
                        page.Tag = new UCFunction2();
                        break;
                    case "F3":
                        page.Tag = new UCFunction3();
                        break;
                    case "F4":
                        page.Tag = new UCFunction4();
                        break;
                    case "F5":
                        page.Tag = new UCFunction5();
                        break;
                    case "F6":
                        page.Tag = new UCFunction6();
                        break;
                    case "F7":
                        page.Tag = new UCFunction7();
                        break;
                    case "F8":
                        page.Tag = new UCFunction8();
                        break;
                    case "F9":
                        page.Tag = new UCFunction9();
                        break;
                }
                Control con = page.Tag as Control;
                con.Dock = DockStyle.Fill;
                page.Controls.Add(con);
            }
            if (page != null && page.Tag != null)
            {
                ((Control)page.Tag).Visible = true;
            }
            this.tableGroup.Tag = page == null ? null : page.Tag;
        }


    }
}
