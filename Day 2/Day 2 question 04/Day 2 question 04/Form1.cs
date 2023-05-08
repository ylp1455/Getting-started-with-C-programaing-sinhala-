using System;
using System.Windows.Forms;

namespace Day_2_question_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Farenhiet to Celcius")
            {
                double f = double.Parse(textBox1.Text);
                double c = (f - 32) * 5 / 9;
                textBox2.Text = c.ToString();
            }
            else if (comboBox1.Text == "Celcius to Farenhiet")
            {
                double c = double.Parse(textBox1.Text);
                double f = (c * 9 / 5) + 32;
                textBox2.Text = f.ToString();
            }
            else
            {
                textBox2.Text = "Invalid choice";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                double f = double.Parse(textBox4.Text);
                double c = (f - 32) * 5 / 9;
                textBox3.Text = c.ToString();
            }
            else if (radioButton2.Checked == true) {
                double c = double.Parse(textBox4.Text);
                double f = (c * 9 / 5) + 32;
                textBox3.Text = f.ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
