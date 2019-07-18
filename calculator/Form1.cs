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
            double firstNumber = Convert.ToDouble(InputVar1.Text);
            double secondNumber = Convert.ToDouble(InputVar2.Text);

            var Calculator = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
            double result = Calculator.Calculate(firstNumber, secondNumber);

            OutputVar.Text = result.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calculator2Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(InputVar1.Text);

            var Calculator = OneArgumentFactory.CreateCalculator(((Button)sender).Name);
            double result = Calculator.Calculate(firstNumber);

            OutputVar.Text = result.ToString();
        }
    }
}
