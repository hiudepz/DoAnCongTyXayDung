﻿namespace GUI.User
{
    partial class DashBoard_User
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
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baocaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportNhaThauCongTrinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportDanhSachVatTuVaTongChiPhiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bảngBáoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhmucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.congtrinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhathauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vattuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhancongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiendoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.baocaoToolStripMenuItem,
            this.danhmucToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1443, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // baocaoToolStripMenuItem
            // 
            this.baocaoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportNhaThauCongTrinhToolStripMenuItem,
            this.reportDanhSachVatTuVaTongChiPhiToolStripMenuItem,
            this.bảngBáoCáoToolStripMenuItem});
            this.baocaoToolStripMenuItem.Name = "baocaoToolStripMenuItem";
            this.baocaoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.baocaoToolStripMenuItem.Text = "Báo cáo";
            // 
            // reportNhaThauCongTrinhToolStripMenuItem
            // 
            this.reportNhaThauCongTrinhToolStripMenuItem.Name = "reportNhaThauCongTrinhToolStripMenuItem";
            this.reportNhaThauCongTrinhToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.reportNhaThauCongTrinhToolStripMenuItem.Text = "Báo cáo quản lý công trình nhà thầu";
            this.reportNhaThauCongTrinhToolStripMenuItem.Click += new System.EventHandler(this.reportNhaThauCongTrinhToolStripMenuItem_Click);
            // 
            // reportDanhSachVatTuVaTongChiPhiToolStripMenuItem
            // 
            this.reportDanhSachVatTuVaTongChiPhiToolStripMenuItem.Name = "reportDanhSachVatTuVaTongChiPhiToolStripMenuItem";
            this.reportDanhSachVatTuVaTongChiPhiToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.reportDanhSachVatTuVaTongChiPhiToolStripMenuItem.Text = "Báo cáo danh sách vật tư và tổng chi phí";
            this.reportDanhSachVatTuVaTongChiPhiToolStripMenuItem.Click += new System.EventHandler(this.reportDanhSachVatTuVaTongChiPhiToolStripMenuItem_Click);
            // 
            // bảngBáoCáoToolStripMenuItem
            // 
            this.bảngBáoCáoToolStripMenuItem.Name = "bảngBáoCáoToolStripMenuItem";
            this.bảngBáoCáoToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.bảngBáoCáoToolStripMenuItem.Text = "Bảng Báo Cáo";
            this.bảngBáoCáoToolStripMenuItem.Click += new System.EventHandler(this.bảngBáoCáoToolStripMenuItem_Click);
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
            this.danhmucToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.danhmucToolStripMenuItem.Text = "Danh mục";
            // 
            // congtrinhToolStripMenuItem
            // 
            this.congtrinhToolStripMenuItem.Name = "congtrinhToolStripMenuItem";
            this.congtrinhToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.congtrinhToolStripMenuItem.Text = "Công trình";
            this.congtrinhToolStripMenuItem.Click += new System.EventHandler(this.congtrinhToolStripMenuItem_Click);
            // 
            // nhathauToolStripMenuItem
            // 
            this.nhathauToolStripMenuItem.Name = "nhathauToolStripMenuItem";
            this.nhathauToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.nhathauToolStripMenuItem.Text = "Nhà thầu";
            this.nhathauToolStripMenuItem.Click += new System.EventHandler(this.nhathauToolStripMenuItem_Click);
            // 
            // vattuToolStripMenuItem
            // 
            this.vattuToolStripMenuItem.Name = "vattuToolStripMenuItem";
            this.vattuToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.vattuToolStripMenuItem.Text = "Vật tư";
            this.vattuToolStripMenuItem.Click += new System.EventHandler(this.vattuToolStripMenuItem_Click);
            // 
            // nhancongToolStripMenuItem
            // 
            this.nhancongToolStripMenuItem.Name = "nhancongToolStripMenuItem";
            this.nhancongToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.nhancongToolStripMenuItem.Text = "Nhân công";
            this.nhancongToolStripMenuItem.Click += new System.EventHandler(this.nhancongToolStripMenuItem_Click);
            // 
            // tiendoToolStripMenuItem
            // 
            this.tiendoToolStripMenuItem.Name = "tiendoToolStripMenuItem";
            this.tiendoToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.tiendoToolStripMenuItem.Text = "Tiến độ";
            this.tiendoToolStripMenuItem.Click += new System.EventHandler(this.tiendoToolStripMenuItem_Click_1);
            // 
            // DashBoard_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1443, 839);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DashBoard_User";
            this.Text = "DashBoard_User";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem baocaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportNhaThauCongTrinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportDanhSachVatTuVaTongChiPhiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bảngBáoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhmucToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem congtrinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhathauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vattuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhancongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiendoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}