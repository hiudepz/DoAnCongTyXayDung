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
using static System.Net.Mime.MediaTypeNames;


namespace GUI.Admin
{
    public partial class NhaThau_Admin: Form
    {
        private BLL_Nhathau_Admin  bll = new BLL_Nhathau_Admin();
        public NhaThau_Admin()
        {
            InitializeComponent();
        }

        private void NhaThau_Admin_Load(object sender, EventArgs e)
        {
            dgvNhathau_Admin.DataSource= bll.GetContractorList();
        }

        private void dgvNhathau_Admin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNhathau_Admin.DataSource == null || dgvNhathau_Admin.Rows.Count == 0 || dgvNhathau_Admin.CurrentCell == null)
            {
                MessageBox.Show("Không có dữ liệu để chọn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int row = dgvNhathau_Admin.CurrentCell.RowIndex;

            // Gán giá trị, nếu null thì dùng chuỗi rỗng ""
            txtMasothue_Admin.Text = dgvNhathau_Admin.Rows[row].Cells[0].Value != null ? dgvNhathau_Admin.Rows[row].Cells[0].Value.ToString() : "";
            txtTencongty_Admin.Text = dgvNhathau_Admin.Rows[row].Cells[1].Value != null ? dgvNhathau_Admin.Rows[row].Cells[1].Value.ToString() : "";
            txtMasothue_Admin.Text = dgvNhathau_Admin.Rows[row].Cells[2].Value != null ? dgvNhathau_Admin.Rows[row].Cells[2].Value.ToString() : "";
            txtDiachi_Admin.Text = dgvNhathau_Admin.Rows[row].Cells[3].Value != null ? dgvNhathau_Admin.Rows[row].Cells[3].Value.ToString() : "";
            txtNguoidaidiennhathau_Admin.Text = dgvNhathau_Admin.Rows[row].Cells[4].Value != null ? dgvNhathau_Admin.Rows[row].Cells[4].Value.ToString() : "";
            txtSdtnhathau_Admin.Text = dgvNhathau_Admin.Rows[row].Cells[5].Value != null ? dgvNhathau_Admin.Rows[row].Cells[5].Value.ToString() : "";
            txtEmailnhathau_Admin.Text = dgvNhathau_Admin.Rows[row].Cells[6].Value != null ? dgvNhathau_Admin.Rows[row].Cells[6].Value.ToString() : "";
        }

        private void btnThemnhathau_Admin_Click(object sender, EventArgs e)
        {
            try
            {
                var newConstruction = new NhaThau
                {
                    ten_cong_ty = txtTencongty_Admin.Text,
                    ma_so_thue  = txtMasothue_Admin.Text,
                    dia_chi = txtDiachi_Admin.Text,
                    nguoi_dai_dien = txtNguoidaidiennhathau_Admin.Text,
                    so_dien_thoai = txtSdtnhathau_Admin.Text,
                    email = txtEmailnhathau_Admin.Text,
                    
                };

                if (bll.AddContractor(newConstruction))
                {
                    MessageBox.Show("Thêm thành công!");
                    dgvNhathau_Admin.DataSource = bll.GetContractorList(); // Refresh DataGridView
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

      

        private void btnXoanhathau_Admin_Click_1(object sender, EventArgs e)
        {
            if (dgvNhathau_Admin.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvNhathau_Admin.CurrentRow.Cells["id"].Value);
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (bll.DeleteContractor(id))
                {
                    dgvNhathau_Admin.DataSource = bll.GetContractorList();
                }
            }
        }

        private void btnSuanhathau_Admin_Click_1(object sender, EventArgs e)
        {
            if (dgvNhathau_Admin.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn công trình cần sửa");
                return;
            }

            try
            {
                
                // Lấy ID từ dòng được chọn
                int id = Convert.ToInt32(dgvNhathau_Admin.CurrentRow.Cells["id"].Value);

                // Tạo đối tượng cập nhật
                var updated = new NhaThau
                {
                    id = id,
                    ten_cong_ty = txtTencongty_Admin.Text,
                    ma_so_thue = txtMasothue_Admin.Text,
                    dia_chi = txtDiachi_Admin.Text,
                    nguoi_dai_dien = txtNguoidaidiennhathau_Admin.Text,
                    so_dien_thoai = txtSdtnhathau_Admin.Text,

                    email = txtEmailnhathau_Admin.Text,

                };

                // Gọi BLL để cập nhật
                if (bll.UpdateContractor(updated))
                {
                    MessageBox.Show("Cập nhật thành công!");
                    // Load lại dữ liệu
                    dgvNhathau_Admin.DataSource = bll.GetContractorList();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy công trình để cập nhật");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = textBox7.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(tuKhoa))
            {
                // Nếu ô tìm kiếm bị xoá trắng → hiện danh sách gốc
                dgvNhathau_Admin.DataSource = bll.GetContractorList();
            }
            else
            {
                // Lọc theo từ khoá
                tuKhoa = textBox7.Text.Trim();
                var ketQua = bll.TimKiem(tuKhoa);
                dgvNhathau_Admin.DataSource = ketQua;
            }
        }
    }
}
