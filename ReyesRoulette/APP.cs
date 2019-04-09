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
        { Console.WriteLine("Welcome to Reyes Roulette. \nFist part of this game is to pic a number or Color.");

           
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
