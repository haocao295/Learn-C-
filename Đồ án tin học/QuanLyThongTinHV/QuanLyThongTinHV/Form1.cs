using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThongTinHV
{
    public partial class Form1 : Form
    {     
		List<HocVien> dsHocVien = new List<HocVien>();
        public Form1()
        {
            InitializeComponent();
        }

        private void txtMaHocVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenHocVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbGioiTinh_Enter(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
			string maHocVien = txtMaHocVien.Text;
			string hoTenHocVien = txtTenHocVien.Text;
			DateTime ngaySinh = dtpNgaySinh.Value;
			string gioiTinh = null;
			if(rboNam.Checked == true)
				{
					gioiTinh = "Nam";
				}
			else if(rboNu.Checked == true)
			{
				gioiTinh = "Nữ";
			}
			string soDienthoai = textBox6.Text;
			string Email = textBox7.Text;
			string diaChi = textBox5.Text;
			HocVien hocVien = new HocVien ( maHocVien, hoTenHocVien, ngaySinh, gioiTinh, soDienthoai, Email, diaChi );
				dsHocVien.Add(hocVien);
			//hienthi 
			hienThiDSHV(lvThongTinHocVien);
			
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
			foreach(ListViewItem lvi in lvThongTinHocVien.SelectedItems)
			{
				string MaHV = lvi.SubItems[0].Text;
				HocVien hocVien = null;
				foreach (HocVien a in dsHocVien)
				{
					if(a.MaHV == MaHV)
					{
						hocVien = a;
						break;
					}
				}
				if (hocVien != null)
					dsHocVien.Remove(hocVien);
			}
			hienThiDSHV(lvThongTinHocVien);

		}

		public void hienThiDSHV(ListView lv)
		{
			lv.Items.Clear();
			for(int i=0; i < dsHocVien.Count; i++)
			{
				HocVien hocVien = new HocVien();
				hocVien = dsHocVien[i];
				ListViewItem lvi = new ListViewItem(hocVien.MaHV);
				lvi.SubItems.Add(hocVien.HoTen);
				lvi.SubItems.Add(hocVien.NgaySinh.ToString());
				lvi.SubItems.Add(hocVien.GioiTinh);
				lvi.SubItems.Add(hocVien.DiaChi);
				lvi.SubItems.Add(hocVien.EMAIL);
				lvi.SubItems.Add(hocVien.SDT);

				lv.Items.Add(lvi);

			}
		}
        private void btnChinhSua_Click(object sender, EventArgs e)
        {
			string maHV = txtMaHocVien.Text;
			HocVien hocVien = null;
			foreach(HocVien a in dsHocVien)
			{
				if(a.MaHV == maHV)
				{
					hocVien = a;
					break;

				}
			}
			if(hocVien != null)
			{
				hocVien.HoTen = txtTenHocVien.Text;
				hocVien.NgaySinh = dtpNgaySinh.Value;
				if (rboNam.Checked == true)
					hocVien.GioiTinh = "Nam";
				else if (rboNu.Checked == true)
					hocVien.GioiTinh = "Nu";
				//hocVien.GioiTinh = rboNam.Checked;
				hocVien.DiaChi = textBox5.Text;
				hocVien.MaHV = txtMaHocVien.Text;
				hocVien.SDT = textBox6.Text;
				hocVien.EMAIL = textBox7.Text;
			}
			hienThiDSHV(lvThongTinHocVien);
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

		private void lvThongTinHocVien_SelectedIndexChanged(object sender, EventArgs e)
		{
			foreach(ListViewItem lvi in lvThongTinHocVien.SelectedItems )
			{
				string maHV = lvi.SubItems[0].Text;
				HocVien hocVien = null;
				foreach (HocVien a in dsHocVien)
				{
					if(a.MaHV == maHV)
					{
						hocVien = a;
						break;
					}
				}
				if(hocVien != null)
				{
					txtMaHocVien.Text = hocVien.MaHV;
					txtTenHocVien.Text = hocVien.HoTen;
					dtpNgaySinh.Value = hocVien.NgaySinh;
					textBox6.Text = hocVien.SDT;
					textBox7.Text = hocVien.EMAIL;
					textBox5.Text = hocVien.DiaChi;
					if (hocVien.GioiTinh.Equals("Nam")) rboNam.Checked = true;
					else rboNu.Checked = true;
				}
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
