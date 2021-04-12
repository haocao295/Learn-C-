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
    public partial class KhoaGD : Form
    {
        private static KhoaXL xuLy = new KhoaXL();
        public KhoaGD()
        {
            InitializeComponent();
        }

        private void KhoaGD_Load(object sender, EventArgs e)
        {
            hienThi(xuLy.layDanhSachKhoa());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KhoaDT khoa = new KhoaDT();
            khoa.MaKhoa = txtMaKhoa.Text;
            khoa.TenKhoa = txtTenKhoa.Text;
            khoa.NgayBatDau = dtpNgayBatDau.Value;
            khoa.NgayKetThuc = dtpNgayKetThuc.Value;
            if(xuLy.TimKiem(khoa.MaKhoa) != null)
            {
                MessageBox.Show("Trùng mã khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
		

			xuLy.Them(khoa);
            hienThi(xuLy.layDanhSachKhoa());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KhoaDT khoa = new KhoaDT();
            khoa.MaKhoa = txtMaKhoa.Text;
            khoa.TenKhoa = txtTenKhoa.Text;
            khoa.NgayBatDau = dtpNgayBatDau.Value;
            khoa.NgayKetThuc = dtpNgayKetThuc.Value;
            xuLy.Sua(khoa);
            hienThi(xuLy.layDanhSachKhoa());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show("Bạn có muốn xóa khóa học này không?", "Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(ketQua == DialogResult.Yes)
            {
                foreach (ListViewItem lvi in lsvKhoa.SelectedItems)
                {
                    string maKhoa = lvi.SubItems[0].Text;
                    xuLy.Xoa(maKhoa);
                }
                hienThi(xuLy.layDanhSachKhoa());
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(xuLy.Luu())
            {
                MessageBox.Show("Lưu khóa học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Lưu khóa học không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lsvKhoa.SelectedItems)
            {
                string maKhoa = lvi.SubItems[0].Text;
                KhoaDT khoa = xuLy.TimKiem(maKhoa);
                if (khoa != null)
                {
                    txtMaKhoa.Text = khoa.MaKhoa;
                    txtTenKhoa.Text = khoa.TenKhoa;
                    dtpNgayBatDau.Value = khoa.NgayBatDau;
                    dtpNgayKetThuc.Value = khoa.NgayKetThuc;
                    break;
                }
            }
        }

        private void hienThi(List<KhoaDT> danhSach)
        {
            lsvKhoa.Items.Clear();
            foreach (KhoaDT khoa in danhSach)
            {
                ListViewItem lvi = new ListViewItem(khoa.MaKhoa);
                lvi.SubItems.Add(khoa.TenKhoa);
                lvi.SubItems.Add(khoa.NgayBatDau.ToString("dd/MM/yyyy"));
                lvi.SubItems.Add(khoa.NgayKetThuc.ToString("dd/MM/yyyy"));
                lsvKhoa.Items.Add(lvi);
            }
        }
		//bool checkData()
		//{
		//	if(string.IsNullOrWhiteSpace(txtMaKhoa.Text))
		//	{
		//		MessageBox.Show("Bạn chưa nhập mã khóa học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
		//		txtMaKhoa.Focus();
		//		return false; 
		//	}
		//	if (string.IsNullOrWhiteSpace(txtTenKhoa.Text))
		//	{
		//		MessageBox.Show("Bạn chưa nhập tên khóa học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
		//		txtTenKhoa.Focus();
		//		return false;
		//	}
		//}
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
