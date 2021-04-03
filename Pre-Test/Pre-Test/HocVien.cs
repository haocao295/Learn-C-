using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre_Test
{
	class HocVien
	{
		private string maso;
		private string hoten;
		private DateTime ngaysinh;
		private string gioitinh;
		private float dvan;
		private float dtoan;

		public HocVien ()
		{
			this.maso = null;
			this.hoten = null;
			this.ngaysinh = DateTime.Now;
			this.dvan = 0;
			this.dtoan = 0;
			this.gioitinh = null;
			
		}
		public HocVien(string maso, string hoten, DateTime ngaysinh, string gioitinh, float dtoan, float dvan)
		{
			this.maso = maso;
			this.hoten = hoten;
			this.ngaysinh = ngaysinh;
			this.gioitinh = gioitinh;
			this.dvan = dvan;
			this.dtoan = dtoan;
		
		}
		public string HoTen
		{
			get { return this.hoten; }
			set { this.hoten = value; }
		}
		public string MaSo
		{
			get { return this.maso; }
			set { this.maso = value; }
		}
		public DateTime NgaySinh
		{
			get { return this.ngaysinh; }
			set { this.ngaysinh = value; }
		}
		public string GioiTinh
		{
			get { return this.gioitinh; }
			set { this.gioitinh = value; }
		}
		public float DiemToan
		{
			get { return this.dtoan; }
			set { this.dtoan = value; }
		}
		public float DiemVan
		{
			get { return this.dvan; }
			set { this.dvan = value; }
		}
		public float DTB ()
		{
			return ((this.dtoan + this.dvan) / 2);
		}
	}
}
