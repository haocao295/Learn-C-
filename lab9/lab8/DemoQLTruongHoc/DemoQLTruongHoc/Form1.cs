using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoQLTruongHoc
{
    public partial class Form1 : Form
    {
        private TruongHoc truong = new TruongHoc();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string CMND = txtSoCMND.Text;
            string HoTen = txtHoten.Text;
            DateTime NgaySinh = dtpNgaysinh.Value;
            string GioiTinh = null;
            if(radNam.Checked==true)
            {
                GioiTinh = "Nam";
            }
            else if(radNu.Checked==true)
            {
                GioiTinh = "Nữ";
            }
            string DiaChi = txtDiachi.Text;

            if (radGiaovien.Checked == true)
            {
                DateTime NgayVaoLam = dtpNgayvaolam.Value;
                string ChuyenMon = null;
                if (radTunhien.Checked == true)
                {
                    ChuyenMon = "Tự nhiên";
                }
                else if (radXahoi.Checked == true)
                {
                    ChuyenMon = "Xã hội";
                }
                GiaoVien gv = new GiaoVien(CMND, HoTen, NgaySinh, GioiTinh, DiaChi, NgayVaoLam, ChuyenMon);
                truong.Them(gv);
                HienThiDanhSachGiaoVien(truong,lvDanhSachGiaoVien);
            }
            else if (radHocsinh.Checked == true)
            {
                float Toan = float.Parse(txtDiemToan.Text);
                float Van = float.Parse(txtDiemVan.Text);
                float NgoaiNgu = float.Parse(txtDiemNgoaiNgu.Text);
                HocSinh hs = new HocSinh(CMND, HoTen, NgaySinh, GioiTinh, DiaChi, Toan, Van, NgoaiNgu);
                truong.Them(hs);
                HienThiDanhSachHocSinh(truong, lvDanhSachHocSinh);
            }
            
            
        }
        private void HienThiDanhSachGiaoVien(TruongHoc truonghoc,ListView lv)
        {
            lv.Items.Clear();
            GiaoVien gv = new GiaoVien();
            foreach(Nguoi nguoi in truonghoc.dsThanhVien)
            {
                if(nguoi is GiaoVien)
                {
                    gv = (GiaoVien)nguoi;
                    ListViewItem lvi = new ListViewItem(gv.SoCMND);
                    lvi.SubItems.Add(gv.HoTen);
                    lvi.SubItems.Add(gv.NgaySinh.ToShortDateString());
                    lvi.SubItems.Add(gv.GioiTinh);
                    lvi.SubItems.Add(gv.DiaChi);
                    lvi.SubItems.Add(gv.NgayVaoLam.ToString("dd/MM/yyyy"));
                    lvi.SubItems.Add(gv.ChuyenMon);

                    lv.Items.Add(lvi);
                }
            }

        }
        private void HienThiDanhSachGiaoVienTheoDanhSach(List<GiaoVien> dsGiaoVien,ListView lvDanhSachGiaoVien)
        {
            lvDanhSachGiaoVien.Items.Clear();
            foreach(GiaoVien gv in dsGiaoVien)
            {
                ListViewItem lvi = new ListViewItem(gv.SoCMND);
                lvi.SubItems.Add(gv.HoTen);
                lvi.SubItems.Add(gv.NgaySinh.ToShortDateString());
                lvi.SubItems.Add(gv.GioiTinh);
                lvi.SubItems.Add(gv.DiaChi);
                lvi.SubItems.Add(gv.NgayVaoLam.ToString());
                lvi.SubItems.Add(gv.ChuyenMon);
                lvDanhSachGiaoVien.Items.Add(lvi);
            }
        }
        private void HienThiDanhSachHocSinh(TruongHoc hocsinh, ListView lv)
        {
            lv.Items.Clear();
            HocSinh hs = new HocSinh();
            foreach (Nguoi nguoi in hocsinh.dsThanhVien)
            {
                if (nguoi is HocSinh)
                {
                    hs = (HocSinh)nguoi;
                    ListViewItem lvi = new ListViewItem(hs.SoCMND);
                    lvi.SubItems.Add(hs.HoTen);
                    lvi.SubItems.Add(hs.NgaySinh.ToShortDateString());
                    lvi.SubItems.Add(hs.GioiTinh);
                    lvi.SubItems.Add(hs.DiaChi);
                    lvi.SubItems.Add(Convert.ToString(hs.DiemToan));
                    lvi.SubItems.Add(Convert.ToString(hs.DiemVan));
                    lvi.SubItems.Add(Convert.ToString(hs.DiemNgoaiNgu));
                    lvi.SubItems.Add(Convert.ToString(hs.tinhDiemTrungBinh()));
                    lv.Items.Add(lvi);
                }
            }

        }

        private void HienThiDanhSachHocSinhTheoDanhSach(List<HocSinh>dsHocSinh,ListView lv)
        {
            lv.Items.Clear();

            foreach(HocSinh hs in dsHocSinh)
            {
                ListViewItem lvi = new ListViewItem(hs.SoCMND);
                lvi.SubItems.Add(hs.HoTen);
                lvi.SubItems.Add(hs.NgaySinh.ToShortDateString());
                lvi.SubItems.Add(hs.GioiTinh);
                lvi.SubItems.Add(hs.DiaChi);
                lvi.SubItems.Add(Convert.ToString(hs.DiemToan));
                lvi.SubItems.Add(Convert.ToString(hs.DiemVan));
                lvi.SubItems.Add(Convert.ToString(hs.DiemNgoaiNgu));
                lvi.SubItems.Add(Convert.ToString(hs.tinhDiemTrungBinh()));
                lv.Items.Add(lvi);
            }
        }

        private void lvDanhSachHocSinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvDanhSachGiaoVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Tìm giang vien co tham niên cao nhất
        private void button2_Click(object sender, EventArgs e)
        {
            List<GiaoVien> dsThamNienCaoNhat = new List<GiaoVien>();
            dsThamNienCaoNhat = truong.timGiaoVienThamNienCaoNhat();
            HienThiDanhSachGiaoVienTheoDanhSach(dsThamNienCaoNhat, lvDanhSachGiaoVien);
        }
  

        private void button4_Click(object sender, EventArgs e)
        {
            List<HocSinh> dsDiemCaoNhat = new List<HocSinh>();
            dsDiemCaoNhat = truong.timHocSingCoDiemTBCaoNhat();
            HienThiDanhSachHocSinhTheoDanhSach(dsDiemCaoNhat, lvDanhSachHocSinh);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<GiaoVien> dsThamNienCaoNhat = new List<GiaoVien>();
            dsThamNienCaoNhat = truong.timGiaoVienThamNienLon5();
            HienThiDanhSachGiaoVienTheoDanhSach(dsThamNienCaoNhat, lvDanhSachGiaoVien);
        }
        //Tìm giáo viên có thăm niên > 5 năm
        private void button1_Click(object sender, EventArgs e)
        {
            List<GiaoVien> dsThamNienCaoNhat = new List<GiaoVien>();
            dsThamNienCaoNhat = truong.timGiaoVienThamNienLon5();
            HienThiDanhSachGiaoVienTheoDanhSach(dsThamNienCaoNhat, lvDanhSachGiaoVien);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<HocSinh> dsDiemCaoNhat = new List<HocSinh>();
            dsDiemCaoNhat = truong.timHocSingCoDiemYeu();
            HienThiDanhSachHocSinhTheoDanhSach(dsDiemCaoNhat, lvDanhSachHocSinh);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<HocSinh> dsDiemCaoNhat = new List<HocSinh>();
            dsDiemCaoNhat = truong.timHocSingCoDiemGioi();
            HienThiDanhSachHocSinhTheoDanhSach(dsDiemCaoNhat, lvDanhSachHocSinh);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lvDanhSachHocSinh.Items.Clear();
            HocSinh hs = new HocSinh();
            foreach (Nguoi nguoi in truong.sapxepDSHocSinh())
            { 
                hs = (HocSinh)nguoi;
                ListViewItem lvi = new ListViewItem(hs.SoCMND);
                lvi.SubItems.Add(hs.HoTen);
                lvi.SubItems.Add(hs.NgaySinh.ToShortDateString());
                lvi.SubItems.Add(hs.GioiTinh);
                lvi.SubItems.Add(hs.DiaChi);
                lvi.SubItems.Add(Convert.ToString(hs.DiemToan));
                lvi.SubItems.Add(Convert.ToString(hs.DiemVan));
                lvi.SubItems.Add(Convert.ToString(hs.DiemNgoaiNgu));
                lvi.SubItems.Add(Convert.ToString(hs.tinhDiemTrungBinh()));
                lvDanhSachHocSinh.Items.Add(lvi);
               
            }
        }
    }
}
