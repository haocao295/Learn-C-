
namespace QuanLyTrungTamNgoaiNgu.GiaoDien
{
    partial class KhoaGD
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
			this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
			this.lsvKhoa = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnLuu = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.txtTenKhoa = new System.Windows.Forms.TextBox();
			this.txtMaKhoa = new System.Windows.Forms.TextBox();
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
			this.pnChinh.Controls.Add(this.dtpNgayKetThuc);
			this.pnChinh.Controls.Add(this.label4);
			this.pnChinh.Controls.Add(this.dtpNgayBatDau);
			this.pnChinh.Controls.Add(this.lsvKhoa);
			this.pnChinh.Controls.Add(this.btnLuu);
			this.pnChinh.Controls.Add(this.btnXoa);
			this.pnChinh.Controls.Add(this.btnSua);
			this.pnChinh.Controls.Add(this.btnThem);
			this.pnChinh.Controls.Add(this.txtTenKhoa);
			this.pnChinh.Controls.Add(this.txtMaKhoa);
			this.pnChinh.Controls.Add(this.label3);
			this.pnChinh.Controls.Add(this.label2);
			this.pnChinh.Controls.Add(this.label1);
			this.pnChinh.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnChinh.Location = new System.Drawing.Point(0, 0);
			this.pnChinh.Name = "pnChinh";
			this.pnChinh.Size = new System.Drawing.Size(638, 554);
			this.pnChinh.TabIndex = 1;
			// 
			// btnthoat
			// 
			this.btnthoat.BackColor = System.Drawing.Color.SeaShell;
			this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnthoat.ForeColor = System.Drawing.Color.IndianRed;
			this.btnthoat.Location = new System.Drawing.Point(449, 236);
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
			this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
			this.label5.Location = new System.Drawing.Point(135, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(370, 48);
			this.label5.TabIndex = 14;
			this.label5.Tag = "";
			this.label5.Text = "Quản Lý Khóa Học";
			// 
			// dtpNgayKetThuc
			// 
			this.dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy";
			this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNgayKetThuc.Location = new System.Drawing.Point(143, 238);
			this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
			this.dtpNgayKetThuc.Size = new System.Drawing.Size(200, 22);
			this.dtpNgayKetThuc.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(39, 238);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(95, 17);
			this.label4.TabIndex = 12;
			this.label4.Text = "Ngày kết thúc";
			// 
			// dtpNgayBatDau
			// 
			this.dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
			this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNgayBatDau.Location = new System.Drawing.Point(143, 194);
			this.dtpNgayBatDau.Name = "dtpNgayBatDau";
			this.dtpNgayBatDau.Size = new System.Drawing.Size(200, 22);
			this.dtpNgayBatDau.TabIndex = 11;
			// 
			// lsvKhoa
			// 
			this.lsvKhoa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.lsvKhoa.FullRowSelect = true;
			this.lsvKhoa.HideSelection = false;
			this.lsvKhoa.Location = new System.Drawing.Point(46, 278);
			this.lsvKhoa.Name = "lsvKhoa";
			this.lsvKhoa.Size = new System.Drawing.Size(548, 264);
			this.lsvKhoa.TabIndex = 10;
			this.lsvKhoa.UseCompatibleStateImageBehavior = false;
			this.lsvKhoa.View = System.Windows.Forms.View.Details;
			this.lsvKhoa.SelectedIndexChanged += new System.EventHandler(this.lsvKhoa_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Mã khóa";
			this.columnHeader1.Width = 79;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Tên khóa";
			this.columnHeader2.Width = 89;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Ngày bắt đầu";
			this.columnHeader3.Width = 150;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Ngày kết thúc";
			this.columnHeader4.Width = 150;
			// 
			// btnLuu
			// 
			this.btnLuu.BackColor = System.Drawing.Color.Aqua;
			this.btnLuu.Location = new System.Drawing.Point(491, 178);
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
			this.btnXoa.Location = new System.Drawing.Point(382, 178);
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
			this.btnSua.Location = new System.Drawing.Point(491, 107);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(103, 38);
			this.btnSua.TabIndex = 7;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = false;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnThem.Location = new System.Drawing.Point(382, 107);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(103, 38);
			this.btnThem.TabIndex = 6;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// txtTenKhoa
			// 
			this.txtTenKhoa.Location = new System.Drawing.Point(143, 152);
			this.txtTenKhoa.Name = "txtTenKhoa";
			this.txtTenKhoa.Size = new System.Drawing.Size(201, 22);
			this.txtTenKhoa.TabIndex = 4;
			// 
			// txtMaKhoa
			// 
			this.txtMaKhoa.Location = new System.Drawing.Point(143, 107);
			this.txtMaKhoa.Name = "txtMaKhoa";
			this.txtMaKhoa.Size = new System.Drawing.Size(201, 22);
			this.txtMaKhoa.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(39, 194);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(93, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Ngày bắt đầu";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(39, 152);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên khóa";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(39, 107);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã khóa";
			// 
			// KhoaGD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(638, 554);
			this.Controls.Add(this.pnChinh);
			this.Name = "KhoaGD";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản Lý Khóa Học";
			this.Load += new System.EventHandler(this.KhoaGD_Load);
			this.pnChinh.ResumeLayout(false);
			this.pnChinh.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnChinh;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.ListView lsvKhoa;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnthoat;
    }
}