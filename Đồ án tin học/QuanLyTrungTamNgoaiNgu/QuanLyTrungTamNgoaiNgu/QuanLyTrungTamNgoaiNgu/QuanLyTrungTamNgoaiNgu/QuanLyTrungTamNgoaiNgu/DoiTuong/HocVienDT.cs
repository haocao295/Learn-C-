using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrungTamNgoaiNgu.DoiTuong
{
    [Serializable()]
    class HocVienDT
    {
        private string maHV;
        private string hoTenHV;
        private DateTime ngaySinh;
        private bool gioiTinh;
        private string diaChi;
        private string sdt;
        private string email;
        public string MaHV
        {
            get { return this.maHV; }
            set { this.maHV = value; }
        }
        public string HoTen
        {
            get { return this.hoTenHV; }
            set { this.hoTenHV = value; }
        }
        public DateTime NgaySinh
        {
            get { return this.ngaySinh; }
            set { this.ngaySinh = value; }
        }
        public bool GioiTinh
        {
            get { return this.gioiTinh; }
            set { this.gioiTinh = value; }
        }
        public string DiaChi
        {
            get { return this.diaChi; }
            set { this.diaChi = value; }
        }
        public string SDT
        {
            get { return this.sdt; }
            set { this.sdt = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public HocVienDT()
        {
            this.maHV = null;
            this.hoTenHV = null;
            this.gioiTinh = true;
            this.ngaySinh = DateTime.Now;
            this.diaChi = null;
            this.sdt = null;
            this.email = null;
        }
        public HocVienDT(string maHV, string hoTenHV, DateTime ngaySinh, bool gioiTinh, string diaChi, string sdt, string email)
        {
            this.maHV = maHV;
            this.hoTenHV = hoTenHV;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.sdt = sdt;
            this.email = email;
        }
    }
}
