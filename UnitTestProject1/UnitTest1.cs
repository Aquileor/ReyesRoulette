using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        public void Bet1()
        {
            int NumOrColorVar = 4;
            Console.WriteLine($"\nBet1. You would win based off your number being {NumOrColorVar}!");
        }

        [TestMethod()]
        public void Bet2Test()
        {
            int NumOrColorVar = 6;

            if (NumOrColorVar % 2 == 0)
            { Console.WriteLine($"\nBet2. You would win based off your number being even!"); }

            else
            { Console.WriteLine($"\nBet2. Would Win if you bet odds."); }
        }
    }
}
