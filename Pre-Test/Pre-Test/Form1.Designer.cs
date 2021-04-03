namespace Pre_Test
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
			this.ms = new System.Windows.Forms.TextBox();
			this.dt = new System.Windows.Forms.TextBox();
			this.ht = new System.Windows.Forms.TextBox();
			this.dv = new System.Windows.Forms.TextBox();
			this.them = new System.Windows.Forms.Button();
			this.thoat = new System.Windows.Forms.Button();
			this.xoa = new System.Windows.Forms.Button();
			this.sua = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lvHocVien = new System.Windows.Forms.ListView();
			this.mssv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tensv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.nssv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.gtsv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.dtoan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.dvan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.dtb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.ns = new System.Windows.Forms.DateTimePicker();
			this.nam = new System.Windows.Forms.RadioButton();
			this.nu = new System.Windows.Forms.RadioButton();
			this.tnm = new System.Windows.Forms.RadioButton();
			this.tnt = new System.Windows.Forms.RadioButton();
			this.ttm = new System.Windows.Forms.TextBox();
			this.ttt = new System.Windows.Forms.TextBox();
			this.ok = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(210, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(346, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "THÔNG TIN HỌC VIÊN";
			// 
			// ms
			// 
			this.ms.Location = new System.Drawing.Point(102, 61);
			this.ms.Name = "ms";
			this.ms.Size = new System.Drawing.Size(222, 22);
			this.ms.TabIndex = 7;
			// 
			// dt
			// 
			this.dt.Location = new System.Drawing.Point(102, 237);
			this.dt.Name = "dt";
			this.dt.Size = new System.Drawing.Size(222, 22);
			this.dt.TabIndex = 8;
			// 
			// ht
			// 
			this.ht.Location = new System.Drawing.Point(102, 97);
			this.ht.Name = "ht";
			this.ht.Size = new System.Drawing.Size(222, 22);
			this.ht.TabIndex = 9;
			// 
			// dv
			// 
			this.dv.Location = new System.Drawing.Point(102, 198);
			this.dv.Name = "dv";
			this.dv.Size = new System.Drawing.Size(222, 22);
			this.dv.TabIndex = 10;
			// 
			// them
			// 
			this.them.Location = new System.Drawing.Point(365, 57);
			this.them.Name = "them";
			this.them.Size = new System.Drawing.Size(89, 57);
			this.them.TabIndex = 11;
			this.them.Text = "Thêm";
			this.them.UseVisualStyleBackColor = true;
			this.them.Click += new System.EventHandler(this.them_Click);
			// 
			// thoat
			// 
			this.thoat.Location = new System.Drawing.Point(467, 126);
			this.thoat.Name = "thoat";
			this.thoat.Size = new System.Drawing.Size(89, 57);
			this.thoat.TabIndex = 12;
			this.thoat.Text = "Thoát";
			this.thoat.UseVisualStyleBackColor = true;
			this.thoat.Click += new System.EventHandler(this.thoat_Click);
			// 
			// xoa
			// 
			this.xoa.Location = new System.Drawing.Point(365, 126);
			this.xoa.Name = "xoa";
			this.xoa.Size = new System.Drawing.Size(89, 57);
			this.xoa.TabIndex = 13;
			this.xoa.Text = "Xóa";
			this.xoa.UseVisualStyleBackColor = true;
			this.xoa.Click += new System.EventHandler(this.xoa_Click);
			// 
			// sua
			// 
			this.sua.Location = new System.Drawing.Point(467, 57);
			this.sua.Name = "sua";
			this.sua.Size = new System.Drawing.Size(89, 57);
			this.sua.TabIndex = 14;
			this.sua.Text = "Sửa";
			this.sua.UseVisualStyleBackColor = true;
			this.sua.Click += new System.EventHandler(this.sua_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.ok);
			this.groupBox1.Controls.Add(this.ttt);
			this.groupBox1.Controls.Add(this.ttm);
			this.groupBox1.Controls.Add(this.tnt);
			this.groupBox1.Controls.Add(this.tnm);
			this.groupBox1.Location = new System.Drawing.Point(579, 59);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(266, 123);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tìm Kiếm";
			// 
			// lvHocVien
			// 
			this.lvHocVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mssv,
            this.tensv,
            this.nssv,
            this.gtsv,
            this.dtoan,
            this.dvan,
            this.dtb});
			this.lvHocVien.FullRowSelect = true;
			this.lvHocVien.HideSelection = false;
			this.lvHocVien.Location = new System.Drawing.Point(37, 295);
			this.lvHocVien.Name = "lvHocVien";
			this.lvHocVien.Size = new System.Drawing.Size(816, 224);
			this.lvHocVien.TabIndex = 16;
			this.lvHocVien.UseCompatibleStateImageBehavior = false;
			this.lvHocVien.View = System.Windows.Forms.View.Details;
			this.lvHocVien.SelectedIndexChanged += new System.EventHandler(this.lvHocVien_SelectedIndexChanged);
			// 
			// mssv
			// 
			this.mssv.Text = "Mã Số";
			this.mssv.Width = 82;
			// 
			// tensv
			// 
			this.tensv.Text = "Họ Tên";
			this.tensv.Width = 212;
			// 
			// nssv
			// 
			this.nssv.Text = "Ngày Sinh";
			this.nssv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nssv.Width = 171;
			// 
			// gtsv
			// 
			this.gtsv.Text = "Giới Tính";
			this.gtsv.Width = 72;
			// 
			// dtoan
			// 
			this.dtoan.Text = "Điểm Toán";
			this.dtoan.Width = 101;
			// 
			// dvan
			// 
			this.dvan.Text = "Điểm Văn";
			this.dvan.Width = 84;
			// 
			// dtb
			// 
			this.dtb.Text = "Điểm TB";
			this.dtb.Width = 92;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 17);
			this.label2.TabIndex = 17;
			this.label2.Text = "Mã Số";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(20, 201);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 17);
			this.label3.TabIndex = 18;
			this.label3.Text = "Điểm Văn";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(20, 166);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 17);
			this.label4.TabIndex = 19;
			this.label4.Text = "Giới Tính";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(20, 136);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 17);
			this.label5.TabIndex = 20;
			this.label5.Text = "Ngày Sinh";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(20, 97);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 17);
			this.label6.TabIndex = 21;
			this.label6.Text = "Họ Tên";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(20, 242);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(77, 17);
			this.label7.TabIndex = 22;
			this.label7.Text = "Điểm Toán";
			// 
			// ns
			// 
			this.ns.Location = new System.Drawing.Point(103, 136);
			this.ns.Name = "ns";
			this.ns.Size = new System.Drawing.Size(220, 22);
			this.ns.TabIndex = 23;
			// 
			// nam
			// 
			this.nam.AutoSize = true;
			this.nam.Location = new System.Drawing.Point(103, 164);
			this.nam.Name = "nam";
			this.nam.Size = new System.Drawing.Size(58, 21);
			this.nam.TabIndex = 24;
			this.nam.TabStop = true;
			this.nam.Text = "Nam";
			this.nam.UseVisualStyleBackColor = true;
			// 
			// nu
			// 
			this.nu.AutoSize = true;
			this.nu.Location = new System.Drawing.Point(167, 164);
			this.nu.Name = "nu";
			this.nu.Size = new System.Drawing.Size(47, 21);
			this.nu.TabIndex = 25;
			this.nu.TabStop = true;
			this.nu.Text = "Nữ";
			this.nu.UseVisualStyleBackColor = true;
			// 
			// tnm
			// 
			this.tnm.AutoSize = true;
			this.tnm.Location = new System.Drawing.Point(15, 28);
			this.tnm.Name = "tnm";
			this.tnm.Size = new System.Drawing.Size(112, 21);
			this.tnm.TabIndex = 0;
			this.tnm.TabStop = true;
			this.tnm.Text = "Tìm Theo Mã";
			this.tnm.UseVisualStyleBackColor = true;
			// 
			// tnt
			// 
			this.tnt.AutoSize = true;
			this.tnt.Location = new System.Drawing.Point(15, 55);
			this.tnt.Name = "tnt";
			this.tnt.Size = new System.Drawing.Size(108, 21);
			this.tnt.TabIndex = 1;
			this.tnt.TabStop = true;
			this.tnt.Text = "Tìm theo tên";
			this.tnt.UseVisualStyleBackColor = true;
			// 
			// ttm
			// 
			this.ttm.Location = new System.Drawing.Point(128, 31);
			this.ttm.Name = "ttm";
			this.ttm.Size = new System.Drawing.Size(137, 22);
			this.ttm.TabIndex = 2;
			// 
			// ttt
			// 
			this.ttt.Location = new System.Drawing.Point(126, 62);
			this.ttt.Name = "ttt";
			this.ttt.Size = new System.Drawing.Size(138, 22);
			this.ttt.TabIndex = 3;
			// 
			// ok
			// 
			this.ok.Location = new System.Drawing.Point(51, 92);
			this.ok.Name = "ok";
			this.ok.Size = new System.Drawing.Size(99, 25);
			this.ok.TabIndex = 4;
			this.ok.Text = "OK";
			this.ok.UseVisualStyleBackColor = true;
			this.ok.Click += new System.EventHandler(this.ok_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(867, 545);
			this.Controls.Add(this.nu);
			this.Controls.Add(this.nam);
			this.Controls.Add(this.ns);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lvHocVien);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.sua);
			this.Controls.Add(this.xoa);
			this.Controls.Add(this.thoat);
			this.Controls.Add(this.them);
			this.Controls.Add(this.dv);
			this.Controls.Add(this.ht);
			this.Controls.Add(this.dt);
			this.Controls.Add(this.ms);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox ms;
		private System.Windows.Forms.TextBox dt;
		private System.Windows.Forms.TextBox ht;
		private System.Windows.Forms.TextBox dv;
		private System.Windows.Forms.Button them;
		private System.Windows.Forms.Button thoat;
		private System.Windows.Forms.Button xoa;
		private System.Windows.Forms.Button sua;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListView lvHocVien;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker ns;
		private System.Windows.Forms.RadioButton nam;
		private System.Windows.Forms.RadioButton nu;
		private System.Windows.Forms.ColumnHeader mssv;
		private System.Windows.Forms.ColumnHeader tensv;
		private System.Windows.Forms.ColumnHeader nssv;
		private System.Windows.Forms.ColumnHeader gtsv;
		private System.Windows.Forms.ColumnHeader dtoan;
		private System.Windows.Forms.ColumnHeader dvan;
		private System.Windows.Forms.ColumnHeader dtb;
		private System.Windows.Forms.Button ok;
		private System.Windows.Forms.TextBox ttt;
		private System.Windows.Forms.TextBox ttm;
		private System.Windows.Forms.RadioButton tnt;
		private System.Windows.Forms.RadioButton tnm;
	}
}

