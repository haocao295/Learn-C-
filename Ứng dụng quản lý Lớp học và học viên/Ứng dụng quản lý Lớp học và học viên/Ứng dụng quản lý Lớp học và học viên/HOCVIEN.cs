using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ứng_dụng_quản_lý_Lớp_học_và_học_viên
{
    [Serializable]
    class HOCVIEN
    {
        private string Mahv;
        private string Hoten;
        private DateTime Ngaysinh;
        private string Gioitinh;
        private float Diemtoan;
        private float Diemvan;

        public HOCVIEN()
        {
            this.Mahv = null;
            this.Hoten = null;
            this.Ngaysinh = DateTime.Now;
            this.Gioitinh = null;
            this.Diemtoan = 0;
            this.Diemvan = 0;
        }
        public HOCVIEN(string Mahv,string Hoten,DateTime Ngaysinh,string Gioitinh,float Diemtoan,float Diemvan)
        {
            this.Mahv = Mahv;
            this.Hoten = Hoten;
            this.Ngaysinh = Ngaysinh;
            this.Gioitinh = Gioitinh;
            this.Diemtoan = Diemtoan;
            this.Diemvan = Diemvan;
        }
        public HOCVIEN(string dong)
        {
            string[] tam = dong.Split("\t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            if(tam.Length>0)
            {
                this.Mahv = tam[0];
                this.Hoten = tam[1];
                this.Ngaysinh = DateTime.Parse(tam[2]);
                this.Gioitinh = tam[3];
                this.Diemtoan = float.Parse(tam[4]);
                this.Diemvan = float.Parse(tam[5]);
            }
        }
        public string MaHV
        {
            get { return this.Mahv; }
            set { this.Mahv = value; }
        }
        public string HOTEN
        {
            get { return this.Hoten; }
            set { this.Hoten = value; }
        }
        public DateTime NGAYSINH
        {
            get { return this.Ngaysinh; }
            set { this.Ngaysinh = value; }
        }
        public string GIOITINH
        {
            get { return this.Gioitinh; }
            set { this.Gioitinh = value; }
        }
        public float DIEMTOAN
        {
            get { return this.Diemtoan; }
            set { this.Diemtoan = value; }
        }
        public float DIEMVAN
        {
            get { return this.Diemvan; }
            set { this.Diemvan = value; }
        }
        public float tinhDiemTB()
        {
            return (this.Diemtoan + this.Diemvan) / 2;
        }
        public string xepLoai()
        {
            string loai = null;
            if (tinhDiemTB() >= 8 && tinhDiemTB() <= 10)
            {
                loai = "Giỏi";
            }
            else if (tinhDiemTB() < 8 && tinhDiemTB() >= 6.5)
            {
                loai = "Khá";
            }
            else if (tinhDiemTB() < 6.5 && tinhDiemTB() >= 5)
            {
                loai = "Trung bình";
            }
            else
                loai = "Yếu";
            return loai;
        }
        public string tachTen()
        {
            string ten = null;
            int vitriKhoangCachCuoi = this.Hoten.Trim().LastIndexOf(" ");
            ten = this.Hoten.Substring(vitriKhoangCachCuoi);
            return ten;
        }
    }
}
