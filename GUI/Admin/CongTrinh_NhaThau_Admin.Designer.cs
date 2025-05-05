namespace GUI.Admin
{
    partial class CongTrinh_NhaThau_Admin
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
            this.cbbIdNT = new System.Windows.Forms.ComboBox();
            this.txtVaitro = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvCT_NT_Admin = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTimcongtrinh_admin = new System.Windows.Forms.Button();
            this.txtKeywordcongtrinh_admin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_NT_Admin)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbIdCT
            // 
            this.cbbIdCT.FormattingEnabled = true;
            this.cbbIdCT.Location = new System.Drawing.Point(165, 86);
            this.cbbIdCT.Margin = new System.Windows.Forms.Padding(4);
            this.cbbIdCT.Name = "cbbIdCT";
            this.cbbIdCT.Size = new System.Drawing.Size(160, 24);
            this.cbbIdCT.TabIndex = 0;
            // 
            // cbbIdNT
            // 
            this.cbbIdNT.FormattingEnabled = true;
            this.cbbIdNT.Location = new System.Drawing.Point(165, 160);
            this.cbbIdNT.Margin = new System.Windows.Forms.Padding(4);
            this.cbbIdNT.Name = "cbbIdNT";
            this.cbbIdNT.Size = new System.Drawing.Size(160, 24);
            this.cbbIdNT.TabIndex = 1;
            // 
            // txtVaitro
            // 
            this.txtVaitro.Location = new System.Drawing.Point(419, 87);
            this.txtVaitro.Margin = new System.Windows.Forms.Padding(4);
            this.txtVaitro.Name = "txtVaitro";
            this.txtVaitro.Size = new System.Drawing.Size(132, 22);
            this.txtVaitro.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(165, 270);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvCT_NT_Admin
            // 
            this.dgvCT_NT_Admin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCT_NT_Admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT_NT_Admin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCT_NT_Admin.Location = new System.Drawing.Point(0, 369);
            this.dgvCT_NT_Admin.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCT_NT_Admin.Name = "dgvCT_NT_Admin";
            this.dgvCT_NT_Admin.RowHeadersWidth = 51;
            this.dgvCT_NT_Admin.Size = new System.Drawing.Size(1067, 185);
            this.dgvCT_NT_Admin.TabIndex = 4;
            this.dgvCT_NT_Admin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCT_NT_Admin_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Công trình";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nhà thầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vai trò";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(293, 270);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 28);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(433, 268);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 28);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTimcongtrinh_admin
            // 
            this.btnTimcongtrinh_admin.Location = new System.Drawing.Point(962, 341);
            this.btnTimcongtrinh_admin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimcongtrinh_admin.Name = "btnTimcongtrinh_admin";
            this.btnTimcongtrinh_admin.Size = new System.Drawing.Size(75, 23);
            this.btnTimcongtrinh_admin.TabIndex = 14;
            this.btnTimcongtrinh_admin.Text = "Tìm Kiếm ";
            this.btnTimcongtrinh_admin.UseVisualStyleBackColor = true;
            // 
            // txtKeywordcongtrinh_admin
            // 
            this.txtKeywordcongtrinh_admin.Location = new System.Drawing.Point(827, 341);
            this.txtKeywordcongtrinh_admin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKeywordcongtrinh_admin.Name = "txtKeywordcongtrinh_admin";
            this.txtKeywordcongtrinh_admin.Size = new System.Drawing.Size(129, 22);
            this.txtKeywordcongtrinh_admin.TabIndex = 13;
            this.txtKeywordcongtrinh_admin.TextChanged += new System.EventHandler(this.txtKeywordcongtrinh_admin_TextChanged);
            // 
            // CongTrinh_NhaThau_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnTimcongtrinh_admin);
            this.Controls.Add(this.txtKeywordcongtrinh_admin);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCT_NT_Admin);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtVaitro);
            this.Controls.Add(this.cbbIdNT);
            this.Controls.Add(this.cbbIdCT);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CongTrinh_NhaThau_Admin";
            this.Text = "CongTrinh_NhaThau";
            this.Load += new System.EventHandler(this.CongTrinh_NhaThau_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_NT_Admin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbIdCT;
        private System.Windows.Forms.ComboBox cbbIdNT;
        private System.Windows.Forms.TextBox txtVaitro;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvCT_NT_Admin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTimcongtrinh_admin;
        private System.Windows.Forms.TextBox txtKeywordcongtrinh_admin;
    }
}