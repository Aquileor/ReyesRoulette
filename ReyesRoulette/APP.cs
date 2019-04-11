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
            start();

            Console.Clear();
            new GameCode().RunFromThisMethod();

            RestartGame();
        }

        //Method that starts the game and allows you to select a random number or quit.
        public void start()
        {
            Console.WriteLine("Welcome to Reyes Roulette. Select from the option below: ");
            string Gender = " ";
            // bool check = false;

            {
                Console.WriteLine("\n1. Start random number generator " + "2. Quit");
                Console.Write("My option is: ");
                Gender = Console.ReadLine();
            
                switch (Gender)
                {
                    //1. Numbers: the number of the bin
                    case "1":

                        // Console.ReadKey();
                        // Gamecode.num();
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
                       // check = false;
                        break;
                }
            }
            // return Gender;
        }

        //Method that gives you the option to play the game again or quit.
        public void RestartGame()
        {
            Console.WriteLine("\nDo you want to play Roulette again: Y/N ?");

            string game = Console.ReadLine();

            if (game == "y")
            {
                Console.Clear();
                Task();
            }
            else if (game != "y")
            {
                Console.Clear();
                Console.WriteLine("Hope you had fun playing Roulette.");
                Console.ReadKey();
            }
        }     
    }
}
