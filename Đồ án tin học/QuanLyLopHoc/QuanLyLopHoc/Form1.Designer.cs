namespace QuanLyLopHoc
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
			this.lblMaLop = new System.Windows.Forms.Label();
			this.lblTenLop = new System.Windows.Forms.Label();
			this.lblGhiChu = new System.Windows.Forms.Label();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnChinhSua = new System.Windows.Forms.Button();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.txtMaLop = new System.Windows.Forms.TextBox();
			this.txtGhiChu = new System.Windows.Forms.TextBox();
			this.txtTenLop = new System.Windows.Forms.TextBox();
			this.lvQLLH = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label1.Location = new System.Drawing.Point(212, 39);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(413, 58);
			this.label1.TabIndex = 0;
			this.label1.Text = "Quản Lý Lớp Học";
			// 
			// lblMaLop
			// 
			this.lblMaLop.AutoSize = true;
			this.lblMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblMaLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.lblMaLop.Location = new System.Drawing.Point(18, 133);
			this.lblMaLop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblMaLop.Name = "lblMaLop";
			this.lblMaLop.Size = new System.Drawing.Size(99, 20);
			this.lblMaLop.TabIndex = 1;
			this.lblMaLop.Text = "Mã Lớp Học";
			// 
			// lblTenLop
			// 
			this.lblTenLop.AutoSize = true;
			this.lblTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblTenLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.lblTenLop.Location = new System.Drawing.Point(18, 185);
			this.lblTenLop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblTenLop.Name = "lblTenLop";
			this.lblTenLop.Size = new System.Drawing.Size(69, 20);
			this.lblTenLop.TabIndex = 2;
			this.lblTenLop.Text = "Tên Lớp";
			// 
			// lblGhiChu
			// 
			this.lblGhiChu.AutoSize = true;
			this.lblGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblGhiChu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.lblGhiChu.Location = new System.Drawing.Point(18, 237);
			this.lblGhiChu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblGhiChu.Name = "lblGhiChu";
			this.lblGhiChu.Size = new System.Drawing.Size(69, 20);
			this.lblGhiChu.TabIndex = 3;
			this.lblGhiChu.Text = "Ghi Chú";
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnThem.Location = new System.Drawing.Point(31, 294);
			this.btnThem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(96, 39);
			this.btnThem.TabIndex = 4;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnXoa.Location = new System.Drawing.Point(211, 294);
			this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(96, 39);
			this.btnXoa.TabIndex = 5;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = false;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnChinhSua
			// 
			this.btnChinhSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnChinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnChinhSua.Location = new System.Drawing.Point(31, 375);
			this.btnChinhSua.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btnChinhSua.Name = "btnChinhSua";
			this.btnChinhSua.Size = new System.Drawing.Size(96, 39);
			this.btnChinhSua.TabIndex = 6;
			this.btnChinhSua.Text = "Chỉnh Sửa";
			this.btnChinhSua.UseVisualStyleBackColor = false;
			this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnTimKiem.Location = new System.Drawing.Point(211, 375);
			this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(96, 39);
			this.btnTimKiem.TabIndex = 7;
			this.btnTimKiem.Text = "Tìm Kiếm";
			this.btnTimKiem.UseVisualStyleBackColor = false;
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnThoat.Location = new System.Drawing.Point(632, 415);
			this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(96, 39);
			this.btnThoat.TabIndex = 8;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = false;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// txtMaLop
			// 
			this.txtMaLop.Location = new System.Drawing.Point(120, 130);
			this.txtMaLop.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txtMaLop.Name = "txtMaLop";
			this.txtMaLop.Size = new System.Drawing.Size(198, 23);
			this.txtMaLop.TabIndex = 9;
			this.txtMaLop.TextChanged += new System.EventHandler(this.txtMaLop_TextChanged);
			// 
			// txtGhiChu
			// 
			this.txtGhiChu.Location = new System.Drawing.Point(120, 237);
			this.txtGhiChu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txtGhiChu.Name = "txtGhiChu";
			this.txtGhiChu.Size = new System.Drawing.Size(198, 23);
			this.txtGhiChu.TabIndex = 10;
			this.txtGhiChu.TextChanged += new System.EventHandler(this.txtGhiChu_TextChanged);
			// 
			// txtTenLop
			// 
			this.txtTenLop.Location = new System.Drawing.Point(120, 182);
			this.txtTenLop.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txtTenLop.Name = "txtTenLop";
			this.txtTenLop.Size = new System.Drawing.Size(198, 23);
			this.txtTenLop.TabIndex = 11;
			this.txtTenLop.TextChanged += new System.EventHandler(this.txtTenLop_TextChanged);
			// 
			// lvQLLH
			// 
			this.lvQLLH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.lvQLLH.HideSelection = false;
			this.lvQLLH.Location = new System.Drawing.Point(342, 130);
			this.lvQLLH.Name = "lvQLLH";
			this.lvQLLH.Size = new System.Drawing.Size(386, 273);
			this.lvQLLH.TabIndex = 12;
			this.lvQLLH.UseCompatibleStateImageBehavior = false;
			this.lvQLLH.View = System.Windows.Forms.View.Details;
			this.lvQLLH.SelectedIndexChanged += new System.EventHandler(this.lvQLLH_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Mã lớp học";
			this.columnHeader1.Width = 119;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Tên lớp";
			this.columnHeader2.Width = 116;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Ghi chú";
			this.columnHeader3.Width = 145;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleTurquoise;
			this.ClientSize = new System.Drawing.Size(760, 467);
			this.Controls.Add(this.lvQLLH);
			this.Controls.Add(this.txtTenLop);
			this.Controls.Add(this.txtGhiChu);
			this.Controls.Add(this.txtMaLop);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnTimKiem);
			this.Controls.Add(this.btnChinhSua);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.lblGhiChu);
			this.Controls.Add(this.lblTenLop);
			this.Controls.Add(this.lblMaLop);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.ListView lvQLLH;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

