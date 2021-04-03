using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQLTruongHoc
{
    class HocSinh:Nguoi
    {
        private float toan;
        private float van;
        private float anh;
        public float DiemToan
        {
            get { return this.toan; }
            set { this.toan = value; }
        }
        public float DiemVan
        {
            get { return this.van; }
            set { this.van = value; }
        }
        public float DiemNgoaiNgu
        {
            get { return this.anh; }
            set { this.anh = value; }
        }

        public HocSinh()
        {
            this.toan = 0;
            this.van = 0;
            this.anh = 0;
        }

        public HocSinh(string SoCMND,string HoTen,DateTime NgaySinh,string GioiTinh,string DiaChi,float Toan, float Van,float NgoaiNgu)
        {
            this.SoCMND = SoCMND;
            this.HoTen = HoTen;
            this.NgaySinh = NgaySinh;
            this.GioiTinh = GioiTinh;
            this.DiaChi = DiaChi;
            this.toan = Toan;
            this.van = Van;
            this.anh = NgoaiNgu;
        }

        public float tinhDiemTrungBinh()
        {
            return (this.toan + this.van + this.anh) / 3;
        }

        public string TachTen()
        {
            string ten = null;
            int ViTrikhoangTrangCuoi = this.HoTen.Trim().LastIndexOf(" ");
            ten = this.HoTen.Trim().Substring(ViTrikhoangTrangCuoi + 1);
            return ten;
        }
    }
}
