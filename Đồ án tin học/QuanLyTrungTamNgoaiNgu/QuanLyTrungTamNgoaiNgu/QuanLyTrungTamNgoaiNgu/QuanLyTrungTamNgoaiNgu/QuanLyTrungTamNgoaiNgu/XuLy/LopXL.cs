using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTrungTamNgoaiNgu.DoiTuong;

namespace QuanLyTrungTamNgoaiNgu.XuLy
{
    class LopXL
    {
        private static List<LopDT> danhSachLop;
        private static TruyCapDuLieu duLieu;
        public LopXL()
        {
            duLieu = TruyCapDuLieu.khoiTao();
            danhSachLop = duLieu.layDanhSachLop();
        }

        public List<LopDT> layDanhSachLop()
        {
            return danhSachLop;
        }

        public LopDT TimKiem(string maLop)
        {
            foreach(LopDT lop in danhSachLop)
            {
                if (lop.MaLop.Equals(maLop)) return lop;
            }
            return null;
        }

        public void Them(LopDT lopHoc)
        {
            danhSachLop.Add(lopHoc);
        }

        public void Sua(LopDT lopHoc)
        {
            LopDT lop = TimKiem(lopHoc.MaLop);
            if (lop != null)
            {
                lop.TenLop = lopHoc.TenLop;
                lop.GhiChu = lopHoc.GhiChu;
            }
        }

        public void Xoa(string maLop)
        {
            LopDT lop = TimKiem(maLop);
            if (lop != null)
            {
                danhSachLop.Remove(lop);
            }
        }

        public bool Luu()
        {
            return TruyCapDuLieu.ghiFile("dulieu.dat");
        }
    }
}
