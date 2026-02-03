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
        DataTable dtSinhVien = new DataTable();
        DataTable dtKhoa = new DataTable();
        BindingSource bs = new BindingSource();

        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            // 1. Đọc dữ liệu từ SQL
            da = new SqlDataAdapter("SELECT * FROM SinhVien", conn);
            da.Fill(dtSinhVien);

            // Lấy dữ liệu mã khoa
            SqlDataAdapter daKhoa = new SqlDataAdapter("SELECT MaKhoa, TenKhoa FROM Khoa", conn);
            daKhoa.Fill(dtKhoa);

            // 2. Gán dữ liệu vào BingdingSource (vật trung gian)
            bs.DataSource = dtSinhVien;

            // 3. Liên kết BindingSource với DataGridView và Navigator
            dataGridViewSinhVien.DataSource = bs;

            // 4. Liên kết từng textbox với các cột tường ứng
            txtMaSoSinhVien.DataBindings.Add("Text", bs, "MaSo");
            txtHoTen.DataBindings.Add("Text", bs, "HoTen");
            dtp_NgaySinh.DataBindings.Add("Value", bs, "NgaySinh");
            radioButton_Nam.DataBindings.Add("Checked", bs, "GioiTinh", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDiaChi.DataBindings.Add("Text", bs, "DiaChi");
            txtSoDienThoai.DataBindings.Add("Text", bs, "DienThoai");
            // Thiết lập combobox
            comboBox_MaKhoa.DataSource = dtKhoa;
            comboBox_MaKhoa.DisplayMember = "TenKhoa";
            comboBox_MaKhoa.ValueMember = "MaKhoa";

            bs.PositionChanged += (s, e) =>
            {
                if (bs.Current != null)
                {
                    DataRowView currentRow = (DataRowView)bs.Current;

                    // Kiểm tra nếu giá trị là DBNull (dòng mới chưa có dữ liệu) thì mặc định là true
                    object val = currentRow["GioiTinh"];
                    bool gioiTinh = (val == DBNull.Value) ? true : (bool)val;

                    radioButton_Nam.Checked = gioiTinh;
                    radioButton_Nu.Checked = !gioiTinh;
                }
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


        private void button_ThemMoi_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kết thúc mọi chỉnh sửa
                bs.EndEdit();

                // 2. TẠM THỜI xóa binding của các controls
                txtMaSoSinhVien.DataBindings.Clear();
                txtHoTen.DataBindings.Clear();
                dtp_NgaySinh.DataBindings.Clear();
                radioButton_Nam.DataBindings.Clear();
                txtDiaChi.DataBindings.Clear();
                txtSoDienThoai.DataBindings.Clear();

                // 3. Tạo dòng mới
                bs.AddNew();

                // 4. THIẾT LẬP LẠI BINDING
                txtMaSoSinhVien.DataBindings.Add("Text", bs, "MaSo");
                txtHoTen.DataBindings.Add("Text", bs, "HoTen");
                dtp_NgaySinh.DataBindings.Add("Value", bs, "NgaySinh");
                radioButton_Nam.DataBindings.Add("Checked", bs, "GioiTinh", true, DataSourceUpdateMode.OnPropertyChanged);
                txtDiaChi.DataBindings.Add("Text", bs, "DiaChi");
                txtSoDienThoai.DataBindings.Add("Text", bs, "DienThoai");

                // 5. Cập nhật Grid
                if (dataGridViewSinhVien.Rows.Count > 0)
                {
                    int newIndex = bs.Count - 1;
                    dataGridViewSinhVien.FirstDisplayedScrollingRowIndex = newIndex;
                    dataGridViewSinhVien.Rows[newIndex].Selected = true;
                    dataGridViewSinhVien.CurrentCell = dataGridViewSinhVien.Rows[newIndex].Cells[0];
                }

                // 6. Focus vào TextBox đầu tiên
                txtMaSoSinhVien.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm mới: " + ex.Message, "Lỗi");
            }
        }

        private void button_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                // Xác nhận dữ liệu từ các TextBox đã nạp vào dòng hiện tại của DataTable
                this.Validate();
                bs.EndEdit();

                // Tự động sinh lệnh INSERT/UPDATE
                SqlCommandBuilder builder = new SqlCommandBuilder(da);

                // Đẩy dữ liệu xuống SQL
                da.Update(dtSinhVien);

                MessageBox.Show("Đã lưu dữ liệu thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
              
                 MessageBox.Show("Lỗi CSDL: " + ex.Message);

                // Nạp lại dữ liệu để xóa các dòng lỗi trên giao diện
                dtSinhVien.Clear();
                da.Fill(dtSinhVien);
            }

        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            // 1. Lấy thông tin sinh viên hiện tại đang chọn
            DataRowView currentRow = (DataRowView)bs.Current;
            string tenSV = currentRow["HoTen"].ToString();

            // 2. Hiển thị hộp thoại xác nhận (Confirm)
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa sinh viên {tenSV} không?",
                                                 "Xác nhận xóa",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // 3. Xóa dòng khỏi BindingSource
                    bs.RemoveCurrent();

                    // 4. Cập nhật ngay lập tức xuống CSDL
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    da.Update(dtSinhVien);

                    MessageBox.Show("Đã xóa sinh viên thành công!", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi");
                    // Nếu lỗi (vướng khóa ngoại), nạp lại dữ liệu để đồng bộ grid
                    dtSinhVien.Clear();
                    da.Fill(dtSinhVien);
                }
            }
        }
    }
}
