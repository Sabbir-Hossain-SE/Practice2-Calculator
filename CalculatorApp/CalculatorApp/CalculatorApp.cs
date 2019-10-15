using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorApp : Form
    {
        public Calculator calculator=new Calculator();

        public CalculatorApp()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bool flag1 = Regex.IsMatch(number1TextBox.Text, "[0-9.]{1,}$");
            bool flag2 = Regex.IsMatch(number2TextBox.Text, "[0-9.]{1,}$");
            if (flag1 == true && flag2 == true)
            {
                double num1 = Convert.ToDouble(number1TextBox.Text);
                double num2 = Convert.ToDouble(number2TextBox.Text);
                resultTextBox.Text = Convert.ToString(calculator.Add(num1, num2));
            }
            else
            {
                MessageBox.Show("Enter all TextField properly.");
            }
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            bool flag1 = Regex.IsMatch(number1TextBox.Text, "[0-9.]{1,}$");
            bool flag2 = Regex.IsMatch(number2TextBox.Text, "[0-9.]{1,}$");
            if (flag1 == true && flag2 == true)
            {
                double num1 = Convert.ToDouble(number1TextBox.Text);
                double num2 = Convert.ToDouble(number2TextBox.Text);
                resultTextBox.Text = Convert.ToString(calculator.Sub(num1, num2));
            }
            else
            {
                MessageBox.Show("Enter all TextField properly.");
            }
        }

        private void mulButton_Click(object sender, EventArgs e)
        {
            bool flag1 = Regex.IsMatch(number1TextBox.Text, "[0-9.]{1,}$");
            bool flag2 = Regex.IsMatch(number2TextBox.Text, "[0-9.]{1,}$");
            if (flag1 == true && flag2 == true)
            {
                double num1 = Convert.ToDouble(number1TextBox.Text);
                double num2 = Convert.ToDouble(number2TextBox.Text);
                resultTextBox.Text = Convert.ToString(calculator.Mul(num1, num2));
            }
            else
            {
                MessageBox.Show("Enter all TextField properly.");
            }
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            bool flag1 = Regex.IsMatch(number1TextBox.Text, "[0-9.]{1,}$");
            bool flag2 = Regex.IsMatch(number2TextBox.Text, "[0-9.]{1,}$");
            if (flag1 == true && flag2 == true)
            {
                double num1 = Convert.ToDouble(number1TextBox.Text);
                double num2 = Convert.ToDouble(number2TextBox.Text);
                resultTextBox.Text = Convert.ToString(calculator.Div(num1, num2));
            }
            else
            {
                MessageBox.Show("Enter all TextField properly.");
            }
        }


    }
}
