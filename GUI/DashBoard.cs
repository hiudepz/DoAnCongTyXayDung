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
    public partial class Dashboard_User : Form
    {
        public Dashboard_User()
        {
            InitializeComponent();

            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }
       
        private void btnVattu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNhancong_Click(object sender, EventArgs e)
        {

        }

        private void vattuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Visible = false;
            frmVattu vt = new frmVattu();
            vt.MdiParent = this;
            vt.Dock = DockStyle.Fill;
            vt.Show();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
