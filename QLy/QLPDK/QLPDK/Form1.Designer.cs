namespace QLPDK
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
			this.txtMP = new System.Windows.Forms.TextBox();
			this.txtST = new System.Windows.Forms.TextBox();
			this.btnthoat = new System.Windows.Forms.Button();
			this.btnsua = new System.Windows.Forms.Button();
			this.btnxoa = new System.Windows.Forms.Button();
			this.btnthem = new System.Windows.Forms.Button();
			this.lvQLPDK = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.txtNL = new System.Windows.Forms.DateTimePicker();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(231, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(214, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "PHIẾU ĐĂNG KÍ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(87, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 27);
			this.label2.TabIndex = 1;
			this.label2.Text = "Mã Phiếu";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(85, 141);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(107, 27);
			this.label3.TabIndex = 2;
			this.label3.Text = "Ngày Lập";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(87, 192);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 27);
			this.label4.TabIndex = 3;
			this.label4.Text = "Số Tiền";
			// 
			// txtMP
			// 
			this.txtMP.Location = new System.Drawing.Point(270, 96);
			this.txtMP.Name = "txtMP";
			this.txtMP.Size = new System.Drawing.Size(100, 22);
			this.txtMP.TabIndex = 4;
			// 
			// txtST
			// 
			this.txtST.Location = new System.Drawing.Point(270, 196);
			this.txtST.Name = "txtST";
			this.txtST.Size = new System.Drawing.Size(100, 22);
			this.txtST.TabIndex = 5;
			// 
			// btnthoat
			// 
			this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnthoat.Location = new System.Drawing.Point(501, 210);
			this.btnthoat.Name = "btnthoat";
			this.btnthoat.Size = new System.Drawing.Size(91, 47);
			this.btnthoat.TabIndex = 12;
			this.btnthoat.Text = "Thoát";
			this.btnthoat.UseVisualStyleBackColor = true;
			this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
			// 
			// btnsua
			// 
			this.btnsua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsua.Location = new System.Drawing.Point(501, 153);
			this.btnsua.Name = "btnsua";
			this.btnsua.Size = new System.Drawing.Size(91, 40);
			this.btnsua.TabIndex = 11;
			this.btnsua.Text = "Sửa";
			this.btnsua.UseVisualStyleBackColor = true;
			this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
			// 
			// btnxoa
			// 
			this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnxoa.Location = new System.Drawing.Point(501, 96);
			this.btnxoa.Name = "btnxoa";
			this.btnxoa.Size = new System.Drawing.Size(91, 44);
			this.btnxoa.TabIndex = 10;
			this.btnxoa.Text = "Xóa";
			this.btnxoa.UseVisualStyleBackColor = true;
			this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
			// 
			// btnthem
			// 
			this.btnthem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnthem.Location = new System.Drawing.Point(501, 33);
			this.btnthem.Name = "btnthem";
			this.btnthem.Size = new System.Drawing.Size(91, 45);
			this.btnthem.TabIndex = 9;
			this.btnthem.Text = "Thêm";
			this.btnthem.UseVisualStyleBackColor = true;
			this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
			// 
			// lvQLPDK
			// 
			this.lvQLPDK.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.lvQLPDK.HideSelection = false;
			this.lvQLPDK.Location = new System.Drawing.Point(119, 272);
			this.lvQLPDK.Name = "lvQLPDK";
			this.lvQLPDK.Size = new System.Drawing.Size(372, 163);
			this.lvQLPDK.TabIndex = 13;
			this.lvQLPDK.UseCompatibleStateImageBehavior = false;
			this.lvQLPDK.View = System.Windows.Forms.View.Details;
			this.lvQLPDK.SelectedIndexChanged += new System.EventHandler(this.lvQLPDK_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Mã Phiếu";
			this.columnHeader1.Width = 107;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Ngày Lập";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader2.Width = 130;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Số Tiền";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader3.Width = 129;
			// 
			// txtNL
			// 
			this.txtNL.Location = new System.Drawing.Point(237, 143);
			this.txtNL.Name = "txtNL";
			this.txtNL.Size = new System.Drawing.Size(200, 22);
			this.txtNL.TabIndex = 14;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Location = new System.Drawing.Point(556, 272);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(219, 151);
			this.groupBox1.TabIndex = 30;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tìm kiếm";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(59, 25);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(150, 22);
			this.textBox1.TabIndex = 28;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(10, 28);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 17);
			this.label5.TabIndex = 27;
			this.label5.Text = "Mã: ";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(47, 75);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(121, 43);
			this.button1.TabIndex = 26;
			this.button1.Text = "Tìm";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(822, 462);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtNL);
			this.Controls.Add(this.lvQLPDK);
			this.Controls.Add(this.btnthoat);
			this.Controls.Add(this.btnsua);
			this.Controls.Add(this.btnxoa);
			this.Controls.Add(this.btnthem);
			this.Controls.Add(this.txtST);
			this.Controls.Add(this.txtMP);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMP;
        private System.Windows.Forms.TextBox txtST;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.ListView lvQLPDK;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DateTimePicker txtNL;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button1;
	}
}

