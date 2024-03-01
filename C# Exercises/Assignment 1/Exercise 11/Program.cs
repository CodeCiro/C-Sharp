using System;


namespace exercise11
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please, enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Now, enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("Greater is: " + num1);
            }
            else if (num2 > num1)
            {
                Console.WriteLine("Greater is: " + num2);
            }
            else if (num1 == num2)
            {
                Console.WriteLine("Both are equal");
            }
        }
    }
}
