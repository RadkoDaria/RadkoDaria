using System;
using System.Windows.Forms;
using calculator.OneArgumentCalculators;
using calculator.TwoArgumentCalculators;

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
            try
            {
                double firstNumber = Convert.ToDouble(InputVar1.Text);
                double secondNumber = Convert.ToDouble(InputVar2.Text);

                var calculator = TwoArgumentsFactory.CreateCalculator(((Button) sender).Name);
                double result = calculator.Calculate(firstNumber, secondNumber);

                OutputVar.Text = result.ToString();
            }
            catch (Exception exc)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calculator2Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(InputVar1.Text);

            var calculator = OneArgumentFactory.CreateCalculator(((Button)sender).Name);
            double result = calculator.Calculate(firstNumber);

            OutputVar.Text = result.ToString();
        }
    }
}
