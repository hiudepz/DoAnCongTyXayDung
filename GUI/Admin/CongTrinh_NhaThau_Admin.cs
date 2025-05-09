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
using static System.Net.Mime.MediaTypeNames;

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
            try
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
            }catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
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
            //dgvCT_NT_Admin.Columns["CongTrinh"].Visible = false;
            //dgvCT_NT_Admin.Columns["NhaThau"].Visible = false;
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
            //if (int.TryParse(dgvCT_NT_Admin.Rows[row].Cells[0].Value?.ToString(), out int idCT))
            //{
            //    cbbIdCT.SelectedValue = idCT; // Gán vào ComboBox sẽ tự hiển thị tên
            //}
            //cbbIdCT.Text = dgvCT_NT_Admin.Rows[row].Cells[0].Value?.ToString(); // Gán vào ComboBox sẽ tự hiển thị tên
            //cbbIdNT.Text = dgvCT_NT_Admin.Rows[row].Cells[1].Value?.ToString();
            //if (int.TryParse(dgvCT_NT_Admin.Rows[row].Cells[1].Value?.ToString(), out int idNT))
            //{
            //    cbbIdNT.SelectedValue = idNT;
            //}
            // Lấy ID từ DataGridView
            var tenCT = dgvCT_NT_Admin.Rows[e.RowIndex].Cells[0].Value?.ToString();
            var tenNT = dgvCT_NT_Admin.Rows[e.RowIndex].Cells[1].Value?.ToString();
            
            cbbIdCT.SelectedItem = b.LayDanhSachCongTrinh().FirstOrDefault(ct => ct.ten == tenCT);
            cbbIdNT.SelectedItem = b.LayDanhSachNhaThau().FirstOrDefault(nt => nt.ten_cong_ty == tenNT);
            txtVaitro.Text = dgvCT_NT_Admin.Rows[row].Cells[2].Value != null ? dgvCT_NT_Admin.Rows[row].Cells[2].Value.ToString() : "";
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var confirm = MessageBox.Show("Bạn có chắc chắn xóa","Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
                if (confirm == DialogResult.Yes)
                {


                    var dto = new CongTrinh_NhaThau
                    {
                        cong_trinh_id = (int)cbbIdCT.SelectedValue,
                        nha_thau_id = (int)cbbIdNT.SelectedValue,
                        vai_tro = txtVaitro.Text
                    };

                    if (b.XoaNhaThauVaoCongTrinh(dto))
                    {
                        MessageBox.Show("Xóa thành công!");
                        dgvCT_NT_Admin.DataSource = b.LayDanhSachCTNT();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi "+ ex.Message,"Thông báo");
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                var existing = new CongTrinh_NhaThau
                {
                    cong_trinh_id = (int)cbbIdCT.SelectedValue,
                    nha_thau_id = (int)cbbIdNT.SelectedValue,
                    vai_tro = txtVaitro.Text
                };

                if(existing != null)
                {
                    b.SuaNhaThauVaCongTrinh(existing);
                    MessageBox.Show("Cập nhật thành công");
                    dgvCT_NT_Admin.DataSource = b.LayDanhSachCTNT();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void txtKeywordcongtrinh_admin_TextChanged(object sender, EventArgs e)
        {
            LoadTienDo(txtKeywordcongtrinh_admin.Text.Trim());
        }
        private void LoadTienDo(string keyword = "")
        {
            List<DTO_CongTrinh_NhaThau> ds = b.GetAllTK(keyword);
            dgvCT_NT_Admin.DataSource = ds;
        }
    }
}
