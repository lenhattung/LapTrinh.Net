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

        private void tim(ListView lv, string text)
        {
            text = text.ToUpper();
            for (int i = 0; i < lv.Items.Count; i++)
            {
                string maSV = lv.Items[i].SubItems[1].Text.ToUpper();
                string hoTen = lv.Items[i].SubItems[2].Text.ToUpper();
                if (maSV.Contains(text) || hoTen.Contains(text))
                {
                    lv.Items[i].Selected = true;
                    lv.Items[i].EnsureVisible();
                    lv.Items[i].Focused = true;
                }
                else
                {
                    lv.Items[i].Selected = false;
                }

            }
        }

        private void thucHienTim()
        {
            tim(lvDanhSachSV, txtTimKiem.Text);
            txtTimKiem.SelectAll();
            txtTimKiem.Focus();
        }
        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                thucHienTim();
            }
        }
        private void btSearch_Click(object sender, EventArgs e)
        {
            thucHienTim();
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
            for (int i = 0; i < lv.Items.Count; i++)
            {
                lv.Items[i].Text = (i + 1).ToString();
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có thực sự muốn thoát không?", "Xác nhận",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i++)
            {
                ListViewItem li = new ListViewItem(i.ToString());
                li.SubItems.Add("SV" + i);
                li.SubItems.Add("Nguyễn Văn " + i);

                lvDanhSachSV.Items.Add(li);

            }
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btChon1_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < lvDanhSachSV.Items.Count)
            {
                if (lvDanhSachSV.Items[i].Selected == true)
                {
                    ListViewItem li = lvDanhSachSV.Items[i];

                    lvDanhSachSV.Items.RemoveAt(i);
                    lvDachon.Items.Add(li);
                }
                else
                {
                    i++;
                }
                danhSoThuTu(lvDanhSachSV);
            }
        }

        private void btTrave1_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < lvDachon.Items.Count)
            {
                if (lvDachon.Items[i].Selected == true)
                {
                    ListViewItem li = lvDachon.Items[i];

                    lvDachon.Items.RemoveAt(i);
                    lvDanhSachSV.Items.Add(li);
                }
                else
                {
                    i++;
                }
                danhSoThuTu(lvDachon);
            }
        }

        private void btChonDS_Click(object sender, EventArgs e)
        {
            while (lvDanhSachSV.Items.Count > 0)
            {
                ListViewItem li = lvDanhSachSV.Items[0];

                lvDanhSachSV.Items.RemoveAt(0);
                lvDachon.Items.Add(li);
            }
        }

        private void btTraveDS_Click(object sender, EventArgs e)
        {
            while (lvDachon.Items.Count > 0)
            {
                ListViewItem li = lvDachon.Items[0];

                lvDachon.Items.RemoveAt(0);
                lvDanhSachSV.Items.Add(li);
            }
        }
    }
}
