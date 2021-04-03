using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQLTruongHoc
{
    class Nguoi
    {
        public string SoCMND { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }

        public Nguoi()
        {
            this.SoCMND = null;
            this.HoTen = null;
            this.NgaySinh = System.DateTime.Now;
            this.GioiTinh = null;
            this.DiaChi = null;
        }

        public Nguoi(string SoCMND,string HoTen,DateTime NgaySinh,string GioiTinh,string DiaChi)
        {
            this.SoCMND = SoCMND;
            this.HoTen = HoTen;
            this.NgaySinh = NgaySinh;
            this.GioiTinh = GioiTinh;
            this.DiaChi = DiaChi;
        }

    }
}
