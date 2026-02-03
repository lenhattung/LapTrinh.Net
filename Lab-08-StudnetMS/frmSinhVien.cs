using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Lab_08_StudnetMS
{
    public partial class frmSinhVien : Form
    {
        // Thêm TrustServerCertificate=True; và Encrypt=False;
        SqlConnection conn = new SqlConnection("Server=.;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=False;");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();

        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            // 1. Đọc dữ liệu từ SQL
            da = new SqlDataAdapter("SELECT * FROM SinhVien", conn);
            da.Fill(dt);

            // 2. Gán dữ liệu vào BingdingSource (vật trung gian)
            bs.DataSource = dt;

            // 3. Liên kết BindingSource với DataGridView và Navigator
            dataGridViewSinhVien.DataSource = bs;

            // 4. Liên kết từng textbox với các cột tường ứng
            txtMaSoSinhVien.DataBindings.Add("Text", bs, "MaSo");
            txtHoTen.DataBindings.Add("Text", bs, "HoTen");
            dtp_NgaySinh.DataBindings.Add("Value", bs, "NgaySinh");
            radioButton_Nam.DataBindings.Add("Checked", bs, "GioiTinh", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDiaChi.DataBindings.Add("Text", bs, "DiaChi");
            txtSoDienThoai.DataBindings.Add("Text", bs, "DienThoai");
            txtMaKhoa.DataBindings.Add("Text", bs, "MaKhoa");

            bs.PositionChanged += (s, e) =>
            {
                DataRowView currentRow = (DataRowView)bs.Current;
                bool gioiTinh = (bool)currentRow["GioiTinh"];
                radioButton_Nam.Checked = gioiTinh;
                radioButton_Nu.Checked = !gioiTinh;
            };
        }

        private void radioButton_Nam_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Nam.Focused)
            {
                DataRowView currentView = (DataRowView)bs.Current;
                currentView["GioiTinh"] = radioButton_Nam.Checked;
            }
        }

        private void radioButton_Nu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Nu.Focused)
            {
                DataRowView currentView = (DataRowView)bs.Current;
                currentView["GioiTinh"] = !radioButton_Nu.Checked;
            }
        }

        private void dataGridViewSinhVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
          
        }
    }
}
