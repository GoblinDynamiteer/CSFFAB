using System;
using System.Collections; // ArrayList
using System.Collections.Generic;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlas Supreme";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";
            car2.VIN = "B2";

            Book b1 = new Book();
            b1.Author = "Rinn Taylor";
            b1.Title = "C Hashtag Rox";
            b1.ISBN = "1-123-12345-1";
            

            /* ArrayList are dynamically sized,
             * sorting, remove items etc */
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(b1); // Can add different types

            /* Problems when iterating if b1 in ArrayList */
            foreach (object item in myArrayList)
            {
                // Console.WriteLine(item.Make);
            }

            /* List<T> -- generic list */
            List<Car> myList = new List<Car>();

            myList.Add(car1);
            myList.Add(car2);

            // myList.Add(b1); -- Can't add different types

            foreach (Car car in myList)
            {
                Console.WriteLine(car.Make);
            }

            /* Dictionary<TKey, TValue> */
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();

            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            Console.WriteLine(myDictionary["B2"].Make);

            /* Object initializer syntax, no need for constructor */
            string[] names = { "Bob", "Steve", "Brian" };
            Car car3 = new Car() { Make = "BMW", Model = "750li", VIN = "C3" };
            Car car4 = new Car() { Make = "Toyota", Model = "4Runner", VIN = "D4" };

            /* Collecton initializer syntax */
            List<Car> myCarList = new List<Car>()
            {
                new Car() { Make = "Oldsmobile", Model = "Cutlas Supreme", VIN = "E5" },
                new Car() { Make = "Nissan", Model = "Altima", VIN = "F6" }
            };

            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; } // Vehicle Id Number
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
