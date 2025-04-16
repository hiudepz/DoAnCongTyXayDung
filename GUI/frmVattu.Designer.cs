namespace GUI
{
    partial class frmVattu
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
            this.dgvVattu = new System.Windows.Forms.DataGridView();
            this.btnThemvattu = new System.Windows.Forms.Button();
            this.btnXoavattu = new System.Windows.Forms.Button();
            this.btnSuavattu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMavattu = new System.Windows.Forms.TextBox();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.txtDonvitinh = new System.Windows.Forms.TextBox();
            this.nudSoluongtonkho = new System.Windows.Forms.NumericUpDown();
            this.nudMuctonkhotoithieu = new System.Windows.Forms.NumericUpDown();
            this.txtTenvattu = new System.Windows.Forms.TextBox();
            this.txtManhacc = new System.Windows.Forms.TextBox();
            this.ptbVattu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVattu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoluongtonkho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMuctonkhotoithieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVattu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVattu
            // 
            this.dgvVattu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVattu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVattu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvVattu.Location = new System.Drawing.Point(0, 300);
            this.dgvVattu.Name = "dgvVattu";
            this.dgvVattu.Size = new System.Drawing.Size(800, 150);
            this.dgvVattu.TabIndex = 0;
            // 
            // btnThemvattu
            // 
            this.btnThemvattu.Location = new System.Drawing.Point(138, 248);
            this.btnThemvattu.Name = "btnThemvattu";
            this.btnThemvattu.Size = new System.Drawing.Size(75, 23);
            this.btnThemvattu.TabIndex = 1;
            this.btnThemvattu.Text = "Thêm";
            this.btnThemvattu.UseVisualStyleBackColor = true;
            // 
            // btnXoavattu
            // 
            this.btnXoavattu.Location = new System.Drawing.Point(234, 248);
            this.btnXoavattu.Name = "btnXoavattu";
            this.btnXoavattu.Size = new System.Drawing.Size(75, 23);
            this.btnXoavattu.TabIndex = 1;
            this.btnXoavattu.Text = "Xóa";
            this.btnXoavattu.UseVisualStyleBackColor = true;
            // 
            // btnSuavattu
            // 
            this.btnSuavattu.Location = new System.Drawing.Point(337, 248);
            this.btnSuavattu.Name = "btnSuavattu";
            this.btnSuavattu.Size = new System.Drawing.Size(75, 23);
            this.btnSuavattu.TabIndex = 1;
            this.btnSuavattu.Text = "Sửa";
            this.btnSuavattu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã vật tư";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên vật tư";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhà cung cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Đơn vị tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Đơn giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(552, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Hình ảnh";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(514, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Số lượng tồn kho";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(514, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Mức tồn kho tối thiểu";
            // 
            // txtMavattu
            // 
            this.txtMavattu.Location = new System.Drawing.Point(188, 56);
            this.txtMavattu.Name = "txtMavattu";
            this.txtMavattu.Size = new System.Drawing.Size(100, 20);
            this.txtMavattu.TabIndex = 3;
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(372, 97);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(100, 20);
            this.txtDongia.TabIndex = 3;
            // 
            // txtDonvitinh
            // 
            this.txtDonvitinh.Location = new System.Drawing.Point(372, 57);
            this.txtDonvitinh.Name = "txtDonvitinh";
            this.txtDonvitinh.Size = new System.Drawing.Size(100, 20);
            this.txtDonvitinh.TabIndex = 3;
            // 
            // nudSoluongtonkho
            // 
            this.nudSoluongtonkho.Location = new System.Drawing.Point(644, 57);
            this.nudSoluongtonkho.Name = "nudSoluongtonkho";
            this.nudSoluongtonkho.Size = new System.Drawing.Size(120, 20);
            this.nudSoluongtonkho.TabIndex = 4;
            // 
            // nudMuctonkhotoithieu
            // 
            this.nudMuctonkhotoithieu.Location = new System.Drawing.Point(644, 97);
            this.nudMuctonkhotoithieu.Name = "nudMuctonkhotoithieu";
            this.nudMuctonkhotoithieu.Size = new System.Drawing.Size(120, 20);
            this.nudMuctonkhotoithieu.TabIndex = 5;
            // 
            // txtTenvattu
            // 
            this.txtTenvattu.Location = new System.Drawing.Point(188, 96);
            this.txtTenvattu.Name = "txtTenvattu";
            this.txtTenvattu.Size = new System.Drawing.Size(100, 20);
            this.txtTenvattu.TabIndex = 3;
            // 
            // txtManhacc
            // 
            this.txtManhacc.Location = new System.Drawing.Point(188, 137);
            this.txtManhacc.Name = "txtManhacc";
            this.txtManhacc.Size = new System.Drawing.Size(100, 20);
            this.txtManhacc.TabIndex = 3;
            // 
            // ptbVattu
            // 
            this.ptbVattu.Location = new System.Drawing.Point(649, 173);
            this.ptbVattu.Name = "ptbVattu";
            this.ptbVattu.Size = new System.Drawing.Size(115, 98);
            this.ptbVattu.TabIndex = 6;
            this.ptbVattu.TabStop = false;
            // 
            // frmVattu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ptbVattu);
            this.Controls.Add(this.nudMuctonkhotoithieu);
            this.Controls.Add(this.nudSoluongtonkho);
            this.Controls.Add(this.txtDonvitinh);
            this.Controls.Add(this.txtDongia);
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
            this.Controls.Add(this.btnThemvattu);
            this.Controls.Add(this.dgvVattu);
            this.Name = "frmVattu";
            this.Text = "frmVattu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVattu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoluongtonkho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMuctonkhotoithieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVattu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVattu;
        private System.Windows.Forms.Button btnThemvattu;
        private System.Windows.Forms.Button btnXoavattu;
        private System.Windows.Forms.Button btnSuavattu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMavattu;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.TextBox txtDonvitinh;
        private System.Windows.Forms.NumericUpDown nudSoluongtonkho;
        private System.Windows.Forms.NumericUpDown nudMuctonkhotoithieu;
        private System.Windows.Forms.TextBox txtTenvattu;
        private System.Windows.Forms.TextBox txtManhacc;
        private System.Windows.Forms.PictureBox ptbVattu;
    }
}