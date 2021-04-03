using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLopHoc 
{
    class LopHoc
    {
        private string maLopHoc;
        private string tenLop;
        private string ghiChu;

        public LopHoc()
        {
            this.maLopHoc = null;
            this.tenLop = null;
            this.ghiChu = null;
        }
        public LopHoc(string MaLopHoc, string TenLop,string chuthich)
        {
            this.maLopHoc = MaLopHoc;
            this.tenLop = TenLop;
            this.ghiChu = chuthich;
        }
        public string MALH
        {
            get { return this.maLopHoc; }
            set { this.maLopHoc = value; }
        }
        public string TenLH
        {
            get { return this.tenLop; }
            set { this.tenLop = value; }
        }
        public string GHICHU
        {
            get { return this.ghiChu; }
            set { this.ghiChu = value; }
        }
    }

}
