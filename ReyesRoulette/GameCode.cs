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
        public static void start()
        {
           
            /*
            1. Numbers: the number of the bin
            2. Evens/Odds: even or odd numbers
            3. Reds/Blacks: red or black colored numbers
            4. Lows/Highs: low (1 { 18) or high (19 { 38) numbers. Lows/Highs: low (1 – 18) or high (19 – 36) numbers
            5. Dozens: row thirds, 1 { 12, 13 { 24, 25 { 36
            6. Columns: rst, second, or third columns
            7. Street: rows, e.g., 1/2/3 or 22/23/24
            8. 6 Numbers: double rows, e.g., 1/2/3/4/5/6 or 22/23/24/25/26/26
            9. Split: at the edge of any two contiguous numbers, e.g., 1/2, 11/14, and 35/36
            10. Corner: at the intersection of any four contiguous numbers, e.g., 1/2/4/5, or 23/24/26/27
            }
            */

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


        public  void Options(int choice)

        {
            switch (choice)
            {

                case 1:

                    break;

                case 2:

                    break;

                case 3:

                    break;

                case 4:

                    break;

                case 5:

                    break;

                case 6:

                    break;

                case 7:

                    break;

                case 8:

                    break;

                case 9:

                    break;

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
