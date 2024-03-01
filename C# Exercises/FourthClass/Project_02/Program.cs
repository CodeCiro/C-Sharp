
// If-Else Statement


namespace Project_02
{
    public class Program
    {
        public static void Main()
        {
            int num;
            const int target = 10;

            Console.WriteLine("Enter a number  and I'll compare it to " + target + ": ");
            num = int.Parse(Console.ReadLine());

            if (num >= target)
            {
                Console.WriteLine("\n==================================");
                Console.WriteLine(num + " is greater than or equal to " + target);
                int diff = num - target;
                Console.WriteLine(num + " is " + diff + " greater than " + target);
            }
            else
            {
                Console.WriteLine("\n==================================");
                Console.WriteLine(num + " is less than " + target);
                int diff = target - num;
                Console.WriteLine(num + " is " + diff + " less than " + target);
            }
            Console.WriteLine();
            return;
        }
    }
}