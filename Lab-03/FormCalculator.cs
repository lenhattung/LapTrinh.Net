namespace Lab_03
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCong_Click(object sender, EventArgs e)
        {
            double n = double.Parse(txtSoN.Text);
            double m = double.Parse(txtSoM.Text);
            double Tong = n + m;
            txtKetQua.Text = Tong.ToString();
        }

        private void buttonTru_Click(object sender, EventArgs e)
        {
            double n = double.Parse(txtSoN.Text);
            double m = double.Parse(txtSoM.Text);
            double Tong = n - m;
            txtKetQua.Text = Tong.ToString();
        }

        private void buttonNhan_Click(object sender, EventArgs e)
        {
            double n = double.Parse(txtSoN.Text);
            double m = double.Parse(txtSoM.Text);
            double Tong = n * m;
            txtKetQua.Text = Tong.ToString();
        }

        private void buttonChia_Click(object sender, EventArgs e)
        {
            double n = double.Parse(txtSoN.Text);
            double m = double.Parse(txtSoM.Text);
            if (m != 0)
            {
                double Tong = n / m;
                txtKetQua.Text = Tong.ToString();
            }
            else
            {
                txtKetQua.Text = "Không thể thực hiện phép chia cho 0!";
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            txtSoN.Text = "";
            txtSoM.Text = "";
            txtKetQua.Text = "";
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
