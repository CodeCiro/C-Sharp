
// Conditional Operator

namespace Project_03
{
    public class Program
    {
        public static void Main()
        {

            int num;

            Console.WriteLine("Enter an integer: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine(num + " is even");
            else
                Console.WriteLine(num + " is odd");

            Console.WriteLine(num + " is " + ((num % 2 == 0) ? "even" : "odd"));

            int num1, num2;

            Console.WriteLine("Enter two integers separated by a space: ");
           
            string line = Console.ReadLine();
            string[] data = line.Split(' ');
            num1 = int.Parse(data[0]); //first integer
            num2 = int.Parse(data[1]); //second integer



            if (num1 != num2)
            {
                Console.WriteLine("Largest: " + ((num1 > num2) ? num1 : num2) );
                Console.WriteLine("Smallest: " + ((num1 < num2) ? num1 : num2) );

            }
            else
            {
                Console.WriteLine("The numbers are the same");
            }

            Console.WriteLine();
            return;
        }

    }
}