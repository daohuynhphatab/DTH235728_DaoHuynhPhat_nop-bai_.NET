using System.Runtime.CompilerServices;

namespace bai2._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TinhToan('+');
        }
        private void button2_Click(object sender, EventArgs e)
        {
            TinhToan('-');
        }
        private void button3_Click(object sender, EventArgs e)
        {
            TinhToan('*');
        }
        private void button4_Click(object sender, EventArgs e)
        {
            TinhToan('/');
        }
        private bool TryGetInputs(out double a, out double b)
        {
            try
            {
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                return true;
            }
            catch
            {
                a = 0; b = 0;
                MessageBox.Show("Invalid input. Please enter numeric values.");
                return false;
            }

        }
        private void TinhToan(char Phep)
        {
            if (TryGetInputs(out double a, out double b))
            {
                double kq = 0;
                switch (Phep)
                {
                    case '+':
                        kq = a + b;
                        break;
                    case '-':
                        kq = a - b;
                        break;
                    case '*':
                        kq = a * b;
                        break;
                    case '/':
                        if (b != 0)
                            kq = a / b;
                        else
                        {
                            MessageBox.Show("Cannot divide by zero.");
                            return;
                        }
                        break;
                }
                MessageBox.Show("Ket qua: " + kq);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
