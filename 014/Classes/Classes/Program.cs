/*   C# Fundamentals for Absolute Beginners
 *   14 | Understanding Classes
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "BMW";
            myCar.Model = "X5";
            myCar.Year = 2001;
            myCar.Color = "Blue";

            Console.WriteLine("{0} {1} {2} {3}", 
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color
            );

            /* Call method in class Car */
            decimal value = myCar.DetermineMarketValue();
            Console.WriteLine("Value {0:C}", value);

            Console.ReadLine();
        }

    }

    class Car
    {
        /* Type prop <tab> <tab> to expand 
         * code snippet in Visual Studio */
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        /* Method in class Car */
        public decimal DetermineMarketValue()
        {
            decimal carValue;

            if (Year > 1990)
            {
                carValue = 100000;
            }

            else
            {
                carValue = 50000;
            }

            return carValue;
        }

    }
}
