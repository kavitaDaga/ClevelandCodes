//Prob11 Chapter 8 Ward Card Game

using System;
using static System.Console;

namespace NewDeckCards
{
    class Program
    {


        static void Main(string[] args)
        {
            NewDeckCards[] myCard = new NewDeckCards[52];
            string[] suitType = { "spade", "heart", "diamond", "clubs" };

            int[] computer = new int[52];           //Array to store random numbers generated
            int[] player = new int[26];
            int[] computer1 = new int[26];
            int j = 0, k = 0;
            int fx =0, temp, playerPoints = 0, ComputerPoints = 0;
          
            Random rnd = new Random();
            //For each card x gives spade ,heart --- clubs face and i assings value from 1- 13 ,1-Ace,13-King.
            for (int x = 0; x <= 3; x++)
            {
                for (int i = 0; i < 13; i++)
                {
                   //Assigning a unique value to each card by index j
                    myCard[j] = new NewDeckCards(Face: Convert.ToString(i + 1), Value: j + 1, Suit: suitType[x]);
                    // if(i == 0) { myCard[j].SetFace("Ace");  };
                    myCard[j].printInfo();
                    j++;
                }
            }
            //Displaying the Array of 52 Objects in an array.
            for (k = 0; k < 52; k++)
            {
                myCard[k].printInfo();
                computer[k] = k;
            }
            //52 values stored in computer Array which represents computer
            // Shuffle the array
            
            for (k = 0; k < 26; k ++)
            {
                fx = rnd.Next(0, 52);
                temp = computer[51-k];
                computer[51-k] = computer[fx];
                computer[fx] = temp;
                WriteLine("**************" + computer[k]);

            }
                //Player array stores from values 0-26
              //new computer array from 26

            for (k = 0; k < 26; k++)
            {
                
                player[k] = computer[k];
                computer1[k] = computer[k + 25];
                string a = myCard[player[k]].getFace();//getface method call
                string b = myCard[computer1[k]].getFace();
                if (a == b)
                {
                    WriteLine("Tie");
                    playerPoints += 1;
                    ComputerPoints += 1;
                }
                else if (int.Parse(a) > int.Parse(b))
                {
                    WriteLine(" Player score:{0} and Computer Score:{1}", a, b);
                    playerPoints += 2;
                    ComputerPoints += 0;
                }
                else
                {
                    WriteLine(" Computer Score:{0} and Player Score :{1}", b, a);
                    playerPoints += 0;
                    ComputerPoints += 2;
                }
             
            }
            WriteLine("Player:{0} Computer:{1}" ,playerPoints ,ComputerPoints);
            WriteLine(playerPoints - ComputerPoints > 0 ?  playerPoints : ComputerPoints);


        }
    }
}

