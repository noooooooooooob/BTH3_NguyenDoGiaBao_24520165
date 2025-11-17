namespace Bai09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //chuyển các mục được chọn từ lbxChon sang lbxKhongChon
            lbxDaChon.Items.AddRange(lbxChon.SelectedItems.Cast<string>().ToArray());
            //xóa các mục đã chuyển khỏi lbxChon
            while (lbxChon.SelectedItems.Count > 0)
            {
                lbxChon.Items.Remove(lbxChon.SelectedItems[0]);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //chuyển các mục được chọn từ lbxDaChon sang lbxChon
            lbxChon.Items.AddRange(lbxDaChon.SelectedItems.Cast<string>().ToArray());
            //xóa các mục đã chuyển khỏi lbxDaChon
            while (lbxDaChon.SelectedItems.Count > 0)
            {
                lbxDaChon.Items.Remove(lbxDaChon.SelectedItems[0]);
            }
        }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            //check xem có trùng MSSV ko
            //nếu trùng thì cập nhật
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //nếu trùng MSSV thì cập nhật
                //kiểm tra null để tránh lỗi
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == txtMSSV.Text)
                {
                    //cập nhật thông tin
                    row.Cells[1].Value = txtHoTen.Text;
                    row.Cells[2].Value = cbbChuyenNganh.SelectedItem.ToString();
                    row.Cells[3].Value = rbtnMale.Checked ? "Nam" : "Nữ";
                    row.Cells[4].Value = lbxDaChon.Items.Count;
                    MessageBox.Show("Cập nhật thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            //kiểm tra dữ liệu nhập vào có ko
            //vì giới tính mặc định đã chọn nên ko cần kiểm tra
            if (txtMSSV.Text == "" || txtHoTen.Text == "" || cbbChuyenNganh.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //cập nhật cho dataGridView
            string tempMSSV = txtMSSV.Text;
            string tempHoTen = txtHoTen.Text;
            string tempChuyenNganh = cbbChuyenNganh.SelectedItem.ToString();
            string tempGioiTinh = rbtnMale.Checked ? "Nam" : "Nữ";
            int tempSoMonDaChon = lbxDaChon.Items.Count;
            //thêm học môn gì kiểm tra từng môn
            bool tempCSDL = lbxDaChon.Items.Contains("Cơ sở dữ liệu");
            bool tempCSDLNC = lbxDaChon.Items.Contains("Cơ sở DL NC");
            bool tempPTTK = lbxDaChon.Items.Contains("PTTK hệ thống thông tin");


            dataGridView1.Rows.Add(tempMSSV, tempHoTen, tempChuyenNganh, tempGioiTinh, tempSoMonDaChon, tempCSDL, tempCSDLNC, tempPTTK);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra không phải click vào header
            if (e.RowIndex >= 0)
            {
                // Làm nổi bật hàng được chọn
                dataGridView1.Rows[e.RowIndex].Selected = true;

                // Lấy dữ liệu từ hàng được chọn
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Hiển thị thông tin lên form nhập
                txtMSSV.Text = selectedRow.Cells[0].Value?.ToString() ?? "";
                txtHoTen.Text = selectedRow.Cells[1].Value?.ToString() ?? "";

                // Chuyên ngành
                string chuyenNganh = selectedRow.Cells[2].Value?.ToString() ?? "";
                cbbChuyenNganh.SelectedItem = chuyenNganh;

                // Giới tính
                string gioiTinh = selectedRow.Cells[3].Value?.ToString() ?? "";
                if (gioiTinh == "Nam")
                {
                    rbtnMale.Checked = true;
                }
                else
                {
                    rbtnFemale.Checked = true;
                }


                //reset lbxChon và lbxDaChon
                lbxChon.Items.Clear();
                lbxDaChon.Items.Clear();
                // kiểm tra xem trong gridview có môn học nào đã chọn ko rồi thêm vào lbxDaChon và lbxChon
                if (selectedRow.Cells[5].Value != null && (bool)selectedRow.Cells[5].Value)
                {
                    lbxDaChon.Items.Add("Cơ sở dữ liệu");
                }
                else
                {
                    lbxChon.Items.Add("Cơ sở dữ liệu");
                }

                if (selectedRow.Cells[6].Value != null && (bool)selectedRow.Cells[6].Value)
                {
                    lbxDaChon.Items.Add("Cơ sở DL NC");
                }
                else
                {
                    lbxChon.Items.Add("Cơ sở DL NC");
                }

                if (selectedRow.Cells[7].Value != null && (bool)selectedRow.Cells[7].Value)
                {
                    lbxDaChon.Items.Add("PTTK hệ thống thông tin");
                }
                else
                {
                    lbxChon.Items.Add("PTTK hệ thống thông tin");
                }


            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Kiểm tra có hàng nào được chọn không nếu chọn hàng trống thì báo lỗi
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Xóa hàng được chọn
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
        }
    }
}
