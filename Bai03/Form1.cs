namespace Bai03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int r = rd.Next(0, 256);
            int g = rd.Next(0, 256);
            int b = rd.Next(0, 256);
            //phải dùng this. thay vì Form1.
            this.BackColor = Color.FromArgb(r, g, b);
        }
    }
}
