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

            //Console.Clear();
            //new GameCode().RunFromThisMethod();

            EndGame();

            //RestartGame();
        }

        //Method that starts the game and allows you to select a random number or quit.
        public void start()
        {
            Console.WriteLine("Welcome to Reyes Roulette. Select from the option below: ");
            string Gender = " ";

            bool check = false;

            while (check == false)

            {
                Console.WriteLine("\n1. Start random number generator " + "2. Quit");
                Console.Write("My option is: ");
                Gender = Console.ReadLine();
            
                switch (Gender)
                {
                    //1. Numbers: the number of the bin
                    case "1":
                        Console.Clear();
                        new GameCode().RunFromThisMethod();

                        check = false;
                        break;

                    //2. Evens/Odds: even or odd numbers
                    case "2":
                        RestartGame();
                        //Console.WriteLine("Sorry. Thanks for playing.");
                        //Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("\nThanks for playing. Duces (>^_^>) (<^_^<)\n");
                        check = true;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid Selection. ReEnter an oprtion from the options below.\n");
                        start();
                       check = false;
                        break;
                }
            }
            // return Gender;
        }

        //Method that gives you the option to play the game again or quit.
        public void RestartGame()
        {
            Console.WriteLine("\nDo you want to play Roulette again: Y/N ?");
            Console.Write("Option Selected: ");

            string game = Console.ReadLine();

            if (game == "y")
            {
                Console.Clear();
                Task();
            }
            else if (game != "y")
            {
                EndGame();
            }
        }     

        public void EndGame()
        {
            Console.Clear();
            Console.WriteLine("Hope you had fun playing Roulette.");
            Console.ReadKey();
        }
    }
}
