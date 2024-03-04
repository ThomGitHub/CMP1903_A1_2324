using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        private Random die = new Random();
        // Creates the die as a Random object.

        public int Roll() 
        // Methods for randomly generating the die object.
        {
            return die.Next(1, 7);
            // Returns a random integer between 1 and 7.
        }
    }
}
