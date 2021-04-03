namespace QLLK
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
			this.lvQLLK = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnthoat = new System.Windows.Forms.Button();
			this.btnsua = new System.Windows.Forms.Button();
			this.btnxoa = new System.Windows.Forms.Button();
			this.btnthem = new System.Windows.Forms.Button();
			this.txtLK = new System.Windows.Forms.TextBox();
			this.txtMLK = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lvQLLK
			// 
			this.lvQLLK.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.lvQLLK.HideSelection = false;
			this.lvQLLK.Location = new System.Drawing.Point(230, 232);
			this.lvQLLK.Name = "lvQLLK";
			this.lvQLLK.Size = new System.Drawing.Size(278, 178);
			this.lvQLLK.TabIndex = 25;
			this.lvQLLK.UseCompatibleStateImageBehavior = false;
			this.lvQLLK.View = System.Windows.Forms.View.Details;
			this.lvQLLK.SelectedIndexChanged += new System.EventHandler(this.lvQLLH_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Mã Lớp - Khóa";
			this.columnHeader1.Width = 131;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Sỉ Số";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader2.Width = 138;
			// 
			// btnthoat
			// 
			this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnthoat.Location = new System.Drawing.Point(556, 260);
			this.btnthoat.Name = "btnthoat";
			this.btnthoat.Size = new System.Drawing.Size(91, 47);
			this.btnthoat.TabIndex = 24;
			this.btnthoat.Text = "Thoát";
			this.btnthoat.UseVisualStyleBackColor = true;
			this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
			// 
			// btnsua
			// 
			this.btnsua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsua.Location = new System.Drawing.Point(556, 207);
			this.btnsua.Name = "btnsua";
			this.btnsua.Size = new System.Drawing.Size(91, 40);
			this.btnsua.TabIndex = 23;
			this.btnsua.Text = "Sửa";
			this.btnsua.UseVisualStyleBackColor = true;
			this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
			// 
			// btnxoa
			// 
			this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnxoa.Location = new System.Drawing.Point(556, 146);
			this.btnxoa.Name = "btnxoa";
			this.btnxoa.Size = new System.Drawing.Size(91, 44);
			this.btnxoa.TabIndex = 22;
			this.btnxoa.Text = "Xóa";
			this.btnxoa.UseVisualStyleBackColor = true;
			this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
			// 
			// btnthem
			// 
			this.btnthem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnthem.Location = new System.Drawing.Point(556, 83);
			this.btnthem.Name = "btnthem";
			this.btnthem.Size = new System.Drawing.Size(91, 45);
			this.btnthem.TabIndex = 21;
			this.btnthem.Text = "Thêm";
			this.btnthem.UseVisualStyleBackColor = true;
			this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
			// 
			// txtLK
			// 
			this.txtLK.Location = new System.Drawing.Point(390, 159);
			this.txtLK.Name = "txtLK";
			this.txtLK.Size = new System.Drawing.Size(100, 22);
			this.txtLK.TabIndex = 20;
			// 
			// txtMLK
			// 
			this.txtMLK.Location = new System.Drawing.Point(390, 98);
			this.txtMLK.Name = "txtMLK";
			this.txtMLK.Size = new System.Drawing.Size(100, 22);
			this.txtMLK.TabIndex = 19;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(207, 194);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(0, 27);
			this.label4.TabIndex = 18;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(207, 155);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 27);
			this.label3.TabIndex = 17;
			this.label3.Text = "Sỉ Số";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(207, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(162, 27);
			this.label2.TabIndex = 16;
			this.label2.Text = "Mã Lớp - Khóa";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(274, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(283, 33);
			this.label1.TabIndex = 15;
			this.label1.Text = "QUẢN LÍ LỚP - KHÓA";
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
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(10, 28);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 17);
			this.label5.TabIndex = 27;
			this.label5.Text = "Mã: ";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(59, 25);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(150, 22);
			this.textBox1.TabIndex = 28;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Location = new System.Drawing.Point(693, 129);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(219, 151);
			this.groupBox1.TabIndex = 29;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tìm kiếm";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(917, 465);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lvQLLK);
			this.Controls.Add(this.btnthoat);
			this.Controls.Add(this.btnsua);
			this.Controls.Add(this.btnxoa);
			this.Controls.Add(this.btnthem);
			this.Controls.Add(this.txtLK);
			this.Controls.Add(this.txtMLK);
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

        private System.Windows.Forms.ListView lvQLLK;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtLK;
        private System.Windows.Forms.TextBox txtMLK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}

