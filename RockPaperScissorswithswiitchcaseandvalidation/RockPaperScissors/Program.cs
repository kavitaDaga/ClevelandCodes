//P186 Prob 8 Rock Paper Scissors using nested Switch and case 
//Player is given three chance to choose rps and computer randomly generates rps
//It will ask user to enter either r ,p or s .otherwise it will wait.
using System;
using static System.Console;

namespace RockPaperScissors
{
    class Program
    {
        private static object ConvertToChar;

        static void Main(string[] args)
        {
            string[] ComputerRps = new string[3];
            int[] ComputerIntRps = new int[3];
            string[] rpsPlayerGuess = new string[3];
            Boolean TryAgain = true;
            string playerChoose ="";
            Random rnd = new Random();
          
            for (int i = 0; i <= 2; i++)
            {
                ComputerIntRps[i] = rnd.Next(1, 4);
                WriteLine("Input your guess r , p or s where r = Rock,p = Paper and s = scissors ");
               
                while (TryAgain)
                {
                    
                    playerChoose = ReadLine();
                    TryAgain = playerChoose != "r" && playerChoose != "p" && playerChoose != "s" ? true:false;
                    
                }
                TryAgain = true;//reset try again for next try
                rpsPlayerGuess[i] = playerChoose;
                if (ComputerIntRps[i] == 1)
                    ComputerRps[i] = "r";
                else if (ComputerIntRps[i] == 2)
                    ComputerRps[i] = "p";
                else   ComputerRps[i] = "s";

                WriteLine("Player guess {0}", rpsPlayerGuess[i]);

                WriteLine("Computer Random {0}", ComputerRps[i]);

                switch (ComputerRps[i])
                {
                    case "r":
                        switch (rpsPlayerGuess[i])
                        {
                            case "r":
                              WriteLine("Tie ");
                              break;
                            case "p":
                                WriteLine("Winner Paper wins Rock {0} ", rpsPlayerGuess[i]);
                                break;
                            case "s":
                                WriteLine("Looser Scissors loose to  Rock {0} ", rpsPlayerGuess[i]);
                                break;
                        }
                        break;
                    case "p":
                        switch (rpsPlayerGuess[i])
                        {
                            case "p":
                                WriteLine("Tie ");
                                break;
                            case "s":
                                WriteLine("Looser Scissors Loose to Papers {0}", rpsPlayerGuess[i]);
                                break;
                            case "r":
                                WriteLine("Winner Rock wins over Paper {0}", rpsPlayerGuess[i]);
                                break;
                        }
                        break;
                    case "s":
                        switch (rpsPlayerGuess[i])
                        {
                            case "s":
                                WriteLine("Tie ");
                                break;
                            case "r":
                                WriteLine("Winner Rock wins over Scissors {0}", rpsPlayerGuess[i]);
                                break;
                            case "p":
                                WriteLine("Looser Paper loose to Scissors {0}", rpsPlayerGuess[i]);
                                break;
                        }
                        break;
                 }
            }//closing for loop  
        }//closing main 
    }//closing class
}//closing namescape

