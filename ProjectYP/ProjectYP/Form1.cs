using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectYP.OneArgument;
using ProjectYP.TwoArguments;

namespace ProjectYP
{
    public partial class bt_tan : Form
    {
        public bt_tan()
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

        private void oneArgclick(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(textBox4.Text);
            IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator(((Button)sender).Name);
            double result = calculator.Calculate(first);
            textBox6.Text = Convert.ToString(result);
        }
    }
}
