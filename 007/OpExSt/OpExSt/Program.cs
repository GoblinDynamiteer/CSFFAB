/*   C# Fundamentals for Absolute Beginners
 *   7 | Operators, Expressions, and Statements
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpExSt
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Variable declaration */
            int x, y, a, b;

            /* Assignment operator */
            x = 3;
            y = 2;
            a = 1;
            b = 0;

            /* Mathematical operators */
            /* Addition */
            x = 3 + 4;

            /* Subtraction */
            x = 4 - 3;

            /* Multiplication */
            x = 4 * 2;

            /* Division */
            x = 10 / 5;

            /* Order of operations, 
             * operations inside parantheses take priority */
            x = (x + y) * (a - b);

            /* Evaluation operators */
            /* Equality */
            if (x == y)
            {
            }

            /* Greater than */
            if (x > y)
            {
            }

            /* Less than */
            if (x < y)
            {
            }

            /* Greater or equal to */
            if (x >= y)
            {
            }

            /* Less than or equal to */
            if (x <= y)
            {
            }

            /* Conditional */
            /* AND */
            if ((x > y) && (a > b))
            {
            }

            /* OR */
            if ((x > y) || (a > b))
            {
            }

            /* Inline, ternary */
            string xIsThree = (x == 3) ? "True" : "False";
        }
    }
}
