namespace GUI.Admin
{
    partial class TienDo_Admin
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dgvTienDo = new System.Windows.Forms.DataGridView();
            this.txtPhanTram = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgayCaoNhat = new System.Windows.Forms.DateTimePicker();
            this.cbbCongTrinh = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.ChartTienDo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienDo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTienDo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(736, 6);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.Text = "Tìm Kiếm ";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(195, 157);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(97, 157);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // dgvTienDo
            // 
            this.dgvTienDo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTienDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTienDo.Location = new System.Drawing.Point(12, 206);
            this.dgvTienDo.Name = "dgvTienDo";
            this.dgvTienDo.RowHeadersWidth = 51;
            this.dgvTienDo.RowTemplate.Height = 24;
            this.dgvTienDo.Size = new System.Drawing.Size(611, 324);
            this.dgvTienDo.TabIndex = 8;
            this.dgvTienDo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTienDo_CellContentClick);
            // 
            // txtPhanTram
            // 
            this.txtPhanTram.Location = new System.Drawing.Point(473, 81);
            this.txtPhanTram.Name = "txtPhanTram";
            this.txtPhanTram.Size = new System.Drawing.Size(130, 22);
            this.txtPhanTram.TabIndex = 3;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(473, 46);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(130, 22);
            this.txtMoTa.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phần trăm hoàn thành :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày Cập Nhật : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mô tả :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Công trình : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgayCaoNhat);
            this.groupBox1.Controls.Add(this.cbbCongTrinh);
            this.groupBox1.Controls.Add(this.txtPhanTram);
            this.groupBox1.Controls.Add(this.txtMoTa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(97, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(813, 120);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiến độ công trình ";
            // 
            // dtpNgayCaoNhat
            // 
            this.dtpNgayCaoNhat.Location = new System.Drawing.Point(134, 80);
            this.dtpNgayCaoNhat.Name = "dtpNgayCaoNhat";
            this.dtpNgayCaoNhat.Size = new System.Drawing.Size(172, 22);
            this.dtpNgayCaoNhat.TabIndex = 5;
            // 
            // cbbCongTrinh
            // 
            this.cbbCongTrinh.FormattingEnabled = true;
            this.cbbCongTrinh.Location = new System.Drawing.Point(134, 44);
            this.cbbCongTrinh.Name = "cbbCongTrinh";
            this.cbbCongTrinh.Size = new System.Drawing.Size(130, 24);
            this.cbbCongTrinh.TabIndex = 4;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(579, 7);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(130, 22);
            this.txtTimKiem.TabIndex = 10;
            // 
            // ChartTienDo
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartTienDo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartTienDo.Legends.Add(legend1);
            this.ChartTienDo.Location = new System.Drawing.Point(629, 217);
            this.ChartTienDo.Name = "ChartTienDo";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Tiến độ";
            this.ChartTienDo.Series.Add(series1);
            this.ChartTienDo.Size = new System.Drawing.Size(430, 300);
            this.ChartTienDo.TabIndex = 14;
            this.ChartTienDo.Text = "chart1";
            title1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Bảng theo dõi tiến độ ";
            this.ChartTienDo.Titles.Add(title1);
            // 
            // TienDo_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ChartTienDo);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgvTienDo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTimKiem);
            this.Name = "TienDo_Admin";
            this.Text = "TienDo_Admin";
            this.Load += new System.EventHandler(this.TienDo_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienDo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTienDo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dgvTienDo;
        private System.Windows.Forms.TextBox txtPhanTram;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cbbCongTrinh;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartTienDo;
        private System.Windows.Forms.DateTimePicker dtpNgayCaoNhat;
    }
}