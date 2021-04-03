using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQLTruongHoc
{
    class TruongHoc
    {
        public List<Nguoi> dsThanhVien { get; set; }

        public TruongHoc()
        {
            dsThanhVien = new List<Nguoi>();
        }

        public TruongHoc(List<Nguoi> ds)
        {
            dsThanhVien = ds;
        }
        public void Them(GiaoVien gv)
        {
            this.dsThanhVien.Add(gv);
        }
        public void Them(HocSinh hs)
        {
            this.dsThanhVien.Add(hs);
        }
        public float timDiemTrungBinhCaoNhat()
        {
            float DiemTrungBinhCaoNhat = 0;
            foreach (Nguoi nguoi in dsThanhVien)
            {
                if(nguoi is HocSinh)
                {
                    if (((HocSinh)nguoi).tinhDiemTrungBinh() > DiemTrungBinhCaoNhat)
                        DiemTrungBinhCaoNhat = ((HocSinh)nguoi).tinhDiemTrungBinh();
                }
            }
            return DiemTrungBinhCaoNhat;
        }
        public List<HocSinh> timHocSingCoDiemTBCaoNhat()
        {
            List<HocSinh> KetQua = new List<HocSinh>();
            float DiemTrungBinhCaoNhat = timDiemTrungBinhCaoNhat();
            foreach (Nguoi nguoi in dsThanhVien)
            {
                if(nguoi is HocSinh)
                {
                    if(((HocSinh)nguoi).tinhDiemTrungBinh() == DiemTrungBinhCaoNhat)
                    {
                        KetQua.Add((HocSinh)nguoi);
                    }
                }
            }
            return KetQua;
        }
        public HocSinh TimHocSinhTheoCMND(string CMND)
        {
            HocSinh hocSinh = new HocSinh();
            foreach(Nguoi nguoi in dsThanhVien)
            {
                hocSinh = (HocSinh)nguoi;
                break;
            }
            return hocSinh;
        }
        //    public List<HocSinh> timHocSinhTheoTen( string ten)
        //    {
        //        List<HocSinh>
        //    }
        public int timGVThamNienCaoNhat()
        {
            int thamNienCaoNhat = 0;
            foreach (Nguoi nguoi in dsThanhVien)
            {
                if (nguoi is GiaoVien)
                {
                    if (((GiaoVien)nguoi).tinhThanhNien() > thamNienCaoNhat)
                        thamNienCaoNhat = ((GiaoVien)nguoi).tinhThanhNien();
                }
            }
            return thamNienCaoNhat;
        }
        public List<GiaoVien> timGiaoVienThamNienCaoNhat()
        {
            List<GiaoVien> KetQua = new List<GiaoVien>();
            int thamNienLonNhat = timGVThamNienCaoNhat();
            foreach (Nguoi nguoi in dsThanhVien)
            {
                if (nguoi is GiaoVien)
                {
                    int thamNien = ((GiaoVien)nguoi).tinhThanhNien();
                    if (thamNien == thamNienLonNhat)
                    {
                        KetQua.Add((GiaoVien)nguoi);
                    }
                }
            }
            return KetQua;
        }

        public List<GiaoVien> timGiaoVienThamNienLon5()
        {
            List<GiaoVien> KetQua = new List<GiaoVien>();
            foreach (Nguoi nguoi in dsThanhVien)
            {
                if (nguoi is GiaoVien)
                {
                    if ((((GiaoVien)nguoi).tinhThamNien()/365) > 5)
                    {
                        KetQua.Add((GiaoVien)nguoi);
                    }
                }
            }
            return KetQua;
        }
        public List<GiaoVien> timGiaoVienNu()
        {
            List<GiaoVien> KetQua = new List<GiaoVien>();
            foreach (Nguoi nguoi in dsThanhVien)
            {
                if (nguoi is GiaoVien)
                {
                    if (((GiaoVien)nguoi).GioiTinh == "Nữ")
                    {
                        KetQua.Add((GiaoVien)nguoi);
                    }
                }
            }
            return KetQua;
        }
        public List<HocSinh> timHocSingCoDiemYeu()
        {
            List<HocSinh> KetQua = new List<HocSinh>();
            foreach (Nguoi nguoi in dsThanhVien)
            {
                if (nguoi is HocSinh)
                {
                    if (((HocSinh)nguoi).tinhDiemTrungBinh()< 5)
                    {
                        KetQua.Add((HocSinh)nguoi);
                    }
                }
            }
            return KetQua;
        }
        public List<HocSinh> timHocSingCoDiemGioi()
        {
            List<HocSinh> KetQua = new List<HocSinh>();
            foreach (Nguoi nguoi in dsThanhVien)
            {
                if (nguoi is HocSinh)
                {
                    if (((HocSinh)nguoi).tinhDiemTrungBinh() > 8)
                    {
                        KetQua.Add((HocSinh)nguoi);
                    }
                }
            }
            return KetQua;
        }
        public List<HocSinh> layDanhSachHocSinh()
        {
            return dsThanhVien.Cast<HocSinh>().ToList();
        }
        public List<HocSinh> sapxepDSHocSinh()
        {
            return layDanhSachHocSinh().OrderBy(x => x.tinhDiemTrungBinh()).ToList();
        }
    }
}
