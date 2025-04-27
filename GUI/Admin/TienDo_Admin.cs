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
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI.Admin
{
    public partial class TienDo_Admin: Form
    {
        private BLL_TienDo_Admin bll = new BLL_TienDo_Admin();
        public TienDo_Admin()
        {
            InitializeComponent();
        }

        private void TienDo_Admin_Load(object sender, EventArgs e)
        {
            //dgvTienDo.AutoGenerateColumns = false;
            dgvTienDo.DataSource = bll.GetProgressList();
            dgvTienDo.Columns["id"].Visible = false;
            dgvTienDo.Columns["CongTrinh"].Visible = false;
            LoadChart();
            //Format datetimepicker 01/12/25
            dtpNgayCaoNhat.Format = DateTimePickerFormat.Custom;
            dtpNgayCaoNhat.CustomFormat = "dd/MM/yy";
            dtpNgayCaoNhat.Format = DateTimePickerFormat.Custom;
            dtpNgayCaoNhat.CustomFormat = "dd/MM/yy";
        }
        public void LoadChart()
        {
            var data = bll.GetByTienDo();
            ChartTienDo.Series.Clear();
            Series series = new Series("Tien Do");
            series.ChartType = SeriesChartType.Column;

            foreach (var item in data)
            {
                
                series.Points.AddXY(Hienten((int)item.cong_trinh_id) , item.phan_tram_hoan_thanh);
            }

            ChartTienDo.Series.Add(series);
        }
        //Hien ten cong trinh tren chart
        public string Hienten(int congTrinhId)
        {
            var congTrinh = bll.GetbyCongTrinh(congTrinhId).FirstOrDefault();
            return congTrinh?? "Không xác định";
        }

        private void dgvTienDo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTienDo.DataSource == null || dgvTienDo.Rows.Count == 0 || dgvTienDo.CurrentCell == null)
            {
                MessageBox.Show("Không có dữ liệu để chọn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int row = dgvTienDo.CurrentCell.RowIndex;


        }      
    }
}
