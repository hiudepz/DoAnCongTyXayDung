namespace GUI.Admin
{
    partial class VatTu_Admin
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
            this.pbVattu = new System.Windows.Forms.PictureBox();
            this.nudMuctonkhotoithieu = new System.Windows.Forms.NumericUpDown();
            this.nudSoluongtonkho = new System.Windows.Forms.NumericUpDown();
            this.txtDonvitinh = new System.Windows.Forms.TextBox();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.txtManhacc = new System.Windows.Forms.TextBox();
            this.txtTenvattu = new System.Windows.Forms.TextBox();
            this.txtMavattu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSuavattu = new System.Windows.Forms.Button();
            this.btnXoavattu = new System.Windows.Forms.Button();
            this.btnThemvattu = new System.Windows.Forms.Button();
            this.dgvVattu = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtUrlanhvattu_Admin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbVattu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMuctonkhotoithieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoluongtonkho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVattu)).BeginInit();
            this.SuspendLayout();
            // 
            // pbVattu
            // 
            this.pbVattu.Location = new System.Drawing.Point(567, 145);
            this.pbVattu.Name = "pbVattu";
            this.pbVattu.Size = new System.Drawing.Size(115, 98);
            this.pbVattu.TabIndex = 26;
            this.pbVattu.TabStop = false;
            this.pbVattu.Click += new System.EventHandler(this.pbVattu_Click);
            // 
            // nudMuctonkhotoithieu
            // 
            this.nudMuctonkhotoithieu.Location = new System.Drawing.Point(562, 69);
            this.nudMuctonkhotoithieu.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.nudMuctonkhotoithieu.Name = "nudMuctonkhotoithieu";
            this.nudMuctonkhotoithieu.Size = new System.Drawing.Size(120, 20);
            this.nudMuctonkhotoithieu.TabIndex = 25;
            // 
            // nudSoluongtonkho
            // 
            this.nudSoluongtonkho.Location = new System.Drawing.Point(562, 29);
            this.nudSoluongtonkho.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudSoluongtonkho.Name = "nudSoluongtonkho";
            this.nudSoluongtonkho.Size = new System.Drawing.Size(120, 20);
            this.nudSoluongtonkho.TabIndex = 24;
            // 
            // txtDonvitinh
            // 
            this.txtDonvitinh.Location = new System.Drawing.Point(290, 29);
            this.txtDonvitinh.Name = "txtDonvitinh";
            this.txtDonvitinh.Size = new System.Drawing.Size(100, 20);
            this.txtDonvitinh.TabIndex = 23;
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(290, 69);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(100, 20);
            this.txtDongia.TabIndex = 22;
            // 
            // txtManhacc
            // 
            this.txtManhacc.Location = new System.Drawing.Point(106, 110);
            this.txtManhacc.Name = "txtManhacc";
            this.txtManhacc.Size = new System.Drawing.Size(100, 20);
            this.txtManhacc.TabIndex = 21;
            // 
            // txtTenvattu
            // 
            this.txtTenvattu.Location = new System.Drawing.Point(106, 68);
            this.txtTenvattu.Name = "txtTenvattu";
            this.txtTenvattu.Size = new System.Drawing.Size(100, 20);
            this.txtTenvattu.TabIndex = 20;
            // 
            // txtMavattu
            // 
            this.txtMavattu.Location = new System.Drawing.Point(106, 28);
            this.txtMavattu.Name = "txtMavattu";
            this.txtMavattu.Size = new System.Drawing.Size(100, 20);
            this.txtMavattu.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(432, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Mức tồn kho tối thiểu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(432, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Số lượng tồn kho";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(598, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Hình ảnh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Đơn vị tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nhà cung cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên vật tư";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã vật tư";
            // 
            // btnSuavattu
            // 
            this.btnSuavattu.Location = new System.Drawing.Point(255, 220);
            this.btnSuavattu.Name = "btnSuavattu";
            this.btnSuavattu.Size = new System.Drawing.Size(75, 23);
            this.btnSuavattu.TabIndex = 9;
            this.btnSuavattu.Text = "Sửa";
            this.btnSuavattu.UseVisualStyleBackColor = true;
            this.btnSuavattu.Click += new System.EventHandler(this.btnSuavattu_Click);
            // 
            // btnXoavattu
            // 
            this.btnXoavattu.Location = new System.Drawing.Point(152, 220);
            this.btnXoavattu.Name = "btnXoavattu";
            this.btnXoavattu.Size = new System.Drawing.Size(75, 23);
            this.btnXoavattu.TabIndex = 8;
            this.btnXoavattu.Text = "Xóa";
            this.btnXoavattu.UseVisualStyleBackColor = true;
            this.btnXoavattu.Click += new System.EventHandler(this.btnXoavattu_Click);
            // 
            // btnThemvattu
            // 
            this.btnThemvattu.Location = new System.Drawing.Point(56, 220);
            this.btnThemvattu.Name = "btnThemvattu";
            this.btnThemvattu.Size = new System.Drawing.Size(75, 23);
            this.btnThemvattu.TabIndex = 10;
            this.btnThemvattu.Text = "Thêm";
            this.btnThemvattu.UseVisualStyleBackColor = true;
            this.btnThemvattu.Click += new System.EventHandler(this.btnThemvattu_Click);
            // 
            // dgvVattu
            // 
            this.dgvVattu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVattu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVattu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvVattu.Location = new System.Drawing.Point(0, 300);
            this.dgvVattu.Name = "dgvVattu";
            this.dgvVattu.RowHeadersWidth = 51;
            this.dgvVattu.Size = new System.Drawing.Size(800, 150);
            this.dgvVattu.TabIndex = 7;
            this.dgvVattu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVattu_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Thêm ảnh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUrlanhvattu_Admin
            // 
            this.txtUrlanhvattu_Admin.Location = new System.Drawing.Point(442, 191);
            this.txtUrlanhvattu_Admin.Name = "txtUrlanhvattu_Admin";
            this.txtUrlanhvattu_Admin.Size = new System.Drawing.Size(100, 20);
            this.txtUrlanhvattu_Admin.TabIndex = 21;
            // 
            // VatTu_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbVattu);
            this.Controls.Add(this.nudMuctonkhotoithieu);
            this.Controls.Add(this.nudSoluongtonkho);
            this.Controls.Add(this.txtDonvitinh);
            this.Controls.Add(this.txtDongia);
            this.Controls.Add(this.txtUrlanhvattu_Admin);
            this.Controls.Add(this.txtManhacc);
            this.Controls.Add(this.txtTenvattu);
            this.Controls.Add(this.txtMavattu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSuavattu);
            this.Controls.Add(this.btnXoavattu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThemvattu);
            this.Controls.Add(this.dgvVattu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VatTu_Admin";
            this.Text = "VatTu_Adin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VatTu_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbVattu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMuctonkhotoithieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoluongtonkho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVattu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbVattu;
        private System.Windows.Forms.NumericUpDown nudMuctonkhotoithieu;
        private System.Windows.Forms.NumericUpDown nudSoluongtonkho;
        private System.Windows.Forms.TextBox txtDonvitinh;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.TextBox txtManhacc;
        private System.Windows.Forms.TextBox txtTenvattu;
        private System.Windows.Forms.TextBox txtMavattu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSuavattu;
        private System.Windows.Forms.Button btnXoavattu;
        private System.Windows.Forms.Button btnThemvattu;
        private System.Windows.Forms.DataGridView dgvVattu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUrlanhvattu_Admin;
    }
}