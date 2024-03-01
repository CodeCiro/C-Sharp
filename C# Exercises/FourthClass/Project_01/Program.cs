
// If Statement 

namespace Project_01
{
    public class Program
    {
        public static void Main()
        {
            int num;
            const int min = 10;
            const int max = 100;

            Console.WriteLine("Enter a number between " +
                min + " and " + max + ": ");
            num = int.Parse(Console.ReadLine());

            if (num >= min)
            {
                Console.WriteLine("\n=========== If statement 1 =============");
                Console.WriteLine(num + " is greater than or equal to " + min);

                int diff = num - min;
                Console.WriteLine(num + " is " + diff + " greater than " + min);
            }

            if (num <= max)
            {
                Console.WriteLine("\n=========== If statement 2=============");
                Console.WriteLine(num + " is less than or equal to " + max);

                int diff = max - num;
                Console.WriteLine(num + " is " + diff + " less than " + max);
            }

            if (num >= min && num <= max)
            {
                Console.WriteLine("\n=========== If statement 3=============");
                Console.WriteLine(num + " is in range ");
                Console.WriteLine(" This means satements 1 and 2 must also display!!");
            }

            if (num == min || num == max)
            {
                Console.WriteLine("\n=========== If statement 4 =============");
                Console.WriteLine(num + " is right on a boundary ");
                Console.WriteLine("This means all 4 statements display ");

            }

            Console.WriteLine();
            return;
        }

    }
}