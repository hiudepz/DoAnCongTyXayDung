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

namespace GUI.User
{
    public partial class PhanCong_User: Form
    {
        private BLL_NhanCong_Admin bllNhanCong = new BLL_NhanCong_Admin();
        private BLL_PhanCong_Admin bllPHanCong = new BLL_PhanCong_Admin();
        private BLL_Congtrinh_Admin bllCongTrinh = new BLL_Congtrinh_Admin();
        public PhanCong_User()
        {
            InitializeComponent();
        }

        private void PhanCong_User_Load(object sender, EventArgs e)
        {
            //fomat time
            dtpDateStart.Format = DateTimePickerFormat.Custom;
            dtpDateStart.CustomFormat = "dd/MM/yy";
            dtpDateEnd.Format = DateTimePickerFormat.Custom;
            dtpDateEnd.CustomFormat = "dd/MM/yy";
            //Load Data 
            dgvBangPhanCong.DataSource = bllPHanCong.GetPhanCongList();
            dgvNhanCong.DataSource = bllNhanCong.GetMemberList();
            //LoadCongTrinh
            cbbCongTrinh.DataSource = bllCongTrinh.GetConstructionList();
            cbbCongTrinh.ValueMember = "id";
            cbbCongTrinh.DisplayMember = "ten";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvBangPhanCong.DataSource = bllPHanCong.GetPhanCongListTK(txtSearch.Text.Trim());
        }
    }
}
