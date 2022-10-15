namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = Program.Task24(Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = Program.Task27(Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label13.Text = Program.Task30(Convert.ToDouble(textBox7.Text), Convert.ToDouble(textBox15.Text), Convert.ToDouble(textBox8.Text), Convert.ToDouble(textBox16.Text), Convert.ToDouble(textBox6.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label19.Text = Program.Task2(Convert.ToDouble(textBox10.Text), Convert.ToDouble(textBox11.Text), Convert.ToDouble(textBox9.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label25.Text = Program.Task6(Convert.ToDouble(textBox13.Text), Convert.ToDouble(textBox14.Text), Convert.ToDouble(textBox12.Text));
        }
    }
}