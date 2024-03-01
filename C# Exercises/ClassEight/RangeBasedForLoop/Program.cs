using System;
using System.Collections.Generic;

namespace RangeBasedForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Range-based For Loop



            int[] scores = { 10, 20, 30 };

            foreach (var score in scores)
                Console.WriteLine(score);

            List<double> temperatures = new List<double>() { 87.9, 77.9, 80.0, 72.5 };
            double average_temp = 0;
            double total = 0;

            foreach (var temp in temperatures)
                total += temp;

            if (temperatures.Count != 0)
                average_temp = total / temperatures.Count;

            //  cout << fixed << setprecision(1);
            Console.WriteLine("Average temperature is " + average_temp);

            List<int> vals = new List<int>() { 1, 2, 3, 4, 5 };
            foreach (var val in vals)
                Console.WriteLine(val);



            foreach (var c in "This is a test")
                if (c != ' ')
                    Console.WriteLine(c);

            foreach (var c in "This is a test")
                if (c == ' ')
                    Console.Write("\t");
                else
                    Console.Write(c);


            Console.WriteLine();

        }


    }
}

