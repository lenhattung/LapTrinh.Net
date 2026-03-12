namespace Lab08_QuanLySV.Models
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            menuStrip1       = new MenuStrip();
            // Menu: Hệ thống
            mnuHeThong       = new ToolStripMenuItem();
            mnuThoat         = new ToolStripMenuItem();
            // Menu: Chức năng
            mnuChucNang      = new ToolStripMenuItem();
            mnuSinhVien      = new ToolStripMenuItem();
            mnuKhoa          = new ToolStripMenuItem();
            mnuMonHoc        = new ToolStripMenuItem();
            sep1             = new ToolStripSeparator();
            mnuNhapDiem      = new ToolStripMenuItem();
            mnuKetQua        = new ToolStripMenuItem();
            // Menu: Hỗ trợ
            mnuHoTro         = new ToolStripMenuItem();
            mnuCascade       = new ToolStripMenuItem();
            mnuTileH         = new ToolStripMenuItem();
            mnuTileV         = new ToolStripMenuItem();
            sep2             = new ToolStripSeparator();
            mnuDongTat       = new ToolStripMenuItem();
            // ToolStrip
            toolStrip1       = new ToolStrip();
            tsbSinhVien      = new ToolStripButton();
            tsbKhoa          = new ToolStripButton();
            tsbMonHoc        = new ToolStripButton();
            tsbNhapDiem      = new ToolStripButton();
            tsbKetQua        = new ToolStripButton();
            tsbSep1          = new ToolStripSeparator();
            tsbThoat         = new ToolStripButton();

            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();

            // ── MenuStrip ────────────────────────────────────────────────────
            menuStrip1.Items.AddRange(new ToolStripItem[] {
                mnuHeThong, mnuChucNang, mnuHoTro });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1024, 28);
            menuStrip1.TabIndex = 0;

            // Hệ thống
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuThoat });
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Text = "Hệ thống";

            mnuThoat.Name = "mnuThoat";
            mnuThoat.Text = "Thoát";
            mnuThoat.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuThoat.Click += menuThoat_Click;

            // Chức năng
            mnuChucNang.DropDownItems.AddRange(new ToolStripItem[] {
                mnuSinhVien, mnuKhoa, mnuMonHoc, sep1, mnuNhapDiem, mnuKetQua });
            mnuChucNang.Name = "mnuChucNang";
            mnuChucNang.Text = "Chức năng";

            mnuSinhVien.Name = "mnuSinhVien";
            mnuSinhVien.Text = "👤 Sinh viên";
            mnuSinhVien.Click += menuSinhVien_Click;

            mnuKhoa.Name = "mnuKhoa";
            mnuKhoa.Text = "🏫 Khoa";
            mnuKhoa.Click += menuKhoa_Click;

            mnuMonHoc.Name = "mnuMonHoc";
            mnuMonHoc.Text = "📚 Môn học";
            mnuMonHoc.Click += menuMonHoc_Click;

            sep1.Name = "sep1";

            mnuNhapDiem.Name = "mnuNhapDiem";
            mnuNhapDiem.Text = "📝 Nhập điểm";
            mnuNhapDiem.Click += menuNhapDiem_Click;

            mnuKetQua.Name = "mnuKetQua";
            mnuKetQua.Text = "📊 Xem điểm";
            mnuKetQua.Click += menuKetQua_Click;

            // Hỗ trợ (sắp xếp cửa sổ)
            mnuHoTro.DropDownItems.AddRange(new ToolStripItem[] {
                mnuCascade, mnuTileH, mnuTileV, sep2, mnuDongTat });
            mnuHoTro.Name = "mnuHoTro";
            mnuHoTro.Text = "Hỗ trợ";

            mnuCascade.Name = "mnuCascade";
            mnuCascade.Text = "Xếp tầng (Cascade)";
            mnuCascade.Click += menuCascade_Click;

            mnuTileH.Name = "mnuTileH";
            mnuTileH.Text = "Xếp ngang (Tile Horizontal)";
            mnuTileH.Click += menuTileH_Click;

            mnuTileV.Name = "mnuTileV";
            mnuTileV.Text = "Xếp dọc (Tile Vertical)";
            mnuTileV.Click += menuTileV_Click;

            sep2.Name = "sep2";

            mnuDongTat.Name = "mnuDongTat";
            mnuDongTat.Text = "Đóng tất cả";
            mnuDongTat.Click += menuDongTat_Click;

            // ── ToolStrip ─────────────────────────────────────────────────────
            toolStrip1.Items.AddRange(new ToolStripItem[] {
                tsbSinhVien, tsbKhoa, tsbMonHoc, tsbNhapDiem, tsbKetQua,
                tsbSep1, tsbThoat });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1024, 42);
            toolStrip1.TabIndex = 1;

            tsbSinhVien.Font = new Font("Segoe UI", 10F);
            tsbSinhVien.Name = "tsbSinhVien";
            tsbSinhVien.Text = "👤 Sinh viên";
            tsbSinhVien.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbSinhVien.Padding = new Padding(6, 0, 6, 0);
            tsbSinhVien.Click += tsbSinhVien_Click;

            tsbKhoa.Font = new Font("Segoe UI", 10F);
            tsbKhoa.Name = "tsbKhoa";
            tsbKhoa.Text = "🏫 Khoa";
            tsbKhoa.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbKhoa.Padding = new Padding(6, 0, 6, 0);
            tsbKhoa.Click += tsbKhoa_Click;

            tsbMonHoc.Font = new Font("Segoe UI", 10F);
            tsbMonHoc.Name = "tsbMonHoc";
            tsbMonHoc.Text = "📚 Môn học";
            tsbMonHoc.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbMonHoc.Padding = new Padding(6, 0, 6, 0);
            tsbMonHoc.Click += tsbMonHoc_Click;

            tsbNhapDiem.Font = new Font("Segoe UI", 10F);
            tsbNhapDiem.Name = "tsbNhapDiem";
            tsbNhapDiem.Text = "📝 Nhập điểm";
            tsbNhapDiem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbNhapDiem.Padding = new Padding(6, 0, 6, 0);
            tsbNhapDiem.Click += tsbNhapDiem_Click;

            tsbKetQua.Font = new Font("Segoe UI", 10F);
            tsbKetQua.Name = "tsbKetQua";
            tsbKetQua.Text = "📊 Xem điểm";
            tsbKetQua.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbKetQua.Padding = new Padding(6, 0, 6, 0);
            tsbKetQua.Click += tsbKetQua_Click;

            tsbSep1.Name = "tsbSep1";

            tsbThoat.Font = new Font("Segoe UI", 10F);
            tsbThoat.Name = "tsbThoat";
            tsbThoat.Text = "➡️ Thoát";
            tsbThoat.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbThoat.Alignment = ToolStripItemAlignment.Right;
            tsbThoat.Padding = new Padding(6, 0, 6, 0);
            tsbThoat.Click += tsbThoat_Click;

            // ── frmMain ───────────────────────────────────────────────────────
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 700);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;          // ← quan trọng nhất
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "Quản lý sinh viên";
            WindowState = FormWindowState.Maximized;

            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuChucNang;
        private ToolStripMenuItem mnuSinhVien;
        private ToolStripMenuItem mnuKhoa;
        private ToolStripMenuItem mnuMonHoc;
        private ToolStripSeparator sep1;
        private ToolStripMenuItem mnuNhapDiem;
        private ToolStripMenuItem mnuKetQua;
        private ToolStripMenuItem mnuHoTro;
        private ToolStripMenuItem mnuCascade;
        private ToolStripMenuItem mnuTileH;
        private ToolStripMenuItem mnuTileV;
        private ToolStripSeparator sep2;
        private ToolStripMenuItem mnuDongTat;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbSinhVien;
        private ToolStripButton tsbKhoa;
        private ToolStripButton tsbMonHoc;
        private ToolStripButton tsbNhapDiem;
        private ToolStripButton tsbKetQua;
        private ToolStripSeparator tsbSep1;
        private ToolStripButton tsbThoat;
    }
}
