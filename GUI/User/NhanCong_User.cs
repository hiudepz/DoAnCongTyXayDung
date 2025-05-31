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

namespace GUI.User
{
    public partial class NhanCong_User : Form
    {
        private BLL_NhanCong_Admin bll = new BLL_NhanCong_Admin();
        public NhanCong_User()
        {
            InitializeComponent();
        }

        private void NhanCong_User_Load(object sender, EventArgs e)
        {
            dgvNhancong_User.DataSource = bll.GetMemberList();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(tuKhoa))
            {
                // Nếu ô tìm kiếm bị xoá trắng → hiện danh sách gốc
                dgvNhancong_User.DataSource = bll.GetMemberList();
            }
            else
            {
                // Lọc theo từ khoá
                tuKhoa = txtTimKiem.Text.Trim();
                var ketQua = bll.TimKiem(tuKhoa);
                dgvNhancong_User.DataSource = ketQua;
            }
        }
    }
}
