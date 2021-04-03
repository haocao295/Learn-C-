using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuanLyThongTinHV
{
    public partial class Form1 : Form
    {
        private List<HocVien> dsHocVien = new List<HocVien>();
        public  string GioiTinh { get; private set; }
        private int ViTri = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maHocVien = txtMaHocVien.Text;
            string hoTenHocVien = txtTenHocVien.Text;
          DateTime ngaySinh = dtpNgaySinh.Value;
            string gioiTinh = null;
            if(rbnNam.Checked==true)
            {
                gioiTinh = "Nam";
            }
            else if(rbnNu.Checked==true)
            {
                gioiTinh = "Nữ";
            }
            string diaChi = txtDiaChi.Text;
            string eMail = txtEmail.Text;
            string soDienThoai = txtSdt.Text;


            HocVien hocvien = new HocVien(maHocVien, hoTenHocVien, ngaySinh, gioiTinh, diaChi, soDienThoai, eMail);
            dsHocVien.Add(hocvien);
            hienThiDanhSachHocVien(lvThongTinHocVien,dsHocVien);
    }
        private void hienThiDanhSachHocVien(ListView lv, List<HocVien> dshv)
        {
            lv.Items.Clear();
            for(int i=0;i<dshv.Count;i++)
            {
                HocVien hocvien = new HocVien();
                hocvien = dshv[i];
                ListViewItem lvi = new ListViewItem(hocvien.MaHV);
                lvi.SubItems.Add(hocvien.HoTen);
                lvi.SubItems.Add(hocvien.NgaySinh.ToShortDateString());
                lvi.SubItems.Add(hocvien.GioiTinh);
                lvi.SubItems.Add(hocvien.DiaChi);
                lvi.SubItems.Add(hocvien.EMAIL);
                lvi.SubItems.Add(hocvien.SDT);
                

                lv.Items.Add(lvi);
            }
        }


        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn thật sự muốn xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                lvThongTinHocVien.Items.RemoveAt(ViTri);
             
            }
           

        }
        public void hienThiNguoc(int ViTri)
        {

            {
                HocVien hv = dsHocVien[ViTri];

                txtMaHocVien.Text = hv.MaHV;
                txtTenHocVien.Text = hv.HoTen;
                dtpNgaySinh.Value = hv.NgaySinh;
                if (hv.GioiTinh == "Nam")
                {
                    rbnNam.Checked = true;
                }
                else if (hv.GioiTinh == "Nữ")
                {
                    rbnNu.Checked = true;
                }
                txtDiaChi.Text = hv.DiaChi;
                txtEmail.Text = hv.EMAIL;
                txtSdt.Text = hv.SDT;

            }
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn thật sự muốn sửa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                HocVien hv = new HocVien();
                txtMaHocVien.Text = hv.MaHV;
                hv.HoTen = txtTenHocVien.Text;
                hv.NgaySinh = dtpNgaySinh.Value;
                if (rbnNam.Checked == true)
                {
                    hv.GioiTinh = "Nam";
                }
                else if (rbnNu.Checked == true)
                {
                    hv.GioiTinh = "Nữ";
                }
                hv.DiaChi = txtDiaChi.Text;
                hv.EMAIL = txtEmail.Text;
                hv.SDT = txtSdt.Text;

                dsHocVien[ViTri] = hv;

            }
            hienThiDanhSachHocVien(lvThongTinHocVien, dsHocVien);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn thật sự có muốn thoát", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result ==DialogResult.Yes)
            {
                this.Close();    
            }


        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
           



        }

        private void lvThongTinHocVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(lvThongTinHocVien.SelectedItems.Count > 0)
            {
                ViTri = lvThongTinHocVien.Items.IndexOf(lvThongTinHocVien.SelectedItems[0]);
            }hienThiNguoc(ViTri);

        }


        private bool timHocVienTheoMa(string maHocVien, ref HocVien hocvien)
        {
            
            for(int i=0;i<dsHocVien.Count;i++)
            {
                if (dsHocVien[i].MaHV.Equals(maHocVien))
                    {
                    hocvien = dsHocVien[i];
                    return true;
                  }
            }
            return false;
        }
        private List<HocVien> timHocVienTHeoTen (string hoten)
        {
            List<HocVien> dsKetQua = new List<HocVien>();
            for(int i=0;i<dsHocVien.Count;i++)
            {
                if(dsHocVien[i].MaHV.Equals(hoten))
                {
                    dsKetQua.Add(dsHocVien[i]);

                }
            }return dsKetQua;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            
            List<HocVien> dshv = new List<HocVien>();
            
            if (rbntimTheoMa.Checked==true)
            {
                for (int i = 0; i < dsHocVien.Count; i++)
                {
                    if (dsHocVien[i].MaHV.Equals(txttimTheoMa.Text))
                    {
                        dshv.Add(dsHocVien[i]);
                        
                    }
                   
                }
                hienThiDanhSachHocVien(lvThongTinHocVien, dshv);
            }
            else if(rbntimTheoTen.Checked==true)
            {
                for (int i = 0; i < dsHocVien.Count; i++)
                {
                    if (dsHocVien[i].HoTen.Equals(txttimTheoTen.Text))
                    {
                        dshv.Add(dsHocVien[i]);

                    }



                }
                hienThiDanhSachHocVien(lvThongTinHocVien, dshv);

            }





        }



        private void Form1_Load (object sender, EventArgs e)
        {
            docDuLieuTuFile("danhsachhocvien.txt");
            hienThiDanhSachHocVien( lvThongTinHocVien, this.dsHocVien);
        }
        private void docDuLieuTuFile (string tenFile)
        {
            string[] tatCaCacDong = File.ReadAllLines(tenFile);
            string dong = null;
            for(int i=0;i<tatCaCacDong.Length;i++)
            {
                dong = tatCaCacDong[i];
                HocVien hocvien = new HocVien(dong);
                this.dsHocVien.Add(hocvien);
            }
        }
        private void ghiFile (string tenFile)
        {
            StreamWriter swt = new StreamWriter(tenFile, false, Encoding.UTF8);
            for(int i =0;i<this.dsHocVien.Count;i++)
            {
                swt.WriteLine(dsHocVien[i].MaHV + "\t" + dsHocVien[i].HoTen + "\t" + dsHocVien[i].NgaySinh + "\t" + dsHocVien[i].GioiTinh + "\t" + dsHocVien[i].DiaChi + "\t" + dsHocVien[i].EMAIL + "\t" + dsHocVien[i].SDT);

            } swt.Close();
        }

        private void btnghifile_Click(object sender, EventArgs e)
        {

            ghiFile("danhsachhocvien.txt");
            MessageBox.Show("Đã ghi dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btndocFile_Click(object sender, EventArgs e)
        {
            docDuLieuTuFile("danhsachhocvien.txt");
        }
    }
}
