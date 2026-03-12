namespace Lab08_QuanLySV.Models
{
    partial class frmKetQua
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
            cboSinhVien = new ComboBox();
            btnXem      = new Button();
            pnlTongKet  = new Panel();
            lblDTB      = new Label();
            lblSoMon    = new Label();
            lblXepLoai  = new Label();
            dgvKetQua   = new DataGridView();
            btnXuatCSV  = new Button();
            pnlTongKet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKetQua).BeginInit();
            SuspendLayout();
            // 
            // lblSinhVien
            // 
            lblSinhVien.AutoSize = true;
            lblSinhVien.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSinhVien.Location = new Point(80, 38);
            lblSinhVien.Name = "lblSinhVien";
            lblSinhVien.TabIndex = 0;
            lblSinhVien.Text = "Sinh viên:";
            // 
            // cboSinhVien
            // 
            cboSinhVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSinhVien.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboSinhVien.FormattingEnabled = true;
            cboSinhVien.Location = new Point(190, 33);
            cboSinhVien.Name = "cboSinhVien";
            cboSinhVien.Size = new Size(380, 39);
            cboSinhVien.TabIndex = 1;
            // 
            // btnXem
            // 
            btnXem.BackColor = Color.FromArgb(46, 125, 50);
            btnXem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXem.ForeColor = Color.White;
            btnXem.Location = new Point(585, 30);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(160, 46);
            btnXem.TabIndex = 2;
            btnXem.Text = "🔍 Xem kết quả";
            btnXem.UseVisualStyleBackColor = false;
            btnXem.Click += btnXem_Click;
            // 
            // pnlTongKet
            // 
            pnlTongKet.BackColor = Color.FromArgb(232, 248, 240);
            pnlTongKet.BorderStyle = BorderStyle.FixedSingle;
            pnlTongKet.Controls.Add(lblDTB);
            pnlTongKet.Controls.Add(lblSoMon);
            pnlTongKet.Controls.Add(lblXepLoai);
            pnlTongKet.Location = new Point(11, 92);
            pnlTongKet.Name = "pnlTongKet";
            pnlTongKet.Size = new Size(901, 50);
            pnlTongKet.TabIndex = 3;
            // 
            // lblDTB
            // 
            lblDTB.AutoSize = true;
            lblDTB.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDTB.ForeColor = Color.FromArgb(21, 101, 192);
            lblDTB.Location = new Point(12, 12);
            lblDTB.Name = "lblDTB";
            lblDTB.TabIndex = 0;
            lblDTB.Text = "ĐTB: —";
            // 
            // lblSoMon
            // 
            lblSoMon.AutoSize = true;
            lblSoMon.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSoMon.Location = new Point(200, 12);
            lblSoMon.Name = "lblSoMon";
            lblSoMon.TabIndex = 1;
            lblSoMon.Text = "Môn đã học: —";
            // 
            // lblXepLoai
            // 
            lblXepLoai.AutoSize = true;
            lblXepLoai.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblXepLoai.ForeColor = Color.DarkGreen;
            lblXepLoai.Location = new Point(420, 12);
            lblXepLoai.Name = "lblXepLoai";
            lblXepLoai.TabIndex = 2;
            lblXepLoai.Text = "Xếp loại: —";
            // 
            // dgvKetQua
            // 
            dgvKetQua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKetQua.Location = new Point(11, 158);
            dgvKetQua.Name = "dgvKetQua";
            dgvKetQua.ReadOnly = true;
            dgvKetQua.RowHeadersWidth = 51;
            dgvKetQua.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKetQua.Size = new Size(901, 310);
            dgvKetQua.TabIndex = 4;
            // 
            // btnXuatCSV
            // 
            btnXuatCSV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXuatCSV.ForeColor = Color.FromArgb(21, 101, 192);
            btnXuatCSV.Location = new Point(11, 480);
            btnXuatCSV.Name = "btnXuatCSV";
            btnXuatCSV.Size = new Size(160, 46);
            btnXuatCSV.TabIndex = 5;
            btnXuatCSV.Text = "💾 Xuất CSV";
            btnXuatCSV.UseVisualStyleBackColor = true;
            btnXuatCSV.Click += btnXuatCSV_Click;
            // 
            // frmKetQua
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 545);
            Controls.Add(btnXuatCSV);
            Controls.Add(dgvKetQua);
            Controls.Add(pnlTongKet);
            Controls.Add(btnXem);
            Controls.Add(cboSinhVien);
            Controls.Add(lblSinhVien);
            Name = "frmKetQua";
            Text = "frmKetQua — Kết quả học tập";
            Load += frmKetQua_Load;
            pnlTongKet.ResumeLayout(false);
            pnlTongKet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKetQua).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSinhVien;
        private ComboBox cboSinhVien;
        private Button btnXem;
        private Panel pnlTongKet;
        private Label lblDTB;
        private Label lblSoMon;
        private Label lblXepLoai;
        private DataGridView dgvKetQua;
        private Button btnXuatCSV;
    }
}
