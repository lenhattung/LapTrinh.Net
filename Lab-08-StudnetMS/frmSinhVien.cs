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
                DataRowView currentRow = (DataRowView)bs.Current;
                // Kiểm tra nếu cột GioiTinh là DBNull (thường gặp khi AddNew) thì mặc định là true (Nam)
                object val = currentRow["GioiTinh"];
                bool gioiTinh = (val == DBNull.Value) ? true : (bool)val;

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

      
        private void button_ThemMoi_Click(object sender, EventArgs e)
        {
            // 1. Kết thúc các thay đổi cũ nếu có
            bs.EndEdit();

            // 2. Thêm dòng mới (Các textbox sẽ tự động trống nhờ Binding)
            bs.AddNew();

            // 3. Di chuyển thanh cuộn của DataGridView xuống dòng cuối cùng
            if (dataGridViewSinhVien.Rows.Count > 0)
            {
                int newIndex = bs.Count - 1;
                dataGridViewSinhVien.FirstDisplayedScrollingRowIndex = newIndex; // Cuộn tới dòng mới
                dataGridViewSinhVien.Rows[newIndex].Selected = true; // Bôi xanh dòng mới
                dataGridViewSinhVien.CurrentCell = dataGridViewSinhVien.Rows[newIndex].Cells[0]; // Đặt tiêu điểm
            }

            // 4. Thiết lập giá trị mặc định cho dòng mới (nếu cần) thông qua DataRow
            DataRowView newRow = (DataRowView)bs.Current;
            newRow["NgaySinh"] = DateTime.Now;
            newRow["GioiTinh"] = true; // Mặc định là Nam

            txtMaSoSinhVien.Focus();
        }

        private void button_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kết thúc việc chỉnh sửa
                bs.EndEdit();

                // 2. Sử dụng SQLCommandBuilder để tạo update
                SqlCommandBuilder builder = new SqlCommandBuilder(da);

                // 3. Cập nhật thay đổi xuống Database
                da.Update(dtSinhVien);
                MessageBox.Show("Đã lưu thành công!", "Thông báo");
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
