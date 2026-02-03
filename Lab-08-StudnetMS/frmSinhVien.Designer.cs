namespace Lab_08_StudnetMS
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
            components = new System.ComponentModel.Container();
            dataGridViewSinhVien = new DataGridView();
            bindingSource1 = new BindingSource(components);
            label1 = new Label();
            txtMaSoSinhVien = new TextBox();
            txtHoTen = new TextBox();
            label2 = new Label();
            label4 = new Label();
            txtSoDienThoai = new TextBox();
            label5 = new Label();
            txtDiaChi = new TextBox();
            label6 = new Label();
            txtMaKhoa = new TextBox();
            label7 = new Label();
            dtp_NgaySinh = new DateTimePicker();
            gbGioiTinh = new GroupBox();
            radioButton_Nu = new RadioButton();
            radioButton_Nam = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSinhVien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            gbGioiTinh.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewSinhVien
            // 
            dataGridViewSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSinhVien.Location = new Point(22, 206);
            dataGridViewSinhVien.Name = "dataGridViewSinhVien";
            dataGridViewSinhVien.RowHeadersWidth = 51;
            dataGridViewSinhVien.Size = new Size(871, 326);
            dataGridViewSinhVien.TabIndex = 0;
            dataGridViewSinhVien.CellFormatting += dataGridViewSinhVien_CellFormatting;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 16);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã số SV";
            // 
            // txtMaSoSinhVien
            // 
            txtMaSoSinhVien.Location = new Point(103, 12);
            txtMaSoSinhVien.Name = "txtMaSoSinhVien";
            txtMaSoSinhVien.Size = new Size(218, 27);
            txtMaSoSinhVien.TabIndex = 2;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(103, 58);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(218, 27);
            txtHoTen.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 62);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 3;
            label2.Text = "Họ tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 117);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 5;
            label4.Text = "Ngày sinh";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(458, 55);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(194, 27);
            txtSoDienThoai.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(355, 59);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 11;
            label5.Text = "Số điện thoại";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(434, 9);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(218, 27);
            txtDiaChi.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(355, 13);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 9;
            label6.Text = "Địa chỉ";
            // 
            // txtMaKhoa
            // 
            txtMaKhoa.Location = new Point(434, 110);
            txtMaKhoa.Name = "txtMaKhoa";
            txtMaKhoa.Size = new Size(218, 27);
            txtMaKhoa.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(355, 114);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 13;
            label7.Text = "Mã khoa";
            // 
            // dtp_NgaySinh
            // 
            dtp_NgaySinh.CustomFormat = "dd/MM/yyyy";
            dtp_NgaySinh.Format = DateTimePickerFormat.Custom;
            dtp_NgaySinh.Location = new Point(104, 107);
            dtp_NgaySinh.Name = "dtp_NgaySinh";
            dtp_NgaySinh.Size = new Size(218, 27);
            dtp_NgaySinh.TabIndex = 15;
            // 
            // gbGioiTinh
            // 
            gbGioiTinh.Controls.Add(radioButton_Nu);
            gbGioiTinh.Controls.Add(radioButton_Nam);
            gbGioiTinh.Location = new Point(24, 146);
            gbGioiTinh.Name = "gbGioiTinh";
            gbGioiTinh.Size = new Size(301, 53);
            gbGioiTinh.TabIndex = 16;
            gbGioiTinh.TabStop = false;
            gbGioiTinh.Text = "Giới tính";
            // 
            // radioButton_Nu
            // 
            radioButton_Nu.AutoSize = true;
            radioButton_Nu.Location = new Point(222, 14);
            radioButton_Nu.Name = "radioButton_Nu";
            radioButton_Nu.Size = new Size(50, 24);
            radioButton_Nu.TabIndex = 1;
            radioButton_Nu.TabStop = true;
            radioButton_Nu.Text = "Nữ";
            radioButton_Nu.UseVisualStyleBackColor = true;
            radioButton_Nu.CheckedChanged += radioButton_Nu_CheckedChanged;
            // 
            // radioButton_Nam
            // 
            radioButton_Nam.AutoSize = true;
            radioButton_Nam.Location = new Point(132, 14);
            radioButton_Nam.Name = "radioButton_Nam";
            radioButton_Nam.Size = new Size(62, 24);
            radioButton_Nam.TabIndex = 0;
            radioButton_Nam.TabStop = true;
            radioButton_Nam.Text = "Nam";
            radioButton_Nam.UseVisualStyleBackColor = true;
            radioButton_Nam.CheckedChanged += radioButton_Nam_CheckedChanged;
            // 
            // frmSinhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 556);
            Controls.Add(gbGioiTinh);
            Controls.Add(dtp_NgaySinh);
            Controls.Add(txtMaKhoa);
            Controls.Add(label7);
            Controls.Add(txtSoDienThoai);
            Controls.Add(label5);
            Controls.Add(txtDiaChi);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(txtHoTen);
            Controls.Add(label2);
            Controls.Add(txtMaSoSinhVien);
            Controls.Add(label1);
            Controls.Add(dataGridViewSinhVien);
            Name = "frmSinhVien";
            Text = "frmSinhVien";
            Load += frmSinhVien_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSinhVien).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            gbGioiTinh.ResumeLayout(false);
            gbGioiTinh.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewSinhVien;
        private BindingSource bindingSource1;
        private Label label1;
        private TextBox txtMaSoSinhVien;
        private TextBox txtHoTen;
        private Label label2;
        private Label label4;
        private TextBox txtSoDienThoai;
        private Label label5;
        private TextBox txtDiaChi;
        private Label label6;
        private TextBox txtMaKhoa;
        private Label label7;
        private DateTimePicker dtp_NgaySinh;
        private GroupBox gbGioiTinh;
        private RadioButton radioButton_Nu;
        private RadioButton radioButton_Nam;
    }
}