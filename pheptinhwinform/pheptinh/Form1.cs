using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pheptinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncong_Click(object sender, EventArgs e)
        {
            float sothunhat = float.Parse(txtsothunhat.Text);
            float sothuhai = float.Parse(txtsothuhai.Text);

            float tong = sothunhat + sothuhai;
            lblketqua.Text = "tong: ";
            txtketqua.Text = tong.ToString();
        }

        private void btntru_Click(object sender, EventArgs e)
        {
            float sothunhat = float.Parse(txtsothunhat.Text);
            float sothuhai = float.Parse(txtsothuhai.Text);
            float hieu = sothunhat - sothuhai;
            lblketqua.Text = " hieu: ";
            txtketqua.Text = hieu.ToString();
        }

        private void btnnhan_Click(object sender, EventArgs e)
        {
            float sothunhat = float.Parse(txtsothunhat.Text);
            float sothuhai = float.Parse(txtsothuhai.Text);
            float tich = sothunhat * sothuhai;
            lblketqua.Text = "tich: ";
            txtketqua.Text = tich.ToString();

        }

        private void btnchia_Click(object sender, EventArgs e)
        {
            float sothunhat = float.Parse(txtsothunhat.Text);
            float sothuhai = float.Parse(txtsothuhai.Text);
            float thuong = sothunhat / sothuhai;
            if(sothuhai==0)
            {
                lblketqua.Text = "thuong: ";
                txtketqua.Text = "error! :( ";
               
            }
            else
            {
                lblketqua.Text = "thuong: ";
                txtketqua.Text = thuong.ToString();

            }
           
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are u sure", "Notifications", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result==DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
