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

           
        start();

            Console.WriteLine("\nThe bets that you would win based off of your number generated is: \n");
            new GameCode().Bet1();

            Console.WriteLine("\n");
            new GameCode().Bet2();
    
            Console.WriteLine("\n");
            new GameCode().Bet3();

            Console.WriteLine("\n");
            new GameCode().Bet4();

            Console.WriteLine("\n");
            new GameCode().Bet5();

            Console.WriteLine("\n");
           // new GameCode().Bet6();

            Console.WriteLine("\n");
            new GameCode().Bet7();

            Console.WriteLine("\n");
             new GameCode().Bet8();

            Console.WriteLine("\n");
            //new GameCode().Bet9();

            Console.WriteLine("\n");
            // new GameCode().Bet10();

            Console.WriteLine("\n");
            RestartGame();


        }
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
                        //check = false;
                        break;
                }

            }
            // return Gender;
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
            Console.WriteLine("Hope you had fun playing Roulette.");
            Console.ReadKey();


        }
    }
}
