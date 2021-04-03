namespace lab4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nu = new System.Windows.Forms.RadioButton();
            this.nam = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.them = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.mahv = new System.Windows.Forms.TextBox();
            this.hoten = new System.Windows.Forms.TextBox();
            this.toan = new System.Windows.Forms.TextBox();
            this.van = new System.Windows.Forms.TextBox();
            this.tb = new System.Windows.Forms.TextBox();
            this.xeploai = new System.Windows.Forms.TextBox();
            this.lvDanhSachHocVien = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chonMa = new System.Windows.Forms.RadioButton();
            this.chonTen = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.timTheoMa = new System.Windows.Forms.TextBox();
            this.timTheoTen = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã học viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nu);
            this.groupBox1.Controls.Add(this.nam);
            this.groupBox1.Location = new System.Drawing.Point(149, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 49);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn";
            // 
            // nu
            // 
            this.nu.AutoSize = true;
            this.nu.Location = new System.Drawing.Point(125, 18);
            this.nu.Name = "nu";
            this.nu.Size = new System.Drawing.Size(39, 17);
            this.nu.TabIndex = 1;
            this.nu.Text = "Nữ";
            this.nu.UseVisualStyleBackColor = true;
            // 
            // nam
            // 
            this.nam.AutoSize = true;
            this.nam.Checked = true;
            this.nam.Location = new System.Drawing.Point(17, 20);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(47, 17);
            this.nam.TabIndex = 0;
            this.nam.TabStop = true;
            this.nam.Text = "Nam";
            this.nam.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Điểm toán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Điểm văn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Trung bình";
            // 
            // ngaysinh
            // 
            this.ngaysinh.Location = new System.Drawing.Point(149, 111);
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Size = new System.Drawing.Size(200, 20);
            this.ngaysinh.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Loại";
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(393, 41);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(75, 23);
            this.them.TabIndex = 10;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // sua
            // 
            this.sua.Location = new System.Drawing.Point(393, 87);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(75, 23);
            this.sua.TabIndex = 11;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(393, 135);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(75, 23);
            this.xoa.TabIndex = 12;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(393, 188);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(75, 23);
            this.thoat.TabIndex = 13;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // mahv
            // 
            this.mahv.Location = new System.Drawing.Point(149, 44);
            this.mahv.Name = "mahv";
            this.mahv.Size = new System.Drawing.Size(100, 20);
            this.mahv.TabIndex = 14;
            this.mahv.Text = "DH";
            // 
            // hoten
            // 
            this.hoten.Location = new System.Drawing.Point(149, 77);
            this.hoten.Name = "hoten";
            this.hoten.Size = new System.Drawing.Size(200, 20);
            this.hoten.TabIndex = 15;
            this.hoten.Text = "Khanh";
            // 
            // toan
            // 
            this.toan.Location = new System.Drawing.Point(149, 201);
            this.toan.Name = "toan";
            this.toan.Size = new System.Drawing.Size(64, 20);
            this.toan.TabIndex = 16;
            this.toan.Text = "1";
            // 
            // van
            // 
            this.van.Location = new System.Drawing.Point(149, 230);
            this.van.Name = "van";
            this.van.Size = new System.Drawing.Size(64, 20);
            this.van.TabIndex = 17;
            this.van.Text = "1";
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(149, 256);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(64, 20);
            this.tb.TabIndex = 18;
            // 
            // xeploai
            // 
            this.xeploai.Location = new System.Drawing.Point(149, 286);
            this.xeploai.Name = "xeploai";
            this.xeploai.Size = new System.Drawing.Size(64, 20);
            this.xeploai.TabIndex = 19;
            // 
            // lvDanhSachHocVien
            // 
            this.lvDanhSachHocVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvDanhSachHocVien.FullRowSelect = true;
            this.lvDanhSachHocVien.HideSelection = false;
            this.lvDanhSachHocVien.Location = new System.Drawing.Point(6, 429);
            this.lvDanhSachHocVien.MultiSelect = false;
            this.lvDanhSachHocVien.Name = "lvDanhSachHocVien";
            this.lvDanhSachHocVien.Size = new System.Drawing.Size(589, 118);
            this.lvDanhSachHocVien.TabIndex = 20;
            this.lvDanhSachHocVien.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachHocVien.View = System.Windows.Forms.View.Details;
            this.lvDanhSachHocVien.SelectedIndexChanged += new System.EventHandler(this.lvDanhSachHocVien_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã học viên";
            this.columnHeader1.Width = 79;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ tên";
            this.columnHeader2.Width = 128;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày sinh";
            this.columnHeader3.Width = 82;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giới tính";
            this.columnHeader4.Width = 54;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Điểm toán";
            this.columnHeader5.Width = 65;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Điểm văn";
            this.columnHeader6.Width = 58;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = " Trung bình";
            this.columnHeader7.Width = 68;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Xếp loại";
            this.columnHeader8.Width = 190;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.timTheoTen);
            this.groupBox2.Controls.Add(this.timTheoMa);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.chonTen);
            this.groupBox2.Controls.Add(this.chonMa);
            this.groupBox2.Location = new System.Drawing.Point(330, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 116);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // chonMa
            // 
            this.chonMa.AutoSize = true;
            this.chonMa.Location = new System.Drawing.Point(17, 26);
            this.chonMa.Name = "chonMa";
            this.chonMa.Size = new System.Drawing.Size(83, 17);
            this.chonMa.TabIndex = 0;
            this.chonMa.TabStop = true;
            this.chonMa.Text = "Tìm theo mã";
            this.chonMa.UseVisualStyleBackColor = true;
            // 
            // chonTen
            // 
            this.chonTen.AutoSize = true;
            this.chonTen.Location = new System.Drawing.Point(17, 56);
            this.chonTen.Name = "chonTen";
            this.chonTen.Size = new System.Drawing.Size(84, 17);
            this.chonTen.TabIndex = 1;
            this.chonTen.TabStop = true;
            this.chonTen.Text = "Tìm theo tên";
            this.chonTen.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timTheoMa
            // 
            this.timTheoMa.Location = new System.Drawing.Point(107, 26);
            this.timTheoMa.Name = "timTheoMa";
            this.timTheoMa.Size = new System.Drawing.Size(100, 20);
            this.timTheoMa.TabIndex = 3;
            // 
            // timTheoTen
            // 
            this.timTheoTen.Location = new System.Drawing.Point(107, 53);
            this.timTheoTen.Name = "timTheoTen";
            this.timTheoTen.Size = new System.Drawing.Size(100, 20);
            this.timTheoTen.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 559);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lvDanhSachHocVien);
            this.Controls.Add(this.xeploai);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.van);
            this.Controls.Add(this.toan);
            this.Controls.Add(this.hoten);
            this.Controls.Add(this.mahv);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.them);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ngaysinh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton nu;
        private System.Windows.Forms.RadioButton nam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker ngaysinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.TextBox mahv;
        private System.Windows.Forms.TextBox hoten;
        private System.Windows.Forms.TextBox toan;
        private System.Windows.Forms.TextBox van;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.TextBox xeploai;
        private System.Windows.Forms.ListView lvDanhSachHocVien;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox timTheoTen;
        private System.Windows.Forms.TextBox timTheoMa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton chonTen;
        private System.Windows.Forms.RadioButton chonMa;
    }
}

