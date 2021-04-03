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
        public bool timHocVienTheoMa(string maHV, ref HocVienDT hocVien)
        {
            for (int i = 0; i < dsHocVien.Count; i++)
            {
                if (dsHocVien[i].MaHV.Equals(maHV))
                {
                    hocVien = dsHocVien[i];
                    return true;
                }
            }
            return false;
        }
        public void them(HocVienDT hocVien)
        {
            dsHocVien.Add(hocVien);
        }
        public void xoa(string maHV)
        {
            HocVienDT a = tim(maHV);
            if (a != null)
            {
                dsHocVien.Remove(a);
            }
        }
        public void sua(HocVienDT hocVien)
        {
            HocVienDT a = tim(hocVien.MaHV);
            if (a != null)
            {
                a.HoTen = hocVien.HoTen;
                a.NgaySinh = hocVien.NgaySinh;
                a.GioiTinh = hocVien.GioiTinh;
                a.DiaChi = hocVien.DiaChi;
                a.SDT = hocVien.SDT;
                a.Email = hocVien.Email;
            }
        }
        public bool Luu()
        {
            return TruyCapDuLieu.ghiFile("dulieu.dat");
        }
    }
}
