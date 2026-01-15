namespace Lab_03
{
    partial class FormUocBoi
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
            groupBox1 = new GroupBox();
            textBoxB = new TextBox();
            textBoxA = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            radioButtonBSCNN = new RadioButton();
            radioButtonUSCLN = new RadioButton();
            groupBox3 = new GroupBox();
            buttonThoat = new Button();
            buttonBoQua = new Button();
            buttonTim = new Button();
            textBoxKetQua = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxB);
            groupBox1.Controls.Add(textBoxA);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(16, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(529, 189);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập";
            // 
            // textBoxB
            // 
            textBoxB.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxB.Location = new Point(63, 99);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(437, 38);
            textBoxB.TabIndex = 3;
            textBoxB.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxA
            // 
            textBoxA.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxA.Location = new Point(63, 37);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(437, 38);
            textBoxA.TabIndex = 2;
            textBoxA.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 107);
            label2.Name = "label2";
            label2.Size = new Size(21, 20);
            label2.TabIndex = 1;
            label2.Text = "B:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 49);
            label1.Name = "label1";
            label1.Size = new Size(26, 20);
            label1.TabIndex = 0;
            label1.Text = "A: ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButtonBSCNN);
            groupBox2.Controls.Add(radioButtonUSCLN);
            groupBox2.Location = new Point(560, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(228, 180);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chọn tìm";
            // 
            // radioButtonBSCNN
            // 
            radioButtonBSCNN.AutoSize = true;
            radioButtonBSCNN.Location = new Point(26, 94);
            radioButtonBSCNN.Name = "radioButtonBSCNN";
            radioButtonBSCNN.Size = new Size(177, 24);
            radioButtonBSCNN.TabIndex = 1;
            radioButtonBSCNN.TabStop = true;
            radioButtonBSCNN.Text = "Bội số chung nhỏ nhất";
            radioButtonBSCNN.UseVisualStyleBackColor = true;
            // 
            // radioButtonUSCLN
            // 
            radioButtonUSCLN.AutoSize = true;
            radioButtonUSCLN.Location = new Point(30, 38);
            radioButtonUSCLN.Name = "radioButtonUSCLN";
            radioButtonUSCLN.Size = new Size(178, 24);
            radioButtonUSCLN.TabIndex = 0;
            radioButtonUSCLN.TabStop = true;
            radioButtonUSCLN.Text = "Ước số chung lớn nhất";
            radioButtonUSCLN.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonThoat);
            groupBox3.Controls.Add(buttonBoQua);
            groupBox3.Controls.Add(buttonTim);
            groupBox3.Controls.Add(textBoxKetQua);
            groupBox3.Location = new Point(15, 239);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(770, 163);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kết quả:";
            // 
            // buttonThoat
            // 
            buttonThoat.Location = new Point(467, 89);
            buttonThoat.Name = "buttonThoat";
            buttonThoat.Size = new Size(107, 58);
            buttonThoat.TabIndex = 3;
            buttonThoat.Text = "Thoát";
            buttonThoat.UseVisualStyleBackColor = true;
            buttonThoat.Click += buttonThoat_Click;
            // 
            // buttonBoQua
            // 
            buttonBoQua.Location = new Point(331, 89);
            buttonBoQua.Name = "buttonBoQua";
            buttonBoQua.Size = new Size(107, 58);
            buttonBoQua.TabIndex = 2;
            buttonBoQua.Text = "Bỏ qua";
            buttonBoQua.UseVisualStyleBackColor = true;
            buttonBoQua.Click += buttonBoQua_Click;
            // 
            // buttonTim
            // 
            buttonTim.Location = new Point(190, 89);
            buttonTim.Name = "buttonTim";
            buttonTim.Size = new Size(107, 58);
            buttonTim.TabIndex = 1;
            buttonTim.Text = "Tìm";
            buttonTim.UseVisualStyleBackColor = true;
            buttonTim.Click += button1_Click;
            // 
            // textBoxKetQua
            // 
            textBoxKetQua.BackColor = Color.FromArgb(255, 255, 192);
            textBoxKetQua.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxKetQua.Location = new Point(65, 23);
            textBoxKetQua.Name = "textBoxKetQua";
            textBoxKetQua.Size = new Size(692, 47);
            textBoxKetQua.TabIndex = 0;
            textBoxKetQua.TextAlign = HorizontalAlignment.Center;
            // 
            // FormUocBoi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 414);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormUocBoi";
            Text = "FormUocBoi";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxB;
        private TextBox textBoxA;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton radioButtonBSCNN;
        private RadioButton radioButtonUSCLN;
        private GroupBox groupBox3;
        private Button buttonTim;
        private TextBox textBoxKetQua;
        private Button buttonThoat;
        private Button buttonBoQua;
    }
}