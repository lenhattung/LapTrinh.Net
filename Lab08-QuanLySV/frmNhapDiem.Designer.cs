namespace Lab08_QuanLySV.Models
{
    partial class frmNhapDiem
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
            lblSinhVien = new Label();
            lblMonHoc = new Label();
            lblDiem = new Label();
            cboSinhVien = new ComboBox();
            cboMonHoc = new ComboBox();
            nudDiem = new NumericUpDown();
            btnLuuDiem = new Button();
            btnCapNhat = new Button();
            btnXoaDiem = new Button();
            btnLamMoi = new Button();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            lblDTB = new Label();
            dgvDiem = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudDiem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDiem).BeginInit();
            SuspendLayout();
            // 
            // lblSinhVien
            // 
            lblSinhVien.AutoSize = true;
            lblSinhVien.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSinhVien.Location = new Point(80, 38);
            lblSinhVien.Name = "lblSinhVien";
            lblSinhVien.Size = new Size(111, 31);
            lblSinhVien.TabIndex = 0;
            lblSinhVien.Text = "Sinh viên:";
            // 
            // lblMonHoc
            // 
            lblMonHoc.AutoSize = true;
            lblMonHoc.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMonHoc.Location = new Point(80, 90);
            lblMonHoc.Name = "lblMonHoc";
            lblMonHoc.Size = new Size(109, 31);
            lblMonHoc.TabIndex = 1;
            lblMonHoc.Text = "Môn học:";
            // 
            // lblDiem
            // 
            lblDiem.AutoSize = true;
            lblDiem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiem.Location = new Point(80, 142);
            lblDiem.Name = "lblDiem";
            lblDiem.Size = new Size(73, 31);
            lblDiem.TabIndex = 2;
            lblDiem.Text = "Điểm:";
            // 
            // cboSinhVien
            // 
            cboSinhVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSinhVien.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboSinhVien.FormattingEnabled = true;
            cboSinhVien.Location = new Point(190, 33);
            cboSinhVien.Name = "cboSinhVien";
            cboSinhVien.Size = new Size(380, 39);
            cboSinhVien.TabIndex = 3;
            // 
            // cboMonHoc
            // 
            cboMonHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMonHoc.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboMonHoc.FormattingEnabled = true;
            cboMonHoc.Location = new Point(190, 85);
            cboMonHoc.Name = "cboMonHoc";
            cboMonHoc.Size = new Size(380, 39);
            cboMonHoc.TabIndex = 4;
            // 
            // nudDiem
            // 
            nudDiem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudDiem.Location = new Point(190, 137);
            nudDiem.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudDiem.Name = "nudDiem";
            nudDiem.Size = new Size(120, 38);
            nudDiem.TabIndex = 5;
            nudDiem.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // btnLuuDiem
            // 
            btnLuuDiem.BackColor = Color.FromArgb(21, 101, 192);
            btnLuuDiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLuuDiem.ForeColor = Color.White;
            btnLuuDiem.Location = new Point(17, 200);
            btnLuuDiem.Name = "btnLuuDiem";
            btnLuuDiem.Size = new Size(130, 52);
            btnLuuDiem.TabIndex = 6;
            btnLuuDiem.Text = "➕ Lưu điểm";
            btnLuuDiem.UseVisualStyleBackColor = false;
            btnLuuDiem.Click += btnLuuDiem_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.FromArgb(230, 81, 0);
            btnCapNhat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCapNhat.ForeColor = Color.White;
            btnCapNhat.Location = new Point(157, 200);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(130, 52);
            btnCapNhat.TabIndex = 7;
            btnCapNhat.Text = "✏️ Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXoaDiem
            // 
            btnXoaDiem.BackColor = Color.FromArgb(198, 40, 40);
            btnXoaDiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoaDiem.ForeColor = Color.White;
            btnXoaDiem.Location = new Point(297, 200);
            btnXoaDiem.Name = "btnXoaDiem";
            btnXoaDiem.Size = new Size(130, 52);
            btnXoaDiem.TabIndex = 8;
            btnXoaDiem.Text = "🗑️ Xóa điểm";
            btnXoaDiem.UseVisualStyleBackColor = false;
            btnXoaDiem.Click += btnXoaDiem_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(84, 110, 122);
            btnLamMoi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(437, 200);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(130, 52);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "🔄 Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTimKiem.Location = new Point(681, 156);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(95, 31);
            lblTimKiem.TabIndex = 10;
            lblTimKiem.Text = "Từ khóa";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(632, 208);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(190, 38);
            txtTimKiem.TabIndex = 11;
            txtTimKiem.KeyDown += txtTimKiem_KeyDown;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTimKiem.ForeColor = Color.Teal;
            btnTimKiem.Location = new Point(831, 202);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(73, 52);
            btnTimKiem.TabIndex = 12;
            btnTimKiem.Text = "🔍";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // lblDTB
            // 
            lblDTB.AutoSize = true;
            lblDTB.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDTB.ForeColor = Color.Blue;
            lblDTB.Location = new Point(17, 268);
            lblDTB.Name = "lblDTB";
            lblDTB.Size = new Size(0, 25);
            lblDTB.TabIndex = 13;
            // 
            // dgvDiem
            // 
            dgvDiem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiem.Location = new Point(11, 290);
            dgvDiem.Name = "dgvDiem";
            dgvDiem.ReadOnly = true;
            dgvDiem.RowHeadersWidth = 51;
            dgvDiem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDiem.Size = new Size(901, 310);
            dgvDiem.TabIndex = 14;
            dgvDiem.SelectionChanged += dgvDiem_SelectionChanged;
            // 
            // frmNhapDiem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 620);
            Controls.Add(dgvDiem);
            Controls.Add(lblDTB);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(lblTimKiem);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoaDiem);
            Controls.Add(btnCapNhat);
            Controls.Add(btnLuuDiem);
            Controls.Add(nudDiem);
            Controls.Add(cboMonHoc);
            Controls.Add(cboSinhVien);
            Controls.Add(lblDiem);
            Controls.Add(lblMonHoc);
            Controls.Add(lblSinhVien);
            Name = "frmNhapDiem";
            Text = "frmNhapDiem — Nhập Điểm";
            Load += frmNhapDiem_Load;
            ((System.ComponentModel.ISupportInitialize)nudDiem).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDiem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSinhVien;
        private Label lblMonHoc;
        private Label lblDiem;
        private ComboBox cboSinhVien;
        private ComboBox cboMonHoc;
        private NumericUpDown nudDiem;
        private Button btnLuuDiem;
        private Button btnCapNhat;
        private Button btnXoaDiem;
        private Button btnLamMoi;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Label lblDTB;
        private DataGridView dgvDiem;
    }
}
