namespace Bai08
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtSTK = new TextBox();
            label2 = new Label();
            txtTen = new TextBox();
            label3 = new Label();
            txtDiaChi = new TextBox();
            label4 = new Label();
            txtSoTien = new TextBox();
            label5 = new Label();
            btnThem = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            lvTaiKhoan = new ListView();
            STT = new ColumnHeader();
            MaTaiKhoan = new ColumnHeader();
            TenKhachHang = new ColumnHeader();
            DiaChi = new ColumnHeader();
            SoTien = new ColumnHeader();
            label6 = new Label();
            txtTongTien = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 20F);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(115, 23);
            label1.Name = "label1";
            label1.Size = new Size(684, 52);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            // 
            // txtSTK
            // 
            txtSTK.Location = new Point(285, 109);
            txtSTK.Name = "txtSTK";
            txtSTK.Size = new Size(514, 31);
            txtSTK.TabIndex = 1;
            txtSTK.KeyPress += txtSTK_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 109);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 2;
            label2.Text = "Số tài khoản";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(285, 149);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(514, 31);
            txtTen.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 149);
            label3.Name = "label3";
            label3.Size = new Size(134, 25);
            label3.TabIndex = 4;
            label3.Text = "Tên khách hàng";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(285, 196);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(514, 31);
            txtDiaChi.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 196);
            label4.Name = "label4";
            label4.Size = new Size(161, 25);
            label4.TabIndex = 6;
            label4.Text = "Địa chỉ khách hàng";
            // 
            // txtSoTien
            // 
            txtSoTien.Location = new Point(285, 243);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(514, 31);
            txtSoTien.TabIndex = 7;
            txtSoTien.KeyPress += txtSoTien_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 243);
            label5.Name = "label5";
            label5.Size = new Size(194, 25);
            label5.TabIndex = 8;
            label5.Text = "Số tiền trong tài khoản";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(361, 302);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(153, 34);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm / Cập nhật";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThemCapNhat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(534, 302);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(668, 302);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 34);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lvTaiKhoan
            // 
            lvTaiKhoan.Columns.AddRange(new ColumnHeader[] { STT, MaTaiKhoan, TenKhachHang, DiaChi, SoTien });
            lvTaiKhoan.FullRowSelect = true;
            lvTaiKhoan.Location = new Point(56, 342);
            lvTaiKhoan.MultiSelect = false;
            lvTaiKhoan.Name = "lvTaiKhoan";
            lvTaiKhoan.Size = new Size(800, 255);
            lvTaiKhoan.TabIndex = 12;
            lvTaiKhoan.UseCompatibleStateImageBehavior = false;
            lvTaiKhoan.View = View.Details;
            lvTaiKhoan.SelectedIndexChanged += lvTaiKhoan_SelectedIndexChanged;
            // 
            // STT
            // 
            STT.Text = "STT";
            STT.Width = 50;
            // 
            // MaTaiKhoan
            // 
            MaTaiKhoan.Text = "Mã Tài Khoản";
            MaTaiKhoan.Width = 200;
            // 
            // TenKhachHang
            // 
            TenKhachHang.Text = "Tên khách hàng";
            TenKhachHang.Width = 200;
            // 
            // DiaChi
            // 
            DiaChi.Text = "Địa chỉ";
            DiaChi.Width = 200;
            // 
            // SoTien
            // 
            SoTien.Text = "Số tiền";
            SoTien.Width = 150;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(466, 616);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 13;
            label6.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            txtTongTien.BackColor = SystemColors.ActiveBorder;
            txtTongTien.Location = new Point(563, 616);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(316, 31);
            txtTongTien.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 667);
            Controls.Add(txtTongTien);
            Controls.Add(label6);
            Controls.Add(lvTaiKhoan);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(label5);
            Controls.Add(txtSoTien);
            Controls.Add(label4);
            Controls.Add(txtDiaChi);
            Controls.Add(label3);
            Controls.Add(txtTen);
            Controls.Add(label2);
            Controls.Add(txtSTK);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSTK;
        private Label label2;
        private TextBox txtTen;
        private Label label3;
        private TextBox txtDiaChi;
        private Label label4;
        private TextBox txtSoTien;
        private Label label5;
        private Button btnThem;
        private Button btnXoa;
        private Button btnThoat;
        private ListView lvTaiKhoan;
        private ColumnHeader STT;
        private ColumnHeader MaTaiKhoan;
        private ColumnHeader TenKhachHang;
        private ColumnHeader DiaChi;
        private ColumnHeader SoTien;
        private Label label6;
        private TextBox txtTongTien;
    }
}
