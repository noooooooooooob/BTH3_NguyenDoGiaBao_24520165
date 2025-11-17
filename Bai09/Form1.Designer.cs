namespace Bai09
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
            rbtnFemale = new RadioButton();
            rbtnMale = new RadioButton();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            grbThongtinsv = new GroupBox();
            btnXoa = new Button();
            btnLuuThongTin = new Button();
            lbxDaChon = new ListBox();
            button2 = new Button();
            button1 = new Button();
            lbxChon = new ListBox();
            cbbChuyenNganh = new ComboBox();
            txtHoTen = new TextBox();
            txtMSSV = new TextBox();
            dataGridView1 = new DataGridView();
            ColumnMSSV = new DataGridViewTextBoxColumn();
            ColumnHoTen = new DataGridViewTextBoxColumn();
            ColumnChuyenNganh = new DataGridViewTextBoxColumn();
            ColumnGioiTinh = new DataGridViewTextBoxColumn();
            ColumnSoMon = new DataGridViewTextBoxColumn();
            ColumnCSDL = new DataGridViewTextBoxColumn();
            ColumnCSDLNC = new DataGridViewTextBoxColumn();
            ColumnPTTK = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            grbThongtinsv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // rbtnFemale
            // 
            rbtnFemale.AutoSize = true;
            rbtnFemale.Location = new Point(103, 15);
            rbtnFemale.Name = "rbtnFemale";
            rbtnFemale.Size = new Size(61, 29);
            rbtnFemale.TabIndex = 7;
            rbtnFemale.TabStop = true;
            rbtnFemale.Text = "Nữ";
            rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            rbtnMale.AutoSize = true;
            rbtnMale.Location = new Point(6, 15);
            rbtnMale.Name = "rbtnMale";
            rbtnMale.RightToLeft = RightToLeft.No;
            rbtnMale.Size = new Size(75, 29);
            rbtnMale.TabIndex = 6;
            rbtnMale.TabStop = true;
            rbtnMale.Text = "Nam";
            rbtnMale.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 222);
            label6.Name = "label6";
            label6.Size = new Size(235, 25);
            label6.TabIndex = 4;
            label6.Text = "Chọn các môn học tham gia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 176);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 3;
            label5.Text = "Giới tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 129);
            label4.Name = "label4";
            label4.Size = new Size(126, 25);
            label4.TabIndex = 2;
            label4.Text = "Chuyên ngành";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 86);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 1;
            label3.Text = "Họ tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 39);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 0;
            label2.Text = "Mã sinh viên";
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(rbtnMale);
            groupBox1.Controls.Add(rbtnFemale);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(225, 153);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(170, 48);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // grbThongtinsv
            // 
            grbThongtinsv.Controls.Add(btnXoa);
            grbThongtinsv.Controls.Add(btnLuuThongTin);
            grbThongtinsv.Controls.Add(lbxDaChon);
            grbThongtinsv.Controls.Add(button2);
            grbThongtinsv.Controls.Add(button1);
            grbThongtinsv.Controls.Add(lbxChon);
            grbThongtinsv.Controls.Add(cbbChuyenNganh);
            grbThongtinsv.Controls.Add(txtHoTen);
            grbThongtinsv.Controls.Add(txtMSSV);
            grbThongtinsv.Controls.Add(groupBox1);
            grbThongtinsv.Controls.Add(label2);
            grbThongtinsv.Controls.Add(label6);
            grbThongtinsv.Controls.Add(label3);
            grbThongtinsv.Controls.Add(label5);
            grbThongtinsv.Controls.Add(label4);
            grbThongtinsv.Location = new Point(51, 26);
            grbThongtinsv.Name = "grbThongtinsv";
            grbThongtinsv.Size = new Size(893, 433);
            grbThongtinsv.TabIndex = 1;
            grbThongtinsv.TabStop = false;
            grbThongtinsv.Text = "Thông tin sinh viên";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(483, 399);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(145, 34);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Xóa chọn";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuuThongTin
            // 
            btnLuuThongTin.Location = new Point(276, 399);
            btnLuuThongTin.Name = "btnLuuThongTin";
            btnLuuThongTin.Size = new Size(145, 34);
            btnLuuThongTin.TabIndex = 16;
            btnLuuThongTin.Text = "Lưu thông tin";
            btnLuuThongTin.UseVisualStyleBackColor = true;
            btnLuuThongTin.Click += btnLuuThongTin_Click;
            // 
            // lbxDaChon
            // 
            lbxDaChon.ItemHeight = 25;
            lbxDaChon.Location = new Point(513, 250);
            lbxDaChon.Name = "lbxDaChon";
            lbxDaChon.Size = new Size(354, 129);
            lbxDaChon.TabIndex = 15;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Location = new Point(411, 337);
            button2.Name = "button2";
            button2.Size = new Size(82, 42);
            button2.TabIndex = 14;
            button2.Text = "<";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Location = new Point(411, 250);
            button1.Name = "button1";
            button1.Size = new Size(82, 42);
            button1.TabIndex = 13;
            button1.Text = ">";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lbxChon
            // 
            lbxChon.ItemHeight = 25;
            lbxChon.Items.AddRange(new object[] { "Cơ sở dữ liệu", "Cơ sở DL NC", "PTTK hệ thống thông tin" });
            lbxChon.Location = new Point(41, 250);
            lbxChon.Name = "lbxChon";
            lbxChon.Size = new Size(354, 129);
            lbxChon.TabIndex = 12;
            // 
            // cbbChuyenNganh
            // 
            cbbChuyenNganh.FormattingEnabled = true;
            cbbChuyenNganh.Items.AddRange(new object[] { "Công nghệ Phần mềm", "Hệ thống Thông tin", "Khoa học Máy tính", "Mạng Máy tính & Truyền thông", "Khoa Công nghệ Thông tin", "Khoa Kỹ thuật Máy tính" });
            cbbChuyenNganh.Location = new Point(225, 121);
            cbbChuyenNganh.Name = "cbbChuyenNganh";
            cbbChuyenNganh.Size = new Size(511, 33);
            cbbChuyenNganh.TabIndex = 11;
            cbbChuyenNganh.Text = "Công nghệ Phần mềm";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(225, 80);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(350, 31);
            txtHoTen.TabIndex = 10;
            // 
            // txtMSSV
            // 
            txtMSSV.Location = new Point(225, 33);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(350, 31);
            txtMSSV.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnMSSV, ColumnHoTen, ColumnChuyenNganh, ColumnGioiTinh, ColumnSoMon, ColumnCSDL, ColumnCSDLNC, ColumnPTTK });
            dataGridView1.Location = new Point(42, 465);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(914, 300);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // ColumnMSSV
            // 
            ColumnMSSV.HeaderText = "MSSV";
            ColumnMSSV.MinimumWidth = 8;
            ColumnMSSV.Name = "ColumnMSSV";
            ColumnMSSV.ReadOnly = true;
            ColumnMSSV.Width = 200;
            // 
            // ColumnHoTen
            // 
            ColumnHoTen.HeaderText = "Họ Tên";
            ColumnHoTen.MinimumWidth = 8;
            ColumnHoTen.Name = "ColumnHoTen";
            ColumnHoTen.ReadOnly = true;
            ColumnHoTen.Width = 350;
            // 
            // ColumnChuyenNganh
            // 
            ColumnChuyenNganh.HeaderText = "Chuyên ngành";
            ColumnChuyenNganh.MinimumWidth = 8;
            ColumnChuyenNganh.Name = "ColumnChuyenNganh";
            ColumnChuyenNganh.ReadOnly = true;
            ColumnChuyenNganh.Width = 175;
            // 
            // ColumnGioiTinh
            // 
            ColumnGioiTinh.HeaderText = "Giới tính";
            ColumnGioiTinh.MinimumWidth = 8;
            ColumnGioiTinh.Name = "ColumnGioiTinh";
            ColumnGioiTinh.ReadOnly = true;
            ColumnGioiTinh.Width = 75;
            // 
            // ColumnSoMon
            // 
            ColumnSoMon.HeaderText = "Số môn";
            ColumnSoMon.MinimumWidth = 8;
            ColumnSoMon.Name = "ColumnSoMon";
            ColumnSoMon.ReadOnly = true;
            ColumnSoMon.Width = 50;
            // 
            // ColumnCSDL
            // 
            ColumnCSDL.HeaderText = "CSDL";
            ColumnCSDL.MinimumWidth = 8;
            ColumnCSDL.Name = "ColumnCSDL";
            ColumnCSDL.ReadOnly = true;
            ColumnCSDL.Visible = false;
            ColumnCSDL.Width = 150;
            // 
            // ColumnCSDLNC
            // 
            ColumnCSDLNC.HeaderText = "CSDLNC";
            ColumnCSDLNC.MinimumWidth = 8;
            ColumnCSDLNC.Name = "ColumnCSDLNC";
            ColumnCSDLNC.ReadOnly = true;
            ColumnCSDLNC.Visible = false;
            ColumnCSDLNC.Width = 150;
            // 
            // ColumnPTTK
            // 
            ColumnPTTK.HeaderText = "PTTK";
            ColumnPTTK.MinimumWidth = 8;
            ColumnPTTK.Name = "ColumnPTTK";
            ColumnPTTK.ReadOnly = true;
            ColumnPTTK.Visible = false;
            ColumnPTTK.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 791);
            Controls.Add(dataGridView1);
            Controls.Add(grbThongtinsv);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grbThongtinsv.ResumeLayout(false);
            grbThongtinsv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private RadioButton rbtnFemale;
        private RadioButton rbtnMale;
        private GroupBox groupBox1;
        private GroupBox grbThongtinsv;
        private ComboBox cbbChuyenNganh;
        private TextBox txtHoTen;
        private TextBox txtMSSV;
        private Button button2;
        private Button button1;
        private ListBox lbxChon;
        private ListBox lbxDaChon;
        private DataGridView dataGridView1;
        private Button btnLuuThongTin;
        private Button btnXoa;
        private DataGridViewTextBoxColumn ColumnMSSV;
        private DataGridViewTextBoxColumn ColumnHoTen;
        private DataGridViewTextBoxColumn ColumnChuyenNganh;
        private DataGridViewTextBoxColumn ColumnGioiTinh;
        private DataGridViewTextBoxColumn ColumnSoMon;
        private DataGridViewTextBoxColumn ColumnCSDL;
        private DataGridViewTextBoxColumn ColumnCSDLNC;
        private DataGridViewTextBoxColumn ColumnPTTK;
    }
}
