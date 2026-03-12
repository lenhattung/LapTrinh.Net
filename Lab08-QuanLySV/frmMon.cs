using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Lab08_QuanLySV.Models
{
    public partial class frmMon : Form
    {
        private QuanLySvContext db = new QuanLySvContext();

        public frmMon() { InitializeComponent(); }

        private void frmMon_Load(object sender, EventArgs e) => LoadDanhSach();

        // ── LOAD DANH SÁCH ────────────────────────────────────────────────────
        private void LoadDanhSach(string keyword = "")
        {
            var query = db.Mons.AsQueryable();

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                string kw = keyword.Trim().ToLower();
                query = query.Where(m =>
                    m.TenMh.ToLower().Contains(kw) ||
                    m.MaMh.ToLower().Contains(kw));
            }

            var ds = query.Select(m => new {
                MaMh   = m.MaMh.Trim(),
                TenMh  = m.TenMh.Trim(),
                m.SoTiet
            }).ToList();

            dgvMon.DataSource = ds;

            if (dgvMon.Columns.Count > 0)
            {
                dgvMon.Columns["MaMh"].HeaderText   = "Mã môn";
                dgvMon.Columns["TenMh"].HeaderText  = "Tên môn học";
                dgvMon.Columns["SoTiet"].HeaderText = "Số tiết";
                dgvMon.Columns["MaMh"].Width   = 100;
                dgvMon.Columns["TenMh"].Width  = 300;
                dgvMon.Columns["SoTiet"].Width = 100;
            }
        }

        // ── CHỌN HÀNG → ĐIỀN VÀO FORM ────────────────────────────────────────
        private void dgvMon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMon.CurrentRow == null) return;
            txtMaMh.Text  = dgvMon.CurrentRow.Cells["MaMh"].Value?.ToString();
            txtTenMh.Text = dgvMon.CurrentRow.Cells["TenMh"].Value?.ToString();
            if (int.TryParse(dgvMon.CurrentRow.Cells["SoTiet"].Value?.ToString(), out int soTiet))
                nudSoTiet.Value = soTiet;
        }

        // ── TÌM KIẾM ──────────────────────────────────────────────────────────
        private void btnTimKiem_Click(object sender, EventArgs e) =>
            LoadDanhSach(txtTimKiem.Text);

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) LoadDanhSach(txtTimKiem.Text);
        }

        // ── THÊM ──────────────────────────────────────────────────────────────
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMh.Text) || string.IsNullOrWhiteSpace(txtTenMh.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ mã môn và tên môn học!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            string maMh = txtMaMh.Text.Trim().ToUpper();

            if (db.Mons.Any(m => m.MaMh.Trim() == maMh))
            {
                MessageBox.Show("Mã môn học đã tồn tại!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            db.Mons.Add(new Mon {
                MaMh   = maMh,
                TenMh  = txtTenMh.Text.Trim(),
                SoTiet = (int)nudSoTiet.Value
            });
            db.SaveChanges();
            LoadDanhSach();
            LamMoi();
            MessageBox.Show("Thêm môn học thành công!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ── SỬA ───────────────────────────────────────────────────────────────
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMh.Text)) return;

            string maMh = txtMaMh.Text.Trim();
            Mon? mon = db.Mons.FirstOrDefault(m => m.MaMh.Trim() == maMh);
            if (mon == null)
            {
                MessageBox.Show("Không tìm thấy môn học!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            mon.TenMh  = txtTenMh.Text.Trim();
            mon.SoTiet = (int)nudSoTiet.Value;
            db.SaveChanges();
            LoadDanhSach();
            MessageBox.Show("Cập nhật thành công!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ── XÓA ───────────────────────────────────────────────────────────────
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMh.Text)) return;

            string maMh = txtMaMh.Text.Trim();

            // Kiểm tra FK: môn đã có điểm chưa
            if (db.KetQuas.Any(kq => kq.MaMh.Trim() == maMh))
            {
                MessageBox.Show($"Không thể xóa! Môn '{txtTenMh.Text}' đã có điểm số trong hệ thống.",
                    "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            var cf = MessageBox.Show($"Xóa môn học '{txtTenMh.Text}'?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cf != DialogResult.Yes) return;

            Mon? mon = db.Mons.FirstOrDefault(m => m.MaMh.Trim() == maMh);
            if (mon != null) { db.Mons.Remove(mon); db.SaveChanges(); }

            LoadDanhSach();
            LamMoi();
            MessageBox.Show("Xóa thành công!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ── LÀM MỚI ───────────────────────────────────────────────────────────
        private void LamMoi()
        {
            txtMaMh.Clear();
            txtTenMh.Clear();
            nudSoTiet.Value = 45;
            txtTimKiem.Clear();
            txtMaMh.Focus();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
            LoadDanhSach();
        }
    }
}
