namespace GUI.User
{
    partial class PhanCong_User
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
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvBangPhanCong = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtIdNhanCongvs = new System.Windows.Forms.TextBox();
            this.dtpstartvs = new System.Windows.Forms.DateTimePicker();
            this.txtCongTrinhIdvs = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangPhanCong)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDateStart);
            this.groupBox1.Controls.Add(this.dtpDateEnd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbCongTrinh);
            this.groupBox1.Location = new System.Drawing.Point(574, 188);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(459, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phân Công Nhân Vien";
            // 
            // dtpDateStart
            // 
            this.dtpDateStart.Location = new System.Drawing.Point(201, 66);
            this.dtpDateStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDateStart.Name = "dtpDateStart";
            this.dtpDateStart.Size = new System.Drawing.Size(244, 22);
            this.dtpDateStart.TabIndex = 6;
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Location = new System.Drawing.Point(201, 107);
            this.dtpDateEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(244, 22);
            this.dtpDateEnd.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ngày kết thúc :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày bắt đầu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn Công Trình :";
            // 
            // cbbCongTrinh
            // 
            this.cbbCongTrinh.FormattingEnabled = true;
            this.cbbCongTrinh.Location = new System.Drawing.Point(201, 30);
            this.cbbCongTrinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbCongTrinh.Name = "cbbCongTrinh";
            this.cbbCongTrinh.Size = new System.Drawing.Size(244, 24);
            this.cbbCongTrinh.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(1278, 330);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 14;
            this.btnTimKiem.Text = "Tìm Kiếm ";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1141, 330);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(129, 22);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvBangPhanCong
            // 
            this.dgvBangPhanCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBangPhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangPhanCong.Location = new System.Drawing.Point(6, 21);
            this.dgvBangPhanCong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBangPhanCong.Name = "dgvBangPhanCong";
            this.dgvBangPhanCong.RowHeadersWidth = 51;
            this.dgvBangPhanCong.RowTemplate.Height = 24;
            this.dgvBangPhanCong.Size = new System.Drawing.Size(742, 302);
            this.dgvBangPhanCong.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvBangPhanCong);
            this.groupBox3.Location = new System.Drawing.Point(467, 359);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(754, 329);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bảng Phân Công";
            // 
            // txtIdNhanCongvs
            // 
            this.txtIdNhanCongvs.Location = new System.Drawing.Point(45, 49);
            this.txtIdNhanCongvs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdNhanCongvs.Name = "txtIdNhanCongvs";
            this.txtIdNhanCongvs.Size = new System.Drawing.Size(149, 22);
            this.txtIdNhanCongvs.TabIndex = 19;
            // 
            // dtpstartvs
            // 
            this.dtpstartvs.Location = new System.Drawing.Point(45, 78);
            this.dtpstartvs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpstartvs.Name = "dtpstartvs";
            this.dtpstartvs.Size = new System.Drawing.Size(200, 22);
            this.dtpstartvs.TabIndex = 20;
            // 
            // txtCongTrinhIdvs
            // 
            this.txtCongTrinhIdvs.Location = new System.Drawing.Point(45, 21);
            this.txtCongTrinhIdvs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCongTrinhIdvs.Name = "txtCongTrinhIdvs";
            this.txtCongTrinhIdvs.Size = new System.Drawing.Size(149, 22);
            this.txtCongTrinhIdvs.TabIndex = 19;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtCongTrinhIdvs);
            this.groupBox4.Controls.Add(this.dtpstartvs);
            this.groupBox4.Controls.Add(this.txtIdNhanCongvs);
            this.groupBox4.Location = new System.Drawing.Point(1063, 157);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(253, 111);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Phân công";
            // 
            // PhanCong_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1033);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PhanCong_User";
            this.Text = "PhanCong_User";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PhanCong_User_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvBangPhanCong;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtIdNhanCongvs;
        private System.Windows.Forms.DateTimePicker dtpstartvs;
        private System.Windows.Forms.TextBox txtCongTrinhIdvs;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}