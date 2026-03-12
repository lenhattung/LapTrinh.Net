using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.EntityFrameworkCore;

namespace Lab08_QuanLySV.Models
{
    public partial class frmNhapDiem : Form
    {
        private QuanLySvContext db = new QuanLySvContext();

        public frmNhapDiem() { InitializeComponent(); }

        private void frmNhapDiem_Load(object sender, EventArgs e)
        {
            LoadComboSinhVien();
            LoadComboMonHoc();
            LoadDanhSachDiem();
        }

        // ── LOAD COMBO ────────────────────────────────────────────────────────
        private void LoadComboSinhVien()
        {
            var ds = db.SinhViens
                .Include(sv => sv.MaKhoaNavigation)
                .Select(sv => new {
                    sv.MaSo,
                    HienThi = sv.HoTen + " — " + sv.MaKhoaNavigation.TenKhoa.Trim()
                }).ToList();
            cboSinhVien.DataSource    = ds;
            cboSinhVien.DisplayMember = "HienThi";
            cboSinhVien.ValueMember   = "MaSo";
        }

        private void LoadComboMonHoc()
        {
            var ds = db.Mons
                .Select(m => new {
                    MaMH    = m.MaMh.Trim(),
                    HienThi = m.TenMh.Trim() + " (" + m.SoTiet + " tiết)"
                }).ToList();
            cboMonHoc.DataSource    = ds;
            cboMonHoc.DisplayMember = "HienThi";
            cboMonHoc.ValueMember   = "MaMH";
        }

        // ── LOAD DANH SÁCH ĐIỂM (có search) ──────────────────────────────────
        private void LoadDanhSachDiem(string keyword = "")
        {
            var query = db.KetQuas
                .Include(kq => kq.MaSoNavigation)
                .Include(kq => kq.MaMhNavigation)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                string kw = keyword.Trim().ToLower();
                query = query.Where(kq =>
                    kq.MaSoNavigation.HoTen.ToLower().Contains(kw) ||
                    kq.MaMhNavigation.TenMh.ToLower().Contains(kw));
            }

            var ds = query.Select(kq => new {
                MaSo    = kq.MaSo,
                HoTen   = kq.MaSoNavigation.HoTen,
                TenMH   = kq.MaMhNavigation.TenMh.Trim(),
                kq.Diem,
                XepLoai = kq.Diem >= 9 ? "Xuất sắc"
                        : kq.Diem >= 7 ? "Giỏi"
                        : kq.Diem >= 5 ? "Trung bình" : "Yếu"
            }).OrderBy(x => x.HoTen).ThenBy(x => x.TenMH).ToList();

            dgvDiem.DataSource = ds;

            if (dgvDiem.Columns.Count > 0)
            {
                dgvDiem.Columns["MaSo"].HeaderText    = "Mã SV";
                dgvDiem.Columns["HoTen"].HeaderText   = "Họ tên";
                dgvDiem.Columns["TenMH"].HeaderText   = "Môn học";
                dgvDiem.Columns["Diem"].HeaderText    = "Điểm";
                dgvDiem.Columns["XepLoai"].HeaderText = "Xếp loại";
                dgvDiem.Columns["MaSo"].Width    = 65;
                dgvDiem.Columns["HoTen"].Width   = 220;
                dgvDiem.Columns["TenMH"].Width   = 200;
                dgvDiem.Columns["Diem"].Width    = 65;
                dgvDiem.Columns["XepLoai"].Width = 100;
            }

            // Hiện ĐTB toàn bộ
            if (ds.Count > 0)
            {
                double dtb = ds.Average(d => d.Diem ?? 0);
                lblDTB.Text = $"Điểm trung bình toàn khóa: {dtb:F2}";
            }
            else lblDTB.Text = "";
        }

