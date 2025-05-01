using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Admin
{
    public partial class DashBoard_Admin: Form
    {
        public DashBoard_Admin()
        {
            InitializeComponent();
        }

        private void congtrinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CongTrinh_Admin a = new CongTrinh_Admin();
            a.MdiParent = this;
            a.Show();
        }

        private void nhathauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhaThau_Admin a = new NhaThau_Admin();
            a.MdiParent = this;
            a.Show();
        }

        private void vattuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VatTu_Admin a = new VatTu_Admin();
            a.MdiParent = this;
            a.Show();
        }

        private void reportNhaThauCongTrinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportNTCT a = new reportNTCT();
            a.MdiParent = this;
            a.Show();
        }

        private void tiendoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           TienDo_Admin a = new TienDo_Admin();
            a.MdiParent = this;
            a.Show();
        }
    }
}
