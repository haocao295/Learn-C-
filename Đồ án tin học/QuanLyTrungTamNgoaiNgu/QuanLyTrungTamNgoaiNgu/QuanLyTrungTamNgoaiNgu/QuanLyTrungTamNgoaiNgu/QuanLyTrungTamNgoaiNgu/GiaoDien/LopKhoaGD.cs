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
    public partial class LopKhoaGD : Form
    {
        private static LopKhoaXL xuLy = new LopKhoaXL();

        public LopKhoaGD()
        {
            InitializeComponent();
        }

        private void LopKhoaGD_Load(object sender, EventArgs e)
        {
            cbbLop.DataSource = xuLy.layDanhSachLop();
            cbbLop.DisplayMember = "tenLop";
            cbbLop.ValueMember = "maLop";
            cbbKhoa.DataSource = xuLy.layDanhSacKhoa();
            cbbKhoa.DisplayMember = "tenKhoa";
            cbbKhoa.ValueMember = "maKhoa";
            hienThi(xuLy.layDanhSachLopKhoa());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LopKhoaDT lopKhoa = new LopKhoaDT();
            lopKhoa.MaLopKhoa = cbbKhoa.SelectedValue + "-" + cbbLop.SelectedValue;
            lopKhoa.Lop.MaLop = cbbLop.SelectedValue.ToString();
            lopKhoa.Lop.TenLop = cbbLop.GetItemText(cbbLop.SelectedItem);
            lopKhoa.Khoa.MaKhoa = cbbKhoa.SelectedValue.ToString();
            lopKhoa.Khoa.TenKhoa = cbbKhoa.GetItemText(cbbKhoa.SelectedItem);
            lopKhoa.SiSo = int.Parse(txtSiSo.Text);
            xuLy.Them(lopKhoa);
            hienThi(xuLy.layDanhSachLopKhoa());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            LopKhoaDT lopKhoa = new LopKhoaDT();
            lopKhoa.MaLopKhoa = cbbKhoa.SelectedValue + "-" + cbbLop.SelectedValue;
            lopKhoa.Lop.MaLop = cbbLop.SelectedValue.ToString();
            lopKhoa.Lop.TenLop = cbbLop.GetItemText(cbbLop.SelectedItem);
            lopKhoa.Khoa.MaKhoa = cbbKhoa.SelectedValue.ToString();
            lopKhoa.Khoa.TenKhoa = cbbKhoa.GetItemText(cbbKhoa.SelectedItem);
            lopKhoa.SiSo = int.Parse(txtSiSo.Text);
            xuLy.Sua(lopKhoa);
            hienThi(xuLy.layDanhSachLopKhoa());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show("Bạn có muốn xóa lớp-khóa học này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ketQua == DialogResult.Yes)
            {
                foreach (ListViewItem lvi in lsvLopKhoa.SelectedItems)
                {
                    string maLopKhoa = lvi.SubItems[0].Text;
                    xuLy.Xoa(maLopKhoa);
                }
                hienThi(xuLy.layDanhSachLopKhoa());
            }   
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (xuLy.Luu())
            {
                MessageBox.Show("Lưu lớp-khóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lưu lớp-khóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvLopKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lsvLopKhoa.SelectedItems)
            {
                string maLopKhoa = lvi.SubItems[0].Text;
                LopKhoaDT lopKhoa = xuLy.TimKiem(maLopKhoa);
                if (lopKhoa != null)
                {
                    cbbLop.SelectedValue = lopKhoa.Lop.MaLop;
                    cbbKhoa.SelectedValue = lopKhoa.Khoa.MaKhoa;
                    txtSiSo.Text = lopKhoa.SiSo.ToString();
                    break;
                }
            }
        }

        private void hienThi(List<LopKhoaDT> danhSach)
        {
            lsvLopKhoa.Items.Clear();
            foreach (LopKhoaDT lopKhoa in danhSach)
            {
                ListViewItem lvi = new ListViewItem(lopKhoa.MaLopKhoa);
                lvi.SubItems.Add(lopKhoa.Lop.TenLop);
                lvi.SubItems.Add(lopKhoa.Khoa.TenKhoa);
                lvi.SubItems.Add(lopKhoa.SiSo.ToString());
                lsvLopKhoa.Items.Add(lvi);
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

       
    }
}
