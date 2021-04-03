using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThongTinHV
{
    class HocVien
    {

        private string maHocVien;
        private string hoTenHocVien;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string soDienThoai;
        private string eMail;
        private string diaChi;



        public HocVien (string dong)
        {
            string[] tam = dong.Split("\t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            if(tam.Length > 0)
            {
                this.maHocVien = tam[0];
                this.hoTenHocVien = tam[1];
                this.ngaySinh =DateTime.Parse (tam[2]);
                this.gioiTinh = tam[3];
                this.diaChi = tam[4];
                this.eMail = tam[5];
                this.soDienThoai = tam[6];
            }
        }
        public HocVien()
        {
            this.maHocVien = null;
            this.hoTenHocVien = null;

        }
        public HocVien(string ma, string hoten, DateTime ngaysinh, string phai,string dc ,string sdt, string email)
        {
           this. maHocVien = ma;
           this. hoTenHocVien = hoten;
           this. ngaySinh = ngaysinh;
           this. gioiTinh = phai;
            this.diaChi = dc;
           this.soDienThoai = sdt;
           this. eMail = email;
        }
        public string MaHV
        {
            get { return this.maHocVien; }
            set { this.maHocVien = value; }
        }
        public string HoTen
        {
            get { return this.hoTenHocVien; }
            set { this.hoTenHocVien = value; }
        }
        public DateTime NgaySinh
        {
            get { return this.ngaySinh; }
            set { this.ngaySinh = value; }
        }
        public string GioiTinh
        {
            get { return this.gioiTinh; }
            set { this.gioiTinh = value; }
        }
        public string SDT
        {
            get { return this.soDienThoai; }
            set { this.soDienThoai = value; }
        }
        public string EMAIL
        {
            get { return this.eMail; }
            set { this.eMail = value; }
        }
        public string DiaChi
        {
            get { return this.diaChi; }
            set { this.diaChi = value; }
        }

        public String tachTen()
        {
            string ten  = null;
            int viTriKhoangTrangCuoi = this.HoTen.Trim().LastIndexOf(" ");
            ten = this.HoTen.Substring(viTriKhoangTrangCuoi);
            return ten;

        }

    }
}
