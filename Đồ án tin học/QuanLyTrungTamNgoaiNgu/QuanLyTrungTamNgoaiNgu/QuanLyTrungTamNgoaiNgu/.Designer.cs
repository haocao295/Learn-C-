﻿
namespace QuanLyTrungTamNgoaiNgu
{
    partial class TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabMenuHocVien = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMenuLopHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMenuKhoaHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMenuPhieu = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMenuLopKhoa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabMenuHocVien,
            this.tabMenuLopHoc,
            this.tabMenuKhoaHoc,
            this.tabMenuPhieu,
            this.tabMenuLopKhoa});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(945, 43);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabMenuHocVien
            // 
            this.tabMenuHocVien.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.tabMenuHocVien.Image = ((System.Drawing.Image)(resources.GetObject("tabMenuHocVien.Image")));
            this.tabMenuHocVien.Name = "tabMenuHocVien";
            this.tabMenuHocVien.Size = new System.Drawing.Size(146, 39);
            this.tabMenuHocVien.Text = "Học viên";
            this.tabMenuHocVien.Click += new System.EventHandler(this.tabMenuHocVien_Click);
            // 
            // tabMenuLopHoc
            // 
            this.tabMenuLopHoc.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.tabMenuLopHoc.Image = ((System.Drawing.Image)(resources.GetObject("tabMenuLopHoc.Image")));
            this.tabMenuLopHoc.Name = "tabMenuLopHoc";
            this.tabMenuLopHoc.Size = new System.Drawing.Size(139, 39);
            this.tabMenuLopHoc.Text = "Lớp học";
            this.tabMenuLopHoc.Click += new System.EventHandler(this.tabMenuLopHoc_Click);
            // 
            // tabMenuKhoaHoc
            // 
            this.tabMenuKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.tabMenuKhoaHoc.Image = global::QuanLyTrungTamNgoaiNgu.Properties.Resources.download;
            this.tabMenuKhoaHoc.Name = "tabMenuKhoaHoc";
            this.tabMenuKhoaHoc.Size = new System.Drawing.Size(154, 39);
            this.tabMenuKhoaHoc.Text = "Khóa học";
            this.tabMenuKhoaHoc.Click += new System.EventHandler(this.tabMenuKhoaHoc_Click);
            // 
            // tabMenuPhieu
            // 
            this.tabMenuPhieu.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.tabMenuPhieu.Image = global::QuanLyTrungTamNgoaiNgu.Properties.Resources.download__1_;
            this.tabMenuPhieu.Name = "tabMenuPhieu";
            this.tabMenuPhieu.Size = new System.Drawing.Size(205, 39);
            this.tabMenuPhieu.Text = "Phiếu đăng ký";
            this.tabMenuPhieu.Click += new System.EventHandler(this.tabMenuPhieu_Click);
            // 
            // tabMenuLopKhoa
            // 
            this.tabMenuLopKhoa.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.tabMenuLopKhoa.Image = global::QuanLyTrungTamNgoaiNgu.Properties.Resources.images1;
            this.tabMenuLopKhoa.Name = "tabMenuLopKhoa";
            this.tabMenuLopKhoa.Size = new System.Drawing.Size(172, 39);
            this.tabMenuLopKhoa.Text = "Lớp - Khóa";
            this.tabMenuLopKhoa.Click += new System.EventHandler(this.tabMenuLopKhoa_Click);
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::QuanLyTrungTamNgoaiNgu.Properties.Resources.unnamed1;
            this.ClientSize = new System.Drawing.Size(945, 364);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý";
            this.Load += new System.EventHandler(this.TrangChu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tabMenuLopHoc;
        private System.Windows.Forms.ToolStripMenuItem tabMenuKhoaHoc;
        private System.Windows.Forms.ToolStripMenuItem tabMenuPhieu;
        private System.Windows.Forms.ToolStripMenuItem tabMenuLopKhoa;
        private System.Windows.Forms.ToolStripMenuItem tabMenuHocVien;
    }
}

