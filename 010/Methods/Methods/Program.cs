/*   C# Fundamentals for Absolute Beginners
 *   10 | Defining and Calling Methods
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Call method */
            HelloWorld();
            Console.ReadLine();
        }

        /* A method */
        private static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
