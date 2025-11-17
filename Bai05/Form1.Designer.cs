namespace Bai05
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
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
            lblNumber1 = new Label();
            lblNumber2 = new Label();
            btnCong = new Button();
            btnTru = new Button();
            btnNhan = new Button();
            btnChia = new Button();
            lblAnswer = new Label();
            txtAnswer = new TextBox();
            SuspendLayout();
            // 
            // txtNumber1
            // 
            txtNumber1.Location = new Point(227, 50);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(440, 31);
            txtNumber1.TabIndex = 0;
            txtNumber1.KeyPress += txtNumberChiChoPhepNhapSo_KeyPress;
            // 
            // txtNumber2
            // 
            txtNumber2.Location = new Point(227, 100);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(440, 31);
            txtNumber2.TabIndex = 1;
            txtNumber2.KeyPress += txtNumberChiChoPhepNhapSo_KeyPress;
            // 
            // lblNumber1
            // 
            lblNumber1.AutoSize = true;
            lblNumber1.Location = new Point(109, 50);
            lblNumber1.Name = "lblNumber1";
            lblNumber1.Size = new Size(89, 25);
            lblNumber1.TabIndex = 2;
            lblNumber1.Text = "number 1";
            // 
            // lblNumber2
            // 
            lblNumber2.AutoSize = true;
            lblNumber2.Location = new Point(109, 100);
            lblNumber2.Name = "lblNumber2";
            lblNumber2.Size = new Size(89, 25);
            lblNumber2.TabIndex = 3;
            lblNumber2.Text = "number 2";
            // 
            // btnCong
            // 
            btnCong.Location = new Point(170, 170);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(60, 60);
            btnCong.TabIndex = 4;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += btnCong_Click;
            // 
            // btnTru
            // 
            btnTru.Location = new Point(270, 170);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(60, 60);
            btnTru.TabIndex = 5;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = true;
            btnTru.Click += btnTru_Click;
            // 
            // btnNhan
            // 
            btnNhan.Location = new Point(370, 170);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(60, 60);
            btnNhan.TabIndex = 6;
            btnNhan.Text = "X";
            btnNhan.UseVisualStyleBackColor = true;
            btnNhan.Click += btnNhan_Click;
            // 
            // btnChia
            // 
            btnChia.Location = new Point(470, 170);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(60, 60);
            btnChia.TabIndex = 7;
            btnChia.Text = "/";
            btnChia.UseVisualStyleBackColor = true;
            btnChia.Click += btnChia_Click;
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.Location = new Point(139, 325);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(70, 25);
            lblAnswer.TabIndex = 9;
            lblAnswer.Text = "Answer";
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(227, 325);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(440, 31);
            txtAnswer.TabIndex = 10;
            txtAnswer.KeyPress += txtAnswer_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAnswer);
            Controls.Add(lblAnswer);
            Controls.Add(btnChia);
            Controls.Add(btnNhan);
            Controls.Add(btnTru);
            Controls.Add(btnCong);
            Controls.Add(lblNumber2);
            Controls.Add(lblNumber1);
            Controls.Add(txtNumber2);
            Controls.Add(txtNumber1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private Label lblNumber1;
        private Label lblNumber2;
        private Button btnCong;
        private Button btnTru;
        private Button btnNhan;
        private Button btnChia;
        private Label lblAnswer;
        private TextBox txtAnswer;
    }
}
