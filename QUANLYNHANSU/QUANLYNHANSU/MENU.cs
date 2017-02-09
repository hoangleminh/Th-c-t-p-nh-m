using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QUANLYNHANSU
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void Quanly_Click(object sender, EventArgs e)
        {
            if (!PanelThaotac.Controls.Contains(QUANLY2.Instance))
            {
                PanelThaotac.Controls.Add(QUANLY2.Instance);
                QUANLY2.Instance.Dock = DockStyle.Fill;
                QUANLY2.Instance.BringToFront();
            }
            else
            {
                QUANLY2.Instance.BringToFront();
            }
        }

        private void Thongtin_Click(object sender, EventArgs e)
        {
            if (!PanelThaotac.Controls.Contains(THONGTIN.Instance))
            {
                PanelThaotac.Controls.Add(THONGTIN.Instance);
                THONGTIN.Instance.Dock = DockStyle.Fill;
                THONGTIN.Instance.BringToFront();
            }
            else
            {
                QUANLY2.Instance.BringToFront();
            }
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LOGOUT_Click(object sender, EventArgs e)
        {
            LOGIN frm1 = new LOGIN();
            frm1.Show();
            this.Close();
        }
    }
}
