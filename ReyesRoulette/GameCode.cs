using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This class will have all the code to the game that is assoicated with ReyesRoulette.
namespace ReyesRoulette
{
    class GameCode
    {

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
        public static int ReyesRouletteNumbers()
        {
            int[] wheelNumbers = new int[] { 0, 00, 30, 7, 32, 5, 34, 3, 36, 1, 27,
                                             25, 12, 19, 18, 21, 16, 23, 14, 11, 20, 32, 17,
                                             22, 15, 24, 13, 10, 29, 8, 31, 6, 33, 4, 35, 2 };


         //   Console.WriteLine($"number is: {wheelNumbers[RandoNum()]}");
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
        
        public void num()
        {
            Console.Clear();
            Random gameDice = new Random();
            int game = gameDice.Next(0, 37);
            Console.WriteLine($"\nThe random number generated is: {game}");
            
        }
        public void color()
        {
            Random color = new Random();
            int game = color.Next(0, 37);
            char colors = (char)(game);       

        }



        /*
        public static int RouletteNum()

        {

            int[] wheelNumbers = new int[] { 30, 7, 32, 5, 34, 3, 36, 1, 27, 25, 12, 19, 18, 21, 16, 23, 14, 11, 20, 32, 17, 22, 15, 24, 13, 10, 29, 8, 31, 6, 33, 4, 35, 2, 0, 00 };

           return wheelNumbers[num()];

        }

        public static char RouletteColor()

        {

            char[] colorWheel = new char[] { 'r', 'r', 'r', 'r', 'r', 'r', 'r', 'r', 'r', 'r', 'r', 'r', 'r', 'r', 'r', 'r', 'r', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'g', 'g' };
            
            return colorWheel[color()];

        }
        */

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
            Console.WriteLine("Please choose column 1, 2 , or 3");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
            {
                if (NumOrColorVar % 3 == 1)
                {
                    Console.WriteLine($"You Won! $");
                }
                else
                {
                    Console.WriteLine($"You lost  ");
                }
            }
            else if (num == 2)
            {
                if (NumOrColorVar % 3 == 2)
                {
                    Console.WriteLine($"You Won! ");
                }
                else
                {
                    Console.WriteLine($"You lost  ");
                }
            }
            else if (num == 3)
            {
                if (NumOrColorVar % 3 == 0)
                {
                    Console.WriteLine($"You Won! ");
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
            int temp = ReyesRouletteNumbers();
            Console.WriteLine("For this game, you will choose two numbers for a split bet");
            Console.Write("Choose for your first number.");
            int num01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Choose you second number.");
            int num02 = Convert.ToInt32(Console.ReadLine());



            if (num01 == temp || num02 == temp)
            {
                Console.WriteLine($"You chose {num01}/{num02}, You win ");
            }
            else
            {
                Console.WriteLine($"You chose {num01}/{num02}, You win ");
            }
        }

        //10. Corner: at the intersection of any four contiguous numbers, e.g., 1/2/4/5, or 23/24/26/27
        public void Bet10()
        {
            //10. Corner: at the intersection of any four contiguous numbers, e.g., 1/2/4/5, or 23/24/26/27
            int temp = ReyesRouletteNumbers();
            Console.WriteLine("For this bet, you will have to choose 4 numbers.");
            Console.Write("Choose for your first number.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Choose for your second number.");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Choose for your third number.");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Choose for your fourth number.");
            int num4 = Convert.ToInt32(Console.ReadLine());



            if (num1 == temp || num2 == temp || num3 == temp || num4 == temp)
            {
                Console.WriteLine($"You Won!!!!, your numbers were {num1}/{num2}/{num3}/{num4}, you won ");
            }
            else
            {
                Console.WriteLine($"You lost, your numbers were {num1}/{num2}/{num3}/{num4}, you lost ");

            }

        }
    }
}

