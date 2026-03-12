using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Lab08_QuanLySV.Models
{
    public partial class frmKetQua : Form
    {
        private QuanLySvContext db = new QuanLySvContext();

        public frmKetQua() { InitializeComponent(); }

        private void frmKetQua_Load(object sender, EventArgs e)
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

        // ── XEM KẾT QUẢ ──────────────────────────────────────────────────────
        private void btnXem_Click(object sender, EventArgs e)
        {
            if (cboSinhVien.SelectedValue == null) return;
            int maSo = (int)cboSinhVien.SelectedValue;

            var ds = db.KetQuas
                .Include(kq => kq.MaMhNavigation)
                .Where(kq => kq.MaSo == maSo)
                .Select(kq => new {
                    TenMH   = kq.MaMhNavigation.TenMh.Trim(),
                    SoTiet  = kq.MaMhNavigation.SoTiet,
                    kq.Diem,
                    XepLoai = kq.Diem >= 9 ? "Xuất sắc"
                            : kq.Diem >= 7 ? "Giỏi"
                            : kq.Diem >= 5 ? "Trung bình" : "Yếu"
                })
                .OrderBy(x => x.TenMH)
                .ToList();

            dgvKetQua.DataSource = ds;

            if (dgvKetQua.Columns.Count > 0)
            {
                dgvKetQua.Columns["TenMH"].HeaderText   = "Môn học";
                dgvKetQua.Columns["SoTiet"].HeaderText  = "Số tiết";
                dgvKetQua.Columns["Diem"].HeaderText    = "Điểm";
                dgvKetQua.Columns["XepLoai"].HeaderText = "Xếp loại";
                dgvKetQua.Columns["TenMH"].Width   = 300;
                dgvKetQua.Columns["SoTiet"].Width  = 80;
                dgvKetQua.Columns["Diem"].Width    = 70;
                dgvKetQua.Columns["XepLoai"].Width = 110;
            }

            // ── Tổng kết ──────────────────────────────────────────────────────
            if (ds.Count > 0)
            {
                double dtb = ds.Average(d => d.Diem ?? 0);

                string xepLoai;
                Color  mauSac;
                if      (dtb >= 9.0) { xepLoai = "Xuất sắc";  mauSac = Color.DarkOrange; }
                else if (dtb >= 7.0) { xepLoai = "Giỏi";      mauSac = Color.DarkGreen;  }
                else if (dtb >= 5.0) { xepLoai = "Trung bình";mauSac = Color.DarkBlue;   }
                else                 { xepLoai = "Yếu";        mauSac = Color.DarkRed;    }

                lblDTB.Text          = $"ĐTB: {dtb:F2}";
                lblSoMon.Text        = $"Môn đã học: {ds.Count}";
                lblXepLoai.Text      = $"Xếp loại: {xepLoai}";
                lblXepLoai.ForeColor = mauSac;
            }
            else
            {
                lblDTB.Text     = "Sinh viên chưa có điểm";
                lblSoMon.Text   = "";
                lblXepLoai.Text = "";
            }
        }

        // ── XUẤT CSV ──────────────────────────────────────────────────────────
        private void btnXuatCSV_Click(object sender, EventArgs e)
        {
            if (dgvKetQua.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu để xuất! Hãy bấm 'Xem kết quả' trước.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            using SaveFileDialog sfd = new SaveFileDialog
            {
                Filter      = "CSV files (*.csv)|*.csv",
                FileName    = $"KetQua_{cboSinhVien.Text.Split('—')[0].Trim()}_{DateTime.Now:yyyyMMdd}.csv",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };

            if (sfd.ShowDialog() != DialogResult.OK) return;

            using StreamWriter sw = new StreamWriter(sfd.FileName, false,
                System.Text.Encoding.UTF8);

            // BOM UTF-8 để Excel đọc được tiếng Việt
            sw.Write("\uFEFF");
            sw.WriteLine("Môn học,Số tiết,Điểm,Xếp loại");

            foreach (DataGridViewRow row in dgvKetQua.Rows)
            {
                if (row.IsNewRow) continue;
                string tenMH   = row.Cells["TenMH"].Value?.ToString()   ?? "";
                string soTiet  = row.Cells["SoTiet"].Value?.ToString()  ?? "";
                string diem    = row.Cells["Diem"].Value?.ToString()    ?? "";
                string xepLoai = row.Cells["XepLoai"].Value?.ToString() ?? "";
                sw.WriteLine($"{tenMH},{soTiet},{diem},{xepLoai}");
            }

            // Thêm dòng tổng kết cuối file
            sw.WriteLine();
            sw.WriteLine($"Sinh viên: {cboSinhVien.Text}");
            sw.WriteLine($"{lblDTB.Text},{lblSoMon.Text},{lblXepLoai.Text}");

            MessageBox.Show($"Xuất file thành công!\n{sfd.FileName}",
                "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
