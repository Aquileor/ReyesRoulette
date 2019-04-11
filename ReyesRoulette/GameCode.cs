using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This class will have all the code to the game that is assoicated with ReyesRoulette.
namespace ReyesRoulette
{
    //This is were i build the Methods to run the code from.
    class GameCode
    {
        //Random number Generator for the diffrent values and colors
        public static int NumberGenerator()
        {
            Random random = new Random();
            int ran = random.Next(0, 37);
            return ran;
        }
        
        public static char ColorGenerator()
        {
            Random random = new Random();

            int ran = random.Next(0, 37);
            char wheelcolor = (char)(ran);
            return wheelcolor;
        }

        //Listing out the number and there respective colors.
        public static int ReyesRouletteNumbers()
        {
            int[] wheelNumbers = new int[] { 0, 00, 30, 7, 32, 5, 34, 3, 36, 1, 27,
                                             25, 12, 19, 18, 21, 16, 23, 14, 11, 20, 32, 17,
                                             22, 15, 24, 13, 10, 29, 8, 31, 6, 33, 4, 35, 2 };

         //Console.WriteLine($"number is: {wheelNumbers[RandoNum()]}");
           return wheelNumbers[NumberGenerator()];

        }

        public static char ReyesRouletteColors()
        {
            char[] colorWheel = new char[] { 'G','G', 'R', 'R', 'R', 'R', 'R', 'R', 'R', 'R',
                                             'R', 'R', 'R', 'R', 'R', 'R', 'R', 'R', 'R', 'B', 'B', 'B', 'B', 'B',
                                             'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B' };
            //Console.WriteLine($"number is: {colorWheel[RandoCol()]}");
            return colorWheel[ColorGenerator()];
        }

        //This is were i create each method based off of each possible bets.
        //1. Numbers: the number of the bin
        public void Bet1()
        {
            int NumOrColorVar = ReyesRouletteNumbers();
            Console.WriteLine($"You would win based off your number being {NumOrColorVar}!"); 
        }

        //2. Evens/Odds: even or odd numbers
        public void Bet2()
        {
            int NumOrColorVar = ReyesRouletteNumbers();

            if (NumOrColorVar % 2 == 0)
            { Console.WriteLine($"You would win based off your number being even!"); }

            else
            { Console.WriteLine($"Would Win if you bet odds."); }
        }

        //3. Reds/Blacks: red or black colored numbers
        public void Bet3()
        {
            //3. Reds/Blacks: red or black colored numbers
            char NumOrColorVar = ReyesRouletteColors();
           
            if (NumOrColorVar == 'R')
            { Console.WriteLine($"You win based off the color Red"); }

            else if (NumOrColorVar != 'R')
            { Console.WriteLine($"You win based off the color Red"); }

            else if (NumOrColorVar == 'G')
            { Console.WriteLine($"You win based off the color Red "); }

            else
            {  Console.WriteLine($"You win based off the color Red "); }
        }

        //4. Lows/Highs: low (1 – 18) or high (19 – 36) numbers
        public void Bet4()
        {
            int NumOrColorVar = ReyesRouletteNumbers();

            if (NumOrColorVar <= 18 && NumOrColorVar >= 0)
            {   Console.WriteLine($"You win becuase your number is low ( 1-18). ");  }
            else if (NumOrColorVar <= 36 && NumOrColorVar >= 19)
            {  Console.WriteLine($"You win becuase your number is high ( 19-36). "); }
            else
            { Console.WriteLine("You win because your answer is 0 or 00."); }
        }

        //5. Dozens: row thirds, 1-12 , 13-24, 25-36
        public void Bet5()
        {
            int NumOrColorVar = ReyesRouletteNumbers();

            if (NumOrColorVar > 24 && NumOrColorVar <= 36)
            {   Console.WriteLine($"You win becuase your number is low ( 24-36)."); }

            else if (NumOrColorVar > 12 && NumOrColorVar <= 24)
            {    Console.WriteLine($"You win becuase your number is low ( 12-24). "); }

            else if (
                NumOrColorVar >= 0 && NumOrColorVar <= 12)
            {  Console.WriteLine($"You win becuase your number is low ( 1-12). ");   }

            else
            {   Console.WriteLine($"You win because your answer is 0 or 00. "); }
        }

        //6. Columns: first, second, or third columns
        public void Bet6()
        {
            int NumOrColorVar = ReyesRouletteNumbers();

            if (NumOrColorVar == 1)
            {
                if (NumOrColorVar % 3 == 1)
                {
                    Console.WriteLine($"You Won based off the first column ");
                }
                else
                {
                    Console.WriteLine($"You lost  ");
                }
            }
            else if (NumOrColorVar == 2)
            {
                if (NumOrColorVar % 3 == 2)
                {
                    Console.WriteLine($"You Won based off the second column ");
                }
                else
                {
                    Console.WriteLine($"You lost  ");
                }
            }
            else if (NumOrColorVar == 3)
            {
                if (NumOrColorVar % 3 == 0)
                {
                    Console.WriteLine($"You Won based off the thrid column ");
                }
                else if (NumOrColorVar == 0)
                {
                    Console.WriteLine($"You lost  ");
                }
                else
                {
                    Console.WriteLine($"You lost  ");
                }
            }
        }

