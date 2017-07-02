using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>() {
                new Car() { VIN="A1", Make = "BMW", Model= "550i", StickerPrice=55000, Year=2009},
                new Car() { VIN="B2", Make="Toyota", Model="4Runner", StickerPrice=35000, Year=2010},
                new Car() { VIN="C3", Make="BMW", Model = "745li", StickerPrice=75000, Year=2008},
                new Car() { VIN="D4", Make="Ford", Model="Escape", StickerPrice=25000, Year=2008},
                new Car() { VIN="E5", Make="BMW", Model="55i", StickerPrice=57000, Year=2010}
            };

            /* LINQ query */
            /* Find all BWMs from 2010 */
            var bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select car;

            foreach (var car in bmws)
            {
                Console.WriteLine("{0} {1}", car.Model, car.VIN);
            }

            Console.WriteLine("---------------");

            /* LINQ method */
            var bmws2 = myCars.Where(p => p.Make == "BMW" && p.Year == 2010); // lambda expression =>

            /* var keyword lets compiler figure out data type */

            foreach (var car in bmws2)
            {
                Console.WriteLine("{0} {1}", car.Model, car.VIN);
            }

            Console.WriteLine("---------------");

            /* LINQ query */
            var orderedCars = from car in myCars
                              orderby car.Year descending
                              select car;

            foreach (var car in orderedCars)
            {
                Console.WriteLine("{0} {1} {2}", car.Model, car.VIN, car.Year);
            }

            Console.WriteLine("---------------");

            /* LINQ method */
            var orderedCars2 = myCars.OrderByDescending(p => p.Year);

            foreach (var car in orderedCars)
            {
                Console.WriteLine("{0} {1} {2}", car.Model, car.VIN, car.Year);
            }

            Console.WriteLine("---------------");

            /* Find first car in list that matches query */
            var firstCar = myCars.First(p => p.Make == "BMW");

            Console.WriteLine("{0} {1} {2}", firstCar.Model, firstCar.VIN, firstCar.Year);

            Console.WriteLine("---------------");

            /* Find first car in list that matches query, ordered by year */
            var firstCarYear = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW");

            Console.WriteLine("{0} {1} {2}", firstCarYear.Model, firstCarYear.VIN, firstCarYear.Year);

            Console.WriteLine("---------------");

            /* Check if true for all items in list */
            Console.Write("All cars are newer than 1999: ");
            Console.WriteLine(myCars.TrueForAll(p => p.Year > 1999));

            Console.Write("All cars are BMWs: ");
            Console.WriteLine(myCars.TrueForAll(p => p.Make == "BMW"));

            Console.WriteLine("---------------");

            /* Foreach operation */
            myCars.ForEach(car => Console.WriteLine("{0} {1} {2}", car.Make, car.Model, car.StickerPrice));
            myCars.ForEach(car => car.StickerPrice -= 3000);
            Console.WriteLine("---------------");
            myCars.ForEach(car => Console.WriteLine("{0} {1} {2}", car.Make, car.Model, car.StickerPrice));

            Console.WriteLine("---------------");

            Console.Write("55i exists in list: ");
            Console.WriteLine(myCars.Exists(car => car.Model == "55i"));

            Console.WriteLine("---------------");
            Console.Write("Sum of stickerprice: ");
            Console.WriteLine(myCars.Sum(car => car.StickerPrice));

            Console.WriteLine("---------------");
            Console.WriteLine("myCars.GetType: {0}", myCars.GetType());
            Console.WriteLine("orderedCars.GetType: {0}", orderedCars.GetType());
            Console.WriteLine("bmws.GetType: {0}", bmws.GetType());

            var newCars = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select new { car.Make, car.Model };

            Console.WriteLine("newCars.GetType: {0}", newCars.GetType());

            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }
}
