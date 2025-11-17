namespace Bai06
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
            txtNhap = new TextBox();
            btnBackspace = new Button();
            btnCE = new Button();
            btnC = new Button();
            btnMC = new Button();
            btnMR = new Button();
            btnMS = new Button();
            btnMCong = new Button();
            btn0 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            menuStrip1 = new MenuStrip();
            editToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            btnNegative = new Button();
            btnCham = new Button();
            btnChia = new Button();
            btnNhan = new Button();
            btnTru = new Button();
            btnCong = new Button();
            btnBang = new Button();
            btnDao = new Button();
            btnLayDu = new Button();
            btnCang = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNhap
            // 
            txtNhap.Location = new Point(25, 36);
            txtNhap.Name = "txtNhap";
            txtNhap.Size = new Size(729, 31);
            txtNhap.TabIndex = 0;
            txtNhap.Text = "0";
            txtNhap.TextAlign = HorizontalAlignment.Right;
            txtNhap.KeyPress += On_KeyPress;
            // 
            // btnBackspace
            // 
            btnBackspace.Location = new Point(215, 97);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(142, 56);
            btnBackspace.TabIndex = 1;
            btnBackspace.Text = "Backspace";
            btnBackspace.UseVisualStyleBackColor = true;
            btnBackspace.Click += btnBackspace_Click;
            // 
            // btnCE
            // 
            btnCE.Location = new Point(378, 97);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(140, 56);
            btnCE.TabIndex = 2;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.Click += btnCE_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(539, 97);
            btnC.Name = "btnC";
            btnC.Size = new Size(138, 56);
            btnC.TabIndex = 3;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnMC
            // 
            btnMC.Location = new Point(52, 189);
            btnMC.Name = "btnMC";
            btnMC.Size = new Size(112, 34);
            btnMC.TabIndex = 4;
            btnMC.Text = "MC";
            btnMC.UseVisualStyleBackColor = true;
            btnMC.Click += btnMC_Click;
            // 
            // btnMR
            // 
            btnMR.Location = new Point(52, 243);
            btnMR.Name = "btnMR";
            btnMR.Size = new Size(112, 34);
            btnMR.TabIndex = 5;
            btnMR.Text = "MR";
            btnMR.UseVisualStyleBackColor = true;
            btnMR.Click += btnMR_Click;
            // 
            // btnMS
            // 
            btnMS.Location = new Point(52, 303);
            btnMS.Name = "btnMS";
            btnMS.Size = new Size(112, 34);
            btnMS.TabIndex = 6;
            btnMS.Text = "MS";
            btnMS.UseVisualStyleBackColor = true;
            btnMS.Click += btnMS_Click;
            // 
            // btnMCong
            // 
            btnMCong.Location = new Point(52, 362);
            btnMCong.Name = "btnMCong";
            btnMCong.Size = new Size(112, 34);
            btnMCong.TabIndex = 7;
            btnMCong.Text = "M+";
            btnMCong.UseVisualStyleBackColor = true;
            btnMCong.Click += btnMPlus_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(215, 362);
            btn0.Name = "btn0";
            btn0.Size = new Size(68, 34);
            btn0.TabIndex = 8;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnSo_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(215, 303);
            btn1.Name = "btn1";
            btn1.Size = new Size(68, 34);
            btn1.TabIndex = 9;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnSo_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(319, 303);
            btn2.Name = "btn2";
            btn2.Size = new Size(69, 34);
            btn2.TabIndex = 10;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnSo_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(431, 303);
            btn3.Name = "btn3";
            btn3.Size = new Size(59, 34);
            btn3.TabIndex = 11;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnSo_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(215, 243);
            btn4.Name = "btn4";
            btn4.Size = new Size(68, 34);
            btn4.TabIndex = 12;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnSo_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(319, 243);
            btn5.Name = "btn5";
            btn5.Size = new Size(69, 34);
            btn5.TabIndex = 13;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnSo_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(431, 243);
            btn6.Name = "btn6";
            btn6.Size = new Size(59, 34);
            btn6.TabIndex = 14;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnSo_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(215, 189);
            btn7.Name = "btn7";
            btn7.Size = new Size(68, 34);
            btn7.TabIndex = 15;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnSo_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(319, 189);
            btn8.Name = "btn8";
            btn8.Size = new Size(69, 34);
            btn8.TabIndex = 16;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnSo_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(431, 189);
            btn9.Name = "btn9";
            btn9.Size = new Size(59, 34);
            btn9.TabIndex = 17;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnSo_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, viewToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(58, 29);
            editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(65, 29);
            viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(65, 29);
            helpToolStripMenuItem.Text = "Help";
            // 
            // btnNegative
            // 
            btnNegative.Location = new Point(319, 362);
            btnNegative.Name = "btnNegative";
            btnNegative.Size = new Size(69, 34);
            btnNegative.TabIndex = 19;
            btnNegative.Text = "+/-";
            btnNegative.UseVisualStyleBackColor = true;
            btnNegative.Click += btnNegative_Click;
            // 
            // btnCham
            // 
            btnCham.Location = new Point(431, 362);
            btnCham.Name = "btnCham";
            btnCham.Size = new Size(59, 34);
            btnCham.TabIndex = 20;
            btnCham.Text = ".";
            btnCham.UseVisualStyleBackColor = true;
            btnCham.Click += btnCham_Click;
            // 
            // btnChia
            // 
            btnChia.Location = new Point(519, 189);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(58, 34);
            btnChia.TabIndex = 21;
            btnChia.Text = "/";
            btnChia.UseVisualStyleBackColor = true;
            btnChia.Click += btnPhepToan_Click;
            // 
            // btnNhan
            // 
            btnNhan.Location = new Point(519, 243);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(58, 34);
            btnNhan.TabIndex = 22;
            btnNhan.Text = "*";
            btnNhan.UseVisualStyleBackColor = true;
            btnNhan.Click += btnPhepToan_Click;
            // 
            // btnTru
            // 
            btnTru.Location = new Point(519, 303);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(58, 34);
            btnTru.TabIndex = 23;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = true;
            btnTru.Click += btnPhepToan_Click;
            // 
            // btnCong
            // 
            btnCong.Location = new Point(519, 362);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(58, 34);
            btnCong.TabIndex = 24;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += btnPhepToan_Click;
            // 
            // btnBang
            // 
            btnBang.Location = new Point(601, 362);
            btnBang.Name = "btnBang";
            btnBang.Size = new Size(76, 34);
            btnBang.TabIndex = 25;
            btnBang.Text = "=";
            btnBang.UseVisualStyleBackColor = true;
            btnBang.Click += btnBang_Click;
            // 
            // btnDao
            // 
            btnDao.Location = new Point(601, 303);
            btnDao.Name = "btnDao";
            btnDao.Size = new Size(76, 34);
            btnDao.TabIndex = 26;
            btnDao.Text = "1/x";
            btnDao.UseVisualStyleBackColor = true;
            btnDao.Click += btnDao_Click;
            // 
            // btnLayDu
            // 
            btnLayDu.Location = new Point(601, 243);
            btnLayDu.Name = "btnLayDu";
            btnLayDu.Size = new Size(76, 34);
            btnLayDu.TabIndex = 27;
            btnLayDu.Text = "%";
            btnLayDu.UseVisualStyleBackColor = true;
            btnLayDu.Click += btnLayDu_Click;
            // 
            // btnCang
            // 
            btnCang.Location = new Point(601, 189);
            btnCang.Name = "btnCang";
            btnCang.Size = new Size(76, 34);
            btnCang.TabIndex = 28;
            btnCang.Text = "sqrt";
            btnCang.UseVisualStyleBackColor = true;
            btnCang.Click += btnCang_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 426);
            Controls.Add(btnCang);
            Controls.Add(btnLayDu);
            Controls.Add(btnDao);
            Controls.Add(btnBang);
            Controls.Add(btnCong);
            Controls.Add(btnTru);
            Controls.Add(btnNhan);
            Controls.Add(btnChia);
            Controls.Add(btnCham);
            Controls.Add(btnNegative);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn0);
            Controls.Add(btnMCong);
            Controls.Add(btnMS);
            Controls.Add(btnMR);
            Controls.Add(btnMC);
            Controls.Add(btnC);
            Controls.Add(btnCE);
            Controls.Add(btnBackspace);
            Controls.Add(txtNhap);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNhap;
        private Button btnBackspace;
        private Button btnCE;
        private Button btnC;
        private Button btnMC;
        private Button btnMR;
        private Button btnMS;
        private Button btnMCong;
        private Button btn0;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private Button btnNegative;
        private Button btnCham;
        private Button btnChia;
        private Button btnNhan;
        private Button btnTru;
        private Button btnCong;
        private Button btnBang;
        private Button btnDao;
        private Button btnLayDu;
        private Button btnCang;
    }
}
