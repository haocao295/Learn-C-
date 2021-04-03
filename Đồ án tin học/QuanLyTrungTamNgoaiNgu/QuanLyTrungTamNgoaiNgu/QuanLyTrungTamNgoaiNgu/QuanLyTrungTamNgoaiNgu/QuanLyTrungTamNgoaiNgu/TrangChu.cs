using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTrungTamNgoaiNgu.GiaoDien;

namespace QuanLyTrungTamNgoaiNgu
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void tabMenuHocVien_Click(object sender, EventArgs e)
        {
            HocVienGD giaoDien = new HocVienGD();
            giaoDien.Show();
        }

        private void tabMenuLopHoc_Click(object sender, EventArgs e)
        {
            LopGD giaoDien = new LopGD();
            giaoDien.Show();
        }

        private void tabMenuKhoaHoc_Click(object sender, EventArgs e)
        {
            KhoaGD giaoDien = new KhoaGD();
            giaoDien.Show();
        }

        private void tabMenuPhieu_Click(object sender, EventArgs e)
        {
            PhieuDangKyGD giaoDien = new PhieuDangKyGD();
            giaoDien.Show();
        }

        private void tabMenuLopKhoa_Click(object sender, EventArgs e)
        {
            LopKhoaGD giaoDien = new LopKhoaGD();
            giaoDien.Show();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            TruyCapDuLieu.docFile("dulieu.dat");
        }
    }
}
