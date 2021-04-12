﻿using QuanLyTrungTamNgoaiNgu.DoiTuong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTrungTamNgoaiNgu.XuLy
{
    class PhieuDangKyXL
    {
        private List<PhieuDangKyDT> dsPhieuDangKy;
		private static List<LopKhoaDT> danhSachLopKhoa;
		private static List<HocVienDT> danhSachHocVien;
		private static TruyCapDuLieu data;


        public PhieuDangKyXL()
        {
            data = TruyCapDuLieu.khoiTao();
            dsPhieuDangKy = data.layDanhSachPhieuDangKy();
        }
		
		public PhieuDangKyDT tim(string maPDK)
        {
            foreach (PhieuDangKyDT a in dsPhieuDangKy)
            {
                if (a.MaPDK.Equals(maPDK))
                    return a;
            }
            return null;
        }
        public bool timTheoMa(string maPDK, ref PhieuDangKyDT pdk)
        {
            for (int i = 0; i < dsPhieuDangKy.Count; i++)
            {
                if (dsPhieuDangKy[i].MaPDK.Equals(maPDK))
                {
                    pdk = dsPhieuDangKy[i];
                    return true;
                }
            }
            return false;
        }
        public void them(PhieuDangKyDT pdk)
        {
            dsPhieuDangKy.Add(pdk);
        }
        public void xoa(string maPDK)
        {
            PhieuDangKyDT a = tim(maPDK);
            if (a != null)
            {
                dsPhieuDangKy.Remove(a);
            }
        }
		public void sua(PhieuDangKyDT pdk)
		{
		
		}

		public List<LopKhoaDT> layDanhSachLopKhoa()
		{
			danhSachLopKhoa = data.layDanhSachLopKhoa();
			return danhSachLopKhoa;
		}
		public List<HocVienDT> layDanhSachHocVien()
		{
			danhSachHocVien=data.layDanhSachHocVien();
			return danhSachHocVien;
		}
		public List<PhieuDangKyDT> layDanhSachPDK()
		{
			return dsPhieuDangKy;
		}
		public bool Luu()
        {
            return TruyCapDuLieu.ghiFile("dulieu.dat");
        }
    }
}
