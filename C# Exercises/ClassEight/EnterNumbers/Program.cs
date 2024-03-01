using System;

namespace EnterNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double x = 0;
            do
            {
                Console.WriteLine("give a positif number: ");
                x = double.Parse(Console.ReadLine());
                if (x < 0) Console.WriteLine("please positif !");
                if (x <= 0) continue;
                Console.WriteLine("the square root is : " + Math.Sqrt(x));
            } while (x>0);
        }
    }
}

