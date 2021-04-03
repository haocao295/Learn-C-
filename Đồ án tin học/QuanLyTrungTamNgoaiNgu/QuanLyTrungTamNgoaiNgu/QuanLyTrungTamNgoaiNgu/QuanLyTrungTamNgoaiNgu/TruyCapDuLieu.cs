using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using QuanLyTrungTamNgoaiNgu.DoiTuong;
using System.Windows.Forms;

namespace QuanLyTrungTamNgoaiNgu
{
    [Serializable]
    class TruyCapDuLieu
    {
        private static TruyCapDuLieu duLieu = null;
        private List<HocVienDT> danhSachHocVien;
        private List<LopDT> danhSachLop;
        private List<KhoaDT> danhSachKhoa;
        private List<LopKhoaDT> danhSachLopKhoa;
        private List<PhieuDangKyDT> danhSachPhieuDangKy;

        private TruyCapDuLieu()
        {
            danhSachHocVien = new List<HocVienDT>();
            danhSachLop = new List<LopDT>();
            danhSachKhoa = new List<KhoaDT>();
            danhSachLopKhoa = new List<LopKhoaDT>();
            danhSachPhieuDangKy = new List<PhieuDangKyDT>();
        }

        public static TruyCapDuLieu khoiTao()
        {
            if(duLieu == null)
            {
                duLieu = new TruyCapDuLieu();
            }
            return duLieu;
        }

        public List<HocVienDT>layDanhSachHocVien()
        {
            return danhSachHocVien;
        }
        public List<LopDT> layDanhSachLop()
        {
            return danhSachLop;
        }

        public List<KhoaDT> layDanhSachKhoa()
        {
            return danhSachKhoa;
        }

        public List<LopKhoaDT> layDanhSachLopKhoa()
        {
            return danhSachLopKhoa;
        }
        public List<PhieuDangKyDT>layDanhSachPhieuDangKy()
        {
            return danhSachPhieuDangKy;
        }

        public static bool docFile(string tenFile)
        {
            try
            {
                FileStream stream = new FileStream(tenFile, FileMode.Open);
                if (stream == null) return false;
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                duLieu = binaryFormatter.Deserialize(stream) as TruyCapDuLieu;
                stream.Close();
                return true;
            } catch
            {
                return false;
            }
        }

        public static bool ghiFile(string tenFile)
        {
            try
            {
                FileStream stream = new FileStream(tenFile, FileMode.Create);
                if (stream == null) return false;
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, duLieu);
                stream.Close();
                return true;
            } catch
            {
                return false;
            }
        }
    }
}
