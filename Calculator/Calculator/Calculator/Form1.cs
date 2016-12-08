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
    public partial class Form1 : Form
    {
        float num1 = 0;
        float num2 = 0;
        float total = 0;
        string oper;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void uno_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "1";

        }

        private void two_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "3";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "0";
        }

        private void four_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "9";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(result.Text);
            oper = "+";
            result.Text = "";

        }

        private void equal_Click(object sender, EventArgs e)
        {
            num2 = float.Parse(result.Text);                    
            switch (oper)
            {
                case "+":
                    total = num1 + num2;
                    break;
                case "-":
                    total = num1 - num2;
                    break;
                case "/":
                    total = num1 / num2;
                    break;
                case "*":
                    total = num1 * num2;
                    break;
              }

            result.Text = total.ToString("N");
        }

        private void clean_Click(object sender, EventArgs e)
        {
            result.Text = "";
            num1 = 0;
            num2 = 0;
            total = 0;
        }

        private void less_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(result.Text);
            oper = "-";
            result.Text = "";
        }

        private void times_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(result.Text);
            oper = "*";
            result.Text = "";
        }

        private void division_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(result.Text);
            oper = "/";
            result.Text = "";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + ".";
        }
    }
}
