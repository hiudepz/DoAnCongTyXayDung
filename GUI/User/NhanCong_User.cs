using BLL;
using DAL;
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
    public partial class NhanCong_User: Form
    {
        private BLL_NhanCong_Admin bll = new BLL_NhanCong_Admin();
        public NhanCong_User()
        {
            InitializeComponent();
        }


        private void dgvNhancong_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvNhancong_user.Rows.Count) return;

            DataGridViewRow row = dgvNhancong_user.Rows[e.RowIndex];

            // Gán dữ liệu từ DataGridView lên các control
            txtHoTen.Text = row.Cells["ho_ten"].Value?.ToString();
            txtChucVu.Text = row.Cells["chuc_vu"].Value?.ToString();
            txtLuongNgay.Text = row.Cells["luong_ngay"].Value?.ToString();
            txtSDT.Text = row.Cells["so_dien_thoai"].Value?.ToString();
        }

        private void NhanCong_User_Load(object sender, EventArgs e)
        {
            dgvNhancong_user.DataSource = bll.GetMemberList();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(tuKhoa))
            {
                // Nếu ô tìm kiếm bị xoá trắng → hiện danh sách gốc
                dgvNhancong_user.DataSource = bll.GetMemberList();
            }
            else
            {
                // Lọc theo từ khoá
                tuKhoa = txtTimKiem.Text.Trim();
                var ketQua = bll.TimKiem(tuKhoa);
                dgvNhancong_user.DataSource = ketQua;
            }
        }
    }
}
