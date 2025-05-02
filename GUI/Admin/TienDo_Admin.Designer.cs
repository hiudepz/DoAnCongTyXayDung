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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPhantramhoanthanh = new System.Windows.Forms.TextBox();
            this.txtMotatiendo = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dgvTienDo = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgaycapnhattiendo = new System.Windows.Forms.DateTimePicker();
            this.cbbTiendoct = new System.Windows.Forms.ComboBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.ChartTienDo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienDo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTienDo)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(733, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Tìm Kiếm ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtPhantramhoanthanh
            // 
            this.txtPhantramhoanthanh.Location = new System.Drawing.Point(473, 81);
            this.txtPhantramhoanthanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhantramhoanthanh.Name = "txtPhantramhoanthanh";
            this.txtPhantramhoanthanh.Size = new System.Drawing.Size(129, 22);
            this.txtPhantramhoanthanh.TabIndex = 3;
            // 
            // txtMotatiendo
            // 
            this.txtMotatiendo.Location = new System.Drawing.Point(473, 46);
            this.txtMotatiendo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMotatiendo.Name = "txtMotatiendo";
            this.txtMotatiendo.Size = new System.Drawing.Size(129, 22);
            this.txtMotatiendo.TabIndex = 3;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(257, 193);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 28);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(126, 193);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 28);
            this.btnLuu.TabIndex = 19;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dgvTienDo
            // 
            this.dgvTienDo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTienDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTienDo.Location = new System.Drawing.Point(13, 254);
            this.dgvTienDo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTienDo.Name = "dgvTienDo";
            this.dgvTienDo.RowHeadersWidth = 51;
            this.dgvTienDo.RowTemplate.Height = 24;
            this.dgvTienDo.Size = new System.Drawing.Size(815, 422);
            this.dgvTienDo.TabIndex = 16;
            this.dgvTienDo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTienDo_CellContentClick);
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
            this.groupBox1.Controls.Add(this.dtpNgaycapnhattiendo);
            this.groupBox1.Controls.Add(this.cbbTiendoct);
            this.groupBox1.Controls.Add(this.txtPhantramhoanthanh);
            this.groupBox1.Controls.Add(this.txtMotatiendo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(94, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(881, 121);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiến độ công trình ";
            // 
            // dtpNgaycapnhattiendo
            // 
            this.dtpNgaycapnhattiendo.Location = new System.Drawing.Point(136, 78);
            this.dtpNgaycapnhattiendo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgaycapnhattiendo.Name = "dtpNgaycapnhattiendo";
            this.dtpNgaycapnhattiendo.Size = new System.Drawing.Size(168, 22);
            this.dtpNgaycapnhattiendo.TabIndex = 5;
            // 
            // cbbTiendoct
            // 
            this.cbbTiendoct.FormattingEnabled = true;
            this.cbbTiendoct.Location = new System.Drawing.Point(133, 44);
            this.cbbTiendoct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTiendoct.Name = "cbbTiendoct";
            this.cbbTiendoct.Size = new System.Drawing.Size(129, 24);
            this.cbbTiendoct.TabIndex = 4;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(576, 7);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(129, 22);
            this.textBox7.TabIndex = 17;
            // 
            // ChartTienDo
            // 
            chartArea4.Name = "ChartArea1";
            this.ChartTienDo.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.ChartTienDo.Legends.Add(legend4);
            this.ChartTienDo.Location = new System.Drawing.Point(836, 254);
            this.ChartTienDo.Margin = new System.Windows.Forms.Padding(4);
            this.ChartTienDo.Name = "ChartTienDo";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Tiến độ";
            this.ChartTienDo.Series.Add(series4);
            this.ChartTienDo.Size = new System.Drawing.Size(573, 422);
            this.ChartTienDo.TabIndex = 21;
            this.ChartTienDo.Text = "chart1";
            title4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.Name = "Title1";
            title4.Text = "Bảng theo dõi tiến độ ";
            this.ChartTienDo.Titles.Add(title4);
            // 
            // TienDo2_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 682);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgvTienDo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.ChartTienDo);
            this.Name = "TienDo2_Admin";
            this.Text = "TienDo2_Admin";
            this.Load += new System.EventHandler(this.TienDo2_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienDo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTienDo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPhantramhoanthanh;
        private System.Windows.Forms.TextBox txtMotatiendo;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dgvTienDo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNgaycapnhattiendo;
        private System.Windows.Forms.ComboBox cbbTiendoct;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartTienDo;
    }
}