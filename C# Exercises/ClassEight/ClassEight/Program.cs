

using System;
using System.Collections.Generic;

namespace Histogram
{
    internal class Program
    {
        static void Main()
        {
            //nested loop - histogram

            int num_items;

            Console.WriteLine("How many data items do you have? ");
            num_items=int.Parse(Console.ReadLine());
            
            List<int> data=new List<int>();

            for (int i= 1 ; i <= num_items; ++i) {
                int data_item;
                Console.WriteLine("Enter data item " + i + ": ");
                data_item = int.Parse(Console.ReadLine());
                data.Add(data_item);
            }

            Console.WriteLine( "\nDisplaying Histogram");
            foreach (var val in data)
            {
                for (int i=1 ; i <= val; ++i) {
                if (i % 5 == 0)
                        Console.Write("*");
                else
                        Console.Write("-");
            }
                Console.WriteLine();
        }

            Console.WriteLine();
        }
    }
}
