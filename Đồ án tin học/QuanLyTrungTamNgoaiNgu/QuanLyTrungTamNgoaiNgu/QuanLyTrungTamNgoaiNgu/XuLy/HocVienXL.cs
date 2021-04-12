using QuanLyTrungTamNgoaiNgu.DoiTuong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTrungTamNgoaiNgu.XuLy
{
    class HocVienXL
    {
        private List<HocVienDT> dsHocVien;
        private static TruyCapDuLieu dulieu;
        public HocVienXL()
        {
            dulieu = TruyCapDuLieu.khoiTao();
            dsHocVien = dulieu.layDanhSachHocVien();
        }
        public List<HocVienDT> layDanhSachHocVien()
        {
            return dsHocVien;
        }
        public HocVienDT tim(string maHV)
        {
            foreach (HocVienDT a in dsHocVien)
            {
                if (a.MaHV.Equals(maHV))
                    return a;
            }
            return null;
        }
        public bool timHocVienTheoMa(string maHV, ref HocVienDT hocvien)
        {
            for (int i = 0; i < dsHocVien.Count; i++)
            {
                if (dsHocVien[i].MaHV.Equals(maHV))
                {
                    hocvien = dsHocVien[i];
                    return true;
                }
            }
            return false;
        }
        public void them(HocVienDT hocvien)
        {
            dsHocVien.Add(hocvien);
        }
        public void xoa(string maHV)
        {
            HocVienDT a = tim(maHV);
            if (a != null)
            {
                dsHocVien.Remove(a);
            }
        }
        public void sua(HocVienDT hocvien)
        {
            HocVienDT a = tim(hocvien.MaHV);
            if (a != null)
            {
                a.HoTen = hocvien.HoTen;
                a.NgaySinh = hocvien.NgaySinh;
                a.GioiTinh = hocvien.GioiTinh;
                a.DiaChi = hocvien.DiaChi;
                a.SDT = hocvien.SDT;
                a.Email = hocvien.Email;
            }
        }
        public bool Luu()
        {
            return TruyCapDuLieu.ghiFile("dulieu.dat");
        }
    }
}
