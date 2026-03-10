namespace Lab08_QuanLySV
{
    partial class frmSinhVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtHoTen = new TextBox();
            txtDienThoai = new TextBox();
            txtDiaChi = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            cboGioiTinh = new ComboBox();
            cboKhoa = new ComboBox();
            btnThem = new Button();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnTimKiem = new Button();
            lblMaSo = new Label();
            dgvSinhVien = new DataGridView();
            txtTimKiem = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 44);
            label1.Name = "label1";
            label1.Size = new Size(76, 31);
            label1.TabIndex = 0;
            label1.Text = "Mã số";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 89);
            label2.Name = "label2";
            label2.Size = new Size(82, 31);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 179);
            label3.Name = "label3";
            label3.Size = new Size(102, 31);
            label3.TabIndex = 3;
            label3.Text = "Giới tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 134);
            label4.Name = "label4";
            label4.Size = new Size(116, 31);
            label4.TabIndex = 2;
            label4.Text = "Ngày sinh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(467, 133);
            label6.Name = "label6";
            label6.Size = new Size(102, 31);
            label6.TabIndex = 6;
            label6.Text = "Mã khoa";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(467, 83);
            label7.Name = "label7";
            label7.Size = new Size(119, 31);
            label7.TabIndex = 5;
            label7.Text = "Điện thoại";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(467, 33);
            label8.Name = "label8";
            label8.Size = new Size(84, 31);
            label8.TabIndex = 4;
            label8.Text = "Địa chỉ";
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoTen.Location = new Point(124, 86);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(304, 38);
            txtHoTen.TabIndex = 9;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDienThoai.Location = new Point(591, 78);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(304, 38);
            txtDienThoai.TabIndex = 11;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiaChi.Location = new Point(591, 30);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(304, 38);
            txtDiaChi.TabIndex = 10;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(164, 133);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(259, 38);
            dtpNgaySinh.TabIndex = 12;
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Location = new Point(155, 179);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(270, 39);
            cboGioiTinh.TabIndex = 13;
            // 
            // cboKhoa
            // 
            cboKhoa.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboKhoa.FormattingEnabled = true;
            cboKhoa.Location = new Point(591, 133);
            cboKhoa.Name = "cboKhoa";
            cboKhoa.Size = new Size(304, 39);
            cboKhoa.TabIndex = 14;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.Green;
            btnThem.Location = new Point(45, 239);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(104, 71);
            btnThem.TabIndex = 15;
            btnThem.Text = "➕ Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLamMoi.ForeColor = Color.Blue;
            btnLamMoi.Location = new Point(388, 239);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(153, 71);
            btnLamMoi.TabIndex = 16;
            btnLamMoi.Text = "🔄 Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(275, 239);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(104, 71);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "🗑️ Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSua.ForeColor = Color.Olive;
            btnSua.Location = new Point(160, 239);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(104, 71);
            btnSua.TabIndex = 18;
            btnSua.Text = "✏️ Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTimKiem.ForeColor = Color.Teal;
            btnTimKiem.Location = new Point(838, 248);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(73, 52);
            btnTimKiem.TabIndex = 19;
            btnTimKiem.Text = "🔍";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // lblMaSo
            // 
            lblMaSo.AutoSize = true;
            lblMaSo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaSo.ForeColor = Color.Brown;
            lblMaSo.Location = new Point(124, 44);
            lblMaSo.Name = "lblMaSo";
            lblMaSo.Size = new Size(98, 31);
            lblMaSo.TabIndex = 20;
            lblMaSo.Text = "lblMaSo";
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Location = new Point(11, 324);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.Size = new Size(901, 302);
            dgvSinhVien.TabIndex = 21;
            dgvSinhVien.CellContentClick += dgvSinhVien_CellContentClick;
            dgvSinhVien.SelectionChanged += dgvSinhVien_SelectionChanged;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(662, 255);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(170, 38);
            txtTimKiem.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(558, 258);
            label5.Name = "label5";
            label5.Size = new Size(95, 31);
            label5.TabIndex = 23;
            label5.Text = "Từ khóa";
            // 
            // frmSinhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 647);
            Controls.Add(label5);
            Controls.Add(txtTimKiem);
            Controls.Add(dgvSinhVien);
            Controls.Add(lblMaSo);
            Controls.Add(btnTimKiem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnLamMoi);
            Controls.Add(btnThem);
            Controls.Add(cboKhoa);
            Controls.Add(cboGioiTinh);
            Controls.Add(dtpNgaySinh);
            Controls.Add(txtDienThoai);
            Controls.Add(txtDiaChi);
            Controls.Add(txtHoTen);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmSinhVien";
            Text = "Quản lý sinh viên";
            Load += frmSinhVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtHoTen;
        private TextBox txtDienThoai;
        private TextBox txtDiaChi;
        private DateTimePicker dtpNgaySinh;
        private ComboBox cboGioiTinh;
        private ComboBox cboKhoa;
        private Button btnThem;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnTimKiem;
        private Label lblMaSo;
        private DataGridView dgvSinhVien;
        private TextBox txtTimKiem;
        private Label label5;
    }
}