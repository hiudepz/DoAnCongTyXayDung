using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class reportNTCT : Form
    {
        //private bool _reportForm = false;
        public reportNTCT()
        {
            InitializeComponent();
        }

        private void btnTimNhaThauTheoCongTrinh_Click(object sender, EventArgs e)
        {
            
            rptNhaThauCongTrinh t = new rptNhaThauCongTrinh();
            ParameterValues pars = new ParameterValues();
            ParameterDiscreteValue pa = new ParameterDiscreteValue();
            pa.Value=txtTimNhaThauTheoCongTrinh.Text;
            pars.Add(pa);
            t.DataDefinition.ParameterFields["@tenCongTrinh"].ApplyCurrentValues(pars);
            crystalReportViewer1.ReportSource = t; 
            //Kiểm tra nếu ko thấy 
            if(t.Rows.Count==0)
            {
                MessageBox.Show($"Không tìm thấy {txtTimNhaThauTheoCongTrinh.Text}","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            //string tenCongTrinh = txtTimNhaThauTheoCongTrinh.Text.Trim();

            //// Lấy dữ liệu từ database
            //DS_NhaThauTheoCongTrinh ds = new DS_NhaThauTheoCongTrinh();
            //var adapter = new DS_NhaThauTheoCongTrinhTableAdapters.sp_TimNhaThauTheoCongTrinhTableAdapter();
            //adapter.Fill(ds.sp_TimNhaThauTheoCongTrinh, tenCongTrinh);

            //// Tạo báo cáo mới
            //rptNhaThauCongTrinh report = new rptNhaThauCongTrinh();
            //report.SetDataSource(ds);
            //report.SetParameterValue("@tenCongTrinh", tenCongTrinh);

            //// Kiểm tra nếu form đã tồn tại
            //if (_reportForm != null && !_reportForm.IsDisposed)
            //{
            //    // Cập nhật ReportSource và refresh
            //    _reportForm.crystalReportViewer1.ReportSource = report;
            //    _reportForm.crystalReportViewer1.Refresh();
            //    _reportForm.BringToFront(); // Đưa form lên trước nếu bị ẩn sau các cửa sổ khác
            //}
            //else
            //{
            //    // Nếu form chưa tồn tại, tạo mới
            //    _reportForm = new reportNTCT();
            //    _reportForm.crystalReportViewer1.ReportSource = report;
            //    _reportForm.Show();
            //}
     



            //// Lấy giá trị từ TextBox
            //string tenCongTrinh = txtTimNhaThauTheoCongTrinh.Text.Trim();

            //// Tạo đối tượng dataset và table adapter
            //DS_NhaThauTheoCongTrinh ds = new DS_NhaThauTheoCongTrinh();
            //DS_NhaThauTheoCongTrinhTableAdapters.sp_TimNhaThauTheoCongTrinhTableAdapter adapter =
            //    new DS_NhaThauTheoCongTrinhTableAdapters.sp_TimNhaThauTheoCongTrinhTableAdapter();

            //// Điền dữ liệu vào dataset
            //adapter.Fill(ds.sp_TimNhaThauTheoCongTrinh, tenCongTrinh);

            //// Tạo đối tượng report và gán nguồn dữ liệu
            //rptNhaThauCongTrinh report = new rptNhaThauCongTrinh();
            //report.SetDataSource(ds);

            //// Gán tham số cho báo cáo (nếu báo cáo sử dụng tham số)
            //report.SetParameterValue("@tenCongTrinh", tenCongTrinh); // "tenCongTrinh" là tham số trong báo cáo

            //// Tạo form chứa CrystalReportViewer
            //reportNTCT frm = new reportNTCT(); // Form có CrystalReportViewer
            //frm.crystalReportViewer1.ReportSource = report;
            //frm.crystalReportViewer1.Refresh();
            //frm.Show();





        }
    }
}