        // ── CHỌN HÀNG → ĐIỀN VÀO COMBO & NUMDIEM ────────────────────────────
        private void dgvDiem_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDiem.CurrentRow == null) return;

            if (int.TryParse(dgvDiem.CurrentRow.Cells["MaSo"].Value?.ToString(), out int maSo))
                foreach (var item in cboSinhVien.Items)
                {
                    var p = item.GetType().GetProperty("MaSo");
                    if (p != null && (int)p.GetValue(item)! == maSo)
                    { cboSinhVien.SelectedItem = item; break; }
                }

            string tenMH = dgvDiem.CurrentRow.Cells["TenMH"].Value?.ToString()?.Trim() ?? "";
            foreach (var item in cboMonHoc.Items)
            {
                var p = item.GetType().GetProperty("HienThi");
                if (p != null && p.GetValue(item)!.ToString()!.StartsWith(tenMH))
                { cboMonHoc.SelectedItem = item; break; }
            }

            if (int.TryParse(dgvDiem.CurrentRow.Cells["Diem"].Value?.ToString(), out int diem))
                nudDiem.Value = diem;
        }

        // ── TÌM KIẾM ─────────────────────────────────────────────────────────
        private void btnTimKiem_Click(object sender, EventArgs e) =>
            LoadDanhSachDiem(txtTimKiem.Text);

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) LoadDanhSachDiem(txtTimKiem.Text);
        }

        // ── LƯU ĐIỂM (thêm mới) ──────────────────────────────────────────────
        private void btnLuuDiem_Click(object sender, EventArgs e)
        {
            if (cboSinhVien.SelectedValue == null || cboMonHoc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Sinh viên và Môn học!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            int    maSo = (int)cboSinhVien.SelectedValue;
            string maMH = cboMonHoc.SelectedValue.ToString()!.Trim();
            int    diem = (int)nudDiem.Value;

            if (db.KetQuas.Any(kq => kq.MaSo == maSo && kq.MaMh.Trim() == maMH))
            {
                MessageBox.Show("Sinh viên này đã có điểm môn học!\nDùng 'Cập nhật' để thay đổi.",
                    "Đã tồn tại", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            db.KetQuas.Add(new KetQua { MaSo = maSo, MaMh = maMH.PadRight(6), Diem = diem });
            db.SaveChanges();
            LoadDanhSachDiem(txtTimKiem.Text);
            MessageBox.Show("Lưu điểm thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ── CẬP NHẬT ĐIỂM ────────────────────────────────────────────────────
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (cboSinhVien.SelectedValue == null || cboMonHoc.SelectedValue == null) return;

            int    maSo = (int)cboSinhVien.SelectedValue;
            string maMH = cboMonHoc.SelectedValue.ToString()!.Trim();

            KetQua? kq = db.KetQuas.FirstOrDefault(k =>
                k.MaSo == maSo && k.MaMh.Trim() == maMH);

            if (kq == null)
            {
                MessageBox.Show("Không tìm thấy bản ghi! Dùng 'Lưu điểm' để thêm mới.",
                    "Không tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            kq.Diem = (int)nudDiem.Value;
            db.SaveChanges();
            LoadDanhSachDiem(txtTimKiem.Text);
            MessageBox.Show("Cập nhật điểm thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ── XÓA ĐIỂM ─────────────────────────────────────────────────────────
        private void btnXoaDiem_Click(object sender, EventArgs e)
        {
            if (cboSinhVien.SelectedValue == null || cboMonHoc.SelectedValue == null) return;

            int    maSo   = (int)cboSinhVien.SelectedValue;
            string maMH   = cboMonHoc.SelectedValue.ToString()!.Trim();
            string tenSV  = cboSinhVien.Text.Split('—')[0].Trim();
            string tenMon = cboMonHoc.Text.Split('(')[0].Trim();

            var cf = MessageBox.Show($"Xóa điểm của '{tenSV}' môn '{tenMon}'?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cf != DialogResult.Yes) return;

            KetQua? kq = db.KetQuas.FirstOrDefault(k =>
                k.MaSo == maSo && k.MaMh.Trim() == maMH);
            if (kq == null) { MessageBox.Show("Không tìm thấy bản ghi điểm!"); return; }

            db.KetQuas.Remove(kq);
            db.SaveChanges();
            LoadDanhSachDiem(txtTimKiem.Text);
            LamMoi();
            MessageBox.Show("Xóa điểm thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ── LÀM MỚI ──────────────────────────────────────────────────────────
        private void LamMoi()
        {
            if (cboSinhVien.Items.Count > 0) cboSinhVien.SelectedIndex = 0;
            if (cboMonHoc.Items.Count > 0)   cboMonHoc.SelectedIndex   = 0;
            nudDiem.Value = 5;
            txtTimKiem.Clear();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
            LoadDanhSachDiem();
        }
    }
}
