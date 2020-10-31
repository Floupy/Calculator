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
            if (!Display.Text.Contains("."))
            {
                Display.Text += ".";
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
    }
}



