namespace Bai07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool[,] isChose = new bool[3, 5];
        bool[,] is_Sold = new bool[3, 5];

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn != null)
            {
                int row = btn.TabIndex / 5;
                int col = btn.TabIndex % 5;


                //Kiểm tra nếu ghế đã bán thì không cho chọn
                //thoát khỏi hàm nếu ghế đã bán
                if (is_Sold[row, col])
                {
                    MessageBox.Show("This seat is already sold.");
                    return;
                }


                // Nếu đang chọn thì bỏ chọn, nếu chưa chọn thì chọn
                isChose[row, col] = !isChose[row, col];
                btn.BackColor = isChose[row, col] ? Color.Blue : Color.White;
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int KetQua = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (isChose[i, j])
                    {
                        //Find the button by its TabIndex
                        int tabIndex = i * 5 + j;

                        //Tìm nút tương ứng và đổi màu
                        //.OfType<Button>() Lọc ra tất cả control kiểu Button
                        //.FirstOrDefault(b => b.TabIndex == tabIndex) Lọc ra nút có TabIndex tương ứng
                        //b => b.TabIndex == tabIndex Đây là biểu thức lambda, nghĩa là “chọn button b có TabIndex bằng biến tabIndex”.

                        Button btn = this.Controls.OfType<Button>().FirstOrDefault(b => b.TabIndex == tabIndex);
                        if (btn != null)
                        {
                            switch (i)
                            {
                                case 0:
                                    KetQua += 8000;
                                    break;
                                case 1:
                                    KetQua += 6500;
                                    break;
                                case 2:
                                    KetQua += 5000;
                                    break;
                            }
                            is_Sold[i, j] = true;
                            isChose[i, j] = false; //reset trạng thái chọn
                            btn.BackColor = Color.Yellow; //đổi màu ghế đã bán
                        }
                    }
                }

            }

            txtThanhTien.Text = KetQua.ToString();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (isChose[i, j])
                    {
                        //Find the button by its TabIndex
                        int tabIndex = i * 5 + j;
                        //Tìm nút tương ứng và đổi màu
                        //.OfType<Button>() Lọc ra tất cả control kiểu Button
                        //.FirstOrDefault(b => b.TabIndex == tabIndex) Lọc ra nút có TabIndex tương ứng
                        //b => b.TabIndex == tabIndex Đây là biểu thức lambda, nghĩa là “chọn button b có TabIndex bằng biến tabIndex”.
                        Button btn = this.Controls.OfType<Button>().FirstOrDefault(b => b.TabIndex == tabIndex);
                        if (btn != null)
                        {
                            isChose[i, j] = false; //reset trạng thái chọn
                            btn.BackColor = Color.White; //đổi màu ghế về trạng thái ban đầu
                        }
                    }
                }
            }

            txtThanhTien.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cách thoát chương trình
            Application.Exit();
        }
    }
}
