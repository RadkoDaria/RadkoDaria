using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InputVar1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculateClick(object sender, EventArgs e)
        {
            double firstNum = Convert.ToDouble(InputVar1.Text);
            double secondNum = Convert.ToDouble(InputVar2.Text);

            var Calculator = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
            double result = Calculator.Calculate(firstNum, secondNum);

            OutputVar.Text = result.ToString();
        }
    }
}
