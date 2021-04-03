using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLK
{
    class HocVien
    {
        private string maLopKhoa;
        private string siSo;

        public HocVien()
        {
            this.maLopKhoa = null;
            this.siSo = null;
        }
        public HocVien(string malopkhoa, string siso)
        {
            this.maLopKhoa = malopkhoa;
            this.siSo = siso;
        }
        public string MaLopKhoa
        {
            get { return this.maLopKhoa; }
            set { this.maLopKhoa = value; }
        }
        public string SiSo
        {
            get { return this.siSo; }
            set { this.siSo = value; }
        }
    }
}
