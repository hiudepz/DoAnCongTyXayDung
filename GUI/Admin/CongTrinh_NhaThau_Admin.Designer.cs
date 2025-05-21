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
            this.cbbIdCT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbIdCT.FormattingEnabled = true;
            this.cbbIdCT.Location = new System.Drawing.Point(596, 72);
            this.cbbIdCT.Name = "cbbIdCT";
            this.cbbIdCT.Size = new System.Drawing.Size(121, 21);
            this.cbbIdCT.TabIndex = 0;
            // 
            // cbbIdNT
            // 
            this.cbbIdNT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbIdNT.FormattingEnabled = true;
            this.cbbIdNT.Location = new System.Drawing.Point(596, 132);
            this.cbbIdNT.Name = "cbbIdNT";
            this.cbbIdNT.Size = new System.Drawing.Size(121, 21);
            this.cbbIdNT.TabIndex = 1;
            // 
            // txtVaitro
            // 
            this.txtVaitro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVaitro.Location = new System.Drawing.Point(787, 73);
            this.txtVaitro.Name = "txtVaitro";
            this.txtVaitro.Size = new System.Drawing.Size(100, 20);
            this.txtVaitro.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Location = new System.Drawing.Point(596, 221);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
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
            this.dgvCT_NT_Admin.Location = new System.Drawing.Point(0, 360);
            this.dgvCT_NT_Admin.Name = "dgvCT_NT_Admin";
            this.dgvCT_NT_Admin.RowHeadersWidth = 51;
            this.dgvCT_NT_Admin.Size = new System.Drawing.Size(1443, 479);
            this.dgvCT_NT_Admin.TabIndex = 4;
            this.dgvCT_NT_Admin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCT_NT_Admin_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(539, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Công trình";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nhà thầu";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(743, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vai trò";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.Location = new System.Drawing.Point(692, 221);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.Location = new System.Drawing.Point(797, 220);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTimcongtrinh_admin
            // 
            this.btnTimcongtrinh_admin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimcongtrinh_admin.Location = new System.Drawing.Point(1316, 254);
            this.btnTimcongtrinh_admin.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimcongtrinh_admin.Name = "btnTimcongtrinh_admin";
            this.btnTimcongtrinh_admin.Size = new System.Drawing.Size(56, 19);
            this.btnTimcongtrinh_admin.TabIndex = 14;
            this.btnTimcongtrinh_admin.Text = "Tìm Kiếm ";
            this.btnTimcongtrinh_admin.UseVisualStyleBackColor = true;
            // 
            // txtKeywordcongtrinh_admin
            // 
            this.txtKeywordcongtrinh_admin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKeywordcongtrinh_admin.Location = new System.Drawing.Point(1215, 254);
            this.txtKeywordcongtrinh_admin.Margin = new System.Windows.Forms.Padding(2);
            this.txtKeywordcongtrinh_admin.Name = "txtKeywordcongtrinh_admin";
            this.txtKeywordcongtrinh_admin.Size = new System.Drawing.Size(98, 20);
            this.txtKeywordcongtrinh_admin.TabIndex = 13;
            this.txtKeywordcongtrinh_admin.TextChanged += new System.EventHandler(this.txtKeywordcongtrinh_admin_TextChanged);
            // 
            // CongTrinh_NhaThau_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1443, 839);
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
            this.Name = "CongTrinh_NhaThau_Admin";
            this.Text = "CongTrinh_NhaThau";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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