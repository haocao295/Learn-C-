namespace QuanLyTrungTamNgoaiNgu.GiaoDien
{
    partial class PhieuDangKyGD
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
			this.components = new System.ComponentModel.Container();
			this.btnluu = new System.Windows.Forms.Button();
			this.lvdanhsach = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.txtnhapma = new System.Windows.Forms.TextBox();
			this.lblnhapma = new System.Windows.Forms.Label();
			this.dtpngaylap = new System.Windows.Forms.DateTimePicker();
			this.txtsotien = new System.Windows.Forms.TextBox();
			this.txtmaphieu = new System.Windows.Forms.TextBox();
			this.lblsotien = new System.Windows.Forms.Label();
			this.lblngaylap = new System.Windows.Forms.Label();
			this.lblmapdk = new System.Windows.Forms.Label();
			this.btnthoat = new System.Windows.Forms.Button();
			this.btntim = new System.Windows.Forms.Button();
			this.btnthem = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.btnsua = new System.Windows.Forms.Button();
			this.btnxoa = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.ccbHoTen = new System.Windows.Forms.ComboBox();
			this.hocVienDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.ccbLopKhoa = new System.Windows.Forms.ComboBox();
			this.lopKhoaDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.hocVienDTBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lopKhoaDTBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// btnluu
			// 
			this.btnluu.BackColor = System.Drawing.Color.Aqua;
			this.btnluu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnluu.ForeColor = System.Drawing.Color.Blue;
			this.btnluu.Location = new System.Drawing.Point(398, 484);
			this.btnluu.Name = "btnluu";
			this.btnluu.Size = new System.Drawing.Size(75, 46);
			this.btnluu.TabIndex = 110;
			this.btnluu.Text = "Lưu";
			this.btnluu.UseVisualStyleBackColor = false;
			this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
			// 
			// lvdanhsach
			// 
			this.lvdanhsach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
			this.lvdanhsach.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lvdanhsach.FullRowSelect = true;
			this.lvdanhsach.HideSelection = false;
			this.lvdanhsach.Location = new System.Drawing.Point(379, 145);
			this.lvdanhsach.Name = "lvdanhsach";
			this.lvdanhsach.Size = new System.Drawing.Size(627, 326);
			this.lvdanhsach.TabIndex = 109;
			this.lvdanhsach.UseCompatibleStateImageBehavior = false;
			this.lvdanhsach.View = System.Windows.Forms.View.Details;
			this.lvdanhsach.SelectedIndexChanged += new System.EventHandler(this.lvdanhsach_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Mã phiếu";
			this.columnHeader1.Width = 83;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Ngày lập phiếu";
			this.columnHeader2.Width = 121;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Số tiền";
			this.columnHeader3.Width = 69;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Họ tên";
			this.columnHeader4.Width = 72;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "maLopKhoa";
			this.columnHeader5.Width = 116;
			// 
			// txtnhapma
			// 
			this.txtnhapma.Location = new System.Drawing.Point(726, 113);
			this.txtnhapma.Name = "txtnhapma";
			this.txtnhapma.Size = new System.Drawing.Size(100, 22);
			this.txtnhapma.TabIndex = 108;
			// 
			// lblnhapma
			// 
			this.lblnhapma.AutoSize = true;
			this.lblnhapma.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblnhapma.Location = new System.Drawing.Point(637, 114);
			this.lblnhapma.Name = "lblnhapma";
			this.lblnhapma.Size = new System.Drawing.Size(73, 19);
			this.lblnhapma.TabIndex = 107;
			this.lblnhapma.Text = "Nhập mã";
			// 
			// dtpngaylap
			// 
			this.dtpngaylap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpngaylap.Location = new System.Drawing.Point(153, 167);
			this.dtpngaylap.Name = "dtpngaylap";
			this.dtpngaylap.Size = new System.Drawing.Size(200, 22);
			this.dtpngaylap.TabIndex = 106;
			// 
			// txtsotien
			// 
			this.txtsotien.Location = new System.Drawing.Point(153, 205);
			this.txtsotien.Name = "txtsotien";
			this.txtsotien.Size = new System.Drawing.Size(199, 22);
			this.txtsotien.TabIndex = 105;
			// 
			// txtmaphieu
			// 
			this.txtmaphieu.Location = new System.Drawing.Point(153, 120);
			this.txtmaphieu.Name = "txtmaphieu";
			this.txtmaphieu.Size = new System.Drawing.Size(200, 22);
			this.txtmaphieu.TabIndex = 104;
			// 
			// lblsotien
			// 
			this.lblsotien.AutoSize = true;
			this.lblsotien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblsotien.Location = new System.Drawing.Point(82, 208);
			this.lblsotien.Name = "lblsotien";
			this.lblsotien.Size = new System.Drawing.Size(60, 19);
			this.lblsotien.TabIndex = 102;
			this.lblsotien.Text = "Số tiền";
			// 
			// lblngaylap
			// 
			this.lblngaylap.AutoSize = true;
			this.lblngaylap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblngaylap.Location = new System.Drawing.Point(69, 167);
			this.lblngaylap.Name = "lblngaylap";
			this.lblngaylap.Size = new System.Drawing.Size(73, 19);
			this.lblngaylap.TabIndex = 101;
			this.lblngaylap.Text = "Ngày lập";
			// 
			// lblmapdk
			// 
			this.lblmapdk.AutoSize = true;
			this.lblmapdk.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblmapdk.Location = new System.Drawing.Point(69, 120);
			this.lblmapdk.Name = "lblmapdk";
			this.lblmapdk.Size = new System.Drawing.Size(78, 19);
			this.lblmapdk.TabIndex = 100;
			this.lblmapdk.Text = "Mã phiếu";
			// 
			// btnthoat
			// 
			this.btnthoat.BackColor = System.Drawing.Color.SeaShell;
			this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnthoat.ForeColor = System.Drawing.Color.IndianRed;
			this.btnthoat.Location = new System.Drawing.Point(817, 494);
			this.btnthoat.Name = "btnthoat";
			this.btnthoat.Size = new System.Drawing.Size(75, 36);
			this.btnthoat.TabIndex = 99;
			this.btnthoat.Text = "Thoát";
			this.btnthoat.UseVisualStyleBackColor = false;
			this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
			// 
			// btntim
			// 
			this.btntim.BackColor = System.Drawing.Color.SeaShell;
			this.btntim.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btntim.ForeColor = System.Drawing.Color.SteelBlue;
			this.btntim.Location = new System.Drawing.Point(832, 107);
			this.btntim.Name = "btntim";
			this.btntim.Size = new System.Drawing.Size(60, 32);
			this.btntim.TabIndex = 98;
			this.btntim.Text = "Tìm";
			this.btntim.UseVisualStyleBackColor = false;
			this.btntim.Click += new System.EventHandler(this.btntim_Click);
			// 
			// btnthem
			// 
			this.btnthem.BackColor = System.Drawing.Color.Lime;
			this.btnthem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnthem.ForeColor = System.Drawing.Color.SteelBlue;
			this.btnthem.Location = new System.Drawing.Point(53, 351);
			this.btnthem.Name = "btnthem";
			this.btnthem.Size = new System.Drawing.Size(75, 35);
			this.btnthem.TabIndex = 95;
			this.btnthem.Text = "Thêm";
			this.btnthem.UseVisualStyleBackColor = false;
			this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(266, 33);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(465, 48);
			this.label5.TabIndex = 111;
			this.label5.Text = "Quản Lý Phiếu Đăng Ký";
			// 
			// btnsua
			// 
			this.btnsua.BackColor = System.Drawing.Color.Yellow;
			this.btnsua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsua.ForeColor = System.Drawing.Color.SteelBlue;
			this.btnsua.Location = new System.Drawing.Point(153, 351);
			this.btnsua.Name = "btnsua";
			this.btnsua.Size = new System.Drawing.Size(75, 35);
			this.btnsua.TabIndex = 96;
			this.btnsua.Text = "Sửa";
			this.btnsua.UseVisualStyleBackColor = false;
			this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
			// 
			// btnxoa
			// 
			this.btnxoa.BackColor = System.Drawing.Color.Red;
			this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnxoa.ForeColor = System.Drawing.Color.SteelBlue;
			this.btnxoa.Location = new System.Drawing.Point(264, 351);
			this.btnxoa.Name = "btnxoa";
			this.btnxoa.Size = new System.Drawing.Size(75, 35);
			this.btnxoa.TabIndex = 97;
			this.btnxoa.Text = "Xóa";
			this.btnxoa.UseVisualStyleBackColor = false;
			this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(69, 258);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 17);
			this.label1.TabIndex = 112;
			this.label1.Text = "Học Viên";
			// 
			// ccbHoTen
			// 
			this.ccbHoTen.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.hocVienDTBindingSource, "HoTen", true));
			this.ccbHoTen.DataSource = this.hocVienDTBindingSource;
			this.ccbHoTen.DisplayMember = "HoTen";
			this.ccbHoTen.FormattingEnabled = true;
			this.ccbHoTen.Location = new System.Drawing.Point(153, 251);
			this.ccbHoTen.Name = "ccbHoTen";
			this.ccbHoTen.Size = new System.Drawing.Size(200, 24);
			this.ccbHoTen.TabIndex = 113;
			this.ccbHoTen.ValueMember = "HoTen";
			this.ccbHoTen.SelectedIndexChanged += new System.EventHandler(this.ccbHoTen_SelectedIndexChanged);
			// 
			// hocVienDTBindingSource
			// 
			this.hocVienDTBindingSource.DataSource = typeof(QuanLyTrungTamNgoaiNgu.DoiTuong.HocVienDT);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(54, 300);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 17);
			this.label2.TabIndex = 114;
			this.label2.Text = "Lớp - Khóa";
			// 
			// ccbLopKhoa
			// 
			this.ccbLopKhoa.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lopKhoaDTBindingSource, "MaLopKhoa", true));
			this.ccbLopKhoa.DataSource = this.lopKhoaDTBindingSource;
			this.ccbLopKhoa.DisplayMember = "MaLopKhoa";
			this.ccbLopKhoa.FormattingEnabled = true;
			this.ccbLopKhoa.Location = new System.Drawing.Point(153, 297);
			this.ccbLopKhoa.Name = "ccbLopKhoa";
			this.ccbLopKhoa.Size = new System.Drawing.Size(200, 24);
			this.ccbLopKhoa.TabIndex = 115;
			this.ccbLopKhoa.ValueMember = "MaLopKhoa";
			// 
			// lopKhoaDTBindingSource
			// 
			this.lopKhoaDTBindingSource.DataSource = typeof(QuanLyTrungTamNgoaiNgu.DoiTuong.LopKhoaDT);
			// 
			// PhieuDangKyGD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1018, 582);
			this.Controls.Add(this.ccbLopKhoa);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.ccbHoTen);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnluu);
			this.Controls.Add(this.lvdanhsach);
			this.Controls.Add(this.txtnhapma);
			this.Controls.Add(this.lblnhapma);
			this.Controls.Add(this.dtpngaylap);
			this.Controls.Add(this.txtsotien);
			this.Controls.Add(this.txtmaphieu);
			this.Controls.Add(this.lblsotien);
			this.Controls.Add(this.lblngaylap);
			this.Controls.Add(this.lblmapdk);
			this.Controls.Add(this.btnthoat);
			this.Controls.Add(this.btntim);
			this.Controls.Add(this.btnxoa);
			this.Controls.Add(this.btnsua);
			this.Controls.Add(this.btnthem);
			this.Name = "PhieuDangKyGD";
			this.Text = "PhieuDangKyGD";
			this.Load += new System.EventHandler(this.PhieuDangKyGD_Load);
			((System.ComponentModel.ISupportInitialize)(this.hocVienDTBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lopKhoaDTBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.ListView lvdanhsach;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txtnhapma;
        private System.Windows.Forms.Label lblnhapma;
        private System.Windows.Forms.DateTimePicker dtpngaylap;
        private System.Windows.Forms.TextBox txtsotien;
        private System.Windows.Forms.TextBox txtmaphieu;
        private System.Windows.Forms.Label lblsotien;
        private System.Windows.Forms.Label lblngaylap;
        private System.Windows.Forms.Label lblmapdk;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox ccbHoTen;
		private System.Windows.Forms.BindingSource hocVienDTBindingSource;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox ccbLopKhoa;
		private System.Windows.Forms.BindingSource lopKhoaDTBindingSource;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
	}
}