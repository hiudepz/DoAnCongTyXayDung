namespace GUI
{
    partial class reportNTCT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txtTimNhaThauTheoCongTrinh = new System.Windows.Forms.TextBox();
            this.btnTimNhaThauTheoCongTrinh = new System.Windows.Forms.Button();
            this.rptNhaThauCongTrinh1 = new GUI.rptNhaThauCongTrinh();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.rptNhaThauCongTrinh1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1055, 538);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // txtTimNhaThauTheoCongTrinh
            // 
            this.txtTimNhaThauTheoCongTrinh.Location = new System.Drawing.Point(358, 36);
            this.txtTimNhaThauTheoCongTrinh.Name = "txtTimNhaThauTheoCongTrinh";
            this.txtTimNhaThauTheoCongTrinh.Size = new System.Drawing.Size(100, 20);
            this.txtTimNhaThauTheoCongTrinh.TabIndex = 1;
            // 
            // btnTimNhaThauTheoCongTrinh
            // 
            this.btnTimNhaThauTheoCongTrinh.Location = new System.Drawing.Point(358, 63);
            this.btnTimNhaThauTheoCongTrinh.Name = "btnTimNhaThauTheoCongTrinh";
            this.btnTimNhaThauTheoCongTrinh.Size = new System.Drawing.Size(75, 23);
            this.btnTimNhaThauTheoCongTrinh.TabIndex = 2;
            this.btnTimNhaThauTheoCongTrinh.Text = "Search";
            this.btnTimNhaThauTheoCongTrinh.UseVisualStyleBackColor = true;
            this.btnTimNhaThauTheoCongTrinh.Click += new System.EventHandler(this.btnTimNhaThauTheoCongTrinh_Click);
            // 
            // reportNTCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 538);
            this.Controls.Add(this.btnTimNhaThauTheoCongTrinh);
            this.Controls.Add(this.txtTimNhaThauTheoCongTrinh);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "reportNTCT";
            this.Text = "reportNTCT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.TextBox txtTimNhaThauTheoCongTrinh;
        private System.Windows.Forms.Button btnTimNhaThauTheoCongTrinh;
        private rptNhaThauCongTrinh rptNhaThauCongTrinh1;
    }
}