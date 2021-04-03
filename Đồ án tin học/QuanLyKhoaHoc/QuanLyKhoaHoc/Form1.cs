using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoaHoc
{
    public partial class Form1 : Form
    {
		List<KhoaHoc> dsKhoaHoc = new List<KhoaHoc>();
		public Form1()
        {
            InitializeComponent();
        }

        private void txtMaKhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenKhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNgayKG_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNgayKT_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

			string maKhoaHoc = txtMaKhoa.Text;
			string tenKhoaHoc = txtTenKhoa.Text;
			DateTime ngayKhaiGiang = dtpNgayKG.Value;
			DateTime ngayKetThuc = dtpNgayKT.Value;
	
			KhoaHoc khoaHoc = new KhoaHoc(maKhoaHoc, tenKhoaHoc, ngayKhaiGiang, ngayKetThuc);
			dsKhoaHoc.Add(khoaHoc);
			//hienthi 
			hienThiDSKH(lvQLKH);
		}

        private void btnXoa_Click(object sender, EventArgs e)
        {
			foreach (ListViewItem lvi in lvQLKH.SelectedItems)
			{
				string MaKH = lvi.SubItems[0].Text;
				KhoaHoc khoaHoc = null;
				foreach (KhoaHoc a in dsKhoaHoc)
				{
					if (a.MaKH == MaKH)
					{
						khoaHoc = a;
						break;
					}
				}
				if (khoaHoc != null)
					dsKhoaHoc.Remove(khoaHoc);
			}
			hienThiDSKH(lvQLKH);

		}

		private void btnChinhSua_Click(object sender, EventArgs e)
        {
			string maKH = txtMaKhoa.Text;
			KhoaHoc khoaHoc = null;
			foreach (KhoaHoc a in dsKhoaHoc)
			{
				if (a.MaKH == maKH)
				{
					khoaHoc = a;
					break;

				}
			}
			if (khoaHoc != null)
			{
				khoaHoc.MaKH = txtMaKhoa.Text;
				khoaHoc.TenKH = txtTenKhoa.Text;
	
				khoaHoc.NgayKG = dtpNgayKG.Value;
				khoaHoc.NgayKT = dtpNgayKT.Value;
			}
			hienThiDSKH(lvQLKH);
		}

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

		public void hienThiDSKH(ListView lv)
		{
			lv.Items.Clear();
			for (int i = 0; i < dsKhoaHoc.Count; i++)
			{
				KhoaHoc khoaHoc = new KhoaHoc();
				khoaHoc = dsKhoaHoc[i];
				ListViewItem lvi = new ListViewItem(khoaHoc.MaKH);
				lvi.SubItems.Add(khoaHoc.MaKH);
				lvi.SubItems.Add(khoaHoc.TenKH);
				lvi.SubItems.Add(khoaHoc.NgayKG.ToString());
				lvi.SubItems.Add(khoaHoc.NgayKT.ToString());
			

				lv.Items.Add(lvi);

			}
		}
		private void lvQLKH_SelectedIndexChanged(object sender, EventArgs e)
        {
			foreach (ListViewItem lvi in lvQLKH.SelectedItems)
			{
				string maKH = lvi.SubItems[0].Text;
				KhoaHoc khoaHoc = null;
				foreach (KhoaHoc a in dsKhoaHoc)
				{
					if (a.MaKH == maKH)
					{
						khoaHoc = a;
						break;

					}
				}
				if (khoaHoc != null)
				{
					txtMaKhoa.Text = khoaHoc.MaKH ;
					txtTenKhoa.Text = khoaHoc.TenKH;
					dtpNgayKG.Value = khoaHoc.NgayKG;
					dtpNgayKT.Value = khoaHoc.NgayKT ;
			
					
				
				}
			}
		}

        private void btnThoat_Click(object sender, EventArgs e)
        {
			DialogResult result = MessageBox.Show("Ban co muon thoat khong", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
				this.Close();
		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
