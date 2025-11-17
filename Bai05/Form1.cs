namespace Bai05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumberChiChoPhepNhapSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cho phép phím Backspace (xóa)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // chặn ký tự không phải số
            }
        }

        private void txtAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // không cho phép nhập liệu vào txtAnswer
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNumber1.Text);
            double num2 = double.Parse(txtNumber2.Text);

            double answer = num1 + num2;
            txtAnswer.Text = answer.ToString();
        }
        private void btnTru_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNumber1.Text);
            double num2 = double.Parse(txtNumber2.Text);

            double answer = num1 - num2;
            txtAnswer.Text = answer.ToString();
        }
        private void btnNhan_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNumber1.Text);
            double num2 = double.Parse(txtNumber2.Text);

            double answer = num1 * num2;
            txtAnswer.Text = answer.ToString();
        }
        private void btnChia_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNumber1.Text);
            double num2 = double.Parse(txtNumber2.Text);

            double answer = num1 / num2;
            txtAnswer.Text = answer.ToString();
        }
    }
}
