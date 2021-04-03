using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ứng_dụng_quản_lý_Lớp_học_và_học_viên
{
    class LopHoc
    {
        private string malop;
        private string tenlop;
        private List<HOCVIEN> dsHOCVIEN;

        public LopHoc()
        {
            this.malop = null;
            this.tenlop = null;
            this.dsHOCVIEN = new List<HOCVIEN>();
        }
        public LopHoc(string malop, string tenlop, List<HOCVIEN> ds)
        {
            this.malop = malop;
            this.tenlop = tenlop;
            this.dsHOCVIEN = ds;
        }
        public LopHoc(string malop,string tenlop)
        {
            this.malop = malop;
            this.tenlop = tenlop;
        }
        public string MaLop
        {
            get { return this.malop; }
            set { this.malop = value; }
        }
        public string TenLop
        {
            get { return this.tenlop; }
            set { this.tenlop = value; }
        }
        public List<HOCVIEN>Danhsach
        {
            get { return this.dsHOCVIEN; }
            set { this.dsHOCVIEN = value; }
        }
        public void themHocVien(HOCVIEN hv)
        {
            this.dsHOCVIEN.Add(hv);
        }
        public void capNhatHocVien(HOCVIEN hv,int vitri)
        {
            this.dsHOCVIEN[vitri] = hv;
        }
        public void xoaHocVien(int vitri)
        {
            this.dsHOCVIEN.RemoveAt(vitri);
        }
    }
}
