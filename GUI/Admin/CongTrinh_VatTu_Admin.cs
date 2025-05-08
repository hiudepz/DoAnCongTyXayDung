using BLL;
using DAL;
using DTO;
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
    public partial class CongTrinh_VatTu_Admin : Form
    {
        BLL_CT_VT_Admin b = new BLL_CT_VT_Admin();
        public CongTrinh_VatTu_Admin()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            decimal.TryParse(txtSoluong.Text, out decimal soLuong);
            decimal.TryParse(txtDongia.Text, out decimal donGia);

            DateTime ngaySuDung = dtpNgaysudung.Value;

            CongTrinh_VatTu dto = new CongTrinh_VatTu
            {
                cong_trinh_id = (int)cbbIdCT.SelectedValue,
                vat_tu_id = (int)cbbIdVT.SelectedValue,
                so_luong = soLuong,
                don_gia = donGia,
                ngay_su_dung = ngaySuDung
            };

            if (b.ThemVatTuVaoCongTrinh(dto))
            {
                MessageBox.Show("Thêm thành công");
                dgvCT_VT_Admin.DataSource = b.LayDanhSachCTVT();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void CongTrinh_VatTu_Admin_Load(object sender, EventArgs e)
        {
            cbbIdCT.DataSource = b.LayDanhSachCongTrinh();
            cbbIdCT.DisplayMember = "ten";
            cbbIdCT.ValueMember = "id";

            cbbIdVT.DataSource = b.LayDanhSachVatTu();
            cbbIdVT.DisplayMember = "ten";
            cbbIdVT.ValueMember = "id";

            cbbIdCT.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbIdVT.DropDownStyle = ComboBoxStyle.DropDownList;


            dgvCT_VT_Admin.DataSource = b.LayDanhSachCTVT();
            //dgvCT_VT_Admin.Columns["CongTrinh"].Visible = false;
            //dgvCT_VT_Admin.Columns["VatTu"].Visible = false;
            dtpNgaysudung.Format=DateTimePickerFormat.Custom;
            dtpNgaysudung.CustomFormat= "dd/MM/yy";
        }

        private void dgvCT_VT_Admin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCT_VT_Admin.DataSource == null || dgvCT_VT_Admin.Rows.Count == 0 || dgvCT_VT_Admin.CurrentCell == null)
            {
                MessageBox.Show("Không có dữ liệu để chọn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int row = dgvCT_VT_Admin.CurrentCell.RowIndex;

            // Gán giá trị, nếu null thì dùng chuỗi rỗng ""


            // Lấy ID từ dòng được chọn
           
                cbbIdCT.Text = dgvCT_VT_Admin.Rows[row].Cells[0].Value?.ToString(); // Gán vào ComboBox sẽ tự hiển thị tên
                cbbIdVT.Text = dgvCT_VT_Admin.Rows[row].Cells[0].Value?.ToString();
            
            txtSoluong.Text = dgvCT_VT_Admin.Rows[row].Cells[2].Value != null ? dgvCT_VT_Admin.Rows[row].Cells[2].Value.ToString() : "";
            txtDongia.Text = dgvCT_VT_Admin.Rows[row].Cells[3].Value != null ? dgvCT_VT_Admin.Rows[row].Cells[3].Value.ToString() : "";
            dtpNgaysudung.Text = dgvCT_VT_Admin.Rows[row].Cells[4].Value != null ? dgvCT_VT_Admin.Rows[row].Cells[4].Value.ToString() : "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cbbIdCT.SelectedValue == null || cbbIdVT.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ công trình và vật tư!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime ngaySuDung = dtpNgaysudung.Value;

            var dto = new CongTrinh_VatTu
            {
                cong_trinh_id = (int)cbbIdCT.SelectedValue,
                vat_tu_id = (int)cbbIdVT.SelectedValue,
                ngay_su_dung = ngaySuDung
            };

            if (b.XoaVatTuVaoCongTrinh(dto))
            {
                MessageBox.Show("Xóa thành công!");
                dgvCT_VT_Admin.DataSource = b.LayDanhSachCTVT();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cbbIdCT.SelectedValue == null || cbbIdVT.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ công trình và vật tư!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtSoluong.Text, out decimal soLuong) ||
                !decimal.TryParse(txtDongia.Text, out decimal donGia))
            {
                MessageBox.Show("Vui lòng nhập đúng số lượng và đơn giá!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime ngaySuDung = dtpNgaysudung.Value;

            var dto = new CongTrinh_VatTu
            {
                cong_trinh_id = (int)cbbIdCT.SelectedValue,
                vat_tu_id = (int)cbbIdVT.SelectedValue,
                so_luong = soLuong,
                don_gia = donGia,
                ngay_su_dung = ngaySuDung
            };

            if (b.SuaVatTuVaoCongTrinh(dto))
            {
                MessageBox.Show("Cập nhật thành công!");
                dgvCT_VT_Admin.DataSource = b.LayDanhSachCTVT();
            }
            else
            {
                MessageBox.Show("Hãy xóa bản ghi rồi thêm mới");
            }

        }

        private void txtKeywordcongtrinh_admin_TextChanged(object sender, EventArgs e)
        {
            LoadTienDo(txtKeywordcongtrinh_admin.Text.Trim());
        }
        private void LoadTienDo(string keyword = "")
        {
            List<DTO_CongTrinh_VatTu> ds = b.GetAllTK(keyword);
            dgvCT_VT_Admin.DataSource = ds;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
