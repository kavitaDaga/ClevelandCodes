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
        double num1 = 0;
        double num2 = 0;
        double total = 0;
        string operation = "";
        public Calculator()
        {
            InitializeComponent();

        }
        private void btnOne_Click(object sender, EventArgs e)
        {
            if (operation == "=")
            {
                btnOneAfterEqual_Click(sender, e);
                btnShowCal.Text = "";

            }
            else
            {
                btnResult.Text = btnResult.Text + "1";
                btnShowCal.Text = Convert.ToString(num1) + operation;

            }

        }
        private void btnOneAfterEqual_Click(object sender, EventArgs e)
        {
            btnResult.Text =  "1";
            btnShowCal.Text = "";
            operation = "";
            num1 = 0;
            num2 = 0;
        }



        private void btnThree_Click(object sender, EventArgs e)
        {
            if (operation == "=")
            {
                btnThreeAfterEqual_Click(sender, e); }
            else
            {
                btnResult.Text = btnResult.Text + "3";
                btnShowCal.Text = Convert.ToString(num1) + operation;

            }
        }
        private void btnThreeAfterEqual_Click(object sender, EventArgs e)
        {
            btnResult.Text = "3";
            btnShowCal.Text = "";
            operation = "";
            num1 = 0;
            num2 = 0;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (operation == "=")
            {
                btnTwoAfterEqual_Click(sender, e);

            }
            else
            {
                btnResult.Text = btnResult.Text + "2";
                btnShowCal.Text = Convert.ToString(num1) + operation;
            }
           
            

        }
        private void btnTwoAfterEqual_Click(object sender, EventArgs e)
        {
            btnResult.Text = "2";
            btnShowCal.Text = "";
            operation = "";
            num1 = 0;
            num2 = 0;
        }
        

        private void btnPlus_Click(object sender, EventArgs e)
        {
            
            num1 = double.Parse(btnResult.Text);
            operation = "+";
            btnShowCal.Text = Convert.ToString(num1) + operation;
            btnResult.Text = "";
        }

        private void btnAddSub_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(btnResult.Text);
            num1 = -num1;
            btnShowCal.Text = Convert.ToString(num1);
            btnResult.Text = Convert.ToString(num1) ;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (operation == "=")
            {
                btnZeroAfterEqual_Click(sender, e);

            }
            else
            {
                btnResult.Text = btnResult.Text + "0";
                btnShowCal.Text = Convert.ToString(num1) + operation;}
           
        }
        private void btnZeroAfterEqual_Click(object sender, EventArgs e)
        {
            btnResult.Text = "0";
            btnShowCal.Text = "";
            operation = "";
            num1 = 0;
            num2 = 0;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            btnResult.Text = btnResult.Text + ".";
            btnShowCal.Text = Convert.ToString(num1);


        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (operation == "=")
            {
                btnFourAfterEqual_Click(sender, e);

            }
            else
            {
                btnResult.Text = btnResult.Text + "4";
                btnShowCal.Text = Convert.ToString(num1) + operation;

            }


        }
        private void btnFourAfterEqual_Click(object sender, EventArgs e)
        {
            btnResult.Text = "4";
            btnShowCal.Text = "";
            operation = "";
            num1 = 0;
            num2 = 0;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (operation == "=")
            {
                btnFiveAfterEqual_Click(sender, e);

            }
            else
            {
                btnResult.Text = btnResult.Text + "5";
                btnShowCal.Text = Convert.ToString(num1) + operation;

            }


        }
        private void btnFiveAfterEqual_Click(object sender, EventArgs e)
        {
            btnResult.Text = "5";
            btnShowCal.Text = "";
            operation = "";
            num1 = 0;
            num2 = 0;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (operation == "=")
            {
                btnSixAfterEqual_Click(sender, e);

            }
            else
            {
                btnResult.Text = btnResult.Text + "6";
                btnShowCal.Text = Convert.ToString(num1) + operation;

            }


        }
        private void btnSixAfterEqual_Click(object sender, EventArgs e)
        {
            btnResult.Text = "6";
            btnShowCal.Text = "";
            operation = "";
            num1 = 0;
            num2 = 0;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(btnResult.Text);
            operation = "-";
            btnShowCal.Text = Convert.ToString(num1) + operation;
            btnResult.Text = "";
           
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (operation == "=")
            {
                btnNineAfterEqual_Click(sender, e);

            }
            else
            {
                btnResult.Text = btnResult.Text + "9";
                btnShowCal.Text = Convert.ToString(num1) + operation;

            }


        }
        private void btnNineAfterEqual_Click(object sender, EventArgs e)
        {
            btnResult.Text = "9";
            btnShowCal.Text = "";
            operation = "";
            num1 = 0;
            num2 = 0;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (operation == "=")
            {
                btnSevenAfterEqual_Click(sender, e);

            }
            else
            {
                btnResult.Text = btnResult.Text + "7";
                btnShowCal.Text = Convert.ToString(num1) + operation;

            }


        }
        private void btnSevenAfterEqual_Click(object sender, EventArgs e)
        {
            btnResult.Text = "7";
            btnShowCal.Text = "";
            operation = "";
            num1 = 0;
            num2 = 0;
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            int length = (btnResult.Text).Length - 1;
            btnResult.Text = (btnResult.Text).Substring(0, length);
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(btnResult.Text);
            operation = "/";
            btnShowCal.Text = Convert.ToString(num1) + operation;
            btnResult.Text = "";
        }

        
        private void btnCe_Click(object sender, EventArgs e)
        {
            btnResult.Text = "";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(btnResult.Text);
            operation = "*";
            btnShowCal.Text = Convert.ToString(num1) + operation;
            btnResult.Text = "";
        }



        private void btnEqual_Click(object sender, EventArgs e)
        {
            btnShowCal.Text = "";
            num2 = double.Parse(btnResult.Text);

            switch (operation)
            {
                case "+":
                total = num1 + num2;
                break;

                case "-":
                total = num1 - num2;
                break;

                case "*":
                total = num1 * num2;
                break;

                case "/":
                total = num1 / num2;
                break;
                
            }

            btnResult.Text = Convert.ToString(total);
            btnShowCal.Text = "";

            operation = "=";
            
        }
       
        private void clean_Click(object sender, EventArgs e)
        {

        }

        private void btnEight_Click(object sender, EventArgs e)
        {

            if (operation == "=")
            {
                btnEightAfterEqual_Click(sender, e);

            }
            else
            {
                btnResult.Text = btnResult.Text + "8";
                btnShowCal.Text = Convert.ToString(num1) + operation;

            }


        }
        private void btnEightAfterEqual_Click(object sender, EventArgs e)
        {
            btnResult.Text = "8";
            btnShowCal.Text = "";
            operation = "";
            num1 = 0;
            num2 = 0;
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
           num1 = 0;
           num2 = 0;
           total = 0;
           operation = ""; btnResult.Text = "";  btnShowCal.Text = "";

        }

        private void btnShowCal_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(btnResult.Text) * num1/100;
            btnShowCal.Text = Convert.ToString(num1) + operation + Convert.ToString(num2);
            btnResult.Text = Convert.ToString(num2);
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            double calc = double.Parse(btnResult.Text);
            num2 = Math.Sqrt(calc);
            btnShowCal.Text = "sqroot " + btnResult.Text;
            btnResult.Text = Convert.ToString(num2);
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            double calc = double.Parse(btnResult.Text);
            num2 = Math.Pow(calc, 2);
            btnShowCal.Text = num1 + operation + "sqr " + btnResult.Text;
            btnResult.Text = Convert.ToString(num2);
        }

        private void btnInverse_Click(object sender, EventArgs e)
        {
            double calc = double.Parse(btnResult.Text);
            num2 = 1 / calc ;
            btnShowCal.Text = num1 + operation + "1/" + btnResult.Text;
            btnResult.Text = Convert.ToString(num2);
        }
    }
}
