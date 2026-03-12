using System;
using System.Windows.Forms;

namespace Lab08_QuanLySV.Models
{
    public partial class frmMain : Form
    {
        public frmMain() { InitializeComponent(); }

        // ── HÀM DÙNG CHUNG: mở Form con trong MDI ────────────────────────────
        // Nếu Form đó đã mở → focus, chưa mở → tạo mới
        private void MoFormCon(Form formCon)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == formCon.GetType())
                {
                    f.Activate();
                    return;
                }
            }
            formCon.MdiParent = this;
            formCon.Show();
        }

        // ── MENU & TOOLBAR: Sinh viên ─────────────────────────────────────────
        private void menuSinhVien_Click(object sender, EventArgs e) =>
            MoFormCon(new frmSinhVien());

        private void tsbSinhVien_Click(object sender, EventArgs e) =>
            MoFormCon(new frmSinhVien());

        // ── MENU & TOOLBAR: Khoa ──────────────────────────────────────────────
        private void menuKhoa_Click(object sender, EventArgs e) =>
            MoFormCon(new frmKhoa());

        private void tsbKhoa_Click(object sender, EventArgs e) =>
            MoFormCon(new frmKhoa());

        // ── MENU & TOOLBAR: Môn học ───────────────────────────────────────────
        private void menuMonHoc_Click(object sender, EventArgs e) =>
            MoFormCon(new frmMon());

        private void tsbMonHoc_Click(object sender, EventArgs e) =>
            MoFormCon(new frmMon());

        // ── MENU & TOOLBAR: Nhập điểm ────────────────────────────────────────
        private void menuNhapDiem_Click(object sender, EventArgs e) =>
            MoFormCon(new frmNhapDiem());

        private void tsbNhapDiem_Click(object sender, EventArgs e) =>
            MoFormCon(new frmNhapDiem());

        // ── MENU & TOOLBAR: Xem điểm / Kết quả ──────────────────────────────
        private void menuKetQua_Click(object sender, EventArgs e) =>
            MoFormCon(new frmKetQua());

        private void tsbKetQua_Click(object sender, EventArgs e) =>
            MoFormCon(new frmKetQua());

        // ── MENU & TOOLBAR: Thoát ─────────────────────────────────────────────
        private void menuThoat_Click(object sender, EventArgs e) => Thoat();

        private void tsbThoat_Click(object sender, EventArgs e) => Thoat();

        private void Thoat()
        {
            var cf = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cf == DialogResult.Yes) Application.Exit();
        }

        // ── MENU: Sắp xếp cửa sổ con ─────────────────────────────────────────
        private void menuCascade_Click(object sender, EventArgs e) =>
            LayoutMdi(MdiLayout.Cascade);

        private void menuTileH_Click(object sender, EventArgs e) =>
            LayoutMdi(MdiLayout.TileHorizontal);

        private void menuTileV_Click(object sender, EventArgs e) =>
            LayoutMdi(MdiLayout.TileVertical);

        private void menuDongTat_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren) f.Close();
        }
    }
}
