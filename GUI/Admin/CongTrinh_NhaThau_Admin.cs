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
    public partial class CongTrinh_NhaThau_Admin : Form
    {
        BLL_CT_NT_Admin b = new BLL_CT_NT_Admin();
        public CongTrinh_NhaThau_Admin()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CongTrinh_NhaThau dto = new CongTrinh_NhaThau
            {
                cong_trinh_id = (int)cbbIdCT.SelectedValue,
                nha_thau_id = (int)cbbIdNT.SelectedValue,
                vai_tro = txtVaitro.Text
            };

            if (b.ThemNhaThauVaoCongTrinh(dto))
            {
                MessageBox.Show("Thêm thành công");
                dgvCT_NT_Admin.DataSource = b.LayDanhSachCTNT();
            }
               
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
                


        }

        private void CongTrinh_NhaThau_Admin_Load(object sender, EventArgs e)
        {
            cbbIdCT.DataSource = b.LayDanhSachCongTrinh();
            cbbIdCT.DisplayMember = "ten";
            cbbIdCT.ValueMember = "id";

            cbbIdNT.DataSource = b.LayDanhSachNhaThau();
            cbbIdNT.DisplayMember = "ten_cong_ty";
            cbbIdNT.ValueMember = "id";

            cbbIdCT.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbIdNT.DropDownStyle = ComboBoxStyle.DropDownList;


            dgvCT_NT_Admin.DataSource=b.LayDanhSachCTNT();
            dgvCT_NT_Admin.Columns["CongTrinh"].Visible = false;
            dgvCT_NT_Admin.Columns["NhaThau"].Visible = false;
        }

        private void dgvCT_NT_Admin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCT_NT_Admin.DataSource == null || dgvCT_NT_Admin.Rows.Count == 0 || dgvCT_NT_Admin.CurrentCell == null)
            {
                MessageBox.Show("Không có dữ liệu để chọn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int row = dgvCT_NT_Admin.CurrentCell.RowIndex;

            // Gán giá trị, nếu null thì dùng chuỗi rỗng ""
           

            // Lấy ID từ dòng được chọn
            if (int.TryParse(dgvCT_NT_Admin.Rows[row].Cells[0].Value?.ToString(), out int idCT))
            {
                cbbIdCT.SelectedValue = idCT; // Gán vào ComboBox sẽ tự hiển thị tên
            }

            if (int.TryParse(dgvCT_NT_Admin.Rows[row].Cells[1].Value?.ToString(), out int idNT))
            {
                cbbIdNT.SelectedValue = idNT;
            }

            txtVaitro.Text = dgvCT_NT_Admin.Rows[row].Cells[2].Value != null ? dgvCT_NT_Admin.Rows[row].Cells[2].Value.ToString() : "";
           
        }
    }
}
