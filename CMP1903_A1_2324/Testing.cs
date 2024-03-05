using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        private Game testGame = new Game();
        private Die testDie = new Die();
        // Creates a Die and Game object for testing purposes.

        public void Debugging()
        // Method for error testing and debugging the Game and Die classes.
        {
            Console.WriteLine("Running test..."); 
            testGame.RollDice(); 

            foreach (int i in Game.values)
            {
                Debug.Assert(i >= 1, "Die has rolled below a 1.");
                Debug.Assert(i <= 6, "Die has rolled above a 6.");
                // Checks each of the dice rolled and whether or not they're above 6 or below 1.
            }

            int valuesSum = Game.values.Sum(); 
            // Adds all of the values in Game.values (i.e. the dice rolled) together.
            Debug.Assert(valuesSum == testGame.CalculateTotal());
            // Checks to ensure that the CalculateTotal method returns the correct sum.

            testDie.Roll();
            Console.WriteLine("Testing has completed.");
        }
    }   
}
