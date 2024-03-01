
using System;
using System.Collections.Generic;

namespace List_02
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //    vector <char> vowels;         // empty 
            //    vector <char> vowels (5);      // 5 initialized to zero 
            List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };

            Console.WriteLine(vowels[0]);
            Console.WriteLine(vowels[4]);

            //    vector <int> test_scores (3);  // 3 elements all initialized to zero
            //   vector <int> test_scores (3, 100); // 3 elements all initialized to 100

            List<int> test_scores = new List<int>() { 100, 98, 89 };

            Console.WriteLine("\nTest scores using array syntax:");
            Console.WriteLine(test_scores[0]);
            Console.WriteLine(test_scores[1]);
            Console.WriteLine(test_scores[2]);

            Console.WriteLine("\nTest scores using vector syntax:");

            Console.WriteLine(test_scores[0]);
            Console.WriteLine(test_scores[1]);
            Console.WriteLine(test_scores[2]);
            Console.WriteLine("\nThere are " + test_scores.Count + " scores in the vector");

            Console.WriteLine("\nEnter 3 test scores: ");

            test_scores[0] = int.Parse(Console.ReadLine());
            test_scores[1] = int.Parse(Console.ReadLine());
            test_scores[2] = int.Parse(Console.ReadLine());

            Console.WriteLine("\nUpdated test scores: ");

            Console.WriteLine(test_scores[0]);
            Console.WriteLine(test_scores[1]);
            Console.WriteLine(test_scores[2]);


            Console.WriteLine("\nEnter a test score to add to the vector: ");

            int score_to_add = 0;
            score_to_add = int.Parse(Console.ReadLine()); ;

            test_scores.Add(score_to_add);

            Console.WriteLine("\nEnter one more test score to add to the vector: ");

            score_to_add = int.Parse(Console.ReadLine()); ;

            test_scores.Add(score_to_add);

            Console.WriteLine("\nTest scores are now: ");

            Console.WriteLine(test_scores[0]);
            Console.WriteLine(test_scores[1]);
            Console.WriteLine(test_scores[2]);
            Console.WriteLine(test_scores[3]);
            Console.WriteLine(test_scores[4]);

            Console.WriteLine("\nThere are now " + test_scores.Count + " scores in the vector");

            //  Console.WriteLine( << "This should cause an exception!!" << test_scores.at(10) )

            // Example of a 2D-vector

            List<List<int>> movie_ratings = new List<List<int>>();
            List<int> rate = new List<int>() { 1, 2, 3, 4 };
            movie_ratings.Add(rate);
            rate.Clear();
            rate.Add(1);rate.Add(2);rate.Add(4);rate.Add(4);
            movie_ratings.Add(rate);
            rate.Clear();
            rate.Add(1); rate.Add(3); rate.Add(4); rate.Add(5);
            movie_ratings.Add(rate);

            Console.WriteLine("\nHere are the movie rating for reviewer #1 using array syntax :");
            Console.WriteLine(movie_ratings[0][0]);
            Console.WriteLine(movie_ratings[0][1]);
            Console.WriteLine(movie_ratings[0][2]);
            Console.WriteLine(movie_ratings[0][3]);

            Console.WriteLine("\nHere are the movie rating for reviewer #1 using vector syntax :");
            Console.WriteLine(movie_ratings[0][0]);
            Console.WriteLine(movie_ratings[0][1]);
            Console.WriteLine(movie_ratings[0][2]);
            Console.WriteLine(movie_ratings[0][3]);

            Console.WriteLine();


        }


    }
}

