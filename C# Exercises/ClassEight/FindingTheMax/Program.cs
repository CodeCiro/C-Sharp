using System;
using System.Collections.Generic;

namespace FindingTheMax
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>();

            int i ; int max_contenu = 0; int max_index = 0;


            Console.WriteLine("here are the 10  numbers: ");
            // Seed the random number generator
            Random random = new Random();

            for (i = 0; i < 10; i++)
            {
                list.Add(random.Next() % 1000000);
                Console.WriteLine(list[i]);
            }
            for (i = 0; i < list.Count; i++)
            {

                if (list[i] > max_contenu)
                {
                    max_contenu = list[i];
                    max_index = i;

                }
            }
            Console.WriteLine("the highest one is element at index " + max_index + " is   " + max_contenu);

        }
    }
}

