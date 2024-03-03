using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */
            Game newGame = new Game();
            while (true)
             { 
                Console.WriteLine("Enter R to roll the dice again, or E to exit."); 
                string userInput = Console.ReadLine(); 
                if (userInput == "R")
                { 
                    newGame.RollDice();
                    newGame.CalculateTotal(); 
                    continue; 
                }
                else if (userInput == "E")
                {
                    break;
                } 
                else if (userInput != "E" && userInput != "R")
                {
                    Console.WriteLine("The only valid inputs are 'R' and 'E'."); 
                }
             }
        }
    }
}
