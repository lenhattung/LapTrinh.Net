using Lab08_QuanLySV.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab08_QuanLySV
{
    public partial class frmSinhVien : Form
    {
        // Khai báo DbContext — giống EF6, nhưng class trong folder Models/
        private QuanLySvContext db = new QuanLySvContext();

        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            LoadComboBoxGioiTinh();
            LoadComboBoxKhoa();
            LoadDanhSachSinhVien();
        }

        // ─── LOAD COMBOBOX GIỚI TÍNH ───
        private void LoadComboBoxGioiTinh()
        {
            cboGioiTinh.Items.Clear();
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");
            cboGioiTinh.SelectedIndex = 0;

        }
        // ─── LOAD COMBOBOX KHOA TỪ DATABASE ───
        private void LoadComboBoxKhoa()
        {
            // EF Core: dùng .Include() để load navigation property nếu cần
            cboKhoa.DataSource = db.Khoas.ToList();
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.ValueMember = "MaKhoa";
        }

        private void LoadDanhSachSinhVien()
        {
            // EF Core: dùng .Include() để load dữ liệu từ bảng liên quan (KHOA)
            var ds = db.SinhViens
                .Include(sv => sv.MaKhoaNavigation) // Load thông tin khoa
                .Select(sv => new
                {
                    sv.MaSo,
                    sv.HoTen,
                    NgaySinh = sv.NgaySinh.HasValue ? sv.NgaySinh.Value.ToString("dd/MM/yyyy") : "",
                    GioiTinh = sv.GioiTinh == true ? "Nam" : "Nữ",
                    sv.DiaChi,
                    sv.DienThoai,
                    TenKhoa = sv.MaKhoaNavigation != null ? sv.MaKhoaNavigation.TenKhoa.Trim() : ""
                }).ToList();

            dgvSinhVien.DataSource = ds;
            if (dgvSinhVien.Columns.Count > 0)
            {
                dgvSinhVien.Columns["MaSo"].HeaderText = "Mã số";
                dgvSinhVien.Columns["HoTen"].HeaderText = "Họ và tên";
                dgvSinhVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                dgvSinhVien.Columns["GioiTinh"].HeaderText = "Giới tính";
                dgvSinhVien.Columns["DiaChi"].HeaderText = "Địa chỉ";
                dgvSinhVien.Columns["DienThoai"].HeaderText = "Điện thoại";
                dgvSinhVien.Columns["TenKhoa"].HeaderText = "Khoa";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // ── Validate ──
            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );
                txtHoTen.Focus();
                return;
            }

            // ── Tạo object SinhVien — KHÔNG set MaSo (IDENTITY tự tăng) ──
            SinhVien svMoi = new SinhVien
            {
                HoTen = txtHoTen.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = cboGioiTinh.SelectedItem.ToString() == "Nam",
                DiaChi = txtDiaChi.Text.Trim(),
                DienThoai = int.TryParse(txtDienThoai.Text, out int sdt) ? sdt : null,
                MaKhoa = cboKhoa.SelectedValue?.ToString()
            };

            db.SinhViens.Add(svMoi);
            db.SaveChanges();

            LoadDanhSachSinhVien();

            MessageBox.Show("Thêm sinh viên thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow == null) return;
            DataGridViewRow row = dgvSinhVien.CurrentRow;

            lblMaSo.Text = row.Cells["MaSo"].Value?.ToString();
            txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
            txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
            txtDienThoai.Text = row.Cells["DienThoai"].Value?.ToString();

            string? ns = row.Cells["NgaySinh"].Value?.ToString();
            if (DateTime.TryParseExact(ns, "dd/MM/yyyy",
                null, System.Globalization.DateTimeStyles.None, out DateTime ngay))
                dtpNgaySinh.Value = ngay;

            cboGioiTinh.SelectedItem = row.Cells["GioiTinh"].Value?.ToString() == "Nam" ? "Nam" : "Nữ";

            string? tenKhoa = row.Cells["TenKhoa"].Value?.ToString().Trim();
            foreach (Khoa k in cboKhoa.Items)
                if (k.TenKhoa.Trim() == tenKhoa) { cboKhoa.SelectedItem = k; break; }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(lblMaSo.Text, out int maSo))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!"); return;
            }

            SinhVien? sv = db.SinhViens.Find(maSo);

            if (sv == null)
            {
                MessageBox.Show("Không tìm thấy!"); return;
            }

            sv.HoTen = txtHoTen.Text.Trim();
            sv.NgaySinh = dtpNgaySinh.Value;
            sv.GioiTinh = cboGioiTinh.SelectedItem.ToString() == "Nam";
            sv.DiaChi = txtDiaChi.Text.Trim();
            sv.DienThoai = int.TryParse(txtDienThoai.Text, out int sdt) ? sdt : null;
            sv.MaKhoa = cboKhoa.SelectedValue?.ToString();

            db.SaveChanges();
            LoadDanhSachSinhVien();
            MessageBox.Show("Cập nhật sinh viên thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(lblMaSo.Text, out int maSo))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!"); return;
            }

            var cf = MessageBox.Show(
            $"Xóa sinh viên: {txtHoTen.Text}?\nLưu ý: điểm của SV này cũng bị xóa!",
            "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (cf != DialogResult.Yes) return;

            // Bắt buộc xóa KetQua trước (ràng buộc FK)
            var kqs = db.KetQuas.Where(kq => kq.MaSo == maSo).ToList();
            db.KetQuas.RemoveRange(kqs);

            SinhVien? sv = db.SinhViens.Find(maSo);
            if (sv != null) db.SinhViens.Remove(sv);

            db.SaveChanges();
            LoadDanhSachSinhVien();
            MessageBox.Show("Xóa thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void LamMoiForm()
        {
            lblMaSo.Text = "";
            txtHoTen.Clear(); txtDiaChi.Clear(); txtDienThoai.Clear();
            txtTimKiem.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            cboGioiTinh.SelectedIndex = 0;
            if (cboKhoa.Items.Count > 0) cboKhoa.SelectedIndex = 0;
            txtHoTen.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string kw = txtTimKiem.Text.Trim().ToLower();
            var kq = db.SinhViens
            .Include(sv => sv.MaKhoaNavigation)
            .Where(sv => sv.HoTen.ToLower().Contains(kw)
                       || (sv.DiaChi != null && sv.DiaChi.ToLower().Contains(kw)))
            .Select(sv => new
            {
                sv.MaSo,
                sv.HoTen,
                NgaySinh = sv.NgaySinh.HasValue
                           ? sv.NgaySinh.Value.ToString("dd/MM/yyyy") : "",
                GioiTinh = sv.GioiTinh == true ? "Nam" : "Nữ",
                sv.DiaChi,
                sv.DienThoai,
                TenKhoa = sv.MaKhoaNavigation != null
                          ? sv.MaKhoaNavigation.TenKhoa.Trim() : ""
            }).ToList();

            dgvSinhVien.DataSource = kq;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
            LoadDanhSachSinhVien();
        }
    }
}
