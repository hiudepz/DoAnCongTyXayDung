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

namespace GUI.User
{
    public partial class NhaThau_User: Form
    {
        private BLL_Nhathau_Admin bll = new BLL_Nhathau_Admin();
        public NhaThau_User()
        {
            InitializeComponent();
        }

        private void NhaThau_User_Load(object sender, EventArgs e)
        {
            dgvNhathau_user.DataSource= bll.GetContractorList();
        }

        private void dgvNhathau_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNhathau_user.DataSource == null || dgvNhathau_user.Rows.Count == 0 || dgvNhathau_user.CurrentCell == null)
            {
                MessageBox.Show("Không có dữ liệu để chọn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int row = dgvNhathau_user.CurrentCell.RowIndex;

            // Gán giá trị, nếu null thì dùng chuỗi rỗng ""
            txtMasothue_user.Text = dgvNhathau_user.Rows[row].Cells[0].Value != null ? dgvNhathau_user.Rows[row].Cells[0].Value.ToString() : "";
            txtTencongty_user.Text = dgvNhathau_user.Rows[row].Cells[1].Value != null ? dgvNhathau_user.Rows[row].Cells[1].Value.ToString() : "";
            txtMasothue_user.Text = dgvNhathau_user.Rows[row].Cells[2].Value != null ? dgvNhathau_user.Rows[row].Cells[2].Value.ToString() : "";
            txtDiachi_user.Text = dgvNhathau_user.Rows[row].Cells[3].Value != null ? dgvNhathau_user.Rows[row].Cells[3].Value.ToString() : "";
            txtNguoidaidiennhathau_user.Text = dgvNhathau_user.Rows[row].Cells[4].Value != null ? dgvNhathau_user.Rows[row].Cells[4].Value.ToString() : "";
            txtSdtnhathau_user.Text = dgvNhathau_user.Rows[row].Cells[5].Value != null ? dgvNhathau_user.Rows[row].Cells[5].Value.ToString() : "";
            txtEmailnhathau_user.Text = dgvNhathau_user.Rows[row].Cells[6].Value != null ? dgvNhathau_user.Rows[row].Cells[6].Value.ToString() : "";
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = textBox7.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(tuKhoa))
            {
                // Nếu ô tìm kiếm bị xoá trắng → hiện danh sách gốc
                dgvNhathau_user.DataSource = bll.GetContractorList();
            }
            else
            {
                // Lọc theo từ khoá
                tuKhoa = textBox7.Text.Trim();
                var ketQua = bll.TimKiem(tuKhoa);
                dgvNhathau_user.DataSource = ketQua;
            }
        }
    }
}
