using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrungTamNgoaiNgu.DoiTuong
{
    [Serializable()]
    class KhoaDT
    {
        private string maKhoa;
        private string tenKhoa;
        private DateTime ngayBatDau;
        private DateTime ngayKetThuc;

        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
        public string TenKhoa { get => tenKhoa; set => tenKhoa = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }

        public KhoaDT(string makhoa, string tenkhoa, DateTime ngaybatdau, DateTime ngayketthuc)
        {
            this.MaKhoa = makhoa;
            this.TenKhoa = tenkhoa;
            this.NgayBatDau = ngaybatdau;
            this.NgayKetThuc = ngayketthuc;
        }

        public KhoaDT()
        {
            this.MaKhoa = "";
            this.TenKhoa = "";
            this.NgayBatDau = DateTime.Now;
            this.NgayKetThuc = DateTime.Now;
        }
    }
}
