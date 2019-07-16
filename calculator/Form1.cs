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

        private void Add_Click(object sender, EventArgs e)
        {
            double firstNum = Convert.ToDouble(InputVar1.Text);
            double secondNum = Convert.ToDouble(InputVar2.Text);
            double result = firstNum + secondNum;
            OutputVar.Text = result.ToString();
        }

        private void InputVar1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sub_Click(object sender, EventArgs e)
        {
            double firstNum = Convert.ToDouble(InputVar1.Text);
            double secondNum = Convert.ToDouble(InputVar2.Text);
            double result = firstNum - secondNum;
            OutputVar.Text = result.ToString();
        }

        private void Mult_Click(object sender, EventArgs e)
        {
            double firstNum = Convert.ToDouble(InputVar1.Text);
            double secondNum = Convert.ToDouble(InputVar2.Text);
            double result = firstNum * secondNum;
            OutputVar.Text = result.ToString();
        }

        private void Div_Click(object sender, EventArgs e)
        {

        }

        private void CalculateClick(object sender, EventArgs e)
        {
            double firstNum = Convert.ToDouble(InputVar1.Text);
            double secondNum = Convert.ToDouble(InputVar2.Text);
            double result;
            switch (((Button)sender).Name)
            {
                case "add":
                    result = firstNum + secondNum;
                    break;
                case "sub":
                    result = firstNum - secondNum;
                    break;
                case "mult":
                    result = firstNum * secondNum;
                    break;
                case "div":
                    result = firstNum / secondNum;
                    break;
                default: throw new Exception("Неопределенная операция");
            }
            OutputVar.Text = result.ToString();
        }
    }
}
