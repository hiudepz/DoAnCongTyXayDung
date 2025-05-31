namespace GUI.Admin
{
    partial class PhanCong_Admin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDateStart = new System.Windows.Forms.DateTimePicker();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbCongTrinh = new System.Windows.Forms.ComboBox();
            this.dgvNhanCong = new System.Windows.Forms.DataGridView();
            this.ChckNhanCong = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnPhanCong = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvBangPhanCong = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtIdNhanCongvs = new System.Windows.Forms.TextBox();
            this.dtpstartvs = new System.Windows.Forms.DateTimePicker();
            this.txtCongTrinhIdvs = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanCong)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangPhanCong)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.dtpDateStart);
            this.groupBox1.Controls.Add(this.dtpDateEnd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbCongTrinh);
            this.groupBox1.Location = new System.Drawing.Point(335, 157);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(344, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phân Công Nhân Vien";
            // 
            // dtpDateStart
            // 
            this.dtpDateStart.Location = new System.Drawing.Point(151, 54);
            this.dtpDateStart.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDateStart.Name = "dtpDateStart";
            this.dtpDateStart.Size = new System.Drawing.Size(184, 20);
            this.dtpDateStart.TabIndex = 6;
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Location = new System.Drawing.Point(151, 87);
            this.dtpDateEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(184, 20);
            this.dtpDateEnd.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ngày kết thúc :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày bắt đầu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn Công Trình :";
            // 
            // cbbCongTrinh
            // 
            this.cbbCongTrinh.FormattingEnabled = true;
            this.cbbCongTrinh.Location = new System.Drawing.Point(151, 24);
            this.cbbCongTrinh.Margin = new System.Windows.Forms.Padding(2);
            this.cbbCongTrinh.Name = "cbbCongTrinh";
            this.cbbCongTrinh.Size = new System.Drawing.Size(184, 21);
            this.cbbCongTrinh.TabIndex = 0;
            // 
            // dgvNhanCong
            // 
            this.dgvNhanCong.AllowUserToAddRows = false;
            this.dgvNhanCong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvNhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChckNhanCong});
            this.dgvNhanCong.Location = new System.Drawing.Point(4, 17);
            this.dgvNhanCong.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNhanCong.Name = "dgvNhanCong";
            this.dgvNhanCong.RowHeadersWidth = 51;
            this.dgvNhanCong.RowTemplate.Height = 24;
            this.dgvNhanCong.Size = new System.Drawing.Size(537, 292);
            this.dgvNhanCong.TabIndex = 1;
            this.dgvNhanCong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanCong_CellContentClick);
            // 
            // ChckNhanCong
            // 
            this.ChckNhanCong.HeaderText = "Chọn";
            this.ChckNhanCong.MinimumWidth = 6;
            this.ChckNhanCong.Name = "ChckNhanCong";
            this.ChckNhanCong.Width = 125;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimKiem.Location = new System.Drawing.Point(1073, 306);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(56, 19);
            this.btnTimKiem.TabIndex = 14;
            this.btnTimKiem.Text = "Tìm Kiếm ";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Location = new System.Drawing.Point(969, 306);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(98, 20);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnPhanCong
            // 
            this.btnPhanCong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPhanCong.Location = new System.Drawing.Point(335, 272);
            this.btnPhanCong.Margin = new System.Windows.Forms.Padding(2);
            this.btnPhanCong.Name = "btnPhanCong";
            this.btnPhanCong.Size = new System.Drawing.Size(68, 19);
            this.btnPhanCong.TabIndex = 16;
            this.btnPhanCong.Text = "Phân Công";
            this.btnPhanCong.UseVisualStyleBackColor = true;
            this.btnPhanCong.Click += new System.EventHandler(this.btnPhanCong_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.dgvNhanCong);
            this.groupBox2.Location = new System.Drawing.Point(122, 330);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(557, 335);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn Nhân Công";
            // 
            // dgvBangPhanCong
            // 
            this.dgvBangPhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangPhanCong.Location = new System.Drawing.Point(20, 25);
            this.dgvBangPhanCong.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBangPhanCong.Name = "dgvBangPhanCong";
            this.dgvBangPhanCong.RowHeadersWidth = 51;
            this.dgvBangPhanCong.RowTemplate.Height = 24;
            this.dgvBangPhanCong.Size = new System.Drawing.Size(537, 292);
            this.dgvBangPhanCong.TabIndex = 2;
            this.dgvBangPhanCong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangPhanCong_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.dgvBangPhanCong);
            this.groupBox3.Location = new System.Drawing.Point(725, 330);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(586, 335);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bảng Phân Công";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.Location = new System.Drawing.Point(947, 265);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(56, 19);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtIdNhanCongvs
            // 
            this.txtIdNhanCongvs.Location = new System.Drawing.Point(34, 40);
            this.txtIdNhanCongvs.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdNhanCongvs.Name = "txtIdNhanCongvs";
            this.txtIdNhanCongvs.Size = new System.Drawing.Size(113, 20);
            this.txtIdNhanCongvs.TabIndex = 19;
            // 
            // dtpstartvs
            // 
            this.dtpstartvs.Location = new System.Drawing.Point(34, 63);
            this.dtpstartvs.Margin = new System.Windows.Forms.Padding(2);
            this.dtpstartvs.Name = "dtpstartvs";
            this.dtpstartvs.Size = new System.Drawing.Size(151, 20);
            this.dtpstartvs.TabIndex = 20;
            // 
            // txtCongTrinhIdvs
            // 
            this.txtCongTrinhIdvs.Location = new System.Drawing.Point(34, 17);
            this.txtCongTrinhIdvs.Margin = new System.Windows.Forms.Padding(2);
            this.txtCongTrinhIdvs.Name = "txtCongTrinhIdvs";
            this.txtCongTrinhIdvs.Size = new System.Drawing.Size(113, 20);
            this.txtCongTrinhIdvs.TabIndex = 19;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.txtCongTrinhIdvs);
            this.groupBox4.Controls.Add(this.dtpstartvs);
            this.groupBox4.Controls.Add(this.txtIdNhanCongvs);
            this.groupBox4.Location = new System.Drawing.Point(831, 170);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(190, 90);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Phân công";
            // 
            // PhanCong_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1443, 839);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnPhanCong);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PhanCong_Admin";
            this.Text = "PhanCong_Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PhanCong_Admin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanCong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangPhanCong)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbCongTrinh;
        private System.Windows.Forms.DateTimePicker dtpDateStart;
        private System.Windows.Forms.DateTimePicker dtpDateEnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvNhanCong;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnPhanCong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvBangPhanCong;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ChckNhanCong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtIdNhanCongvs;
        private System.Windows.Forms.DateTimePicker dtpstartvs;
        private System.Windows.Forms.TextBox txtCongTrinhIdvs;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}