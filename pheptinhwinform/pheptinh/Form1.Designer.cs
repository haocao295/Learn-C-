namespace pheptinh
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
            this.lbsothunhat = new System.Windows.Forms.Label();
            this.lblsothuhai = new System.Windows.Forms.Label();
            this.lblketqua = new System.Windows.Forms.Label();
            this.txtsothunhat = new System.Windows.Forms.TextBox();
            this.txtsothuhai = new System.Windows.Forms.TextBox();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.btncong = new System.Windows.Forms.Button();
            this.btntru = new System.Windows.Forms.Button();
            this.btnnhan = new System.Windows.Forms.Button();
            this.btnchia = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phep tinh 2 so \r\n";
            // 
            // lbsothunhat
            // 
            this.lbsothunhat.AutoSize = true;
            this.lbsothunhat.Location = new System.Drawing.Point(67, 118);
            this.lbsothunhat.Name = "lbsothunhat";
            this.lbsothunhat.Size = new System.Drawing.Size(60, 13);
            this.lbsothunhat.TabIndex = 1;
            this.lbsothunhat.Text = "so thu nhat";
            // 
            // lblsothuhai
            // 
            this.lblsothuhai.AutoSize = true;
            this.lblsothuhai.Location = new System.Drawing.Point(67, 162);
            this.lblsothuhai.Name = "lblsothuhai";
            this.lblsothuhai.Size = new System.Drawing.Size(53, 13);
            this.lblsothuhai.TabIndex = 2;
            this.lblsothuhai.Text = "so thu hai";
            // 
            // lblketqua
            // 
            this.lblketqua.AutoSize = true;
            this.lblketqua.Location = new System.Drawing.Point(67, 216);
            this.lblketqua.Name = "lblketqua";
            this.lblketqua.Size = new System.Drawing.Size(0, 13);
            this.lblketqua.TabIndex = 3;
            // 
            // txtsothunhat
            // 
            this.txtsothunhat.Location = new System.Drawing.Point(135, 110);
            this.txtsothunhat.Name = "txtsothunhat";
            this.txtsothunhat.Size = new System.Drawing.Size(290, 20);
            this.txtsothunhat.TabIndex = 4;
            // 
            // txtsothuhai
            // 
            this.txtsothuhai.Location = new System.Drawing.Point(135, 155);
            this.txtsothuhai.Name = "txtsothuhai";
            this.txtsothuhai.Size = new System.Drawing.Size(289, 20);
            this.txtsothuhai.TabIndex = 5;
            // 
            // txtketqua
            // 
            this.txtketqua.Location = new System.Drawing.Point(135, 208);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(289, 20);
            this.txtketqua.TabIndex = 6;
            // 
            // btncong
            // 
            this.btncong.Location = new System.Drawing.Point(79, 267);
            this.btncong.Name = "btncong";
            this.btncong.Size = new System.Drawing.Size(56, 46);
            this.btncong.TabIndex = 7;
            this.btncong.Text = "+";
            this.btncong.UseVisualStyleBackColor = true;
            this.btncong.Click += new System.EventHandler(this.btncong_Click);
            // 
            // btntru
            // 
            this.btntru.Location = new System.Drawing.Point(160, 267);
            this.btntru.Name = "btntru";
            this.btntru.Size = new System.Drawing.Size(56, 46);
            this.btntru.TabIndex = 8;
            this.btntru.Text = "-";
            this.btntru.UseVisualStyleBackColor = true;
            this.btntru.Click += new System.EventHandler(this.btntru_Click);
            // 
            // btnnhan
            // 
            this.btnnhan.Location = new System.Drawing.Point(243, 267);
            this.btnnhan.Name = "btnnhan";
            this.btnnhan.Size = new System.Drawing.Size(56, 46);
            this.btnnhan.TabIndex = 9;
            this.btnnhan.Text = "*";
            this.btnnhan.UseVisualStyleBackColor = true;
            this.btnnhan.Click += new System.EventHandler(this.btnnhan_Click);
            // 
            // btnchia
            // 
            this.btnchia.Location = new System.Drawing.Point(334, 267);
            this.btnchia.Name = "btnchia";
            this.btnchia.Size = new System.Drawing.Size(56, 46);
            this.btnchia.TabIndex = 10;
            this.btnchia.Text = "/";
            this.btnchia.UseVisualStyleBackColor = true;
            this.btnchia.Click += new System.EventHandler(this.btnchia_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(368, 339);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(56, 46);
            this.btnthoat.TabIndex = 11;
            this.btnthoat.Text = "thoat";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnchia);
            this.Controls.Add(this.btnnhan);
            this.Controls.Add(this.btntru);
            this.Controls.Add(this.btncong);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.txtsothuhai);
            this.Controls.Add(this.txtsothunhat);
            this.Controls.Add(this.lblketqua);
            this.Controls.Add(this.lblsothuhai);
            this.Controls.Add(this.lbsothunhat);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbsothunhat;
        private System.Windows.Forms.Label lblsothuhai;
        private System.Windows.Forms.Label lblketqua;
        private System.Windows.Forms.TextBox txtsothunhat;
        private System.Windows.Forms.TextBox txtsothuhai;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.Button btncong;
        private System.Windows.Forms.Button btntru;
        private System.Windows.Forms.Button btnnhan;
        private System.Windows.Forms.Button btnchia;
        private System.Windows.Forms.Button btnthoat;
    }
}

