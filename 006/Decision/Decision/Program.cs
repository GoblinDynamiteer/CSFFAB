/*  C# Fundamentals for Absolute Beginners 
*   6 | The if Decision Statement 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine(), message;

            /* if/else if/else don't need curly braces 
             * if containing just one line */
            if (userValue == "1")
                message = "You won a new cat!";
            else if (userValue == "2")
                message = "You won a new dog!";
            else if (userValue == "3")
                message = "You won a new horse!";
            else { // Multiple lines requires curly braces
                message = "Sorry, wrong input!";
                message += " You loose!";  // (+=) is (variable = variable +)
            }
                
            Console.WriteLine(message);

            Console.WriteLine("Choose another door!");
            Console.Write("Choose a door: 1, 2: ");
            userValue = Console.ReadLine();

            /* Ternary operator -- if/else condition */
            message = (userValue == "1") ? "boat" : "bat";

            /* {0} {1} gets replaced by parameter 
             * variables userValue & message */
            Console.WriteLine("You entered {0}: You won a {1}!", 
                    userValue, 
                    message
                );
            Console.ReadLine();
        }
    }
}
