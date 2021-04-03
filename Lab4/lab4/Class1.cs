using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class HocVien
    {
        private string maHocVien;
        private string hoTenHocVien;
        private DateTime ngaySinh;
        private string gioiTinh;
        private float diemToan;
        private float diemVan;

        public HocVien()
        {
            this.maHocVien = null;
            this.hoTenHocVien = null;
            this.ngaySinh = DateTime.Now;
            this.diemToan = 0;
            this.diemVan = 0;
        }
        public HocVien(string ma, string hoten, DateTime ngaysinh, string phai, float toan, float van)
        {
            this.maHocVien = ma;
            this.hoTenHocVien = hoten;
            this.ngaySinh = ngaysinh;
            this.gioiTinh = phai;
            this.diemToan = toan;
            this.diemVan = van;
        }
        public string MaHV
        {
            get { return this.maHocVien; }
            set { this.maHocVien = value; }
        }
        public string HoTen
        {
            get { return this.hoTenHocVien; }
            set { this.hoTenHocVien= value; }
        }
        public DateTime NgaySinh
        {
            get { return this.ngaySinh; }
            set { this.ngaySinh = value; }
        }
        public string GT
        {
            get { return this.gioiTinh; }
            set { this.gioiTinh = value; }
        }
        public float toan
        {
            get { return this.diemToan; }
            set { this.diemToan = value; }
        }
        public float van
        {
            get { return this.diemVan; }
            set { this.diemVan = value; }
        }
        public float tinhDTB()
        {
            return ((this.diemToan + this.diemVan) / 2);
        }
        public string xepLoai()
        {
            string loai = null;
            if (tinhDTB() < 5)
                loai = "yếu";
            else if (tinhDTB() < 6.5)
                loai = "TB";
            else if (tinhDTB() < 8)
                loai = "Khá";
            else
                loai = "Giỏi";
            return loai;
        }
    }
}
