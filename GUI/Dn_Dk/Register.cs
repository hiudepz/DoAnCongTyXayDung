using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Dn_Dk
{
    public partial class Register : Form
    {
        private BLL_DangNhap bllDangNhap=new BLL_DangNhap();
        public Register()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            StringBuilder loi = new StringBuilder();

            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string email = txtEmail.Text.Trim();
            string soDienThoai = txtSDT.Text.Trim();
            string xacNhanMatKhau = txtXacNhanMatKhau.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenDangNhap))
                loi.AppendLine("- Tên đăng nhập không được để trống.");

            if (matKhau.Length < 6)
                loi.AppendLine("- Mật khẩu phải từ 6 ký tự trở lên.");

            else if (matKhau != xacNhanMatKhau)
                loi.AppendLine("- Mật khẩu và xác nhận mật khẩu không trùng khớp.");

            if (!string.IsNullOrWhiteSpace(email) &&
                !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                loi.AppendLine("- Email không đúng định dạng.");

            if (!string.IsNullOrWhiteSpace(soDienThoai) &&
                !Regex.IsMatch(soDienThoai, @"^0\d{9}$"))
                loi.AppendLine("- Số điện thoại phải gồm 10 chữ số, bắt đầu bằng số 0.");

            if (loi.Length > 0)
            {
                MessageBox.Show("Vui lòng kiểm tra lại các lỗi sau:\n\n" + loi.ToString(),
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            //Nếu không lỗi tiếp tục đăng kí 

            var nd = new NguoiDung
            {
                ten_dang_nhap = txtTenDangNhap.Text.Trim(),
                mat_khau = txtMatKhau.Text.Trim(),
                ho_ten = label.Text.Trim(),
                so_dien_thoai = txtSDT.Text.Trim(),
                email = txtSDT.Text.Trim(),
                vai_tro = "User" // Hoặc cho chọn từ ComboBox nếu cần
            };

            
            if (bllDangNhap.DangKyNguoiDung(nd))
            {
                MessageBox.Show("Đăng ký thành công");
                this.Close(); // hoặc mở form đăng nhập
            }
            else
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại");
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
