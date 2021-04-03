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
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.lblMaHocVien = new System.Windows.Forms.Label();
			this.lblTenHocVien = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lbldiachi = new System.Windows.Forms.Label();
			this.lblSdt = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtMaHocVien = new System.Windows.Forms.TextBox();
			this.txtTenHocVien = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
			this.gbGioiTinh = new System.Windows.Forms.GroupBox();
			this.rboNu = new System.Windows.Forms.RadioButton();
			this.rboNam = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.lvThongTinHocVien = new System.Windows.Forms.ListView();
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.gbGioiTinh.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnThem.ForeColor = System.Drawing.Color.Red;
			this.btnThem.Location = new System.Drawing.Point(307, 321);
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
			this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnXoa.ForeColor = System.Drawing.Color.Red;
			this.btnXoa.Location = new System.Drawing.Point(489, 321);
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
			this.btnChinhSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnChinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnChinhSua.ForeColor = System.Drawing.Color.Red;
			this.btnChinhSua.Location = new System.Drawing.Point(673, 321);
			this.btnChinhSua.Margin = new System.Windows.Forms.Padding(4);
			this.btnChinhSua.Name = "btnChinhSua";
			this.btnChinhSua.Size = new System.Drawing.Size(113, 43);
			this.btnChinhSua.TabIndex = 3;
			this.btnChinhSua.Text = "Chỉnh Sửa";
			this.btnChinhSua.UseVisualStyleBackColor = false;
			this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnTimKiem.ForeColor = System.Drawing.Color.Red;
			this.btnTimKiem.Location = new System.Drawing.Point(872, 321);
			this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(113, 43);
			this.btnTimKiem.TabIndex = 4;
			this.btnTimKiem.Text = "Tìm Kiếm";
			this.btnTimKiem.UseVisualStyleBackColor = false;
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.BackColor = System.Drawing.Color.Red;
			this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnThoat.ForeColor = System.Drawing.Color.Yellow;
			this.btnThoat.Location = new System.Drawing.Point(1019, 411);
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
			this.lblMaHocVien.ForeColor = System.Drawing.Color.Black;
			this.lblMaHocVien.Location = new System.Drawing.Point(43, 130);
			this.lblMaHocVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMaHocVien.Name = "lblMaHocVien";
			this.lblMaHocVien.Size = new System.Drawing.Size(104, 20);
			this.lblMaHocVien.TabIndex = 6;
			this.lblMaHocVien.Text = "Mã Học Viên";
			// 
			// lblTenHocVien
			// 
			this.lblTenHocVien.AutoSize = true;
			this.lblTenHocVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblTenHocVien.ForeColor = System.Drawing.Color.Black;
			this.lblTenHocVien.Location = new System.Drawing.Point(545, 126);
			this.lblTenHocVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTenHocVien.Name = "lblTenHocVien";
			this.lblTenHocVien.Size = new System.Drawing.Size(109, 20);
			this.lblTenHocVien.TabIndex = 7;
			this.lblTenHocVien.Text = "Tên Học Viên";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(43, 192);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 20);
			this.label3.TabIndex = 8;
			this.label3.Text = "Ngày Sinh";
			// 
			// lbldiachi
			// 
			this.lbldiachi.AutoSize = true;
			this.lbldiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbldiachi.ForeColor = System.Drawing.Color.Black;
			this.lbldiachi.Location = new System.Drawing.Point(545, 183);
			this.lbldiachi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbldiachi.Name = "lbldiachi";
			this.lbldiachi.Size = new System.Drawing.Size(63, 20);
			this.lbldiachi.TabIndex = 9;
			this.lbldiachi.Text = "Địa Chỉ";
			// 
			// lblSdt
			// 
			this.lblSdt.AutoSize = true;
			this.lblSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblSdt.ForeColor = System.Drawing.Color.Black;
			this.lblSdt.Location = new System.Drawing.Point(545, 240);
			this.lblSdt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSdt.Name = "lblSdt";
			this.lblSdt.Size = new System.Drawing.Size(112, 20);
			this.lblSdt.TabIndex = 10;
			this.lblSdt.Text = "Số Điện Thoại";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblEmail.ForeColor = System.Drawing.Color.Black;
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
			this.txtMaHocVien.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtMaHocVien.Location = new System.Drawing.Point(181, 122);
			this.txtMaHocVien.Margin = new System.Windows.Forms.Padding(4);
			this.txtMaHocVien.Name = "txtMaHocVien";
			this.txtMaHocVien.Size = new System.Drawing.Size(312, 22);
			this.txtMaHocVien.TabIndex = 13;
			this.txtMaHocVien.TextChanged += new System.EventHandler(this.txtMaHocVien_TextChanged);
			// 
			// txtTenHocVien
			// 
			this.txtTenHocVien.Location = new System.Drawing.Point(691, 122);
			this.txtTenHocVien.Margin = new System.Windows.Forms.Padding(4);
			this.txtTenHocVien.Name = "txtTenHocVien";
			this.txtTenHocVien.Size = new System.Drawing.Size(312, 22);
			this.txtTenHocVien.TabIndex = 14;
			this.txtTenHocVien.TextChanged += new System.EventHandler(this.txtTenHocVien_TextChanged);
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(691, 180);
			this.textBox5.Margin = new System.Windows.Forms.Padding(4);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(312, 22);
			this.textBox5.TabIndex = 16;
			this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(691, 236);
			this.textBox6.Margin = new System.Windows.Forms.Padding(4);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(312, 22);
			this.textBox6.TabIndex = 17;
			this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(181, 240);
			this.textBox7.Margin = new System.Windows.Forms.Padding(4);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(312, 22);
			this.textBox7.TabIndex = 18;
			this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
			// 
			// dtpNgaySinh
			// 
			this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpNgaySinh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.dtpNgaySinh.Location = new System.Drawing.Point(181, 183);
			this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(4);
			this.dtpNgaySinh.Name = "dtpNgaySinh";
			this.dtpNgaySinh.Size = new System.Drawing.Size(312, 22);
			this.dtpNgaySinh.TabIndex = 19;
			this.dtpNgaySinh.ValueChanged += new System.EventHandler(this.dtpNgaySinh_ValueChanged);
			// 
			// gbGioiTinh
			// 
			this.gbGioiTinh.Controls.Add(this.rboNu);
			this.gbGioiTinh.Controls.Add(this.rboNam);
			this.gbGioiTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gbGioiTinh.Location = new System.Drawing.Point(47, 294);
			this.gbGioiTinh.Margin = new System.Windows.Forms.Padding(4);
			this.gbGioiTinh.Name = "gbGioiTinh";
			this.gbGioiTinh.Padding = new System.Windows.Forms.Padding(4);
			this.gbGioiTinh.Size = new System.Drawing.Size(180, 70);
			this.gbGioiTinh.TabIndex = 20;
			this.gbGioiTinh.TabStop = false;
			this.gbGioiTinh.Text = "Giới Tính";
			this.gbGioiTinh.Enter += new System.EventHandler(this.gbGioiTinh_Enter);
			// 
			// rboNu
			// 
			this.rboNu.AutoSize = true;
			this.rboNu.Location = new System.Drawing.Point(105, 23);
			this.rboNu.Margin = new System.Windows.Forms.Padding(4);
			this.rboNu.Name = "rboNu";
			this.rboNu.Size = new System.Drawing.Size(47, 21);
			this.rboNu.TabIndex = 2;
			this.rboNu.TabStop = true;
			this.rboNu.Text = "Nữ";
			this.rboNu.UseVisualStyleBackColor = true;
			// 
			// rboNam
			// 
			this.rboNam.AutoSize = true;
			this.rboNam.Location = new System.Drawing.Point(8, 23);
			this.rboNam.Margin = new System.Windows.Forms.Padding(4);
			this.rboNam.Name = "rboNam";
			this.rboNam.Size = new System.Drawing.Size(58, 21);
			this.rboNam.TabIndex = 1;
			this.rboNam.TabStop = true;
			this.rboNam.Text = "Nam";
			this.rboNam.UseVisualStyleBackColor = true;
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
			this.lvThongTinHocVien.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.lvThongTinHocVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.lvThongTinHocVien.HideSelection = false;
			this.lvThongTinHocVien.Location = new System.Drawing.Point(47, 411);
			this.lvThongTinHocVien.Margin = new System.Windows.Forms.Padding(4);
			this.lvThongTinHocVien.Name = "lvThongTinHocVien";
			this.lvThongTinHocVien.Size = new System.Drawing.Size(956, 245);
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
			this.columnHeader9.Width = 108;
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
			this.columnHeader3.Width = 112;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(1148, 667);
			this.Controls.Add(this.lvThongTinHocVien);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.gbGioiTinh);
			this.Controls.Add(this.dtpNgaySinh);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.txtTenHocVien);
			this.Controls.Add(this.txtMaHocVien);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.lblSdt);
			this.Controls.Add(this.lbldiachi);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblTenHocVien);
			this.Controls.Add(this.lblMaHocVien);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnTimKiem);
			this.Controls.Add(this.btnChinhSua);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnThem);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.gbGioiTinh.ResumeLayout(false);
			this.gbGioiTinh.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblMaHocVien;
        private System.Windows.Forms.Label lblTenHocVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.Label lblSdt;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaHocVien;
        private System.Windows.Forms.TextBox txtTenHocVien;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.GroupBox gbGioiTinh;
        private System.Windows.Forms.RadioButton rboNu;
        private System.Windows.Forms.RadioButton rboNam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvThongTinHocVien;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

