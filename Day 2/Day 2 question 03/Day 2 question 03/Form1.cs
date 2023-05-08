using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day_2_question_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double hours = double.Parse(textBox4.Text);
            double hourlyRate = double.Parse(textBox3.Text);

            double grossPay = hours * hourlyRate;

            textBox5.Text = grossPay.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Text = "" ;
            textBox4.Text = "" ;
            textBox3.Text = "" ;

        }
    }
}
