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

        public void start()
        {
            string Gender = " ";

            //  bool check = false;


            {
                Console.WriteLine("\n1. Start random number generator " + "2. Quit");
                Console.Write("My option is: ");
                Gender = Console.ReadLine();

                switch (Gender)
                {
                    //1. Numbers: the number of the bin
                    case "1":

                        // Console.ReadKey();
                        num();
                       // RouletteNum();
                       // RouletteColor();

                        //check = true;

                        break;

                    //2. Evens/Odds: even or odd numbers
                    case "2":

                        Console.WriteLine("Sorry. Thanks for playing.");
                        //check = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid Selection. Re Enter an oprtion from the options below.");
                        start();
                        //check = false;
                        break;


                        //make an if else statment for this
                        /*
                         00 Green
                         1 Red
                         2 Black
                         3 Red
                         4 Black
                         5 Red
                         6 Black
                         7 Red
                         8 Black
                         9 Red
                         10 Black
                         11 Red
                         12 Black
                         13 Red
                         14 Black
                         15 Red
                         16 Black
                         17 Red
                         18 Black
                         19 Red
                         20 Black
                         21 Red
                         22 Black
                         23 Red
                         24 Black
                         25 Red
                         26 Black
                         27 Red
                         28 Black
                         29 Red
                         30 Black
                         31 Red
                         32 Black
                         33 Red
                         34 Black
                         35 Red
                         36 Black
                         00 Green
                         */
                }

            }
            // return Gender;
        }


        public static int RandoNum()
        {
            Random random = new Random();
            int ran = random.Next(0, 37);
            return ran;
        }
        public static char RandoCol()
        {
            Random random = new Random();

            int ran = random.Next(0, 37);
            char wheelcolor = (char)(ran);
            return wheelcolor;
        }
        public static int RouletteNum()
        {
            int[] wheelNumbers = new int[] { 0, 00, 30, 7, 32, 5, 34, 3, 36, 1, 27,
                                             25, 12, 19, 18, 21, 16, 23, 14, 11, 20, 32, 17,
                                             22, 15, 24, 13, 10, 29, 8, 31, 6, 33, 4, 35, 2 };


            Console.WriteLine($"number is: {wheelNumbers[RandoNum()]}");
           return wheelNumbers[RandoNum()];

        }
        public static char RouletteColor()
        {
            char[] colorWheel = new char[] { 'G','G', 'R', 'R', 'R', 'R', 'R', 'R', 'R', 'R',
                                             'R', 'R', 'R', 'R', 'R', 'R', 'R', 'R', 'R', 'B', 'B', 'B', 'B', 'B',
                                             'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B' };
            Console.WriteLine($"number is: {colorWheel[RandoCol()]}");
            return colorWheel[RandoCol()];
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


        /*
           //1. Numbers: the number of the bin
           //2. Evens/Odds: even or odd numbers
           //3. Reds/Blacks: red or black colored numbers
           //4. Lows/Highs: low (1 { 18) or high (19 { 38) numbers. Lows/Highs: low (1 – 18) or high (19 – 36) numbers
           //5. Dozens: row thirds, 1 { 12, 13 { 24, 25 { 36
           //6. Columns: rst, second, or third columns
           //7. Street: rows, e.g., 1/2/3 or 22/23/24
           //8. 6 Numbers: double rows, e.g., 1/2/3/4/5/6 or 22/23/24/25/26/26
           //9. Split: at the edge of any two contiguous numbers, e.g., 1/2, 11/14, and 35/36
           //10. Corner: at the intersection of any four contiguous numbers, e.g., 1/2/4/5, or 23/24/26/27
           }
           */
public void IfElse()
        {
            int temp = RouletteNum();

            // int bet = Convert.ToInt32(Console.ReadLine());
           // Console.WriteLine("The number on the wheel is " + temp);


            if (temp % 2 == 0)//even 
            {
                Console.WriteLine($"You would win based off  being even!");
            }

            else
            {
                Console.WriteLine($"Would Win if you bet odds.");
            }

        }


        public void Options(int choice)

        {
            Console.WriteLine("Possible wining outcomes are: ");

            switch (choice)
            {
                //1. Numbers: the number of the bin
                case 1:
                    


                //2. Evens/Odds: even or odd numbers
                case 2:
                    //2. Evens/Odds: even or odd numbers
                    int temp = RouletteNum();

                   // int bet = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The number on the wheel is " + temp);


                    if (temp % 2 == 0)//even 
                    {
                        Console.WriteLine($"You won based off od being even!");
                    }

                    else
                    {
                        Console.WriteLine($"You lost!");
                    }
                    //PlayAgain();
                    break;


                //3. Reds/Blacks: red or black colored numbers
                case 3:

                    break;

                //4. Lows/Highs: low (1 { 18) or high (19 { 38) numbers. Lows/Highs: low (1 – 18) or high (19 – 36) numbers
                case 4:

                    break;

                //5. Dozens: row thirds, 1 { 12, 13 { 24, 25 { 36
                case 5:

                    break;

                //6. Columns: rst, second, or third columns
                case 6:

                    break;

                //7. Street: rows, e.g., 1/2/3 or 22/23/24
                case 7:

                    break;

                //8. 6 Numbers: double rows, e.g., 1/2/3/4/5/6 or 22/23/24/25/26/26
                case 8:

                    break;

                //9. Split: at the edge of any two contiguous numbers, e.g., 1/2, 11/14, and 35/36
                case 9:

                    break;

                //10. Corner: at the intersection of any four contiguous numbers, e.g., 1/2/4/5, or 23/24/26/27
                case 10:

                    break;
                default:

                    Console.Clear();

                    Console.WriteLine("Invalid answer\n");

                    Console.Clear();



                    start();

                    Console.WriteLine("Welcome.\n These ar your diffrenct options to make the game work");

                    int Num = Convert.ToInt32(Console.ReadLine());

                    Options(Num);

                    return;

            }



        }
    }
}

