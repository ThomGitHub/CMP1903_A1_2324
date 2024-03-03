using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        private List<int> values = new List<int>();
        private Die gameDie = new Die();

        //Methods
        public void RollDice()
        {
            for (int i = 1; i < 4; i++)
            {
                int result = gameDie.Roll();
                values.Add(result);
                Console.WriteLine($"Value of die {i}: {result}"); 
            }
        }

        public void CalculateTotal()
        {
            int total = values.Sum(); 
            Console.WriteLine($"Total value of dice rolled: {total}");
            values.Clear(); 
        }
    }
}
