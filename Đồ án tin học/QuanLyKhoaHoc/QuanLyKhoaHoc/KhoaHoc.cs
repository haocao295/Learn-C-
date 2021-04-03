using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoaHoc
{
    class KhoaHoc
    {
        private string maKhoaHoc;
        private string tenKhoaHoc;
        private DateTime ngayKhaiGiang;
        private DateTime ngayKetThuc;

        public KhoaHoc()
            {
                this.maKhoaHoc=null;
            this.tenKhoaHoc = null;

            }
        public  KhoaHoc (string maKH, string tenKH, DateTime ngayKG, DateTime ngayKT)
        {
            this.maKhoaHoc = maKH;
            this.tenKhoaHoc = tenKH;
            this.ngayKhaiGiang = ngayKG;
            this.ngayKetThuc = ngayKT;
        }
        public string MaKH
        {
            get { return this.maKhoaHoc; }
            set { this.maKhoaHoc = value; }
        }
        public string TenKH
        {
            get { return this.tenKhoaHoc; }
            set { this.tenKhoaHoc = value; }
        }
        public DateTime NgayKG
        {
            get { return this.ngayKhaiGiang; }
            set { this.ngayKhaiGiang = value; }
        }
        public DateTime NgayKT
        {
            get { return this.ngayKetThuc; }
            set { this.ngayKetThuc = value; }
        }
    }
}
