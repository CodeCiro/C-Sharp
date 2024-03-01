using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

          
            // Arrays
            
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            Console.WriteLine("\nThe first vowel is: " + vowels[0]);
            Console.WriteLine("The last vowel is: " + vowels[4]);
            
             double[] hi_temps = { 90.1, 89.8, 77.5, 81.6 };
             Console.WriteLine("\nThe first high temperature is: " + hi_temps[0]);

             hi_temps[0] = 100.7;    // set the first element in hi_temps to 100.7

             Console.WriteLine("The first high temperature is now: " + hi_temps[0]);

             int[] test_scores = { 100, 90, 80, 70, 60 };

             Console.WriteLine("\nFirst score at index 0: " + test_scores[0]);
             Console.WriteLine("Second score at index 1: " + test_scores[1]);
             Console.WriteLine("Third score at index 2:  " + test_scores[2]);
             Console.WriteLine("Fourth score at index 3: " + test_scores[3]);
             Console.WriteLine("Fifth score at index 4: " + test_scores[4]);

             Console.WriteLine("\nEnter 5 test scores: ");
             test_scores[0] = int.Parse(Console.ReadLine());
             test_scores[1] = int.Parse(Console.ReadLine());
             test_scores[2] = int.Parse(Console.ReadLine());
             test_scores[3] = int.Parse(Console.ReadLine());
             test_scores[4] = int.Parse(Console.ReadLine());

             Console.WriteLine("\nThe updated array is:");
             Console.WriteLine("First score at index 0: " + test_scores[0]);
             Console.WriteLine("Second score at index 1: " + test_scores[1]);
             Console.WriteLine("Third score at index 2:  " + test_scores[2]);
             Console.WriteLine("Fourth score at index 3: " + test_scores[3]);
             Console.WriteLine("Fifth score at index 4: " + test_scores[4]);


             Console.WriteLine("\nNotice what the value of the array name is : " + test_scores);

             Console.WriteLine();
            
        }


    }
}

