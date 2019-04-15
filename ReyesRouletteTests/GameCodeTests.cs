using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReyesRoulette;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReyesRoulette.Tests
{
    [TestClass()]
    public class GameCodeTests
    {
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