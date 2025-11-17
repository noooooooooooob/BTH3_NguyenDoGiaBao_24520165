using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Bai02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //đặt cờ hiệu
        bool ShouldPaint = false;
        //random
        Random rd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            ShouldPaint = true;
            this.Invalidate(); //yêu cầu vẽ lại form
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (!ShouldPaint) return;

            int x = rd.Next(this.ClientSize.Width);
            int y = rd.Next(this.ClientSize.Height);

            //vẽ chữ
            using (Font font = new Font("Segoe UI", 18, FontStyle.Bold))
            using (Brush brush = new SolidBrush(Color.FromArgb(rd.Next(256), rd.Next(256), rd.Next(256))))
            {
                e.Graphics.DrawString("Paint Event", font, brush, x, y);
            }

            // Sau khi vẽ xong thì tắt cờ (để không vẽ lại khi Form refresh)
            ShouldPaint = false;
        }
    }
}
