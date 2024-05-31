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
            label1.Text = "è„";
            label1.BackColor = Color.Blue;
            timer1.Enabled = true;
            timer2.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            vy = 15;
            label1.Text = "â∫";
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
            label1.Text = "í∑˙±óNìl";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vy = 15;
            label1.Text = "âE";
            label1.BackColor = Color.Red;
            timer1.Enabled = false;
            timer2.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vy = -15;
            label1.Text = "ç∂";
            label1.BackColor = Color.Yellow;
            timer1.Enabled = false;
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Left += vy;
        }
    }
}