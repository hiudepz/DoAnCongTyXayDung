namespace GUI
{
    partial class Dashboard_User
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hethongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baocaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhmucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.congtrinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhathauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vattuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhancongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiendoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hethongToolStripMenuItem,
            this.baocaoToolStripMenuItem,
            this.danhmucToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1436, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hethongToolStripMenuItem
            // 
            this.hethongToolStripMenuItem.Name = "hethongToolStripMenuItem";
            this.hethongToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hethongToolStripMenuItem.Text = "Hệ thống";
            // 
            // baocaoToolStripMenuItem
            // 
            this.baocaoToolStripMenuItem.Name = "baocaoToolStripMenuItem";
            this.baocaoToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.baocaoToolStripMenuItem.Text = "Báo cáo";
            // 
            // danhmucToolStripMenuItem
            // 
            this.danhmucToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.congtrinhToolStripMenuItem,
            this.nhathauToolStripMenuItem,
            this.vattuToolStripMenuItem,
            this.nhancongToolStripMenuItem,
            this.tiendoToolStripMenuItem});
            this.danhmucToolStripMenuItem.Name = "danhmucToolStripMenuItem";
            this.danhmucToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.danhmucToolStripMenuItem.Text = "Danh mục";
            // 
            // congtrinhToolStripMenuItem
            // 
            this.congtrinhToolStripMenuItem.Name = "congtrinhToolStripMenuItem";
            this.congtrinhToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.congtrinhToolStripMenuItem.Text = "Công trình";
            // 
            // nhathauToolStripMenuItem
            // 
            this.nhathauToolStripMenuItem.Name = "nhathauToolStripMenuItem";
            this.nhathauToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.nhathauToolStripMenuItem.Text = "Nhà thầu";
            // 
            // vattuToolStripMenuItem
            // 
            this.vattuToolStripMenuItem.Name = "vattuToolStripMenuItem";
            this.vattuToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.vattuToolStripMenuItem.Text = "Vật tư";
            this.vattuToolStripMenuItem.Click += new System.EventHandler(this.vattuToolStripMenuItem_Click);
            // 
            // nhancongToolStripMenuItem
            // 
            this.nhancongToolStripMenuItem.Name = "nhancongToolStripMenuItem";
            this.nhancongToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.nhancongToolStripMenuItem.Text = "Nhân công";
            // 
            // tiendoToolStripMenuItem
            // 
            this.tiendoToolStripMenuItem.Name = "tiendoToolStripMenuItem";
            this.tiendoToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.tiendoToolStripMenuItem.Text = "Tiến độ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources._493ef82f_a11e_40fe_a304_c408be4cc684;
            this.pictureBox1.Location = new System.Drawing.Point(110, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(963, 617);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Dashboard_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 650);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard_User";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hethongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baocaoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem danhmucToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem congtrinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhathauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vattuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhancongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiendoToolStripMenuItem;
    }
}

