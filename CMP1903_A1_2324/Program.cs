using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Testing newTest = new Testing();
            Game newGame = new Game();
            // Creates a Testing and Game object.

            Console.WriteLine("Enter R to roll the dice again, T to run a test or E to exit."); 
            string userInput = Console.ReadLine();
            // Asks a user for their input and then reads it.
            if (userInput == "R")
            { 
                newGame.RollDice();
                newGame.CalculateTotal(); 
                // If the user inputs R, runs the methods of the Game object.
                Game.values.Clear();
                // Ensures that values are clear for next set of rolls.
            }
            else if (userInput == "T")
            {
                newTest.Debugging();
                // If the user inputs T, runs the methods of the Testing object.
                Game.values.Clear(); 
            }
            else if (userInput == "E")
            {
                Environment.Exit(0);
                // Terminates the program.
            } 
            else if (userInput != "E" && userInput != "T" && userInput != "R")
            {
                Console.WriteLine("The only valid inputs are 'R' and 'E'.");
                // If the user makes an incorrect input, sends an error message.
                Game.values.Clear();
            }
        }
    }
}
