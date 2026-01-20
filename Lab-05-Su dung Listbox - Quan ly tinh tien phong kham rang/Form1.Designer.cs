namespace Lab_05_Su_dung_Listbox___Quan_ly_tinh_tien_phong_kham_rang
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
            groupBox1 = new GroupBox();
            buttonAddToList = new Button();
            txtTotal = new TextBox();
            label3 = new Label();
            btnExit = new Button();
            btnCalc = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            labelCleanCost = new Label();
            numericUpDownFilling = new NumericUpDown();
            label2 = new Label();
            chkXRay = new CheckBox();
            chkWhitening = new CheckBox();
            chkClean = new CheckBox();
            txtFullName = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            buttonDelete = new Button();
            btnLoadFile = new Button();
            btnSaveToFile = new Button();
            listBoxCustomer = new ListBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFilling).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonAddToList);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(btnCalc);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(labelCleanCost);
            groupBox1.Controls.Add(numericUpDownFilling);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(chkXRay);
            groupBox1.Controls.Add(chkWhitening);
            groupBox1.Controls.Add(chkClean);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(23, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(401, 411);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý Thanh toán";
            // 
            // buttonAddToList
            // 
            buttonAddToList.Location = new Point(208, 288);
            buttonAddToList.Name = "buttonAddToList";
            buttonAddToList.Size = new Size(161, 44);
            buttonAddToList.TabIndex = 15;
            buttonAddToList.Text = "Thêm vào danh sách";
            buttonAddToList.UseVisualStyleBackColor = true;
            buttonAddToList.Click += button1_Click;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = SystemColors.Info;
            txtTotal.Location = new Point(81, 241);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(251, 27);
            txtTotal.TabIndex = 14;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 248);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 13;
            label3.Text = "Tổng tiền";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(56, 348);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(276, 47);
            btnExit.TabIndex = 12;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(19, 288);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(161, 44);
            btnCalc.TabIndex = 11;
            btnCalc.Text = "Tính tổng tiền";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(301, 195);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 10;
            label6.Text = "80.000 đ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(295, 156);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 9;
            label5.Text = "200.000 đ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(285, 119);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 8;
            label4.Text = "1.200.000 đ";
            // 
            // labelCleanCost
            // 
            labelCleanCost.AutoSize = true;
            labelCleanCost.Location = new Point(295, 82);
            labelCleanCost.Name = "labelCleanCost";
            labelCleanCost.Size = new Size(73, 20);
            labelCleanCost.TabIndex = 7;
            labelCleanCost.Text = "100.000 đ";
            // 
            // numericUpDownFilling
            // 
            numericUpDownFilling.Location = new Point(99, 193);
            numericUpDownFilling.Name = "numericUpDownFilling";
            numericUpDownFilling.Size = new Size(150, 27);
            numericUpDownFilling.TabIndex = 6;
            numericUpDownFilling.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 193);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 5;
            label2.Text = "Trám răng";
            // 
            // chkXRay
            // 
            chkXRay.AutoSize = true;
            chkXRay.Location = new Point(8, 156);
            chkXRay.Name = "chkXRay";
            chkXRay.Size = new Size(131, 24);
            chkXRay.TabIndex = 4;
            chkXRay.Text = "Chụp hình răng";
            chkXRay.UseVisualStyleBackColor = true;
            // 
            // chkWhitening
            // 
            chkWhitening.AutoSize = true;
            chkWhitening.Location = new Point(8, 120);
            chkWhitening.Name = "chkWhitening";
            chkWhitening.Size = new Size(127, 24);
            chkWhitening.TabIndex = 3;
            chkWhitening.Text = "Tẩy trắng răng";
            chkWhitening.UseVisualStyleBackColor = true;
            // 
            // chkClean
            // 
            chkClean.AutoSize = true;
            chkClean.Location = new Point(10, 86);
            chkClean.Name = "chkClean";
            chkClean.Size = new Size(81, 24);
            chkClean.TabIndex = 2;
            chkClean.Text = "Cạo vôi";
            chkClean.UseVisualStyleBackColor = true;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(128, 37);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(262, 27);
            txtFullName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 40);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên khách hàng";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonDelete);
            groupBox2.Controls.Add(btnLoadFile);
            groupBox2.Controls.Add(btnSaveToFile);
            groupBox2.Controls.Add(listBoxCustomer);
            groupBox2.Location = new Point(430, 18);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(362, 411);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(4, 350);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(129, 42);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Xóa khách hàng";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // btnLoadFile
            // 
            btnLoadFile.Location = new Point(247, 348);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(109, 44);
            btnLoadFile.TabIndex = 2;
            btnLoadFile.Text = "Tải File";
            btnLoadFile.UseVisualStyleBackColor = true;
            btnLoadFile.Click += btnLoadFile_Click;
            // 
            // btnSaveToFile
            // 
            btnSaveToFile.Location = new Point(138, 348);
            btnSaveToFile.Name = "btnSaveToFile";
            btnSaveToFile.Size = new Size(106, 44);
            btnSaveToFile.TabIndex = 1;
            btnSaveToFile.Text = "Lưu File";
            btnSaveToFile.UseVisualStyleBackColor = true;
            btnSaveToFile.Click += btnSaveToFile_Click;
            // 
            // listBoxCustomer
            // 
            listBoxCustomer.FormattingEnabled = true;
            listBoxCustomer.Location = new Point(8, 29);
            listBoxCustomer.Name = "listBoxCustomer";
            listBoxCustomer.Size = new Size(351, 304);
            listBoxCustomer.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFilling).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtFullName;
        private Label label1;
        private GroupBox groupBox2;
        private CheckBox chkXRay;
        private CheckBox chkWhitening;
        private CheckBox chkClean;
        private Label label2;
        private NumericUpDown numericUpDownFilling;
        private Button btnExit;
        private Button btnCalc;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label labelCleanCost;
        private ListBox listBoxCustomer;
        private Button btnLoadFile;
        private Button btnSaveToFile;
        private Button buttonAddToList;
        private TextBox txtTotal;
        private Label label3;
        private Button buttonDelete;
    }
}
