using QuanLyTrungTamNgoaiNgu.DoiTuong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTrungTamNgoaiNgu.XuLy
{
    class KhoaXL
    {
        private static List<KhoaDT> danhSachKhoa;
        private static TruyCapDuLieu duLieu;
        public KhoaXL()
        {
            duLieu = TruyCapDuLieu.khoiTao();
            danhSachKhoa = duLieu.layDanhSachKhoa();
        }

        public List<KhoaDT> layDanhSachKhoa()
        {
            return danhSachKhoa;
        }

        public KhoaDT TimKiem(string maKhoa)
        {
            foreach (KhoaDT khoa in danhSachKhoa)
            {
                if (khoa.MaKhoa.Equals(maKhoa)) return khoa;
            }
            return null;
        }

        public void Them(KhoaDT khoaHoc)
        {
            danhSachKhoa.Add(khoaHoc);
        }

        public void Sua(KhoaDT khoaHoc)
        {
            KhoaDT khoa = TimKiem(khoaHoc.MaKhoa);
            if (khoa != null)
            {
                khoa.TenKhoa = khoaHoc.TenKhoa;
                khoa.NgayBatDau = khoaHoc.NgayBatDau;
                khoa.NgayKetThuc = khoaHoc.NgayKetThuc;
            }
        }

        public void Xoa(string maKhoa)
        {
            KhoaDT khoa = TimKiem(maKhoa);
            if (khoa != null)
            {
                danhSachKhoa.Remove(khoa);
            }
        }

        public bool Luu()
        {
            return TruyCapDuLieu.ghiFile("dulieu.dat");
        }
    }
}
