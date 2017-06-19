/*   C# Fundamentals for Absolute Beginners
 *   10 | Defining and Calling Methods
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game");

            Console.Write("What's your first name? ");
            string firstName = Console.ReadLine();
            
            Console.Write("What's your last name? ");
            string lastName = Console.ReadLine();

            Console.Write("In what city were you born? ");
            string city = Console.ReadLine();

            /* Call DisplayResult with three parameters */
            DisplayResult(
                ReverseString(firstName),
                ReverseString(lastName),
                ReverseString(city)
            );

            Console.WriteLine();

            /* Call DisplayResult with one parameter */
            DisplayResult(
                ReverseString(firstName) + " " +
                ReverseString(lastName) + " " +
                ReverseString(city) 
            );

            Console.ReadLine();

        }

        private static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            /* Concatenate char array to string, and return string */
            return String.Concat(messageArray);
        }

        /* Method with three parameters */
        private static void DisplayResult(string reversedFirstName, 
                                          string reversedLastName, 
                                          string reversedCity)
        {
            /* String.Format is like sprintf, but returns string. 
            Uses {0}, {1} instead of %s %i etc. */
            Console.WriteLine("Results: ");
            Console.Write(String.Format("{0} {1} {2}",
                    reversedFirstName,
                    reversedLastName,
                    reversedCity));
        }

        /* Method DisplayResult (same name as above, different version) 
         * with one parameters. C# handles these as seperate methods. 
         
           This is called overloaded methods
        */
        private static void DisplayResult(string message)
        {
            Console.WriteLine("Results: ");
            Console.Write(message);
        }

    }
}
