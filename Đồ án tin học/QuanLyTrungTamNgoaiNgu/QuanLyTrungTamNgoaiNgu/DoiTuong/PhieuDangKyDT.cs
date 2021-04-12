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
        private HocVienDT hocVien;
        private LopKhoaDT khoalop;

        public PhieuDangKyDT()
        {
            this.maPDK = null;
            this.ngayLapPhieu = DateTime.Now;
            this.soTien = 0;
			this.hocVien = new HocVienDT();
            this.khoalop = new LopKhoaDT();
        }
        public PhieuDangKyDT(string mapdk, DateTime ngaylapphieu, double sotien, HocVienDT hocvien, LopKhoaDT khoalop)
        {
            this.maPDK = mapdk;
            this.ngayLapPhieu = ngaylapphieu;
            this.soTien = sotien;
            this.hocVien = hocvien;
            this.khoalop = khoalop;
        }
        public string MaPDK { get => maPDK; set => maPDK = value; }
        public DateTime NgayLapPhieu { get => ngayLapPhieu; set => ngayLapPhieu = value; }    
        public double SoTien { get => soTien; set => soTien = value; }        
        public HocVienDT HocVien { get => hocVien; set => hocVien = value; }
		public LopKhoaDT khoaLop { get => khoalop; set => khoalop = value; }
     
    }
}
