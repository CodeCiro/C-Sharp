using System;

namespace MixedExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Mixed Type Expressions
            /*
                Ask the user to enter 3 integers
                Calculate the sum of the integers then
                calculate the average of the 3 integers.

                Display the 3 integers entered
                the sum of the 3 integers and
                the average of the 3 integers.
            */


            int total = 0;
            int num1 = 0, num2 = 0, num3 = 0;
            const int count = 3;

            Console.WriteLine("Enter first integer : ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second integer : ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third integer : ");
            num3 = int.Parse(Console.ReadLine());


            total = num1 + num2 + num3;

            double average = 0.0;

            average = total / count;
            // average = (double)total/count;  Old-Style


            Console.WriteLine( "The 3 numbers were: " + num1 + "," + num2 + "," + num3 );
            Console.WriteLine( "The sum of the numbers is: " + total );
            Console.WriteLine( "The average of the numbers is: " + average);

            Console.WriteLine();
        }


    }
}

