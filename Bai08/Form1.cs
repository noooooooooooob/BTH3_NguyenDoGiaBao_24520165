namespace Bai08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ko cho phep nhập chữ
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            //kiểm tra đã có dấu chấm chưa
            //> -1 nghĩa là đã có dấu chấm vì IndexOf trả về vị trí của dấu chấm trong chuỗi nếu có, ngược lại trả về -1
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.Length == 0)
            {
                e.Handled = true;
            }
            //ko cho phep nhập chữ và cho phép nhập dấu chấm
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btnThemCapNhat_Click(object sender, EventArgs e)
        {
            if (txtSTK.Text == "" || txtTen.Text == "" || txtDiaChi.Text == "" || txtSoTien.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double soTien = double.Parse(txtSoTien.Text);
            bool found = false;
            //kiểm tra stk có tồn tại chưa
            foreach (ListViewItem item in lvTaiKhoan.Items)
            {
                if (item.SubItems[1].Text == txtSTK.Text)
                {
                    //cập nhật
                    item.SubItems[2].Text = txtTen.Text;
                    item.SubItems[3].Text = txtDiaChi.Text;
                    item.SubItems[4].Text = soTien.ToString();
                    MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    found = true;
                }
            }

            if (!found)
            {
                //thêm mới
                int i = lvTaiKhoan.Items.Count + 1;
                ListViewItem newItem = new ListViewItem(i.ToString()); // vì cột đầu là STT nên ta tạo item mới với STT
                newItem.SubItems.Add(txtSTK.Text);
                newItem.SubItems.Add(txtTen.Text);
                newItem.SubItems.Add(txtDiaChi.Text);
                newItem.SubItems.Add(soTien.ToString());
                lvTaiKhoan.Items.Add(newItem);
                MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    



            // Cập nhật tổng tiền
            txtTongTien.Text = (from ListViewItem item in lvTaiKhoan.Items select Double.Parse(item.SubItems[4].Text)).Sum().ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //xóa tài khoản theo STK
            for (int i = 0;i < lvTaiKhoan.Items.Count; i++)
            {
                if (lvTaiKhoan.Items[i].SubItems[1].Text == txtSTK.Text)
                {
                    //kiểm tra xác nhận xóa
                    DialogResult result1 = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    //nếu chọn No thì thoát
                    if (result1 == DialogResult.No)
                    {
                        return;
                    }

                    //xóa item
                    lvTaiKhoan.Items.RemoveAt(i);
                    // Cập nhật lại STT
                    for (int j = 0; j < lvTaiKhoan.Items.Count; j++)
                    {
                        lvTaiKhoan.Items[j].SubItems[0].Text = (j + 1).ToString();
                    }
                    // Cập nhật tổng tiền
                    txtTongTien.Text = (from ListViewItem item in lvTaiKhoan.Items select Double.Parse(item.SubItems[4].Text)).Sum().ToString();
                    MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }


            //không tìm thấy stk thì xóa theo item được chọn



            //kiểm tra có chọn item để xóa ko
            if (lvTaiKhoan.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //kiểm tra xác nhận xóa
            DialogResult result2 = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //nếu chọn No thì thoát
            if (result2 == DialogResult.No)
            {
                return;
            }

            //nếu chọn Yes thì xóa
            // Xóa item được chọn
            lvTaiKhoan.Items.Remove(lvTaiKhoan.SelectedItems[0]);
            // Cập nhật lại STT
            for (int i = 0; i < lvTaiKhoan.Items.Count; i++)
            {
                lvTaiKhoan.Items[i].SubItems[0].Text = (i + 1).ToString();
            }

            //cập nhật lại tổng tiền
            txtTongTien.Text = (from ListViewItem item in lvTaiKhoan.Items select Double.Parse(item.SubItems[4].Text)).Sum().ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lvTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTaiKhoan.SelectedItems.Count > 0)
            {
                ListViewItem item = lvTaiKhoan.SelectedItems[0];
                txtSTK.Text = item.SubItems[1].Text;
                txtTen.Text = item.SubItems[2].Text;
                txtDiaChi.Text = item.SubItems[3].Text;
                txtSoTien.Text = item.SubItems[4].Text;
            }
        }




    }
}

