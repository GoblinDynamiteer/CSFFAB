/*   C# Fundamentals for Absolute Beginners
 *   13 | Working with Dates and Times
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;

            /* Converts to date and time */
            Console.WriteLine(myValue.ToString());

            /* ToShortDateString converts to date only
             * short: "2017-06-19" */
            Console.WriteLine(myValue.ToShortDateString());

            /* ToLongDateString converts to date only
             * long : "Den 19 juni, 2017"*/
            Console.WriteLine(myValue.ToLongDateString());

            /* ToShortTimeString converts to time only 
             * short: "hh:mm" */
            Console.WriteLine(myValue.ToShortTimeString());

            /* ToShortTimeString converts to time only
             * long: "hh:mm:ss" */
            Console.WriteLine(myValue.ToLongTimeString());

            /* Add days to date value */
            Console.WriteLine(myValue.AddDays(12).ToLongDateString());

            /* Add hours to date value */
            Console.WriteLine(myValue.AddHours(827).ToLongDateString());

            /* Use negative values to subtract */
            Console.WriteLine(myValue.AddHours(-827).ToLongDateString());

            /* Return month */
            Console.WriteLine("Month: {0} ", myValue.Month);

            DateTime myBirthday = new DateTime(1983, 06, 19);
            Console.WriteLine("My birthday: {0}", myBirthday.ToShortDateString());

            /* Convert string to DateTime */
            myBirthday = DateTime.Parse("1983-06-19");

            /* TimeSpan class holds time between two dates. */
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);

            Console.WriteLine("My age in days: {0}", myAge.TotalDays);

            Console.ReadLine();
        }
    }
}
