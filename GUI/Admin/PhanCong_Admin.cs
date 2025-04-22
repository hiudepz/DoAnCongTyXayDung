using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI.Admin
{
    public partial class PhanCong_Admin: Form
    {
        BLL_PhanCong_Admin bll = new BLL_PhanCong_Admin();

        public PhanCong_Admin()
        {
            InitializeComponent();
        }

        private void LoadNhanCong(string tuKhoa = "")
        {
            var ds = bll.LayDanhSachNhanCong();

            if (!string.IsNullOrEmpty(tuKhoa))
            {
                ds = ds.Where(n => n.ho_ten.Contains(tuKhoa));
            }

            dgvPhanCong_admin.DataSource = ds.Select(n => new
            {
                Chon = false,
                n.id,
                n.ho_ten,
                n.chuc_vu,
                n.luong_ngay,
                n.so_dien_thoai
            }).ToList();
        }

        private void frmPhanCong_Load(object sender, EventArgs e)
        {
            cbCongTrinh.DataSource = bll.LayDanhSachCongTrinh().ToList();
            cbCongTrinh.DisplayMember = "ten";
            cbCongTrinh.ValueMember = "id";

            LoadNhanCong();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadNhanCong(txtTim.Text.Trim());
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            int congTrinhId = (int)cbCongTrinh.SelectedValue;
            DateTime tuNgay = dtpNgayBatDau.Value;
            DateTime denNgay = dtpNgayKetThuc.Value;

            foreach (DataGridViewRow row in dgvPhanCong_admin.Rows)
            {
                bool chon = Convert.ToBoolean(row.Cells["Chon"].Value);
                if (chon)
                {
                    int nhanCongId = Convert.ToInt32(row.Cells["id"].Value);

                    if (!bll.KiemTraPhanCong(congTrinhId, nhanCongId))
                    {
                        bll.PhanCong(congTrinhId, nhanCongId, tuNgay, denNgay);
                    }
                }
            }

            MessageBox.Show("Phân công hoàn tất!");
        }



    }
}
