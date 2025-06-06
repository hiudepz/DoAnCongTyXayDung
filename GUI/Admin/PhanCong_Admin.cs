﻿using BLL;
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

namespace GUI.Admin
{
    public partial class PhanCong_Admin: Form
    {
        private BLL_NhanCong_Admin bllNhanCong = new BLL_NhanCong_Admin();
        private BLL_PhanCong_Admin bllPHanCong = new BLL_PhanCong_Admin();
        private BLL_Congtrinh_Admin bllCongTrinh = new BLL_Congtrinh_Admin();
        public PhanCong_Admin()
        {
            InitializeComponent();
        }

        private void PhanCong_Admin_Load(object sender, EventArgs e)
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

        private void dgvNhanCong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }



        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvNhanCong.Rows)
                {
                    // Đảm bảo không duyệt dòng mới (nếu AllowUserToAddRows vẫn bật)
                    if (row.IsNewRow) continue;

                    // Kiểm tra checkbox
                    bool isChecked = Convert.ToBoolean(row.Cells["ChckNhanCong"].Value);

                    if (isChecked)
                    {
                        // Lấy dữ liệu từ các ô trong dòng
                        int id = Convert.ToInt32(row.Cells["id"].Value);
                        int id_CongTrinh = (int)cbbCongTrinh.SelectedValue;

                        // Anh có thể xử lý tiếp theo ý muốn, ví dụ:
                        //MessageBox.Show($"ID: {id_CongTrinh} ");
                        
                        //Add
                        var newMember = new PhanCong
                        {
                            cong_trinh_id = id_CongTrinh,
                            nhan_cong_id = id,
                            ngay_bat_dau = dtpDateStart.Value,
                            ngay_ket_thuc = dtpDateEnd.Value,
                            

                        };

                        if (bllPHanCong.AddPhanCong(newMember))
                        {
                            
                            dgvBangPhanCong.DataSource = bllPHanCong.GetPhanCongList(); // Refresh DataGridView
                        }
                    }
                }
                MessageBox.Show("Thêm thành công!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int congTrinhId = int.Parse(txtCongTrinhIdvs.Text);
                int nhanCongId = int.Parse(txtIdNhanCongvs.Text);
                DateTime ngayBatDau = dtpstartvs.Value;

                DialogResult ds = MessageBox.Show("Bạn chắc chắn muốn Xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ds == DialogResult.Yes)
                {
                    bool result = bllPHanCong.DeletePhanCong(congTrinhId, nhanCongId, ngayBatDau);
                    if (result)
                    {
                        MessageBox.Show("Xóa phân công thành công!");
                        LoadDanhSachPhanCong(); // Refresh danh sách
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy phân công để xóa");
                    }
                }
                

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        public void LoadDanhSachPhanCong()
        {
            dgvBangPhanCong.DataSource = bllPHanCong.GetPhanCongList();
        }

        private void dgvBangPhanCong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBangPhanCong.DataSource == null || dgvBangPhanCong.Rows.Count == 0 || dgvBangPhanCong.CurrentCell == null)
            {
                MessageBox.Show("Không có dữ liệu để chọn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int row = dgvBangPhanCong.CurrentCell.RowIndex;

            // Gán giá trị, nếu null thì dùng chuỗi rỗng ""
            txtCongTrinhIdvs.Text = dgvBangPhanCong.Rows[row].Cells[0].Value != null ? dgvBangPhanCong.Rows[row].Cells[0].Value.ToString() : "";
            txtIdNhanCongvs.Text = dgvBangPhanCong.Rows[row].Cells[1].Value != null ? dgvBangPhanCong.Rows[row].Cells[1].Value.ToString() : "";
            dtpstartvs.Text = dgvBangPhanCong.Rows[row].Cells[2].Value != null ? dgvBangPhanCong.Rows[row].Cells[2].Value.ToString() : "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvBangPhanCong.DataSource = bllPHanCong.GetPhanCongListTK(txtSearch.Text.Trim());
        }
        
    }
}
