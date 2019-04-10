using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReyesRoulette
{
    class APP
    {
        //Method that starts the game and is called in the Main Method.

        public void Task()
        {
            Console.WriteLine("Welcome to Reyes Roulette. \nSelect from the option below: \n");

           
            new GameCode().start();

            Console.WriteLine("\nThe bets that you would win based off of your number generated is: ");
            new GameCode().IfElse();

            /*

                Console.WriteLine("\n1. Numbers: the number of the bin " + "\n2. Evens/Odds: even or odd numbers " + "\n3. Reds/Blacks: red or black numbers " +

                        "\n4. Lows/Highs: low or high numbers. " + "\n5. Dozens: row thirds. " + "\n6. Columns: First, second, or third columns" +

                        "\n7. Street: rows. " + "\n8. 6 Numbers: double rows. " + "\n9. Split: at the edge of any two contiguous numbers. " +

                      "\n10. Corner: at the intersection of any four contiguous numbers.");

        */

            /*
             Console.WriteLine("\n1. Start random number generator " + "2. Quit");
            Console.WriteLine();
           Console.Clear();
            int me = Convert.ToInt32(Console.ReadLine());

            new GameCode().start();

           Console.WriteLine();

            Console.WriteLine("Press Enter:");
          
            GameCode.start();
            */

        }

        //Method that gives you the option to play the game again or quit.
        public void RestartGame()
        {
            Console.WriteLine("Do you want to play Roulette again: Y/N ?");

            string game = Console.ReadLine();

            if (game == "y")
            {
                Console.Clear();
                Task();
                Console.WriteLine("Select another number to play Roulette.");
                int num = Convert.ToInt32(Console.ReadLine());
                //Gamechoice(new);
            }
            else if (game != "y")
            {
                EndGame();
            }
        }


        //Method for ending the game
        public void EndGame()
        {
            Console.Clear();
            Console.WriteLine("Hope you had fun playing Roulette.\nPress Enter to Quit...");
            Console.ReadKey();


        }
    }
}
