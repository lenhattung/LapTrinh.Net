using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab08_QuanLySV.Models
{
    public partial class frmMon : Form
    {
        private QuanLySvContext db = new QuanLySvContext();

        public frmMon()
        {
            InitializeComponent();
        }

        private void frmMon_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
        }

        // ─── LOAD DANH SÁCH MÔN HỌC ───────────────────────────────────────────
        private void LoadDanhSach()
        {
            var ds = db.Mons.Select(
                m => new
                {
                    MaMh = m.MaMh.Trim(),
                    TenMh = m.TenMh.Trim(),
                    m.SoTiet
                }
            ).ToList();

            dgvMon.DataSource = ds;

            if (dgvMon.Columns.Count > 0)
            {
                dgvMon.Columns["MaMh"].HeaderText = "Mã môn";
                dgvMon.Columns["TenMh"].HeaderText = "Tên môn học";
                dgvMon.Columns["SoTiet"].HeaderText = "Số tiết";
                dgvMon.Columns["MaMh"].Width = 100;
                dgvMon.Columns["TenMh"].Width = 300;
                dgvMon.Columns["SoTiet"].Width = 100;
            }
        }

        // ─── CHỌN HÀNG → ĐIỀN VÀO FORM ───────────────────────────────────────
        private void dgvMon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMon.CurrentRow == null) return;

            txtMaMH.Text = dgvMon.CurrentRow.Cells["MaMh"].Value?.ToString();
            txtTenMH.Text = dgvMon.CurrentRow.Cells["TenMh"].Value?.ToString();

            if (int.TryParse(dgvMon.CurrentRow.Cells["SoTiet"].Value?.ToString(), out int soTiet))
                nudSoTiet.Value = soTiet;
        }

        // ─── TÌM KIẾM ─────────────────────────────────────────────────────────
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string kw = txtTimKiem.Text.Trim().ToLower();

            var ds = db.Mons
                .Where(m => m.TenMh.ToLower().Contains(kw)
                         || m.MaMh.ToLower().Contains(kw))
                .Select(m => new
                {
                    MaMh = m.MaMh.Trim(),
                    TenMh = m.TenMh.Trim(),
                    m.SoTiet
                })
                .ToList();

            dgvMon.DataSource = ds;
        }

        // ─── THÊM MÔN HỌC MỚI ────────────────────────────────────────────────
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaMH.Text) || string.IsNullOrEmpty(txtTenMH.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ mã môn và tên môn học!",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trùng mã môn
            string MaMh = txtMaMH.Text.Trim().ToUpper();
            if (db.Mons.Any(m => m.MaMh.Trim() == MaMh))
            {
                MessageBox.Show("Mã môn học đã tồn tại!",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.Mons.Add(new Mon
            {
                MaMh = MaMh,
                TenMh = txtTenMH.Text.Trim(),
                SoTiet = (int)nudSoTiet.Value
            });

            db.SaveChanges();
            LoadDanhSach();
            LamMoi();
            MessageBox.Show("Thêm môn học thành công!",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ─── SỬA MÔN HỌC ─────────────────────────────────────────────────────
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMH.Text)) return;

            string MaMh = txtMaMH.Text.Trim();
            Mon? mon = db.Mons.FirstOrDefault(m => m.MaMh.Trim() == MaMh);
            if (mon == null)
            {
                MessageBox.Show("Không tìm thấy môn học!",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            mon.TenMh = txtTenMH.Text.Trim();
            mon.SoTiet = (int)nudSoTiet.Value;
            db.SaveChanges();

            LoadDanhSach();
            MessageBox.Show("Cập nhật thành công!",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ─── XÓA MÔN HỌC ─────────────────────────────────────────────────────
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMH.Text)) return;

            string MaMh = txtMaMH.Text.Trim();

            // Kiểm tra môn học đã có điểm chưa — tránh lỗi FK
            bool coDiem = db.KetQuas.Any(kq => kq.MaMh.Trim() == MaMh);
            if (coDiem)
            {
                MessageBox.Show($"Không thể xóa! Môn '{txtTenMH.Text}' đã có điểm số trong hệ thống.",
                                "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var cf = MessageBox.Show($"Xóa môn học '{txtTenMH.Text}'?", "Xác nhận",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cf != DialogResult.Yes) return;

            Mon? mon = db.Mons.FirstOrDefault(m => m.MaMh.Trim() == MaMh);
            if (mon != null)
            {
                db.Mons.Remove(mon);
                db.SaveChanges();
            }

            LoadDanhSach();
            LamMoi();
            MessageBox.Show("Xóa thành công!",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ─── LÀM MỚI FORM ────────────────────────────────────────────────────
        private void LamMoi()
        {
            txtMaMH.Clear();
            txtTenMH.Clear();
            nudSoTiet.Value = 45;
            txtTimKiem.Clear();
            txtMaMH.Focus();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
            LoadDanhSach();
        }
    }
}