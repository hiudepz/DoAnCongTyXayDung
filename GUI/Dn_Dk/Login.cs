using BLL;
using DAL;
using GUI.Admin;
using GUI.Dn_Dk;
using GUI.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private BLL_DangNhap bllDangNhap=new BLL_DangNhap();   
        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            string ten = txtTenDangNhap.Text.Trim();
            string mk = txtMatKhau.Text.Trim();
            StringBuilder loi = new StringBuilder();
            if (string.IsNullOrWhiteSpace(ten))
                loi.AppendLine("- Vui lòng nhập tên đăng nhập");
            if (string.IsNullOrWhiteSpace(mk))
                loi.AppendLine("- Vui lòng nhập mật khẩu hiện tại.");
            if (mk.Length < 3)
                loi.AppendLine("- Mật khẩu mới phải từ 3 ký tự trở lên.");
            //if (matKhauMoi != xacNhan)
            //    loi.AppendLine("- Xác nhận mật khẩu không khớp.");

            if (loi.Length > 0)
            {
                MessageBox.Show("Vui lòng kiểm tra lại:\n" + loi.ToString(), "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            NguoiDung nd = bllDangNhap.KiemTraDangNhap(ten, mk);
            if(nd != null)
            {
                if (nd.vai_tro == "Admin")
                {
                    MessageBox.Show("Chào Admin");
                    new DashBoard_Admin().Show();
                }
                else
                {
                    MessageBox.Show("Chào người dùng");
                    new DashBoard_User().Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            new Register().Show();
        }

        

      

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            new EditPassWord().Show();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            //DialogResult ds = MessageBox.Show("Bạn chắc chắn có muốn thoát", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (ds == DialogResult.Yes)
            //{
            //    // Hiển thị lại form Login
            //    this.Close();
            //}
           
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
