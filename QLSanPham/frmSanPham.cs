using Microsoft.EntityFrameworkCore;
using QLSanPham.Models;
namespace QLSanPham
{
    public partial class frmSanPham : Form
    {
        QL_sanPhamContext db = new QL_sanPhamContext();
        bool them;
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            cboLoai.DataSource = db.LoaiSps.ToList();
            cboLoai.DisplayMember = "TenLoai";
            cboLoai.ValueMember = "MaLoai";
            LoadData();
            BinhThuong();
        }

        void LoadData()
        {
            dgvSanPham.DataSource = db.SanPhams.AsNoTracking()
            .Select(s => new
            {
                s.MaSp,
                s.TenSp,
                s.MaLoai,
                s.DonGia,
                s.SoLuong,
                s.NgayNhap,
                s.TrangThai,
                TenLoai = s.MaLoaiNavigation.TenLoai
            }).ToList();
        }

        void BinhThuong()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            KhoaONhap(false);
            dgvSanPham.Enabled = true;
        }

        void KhoaONhap(bool b)
        {
            txtMaSP.Enabled = !b;
            txtTenSP.Enabled = !b;
            cboLoai.Enabled = !b;
            txtDonGia.Enabled = !b;
            numSoLuong.Enabled = !b;
            dtpNgayNhap.Enabled = !b;
            grbTrangThai.Enabled = !b;
        }

        void XoaTrang()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            numSoLuong.Value = 1;
            dtpNgayNhap.Value = DateTime.Today;
            cboLoai.SelectedIndex = -1;
            radConHang.Checked = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //viết code nhấn nút thêm cho tôi
            them = true;
            XoaTrang();
            DatTrangThai(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        void DatTrangThai(bool nhap)
        {
            btnThem.Enabled = !nhap;
            btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = nhap;
            txtMaSP.Enabled = nhap;
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy dữ liệu từ dòng được chọn và hiển thị lên các điều khiển nhập liệu
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];
                txtMaSP.Text = row.Cells["MaSp"].Value.ToString();
                txtTenSP.Text = row.Cells["TenSp"].Value.ToString();
                cboLoai.SelectedValue = row.Cells["MaLoai"].Value.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
                numSoLuong.Value = Convert.ToInt32(row.Cells["SoLuong"].Value);
                dtpNgayNhap.Value = Convert.ToDateTime(row.Cells["NgayNhap"].Value);
                string trangThai = row.Cells["TrangThai"].Value.ToString();
                if (trangThai == "Còn hàng")
                    radConHang.Checked = true;
                else
                    radHetHang.Checked = true;
            }
        }
    }
}