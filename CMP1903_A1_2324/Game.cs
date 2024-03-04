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
        public static List<int> values = new List<int>();
        private Die gameDie = new Die();

        public void RollDice()
        {
            for (int i = 1; i < 4; i++)
            {
                int result = gameDie.Roll();
                values.Add(result);
                Console.WriteLine($"Value of die {i}: {result}"); 
            }
        }

        public int CalculateTotal()
        {
            int total = values.Sum(); 
            Console.WriteLine($"Total value of dice rolled: {total}");
            return total; 
        }
    }
}
