using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapMonThayTung_2Lop
{
    class HocSinh
    {
        private string maSoHS;
        private string hoTenHS;
        private DateTime ngaySinh;
        private bool gioiTinh;
        private string diaChi;

        public HocSinh()
        {
            this.maSoHS = null;
            this.hoTenHS = null;
            this.ngaySinh = DateTime.Now;
            this.gioiTinh = true;
            this.diaChi = null;
        }
        public HocSinh(string mshs, string hotenhs, DateTime ngaysinh, bool phai, string diachi)
        {
            this.maSoHS = mshs;
            this.hoTenHS = hotenhs;
            this.ngaySinh = ngaysinh;
            this.gioiTinh = phai;
            this.diaChi = diachi;
        }
        public string MaHS
        {
            get { return this.maSoHS; }
            set { this.maSoHS = value; }
        }
        public string HoTen
        {
            get { return this.hoTenHS; }
            set { this.hoTenHS = value; }
        }
        public DateTime NgaySinh
        {
            get { return this.ngaySinh; }
            set { this.ngaySinh = value; }
        }
        public bool GT
        {
            get { return this.gioiTinh; }
            set { this.gioiTinh = value; }
        }
        public string DiaChi
        {
            get { return this.diaChi; }
            set { this.diaChi = value; }
        }
    }
}
