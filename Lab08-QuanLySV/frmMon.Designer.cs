namespace Lab08_QuanLySV.Models
{
    partial class frmMon
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
            txtMaMH = new TextBox();
            txtTenMH = new TextBox();
            nudSoTiet = new NumericUpDown();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            dgvMon = new DataGridView();
            label5 = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            ((System.ComponentModel.ISupportInitialize)nudSoTiet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 43);
            label1.Name = "label1";
            label1.Size = new Size(99, 31);
            label1.TabIndex = 0;
            label1.Text = "Mã môn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(51, 85);
            label2.Name = "label2";
            label2.Size = new Size(144, 31);
            label2.TabIndex = 1;
            label2.Text = "Tên môn học";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(51, 130);
            label3.Name = "label3";
            label3.Size = new Size(79, 31);
            label3.TabIndex = 2;
            label3.Text = "Số tiết";
            // 
            // txtMaMH
            // 
            txtMaMH.CharacterCasing = CharacterCasing.Upper;
            txtMaMH.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaMH.Location = new Point(247, 39);
            txtMaMH.MaxLength = 6;
            txtMaMH.Name = "txtMaMH";
            txtMaMH.Size = new Size(190, 38);
            txtMaMH.TabIndex = 3;
            // 
            // txtTenMH
            // 
            txtTenMH.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenMH.Location = new Point(247, 85);
            txtTenMH.MaxLength = 50;
            txtTenMH.Name = "txtTenMH";
            txtTenMH.Size = new Size(300, 38);
            txtTenMH.TabIndex = 4;
            // 
            // nudSoTiet
            // 
            nudSoTiet.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudSoTiet.Location = new Point(247, 130);
            nudSoTiet.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nudSoTiet.Name = "nudSoTiet";
            nudSoTiet.Size = new Size(120, 38);
            nudSoTiet.TabIndex = 5;
            nudSoTiet.Value = new decimal(new int[] { 45, 0, 0, 0 });
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.Green;
            btnThem.Location = new Point(17, 196);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(104, 71);
            btnThem.TabIndex = 6;
            btnThem.Text = "➕ Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSua.ForeColor = Color.Olive;
            btnSua.Location = new Point(132, 196);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(104, 71);
            btnSua.TabIndex = 7;
            btnSua.Text = "✏️ Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(247, 196);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(104, 71);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "🗑️ Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLamMoi.ForeColor = Color.Blue;
            btnLamMoi.Location = new Point(362, 196);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(153, 71);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "🔄 Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // dgvMon
            // 
            dgvMon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMon.Location = new Point(20, 290);
            dgvMon.Name = "dgvMon";
            dgvMon.ReadOnly = true;
            dgvMon.RowHeadersWidth = 51;
            dgvMon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMon.Size = new Size(905, 302);
            dgvMon.TabIndex = 10;
            dgvMon.SelectionChanged += dgvMon_SelectionChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(528, 215);
            label5.Name = "label5";
            label5.Size = new Size(95, 31);
            label5.TabIndex = 13;
            label5.Text = "Từ khóa";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(632, 212);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(170, 38);
            txtTimKiem.TabIndex = 12;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTimKiem.ForeColor = Color.Teal;
            btnTimKiem.Location = new Point(808, 205);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(73, 52);
            btnTimKiem.TabIndex = 11;
            btnTimKiem.Text = "🔍";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // frmMon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 630);
            Controls.Add(label5);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(dgvMon);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(nudSoTiet);
            Controls.Add(txtTenMH);
            Controls.Add(txtMaMH);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmMon";
            Text = "Quản lý môn học";
            Load += frmMon_Load;
            ((System.ComponentModel.ISupportInitialize)nudSoTiet).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMaMH;
        private TextBox txtTenMH;
        private NumericUpDown nudSoTiet;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private DataGridView dgvMon;
        private Label label5;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
    }
}