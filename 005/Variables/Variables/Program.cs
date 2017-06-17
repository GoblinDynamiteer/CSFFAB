/*   C# Fundamentals for Absolute Beginners
 *   5 | Understanding Data Types and Variables
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Declare integer variables x and y */
            int x, y;

            /* Assign values to variables x and y */
            x = 7;
            y = x + 3;

            /* Print value of variable y */
            Console.WriteLine("Value of integer variable y: " + y);
            
            /* String variables -- camelCasing variable names */
            string lastName, firstName;

            Console.WriteLine("What is your name?!");

            /* Output string without line break */
            Console.Write("Enter first name: ");

            /* Get string value from user input */
            firstName = Console.ReadLine();

            Console.Write("Enter last name: ");
            lastName = Console.ReadLine();

            Console.WriteLine("Hello " + firstName + " " + lastName + "!");
            Console.ReadLine();
        }
    }
}
