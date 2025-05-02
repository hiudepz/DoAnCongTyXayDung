using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Report
{
    public partial class reportDanhSachVatTuVaTongChiPhi : Form
    {
        public reportDanhSachVatTuVaTongChiPhi()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            rptDanhSachVatTuVaTongChiPhi t = new rptDanhSachVatTuVaTongChiPhi();
            ParameterValues pars = new ParameterValues();
            ParameterDiscreteValue pa = new ParameterDiscreteValue();
            pa.Value = txtTenCongTrinh.Text;
            pars.Add(pa);
            t.DataDefinition.ParameterFields["@tenCongTrinh"].ApplyCurrentValues(pars);
            crystalReportViewer1.ReportSource = t;
            //Kiểm tra nếu ko thấy 
            if (t.Rows.Count == 0)
            {
                MessageBox.Show($"Không tìm thấy {txtTenCongTrinh.Text}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
