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
    public partial class LopGD : Form
    {
        private static LopXL xuLy = new LopXL();
        public LopGD()
        {
            InitializeComponent();
        }

        private void LopGD_Load(object sender, EventArgs e)
        {
            hienThi(xuLy.layDanhSachLop());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LopDT lop = new LopDT();
            lop.MaLop = txtMaLop.Text;
            lop.TenLop = txtTenLop.Text;
            lop.GhiChu = txtGhiChu.Text;
            if (xuLy.TimKiem(lop.MaLop) != null)
            {
                MessageBox.Show("Trùng mã lớp ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            xuLy.Them(lop);
            hienThi(xuLy.layDanhSachLop());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            LopDT lop = new LopDT();
            lop.MaLop = txtMaLop.Text;
            lop.TenLop = txtTenLop.Text;
            lop.GhiChu = txtGhiChu.Text;
            xuLy.Sua(lop);
            hienThi(xuLy.layDanhSachLop());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show("Bạn có muốn xóa lớp học này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ketQua == DialogResult.Yes)
            {
                foreach (ListViewItem lvi in lsvLop.SelectedItems)
                {
                    string maLop = lvi.SubItems[0].Text;
                    xuLy.Xoa(maLop);
                }
                hienThi(xuLy.layDanhSachLop());
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (xuLy.Luu())
            {
                MessageBox.Show("Lưu lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lưu lớp học không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lsvLop.SelectedItems)
            {
                string maLop = lvi.SubItems[0].Text;
                LopDT lop = xuLy.TimKiem(maLop);
                if(lop != null)
                {
                    txtMaLop.Text = lop.MaLop;
                    txtTenLop.Text = lop.TenLop;
                    txtGhiChu.Text = lop.GhiChu;
                    break;
                }
            }
        }

        private void hienThi(List<LopDT> danhSach)
        {
            lsvLop.Items.Clear();
            foreach(LopDT lop in danhSach)
            {
                ListViewItem lvi = new ListViewItem(lop.MaLop);
                lvi.SubItems.Add(lop.TenLop);
                lvi.SubItems.Add(lop.GhiChu);
                lsvLop.Items.Add(lvi);
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
