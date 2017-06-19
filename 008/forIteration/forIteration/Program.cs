using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Iterate trough 0 to 9, 
             * print out values to console */
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 7)
                {
                    Console.WriteLine("i is seven!");
                    /* Break / end for-loop */
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
