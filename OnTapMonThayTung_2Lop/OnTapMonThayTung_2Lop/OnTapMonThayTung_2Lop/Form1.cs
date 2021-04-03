using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTapMonThayTung_2Lop
{
    public partial class Form1 : Form
    {
        private XulyHocsinh xl;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            xl = new XulyHocsinh();
            //xl.docFile("hocsinh.dat");
            hienThi();
        }

        private void hienThi()
        {
            lvDanhSachHS.Items.Clear();
            foreach(HocSinh a in xl.getDSHocSinh())
            {
                ListViewItem lvi = new ListViewItem(a.MaHS);
                lvi.SubItems.Add(a.HoTen);
                lvi.SubItems.Add(a.NgaySinh.ToShortDateString());
                lvi.SubItems.Add(a.GT ? "Nam" : "Nữ");
                lvi.SubItems.Add(a.DiaChi);
                lvDanhSachHS.Items.Add(lvi);
            }
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            HocSinh a = new HocSinh();
            a.MaHS = txtMaSoHS.Text;
            a.HoTen = txtHoTenHS.Text;
            a.DiaChi = txtDiaChi.Text;
            a.NgaySinh = dtpNgaySinh.Value;
            a.GT = radNam.Checked;

            xl.them(a);

            hienThi();
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvDanhSachHS.SelectedItems)
            {
                string mshs = lvi.SubItems[0].Text;
                xl.xoa(mshs);
            }
            hienThi();
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            HocSinh a = new HocSinh();
            a.MaHS = txtMaSoHS.Text;
            a.HoTen = txtHoTenHS.Text;
            a.DiaChi = txtDiaChi.Text;
            a.NgaySinh = dtpNgaySinh.Value;
            a.GT = radNam.Checked;

            xl.sua(a);

            hienThi();
        }

        private void lvDanhSachHS_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem lvi in lvDanhSachHS.SelectedItems)
            {
                string mshs = lvi.SubItems[0].Text;
                HocSinh hs = xl.tim(mshs);
                if(hs != null)
                {
                    txtMaSoHS.Text = hs.MaHS;
                    txtHoTenHS.Text = hs.HoTen;
                    txtDiaChi.Text = hs.DiaChi;
                    dtpNgaySinh.Value = hs.NgaySinh;
                    if (hs.GT == true) radNam.Checked = true;
                    else radNữ.Checked = true;
                }
            }
        }

        private void bntLuuFile_Click(object sender, EventArgs e)
        {
            bool kq = xl.ghiFile("hocsinh.dat");
            if (kq == false) MessageBox.Show("Không mở được FILE");
            else
            {
                MessageBox.Show("Ghi dữ liệu lên FILE thành công");
            }
        }

        
    }
}
