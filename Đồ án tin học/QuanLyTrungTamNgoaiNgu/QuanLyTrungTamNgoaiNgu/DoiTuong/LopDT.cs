using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrungTamNgoaiNgu.DoiTuong
{
    [Serializable()]
    class LopDT
    {
        private string maLop;
        private string tenLop;
        private string ghiChu;

        public string MaLop { get => maLop; set => maLop = value; }
        public string TenLop { get => tenLop; set => tenLop = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public LopDT(string malop, string tenlop, string ghichu)
        {
            this.MaLop = malop;
            this.TenLop = tenlop;
            this.GhiChu = ghichu;
        }

        public LopDT()
        {
            this.MaLop = "";
            this.TenLop = "";
            this.GhiChu = "";
        }
    }
}
