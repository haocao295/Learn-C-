using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrungTamNgoaiNgu.DoiTuong
{
    [Serializable()]
    class PhieuDangKyDT
    {
        private string maPDK;
        private DateTime ngayLapPhieu;
        private double soTien;
        private HocVienDT hocvien;
        private LopKhoaDT khoalop;

        public PhieuDangKyDT()
        {
            this.maPDK = null;
            this.ngayLapPhieu = DateTime.Now;
            this.soTien = 0;
            this.hocvien = new HocVienDT();
            this.khoalop = new LopKhoaDT();
        }
        public PhieuDangKyDT(string maPDK, DateTime ngayLapPhieu, double soTien, HocVienDT hocvien, LopKhoaDT khoalop)
        {
            this.maPDK = maPDK;
            this.ngayLapPhieu = ngayLapPhieu;
            this.soTien = soTien;
            this.hocvien = hocvien;
            this.khoalop = khoalop;
        }
        public string MaPDK
        {
            get { return this.maPDK; }
            set { this.maPDK = value; }
        }
        public DateTime NgayLapPhieu
        {
            get { return this.ngayLapPhieu; }
            set { this.ngayLapPhieu = value; }
        }
        public double SoTien
        {
            get { return this.soTien; }
            set { this.soTien = value; }
        }
        public HocVienDT hocVien
        {
            get { return this.hocvien; }
            set { this.hocvien = value; }
        }
        public LopKhoaDT khoaLop
        {
            get { return this.khoalop; }
            set { this.khoalop = value; }
        }
    }
}
