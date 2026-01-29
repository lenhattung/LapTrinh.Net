namespace Lab_07._Quản_lý_nhân_viên_sử_dụng_ListView
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            tbDiaChi = new TextBox();
            label5 = new Label();
            tbDienThoai = new TextBox();
            label4 = new Label();
            tbNgaySinh = new DateTimePicker();
            tbHoTen = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btThem = new Button();
            btXoa = new Button();
            btSua = new Button();
            btThoat = new Button();
            groupBox2 = new GroupBox();
            lvDanhSachNhanVien = new ListView();
            columnHoTen = new ColumnHeader();
            columnNgaySinh = new ColumnHeader();
            columnDiaChi = new ColumnHeader();
            columnDienThoai = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(64, 24);
            label1.Name = "label1";
            label1.Size = new Size(683, 81);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC NHÂN VIÊN";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbDiaChi);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbDienThoai);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tbNgaySinh);
            groupBox1.Controls.Add(tbHoTen);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(26, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(747, 114);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chi tiết";
            // 
            // tbDiaChi
            // 
            tbDiaChi.Location = new Point(474, 62);
            tbDiaChi.Name = "tbDiaChi";
            tbDiaChi.Size = new Size(247, 27);
            tbDiaChi.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(387, 63);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 3;
            label5.Text = "Địa chỉ";
            // 
            // tbDienThoai
            // 
            tbDienThoai.Location = new Point(474, 26);
            tbDienThoai.Name = "tbDienThoai";
            tbDienThoai.Size = new Size(247, 27);
            tbDienThoai.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(387, 27);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 4;
            label4.Text = "Điện thoại";
            // 
            // tbNgaySinh
            // 
            tbNgaySinh.CustomFormat = "dd/MM/yyyy";
            tbNgaySinh.Format = DateTimePickerFormat.Custom;
            tbNgaySinh.Location = new Point(99, 60);
            tbNgaySinh.Name = "tbNgaySinh";
            tbNgaySinh.Size = new Size(247, 27);
            tbNgaySinh.TabIndex = 3;
            // 
            // tbHoTen
            // 
            tbHoTen.Location = new Point(99, 25);
            tbHoTen.Name = "tbHoTen";
            tbHoTen.Size = new Size(247, 27);
            tbHoTen.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 62);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 1;
            label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 26);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 0;
            label2.Text = "Họ tên";
            // 
            // btThem
            // 
            btThem.Location = new Point(375, 232);
            btThem.Name = "btThem";
            btThem.Size = new Size(95, 49);
            btThem.TabIndex = 2;
            btThem.Text = "Thêm";
            btThem.UseVisualStyleBackColor = true;
            btThem.Click += btThem_Click;
            // 
            // btXoa
            // 
            btXoa.Location = new Point(476, 232);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(95, 49);
            btXoa.TabIndex = 3;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = true;
            btXoa.Click += btXoa_Click;
            // 
            // btSua
            // 
            btSua.Location = new Point(577, 232);
            btSua.Name = "btSua";
            btSua.Size = new Size(95, 49);
            btSua.TabIndex = 4;
            btSua.Text = "Sửa";
            btSua.UseVisualStyleBackColor = true;
            btSua.Click += btSua_Click;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(678, 232);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(95, 49);
            btThoat.TabIndex = 5;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lvDanhSachNhanVien);
            groupBox2.Location = new Point(13, 310);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(766, 297);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chung";
            // 
            // lvDanhSachNhanVien
            // 
            lvDanhSachNhanVien.Columns.AddRange(new ColumnHeader[] { columnHoTen, columnNgaySinh, columnDiaChi, columnDienThoai });
            lvDanhSachNhanVien.FullRowSelect = true;
            lvDanhSachNhanVien.GridLines = true;
            lvDanhSachNhanVien.Location = new Point(17, 28);
            lvDanhSachNhanVien.Name = "lvDanhSachNhanVien";
            lvDanhSachNhanVien.RightToLeftLayout = true;
            lvDanhSachNhanVien.Size = new Size(737, 263);
            lvDanhSachNhanVien.TabIndex = 0;
            lvDanhSachNhanVien.UseCompatibleStateImageBehavior = false;
            lvDanhSachNhanVien.View = View.Details;
            lvDanhSachNhanVien.SelectedIndexChanged += chonMotDong;
            // 
            // columnHoTen
            // 
            columnHoTen.Text = "Họ tên";
            columnHoTen.Width = 180;
            // 
            // columnNgaySinh
            // 
            columnNgaySinh.Text = "Ngày sinh";
            columnNgaySinh.Width = 100;
            // 
            // columnDiaChi
            // 
            columnDiaChi.Text = "Địa chỉ";
            columnDiaChi.Width = 200;
            // 
            // columnDienThoai
            // 
            columnDienThoai.Text = "Điện thoại";
            columnDienThoai.Width = 100;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 629);
            Controls.Add(groupBox2);
            Controls.Add(btThoat);
            Controls.Add(btSua);
            Controls.Add(btXoa);
            Controls.Add(btThem);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Danh mục nhân viên";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox tbDiaChi;
        private Label label5;
        private TextBox tbDienThoai;
        private Label label4;
        private DateTimePicker tbNgaySinh;
        private TextBox tbHoTen;
        private Label label3;
        private Button btThem;
        private Button btXoa;
        private Button btSua;
        private Button btThoat;
        private GroupBox groupBox2;
        private ListView lvDanhSachNhanVien;
        private ColumnHeader columnHoTen;
        private ColumnHeader columnNgaySinh;
        private ColumnHeader columnDiaChi;
        private ColumnHeader columnDienThoai;
    }
}
