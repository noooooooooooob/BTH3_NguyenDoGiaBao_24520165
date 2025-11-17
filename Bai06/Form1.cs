using System;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Bai06
{
    public partial class Form1 : Form
    {
        double result = 0;
        double SoHang1 = 0;
        double SoHang2 = 0;
        bool isOperatorLast = false;
        bool isChamThuNhat = false;
        bool isChamThuHai = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void On_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnCham_Click(object sender, EventArgs e)
        {
            //kiêm tra nếu đã có dấu chấm thập phân thì không thêm nữa
            if (!isChamThuNhat)
            {
                txtNhap.Text += ".";
                isChamThuNhat = true;
                return;
            }
            if (isOperatorLast && !isChamThuHai)
            {
                txtNhap.Text += ".";
                isChamThuHai = true;
                return;
            }
        }

        private void btnSo_Click(object sender, EventArgs e)
        {
            //lấy đối tượng Button từ sender (nút được nhấn)
            Button btn = sender as Button;
            if (btn != null)
            {
                if (txtNhap.Text == "0")
                    txtNhap.Text = btn.Text;
                else
                    txtNhap.Text += btn.Text;
            }
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            //nếu bắt đầu bằng dấu âm
            if (txtNhap.Text.StartsWith("-"))
            {
                //loại bỏ dấu âm
                //Substring(1) tạo ra chuỗi con bắt đầu từ vị trí chỉ số 1 (đếm từ 0) đến hết.
                //Vì '-' nằm ở vị trí 0, nên bỏ qua ký tự đầu tiên → tức là xóa dấu trừ.
                txtNhap.Text = txtNhap.Text.Substring(1);
            }
            else
            {
                //thêm dấu âm vào đầu
                txtNhap.Text = "-" + txtNhap.Text;
            }
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text.Length > 0)
            {
                if (txtNhap.Text.EndsWith(" "))
                {
                    // Xóa dấu cách và ký tự phép toán trước đó
                    txtNhap.Text = txtNhap.Text.Remove(txtNhap.Text.Length - 3, 3);
                    isOperatorLast = false;
                    return;
                }
                if (txtNhap.Text.EndsWith("."))
                {
                    // Xóa dấu chấm thập phân
                    txtNhap.Text = txtNhap.Text.Remove(txtNhap.Text.Length - 1, 1);
                    if (!isOperatorLast && isChamThuNhat)
                        isChamThuNhat = false;
                    if (isOperatorLast && isChamThuHai)
                        isChamThuHai = false;

                    return;
                }
                // Xóa 1 ký tự cuối cùng
                txtNhap.Text = txtNhap.Text.Remove(txtNhap.Text.Length - 1, 1);
            }

            // Nếu xóa hết thì trả về "0"
            if (txtNhap.Text == "")
                txtNhap.Text = "0";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            // Xóa số hiện tại, giữ phép toán cũ
            txtNhap.Text = "0";
            isChamThuNhat = false;
            isChamThuHai = false;
            isOperatorLast = false;
            result = 0;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            // Xóa tất cả: kết quả, phép toán, màn hình
            txtNhap.Text = "0";
            isChamThuNhat = false;
            isChamThuHai = false;
            isOperatorLast = false;
            result = 0;
        }

        private void btnPhepToan_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text.EndsWith("."))
            {
                txtNhap.Text = txtNhap.Text.Remove(txtNhap.Text.Length - 1, 1);
                if (!isOperatorLast && isChamThuNhat)
                    isChamThuNhat = false;
                if (isOperatorLast && isChamThuHai)
                    isChamThuHai = false;
            }

            Button btn = sender as Button;
            if (btn != null && btn != btnBang && !isOperatorLast)
            {
                isOperatorLast = true;
                txtNhap.Text += " " + btn.Text + " ";

            }
        }
        private void btnBang_Click(object sender, EventArgs e)
        {
            //Lấy nội dung trong TextBox (nơi bạn đang nhập biểu thức, ví dụ "123 + 456").
            //Gán vào biến expression để xử lý tính toán.
            string expression = txtNhap.Text;

            //Tạo một bảng dữ liệu ảo (DataTable) trong .NET.
            //Bình thường DataTable dùng để lưu dữ liệu dạng bảng,
            //nhưng nó có một hàm đặc biệt là Compute() có thể tính toán biểu thức toán học từ chuỗi.
            DataTable table = new DataTable();

            //Hàm Compute() nhận 2 tham số:
            //Biểu thức toán học cần tính(chuỗi)
            //Bộ lọc(thường để trống "" nếu không dùng lọc dữ liệu)
            var result = table.Compute(expression, "");



            // Chuyển kết quả sang kiểu double để kiểm tra và định dạng
            //do hàm Compute trả về kiểu object nên cần chuyển đổi.
            //object là kiểu dữ liệu tổng quát trong C# có thể chứa bất kỳ kiểu dữ liệu nào.
            double value = Convert.ToDouble(result);
            if (value == Math.Truncate(value))
                // Rút gọn .0 dư thừa
                txtNhap.Text = ((int)value).ToString();
            else
                // Rút gọn đến 10 chữ số, bỏ các số 0 thừa
                txtNhap.Text = value.ToString("G10");


            //cập nhật trạng thái
            isOperatorLast = false;
            isChamThuNhat = txtNhap.Text.Contains(".");
            isChamThuHai = false;
        }

        private void btnDao_Click(object sender, EventArgs e)
        {
            // try catch để xử lý lỗi chuyển đổi
            // nếu đoạn code có khả năng lỗi cho vô try, nếu nó gây lỗi thì sẽ nhảy vô catch để xử lý
            // try nếu thành công, catch nếu lỗi
            try
            {
                double value = Convert.ToDouble(txtNhap.Text);

                if (value == 0)
                {
                    MessageBox.Show("Không thể chia cho 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double nghichDao = 1 / value;

                // Rút gọn .0 dư thừa
                if (nghichDao == Math.Truncate(nghichDao))
                    txtNhap.Text = ((int)nghichDao).ToString();
                else
                    txtNhap.Text = nghichDao.ToString("G10");

                // Cập nhật trạng thái
                isOperatorLast = false;
                isChamThuNhat = txtNhap.Text.Contains(".");
                isChamThuHai = false;
            }
            catch
            {
                MessageBox.Show("Giá trị không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLayDu_Click(object sender, EventArgs e)
        {
            try
            {
                // Tách biểu thức thành các phần
                //khi găp ' ' sẽ tách chuỗi thành các phần riêng biệt
                string[] parts = txtNhap.Text.Split(' ');

                if (parts.Length == 3)
                {
                    double soThu1 = Convert.ToDouble(parts[0]);
                    string phepToan = parts[1];
                    double soThu2 = Convert.ToDouble(parts[2]);

                    double result = 0;

                    switch (phepToan)
                    {
                        case "+":
                            result = soThu1 + soThu1 * soThu2 / 100;
                            break;
                        case "-":
                            result = soThu1 - soThu1 * soThu2 / 100;
                            break;
                        case "*":
                            result = soThu1 * soThu2 / 100;
                            break;
                        case "/":
                            result = soThu1 / (soThu2 / 100);
                            break;
                    }

                    // Rút gọn .0 dư
                    if (result == Math.Truncate(result))
                        txtNhap.Text = ((int)result).ToString();
                    else
                        txtNhap.Text = result.ToString("G10");

                    isOperatorLast = false;
                    isChamThuNhat = txtNhap.Text.Contains(".");
                    isChamThuHai = false;
                }
                else
                {
                    // Nếu chỉ nhập 1 số → chia cho 100
                    double value = Convert.ToDouble(txtNhap.Text);
                    double result = value / 100;

                    if (result == Math.Truncate(result))
                        txtNhap.Text = ((int)result).ToString();
                    else
                        txtNhap.Text = result.ToString("G10");

                    isOperatorLast = false;
                    isChamThuNhat = txtNhap.Text.Contains(".");
                    isChamThuHai = false;
                }
            }
            catch
            {
                MessageBox.Show("Biểu thức không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCang_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(txtNhap.Text);
                if (value < 0)
                {
                    MessageBox.Show("Không thể tính căn bậc hai của số âm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                double canBang = Math.Sqrt(value);
                // Rút gọn .0 dư thừa
                if (canBang == Math.Truncate(canBang))
                    txtNhap.Text = ((int)canBang).ToString();
                else
                    txtNhap.Text = canBang.ToString("G10");
                // Cập nhật trạng thái
                isOperatorLast = false;
                isChamThuNhat = txtNhap.Text.Contains(".");
                isChamThuHai = false;
            }
            catch
            {
                MessageBox.Show("Giá trị không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        double memory = 0;
        // Nút MC - Xóa bộ nhớ
        private void btnMC_Click(object sender, EventArgs e)
        {
            memory = 0;
            MessageBox.Show("Đã xóa bộ nhớ (MC).", "Memory", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Nút MR - Gọi lại bộ nhớ
        private void btnMR_Click(object sender, EventArgs e)
        {
            txtNhap.Text = memory.ToString();
            isOperatorLast = false;
            isChamThuNhat = txtNhap.Text.Contains(".");
            isChamThuHai = false;
        }

        // Nút MS - Lưu giá trị hiện tại vào bộ nhớ
        private void btnMS_Click(object sender, EventArgs e)
        {
            try
            {
                memory = Convert.ToDouble(txtNhap.Text);
                MessageBox.Show("Đã lưu vào bộ nhớ (MS).", "Memory", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Giá trị không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút M+ - Cộng giá trị hiện tại vào bộ nhớ
        private void btnMPlus_Click(object sender, EventArgs e)
        {
            try
            {
                memory += Convert.ToDouble(txtNhap.Text);
                MessageBox.Show("Đã cộng vào bộ nhớ (M+).", "Memory", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Giá trị không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút M- - Trừ giá trị hiện tại khỏi bộ nhớ
        private void btnMMinus_Click(object sender, EventArgs e)
        {
            try
            {
                memory -= Convert.ToDouble(txtNhap.Text);
                MessageBox.Show("Đã trừ khỏi bộ nhớ (M-).", "Memory", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Giá trị không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
