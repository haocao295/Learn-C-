namespace QuanLyKhoaHoc
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
			this.lblMaKhoa = new System.Windows.Forms.Label();
			this.lblTenKhoa = new System.Windows.Forms.Label();
			this.lblNgayKG = new System.Windows.Forms.Label();
			this.lblNgayKT = new System.Windows.Forms.Label();
			this.txtMaKhoa = new System.Windows.Forms.TextBox();
			this.txtTenKhoa = new System.Windows.Forms.TextBox();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.btnChinhSua = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.lvQLKH = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.dtpNgayKG = new System.Windows.Forms.DateTimePicker();
			this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.ForeColor = System.Drawing.Color.Fuchsia;
			this.label1.Location = new System.Drawing.Point(279, 31);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(446, 58);
			this.label1.TabIndex = 0;
			this.label1.Text = "Quản Lý Khóa Học";
			// 
			// lblMaKhoa
			// 
			this.lblMaKhoa.AutoSize = true;
			this.lblMaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblMaKhoa.ForeColor = System.Drawing.Color.Black;
			this.lblMaKhoa.Location = new System.Drawing.Point(44, 139);
			this.lblMaKhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMaKhoa.Name = "lblMaKhoa";
			this.lblMaKhoa.Size = new System.Drawing.Size(109, 20);
			this.lblMaKhoa.TabIndex = 1;
			this.lblMaKhoa.Text = "Mã Khóa Học";
			// 
			// lblTenKhoa
			// 
			this.lblTenKhoa.AutoSize = true;
			this.lblTenKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblTenKhoa.ForeColor = System.Drawing.Color.Black;
			this.lblTenKhoa.Location = new System.Drawing.Point(44, 198);
			this.lblTenKhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTenKhoa.Name = "lblTenKhoa";
			this.lblTenKhoa.Size = new System.Drawing.Size(114, 20);
			this.lblTenKhoa.TabIndex = 2;
			this.lblTenKhoa.Text = "Tên Khóa Học";
			// 
			// lblNgayKG
			// 
			this.lblNgayKG.AutoSize = true;
			this.lblNgayKG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblNgayKG.ForeColor = System.Drawing.Color.Black;
			this.lblNgayKG.Location = new System.Drawing.Point(44, 262);
			this.lblNgayKG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNgayKG.Name = "lblNgayKG";
			this.lblNgayKG.Size = new System.Drawing.Size(132, 20);
			this.lblNgayKG.TabIndex = 3;
			this.lblNgayKG.Text = "Ngày Khai Giảng";
			// 
			// lblNgayKT
			// 
			this.lblNgayKT.AutoSize = true;
			this.lblNgayKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblNgayKT.ForeColor = System.Drawing.Color.Black;
			this.lblNgayKT.Location = new System.Drawing.Point(44, 319);
			this.lblNgayKT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNgayKT.Name = "lblNgayKT";
			this.lblNgayKT.Size = new System.Drawing.Size(117, 20);
			this.lblNgayKT.TabIndex = 4;
			this.lblNgayKT.Text = "Ngày Kết Thúc";
			// 
			// txtMaKhoa
			// 
			this.txtMaKhoa.Location = new System.Drawing.Point(236, 135);
			this.txtMaKhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtMaKhoa.Name = "txtMaKhoa";
			this.txtMaKhoa.Size = new System.Drawing.Size(283, 22);
			this.txtMaKhoa.TabIndex = 5;
			this.txtMaKhoa.TextChanged += new System.EventHandler(this.txtMaKhoa_TextChanged);
			// 
			// txtTenKhoa
			// 
			this.txtTenKhoa.Location = new System.Drawing.Point(236, 194);
			this.txtTenKhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtTenKhoa.Name = "txtTenKhoa";
			this.txtTenKhoa.Size = new System.Drawing.Size(283, 22);
			this.txtTenKhoa.TabIndex = 8;
			this.txtTenKhoa.TextChanged += new System.EventHandler(this.txtTenKhoa_TextChanged);
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnThem.Location = new System.Drawing.Point(589, 139);
			this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(127, 58);
			this.btnThem.TabIndex = 9;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnTimKiem.Location = new System.Drawing.Point(759, 282);
			this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(127, 58);
			this.btnTimKiem.TabIndex = 10;
			this.btnTimKiem.Text = "Tìm Kiếm";
			this.btnTimKiem.UseVisualStyleBackColor = false;
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// btnChinhSua
			// 
			this.btnChinhSua.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnChinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnChinhSua.Location = new System.Drawing.Point(589, 282);
			this.btnChinhSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnChinhSua.Name = "btnChinhSua";
			this.btnChinhSua.Size = new System.Drawing.Size(127, 58);
			this.btnChinhSua.TabIndex = 11;
			this.btnChinhSua.Text = "Chỉnh Sửa";
			this.btnChinhSua.UseVisualStyleBackColor = false;
			this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnXoa.Location = new System.Drawing.Point(759, 139);
			this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(127, 58);
			this.btnXoa.TabIndex = 12;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = false;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.BackColor = System.Drawing.Color.Red;
			this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnThoat.Location = new System.Drawing.Point(823, 561);
			this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(127, 58);
			this.btnThoat.TabIndex = 13;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = false;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// lvQLKH
			// 
			this.lvQLKH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.lvQLKH.HideSelection = false;
			this.lvQLKH.Location = new System.Drawing.Point(48, 407);
			this.lvQLKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.lvQLKH.Name = "lvQLKH";
			this.lvQLKH.Size = new System.Drawing.Size(667, 212);
			this.lvQLKH.TabIndex = 14;
			this.lvQLKH.UseCompatibleStateImageBehavior = false;
			this.lvQLKH.View = System.Windows.Forms.View.Details;
			this.lvQLKH.SelectedIndexChanged += new System.EventHandler(this.lvQLKH_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Mã khóa học";
			this.columnHeader1.Width = 114;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Tên khóa học";
			this.columnHeader2.Width = 124;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Ngày khai giảng";
			this.columnHeader3.Width = 126;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Ngày kết thúc(dự kiến)";
			this.columnHeader4.Width = 133;
			// 
			// dtpNgayKG
			// 
			this.dtpNgayKG.Location = new System.Drawing.Point(236, 257);
			this.dtpNgayKG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dtpNgayKG.Name = "dtpNgayKG";
			this.dtpNgayKG.Size = new System.Drawing.Size(283, 22);
			this.dtpNgayKG.TabIndex = 15;
			// 
			// dtpNgayKT
			// 
			this.dtpNgayKT.Location = new System.Drawing.Point(236, 319);
			this.dtpNgayKT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dtpNgayKT.Name = "dtpNgayKT";
			this.dtpNgayKT.Size = new System.Drawing.Size(283, 22);
			this.dtpNgayKT.TabIndex = 16;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(963, 635);
			this.Controls.Add(this.dtpNgayKT);
			this.Controls.Add(this.dtpNgayKG);
			this.Controls.Add(this.lvQLKH);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnChinhSua);
			this.Controls.Add(this.btnTimKiem);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.txtTenKhoa);
			this.Controls.Add(this.txtMaKhoa);
			this.Controls.Add(this.lblNgayKT);
			this.Controls.Add(this.lblNgayKG);
			this.Controls.Add(this.lblTenKhoa);
			this.Controls.Add(this.lblMaKhoa);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.Color.Black;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.Label lblTenKhoa;
        private System.Windows.Forms.Label lblNgayKG;
        private System.Windows.Forms.Label lblNgayKT;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListView lvQLKH;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.DateTimePicker dtpNgayKG;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
    }
}

