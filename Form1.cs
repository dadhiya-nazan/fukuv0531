using System.Diagnostics.SymbolStore;

namespace fukuv0531
{
    public partial class Form1 : Form
    {

        int vy = 15;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vy = -15;
            label1.Text = "��";
            label1.BackColor = Color.Blue;
            timer1.Enabled = true;
            timer2.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            vy = 15;
            label1.Text = "��";
            label1.BackColor = Color.Green;
            timer1.Enabled = true;
            timer2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Top += vy;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            label1.Text = "�����N�l";
            label1.BackColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vy = 15;
            label1.Text = "�E";
            label1.BackColor = Color.Red;
            timer1.Enabled = false;
            timer2.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vy = -15;
            label1.Text = "��";
            label1.BackColor = Color.Yellow;
            timer1.Enabled = false;
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Left += vy;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            float fw = 3.14f;
            string str = $"{fw}";
            int a = (int)fw;
            //MessageBox.Show($"{a}");
            str = "3";
            a = int.Parse(str); //Parse ���e
            fw = a;
            fw = float.Parse(str);
        }
    }
}