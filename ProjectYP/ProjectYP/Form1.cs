using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectYP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //    private void textBox1_TextChanged(object sender, EventArgs e)
        //    {
        //         private void button4_Click(object sender, EventArgs e)
        //    {
        //        double a = Convert.ToDouble(textBox1.Text);
        //        double b = Convert.ToDouble(textBox2.Text);
        //        double result = a - b;
        //        textBox3.Text = Convert.ToString(result);
        //    }
        //}




        private void slojenie_Click_1(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox4.Text);
            double b = Convert.ToDouble(textBox5.Text);
            double result = a + b;
            textBox6.Text = Convert.ToString(result);
        }

        private void vichitanye_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox4.Text);
            double b = Convert.ToDouble(textBox5.Text);
            double result = a - b;
            textBox6.Text = Convert.ToString(result);
        }

        private void umnojenie_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox4.Text);
            double b = Convert.ToDouble(textBox5.Text);
            double result = a * b;
            textBox6.Text = Convert.ToString(result);
        }

        private void delenie_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox4.Text);
            double b = Convert.ToDouble(textBox5.Text);
            double result = a / b;
            textBox6.Text = Convert.ToString(result);
        }
    }
}
