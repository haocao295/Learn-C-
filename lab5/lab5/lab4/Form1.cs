using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        private List<HocVien> dsHocVien = new List<HocVien>();
        private int viTri = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void them_Click(object sender, EventArgs e)
        {
            string maHocVien = mahv.Text;
            string hoTen = hoten.Text;
            DateTime ngaySinh = ngaysinh.Value;
            string gioiTinh = "";
            if(nam.Checked == true)
            {
                gioiTinh = "Nam";
            }
            else if(nu.Checked == true)
            {
                gioiTinh = "Nữ";
            }
            float diemToan = float.Parse(toan.Text);
            float diemVan = float.Parse(van.Text);
            HocVien hocVien = new HocVien(maHocVien, hoTen, ngaySinh, gioiTinh, diemToan, diemVan);
            dsHocVien.Add(hocVien);
            hienThiDsHocVien(lvDanhSachHocVien);
        }
        public void hienThiDsHocVien(ListView lv)
        {
            lv.Items.Clear();
            for(int i = 0; i<dsHocVien.Count;i++)
            {
                HocVien hocVien = new HocVien();
                hocVien = dsHocVien[i];
                ListViewItem lvi = new ListViewItem(hocVien.MaHV);
                lvi.SubItems.Add(hocVien.HoTen);
                lvi.SubItems.Add(hocVien.NgaySinh.ToString());
                lvi.SubItems.Add(hocVien.GT.ToString());
                lvi.SubItems.Add(hocVien.toan.ToString());
                lvi.SubItems.Add(hocVien.van.ToString());
                lvi.SubItems.Add(hocVien.tinhDTB().ToString());
                lvi.SubItems.Add(hocVien.xepLoai());
                lv.Items.Add(lvi);
                tb.Text = hocVien.tinhDTB().ToString();
                xeploai.Text = hocVien.xepLoai().ToString();
            }
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            dsHocVien.RemoveAt(viTri);
            hienThiDsHocVien(lvDanhSachHocVien);
        }
        private void sua_Click(object sender, EventArgs e)
        {
            string maHocVien = mahv.Text;
            string hoTen = hoten.Text;
            DateTime ngaySinh = ngaysinh.Value;
            string gioiTinh = "";
            if (nam.Checked == true)
            {
                gioiTinh = "Nam";
            }
            else if (nu.Checked == true)
            {
                gioiTinh = "Nữ";
            }
            float diemToan = float.Parse(toan.Text);
            float diemVan = float.Parse(van.Text);
            HocVien hocVien = new HocVien(maHocVien, hoTen, ngaySinh, gioiTinh, diemToan, diemVan);
            dsHocVien[viTri] = hocVien;
            hienThiDsHocVien(lvDanhSachHocVien);
         }

        private void lvDanhSachHocVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(int i in lvDanhSachHocVien.SelectedIndices)
            {
                viTri = i;
            }
            hienThi1HocVien(dsHocVien[viTri]);
        }
       private void hienThi1HocVien(HocVien hv)
        {
            mahv.Text = hv.MaHV;
            hoten.Text = hv.HoTen;
            ngaysinh.Value = hv.NgaySinh;
            string gioiTinh = hv.GT;
            if (gioiTinh.Equals("Nam"))
                nam.Checked = true;
            else
                nu.Checked = true;
            toan.Text = hv.toan.ToString();
            van.Text = hv.van.ToString();
            tb.Text = hv.tinhDTB().ToString();
            xeploai.Text = hv.xepLoai().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HocVien hv = new HocVien();
            List<HocVien> dsKetQua = new List<HocVien>();
            if(chonMa.Checked == true)
            {
                if(timKiemHocVienTheoMa(timTheoMa.Text, ref hv) == true)
                {
                    hienThi1HocVien(hv);
                }
                else if(timKiemHocVienTheoMa(timTheoMa.Text, ref hv) == false)
                {
                    MessageBox.Show("Không tìm thấy", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if(chonTen.Checked == true)
            {
                dsKetQua = timKiemHocVienTheoTen(timTheoTen.Text);
                if(dsKetQua.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    hienThiDanhSachHocVien(dsKetQua, lvDanhSachHocVien);
                }
            }
        }
        private List<HocVien> timKiemHocVienTheoTen(string hoten)
        {
            List<HocVien> dsKetQua = new List<HocVien>();
            for( int i = 0; i<dsHocVien.Count; i++)
            {
                if (dsHocVien[i].HoTen.Equals(hoten))
                {
                    dsKetQua.Add(dsHocVien[i]);
                }
            }
            return dsKetQua;
        }
        private bool timKiemHocVienTheoMa(string maHV, ref HocVien hocVien)
        {
            for (int i = 0; i < dsHocVien.Count; i++)
            {
                if (dsHocVien[i].MaHV.Equals(maHV))
                {
                    hocVien = dsHocVien[i];
                    return true;
                }
            }
            return false;
        }
        private void hienThiDanhSachHocVien(List<HocVien> danhSach, ListView lv)
        {
            lv.Items.Clear();
            for (int i = 0; i < danhSach.Count; i++)
            {
                HocVien hocVien = new HocVien();
                hocVien = dsHocVien[i];
                ListViewItem lvi = new ListViewItem(hocVien.MaHV);
                lvi.SubItems.Add(hocVien.HoTen);
                lvi.SubItems.Add(hocVien.NgaySinh.ToString());
                lvi.SubItems.Add(hocVien.GT.ToString());
                lvi.SubItems.Add(hocVien.toan.ToString());
                lvi.SubItems.Add(hocVien.van.ToString());
                lvi.SubItems.Add(hocVien.tinhDTB().ToString());
                lvi.SubItems.Add(hocVien.xepLoai());
                lv.Items.Add(lvi);
                tb.Text = hocVien.tinhDTB().ToString();
                xeploai.Text = hocVien.xepLoai().ToString();
            }
        }
    }
}
