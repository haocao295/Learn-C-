using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTrungTamNgoaiNgu.DoiTuong;
using QuanLyTrungTamNgoaiNgu.XuLy;

namespace QuanLyTrungTamNgoaiNgu.GiaoDien
{
    public partial class HocVienGD : Form
    {
        private HocVienXL xl=new HocVienXL();
        public HocVienGD()
        {
            InitializeComponent();
        }
        private void hienthi(List<HocVienDT> danhSach)
        {
            lvdanhsachhv.Items.Clear();
            foreach (HocVienDT a in danhSach)
            {
                ListViewItem lvi = new ListViewItem(a.MaHV);
                lvi.SubItems.Add(a.HoTen);
                lvi.SubItems.Add(a.NgaySinh.ToString("dd/MM/yyyy"));
                lvi.SubItems.Add(a.GioiTinh ? "Nam" : "Nữ");
                lvi.SubItems.Add(a.DiaChi);
                lvi.SubItems.Add(a.SDT);
                lvi.SubItems.Add(a.Email);
                lvdanhsachhv.Items.Add(lvi);
            }
        }
        private void hienThiHocVien(HocVienDT hocvien)
        {
            txtmahocvien.Text = hocvien.MaHV;
            txthoten.Text = hocvien.HoTen;
            dtbngaysinh.Value = hocvien.NgaySinh;
            if (hocvien.GioiTinh == true) radnam.Checked = true;
            else radnu.Checked = true;
            txtdiachi.Text = hocvien.DiaChi;
            txtsdt.Text = hocvien.SDT;
            txtemail.Text = hocvien.Email;

        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            HocVienDT hocvien = new HocVienDT();
            hocvien.MaHV = txtmahocvien.Text;
            hocvien.HoTen = txthoten.Text;
            hocvien.NgaySinh = dtbngaysinh.Value;
            hocvien.GioiTinh = radnam.Checked;
            hocvien.DiaChi = txtdiachi.Text;
            hocvien.SDT = txtsdt.Text;
            hocvien.Email = txtemail.Text;
            if (xl.timHocVienTheoMa(hocvien.MaHV, ref hocvien) == true)
            {
                MessageBox.Show("Trùng mã học viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            xl.them(hocvien);
            hienthi(xl.layDanhSachHocVien());
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            HocVienDT hocvien = new HocVienDT();
            DialogResult result = MessageBox.Show("Bạn có muốn sửa?", " thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                hocvien.MaHV = txtmahocvien.Text;
                hocvien.HoTen = txthoten.Text;
                hocvien.NgaySinh = dtbngaysinh.Value;
                hocvien.GioiTinh = radnam.Checked;
                hocvien.DiaChi = txtdiachi.Text;
                hocvien.SDT = txtsdt.Text;
                hocvien.Email = txtemail.Text;

                xl.sua(hocvien);
            }
            hienthi(xl.layDanhSachHocVien());
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvdanhsachhv.SelectedItems)
            {
                string maHV = lvi.SubItems[0].Text;
                DialogResult result = MessageBox.Show("Bạn có muốn xóa?", " thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    xl.xoa(maHV);
                }
            }
            hienthi(xl.layDanhSachHocVien());
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (xl.Luu())
            {
                MessageBox.Show("Lưu học viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lưu học viên không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            HocVienDT hocvien = new HocVienDT();
            {
                if (xl.timHocVienTheoMa(txtnhapma.Text, ref hocvien) == true)
                    hienThiHocVien(hocvien);
                else
                    MessageBox.Show("Không tìm thấy", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", " Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lvdanhsachhv_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvdanhsachhv.SelectedItems)
            {
                string maHV = lvi.SubItems[0].Text;
                HocVienDT hocvien = xl.tim(maHV);
                if (hocvien != null)
                {
                    txtmahocvien.Text = hocvien.MaHV;
                    txthoten.Text = hocvien.HoTen;
                    dtbngaysinh.Value = hocvien.NgaySinh;
                    if (hocvien.GioiTinh == true) radnam.Checked = true;
                    else radnu.Checked = true;
                    txtdiachi.Text = hocvien.DiaChi;
                    txtsdt.Text = hocvien.SDT;
                    txtemail.Text = hocvien.Email;
                }
            }
        }

        private void HocVienGD_Load(object sender, EventArgs e)
        {
            hienthi(xl.layDanhSachHocVien());
        }
    }
}
