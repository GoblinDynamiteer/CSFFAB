/*   C# Fundamentals for Absolute Beginners
 *   12 | Working with Strings
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Escape sequences with \ -- '\"' prints '"' */
            string myString = "My \"so-called\" life";
            Console.WriteLine(myString);

            /* \n new line */
            myString = "A new\nline!";
            Console.WriteLine(myString);

            /* \\ is \ */
            myString = "Go to your c:\\drive\\";
            Console.WriteLine(myString);

            /* Use @ before string to print as is */
            myString = @"Go to location d:\drive\";
            Console.WriteLine(myString);

            /* Insert strings into string with Format method
             * {#} can be placed in any order, and reused */
            myString = String.Format("{0} {1} {0}", "First", "Second");
            Console.WriteLine(myString);

            /* {0:C} is formatting for currency 
             * output: 123,45 kr in Swedish locale */
            myString = String.Format("{0:C}", 123.45);
            Console.WriteLine(myString);

            /* {0:N} Adds decimals and commas to numbers
             * output: 1 234 567 890,00 */
            myString = String.Format("{0:N}", 1234567890);
            Console.WriteLine(myString);

            /* {0:P} Percentage */
            myString = String.Format("Percentage: {0:P}", .32);
            Console.WriteLine(myString);

            /* {0:} Custom, Cell phone number 
             outputs 70-355 69 82*/
            myString = String.Format("Phone Number; {0:###-### ## ##}", 0703556982);
            Console.WriteLine(myString);

            myString = "Just because you're paranoid doesn't mean they aren't after you.";
            Console.WriteLine(myString);

            /* Gets substring from char 13, 15 lenght */
            myString = myString.Substring(13, 15);

            /* Convert to uppercase */
            myString = myString.ToUpper() + "!";
            Console.WriteLine(myString);

            /* Replace spaces with -- */
            myString = myString.Replace(" ", "--");
            Console.WriteLine(myString);

            /* Remove characters from string */
            myString = "     I'M " + myString.Remove(0, 8) + "\t";
            Console.WriteLine(myString);

            /* Trim white space characters (space, tab ..) */
            myString = myString.Trim();
            Console.WriteLine(myString);

            /* Use StringBuilder class to manipulate strings
             * in a more efficient way */
            StringBuilder myStringBuilder = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                myStringBuilder.Append(i);
                myStringBuilder.Append("--");
            }

            Console.WriteLine(myStringBuilder);

            Console.ReadLine();
        }
    }
}
