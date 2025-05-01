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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_NT_Admin)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbIdCT
            // 
            this.cbbIdCT.FormattingEnabled = true;
            this.cbbIdCT.Location = new System.Drawing.Point(124, 73);
            this.cbbIdCT.Name = "cbbIdCT";
            this.cbbIdCT.Size = new System.Drawing.Size(121, 21);
            this.cbbIdCT.TabIndex = 0;
            // 
            // cbbIdNT
            // 
            this.cbbIdNT.FormattingEnabled = true;
            this.cbbIdNT.Location = new System.Drawing.Point(124, 130);
            this.cbbIdNT.Name = "cbbIdNT";
            this.cbbIdNT.Size = new System.Drawing.Size(121, 21);
            this.cbbIdNT.TabIndex = 1;
            // 
            // txtVaitro
            // 
            this.txtVaitro.Location = new System.Drawing.Point(290, 73);
            this.txtVaitro.Name = "txtVaitro";
            this.txtVaitro.Size = new System.Drawing.Size(100, 20);
            this.txtVaitro.TabIndex = 2;
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
            // dgvCT_NT_Admin
            // 
            this.dgvCT_NT_Admin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCT_NT_Admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT_NT_Admin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCT_NT_Admin.Location = new System.Drawing.Point(0, 300);
            this.dgvCT_NT_Admin.Name = "dgvCT_NT_Admin";
            this.dgvCT_NT_Admin.Size = new System.Drawing.Size(800, 150);
            this.dgvCT_NT_Admin.TabIndex = 4;
            this.dgvCT_NT_Admin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCT_NT_Admin_CellContentClick);
            // 
            // CongTrinh_NhaThau_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCT_NT_Admin);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtVaitro);
            this.Controls.Add(this.cbbIdNT);
            this.Controls.Add(this.cbbIdCT);
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
    }
}