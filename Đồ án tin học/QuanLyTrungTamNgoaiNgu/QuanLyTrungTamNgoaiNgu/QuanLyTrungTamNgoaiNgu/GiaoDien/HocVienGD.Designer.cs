namespace QuanLyTrungTamNgoaiNgu.GiaoDien
{
    partial class HocVienGD
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
            this.btnluu = new System.Windows.Forms.Button();
            this.lblnhapma = new System.Windows.Forms.Label();
            this.btntim = new System.Windows.Forms.Button();
            this.txtnhapma = new System.Windows.Forms.TextBox();
            this.gbgioitinh = new System.Windows.Forms.GroupBox();
            this.radnam = new System.Windows.Forms.RadioButton();
            this.radnu = new System.Windows.Forms.RadioButton();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvdanhsachhv = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnthoat = new System.Windows.Forms.Button();
            this.dtbngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtmahocvien = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblsodienthoai = new System.Windows.Forms.Label();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.lblngaysinh = new System.Windows.Forms.Label();
            this.lblhoten = new System.Windows.Forms.Label();
            this.lblmahocvien = new System.Windows.Forms.Label();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbgioitinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnluu
            // 
            this.btnluu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.ForeColor = System.Drawing.Color.Blue;
            this.btnluu.Location = new System.Drawing.Point(897, 500);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(85, 41);
            this.btnluu.TabIndex = 117;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // lblnhapma
            // 
            this.lblnhapma.AutoSize = true;
            this.lblnhapma.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnhapma.Location = new System.Drawing.Point(783, 106);
            this.lblnhapma.Name = "lblnhapma";
            this.lblnhapma.Size = new System.Drawing.Size(124, 17);
            this.lblnhapma.TabIndex = 116;
            this.lblnhapma.Text = "Nhập mã học viên";
            // 
            // btntim
            // 
            this.btntim.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntim.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btntim.Location = new System.Drawing.Point(1059, 104);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(83, 26);
            this.btntim.TabIndex = 114;
            this.btntim.Text = "Tìm kiếm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // txtnhapma
            // 
            this.txtnhapma.Location = new System.Drawing.Point(924, 104);
            this.txtnhapma.Name = "txtnhapma";
            this.txtnhapma.Size = new System.Drawing.Size(129, 22);
            this.txtnhapma.TabIndex = 115;
            // 
            // gbgioitinh
            // 
            this.gbgioitinh.Controls.Add(this.radnam);
            this.gbgioitinh.Controls.Add(this.radnu);
            this.gbgioitinh.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbgioitinh.Location = new System.Drawing.Point(144, 234);
            this.gbgioitinh.Name = "gbgioitinh";
            this.gbgioitinh.Size = new System.Drawing.Size(200, 66);
            this.gbgioitinh.TabIndex = 112;
            this.gbgioitinh.TabStop = false;
            // 
            // radnam
            // 
            this.radnam.AutoSize = true;
            this.radnam.Checked = true;
            this.radnam.Location = new System.Drawing.Point(28, 29);
            this.radnam.Name = "radnam";
            this.radnam.Size = new System.Drawing.Size(57, 21);
            this.radnam.TabIndex = 18;
            this.radnam.TabStop = true;
            this.radnam.Text = "Nam";
            this.radnam.UseVisualStyleBackColor = true;
            // 
            // radnu
            // 
            this.radnu.AutoSize = true;
            this.radnu.Location = new System.Drawing.Point(121, 29);
            this.radnu.Name = "radnu";
            this.radnu.Size = new System.Drawing.Size(46, 21);
            this.radnu.TabIndex = 19;
            this.radnu.TabStop = true;
            this.radnu.Text = "Nữ";
            this.radnu.UseVisualStyleBackColor = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã học viên";
            this.columnHeader1.Width = 99;
            // 
            // lvdanhsachhv
            // 
            this.lvdanhsachhv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvdanhsachhv.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvdanhsachhv.FullRowSelect = true;
            this.lvdanhsachhv.HideSelection = false;
            this.lvdanhsachhv.Location = new System.Drawing.Point(417, 149);
            this.lvdanhsachhv.Name = "lvdanhsachhv";
            this.lvdanhsachhv.Size = new System.Drawing.Size(779, 339);
            this.lvdanhsachhv.TabIndex = 111;
            this.lvdanhsachhv.UseCompatibleStateImageBehavior = false;
            this.lvdanhsachhv.View = System.Windows.Forms.View.Details;
            this.lvdanhsachhv.SelectedIndexChanged += new System.EventHandler(this.lvdanhsachhv_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ, tên";
            this.columnHeader2.Width = 124;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày sinh";
            this.columnHeader3.Width = 122;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giới tính";
            this.columnHeader4.Width = 66;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Địa chỉ";
            this.columnHeader5.Width = 115;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số điện thoại";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "E-mail";
            this.columnHeader7.Width = 111;
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(1106, 507);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(90, 34);
            this.btnthoat.TabIndex = 110;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // dtbngaysinh
            // 
            this.dtbngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtbngaysinh.Location = new System.Drawing.Point(144, 306);
            this.dtbngaysinh.Name = "dtbngaysinh";
            this.dtbngaysinh.Size = new System.Drawing.Size(200, 22);
            this.dtbngaysinh.TabIndex = 109;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(144, 422);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(200, 22);
            this.txtemail.TabIndex = 108;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(144, 347);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(200, 22);
            this.txtdiachi.TabIndex = 107;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(144, 384);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(200, 22);
            this.txtsdt.TabIndex = 106;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(144, 192);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(200, 22);
            this.txthoten.TabIndex = 105;
            // 
            // txtmahocvien
            // 
            this.txtmahocvien.Location = new System.Drawing.Point(144, 150);
            this.txtmahocvien.Name = "txtmahocvien";
            this.txtmahocvien.Size = new System.Drawing.Size(200, 22);
            this.txtmahocvien.TabIndex = 104;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(38, 422);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(50, 17);
            this.lblemail.TabIndex = 103;
            this.lblemail.Text = "E-mail";
            // 
            // lblsodienthoai
            // 
            this.lblsodienthoai.AutoSize = true;
            this.lblsodienthoai.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsodienthoai.Location = new System.Drawing.Point(38, 389);
            this.lblsodienthoai.Name = "lblsodienthoai";
            this.lblsodienthoai.Size = new System.Drawing.Size(92, 17);
            this.lblsodienthoai.TabIndex = 102;
            this.lblsodienthoai.Text = "Số điện thoại";
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiachi.Location = new System.Drawing.Point(39, 347);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(53, 17);
            this.lbldiachi.TabIndex = 101;
            this.lbldiachi.Text = "Địa chỉ";
            // 
            // lblngaysinh
            // 
            this.lblngaysinh.AutoSize = true;
            this.lblngaysinh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblngaysinh.Location = new System.Drawing.Point(39, 306);
            this.lblngaysinh.Name = "lblngaysinh";
            this.lblngaysinh.Size = new System.Drawing.Size(72, 17);
            this.lblngaysinh.TabIndex = 100;
            this.lblngaysinh.Text = "Ngày sinh";
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhoten.Location = new System.Drawing.Point(38, 192);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(72, 17);
            this.lblhoten.TabIndex = 99;
            this.lblhoten.Text = "Họ và tên";
            // 
            // lblmahocvien
            // 
            this.lblmahocvien.AutoSize = true;
            this.lblmahocvien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmahocvien.Location = new System.Drawing.Point(39, 151);
            this.lblmahocvien.Name = "lblmahocvien";
            this.lblmahocvien.Size = new System.Drawing.Size(94, 17);
            this.lblmahocvien.TabIndex = 98;
            this.lblmahocvien.Text = "Mã Học Viên";
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.Color.Blue;
            this.btnsua.Location = new System.Drawing.Point(684, 500);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(90, 41);
            this.btnsua.TabIndex = 97;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.Color.Blue;
            this.btnxoa.Location = new System.Drawing.Point(791, 500);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(86, 41);
            this.btnxoa.TabIndex = 96;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.Color.Blue;
            this.btnthem.Location = new System.Drawing.Point(590, 500);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(86, 41);
            this.btnthem.TabIndex = 95;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 118;
            this.label2.Text = "Giới tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 48);
            this.label1.TabIndex = 119;
            this.label1.Text = "Quản Lý Học Viên";
            // 
            // HocVienGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 574);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.lblnhapma);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.txtnhapma);
            this.Controls.Add(this.gbgioitinh);
            this.Controls.Add(this.lvdanhsachhv);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.dtbngaysinh);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.txtmahocvien);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblsodienthoai);
            this.Controls.Add(this.lbldiachi);
            this.Controls.Add(this.lblngaysinh);
            this.Controls.Add(this.lblhoten);
            this.Controls.Add(this.lblmahocvien);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "HocVienGD";
            this.Text = "HocVienGD";
            this.Load += new System.EventHandler(this.HocVienGD_Load);
            this.gbgioitinh.ResumeLayout(false);
            this.gbgioitinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Label lblnhapma;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.TextBox txtnhapma;
        private System.Windows.Forms.GroupBox gbgioitinh;
        private System.Windows.Forms.RadioButton radnam;
        private System.Windows.Forms.RadioButton radnu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lvdanhsachhv;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.DateTimePicker dtbngaysinh;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtmahocvien;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblsodienthoai;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.Label lblngaysinh;
        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.Label lblmahocvien;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}