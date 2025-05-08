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
            Application.Exit();
        }
    }
}
