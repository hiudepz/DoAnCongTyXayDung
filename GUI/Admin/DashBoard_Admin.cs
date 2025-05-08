using GUI.Report;
using GUI.User;
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
    public partial class DashBoard_Admin : Form
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

        private void nhancongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanCong_Admin a = new NhanCong_Admin();



            a.MdiParent = this;
            a.Show();
        }

        private void tiendoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TienDo_Admin a = new TienDo_Admin();



            a.MdiParent = this;
            a.Show();
        }

        private void reportDanhSachVatTuVaTongChiPhiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportDanhSachVatTuVaTongChiPhi a = new reportDanhSachVatTuVaTongChiPhi();
            a.MdiParent = this;
            a.Show();
        }

        private void bảngBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baocao a = new Baocao();
            a.MdiParent = this;
            a.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ds = MessageBox.Show("Bạn có muốn quay về trang đăng nhập", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ds == DialogResult.Yes)
            {
                // Hiển thị lại form Login
                this.Hide();
                new Login().Show();
            }
        }
    }
}
