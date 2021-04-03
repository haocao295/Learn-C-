using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQLTruongHoc
{
    class GiaoVien:Nguoi
    {
        public DateTime NgayVaoLam { get; set; }
        public string ChuyenMon { get; set; }

        public GiaoVien()
        {
            this.NgayVaoLam = System.DateTime.Now;
            this.ChuyenMon = null;
        }

        public GiaoVien(DateTime NgayVaoLam,string ChuyenMon)
        {
            this.NgayVaoLam = NgayVaoLam;
            this.ChuyenMon = ChuyenMon;
        }

        public GiaoVien(string CMND, string HoTen, DateTime NgaySinh, string GioiTinh, string DiaChi, DateTime NgayVaoLam, string ChuyenMon)
        {
            this.SoCMND = CMND;
            this.HoTen = HoTen;
            this.NgaySinh = NgaySinh;
            this.GioiTinh = GioiTinh;
            this.DiaChi = DiaChi;

            this.NgayVaoLam = NgayVaoLam;
            this.ChuyenMon = ChuyenMon;
        }

        public int tinhThanhNien()
        {
            TimeSpan ngay = DateTime.Today - NgayVaoLam;
            return ngay.Days;
        }
        public int tinhThamNien()
        {
            TimeSpan ngay = DateTime.Today - NgayVaoLam;
            return ngay.Days;
        }
    }
}
