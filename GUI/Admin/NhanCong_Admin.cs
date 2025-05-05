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

namespace GUI.Admin
{
    
    public partial class NhanCong_Admin: Form
    {
        private BLL_NhanCong_Admin bll = new BLL_NhanCong_Admin();  
        public NhanCong_Admin()
        {
            InitializeComponent();
        }

        private void NhanCong_Admin_Load(object sender, EventArgs e)
        {
            dgvNhancong_Admin.DataSource = bll.GetMemberList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(txtLuongNgay.Text, out decimal luongNgay))
                {
                    MessageBox.Show("Vui lòng nhập giá trị hợp lệ ( ví dụ : 2000.50)");
                    txtLuongNgay.Focus();
                    return;
                }
                var n = new NhanCong
                {
                    ho_ten = txtHoTen.Text,
                    chuc_vu = txtChucVu.Text,
                    luong_ngay = luongNgay,
                    so_dien_thoai = txtSDT.Text,
                 
                };

                if (bll.AddMember(n))
                {
                    MessageBox.Show("Thêm thành công!");
                    dgvNhancong_Admin.DataSource = bll.GetMemberList(); // Refresh DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhancong_Admin.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvNhancong_Admin.CurrentRow.Cells["id"].Value);
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (bll.DeleteMember(id))
                {
                    dgvNhancong_Admin.DataSource = bll.GetMemberList();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhancong_Admin.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng hợp lệ ");
                return;
            }

            try
            {
                // tryParse giá từ string sang decimal
                if (!decimal.TryParse(txtLuongNgay.Text, out decimal luongNgay))
                {
                    MessageBox.Show("Vui lòng nhập giá trị hợp lệ ( ví dụ : 2000.50)");
                    txtLuongNgay.Focus();
                    return;
                }

                int id = Convert.ToInt32(dgvNhancong_Admin.CurrentRow.Cells["id"].Value);

                var updated = new NhanCong
                {
                    id = id,
                    ho_ten = txtHoTen.Text,
                    chuc_vu = txtChucVu.Text,
                    luong_ngay = luongNgay,
                    so_dien_thoai = txtSDT.Text,
                };

                if (bll.UpdateMember(updated))
                {
                    MessageBox.Show("Cập nhật thành công!");
                    dgvNhancong_Admin.DataSource = bll.GetMemberList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
        }

        private void dgvNhancong_Admin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvNhancong_Admin.Rows.Count) return;

            DataGridViewRow row = dgvNhancong_Admin.Rows[e.RowIndex];

            // Gán dữ liệu từ DataGridView lên các control
            txtHoTen.Text = row.Cells["ho_ten"].Value?.ToString();
            txtChucVu.Text = row.Cells["chuc_vu"].Value?.ToString();
            txtLuongNgay.Text = row.Cells["luong_ngay"].Value?.ToString();
            txtSDT.Text = row.Cells["so_dien_thoai"].Value?.ToString();
            
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(tuKhoa))
            {
                // Nếu ô tìm kiếm bị xoá trắng → hiện danh sách gốc
                dgvNhancong_Admin.DataSource = bll.GetMemberList();
            }
            else
            {
                // Lọc theo từ khoá
                tuKhoa = txtTimKiem.Text.Trim();
                var ketQua = bll.TimKiem(tuKhoa);
                dgvNhancong_Admin.DataSource = ketQua;
            }
        }
    }
}
