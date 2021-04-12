using QuanLyTrungTamNgoaiNgu.DoiTuong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTrungTamNgoaiNgu.XuLy
{
    class LopKhoaXL
    {
        private static List<LopKhoaDT> danhSachLopKhoa;
        private static List<LopDT> danhSachLop;
        private static List<KhoaDT> danhSachKhoa;
        private static TruyCapDuLieu duLieu;

        public LopKhoaXL()
        {
            duLieu = TruyCapDuLieu.khoiTao();
            danhSachLopKhoa = duLieu.layDanhSachLopKhoa();
        }

        public List<LopKhoaDT> layDanhSachLopKhoa()
        {
            return danhSachLopKhoa;
        }

        public List<LopDT> layDanhSachLop()
        {
            danhSachLop = duLieu.layDanhSachLop();
            return danhSachLop;
        }
        public List<KhoaDT> layDanhSacKhoa()
        {
            danhSachKhoa = duLieu.layDanhSachKhoa();
            return danhSachKhoa;
        }

        public LopKhoaDT TimKiem(string maLopKhoa)
        {
            foreach (LopKhoaDT lopKhoa in danhSachLopKhoa)
            {
                if (lopKhoa.MaLopKhoa.Equals(maLopKhoa)) return lopKhoa;
            }
            return null;
        }

        public void Them(LopKhoaDT lopKhoaHoc)
        {
            danhSachLopKhoa.Add(lopKhoaHoc);
        }

        public void Sua(LopKhoaDT lopKhoaHoc)
        {
            LopKhoaDT lopKhoa = TimKiem(lopKhoaHoc.MaLopKhoa);
            if (lopKhoa != null)
            {
                lopKhoa.SiSo = lopKhoaHoc.SiSo;
            }
        }

        public void Xoa(string maLopKhoa)
        {
            LopKhoaDT lopKhoa = TimKiem(maLopKhoa);
            if (lopKhoa != null)
            {
                danhSachLopKhoa.Remove(lopKhoa);
            }
        }

        public bool Luu()
        {
            return TruyCapDuLieu.ghiFile("dulieu.dat");
        }
    }
}
