namespace GUI.User
{
    partial class TienDo_User
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtPhantramhoanthanh = new System.Windows.Forms.TextBox();
            this.txtMotatiendo = new System.Windows.Forms.TextBox();
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
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(721, 294);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 20;
            this.button1.Text = "Tìm Kiếm ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtPhantramhoanthanh
            // 
            this.txtPhantramhoanthanh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhantramhoanthanh.Location = new System.Drawing.Point(355, 66);
            this.txtPhantramhoanthanh.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhantramhoanthanh.Name = "txtPhantramhoanthanh";
            this.txtPhantramhoanthanh.Size = new System.Drawing.Size(98, 20);
            this.txtPhantramhoanthanh.TabIndex = 3;
            // 
            // txtMotatiendo
            // 
            this.txtMotatiendo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMotatiendo.Location = new System.Drawing.Point(355, 37);
            this.txtMotatiendo.Margin = new System.Windows.Forms.Padding(2);
            this.txtMotatiendo.Name = "txtMotatiendo";
            this.txtMotatiendo.Size = new System.Drawing.Size(98, 20);
            this.txtMotatiendo.TabIndex = 3;
            // 
            // dgvTienDo
            // 
            this.dgvTienDo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTienDo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTienDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTienDo.Location = new System.Drawing.Point(166, 317);
            this.dgvTienDo.Name = "dgvTienDo";
            this.dgvTienDo.RowHeadersWidth = 51;
            this.dgvTienDo.RowTemplate.Height = 24;
            this.dgvTienDo.Size = new System.Drawing.Size(611, 343);
            this.dgvTienDo.TabIndex = 16;
            this.dgvTienDo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTienDo_CellContentClick);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phần trăm hoàn thành :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày Cập Nhật : ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mô tả :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Công trình : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.dtpNgaycapnhattiendo);
            this.groupBox1.Controls.Add(this.cbbTiendoct);
            this.groupBox1.Controls.Add(this.txtPhantramhoanthanh);
            this.groupBox1.Controls.Add(this.txtMotatiendo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(166, 164);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(661, 98);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiến độ công trình ";
            // 
            // dtpNgaycapnhattiendo
            // 
            this.dtpNgaycapnhattiendo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpNgaycapnhattiendo.Location = new System.Drawing.Point(102, 63);
            this.dtpNgaycapnhattiendo.Name = "dtpNgaycapnhattiendo";
            this.dtpNgaycapnhattiendo.Size = new System.Drawing.Size(127, 20);
            this.dtpNgaycapnhattiendo.TabIndex = 5;
            // 
            // cbbTiendoct
            // 
            this.cbbTiendoct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbTiendoct.FormattingEnabled = true;
            this.cbbTiendoct.Location = new System.Drawing.Point(100, 36);
            this.cbbTiendoct.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTiendoct.Name = "cbbTiendoct";
            this.cbbTiendoct.Size = new System.Drawing.Size(98, 21);
            this.cbbTiendoct.TabIndex = 4;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox7.Location = new System.Drawing.Point(621, 294);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(98, 20);
            this.textBox7.TabIndex = 17;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // ChartTienDo
            // 
            this.ChartTienDo.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea1.Name = "ChartArea1";
            this.ChartTienDo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartTienDo.Legends.Add(legend1);
            this.ChartTienDo.Location = new System.Drawing.Point(832, 317);
            this.ChartTienDo.Name = "ChartTienDo";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Tiến độ";
            this.ChartTienDo.Series.Add(series1);
            this.ChartTienDo.Size = new System.Drawing.Size(430, 343);
            this.ChartTienDo.TabIndex = 21;
            this.ChartTienDo.Text = "chart1";
            title1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Bảng theo dõi tiến độ ";
            this.ChartTienDo.Titles.Add(title1);
            // 
            // TienDo_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1443, 839);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvTienDo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.ChartTienDo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TienDo_User";
            this.Text = "TienDo2_User";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TienDo_User_Load);
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