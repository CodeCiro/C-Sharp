using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementDecrement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int counter = 10;
            int result = 0;
            /*
            // Example 1 - simple increment
            Console.WriteLine( "Counter : " + counter );

            counter = counter + 1;
            Console.WriteLine ("Counter : " + counter );

            counter++;
            Console.WriteLine ("Counter : " + counter );

            ++counter;
            Console.WriteLine ("Counter : " + counter );
            */


            // Example 2 - preincrement
            /* counter = 10;
             result = 0;

             Console.WriteLine ("Counter : " + counter );

             result = ++counter; // Note the pre increment
             Console.WriteLine ("Counter : " + counter );
             Console.WriteLine ("Result : " + result );  */

            // Example 3 - post-increment
            /*   counter = 10;
               result = 0;

               Console.WriteLine( "Counter : " + counter );

               result = counter++; // Note the post increment
               Console.WriteLine ("Counter : " + counter );
               Console.WriteLine ("Result : " + result );  */

            // Example 4
            /*counter = 10;
            result = 0;

            Console.WriteLine("Counter : " + counter);

            result = ++counter + 10;  // Note the pre increment

            Console.WriteLine("Counter : " + counter);
            Console.WriteLine("Result : " + result);  */

            // Example 5
          /*  counter = 10;
            result = 0;

            Console.WriteLine("Counter : " + counter);

            result = counter++ + 10;  // Note the post increment

            Console.WriteLine("Counter : " + counter);
            Console.WriteLine("Result : " + result);  */

            Console.WriteLine();
        }
    }
}
