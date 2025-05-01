using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace GUI.Admin
{
    public partial class CongTrinh_Admin: Form
    {
        private BLL_Congtrinh_Admin ctrBLL = new BLL_Congtrinh_Admin();
        private BLL_Nhathau_Admin nhathau = new BLL_Nhathau_Admin();
        private BLL_Vattu_Admin vattu = new BLL_Vattu_Admin();
        public CongTrinh_Admin()
        {
            InitializeComponent();
        }

        private void CongTrinh_Admin_Load(object sender, EventArgs e)
        {
            //vattu but in contruction
            dgvVattubencongtrinh_admin.DataSource= vattu.GetMaterialList();
            dgvVattubencongtrinh_admin.Columns["id"].Visible = false;
            //Load nhathau's data to dgv
            dgvNhathaubencongtrinh_admin.DataSource = nhathau.GetContractorList();
            // hide the thing for who dont wants to know
            dgvNhathaubencongtrinh_admin.Columns["id"].Visible = false;
            dgvNhathaubencongtrinh_admin.Columns["dia_chi"].Visible = false;
            dgvNhathaubencongtrinh_admin.Columns["nguoi_dai_dien"].Visible = false;
            dgvNhathaubencongtrinh_admin.Columns["so_dien_thoai"].Visible = false;
            dgvNhathaubencongtrinh_admin.Columns["email"].Visible = false;

            // Đặt tên cột hiển thị (nếu cần)
            dgvNhathaubencongtrinh_admin.Columns["ten_cong_ty"].HeaderText = "Tên nhà thầu";
            dgvNhathaubencongtrinh_admin.Columns["ma_so_thue"].HeaderText = "Mã số thuế";

            // Định dạng cột (tuỳ chọn)
            dgvNhathaubencongtrinh_admin.Columns["ten_cong_ty"].Width = 150;
            dgvNhathaubencongtrinh_admin.Columns["ma_so_thue"].Width = 150;
            //cbbTrangthai_admin
            try
            {
                // Gọi BLL để lấy danh sách trạng thái
                List<string> danhSachContractor = nhathau.GetNameContractorList();

                // assign date to combobox
                cbbNhathaucongtrinh_admin.DataSource = danhSachContractor;

                // only choose no text
                cbbNhathaucongtrinh_admin.DropDownStyle = ComboBoxStyle.DropDownList;

                // pick the first value if need
                if (cbbNhathaucongtrinh_admin.Items.Count > 0)
                    cbbNhathaucongtrinh_admin.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách trạng thái: " + ex.Message,
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            //Load database to datagridview which has name dgvCongtrinh_admin
            dgvCongtrinh_admin.DataSource = ctrBLL.GetConstructionList();
            //hide the thing for who dont wants to know
            dgvCongtrinh_admin.Columns["ngay_hoan_thanh"].Visible = false;
            //Format datetimepicker 01/12/25
            dtpNgaybatdau_admin.Format = DateTimePickerFormat.Custom;
            dtpNgaybatdau_admin.CustomFormat = "dd/MM/yy";
            dtpNgayketthuc_admin.Format=DateTimePickerFormat.Custom;
            dtpNgayketthuc_admin.CustomFormat = "dd/MM/yy";
            //cbbTrangthai_admin
            try
            {
                // Gọi BLL để lấy danh sách trạng thái
                List<string> danhSachTrangThai = ctrBLL.GetStatusList();

                // assign date to combobox
                cbbTrangthai_admin.DataSource = danhSachTrangThai;

                // only choose no text
                cbbTrangthai_admin.DropDownStyle = ComboBoxStyle.DropDownList;

                // pick the first value if need
                if (cbbTrangthai_admin.Items.Count > 0)
                    cbbTrangthai_admin.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách trạng thái: " + ex.Message,
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void dgvCongtrinh_admin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCongtrinh_admin.DataSource == null || dgvCongtrinh_admin.Rows.Count == 0 || dgvCongtrinh_admin.CurrentCell == null)
            {
                MessageBox.Show("Không có dữ liệu để chọn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int row = dgvCongtrinh_admin.CurrentCell.RowIndex;

            // Gán giá trị, nếu null thì dùng chuỗi rỗng ""
            txtMacongtrinh_admin.Text = dgvCongtrinh_admin.Rows[row].Cells[0].Value != null ? dgvCongtrinh_admin.Rows[row].Cells[0].Value.ToString() : "";
            txtTencongtrinh_admin.Text = dgvCongtrinh_admin.Rows[row].Cells[1].Value != null ? dgvCongtrinh_admin.Rows[row].Cells[1].Value.ToString() : "";
            txtDiadiem_admin.Text = dgvCongtrinh_admin.Rows[row].Cells[2].Value != null ? dgvCongtrinh_admin.Rows[row].Cells[2].Value.ToString() : "";
            txtChudautu_admin.Text = dgvCongtrinh_admin.Rows[row].Cells[3].Value != null ? dgvCongtrinh_admin.Rows[row].Cells[3].Value.ToString() : "";
            dtpNgaybatdau_admin.Text = dgvCongtrinh_admin.Rows[row].Cells[4].Value != null ? dgvCongtrinh_admin.Rows[row].Cells[4].Value.ToString() : "";
            dtpNgayketthuc_admin.Text = dgvCongtrinh_admin.Rows[row].Cells[5].Value != null ? dgvCongtrinh_admin.Rows[row].Cells[5].Value.ToString() : "";
            cbbTrangthai_admin.Text = dgvCongtrinh_admin.Rows[row].Cells[7].Value != null ? dgvCongtrinh_admin.Rows[row].Cells[7].Value.ToString() : "";
            if (dgvCongtrinh_admin.Rows[row].Cells[8].Value != null &&
                 decimal.TryParse(dgvCongtrinh_admin.Rows[row].Cells[8].Value.ToString(), out decimal tongMucDauTu))
            {
                nudTongmucdautu_admin.Value = tongMucDauTu;
            }
            else
            {
                nudTongmucdautu_admin.Value = nudTongmucdautu_admin.Minimum; //or default value
            }
            // Lấy đường dẫn ảnh từ dòng được chọn
            string imagePath = dgvCongtrinh_admin.Rows[e.RowIndex].Cells["hinh_anh"].Value?.ToString();

            // Load ảnh lên PictureBox
            LoadAnh(imagePath);
            txtUrlcongtrinh_admin.Text = dgvCongtrinh_admin.Rows[row].Cells[9].Value != null ? dgvCongtrinh_admin.Rows[row].Cells[9].Value.ToString() : "";

        }

        private void btnThemcongtrinh_admin_Click(object sender, EventArgs e)
        {
            try
            {
                var newConstruction = new CongTrinh
                {
                    ten = txtTencongtrinh_admin.Text,
                    dia_diem = txtDiadiem_admin.Text,
                    chu_dau_tu = txtChudautu_admin.Text,
                    ngay_bat_dau = dtpNgaybatdau_admin.Value,
                    ngay_du_kien_ket_thuc = dtpNgayketthuc_admin.Value,
                    trang_thai = cbbTrangthai_admin.SelectedItem.ToString(),
                    tong_muc_dau_tu = nudTongmucdautu_admin.Value,
                    hinh_anh = txtUrlcongtrinh_admin.Text
                };

                if (ctrBLL.AddConstruction(newConstruction))
                {
                    MessageBox.Show("Thêm thành công!");
                    dgvCongtrinh_admin.DataSource = ctrBLL.GetConstructionList(); // Refresh DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoacongtrinh_admin_Click(object sender, EventArgs e)
        {
            if (dgvCongtrinh_admin.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvCongtrinh_admin.CurrentRow.Cells["id"].Value);
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (ctrBLL.DeleteConstruction(id))
                {
                    dgvCongtrinh_admin.DataSource = ctrBLL.GetConstructionList();
                }
            }
        }

        private void btnSuacongtrinh_admin_Click(object sender, EventArgs e)
        {
            if (dgvCongtrinh_admin.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn công trình cần sửa");
                return;
            }

            try
            {
                // Lấy ID từ dòng được chọn
                int id = Convert.ToInt32(dgvCongtrinh_admin.CurrentRow.Cells["id"].Value);

                // Tạo đối tượng cập nhật
                var updated = new CongTrinh
                {
                    id = id,
                    ten = txtTencongtrinh_admin.Text,
                    dia_diem = txtDiadiem_admin.Text,
                    chu_dau_tu = txtChudautu_admin.Text,
                    ngay_bat_dau = dtpNgaybatdau_admin.Value,
                    ngay_du_kien_ket_thuc = dtpNgayketthuc_admin.Value,
                    
                    trang_thai = cbbTrangthai_admin.SelectedItem.ToString(),
                    tong_muc_dau_tu = nudTongmucdautu_admin.Value,
                    hinh_anh = txtUrlcongtrinh_admin.Text
                };

                // Gọi BLL để cập nhật
                if (ctrBLL.UpdateConstruction(updated))
                {
                    MessageBox.Show("Cập nhật thành công!");
                    // Load lại dữ liệu
                    dgvCongtrinh_admin.DataSource = ctrBLL.GetConstructionList();
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
        private void LoadAnh(string imagePath)
        {
            try
            {
                if (!string.IsNullOrEmpty(imagePath))
                {
                    // Xử lý đường dẫn tương đối/ tuyệt đối
                    string fullPath = Path.Combine(Application.StartupPath, imagePath);

                    if (File.Exists(fullPath))
                    {
                        pbCongtrinh_admin.Image = Image.FromFile(fullPath);
                    }
                    else
                    {
                        // Nếu không tìm thấy ảnh, hiển thị ảnh mặc định
                        pbCongtrinh_admin.Image = GUI.Properties.Resources.default_image;
                    }
                }
                else
                {
                    pbCongtrinh_admin.Image = null; // Hoặc ảnh mặc định
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load ảnh: " + ex.Message);
                pbCongtrinh_admin.Image = null;
            }
        }
        private void pbCongtrinh_admin_Click(object sender, EventArgs e)
        {
            pbCongtrinh_admin.SizeMode = PictureBoxSizeMode.Zoom; // Hiển thị ảnh vừa khung
            pbCongtrinh_admin.BorderStyle = BorderStyle.FixedSingle;
        }

        private void btnChonanhcongtrinh_admin_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Ảnh công trình|*.jpg;*.jpeg;*.png";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Hiển thị preview
                    pbCongtrinh_admin.Image = Image.FromFile(openFile.FileName);

                    // Lưu đường dẫn (có thể lưu tương đối)
                    txtUrlcongtrinh_admin.Text = "Images/" + Path.GetFileName(openFile.FileName);

                    // Copy file vào thư mục dự án (tuỳ chọn)
                    string destPath = Path.Combine(Application.StartupPath, "Images", Path.GetFileName(openFile.FileName));
                    if (!Directory.Exists(Path.GetDirectoryName(destPath)))
                        Directory.CreateDirectory(Path.GetDirectoryName(destPath));

                    File.Copy(openFile.FileName, destPath, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi chọn ảnh: " + ex.Message);
                }
            }
        }

        private void dgvNhathaubencongtrinh_admin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNhathaubencongtrinh_admin.DataSource == null || dgvNhathaubencongtrinh_admin.Rows.Count == 0 || dgvNhathaubencongtrinh_admin.CurrentCell == null)
            {
                MessageBox.Show("Không có dữ liệu để chọn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int row = dgvNhathaubencongtrinh_admin.CurrentCell.RowIndex;

            // Lấy dòng được chọn
            DataGridViewRow selectedRow = dgvNhathaubencongtrinh_admin.Rows[e.RowIndex];

            // Lấy giá trị tên nhà thầu từ cột "ten_cong_ty"
            string tenNhaThau = selectedRow.Cells["ten_cong_ty"].Value?.ToString();

            // Rfresh ComboBox
            if (!string.IsNullOrEmpty(tenNhaThau))
            {
                
                cbbNhathaucongtrinh_admin.SelectedItem = tenNhaThau;

               
                cbbNhathaucongtrinh_admin.Text = tenNhaThau;
            }


        }

        private void dgvVattubencongtrinh_admin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvVattubencongtrinh_admin.DataSource == null || dgvVattubencongtrinh_admin.Rows.Count == 0 || dgvVattubencongtrinh_admin.CurrentCell == null)
            //{
            //    MessageBox.Show("Không có dữ liệu để chọn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //int row = dgvNhathaubencongtrinh_admin.CurrentCell.RowIndex;

            //// Lấy dòng được chọn
            //DataGridViewRow selectedRow = dgvNhathaubencongtrinh_admin.Rows[e.RowIndex];

            //// Lấy giá trị tên nhà thầu từ cột "ten_cong_ty"
            //string tenNhaThau = selectedRow.Cells["ten_cong_ty"].Value?.ToString();

            //// Rfresh ComboBox
            //if (!string.IsNullOrEmpty(tenNhaThau))
            //{

            //    cbbNhathaucongtrinh_admin.SelectedItem = tenNhaThau;


            //    cbbNhathaucongtrinh_admin.Text = tenNhaThau;
            //}
        }

        private void btnThemnhathaucongtrinh_admin_Click(object sender, EventArgs e)
        {


            CongTrinh_NhaThau_Admin d = new CongTrinh_NhaThau_Admin();
            d.Show();
            //try
            //{
            //    var newConstruction = new NhaThau
            //    {
            //        ten_cong_ty = txtTencongty_Admin.Text,
            //        ma_so_thue = txtMasothue_Admin.Text,
            //        dia_chi = txtDiachi_Admin.Text,
            //        nguoi_dai_dien = txtNguoidaidiennhathau_Admin.Text,
            //        so_dien_thoai = txtSdtnhathau_Admin.Text,
            //        email = txtEmailnhathau_Admin.Text,

            //    };

            //    if (bll.AddContractor(newConstruction))
            //    {
            //        MessageBox.Show("Thêm thành công!");
            //        dgvCongtrinh_admin.DataSource = nhathau.GetContractorList(); // Refresh DataGridView
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi " + ex.Message);
            //}
        }

        private void btnFrmCTNT_Click(object sender, EventArgs e)
        {
            CongTrinh_NhaThau_Admin d = new CongTrinh_NhaThau_Admin();
            d.Show();

            
        }

        private void btnThemvatlieucongtrinh_admin_Click(object sender, EventArgs e)
        {


        }
    }
}
