namespace QuanLyThongTinHV
{
    partial class Form1
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblMaHocVien = new System.Windows.Forms.Label();
            this.lblTenHocVien = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSdt = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaHocVien = new System.Windows.Forms.TextBox();
            this.txtTenHocVien = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.gbGioiTinh = new System.Windows.Forms.GroupBox();
            this.rbnNu = new System.Windows.Forms.RadioButton();
            this.rbnNam = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lvThongTinHocVien = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.txttimTheoTen = new System.Windows.Forms.TextBox();
            this.txttimTheoMa = new System.Windows.Forms.TextBox();
            this.rbntimTheoTen = new System.Windows.Forms.RadioButton();
            this.rbntimTheoMa = new System.Windows.Forms.RadioButton();
            this.btnghifile = new System.Windows.Forms.Button();
            this.btndocFile = new System.Windows.Forms.Button();
            this.gbGioiTinh.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.Red;
            this.btnThem.Location = new System.Drawing.Point(257, 321);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(113, 43);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(439, 321);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(113, 43);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnChinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChinhSua.ForeColor = System.Drawing.Color.Red;
            this.btnChinhSua.Location = new System.Drawing.Point(623, 321);
            this.btnChinhSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(113, 43);
            this.btnChinhSua.TabIndex = 3;
            this.btnChinhSua.Text = "Chỉnh Sửa";
            this.btnChinhSua.UseVisualStyleBackColor = false;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.Color.Yellow;
            this.btnThoat.Location = new System.Drawing.Point(898, 613);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(113, 43);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblMaHocVien
            // 
            this.lblMaHocVien.AutoSize = true;
            this.lblMaHocVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaHocVien.ForeColor = System.Drawing.Color.Maroon;
            this.lblMaHocVien.Location = new System.Drawing.Point(43, 130);
            this.lblMaHocVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaHocVien.Name = "lblMaHocVien";
            this.lblMaHocVien.Size = new System.Drawing.Size(106, 20);
            this.lblMaHocVien.TabIndex = 6;
            this.lblMaHocVien.Text = "Mã Học Viên";
            // 
            // lblTenHocVien
            // 
            this.lblTenHocVien.AutoSize = true;
            this.lblTenHocVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenHocVien.ForeColor = System.Drawing.Color.Maroon;
            this.lblTenHocVien.Location = new System.Drawing.Point(545, 126);
            this.lblTenHocVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenHocVien.Name = "lblTenHocVien";
            this.lblTenHocVien.Size = new System.Drawing.Size(111, 20);
            this.lblTenHocVien.TabIndex = 7;
            this.lblTenHocVien.Text = "Tên Học Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(43, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(545, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Địa Chỉ";
            // 
            // lblSdt
            // 
            this.lblSdt.AutoSize = true;
            this.lblSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSdt.ForeColor = System.Drawing.Color.Maroon;
            this.lblSdt.Location = new System.Drawing.Point(545, 240);
            this.lblSdt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(114, 20);
            this.lblSdt.TabIndex = 10;
            this.lblSdt.Text = "Số Điện Thoại";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblEmail.ForeColor = System.Drawing.Color.Maroon;
            this.lblEmail.Location = new System.Drawing.Point(43, 249);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 20);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 443);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 12;
            // 
            // txtMaHocVien
            // 
            this.txtMaHocVien.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaHocVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHocVien.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMaHocVien.Location = new System.Drawing.Point(181, 122);
            this.txtMaHocVien.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHocVien.Name = "txtMaHocVien";
            this.txtMaHocVien.Size = new System.Drawing.Size(312, 30);
            this.txtMaHocVien.TabIndex = 13;
            // 
            // txtTenHocVien
            // 
            this.txtTenHocVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHocVien.Location = new System.Drawing.Point(691, 122);
            this.txtTenHocVien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenHocVien.Name = "txtTenHocVien";
            this.txtTenHocVien.Size = new System.Drawing.Size(312, 30);
            this.txtTenHocVien.TabIndex = 14;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(691, 180);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(312, 30);
            this.txtDiaChi.TabIndex = 16;
            // 
            // txtSdt
            // 
            this.txtSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdt.Location = new System.Drawing.Point(691, 239);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(4);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(312, 30);
            this.txtSdt.TabIndex = 17;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(181, 240);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(312, 30);
            this.txtEmail.TabIndex = 18;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpNgaySinh.Location = new System.Drawing.Point(181, 183);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(312, 30);
            this.dtpNgaySinh.TabIndex = 19;
            // 
            // gbGioiTinh
            // 
            this.gbGioiTinh.Controls.Add(this.rbnNu);
            this.gbGioiTinh.Controls.Add(this.rbnNam);
            this.gbGioiTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGioiTinh.Location = new System.Drawing.Point(47, 294);
            this.gbGioiTinh.Margin = new System.Windows.Forms.Padding(4);
            this.gbGioiTinh.Name = "gbGioiTinh";
            this.gbGioiTinh.Padding = new System.Windows.Forms.Padding(4);
            this.gbGioiTinh.Size = new System.Drawing.Size(180, 70);
            this.gbGioiTinh.TabIndex = 20;
            this.gbGioiTinh.TabStop = false;
            this.gbGioiTinh.Text = "Giới Tính";
            // 
            // rbnNu
            // 
            this.rbnNu.AutoSize = true;
            this.rbnNu.Location = new System.Drawing.Point(105, 23);
            this.rbnNu.Margin = new System.Windows.Forms.Padding(4);
            this.rbnNu.Name = "rbnNu";
            this.rbnNu.Size = new System.Drawing.Size(56, 28);
            this.rbnNu.TabIndex = 2;
            this.rbnNu.TabStop = true;
            this.rbnNu.Text = "Nữ";
            this.rbnNu.UseVisualStyleBackColor = true;
            // 
            // rbnNam
            // 
            this.rbnNam.AutoSize = true;
            this.rbnNam.Location = new System.Drawing.Point(8, 23);
            this.rbnNam.Margin = new System.Windows.Forms.Padding(4);
            this.rbnNam.Name = "rbnNam";
            this.rbnNam.Size = new System.Drawing.Size(71, 28);
            this.rbnNam.TabIndex = 1;
            this.rbnNam.TabStop = true;
            this.rbnNam.Text = "Nam";
            this.rbnNam.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(280, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 58);
            this.label1.TabIndex = 22;
            this.label1.Text = "THÔNG TIN HỌC VIÊN";
            // 
            // lvThongTinHocVien
            // 
            this.lvThongTinHocVien.BackColor = System.Drawing.SystemColors.Control;
            this.lvThongTinHocVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvThongTinHocVien.FullRowSelect = true;
            this.lvThongTinHocVien.HideSelection = false;
            this.lvThongTinHocVien.Location = new System.Drawing.Point(47, 411);
            this.lvThongTinHocVien.Margin = new System.Windows.Forms.Padding(4);
            this.lvThongTinHocVien.Name = "lvThongTinHocVien";
            this.lvThongTinHocVien.Size = new System.Drawing.Size(716, 245);
            this.lvThongTinHocVien.TabIndex = 23;
            this.lvThongTinHocVien.UseCompatibleStateImageBehavior = false;
            this.lvThongTinHocVien.View = System.Windows.Forms.View.Details;
            this.lvThongTinHocVien.SelectedIndexChanged += new System.EventHandler(this.lvThongTinHocVien_SelectedIndexChanged);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Mã Học Viên";
            this.columnHeader8.Width = 96;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tên Học Viên";
            this.columnHeader9.Width = 111;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Ngày Sinh";
            this.columnHeader10.Width = 93;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Giới Tính";
            this.columnHeader11.Width = 73;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Địa Chỉ";
            this.columnHeader1.Width = 117;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Email";
            this.columnHeader2.Width = 87;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số Điện Thoại";
            this.columnHeader3.Width = 134;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.txttimTheoTen);
            this.groupBox1.Controls.Add(this.txttimTheoMa);
            this.groupBox1.Controls.Add(this.rbntimTheoTen);
            this.groupBox1.Controls.Add(this.rbntimTheoMa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(793, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 139);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnOK.Location = new System.Drawing.Point(107, 99);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(111, 31);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Tìm";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txttimTheoTen
            // 
            this.txttimTheoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimTheoTen.Location = new System.Drawing.Point(158, 63);
            this.txttimTheoTen.Name = "txttimTheoTen";
            this.txttimTheoTen.Size = new System.Drawing.Size(122, 30);
            this.txttimTheoTen.TabIndex = 3;
            // 
            // txttimTheoMa
            // 
            this.txttimTheoMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimTheoMa.Location = new System.Drawing.Point(158, 27);
            this.txttimTheoMa.Name = "txttimTheoMa";
            this.txttimTheoMa.Size = new System.Drawing.Size(122, 30);
            this.txttimTheoMa.TabIndex = 2;
            // 
            // rbntimTheoTen
            // 
            this.rbntimTheoTen.AutoSize = true;
            this.rbntimTheoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbntimTheoTen.Location = new System.Drawing.Point(6, 63);
            this.rbntimTheoTen.Name = "rbntimTheoTen";
            this.rbntimTheoTen.Size = new System.Drawing.Size(134, 21);
            this.rbntimTheoTen.TabIndex = 1;
            this.rbntimTheoTen.TabStop = true;
            this.rbntimTheoTen.Text = "Tìm theo Tên Hv";
            this.rbntimTheoTen.UseVisualStyleBackColor = true;
            // 
            // rbntimTheoMa
            // 
            this.rbntimTheoMa.AutoSize = true;
            this.rbntimTheoMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbntimTheoMa.Location = new System.Drawing.Point(6, 27);
            this.rbntimTheoMa.Name = "rbntimTheoMa";
            this.rbntimTheoMa.Size = new System.Drawing.Size(128, 21);
            this.rbntimTheoMa.TabIndex = 0;
            this.rbntimTheoMa.TabStop = true;
            this.rbntimTheoMa.Text = "Tìm theo Mã Hv";
            this.rbntimTheoMa.UseVisualStyleBackColor = true;
            // 
            // btnghifile
            // 
            this.btnghifile.Location = new System.Drawing.Point(824, 476);
            this.btnghifile.Name = "btnghifile";
            this.btnghifile.Size = new System.Drawing.Size(262, 52);
            this.btnghifile.TabIndex = 25;
            this.btnghifile.Text = "Ghi file";
            this.btnghifile.UseVisualStyleBackColor = true;
            this.btnghifile.Click += new System.EventHandler(this.btnghifile_Click);
            // 
            // btndocFile
            // 
            this.btndocFile.Location = new System.Drawing.Point(824, 534);
            this.btndocFile.Name = "btndocFile";
            this.btndocFile.Size = new System.Drawing.Size(262, 52);
            this.btndocFile.TabIndex = 26;
            this.btndocFile.Text = "Đọc file";
            this.btndocFile.UseVisualStyleBackColor = true;
            this.btndocFile.Click += new System.EventHandler(this.btndocFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1148, 667);
            this.Controls.Add(this.btndocFile);
            this.Controls.Add(this.btnghifile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvThongTinHocVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbGioiTinh);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenHocVien);
            this.Controls.Add(this.txtMaHocVien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSdt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTenHocVien);
            this.Controls.Add(this.lblMaHocVien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbGioiTinh.ResumeLayout(false);
            this.gbGioiTinh.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblMaHocVien;
        private System.Windows.Forms.Label lblTenHocVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSdt;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaHocVien;
        private System.Windows.Forms.TextBox txtTenHocVien;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.GroupBox gbGioiTinh;
        private System.Windows.Forms.RadioButton rbnNu;
        private System.Windows.Forms.RadioButton rbnNam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvThongTinHocVien;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txttimTheoTen;
        private System.Windows.Forms.TextBox txttimTheoMa;
        private System.Windows.Forms.RadioButton rbntimTheoTen;
        private System.Windows.Forms.RadioButton rbntimTheoMa;
        private System.Windows.Forms.Button btnghifile;
        private System.Windows.Forms.Button btndocFile;
    }
}

