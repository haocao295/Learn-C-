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

        public KhoaDT(string maKhoa, string tenKhoa, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            this.MaKhoa = maKhoa;
            this.TenKhoa = tenKhoa;
            this.NgayBatDau = ngayBatDau;
            this.NgayKetThuc = ngayKetThuc;
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
