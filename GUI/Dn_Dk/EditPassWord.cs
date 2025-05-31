using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Dn_Dk
{
    public partial class EditPassWord : Form
    {
        public EditPassWord()
        {
            InitializeComponent();
        }
        private BLL_DangNhap bllDangNhap = new BLL_DangNhap();
        private void btnĐổiMK_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim(); // hoặc lấy từ session đăng nhập
            string matKhauCu = txtMatKhauCu.Text.Trim();
            string matKhauMoi = txtMatKhauMoi.Text.Trim();
            string xacNhan = txtXacNhan.Text.Trim();

            StringBuilder loi = new StringBuilder();
            if (string.IsNullOrWhiteSpace(matKhauCu))
                loi.AppendLine("- Vui lòng nhập mật khẩu hiện tại.");
            if (matKhauMoi.Length < 6)
                loi.AppendLine("- Mật khẩu mới phải từ 6 ký tự trở lên.");
            if (matKhauMoi != xacNhan)
                loi.AppendLine("- Xác nhận mật khẩu không khớp.");

            if (loi.Length > 0)
            {
                MessageBox.Show("Vui lòng kiểm tra lại:\n" + loi.ToString(), "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (bllDangNhap.DoiMatKhau(tenDangNhap, matKhauCu, matKhauMoi))
            {
                MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hiện tại hoặc tên đăng nhập không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditPassWord_Load(object sender, EventArgs e)
        {

        }
    }
}
