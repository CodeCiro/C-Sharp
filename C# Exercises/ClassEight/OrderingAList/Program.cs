using System;
using System.Collections.Generic;

namespace OrderingAList
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<int> list = new List<int>();

            int i = 0; int min_contenu = 0; int min_index = 0;
            Console.WriteLine();

            Console.WriteLine("here are the 10  numbers: ");
            // Seed the random number generator
            Random rnd = new Random();
           
            for (i = 0; i < 10; i++)
            {
                list.Add(rnd.Next() % 1000);
                Console.WriteLine(list[i]);
            }

            List<int> list_sorted = new List<int>();

            for (int j = 0; j < 10; j++)
            {
                min_contenu = 1000;
                for (i = 0; i < list.Count; i++)
                {
                    if (list[i] < min_contenu)
                    {
                        min_contenu = list[i];
                        min_index = i;
                    }
                }

                list_sorted.Add(min_contenu);
                list[min_index] = 1000;

            }

            Console.WriteLine("-----------------result-------------");
            for (int z = 0; z < 10; z++)
                Console.WriteLine(list_sorted[z]);
        }
    }
}

