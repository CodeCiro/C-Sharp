
using System;

namespace Exercise_1
{
    public class Program
    {
        public static void Main()
        {
            //the tax for GST were 7% written as B
            //the tax for QST were 7.5% written as C
            //a program for the unit price of the product and the quantity purchased

            //step 1 = get user input
            Console.WriteLine("Please put the price of object");
            int priceObj = int.Parse(Console.ReadLine());

            //step 2 = do the calculation
            float B = 0.07f;
            float C = 0.075f;
            float result_1 = ((B + 1) * (priceObj));
            float result_2 = ((C + 1) * (result_1));

            //step 3 = display result to user
            Console.WriteLine("this is your GST: " + (result_1 - priceObj));
            Console.WriteLine("this is your QST: " + (result_2 - result_1));
            Console.WriteLine("this is your total: " + result_2);

        }

    }

}