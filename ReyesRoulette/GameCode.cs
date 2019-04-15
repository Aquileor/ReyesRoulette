using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This class will have all the code to the game that is assoicated with ReyesRoulette.
namespace ReyesRoulette
{
    //This is were i build the Methods to run the code from.
   public class GameCode
    {
        //Random number Generator for the diffrent values and colors
        public static int NumberGenerator()
        {
            Random random = new Random();
            int numbers = random.Next(0, 37);
            return numbers;
        }
        
        public static char ColorGenerator()
        {
            Random random = new Random();
            int ran = random.Next(0, 37);
            char colors = (char)(ran);
            return colors;
        }

        //Listing out the number and there respective colors.
        public static char ReyesRouletteColors()
        {
            char[] colors = new char[] { 'G','G', 'R', 'R', 'R', 'R', 'R', 'R', 'R', 'R', 'R', 'R', 'R', 'R', 'R', 'R', 'R', 'R', 'R', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B' };
            return colors[ColorGenerator()];
        }

        public static int ReyesRouletteNumbers()
        {
            int[] Numbers = new int[] { 0, 00, 30, 7, 32, 5, 34, 3, 36, 1, 27, 25, 12, 19, 18, 21, 16, 23, 14, 11, 20, 32, 17, 22, 15, 24, 13, 10, 29, 8, 31, 6, 33, 4, 35, 2 };
            return Numbers[NumberGenerator()];
        }

        //This is were i create each method based off of each possible bets.
        //1. Numbers: the number of the bin
        public void Bet1()
        {
            int NumOrColorVar = ReyesRouletteNumbers();
            Console.WriteLine($"\nBet1. You would win based off your number being {NumOrColorVar}!"); 
        }

        //2. Evens/Odds: even or odd numbers
        public void Bet2()
        {
            int NumOrColorVar = ReyesRouletteNumbers();

            if (NumOrColorVar % 2 == 0)
            { Console.WriteLine($"\nBet2. You would win based off your number being even!"); }

            else
            { Console.WriteLine($"\nBet2. Would Win if you bet odds."); }
        }

        //3. Reds/Blacks: red or black colored numbers
        public void Bet3()
        {
            char NumOrColorVar = ReyesRouletteColors();
           
            if (NumOrColorVar == 'R')
            { Console.WriteLine($"\nBet3. You win based off the color Red"); }

            else if (NumOrColorVar == 'B')
            { Console.WriteLine($"\nBet3. You win based off the color Black"); }

            else if (NumOrColorVar == 'G')
            { Console.WriteLine($"\nBet3. You win based off the color Green "); }

            else
            {  Console.WriteLine($"\nBet3. You win based off the color IDK "); }
        }

        //4. Lows/Highs: low (1 – 18) or high (19 – 36) numbers
        public void Bet4()
        {
            int NumOrColorVar = ReyesRouletteNumbers();

            if (NumOrColorVar <= 18 && NumOrColorVar > 0)
            {   Console.WriteLine($"\nBet4. You win becuase your number is low ( 1-18). ");  }
            else if (NumOrColorVar <= 36 && NumOrColorVar >= 19)
            {  Console.WriteLine($"\nBet4. You win becuase your number is high ( 19-36). "); }
            else
            { Console.WriteLine("\nBet4. You win because your answer is 0 or 00."); }
        }

        //5. Dozens: row thirds, 1-12 , 13-24, 25-36
        public void Bet5()
        {
            int NumOrColorVar = ReyesRouletteNumbers();

            if (NumOrColorVar > 24 && NumOrColorVar <= 36)
            {   Console.WriteLine($"\nBet5. You win becuase your number is low ( 24-36)."); }

            else if (NumOrColorVar > 12 && NumOrColorVar <= 24)
            {    Console.WriteLine($"\nBet5. You win becuase your number is low ( 12-24). "); }

            else if (
                NumOrColorVar > 0 && NumOrColorVar <= 12)
            {  Console.WriteLine($"\nBet5. You win becuase your number is low ( 1-12). ");   }

            else
            {   Console.WriteLine($"\nBet5. You win because your answer is 0 or 00. "); }
        }

        //6. Columns: first, second, or third columns
        public void Bet6()
        {
            int NumOrColorVar = ReyesRouletteNumbers();

                if (NumOrColorVar % 3 == 1)
                {
                    Console.WriteLine($"\nBet6. You would win if you picked the first column");
                }

            else if (NumOrColorVar % 3 == 2)
                {
                Console.WriteLine($"\nBet6. You would win if you picked the second column");
            }

                else if (NumOrColorVar % 3 == 0)
                {
                Console.WriteLine($"\nBet6. You would win if you picked the third column");
            }
                else
            {
                Console.WriteLine($"\nBet6. You would win if you picked 0 or 00");
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
                Console.WriteLine($"\nBet7. You win based off rows {NumOrColorVar} / {solve} / {solve2} or {NumOrColorVar} / {solve3} / {solve4} ");
            }

            else
            {
                Console.WriteLine($"\nBet7. You win because your answer is 0 or 00. ");
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
                Console.WriteLine($"\nBet8. You win based off rows {NumOrColorVar} / {solve} / {solve2} / {solve3} / {solve4} / {solve5} or {NumOrColorVar} / {solve6} / {solve7} / {solve8} / {solve9} / {solve10} ");
            }
            else
            {
                Console.WriteLine($"\nBet8. You win because your answer is 0 or 00. ");
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
                Console.WriteLine($"\nBet9. You win based off rows {NumOrColorVar} / {solve}  or {NumOrColorVar} / {solve2}  or {NumOrColorVar} / {solve3}   or {NumOrColorVar} / {solve4}   ");
            }
            else
            {
                Console.WriteLine($"\nBet9. You win because your answer is 0 or 00. ");
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
                Console.WriteLine($"\nBet10. You win based off rows {solve4} / {solve3} / {solve} / {NumOrColorVar} or {solve3} / {solve2} / {NumOrColorVar} / {solve5}  " +
                    $"{solve} / {NumOrColorVar} / {solve6} / {solve7} or {NumOrColorVar} / {solve5} / {solve7} / {solve8}  ");
            }
            else
            {
                Console.WriteLine($"\nBet10. You win because your answer is 0 or 00. ");
            }

        }

        //This is were I put all my bet methods so I can run it in the APP class.
        public void RunFromThisMethod()
        {
            Console.WriteLine("\nThe bets that you would win based off of your number generated is: ");

            new GameCode().Bet1();

            new GameCode().Bet2();

            new GameCode().Bet3();

            new GameCode().Bet4();

            new GameCode().Bet5();

            new GameCode().Bet6();

            new GameCode().Bet7();

            new GameCode().Bet8();

            new GameCode().Bet9();

            new GameCode().Bet10();
        }
    }
}