using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using GUI.Report;
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
            





        }
    }
}
