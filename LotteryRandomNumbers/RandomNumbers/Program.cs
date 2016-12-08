//Prob 9 Chap 4
using System;
using static System.Console;


namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputRandom = new int[3];
            int points = 0;
            int[] randomNumber = new int[3];
            const int PRIZE1 = 10;
            const int PRIZE2 = 100;
            const int PRIZE3 = 1000;
            const int PRIZE4 = 10000;
            Random rnd = new Random();
            for (int i = 0; i <= 2; i++)
            {
                randomNumber[i] = rnd.Next(1, 5);
                WriteLine("Input your random guess number from 1 till 4 ");
                WriteLine("random {0}", randomNumber[i]);
                inputRandom[i] = int.Parse(ReadLine());
                WriteLine("input Guess {0}", inputRandom[i]);
                if (randomNumber[i] == inputRandom[i])
                {
                    WriteLine("Good Guess this is the random number");
                    points += 1;
                }
            }
            WriteLine("random number is " + randomNumber[0] + randomNumber[1] + randomNumber[2]);
            WriteLine("Guess is " + inputRandom[0] + inputRandom[1] + inputRandom[2]);
            //This is for the Three numbers correct guess inorderly
            if (points != 3)
            {
                points = 0;
                for (int i = 0; i <= 2; i++)
                {
                    for (int j = 0; j <= 2; j++)
                        if (randomNumber[i] == inputRandom[j])
                        {
                            points += 1;
                            inputRandom[j] = 99;
                        }
                }
            }
            else
                points = 4;

                switch (points)
                {

                    case 1:
                        WriteLine("Any one matching  award is ${0}  ", PRIZE1);
                        break;
                    case 2:
                        WriteLine("Two matching  award is ${0}  ", PRIZE2);
                        break;
                    case 3:
                        WriteLine("Three matching not in order  award is $ {0}  ", PRIZE3);
                        break;
                    case 4:
                        WriteLine("Three matching in exact order  award is ${0}  ", PRIZE4);
                        break;
                    default:
                        WriteLine("No matches Award {0} dollars", 0);
                        break;

                }


            }
        }
    }











