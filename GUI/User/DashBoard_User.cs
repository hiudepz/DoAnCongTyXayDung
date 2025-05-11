using GUI.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.User
{
    public partial class DashBoard_User: Form
    {
        public DashBoard_User()
        {
            InitializeComponent();
        }

        private void reportNhaThauCongTrinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //reportNTCT a = new reportNTCT();
            //a.MdiParent = this;
            //a.Show();
        }

        private void congtrinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CongTrinh_User a = new CongTrinh_User();
            a.MdiParent = this;
            a.Show();
        }

        private void nhathauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TienDo_User a = new TienDo_User();
            a.MdiParent = this;
            a.Show();
        }

        private void vattuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VatTu_User a = new VatTu_User();
            a.MdiParent = this;
            a.Show();
        }

        private void nhancongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanCong_User a = new NhanCong_User();
            a.MdiParent = this;
            a.Show();
        }

        

        private void tiendoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TienDo_User a = new TienDo_User();
            a.MdiParent = this;
            a.Show();
        }

        private void reportDanhSachVatTuVaTongChiPhiToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void bảngBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baocao a = new Baocao();
            a.MdiParent = this;
            a.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult  ds= MessageBox.Show("Bạn có muốn quay về trang đăng nhập","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if ( ds==DialogResult.Yes )
            {
                // Hiển thị lại form Login
                this.Hide();
                new Login().Show();
            }

            
        }
    }
}
