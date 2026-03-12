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
    public partial class frmKhoa : Form
    {
        private QuanLySvContext db = new QuanLySvContext();

        public frmKhoa()
        {
            InitializeComponent();
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
        }

        private void LoadDanhSach()
        {
            var ds = db.Khoas.Select(
                    k => new
                    {
                        MaKhoa = k.MaKhoa.Trim(),
                        TenKhoa = k.TenKhoa.Trim()
                    }
                ).ToList();
            dgvKhoa.DataSource = ds;
            if (dgvKhoa.Columns.Count > 0)
            {
                dgvKhoa.Columns["MaKhoa"].HeaderText = "Mã khoa";
                dgvKhoa.Columns["TenKhoa"].HeaderText = "Tên khoa";
                dgvKhoa.Columns["MaKhoa"].Width = 100;
                dgvKhoa.Columns["TenKhoa"].Width = 300;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKhoa.Text) || string.IsNullOrEmpty(txtTenKhoa.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ mã khoa và tên khoa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trùng mã
            string maKhoa = txtMaKhoa.Text.Trim().ToUpper();
            if (db.Khoas.Any(k => k.MaKhoa.Trim() == maKhoa))
            {
                MessageBox.Show("Mã khoa đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.Khoas.Add(new Khoa
            {
                MaKhoa = maKhoa,
                TenKhoa = txtTenKhoa.Text.Trim()
            });

            db.SaveChanges();

            LoadDanhSach();
            LamMoi();
            MessageBox.Show("Thêm khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void LamMoi()
        {
            txtMaKhoa.Clear(); txtTenKhoa.Clear(); txtMaKhoa.Focus();
        }

        private void dgvKhoa_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKhoa.CurrentRow == null) return;
            txtMaKhoa.Text = dgvKhoa.CurrentRow.Cells["MaKhoa"].Value?.ToString();
            txtTenKhoa.Text = dgvKhoa.CurrentRow.Cells["TenKhoa"].Value?.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text)) return;

            string maKhoa = txtMaKhoa.Text.Trim();
            Khoa? khoa = db.Khoas.FirstOrDefault(k => k.MaKhoa.Trim() == maKhoa);
            if (khoa == null) { MessageBox.Show("Không tìm thấy Khoa!"); return; }

            khoa.TenKhoa = txtTenKhoa.Text.Trim();
            db.SaveChanges();
            LoadDanhSach();
            MessageBox.Show("Cập nhật thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text)) return;

            string ma = txtMaKhoa.Text.Trim();

            // Kiểm tra có sinh viên thuộc khoa này không — tránh lỗi FK
            bool coSV = db.SinhViens.Any(sv => sv.MaKhoa.Trim() == ma);
            if (coSV)
            {
                MessageBox.Show($"Không thể xóa! Khoa '{txtTenKhoa.Text}' còn sinh viên đang theo học.",
                                "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var cf = MessageBox.Show($"Xóa khoa '{txtTenKhoa.Text}'?", "Xác nhận",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cf != DialogResult.Yes) return;

            Khoa? khoa = db.Khoas.FirstOrDefault(k => k.MaKhoa.Trim() == ma);
            if (khoa != null) { db.Khoas.Remove(khoa); db.SaveChanges(); }
            LoadDanhSach(); LamMoi();
            MessageBox.Show("Xóa thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
            LoadDanhSach();
        }
    }
}