        //7. Street: rows, e.g., 1/2/3 or 22/23/24
        public void Bet7()
        {
            int NumOrColorVar = ReyesRouletteNumbers();
            int solve = NumOrColorVar + 1;
            int solve2 = NumOrColorVar + 2;

            int solve3 = NumOrColorVar - 1;
            int solve4 = NumOrColorVar - 2;


            if (NumOrColorVar > 0 && NumOrColorVar <= 36)
            {
                Console.WriteLine($"You win based off rows {NumOrColorVar} / {solve} / {solve2} or {NumOrColorVar} / {solve3} / {solve4} ");
            }

            else
            {
                Console.WriteLine($"You win because your answer is 0 or 00. ");
            }

        }

        //8. 6 Numbers: double rows, e.g., 1/2/3/4/5/6 or 22/23/24/25/26/26
        public void Bet8()
        { 
            int NumOrColorVar = ReyesRouletteNumbers();
            int solve = NumOrColorVar + 1;
            int solve2 = NumOrColorVar + 2;
            int solve3 = NumOrColorVar + 3;
            int solve4 = NumOrColorVar + 4;
            int solve5 = NumOrColorVar + 5;

            int solve6 = NumOrColorVar - 1;
            int solve7 = NumOrColorVar - 2;
            int solve8 = NumOrColorVar - 3;
            int solve9 = NumOrColorVar - 4;
            int solve10 = NumOrColorVar - 5;

            if (NumOrColorVar > 0 && NumOrColorVar <= 36)
            {
                Console.WriteLine($"You win based off rows {NumOrColorVar} / {solve} / {solve2} / {solve3} / {solve4} / {solve5} or {NumOrColorVar} / {solve6} / {solve7} / {solve8} / {solve9} / {solve10} ");
            }
            else
            {
                Console.WriteLine($"You win because your answer is 0 or 00. ");
            }

        }

        //9. Split: at the edge of any two contiguous numbers, e.g., 1/2, 11/14, and 35/36
        public void Bet9()
        {
            int NumOrColorVar = ReyesRouletteNumbers();
            int solve = NumOrColorVar + 1;
            int solve2 = NumOrColorVar + 3;

            int solve3 = NumOrColorVar - 1;
            int solve4 = NumOrColorVar - 3;

            if (NumOrColorVar > 0 && NumOrColorVar <= 36)
            {
                Console.WriteLine($"You win based off rows {NumOrColorVar} / {solve}  or {NumOrColorVar} / {solve2}  or {NumOrColorVar} / {solve3}   or {NumOrColorVar} / {solve4}   ");
            }
            else
            {
                Console.WriteLine($"You win because your answer is 0 or 00. ");
            }

        }

        //10. Corner: at the intersection of any four contiguous numbers, e.g., 1/2/4/5, or 23/24/26/27
        public void Bet10()
        {
            //10. Corner: at the intersection of any four contiguous numbers, e.g., 1/2/4/5, or 23/24/26/27
            int NumOrColorVar = ReyesRouletteNumbers();
            int solve = NumOrColorVar - 1;
            int solve2 = NumOrColorVar - 2;
            int solve3 = NumOrColorVar - 3;
            int solve4 = NumOrColorVar - 4;
            int solve5 = NumOrColorVar + 1;
            int solve6 = NumOrColorVar + 2;
            int solve7 = NumOrColorVar + 3;
            int solve8 = NumOrColorVar + 4;

            if (NumOrColorVar > 0 && NumOrColorVar <= 36)
            {
                Console.WriteLine($"You win based off rows {solve4} / {solve3} / {solve} / {NumOrColorVar} or {solve3} / {solve2} / {NumOrColorVar} / {solve5}  " +
                    $"{solve} / {NumOrColorVar} / {solve6} / {solve7} or {NumOrColorVar} / {solve5} / {solve7} / {solve8}  ");
            }
            else
            {
                Console.WriteLine($"You win because your answer is 0 or 00. ");
            }



            /*

            if (num1 == temp || num2 == temp || num3 == temp || num4 == temp)
            {
                Console.WriteLine($"You Won!!!!, your numbers were {num1}/{num2}/{num3}/{num4}, you won ");
            }
            else
            {
                Console.WriteLine($"You lost, your numbers were {num1}/{num2}/{num3}/{num4}, you lost ");

            }
            */

        }

        //This is were I put all my bet methods so I can run it in the APP class.
        public void RunFromThisMethod()
        {
            Console.WriteLine("\nThe bets that you would win based off of your number generated is: ");

            Console.WriteLine("\nBet 1.");
            new GameCode().Bet1();

            Console.WriteLine("\nBet 2.");
            new GameCode().Bet2();

            Console.WriteLine("\nBet 3.");
            new GameCode().Bet3();

            Console.WriteLine("\nBet 4.");
            new GameCode().Bet4();

            Console.WriteLine("\nBet 5.");
            new GameCode().Bet5();

            Console.WriteLine("\nBet 6.");
            new GameCode().Bet6();

            Console.WriteLine("\nBet 7.");
            new GameCode().Bet7();

            Console.WriteLine("\nBet 8.");
            new GameCode().Bet8();

            Console.WriteLine("\nBet 9.");
            new GameCode().Bet9();

            Console.WriteLine("\nBet 10.");
            new GameCode().Bet10();
        }
    }
}

