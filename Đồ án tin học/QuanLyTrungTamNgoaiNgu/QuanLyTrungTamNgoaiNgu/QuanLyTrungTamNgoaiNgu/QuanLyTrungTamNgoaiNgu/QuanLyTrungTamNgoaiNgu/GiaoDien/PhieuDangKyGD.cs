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
    public partial class PhieuDangKyGD : Form
    {
        private PhieuDangKyXL xl = new PhieuDangKyXL();
        public PhieuDangKyGD()
        {
            InitializeComponent();
        }
        private void hienThi(List<PhieuDangKyDT> danhsach)
        {
            lvdanhsach.Items.Clear();
            foreach (PhieuDangKyDT a in danhsach)
            {
                ListViewItem lvi = new ListViewItem(a.MaPDK);
                lvi.SubItems.Add(a.NgayLapPhieu.ToString("dd/MM/yyyy"));
                lvi.SubItems.Add(a.SoTien.ToString());
                lvdanhsach.Items.Add(lvi);
            }
        }
        private void hienThiPDK(PhieuDangKyDT pdk)
        {
            txtmaphieu.Text = pdk.MaPDK;
            dtpngaylap.Value = pdk.NgayLapPhieu;
            txtsotien.Text = pdk.SoTien.ToString();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            PhieuDangKyDT pdk = new PhieuDangKyDT();
            pdk.MaPDK = txtmaphieu.Text;
            pdk.NgayLapPhieu = dtpngaylap.Value;
            pdk.SoTien = double.Parse(txtsotien.Text);
            if (xl.tim(pdk.MaPDK) != null)
            {
                MessageBox.Show("Trùng mã phiếu đăng ký", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            xl.them(pdk);
            hienThi(xl.layDanhSachPhieuDangKy());
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn không thể chỉnh sửa ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //PhieuDangKyDT pdk = new PhieuDangKyDT();
            //pdk.MaPDK = txtmaphieu.Text;
            //pdk.NgayLapPhieu = dtpngaylap.Value;
            //pdk.SoTien = double.Parse(txtsotien.Text);
            //DialogResult result = MessageBox.Show("Bạn có muốn sửa?", " thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (result == DialogResult.Yes)
            //{
            //    xl.sua(pdk);
            //}
            //hienThi(xl.layDanhSachPhieuDangKy());
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn không thể xóa ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //foreach (ListViewItem lvi in lvdanhsach.SelectedItems)
            //{
            //    string maPDK = lvi.SubItems[0].Text;
            //    DialogResult result = MessageBox.Show("Bạn có muốn xóa?", " thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //    if (result == DialogResult.Yes)
            //    {

            //        xl.xoa(maPDK);
            //    }
            //}
            //hienThi(xl.layDanhSachPhieuDangKy());
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            PhieuDangKyDT pdk = new PhieuDangKyDT();
            List<PhieuDangKyDT> dsKetQua = new List<PhieuDangKyDT>();
            {
                if (xl.timTheoMa(txtnhapma.Text, ref pdk) == true)
                    hienThiPDK(pdk);
                else
                    MessageBox.Show("Không tìm thấy", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (xl.Luu())
            {
                MessageBox.Show("Lưu phiếu đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lưu phiếu đăng ký không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn thật sự có muốn thoát", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lvdanhsach_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvdanhsach.SelectedItems)
            {
                string maPDK = lvi.SubItems[0].Text;
                PhieuDangKyDT pdk = xl.tim(maPDK);

                if (pdk != null)
                {
                    txtmaphieu.Text = pdk.MaPDK;
                    dtpngaylap.Value = pdk.NgayLapPhieu;
                    txtsotien.Text = pdk.SoTien.ToString();
                }
            }
        }

        private void PhieuDangKyGD_Load(object sender, EventArgs e)
        {
            hienThi(xl.layDanhSachPhieuDangKy());
        }
    }
}
