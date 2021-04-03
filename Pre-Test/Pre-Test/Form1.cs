using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pre_Test
{

	public partial class Form1 : Form
	{
		private List<HocVien> dshocvien = new List<HocVien>();
		private int ViTri = 0;

		public Form1()
		{
			InitializeComponent();

		}

		private void them_Click(object sender, EventArgs e)
		{
			string maso = ms.Text;
			string hoten = ht.Text;
			DateTime ngaysinh = ns.Value;
			string gioitinh = "";
			if (nam.Checked == true)
			{
				gioitinh = "Nam";
			}
			if (nu.Checked == true)
			{
				gioitinh = "Nu";
			}
			float diemtoan = float.Parse(dt.Text);
			float diemvan = float.Parse(dv.Text);
			HocVien hocVien = new HocVien(maso, hoten, ngaysinh, gioitinh, diemtoan, diemvan);
			dshocvien.Add(hocVien);
			hienthidshv(lvHocVien);
		}

		private void xoa_Click(object sender, EventArgs e)
		{
			dshocvien.RemoveAt(ViTri);
			hienthidshv(lvHocVien);
		}


		private void lvHocVien_SelectedIndexChanged(object sender, EventArgs e)
		{
			foreach (int i in lvHocVien.SelectedIndices)
			{
				ViTri = i;
			}
			hienthi1hv(dshocvien[ViTri]);
		}
		private void hienthi1hv(HocVien a)
		{
			ms.Text = a.MaSo;
			ht.Text = a.HoTen;
			ns.Value = a.NgaySinh;
			string gioitinh = a.GioiTinh;
			if (a.GioiTinh.Equals("Nam"))
				nam.Checked = true;
			if (a.GioiTinh.Equals("Nữ"))
				nu.Checked = true;
			dt.Text = a.DiemToan.ToString();
			dv.Text = a.DiemVan.ToString();
			dtb.Text = a.DTB().ToString();
		}

		private void sua_Click(object sender, EventArgs e)
		{
			string maso = ms.Text;
			string hoten = ht.Text;
			DateTime ngaysinh = ns.Value;
			string gioitinh = "";
			if (nam.Checked == true)
			{
				gioitinh = "Nam";
			}
			if (nu.Checked == true)
			{
				gioitinh = "Nu";
			}
			float diemtoan = float.Parse(dt.Text);
			float diemvan = float.Parse(dv.Text);
			HocVien hocVien = new HocVien(maso, hoten, ngaysinh, gioitinh, diemtoan, diemvan);
			dshocvien[ViTri] = hocVien;
			hienthidshv(lvHocVien);
		}
		private void hienthidshv(ListView lv)
		{
			lv.Items.Clear();
			for (int i = 0; i < dshocvien.Count; i++)
			{
				HocVien a = new HocVien();
				a = dshocvien[i];
				ListViewItem lvi = new ListViewItem(a.MaSo);
				lvi.SubItems.Add(a.HoTen);
				lvi.SubItems.Add(a.NgaySinh.ToString());
				lvi.SubItems.Add(a.GioiTinh);
				lvi.SubItems.Add(a.DiemToan.ToString());
				lvi.SubItems.Add(a.DiemVan.ToString());
				lvi.SubItems.Add(a.DTB().ToString());
				lv.Items.Add(lvi);
			}

		}

		private void thoat_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to exit?", "Notification!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
			if (result == DialogResult.Yes)
				Application.Exit();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void ok_Click(object sender, EventArgs e)
		{
			List<HocVien> dshv = new List<HocVien>();
			if(tnm.Checked == true )
			{
				for(int i=0; i<dshocvien.Count; i++)
				{
					if(dshocvien[i].MaSo.Equals(ttm.Text))
					{
						hienthi1hv(dshocvien[i]);
					}
				}
				hienthidshv(lvHocVien);
			}
			else if(tnt.Checked == true)
			{
				for (int i=0; i<dshocvien.Count; i++) 
				{
					if(dshocvien[i].HoTen.Equals(ttt.Text))
					{
						hienthi1hv(dshocvien[i]);
					}
				}
				hienthidshv(lvHocVien);
			}
		}
	}
}
