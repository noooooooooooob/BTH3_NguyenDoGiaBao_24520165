using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AddEvent("Construction");
        }

        private void AddEvent(string eventName)
        {
            string time = DateTime.Now.ToString("HH:mm:ss");
            listBox1.Items.Add($">> {eventName} [{time}]");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddEvent("Load");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            AddEvent("Activated");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            AddEvent("Shown");
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            AddEvent("Deactivate");
        }

        private async void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            AddEvent("FormClosing");

            // Tạm thời không cho form đóng
            e.Cancel = true;

            // Đợi 2 giây mà không khóa giao diện
            await Task.Delay(2000);
            // vì closed sẽ dispose form, nên ta phải thêm formclosed ở đây
            AddEvent("FormClosed");

            await Task.Delay(2000);

            // Hủy đăng ký sự kiện FormClosing để không bị lặp vô hạn
            this.FormClosing -= Form1_FormClosing;

            //Giờ mới thật sự đóng form
            //gọi lại formclosing -> formclosed
            //vì formclosing đã bị hủy đăng ký nên sẽ không lặp vô hạn
            this.Close();
        }



        private async void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            AddEvent("FormClosed");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog(); // mở Form2, Form1 sẽ bị Deactivate
            // khi Form2 đóng → Activated sẽ được kích hoạt lại
        }
    }
}
