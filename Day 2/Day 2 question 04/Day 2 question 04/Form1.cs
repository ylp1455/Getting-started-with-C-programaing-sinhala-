using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                double c;

                c = (f - 32) * 5 / 9;

                textBox2.Text = c.ToString();


                

            }
            else if (comboBox1.Text == "Celcius to Farenhiet")
            {
                if (comboBox1.Text == "Farenhiet to Celcius")
                {
                    double f = double.Parse(textBox1.Text);
                    double c;

                    c = (f - 32) * 5 / 9;

                    textBox2.Text = c.ToString();
                }
                else if (comboBox1.Text == "Celcius to Farenhiet")
                {
                    double c = double.Parse(textBox1.Text);
                    double f;
                    f = (c * 9 / 5) + 32;

                    textBox2.Text = f.ToString();
                }
                else
                {
                    textBox2.Text = "Invalid choice";
                }
            }
            else { textBox2.Text = "Invalid choice"; }


        }
    }
}
