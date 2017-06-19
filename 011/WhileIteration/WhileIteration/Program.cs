/*   C# Fundamentals for Absolute Beginners
 *   11 | While Iteration Statement
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;

            /* Call method MainMenu while bool 
             * variable is true */
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
            
        }

        private static bool MainMenu()
        {
            /* Clears console screen */
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) PrintNumbers");
            Console.WriteLine("2) Guessing Game");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                PrintNumbers();
                return true;
            }

            else if (result == "2")
            {
                GuessingGame();
                return true;
            }

            else if (result == "3")
            {
                return false;
            }

            else
            {
                return true;
            }

        }

        private static void PrintNumbers()
        {
            Console.Clear();
            Console.WriteLine("Print numbers");
            Console.Write("Type a number: ");

            /* int.Parse converts string to integer value */
            int result = int.Parse(Console.ReadLine());
            int counter = 1;

            while (counter < result + 1)
            {
                Console.Write(counter);
                Console.Write("-");
                counter++;
            }

            Console.ReadLine();
        }

        private static void GuessingGame()
        {
            Console.Clear();

            /* Create a random number using the Random class
             * Method Next(min, max) returns a random number */
            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);

            int guesses = 0;
            bool incorrect = true;

            /* do/while loop, runs atleast one time */
            do
            {
                Console.WriteLine("Guess a number between 1 and 10: ");
                string result = Console.ReadLine();

                if (result == randomNumber.ToString())
                {
                    incorrect = false;
                }

                else
                {
                    Console.WriteLine("Wrong!");
                }

                guesses++;

            } while (incorrect);

            Console.WriteLine("Correct! It took you {0} guesses!", guesses);

            Console.ReadLine();
        }
    }
}
