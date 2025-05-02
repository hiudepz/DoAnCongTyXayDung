namespace GUI.Admin
{
    partial class CongTrinh_VatTu_Admin
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
            this.cbbIdCT = new System.Windows.Forms.ComboBox();
            this.cbbIdVT = new System.Windows.Forms.ComboBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvCT_VT_Admin = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgaysudung = new System.Windows.Forms.DateTimePicker();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_VT_Admin)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbIdCT
            // 
            this.cbbIdCT.FormattingEnabled = true;
            this.cbbIdCT.Location = new System.Drawing.Point(124, 70);
            this.cbbIdCT.Name = "cbbIdCT";
            this.cbbIdCT.Size = new System.Drawing.Size(121, 21);
            this.cbbIdCT.TabIndex = 0;
            // 
            // cbbIdVT
            // 
            this.cbbIdVT.FormattingEnabled = true;
            this.cbbIdVT.Location = new System.Drawing.Point(124, 130);
            this.cbbIdVT.Name = "cbbIdVT";
            this.cbbIdVT.Size = new System.Drawing.Size(121, 21);
            this.cbbIdVT.TabIndex = 1;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(314, 71);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(100, 20);
            this.txtSoluong.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(124, 219);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvCT_VT_Admin
            // 
            this.dgvCT_VT_Admin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCT_VT_Admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT_VT_Admin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCT_VT_Admin.Location = new System.Drawing.Point(0, 300);
            this.dgvCT_VT_Admin.Name = "dgvCT_VT_Admin";
            this.dgvCT_VT_Admin.Size = new System.Drawing.Size(800, 150);
            this.dgvCT_VT_Admin.TabIndex = 4;
            this.dgvCT_VT_Admin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCT_VT_Admin_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Công trình";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vật tư";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vai trò";
            // 
            // dtpNgaysudung
            // 
            this.dtpNgaysudung.Location = new System.Drawing.Point(532, 74);
            this.dtpNgaysudung.Name = "dtpNgaysudung";
            this.dtpNgaysudung.Size = new System.Drawing.Size(200, 20);
            this.dtpNgaysudung.TabIndex = 6;
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(315, 131);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(100, 20);
            this.txtDongia.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Đơn giá";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(233, 219);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(339, 219);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày sử dụng";
            // 
            // CongTrinh_VatTu_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDongia);
            this.Controls.Add(this.dtpNgaysudung);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCT_VT_Admin);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.cbbIdVT);
            this.Controls.Add(this.cbbIdCT);
            this.Name = "CongTrinh_VatTu_Admin";
            this.Text = "CongTrinh_VatTu";
            this.Load += new System.EventHandler(this.CongTrinh_VatTu_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_VT_Admin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbIdCT;
        private System.Windows.Forms.ComboBox cbbIdVT;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvCT_VT_Admin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgaysudung;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label5;
    }
}