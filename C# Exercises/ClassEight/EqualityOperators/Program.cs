using System;
using System.Collections.Generic;

namespace EqualityOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Equality Operators
            bool equal_result = false;
            bool not_equal_result = false;
            int num1, num2;

            Console.WriteLine("Enter first integer : ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second integer : ");
            num2 = int.Parse(Console.ReadLine());

            equal_result = (num1 == num2);
            not_equal_result = (num1 != num2);
            Console.WriteLine("Comparision result (equals) : " + equal_result);
            Console.WriteLine("Comparision result (not equals) : " + not_equal_result);


            char char1, char2;
            Console.WriteLine("Enter first  character : ");
            char1 = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter second  character : ");
            char2 = char.Parse(Console.ReadLine());

            equal_result = (char1 == char2);
            not_equal_result = (char1 != char2);
            Console.WriteLine("Comparision result (equals) : " + equal_result);
            Console.WriteLine("Comparision result (not equals) : " + not_equal_result);

            double double1, double2;
            Console.WriteLine("Enter first double : ");
            double1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second double : ");
            double2 = double.Parse(Console.ReadLine());

            equal_result = (double1 == double2);
            not_equal_result = (double1 != double2);
            Console.WriteLine("Comparision result (equals) : " + equal_result);
            Console.WriteLine("Comparision result (not equals) : " + not_equal_result);

            Console.WriteLine("Enter an integer : ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a double : ");
            double1 = double.Parse(Console.ReadLine());

            equal_result = (num1 == double1);
            not_equal_result = (num1 != double1);
            Console.WriteLine("Comparision result (equals) : " + equal_result);
            Console.WriteLine("Comparision result (not equals) : " + not_equal_result);


            Console.WriteLine();

        }


    }
}

