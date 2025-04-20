using BLL;
using DAL;
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

namespace GUI.Admin
{
    public partial class VatTu_Admin: Form
    {
        private BLL_Vattu_Admin bll = new BLL_Vattu_Admin();
        public VatTu_Admin()
        {
            InitializeComponent();
        }

        private void VatTu_Admin_Load(object sender, EventArgs e)
        {
            dgvVattu.DataSource = bll.GetMaterialList();
            dgvVattu.Columns["id"].Visible = false;

        }

        private void btnThemvattu_Click(object sender, EventArgs e)
        {
            try
            {
                if(!decimal.TryParse(txtDongia.Text,out decimal donGia))
                {
                    MessageBox.Show("Vui lòng nhập đơn giá hợp lệ ( ví dụ : 2000.50)");
                    txtDongia.Focus();
                    return;
                }
                var newMaterial = new VatTu
                {
                    ma_vat_tu = txtMavattu.Text,
                    ten = txtTenvattu.Text,
                    don_vi_tinh = txtDonvitinh.Text,
                    don_gia = donGia,
                    nha_cung_cap = txtManhacc.Text,
                    hinh_anh = txtUrlanhvattu_Admin.Text
                };

                if (bll.AddMaterial(newMaterial))
                {
                    MessageBox.Show("Thêm thành công!");
                    dgvVattu.DataSource = bll.GetMaterialList(); // Refresh DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoavattu_Click(object sender, EventArgs e)
        {
            if (dgvVattu.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvVattu.CurrentRow.Cells["id"].Value);
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (bll.DeleteMaterial(id))
                {
                    dgvVattu.DataSource = bll.GetMaterialList();
                }
            }
        }

        private void btnSuavattu_Click(object sender, EventArgs e)
        {
            if (dgvVattu.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn vật tư cần sửa");
                return;
            }

            try
            {
                // Parse giá từ string sang decimal
                if (!decimal.TryParse(txtDongia.Text, out decimal donGia))
                {
                    MessageBox.Show("Vui lòng nhập đơn giá hợp lệ");
                    txtDongia.Focus();
                    return;
                }

                int id = Convert.ToInt32(dgvVattu.CurrentRow.Cells["id"].Value);

                var updated = new VatTu
                {
                    id = id,
                    ma_vat_tu = txtMavattu.Text,
                    ten = txtTenvattu.Text,
                    don_vi_tinh = txtDonvitinh.Text,
                    don_gia = donGia, // Đã parse sang decimal
                    nha_cung_cap = txtManhacc.Text,
                    hinh_anh = txtUrlanhvattu_Admin.Text
                };

                if (bll.UpdateMaterial(updated))
                {
                    MessageBox.Show("Cập nhật thành công!");
                    dgvVattu.DataSource = bll.GetMaterialList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
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
                        pbVattu.Image = Image.FromFile(fullPath);
                    }
                    else
                    {
                        // Nếu không tìm thấy ảnh, hiển thị ảnh mặc định
                        pbVattu.Image = GUI.Properties.Resources.default_image;
                    }
                }
                else
                {
                    pbVattu.Image = null; // Hoặc ảnh mặc định
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load ảnh: " + ex.Message);
                pbVattu.Image = null;
            }
        }
        private void dgvVattu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvVattu.Rows.Count) return;

            DataGridViewRow row = dgvVattu.Rows[e.RowIndex];

            // Gán dữ liệu từ DataGridView lên các control
            txtMavattu.Text = row.Cells["ma_vat_tu"].Value?.ToString();
            txtTenvattu.Text = row.Cells["ten"].Value?.ToString();
            txtDonvitinh.Text = row.Cells["don_vi_tinh"].Value?.ToString();
            txtDongia.Text = row.Cells["don_gia"].Value?.ToString();
            txtManhacc.Text = row.Cells["nha_cung_cap"].Value?.ToString();
            // Lấy đường dẫn ảnh từ dòng được chọn
            string imagePath = dgvVattu.Rows[e.RowIndex].Cells["hinh_anh"].Value?.ToString();

            // Load ảnh lên PictureBox
            LoadAnh(imagePath);
            txtUrlanhvattu_Admin.Text = row.Cells["hinh_anh"].Value?.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Ảnh công trình|*.jpg;*.jpeg;*.png";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Hiển thị preview
                    pbVattu.Image = Image.FromFile(openFile.FileName);

                    // Lưu đường dẫn (có thể lưu tương đối)
                    txtUrlanhvattu_Admin.Text = "Images/" + Path.GetFileName(openFile.FileName);

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

        private void pbVattu_Click(object sender, EventArgs e)
        {
            pbVattu.SizeMode = PictureBoxSizeMode.Zoom; // Hiển thị ảnh vừa khung
            pbVattu.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
