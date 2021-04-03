using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLopHoc
{
    public partial class Form1 : Form
    {
		 List<LopHoc> dsLopHoc = new List<LopHoc>();
		public Form1()
        {
            InitializeComponent();
        }

      

        private void txtMaLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
			string maLopHoc = txtMaLop.Text;
			string tenLop = txtTenLop.Text;
			string ghiChu = txtGhiChu.Text;
			LopHoc lopHoc  = new LopHoc(maLopHoc, tenLop,ghiChu);
			dsLopHoc.Add(lopHoc);
			//hienthi 
			hienThiDSLH(lvQLLH);
		}

        private void btnXoa_Click(object sender, EventArgs e)
        {
			foreach (ListViewItem lvi in lvQLLH.SelectedItems)
			{
				string MaLH = lvi.SubItems[0].Text;
				LopHoc  lopHoc = null;
				foreach (LopHoc a in dsLopHoc)
				{
					if (a.MaLH == MaLH)
					{
						lopHoc = a;
						break;
					}
				}
				if (lopHoc != null)
					dsLopHoc.Remove(LopHoc);
			}
			hienThiDSLH(lvQLLH);
		}

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
			string maLH = txtMaLop.Text;
			LopHoc lopHoc = null;
			foreach (LopHoc a in dsLopHoc)
			{
				if (a.MaHV == maLH)
				{
					lopHoc = a;
					break;

				}
			}
			if (lopHoc != null)
			{
				lopHoc.maLopHoc = txtTenLop.Text;
				lopHoc.tenLop = txtTenLop.Text;
				lopHoc.ghiChu = txtGhiChu.Text;
			}
			hienThiDSLH(lvQLLH);
		}

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
			
		}

        private void btnThoat_Click(object sender, EventArgs e)
        {
			DialogResult result = MessageBox.Show("Ban co muon thoat khong", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
				this.Close();
		}
		public void hienthiDSLH(ListView lv)
		{
			lv.Items.Clear();
			for (int i = 0; i < dsLopHoc.Count; i++)
			{
				LopHoc lopHoc = new LopHoc();
				lopHoc = dsLopHoc[i];
				ListViewItem lvi = new ListViewItem(lopHoc.maLopHoc);
				lvi.SubItems.Add(lopHoc.maLopHoc);
				lvi.SubItems.Add(lopHoc.tenLop);
				lvi.SubItems.Add(lopHoc.ghiChu);

				lv.Items.Add(lvi);

			}
		}
		private void lvQLLH_SelectedIndexChanged(object sender, EventArgs e)
        {
			foreach (ListViewItem lvi in lvQLLH.SelectedItems)
			{
				string maLH = lvi.SubItems[0].Text;
				LopHoc lopHoc = null;
				foreach (LopHoc a in dsLopHoc)
				{
					if (a.MaLH == maLH)
					{
						lopHoc = a;
						break;
					}
				}
				if (lopHoc != null)
				{
					txtMaLop.Text = lopHoc.maLopHoc;
					txtTenLop.Text = lopHoc.tenLop;
					txtGhiChu.Text = lopHoc.ghiChu;
				}
			}
		}
    }
}
