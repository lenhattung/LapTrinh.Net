using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_06.QuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool kiemTraMaSV(string ma)
        {
            for (int i = 0; i < lvDanhSachSV.Items.Count; i++)
            {
                if (lvDanhSachSV.Items[i].SubItems[1].Text == ma)
                {
                    return false;
                }
            }

            for (int i = 0; i < lvDachon.Items.Count; i++)
            {
                if (lvDachon.Items[i].SubItems[1].Text == ma)
                {
                    return false;
                }
            }
            return true;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {

        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Trim() == "" || txtHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thông báo");
            }
            else if (kiemTraMaSV(txtMaSV.Text.Trim()) == false)
            {
                MessageBox.Show("Mã số sinh viên đã tồn tại, vui lòng nhập lại!", "Thông báo");
                txtMaSV.SelectAll();
                txtMaSV.Focus();
            }
            else
            {
                int stt = lvDanhSachSV.Items.Count + 1;

                ListViewItem li = new ListViewItem(stt.ToString());
                li.SubItems.Add(txtMaSV.Text.Trim());
                li.SubItems.Add(txtHoTen.Text.Trim());

                lvDanhSachSV.Items.Add(li);
                txtMaSV.Text = "";
                txtHoTen.Text = "";
                txtMaSV.Focus();
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < lvDanhSachSV.Items.Count)
            {
                if (lvDanhSachSV.Items[i].Selected == true)
                {
                    lvDanhSachSV.Items.RemoveAt(i);
                }
                else
                {
                    i++;
                }
                danhSoThuTu(lvDanhSachSV);
            }
        }

        private void danhSoThuTu(ListView lv)
        {
            for(int i=0; i < lv.Items.Count; i++)
            {
                lv.Items[i].Text = (i + 1).ToString();
            }
        }
    }
}
