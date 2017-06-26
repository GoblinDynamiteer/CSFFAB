using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            /* Call static method */
            Car.MyMethod();

            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1983;
            myCar.Color = "Silver";

            /* Another reference to the same target */
            Car myOtherCar;
            myOtherCar = myCar;

            Console.WriteLine("{0} {1} {2} {3}",
                myOtherCar.Make,
                myOtherCar.Model,
                myOtherCar.Year,
                myOtherCar.Color);

            myOtherCar.Model = "98";

            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            myOtherCar = null;

            /* Initialize with overloaded constructor */
            Car myThirdCar = new Car(
                "Ford",
                "Escape",
                2005,
                "White");

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car()
        {
            /* 'this' is not needed */
            this.Make = "Nissan";
        }

        public Car(string make, string model, int year, string color)
        {
            this.Make = make;
            this.Year = year;
            this.Model = model;
            this.Color = color;
        }

        public static void MyMethod()
        {
            Console.WriteLine("WrooM!");
        }
    }
}
