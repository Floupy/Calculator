using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        double firstNumber;
        double secondNumber;
        int firstNumberLength;
        string operation; 


        public Calculator()
        {
            InitializeComponent();
        }

        private void NumericButton_click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (Display.Text == "0")
            {

                Display.Text = button.Text;
            }
            else
            {
                Display.Text += button.Text;
            }

        }

        private void buttonPeriod_Click(object sender, EventArgs e)
        {
            if (!Display.Text.Contains(","))
            {
                Display.Text += ",";
            }


        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            string s = Display.Text;


            if (s.Length > 1)
            {
                s = s.Substring(0, s.Length - 1);
                if (s.EndsWith("."))
                {
                    s = s.Substring(0, s.Length - 1);
                }
            }
            else
            {
                s = "0";
            }

            Display.Text = s;


        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(Display.Text);
            number *= -1; //number = number * -1
            Display.Text = Convert.ToString(number);
        }



        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
            if (!Display.Text.Contains("+"))
            {
                firstNumberLength = Display.Text.Length;
                firstNumber = Convert.ToDouble(Display.Text);
                operation = "addition";
                Display.Text += "+";
            }
           

        }

        private void buttonSubstract_Click(object sender, EventArgs e)
        {

        }

        private void buttonResult_click(object sender, EventArgs e)
        {
            double result = 0;
            int secondNumberLength = Display.Text.Length - firstNumberLength - 1;
            string seconNumberText = Display.Text.Substring(firstNumberLength + 1, secondNumberLength);
            secondNumber = Convert.ToDouble(seconNumberText);
            if (operation == "addition")
            {
                result = firstNumber + secondNumber;
            }
            Display.Text = Convert.ToString(result);
        }

            private void buttonMultiply_Click(object sender, EventArgs e)
        {

        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {

        }
    }
}



