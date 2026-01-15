namespace Lab_03
{
    partial class FormCalculator
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSoN = new TextBox();
            txtSoM = new TextBox();
            txtKetQua = new TextBox();
            buttonCong = new Button();
            buttonTru = new Button();
            buttonNhan = new Button();
            buttonChia = new Button();
            buttonXoa = new Button();
            buttonThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(108, 32);
            label1.Name = "label1";
            label1.Size = new Size(605, 60);
            label1.TabIndex = 0;
            label1.Text = "THỰC HIỆN CÁC PHÉP TÍNH";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 147);
            label2.Name = "label2";
            label2.Size = new Size(72, 38);
            label2.TabIndex = 1;
            label2.Text = "Số n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 213);
            label3.Name = "label3";
            label3.Size = new Size(80, 38);
            label3.TabIndex = 2;
            label3.Text = "Số m";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 278);
            label4.Name = "label4";
            label4.Size = new Size(111, 38);
            label4.TabIndex = 3;
            label4.Text = "Kết quả";
            // 
            // txtSoN
            // 
            txtSoN.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoN.Location = new Point(179, 134);
            txtSoN.Name = "txtSoN";
            txtSoN.Size = new Size(505, 51);
            txtSoN.TabIndex = 4;
            txtSoN.TextAlign = HorizontalAlignment.Right;
            // 
            // txtSoM
            // 
            txtSoM.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoM.Location = new Point(179, 203);
            txtSoM.Name = "txtSoM";
            txtSoM.Size = new Size(505, 51);
            txtSoM.TabIndex = 5;
            txtSoM.TextAlign = HorizontalAlignment.Right;
            // 
            // txtKetQua
            // 
            txtKetQua.BackColor = Color.FromArgb(255, 255, 192);
            txtKetQua.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKetQua.Location = new Point(179, 269);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.Size = new Size(505, 51);
            txtKetQua.TabIndex = 6;
            txtKetQua.TextAlign = HorizontalAlignment.Right;
            // 
            // buttonCong
            // 
            buttonCong.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCong.Location = new Point(12, 363);
            buttonCong.Name = "buttonCong";
            buttonCong.Size = new Size(101, 58);
            buttonCong.TabIndex = 7;
            buttonCong.Text = "+";
            buttonCong.UseVisualStyleBackColor = true;
            buttonCong.Click += buttonCong_Click;
            // 
            // buttonTru
            // 
            buttonTru.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonTru.Location = new Point(128, 363);
            buttonTru.Name = "buttonTru";
            buttonTru.Size = new Size(101, 58);
            buttonTru.TabIndex = 8;
            buttonTru.Text = "-";
            buttonTru.UseVisualStyleBackColor = true;
            buttonTru.Click += buttonTru_Click;
            // 
            // buttonNhan
            // 
            buttonNhan.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonNhan.Location = new Point(246, 363);
            buttonNhan.Name = "buttonNhan";
            buttonNhan.Size = new Size(101, 58);
            buttonNhan.TabIndex = 9;
            buttonNhan.Text = "*";
            buttonNhan.UseVisualStyleBackColor = true;
            buttonNhan.Click += buttonNhan_Click;
            // 
            // buttonChia
            // 
            buttonChia.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonChia.Location = new Point(371, 363);
            buttonChia.Name = "buttonChia";
            buttonChia.Size = new Size(101, 58);
            buttonChia.TabIndex = 10;
            buttonChia.Text = "/";
            buttonChia.UseVisualStyleBackColor = true;
            buttonChia.Click += buttonChia_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonXoa.Location = new Point(493, 363);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(101, 58);
            buttonXoa.TabIndex = 11;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = true;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // buttonThoat
            // 
            buttonThoat.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonThoat.Location = new Point(613, 363);
            buttonThoat.Name = "buttonThoat";
            buttonThoat.Size = new Size(154, 58);
            buttonThoat.TabIndex = 12;
            buttonThoat.Text = "Thoát";
            buttonThoat.UseVisualStyleBackColor = true;
            buttonThoat.Click += buttonThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonThoat);
            Controls.Add(buttonXoa);
            Controls.Add(buttonChia);
            Controls.Add(buttonNhan);
            Controls.Add(buttonTru);
            Controls.Add(buttonCong);
            Controls.Add(txtKetQua);
            Controls.Add(txtSoM);
            Controls.Add(txtSoN);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSoN;
        private TextBox txtSoM;
        private TextBox txtKetQua;
        private Button buttonCong;
        private Button buttonTru;
        private Button buttonNhan;
        private Button buttonChia;
        private Button buttonXoa;
        private Button buttonThoat;
    }
}
