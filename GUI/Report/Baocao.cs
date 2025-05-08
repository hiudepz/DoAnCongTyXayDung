using BLL;
using CrystalDecisions.CrystalReports.Engine;
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
    public partial class Baocao: Form
    {
        public Baocao()
        {
            InitializeComponent();
        }
        private BLL_Congtrinh_Admin bll =  new BLL_Congtrinh_Admin();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BaoCao_User_Load(object sender, EventArgs e)
        {
            cbbLoaiBaoCao.Items.Add("Danh sách nhân công theo công trình");
            cbbLoaiBaoCao.Items.Add("Báo cáo tiến độ theo công trình");
            cbbLoaiBaoCao.Items.Add("Báo cáo chi phí tổng");
            cbbCongTrinh.DataSource = bll.GetConstructionList();
            cbbCongTrinh.ValueMember  = "id";
            cbbCongTrinh.DisplayMember = "ten";
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            string loaiBaoCao = cbbLoaiBaoCao.SelectedItem.ToString();
            ReportDocument report = new ReportDocument();

            switch (loaiBaoCao)
            {
                case "Danh sách nhân công theo công trình":
                    report.Load(@"C:\Users\Nguyenthithanhthao\source\repos\hiudepz\DoAnCongTyXayDung\GUI\Report\rptDanhSachNhanCongTheoCongTrinh.rpt");
                    report.SetParameterValue("@CongTrinhID", Convert.ToInt32(cbbCongTrinh.SelectedValue));
                    break;

                case "Báo cáo tiến độ theo công trình":
                    report.Load(@"C:\Users\Nguyenthithanhthao\source\repos\hiudepz\DoAnCongTyXayDung\GUI\Report\rptTienDoCongTrinhTheoIdCongTrinh.rpt");
                    report.SetParameterValue("@CongTrinhID", Convert.ToInt32(cbbCongTrinh.SelectedValue));
                    break;

                case "Báo cáo chi phí tổng":
                    report.Load(@"C:\Users\Nguyenthithanhthao\source\repos\hiudepz\DoAnCongTyXayDung\GUI\Report\ChiPhiTongTheoIdCongTrinh.rpt");
                    report.SetParameterValue("@CongTrinhID", Convert.ToInt32(cbbCongTrinh.SelectedValue));
                    break;
            }

            crystalReportViewerAll.ReportSource = report;
            crystalReportViewerAll.Refresh();
        }
    }
   
}
