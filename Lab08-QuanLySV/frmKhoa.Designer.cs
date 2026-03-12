namespace Lab08_QuanLySV.Models
{
    partial class frmKhoa
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
            txtMaKhoa = new TextBox();
            txtTenKhoa = new TextBox();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            btnThem = new Button();
            dgvKhoa = new DataGridView();
            label5 = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 43);
            label1.Name = "label1";
            label1.Size = new Size(102, 31);
            label1.TabIndex = 0;
            label1.Text = "Mã khoa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(51, 85);
            label2.Name = "label2";
            label2.Size = new Size(104, 31);
            label2.TabIndex = 1;
            label2.Text = "Tên khoa";
            // 
            // txtMaKhoa
            // 
            txtMaKhoa.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaKhoa.Location = new Point(159, 36);
            txtMaKhoa.Name = "txtMaKhoa";
            txtMaKhoa.Size = new Size(190, 38);
            txtMaKhoa.TabIndex = 2;
            // 
            // txtTenKhoa
            // 
            txtTenKhoa.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenKhoa.Location = new Point(159, 85);
            txtTenKhoa.Name = "txtTenKhoa";
            txtTenKhoa.Size = new Size(190, 38);
            txtTenKhoa.TabIndex = 3;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSua.ForeColor = Color.Olive;
            btnSua.Location = new Point(132, 174);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(104, 71);
            btnSua.TabIndex = 22;
            btnSua.Text = "✏️ Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(247, 174);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(104, 71);
            btnXoa.TabIndex = 21;
            btnXoa.Text = "🗑️ Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLamMoi.ForeColor = Color.Blue;
            btnLamMoi.Location = new Point(360, 174);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(153, 71);
            btnLamMoi.TabIndex = 20;
            btnLamMoi.Text = "🔄 Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.Green;
            btnThem.Location = new Point(17, 174);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(104, 71);
            btnThem.TabIndex = 19;
            btnThem.Text = "➕ Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dgvKhoa
            // 
            dgvKhoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhoa.Location = new Point(20, 265);
            dgvKhoa.Name = "dgvKhoa";
            dgvKhoa.RowHeadersWidth = 51;
            dgvKhoa.Size = new Size(905, 302);
            dgvKhoa.TabIndex = 23;
            dgvKhoa.SelectionChanged += dgvKhoa_SelectionChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(528, 193);
            label5.Name = "label5";
            label5.Size = new Size(95, 31);
            label5.TabIndex = 26;
            label5.Text = "Từ khóa";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(632, 190);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(170, 38);
            txtTimKiem.TabIndex = 25;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTimKiem.ForeColor = Color.Teal;
            btnTimKiem.Location = new Point(808, 183);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(73, 52);
            btnTimKiem.TabIndex = 24;
            btnTimKiem.Text = "🔍";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // frmKhoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 607);
            Controls.Add(label5);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(dgvKhoa);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnLamMoi);
            Controls.Add(btnThem);
            Controls.Add(txtTenKhoa);
            Controls.Add(txtMaKhoa);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmKhoa";
            Text = "frmKhoa";
            Load += frmKhoa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMaKhoa;
        private TextBox txtTenKhoa;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Button btnThem;
        private DataGridView dgvKhoa;
        private Label label5;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
    }
}