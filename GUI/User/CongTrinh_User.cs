using BLL;
using DAL;
using GUI.Admin;
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

namespace GUI.User
{
    public partial class CongTrinh_User: Form
    {
        private BLL_Congtrinh_Admin ctrBLL = new BLL_Congtrinh_Admin();
        private BLL_Nhathau_Admin nhathau = new BLL_Nhathau_Admin();
        private BLL_Vattu_Admin vattu = new BLL_Vattu_Admin();
        public CongTrinh_User()
        {
            InitializeComponent();
        }

        private void CongTrinh_User_Load(object sender, EventArgs e)
        {
            //vattu but in contruction
            dgvVattubencongtrinh_user.DataSource = vattu.GetMaterialList();
            dgvVattubencongtrinh_user.Columns["id"].Visible = false;
            //dgvVattubencongtrinh_user.Columns["don_vi"].Visible = false;
            dgvVattubencongtrinh_user.Columns["don_gia"].Visible = false;
            dgvVattubencongtrinh_user.Columns["nha_cung_cap"].Visible = false;
            dgvVattubencongtrinh_user.Columns["hinh_anh"].Visible = false;
            //Load nhathau's data to dgv
            dgvNhathaubencongtrinh_user.DataSource = nhathau.GetContractorList();
            // hide the thing for who dont wants to know
            dgvNhathaubencongtrinh_user.Columns["id"].Visible = false;
            dgvNhathaubencongtrinh_user.Columns["dia_chi"].Visible = false;
            dgvNhathaubencongtrinh_user.Columns["nguoi_dai_dien"].Visible = false;
            dgvNhathaubencongtrinh_user.Columns["so_dien_thoai"].Visible = false;
            dgvNhathaubencongtrinh_user.Columns["email"].Visible = false;

            // Đặt tên cột hiển thị (nếu cần)
            dgvNhathaubencongtrinh_user.Columns["ten_cong_ty"].HeaderText = "Tên nhà thầu";
            dgvNhathaubencongtrinh_user.Columns["ma_so_thue"].HeaderText = "Mã số thuế";

            // Định dạng cột (tuỳ chọn)
            dgvNhathaubencongtrinh_user.Columns["ten_cong_ty"].Width = 150;
            dgvNhathaubencongtrinh_user.Columns["ma_so_thue"].Width = 150;
            //cbbTrangthai_user
            try
            {
                // Gọi BLL để lấy danh sách trạng thái
                List<string> danhSachContractor = nhathau.GetNameContractorList();

                // assign date to combobox
                cbbNhathaucongtrinh_user.DataSource = danhSachContractor;

                // only choose no text
                cbbNhathaucongtrinh_user.DropDownStyle = ComboBoxStyle.DropDownList;

                // pick the first value if need
                if (cbbNhathaucongtrinh_user.Items.Count > 0)
                    cbbNhathaucongtrinh_user.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách trạng thái: " + ex.Message,
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            //Load database to datagridview which has name dgvCongtrinh_user
            dgvCongtrinh_user.DataSource = ctrBLL.GetConstructionList();
            //hide the thing for who dont wants to know
            dgvCongtrinh_user.Columns["ngay_hoan_thanh"].Visible = false;
            //Format datetimepicker 01/12/25
            dtpNgaybatdau_user.Format = DateTimePickerFormat.Custom;
            dtpNgaybatdau_user.CustomFormat = "dd/MM/yy";
            dtpNgayketthuc_user.Format = DateTimePickerFormat.Custom;
            dtpNgayketthuc_user.CustomFormat = "dd/MM/yy";
            //cbbTrangthai_user
            try
            {
                // Gọi BLL để lấy danh sách trạng thái
                List<string> danhSachTrangThai = ctrBLL.GetStatusList();

                // assign date to combobox
                cbbTrangthai_user.DataSource = danhSachTrangThai;

                // only choose no text
                cbbTrangthai_user.DropDownStyle = ComboBoxStyle.DropDownList;

                // pick the first value if need
                if (cbbTrangthai_user.Items.Count > 0)
                    cbbTrangthai_user.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách trạng thái: " + ex.Message,
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void dgvCongtrinh_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCongtrinh_user.DataSource == null || dgvCongtrinh_user.Rows.Count == 0 || dgvCongtrinh_user.CurrentCell == null)
            {
                MessageBox.Show("Không có dữ liệu để chọn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int row = dgvCongtrinh_user.CurrentCell.RowIndex;

            // Gán giá trị, nếu null thì dùng chuỗi rỗng ""
            txtMacongtrinh_user.Text = dgvCongtrinh_user.Rows[row].Cells[0].Value != null ? dgvCongtrinh_user.Rows[row].Cells[0].Value.ToString() : "";
            txtTencongtrinh_user.Text = dgvCongtrinh_user.Rows[row].Cells[1].Value != null ? dgvCongtrinh_user.Rows[row].Cells[1].Value.ToString() : "";
            txtDiadiem_user.Text = dgvCongtrinh_user.Rows[row].Cells[2].Value != null ? dgvCongtrinh_user.Rows[row].Cells[2].Value.ToString() : "";
            txtChudautu_user.Text = dgvCongtrinh_user.Rows[row].Cells[3].Value != null ? dgvCongtrinh_user.Rows[row].Cells[3].Value.ToString() : "";
            dtpNgaybatdau_user.Text = dgvCongtrinh_user.Rows[row].Cells[4].Value != null ? dgvCongtrinh_user.Rows[row].Cells[4].Value.ToString() : "";
            dtpNgayketthuc_user.Text = dgvCongtrinh_user.Rows[row].Cells[5].Value != null ? dgvCongtrinh_user.Rows[row].Cells[5].Value.ToString() : "";
            cbbTrangthai_user.Text = dgvCongtrinh_user.Rows[row].Cells[7].Value != null ? dgvCongtrinh_user.Rows[row].Cells[7].Value.ToString() : "";
            if (dgvCongtrinh_user.Rows[row].Cells[8].Value != null &&
                 decimal.TryParse(dgvCongtrinh_user.Rows[row].Cells[8].Value.ToString(), out decimal tongMucDauTu))
            {
                nudTongmucdautu_user.Value = tongMucDauTu;
            }
            else
            {
                nudTongmucdautu_user.Value = nudTongmucdautu_user.Minimum; //or default value
            }
            // Lấy đường dẫn ảnh từ dòng được chọn
            string imagePath = dgvCongtrinh_user.Rows[e.RowIndex].Cells["hinh_anh"].Value?.ToString();

            // Load ảnh lên PictureBox
            LoadAnh(imagePath);
            txtUrlcongtrinh_user.Text = dgvCongtrinh_user.Rows[row].Cells[9].Value != null ? dgvCongtrinh_user.Rows[row].Cells[9].Value.ToString() : "";
        }

        private void dgvNhathaubencongtrinh_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNhathaubencongtrinh_user.DataSource == null || dgvNhathaubencongtrinh_user.Rows.Count == 0 || dgvNhathaubencongtrinh_user.CurrentCell == null)
            {
                MessageBox.Show("Không có dữ liệu để chọn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int row = dgvNhathaubencongtrinh_user.CurrentCell.RowIndex;

            // Lấy dòng được chọn
            DataGridViewRow selectedRow = dgvNhathaubencongtrinh_user.Rows[e.RowIndex];

            // Lấy giá trị tên nhà thầu từ cột "ten_cong_ty"
            string tenNhaThau = selectedRow.Cells["ten_cong_ty"].Value?.ToString();

            // Rfresh ComboBox
            if (!string.IsNullOrEmpty(tenNhaThau))
            {

                cbbNhathaucongtrinh_user.SelectedItem = tenNhaThau;


                cbbNhathaucongtrinh_user.Text = tenNhaThau;
            }
        }

        private void dgvVattubencongtrinh_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVattubencongtrinh_user.DataSource == null || dgvVattubencongtrinh_user.Rows.Count == 0 || dgvVattubencongtrinh_user.CurrentCell == null)
            {
                MessageBox.Show("Không có dữ liệu để chọn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int row = dgvVattubencongtrinh_user.CurrentCell.RowIndex;

            // Lấy dòng được chọn
            DataGridViewRow selectedRow = dgvVattubencongtrinh_user.Rows[e.RowIndex];

            // Lấy giá trị tên nhà thầu từ cột "ten"
            string tenVatTu = selectedRow.Cells["ten"].Value?.ToString();

            // Rfresh ComboBox
            if (!string.IsNullOrEmpty(tenVatTu))
            {

                cbbVatlieucongtrinh_user.SelectedItem = tenVatTu;


                cbbVatlieucongtrinh_user.Text = tenVatTu;
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
                        pbCongtrinh_user.Image = Image.FromFile(fullPath);
                    }
                    else
                    {
                        // Nếu không tìm thấy ảnh, hiển thị ảnh mặc định
                        pbCongtrinh_user.Image = GUI.Properties.Resources.default_image;
                    }
                }
                else
                {
                    pbCongtrinh_user.Image = null; // Hoặc ảnh mặc định
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load ảnh: " + ex.Message);
                pbCongtrinh_user.Image = null;
            }
        }
        private void pbCongtrinh_user_Click(object sender, EventArgs e)
        {
            pbCongtrinh_user.SizeMode = PictureBoxSizeMode.Zoom; // Hiển thị ảnh vừa khung
            pbCongtrinh_user.BorderStyle = BorderStyle.FixedSingle;
        }

        private void btnChonanhcongtrinh_user_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Ảnh công trình|*.jpg;*.jpeg;*.png";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Hiển thị preview
                    pbCongtrinh_user.Image = Image.FromFile(openFile.FileName);

                    // Lưu đường dẫn (có thể lưu tương đối)
                    txtUrlcongtrinh_user.Text = "Images/" + Path.GetFileName(openFile.FileName);

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

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(tuKhoa))
            {
                // Nếu ô tìm kiếm bị xoá trắng → hiện danh sách gốc
                dgvCongtrinh_user.DataSource = ctrBLL.GetConstructionList();
            }
            else
            {
                // Lọc theo từ khoá
                tuKhoa = txtTimKiem.Text.Trim();
                var ketQua = ctrBLL.TimKiem(tuKhoa);
                dgvCongtrinh_user.DataSource = ketQua;
            }
        }

        private void pbCongtrinh_user_Click_1(object sender, EventArgs e)
        {
            pbCongtrinh_user.SizeMode = PictureBoxSizeMode.Zoom; // Hiển thị ảnh vừa khung
            pbCongtrinh_user.BorderStyle = BorderStyle.FixedSingle;
        }

        private void btnChonanhcongtrinh_user_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Ảnh công trình|*.jpg;*.jpeg;*.png";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Hiển thị preview
                    pbCongtrinh_user.Image = Image.FromFile(openFile.FileName);

                    // Lưu đường dẫn (có thể lưu tương đối)
                    txtUrlcongtrinh_user.Text = "Images/" + Path.GetFileName(openFile.FileName);

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
    }
}
