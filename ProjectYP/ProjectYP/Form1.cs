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


        private void buttonClick(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(textBox4.Text);
            double second = Convert.ToDouble(textBox5.Text);
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
            double result = calculator.Calculate(first, second);

            

            textBox6.Text = Convert.ToString(result);
        }
    }
}
