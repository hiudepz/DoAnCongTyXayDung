using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BLL;
using DAL;

namespace GUI.Admin
{
    public partial class TienDo_Admin : Form
    {
        private BLL_TienDo_Admin bll = new BLL_TienDo_Admin();
        public TienDo_Admin()
        {
            InitializeComponent();
        }

        private void TienDo2_Admin_Load(object sender, EventArgs e)
        {
            //dgvTienDo.AutoGenerateColumns = false;
            dgvTienDo.DataSource = bll.GetProgressList();
            dgvTienDo.Columns["id"].Visible = false;
            dgvTienDo.Columns["CongTrinh"].Visible = false;
            LoadChart();
            //Format datetimepicker 01/12/25
            dtpNgaycapnhattiendo.Format = DateTimePickerFormat.Custom;
            dtpNgaycapnhattiendo.CustomFormat = "dd/MM/yy";
            dtpNgaycapnhattiendo.Format = DateTimePickerFormat.Custom;
            dtpNgaycapnhattiendo.CustomFormat = "dd/MM/yy";
            //LoadCongTrinh
            cbbTiendoct.DataSource = bll.GetAllCongTrinh();
            cbbTiendoct.ValueMember = "id";
            cbbTiendoct.DisplayMember = "ten";
        }
        public void LoadChart()
        {
            var data = bll.GetByTienDo();
            ChartTienDo.Series.Clear();
            Series series = new Series("Tien Do");
            series.ChartType = SeriesChartType.Column;

            foreach (var item in data)
            {

                series.Points.AddXY(Hienten((int)item.cong_trinh_id), item.phan_tram_hoan_thanh);
            }

            ChartTienDo.Series.Add(series);
        }
        //Hien ten cong trinh tren chart
        public string Hienten(int congTrinhId)
        {
            var congTrinh = bll.GetbyCongTrinh(congTrinhId).FirstOrDefault();
            return congTrinh ?? "Không xác định";
        }

        private void dgvTienDo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTienDo.DataSource == null || dgvTienDo.Rows.Count == 0 || dgvTienDo.CurrentCell == null)
            {
                MessageBox.Show("Không có dữ liệu để chọn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int row = dgvTienDo.CurrentCell.RowIndex;

            // Gán giá trị, nếu null thì dùng chuỗi rỗng ""
            cbbTiendoct.SelectedValue = dgvTienDo.Rows[row].Cells[1].Value != null ? dgvTienDo.Rows[row].Cells[1].Value : "";
            dtpNgaycapnhattiendo.Text = dgvTienDo.Rows[row].Cells[2].Value != null ? dgvTienDo.Rows[row].Cells[2].Value.ToString() : "";
            txtMotatiendo.Text = dgvTienDo.Rows[row].Cells[3].Value != null ? dgvTienDo.Rows[row].Cells[3].Value.ToString() : "";
            txtPhantramhoanthanh.Text = dgvTienDo.Rows[row].Cells[4].Value != null ? dgvTienDo.Rows[row].Cells[4].Value.ToString() : "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                var newprogress = new TienDo
                {
                    cong_trinh_id = (int)cbbTiendoct.SelectedValue,

                    ngay_cap_nhat = dtpNgaycapnhattiendo.Value,
                    mo_ta = txtMotatiendo.Text,
                    phan_tram_hoan_thanh = decimal.Parse(txtPhantramhoanthanh.Text),

                };

                if (bll.AddProgress(newprogress))
                {
                    MessageBox.Show("Thêm thành công!");
                    dgvTienDo.DataSource = bll.GetProgressList(); // Refresh DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            LoadChart();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTienDo.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvTienDo.CurrentRow.Cells["id"].Value);
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (bll.DeleteProgress(id))
                {
                    dgvTienDo.DataSource = bll.GetProgressList();
                }
            }
            LoadChart();
        }
    }
}
