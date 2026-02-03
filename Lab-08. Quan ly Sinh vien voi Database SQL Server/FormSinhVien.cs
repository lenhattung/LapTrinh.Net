using Microsoft.Data.SqlClient;
using System.Data;

namespace Lab_08._Quan_ly_Sinh_vien_voi_Database_SQL_Server
{
    public partial class FormSinhVien : Form
    {
        string connectionString =
        "Server=.;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public FormSinhVien()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            string sql = "SELECT * FROM SinhVien";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            
            bindingSource1.DataSource = dt;
            dataGridView1.DataSource = bindingSource1;
        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
