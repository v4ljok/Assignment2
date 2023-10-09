namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double classA;
                double classB;
                double classC;
                double sum;

                classA = 15 * double.Parse(textBox1.Text);
                classB = 12 * double.Parse(textBox2.Text);
                classC = 9 * double.Parse(textBox3.Text);
                sum = classA + classB + classC;

                textBox4.Text = "$" + classA.ToString("N2");
                textBox5.Text = "$" + classB.ToString("N2");
                textBox6.Text = "$" + classC.ToString("N2");
                textBox7.Text = "$" + sum.ToString("N2");
            }
            catch
            {
                MessageBox.Show("Invalid data was enetered");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }
    }
}