using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPDK
{
    class HocVien
    {
        private string maPhieu;
        private DateTime ngayLap;
        private string soTien;

        public HocVien()
        {
            this.maPhieu = null;
            this.ngayLap = DateTime.Now;
            this.soTien = null;
        }
        public HocVien(string maphieu, DateTime ngaylap, string sotien)
        {
            this.maPhieu = maphieu;
            this.ngayLap = ngaylap;
            this.soTien = sotien;
        }
        public string MaPhieu
        {
            get { return this.maPhieu; }
            set { this.maPhieu = value; }
        }
        public DateTime NgayLap
        {
            get { return this.ngayLap; }
            set { this.ngayLap = value; }
        }
        public string SoTien
        {
            get { return this.soTien; }
            set { this.soTien = value; }
        }
    }
}
