using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrungTamNgoaiNgu.DoiTuong
{
    [Serializable()]
    class LopKhoaDT
    {
        private string maLopKhoa;
        private int siSo;
        private LopDT lop;
        private KhoaDT khoa;

        public string MaLopKhoa { get => maLopKhoa; set => maLopKhoa = value; }
        public int SiSo { get => siSo; set => siSo = value; }
        internal LopDT Lop { get => lop; set => lop = value; }
        internal KhoaDT Khoa { get => khoa; set => khoa = value; }

        public LopKhoaDT(string malopkhoa, int siSo, LopDT lop, KhoaDT khoa)
        {
            this.MaLopKhoa = malopkhoa;
            this.SiSo = siSo;
            this.Lop = lop;
            this.Khoa = khoa;
        }

        public LopKhoaDT()
        {
            this.MaLopKhoa = "";
            this.SiSo = 0;
            this.Lop = new LopDT();
            this.Khoa = new KhoaDT();
        }
    }
}
