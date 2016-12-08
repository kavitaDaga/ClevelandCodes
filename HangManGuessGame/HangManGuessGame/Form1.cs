using System;
using static System.Console;
using System.Windows.Forms;

namespace HangManGuessGame
{
    public partial class Form1 : Form
    {
        string[] hangMan = {"parrot", "readibility", "preceded", "caterpillar", "javascript", "demonstrate", "integration", "algorithm" };
        Random rnd = new Random();
        int randomNumber = 0, length1 = 0;
        string guess = "",num2="", letterGuess = "";
        string[] characters = new string[15] ;
        string[] newGuess = new string[15] ;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            btnTwo.Text = "";
            num2 = "";
            guess = btnGuess.Text;
            letterGuess = txtGuess.Text.ToLower();
            length1 = (guess).Length;


            
            if (guess.Contains(letterGuess))
            {
                num2 = "";
                num2 = "Yes!  " + letterGuess + " is in the Word";
                label2.Text = num2;
                for (int i = 0; i < length1; i++)
                {
                    characters[i] = guess.Substring(i, 1);
                    // Write(character[i]);
                    if (characters[i] == letterGuess)
                    {
                       newGuess[i] = characters[i];
                    }//End of if
                }//end of for
            }//End of upper if
           else
            {
              num2 = "Make another guess your letter is not in word ";

            }
            label2.Text = num2;
            num2 = "";

            for (int k = 0; k < length1; k++)
                num2 += newGuess[k];
                btnTwo.Text = "Word: " + num2;//only above statement has for single line .
       } //End of Button Click method

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnGuess.Text = "";
            txtGuess.Text = "";
            randomNumber = rnd.Next(1, 9);
            btnTwo.Text = "";
            btnGuess.Text = hangMan[randomNumber];
            //Initializing an arrays
            for (int i = 0; i < 15; i++)
            {
                newGuess[i] = "*";
                characters[i] = "";
            }
        }
      }
   }

