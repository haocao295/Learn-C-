
namespace QuanLyTrungTamNgoaiNgu.GiaoDien
{
    partial class LopKhoaGD
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
			this.pnChinh = new System.Windows.Forms.Panel();
			this.btnthoat = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.txtSiSo = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cbbKhoa = new System.Windows.Forms.ComboBox();
			this.cbbLop = new System.Windows.Forms.ComboBox();
			this.lsvLopKhoa = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnLuu = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pnChinh.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnChinh
			// 
			this.pnChinh.Controls.Add(this.btnthoat);
			this.pnChinh.Controls.Add(this.label5);
			this.pnChinh.Controls.Add(this.txtSiSo);
			this.pnChinh.Controls.Add(this.label4);
			this.pnChinh.Controls.Add(this.cbbKhoa);
			this.pnChinh.Controls.Add(this.cbbLop);
			this.pnChinh.Controls.Add(this.lsvLopKhoa);
			this.pnChinh.Controls.Add(this.btnLuu);
			this.pnChinh.Controls.Add(this.btnXoa);
			this.pnChinh.Controls.Add(this.btnSua);
			this.pnChinh.Controls.Add(this.btnThem);
			this.pnChinh.Controls.Add(this.label3);
			this.pnChinh.Controls.Add(this.label2);
			this.pnChinh.Controls.Add(this.label1);
			this.pnChinh.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnChinh.Location = new System.Drawing.Point(0, 0);
			this.pnChinh.Name = "pnChinh";
			this.pnChinh.Size = new System.Drawing.Size(641, 633);
			this.pnChinh.TabIndex = 1;
			// 
			// btnthoat
			// 
			this.btnthoat.BackColor = System.Drawing.Color.SeaShell;
			this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnthoat.ForeColor = System.Drawing.Color.IndianRed;
			this.btnthoat.Location = new System.Drawing.Point(475, 277);
			this.btnthoat.Name = "btnthoat";
			this.btnthoat.Size = new System.Drawing.Size(75, 36);
			this.btnthoat.TabIndex = 100;
			this.btnthoat.Text = "Thoát";
			this.btnthoat.UseVisualStyleBackColor = false;
			this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(140, 43);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(368, 48);
			this.label5.TabIndex = 15;
			this.label5.Text = "Quản Lý Lớp-Khóa";
			// 
			// txtSiSo
			// 
			this.txtSiSo.Location = new System.Drawing.Point(148, 241);
			this.txtSiSo.Name = "txtSiSo";
			this.txtSiSo.Size = new System.Drawing.Size(211, 22);
			this.txtSiSo.TabIndex = 14;
			this.txtSiSo.Text = "0";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(47, 241);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 17);
			this.label4.TabIndex = 13;
			this.label4.Text = "Sĩ số";
			// 
			// cbbKhoa
			// 
			this.cbbKhoa.FormattingEnabled = true;
			this.cbbKhoa.Location = new System.Drawing.Point(148, 192);
			this.cbbKhoa.Name = "cbbKhoa";
			this.cbbKhoa.Size = new System.Drawing.Size(211, 24);
			this.cbbKhoa.TabIndex = 12;
			// 
			// cbbLop
			// 
			this.cbbLop.FormattingEnabled = true;
			this.cbbLop.Location = new System.Drawing.Point(148, 147);
			this.cbbLop.Name = "cbbLop";
			this.cbbLop.Size = new System.Drawing.Size(211, 24);
			this.cbbLop.TabIndex = 11;
			// 
			// lsvLopKhoa
			// 
			this.lsvLopKhoa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.lsvLopKhoa.FullRowSelect = true;
			this.lsvLopKhoa.HideSelection = false;
			this.lsvLopKhoa.Location = new System.Drawing.Point(36, 319);
			this.lsvLopKhoa.Name = "lsvLopKhoa";
			this.lsvLopKhoa.Size = new System.Drawing.Size(548, 302);
			this.lsvLopKhoa.TabIndex = 10;
			this.lsvLopKhoa.UseCompatibleStateImageBehavior = false;
			this.lsvLopKhoa.View = System.Windows.Forms.View.Details;
			this.lsvLopKhoa.SelectedIndexChanged += new System.EventHandler(this.lsvLopKhoa_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Mã lớp";
			this.columnHeader1.Width = 92;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Tên lớp";
			this.columnHeader2.Width = 91;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Tên khóa";
			this.columnHeader3.Width = 94;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Sĩ số";
			this.columnHeader4.Width = 120;
			// 
			// btnLuu
			// 
			this.btnLuu.BackColor = System.Drawing.Color.Aqua;
			this.btnLuu.Location = new System.Drawing.Point(517, 211);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(103, 38);
			this.btnLuu.TabIndex = 9;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = false;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.Color.Red;
			this.btnXoa.Location = new System.Drawing.Point(397, 211);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(103, 38);
			this.btnXoa.TabIndex = 8;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = false;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.BackColor = System.Drawing.Color.Yellow;
			this.btnSua.Location = new System.Drawing.Point(517, 147);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(103, 38);
			this.btnSua.TabIndex = 7;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = false;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.Lime;
			this.btnThem.Location = new System.Drawing.Point(397, 147);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(103, 38);
			this.btnThem.TabIndex = 6;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(43, 124);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(0, 17);
			this.label3.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(47, 192);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên Khóa";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(47, 147);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên lớp";
			// 
			// LopKhoaGD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(641, 633);
			this.Controls.Add(this.pnChinh);
			this.Name = "LopKhoaGD";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản Lý Lớp Khóa Học";
			this.Load += new System.EventHandler(this.LopKhoaGD_Load);
			this.pnChinh.ResumeLayout(false);
			this.pnChinh.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnChinh;
        private System.Windows.Forms.ListView lsvLopKhoa;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.TextBox txtSiSo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnthoat;
    }
}