/*   C# Fundamentals for Absolute Beginners
 *   9 | Understanding Arrays
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Create an array of integers. */
            int[] numbers = new int[5];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;

            /* Alternate array initilization. */
            int[] numbers2 = new int[] { 4, 6, 7, 8, 11, 231, 42, 5, 9, 2 };

            /* Array of strings */
            string[] names = new string[] { "Johan", "Kalle", "Nathalie", "Linda", "Sven" };

            /* Print lenght and values of array 'numbers'. */
            int arrayLen = numbers.Length;
            Console.WriteLine("Array lenght: {0}\nArray content:", arrayLen);

            for (int ix = 0; ix < arrayLen; ix++)
            {
                Console.WriteLine("numbers[{0}]: {1}", ix, numbers[ix]);
            }

            /* Print values of array 'numbers2', with foreach iteration. */
            Console.WriteLine("\nArray content of 'numbers2' : ");
            foreach (int integerValue in numbers2)
            {
                Console.WriteLine(integerValue);
            }

            /* Print names of array 'names', with foreach iteration. */
            Console.WriteLine("\nArray content of 'names' : ");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            /* Convert string into char array. 
             * A char variable holds a single character. */
            string stringer = "I'm a stringy stringer!";
            char[] charArray = stringer.ToCharArray();

            /* Reverse charArray */
            Array.Reverse(charArray);

            /* Print text and reversed char array */
            Console.WriteLine("\nText: \t\t" + stringer);
            Console.Write("Reversed: \t");

            foreach (char letter in charArray)
            {
                Console.Write(letter);
            }

            Console.ReadLine();
        }
    }
}
