// While Loop

namespace Project_03
{
    public class Program
    {

        public static void Main()
        {

            int num;
            Console.WriteLine("Enter a positive integer - start the countdown :");
            num = int.Parse(Console.ReadLine());

            while (num > 0)
            {
                Console.WriteLine(num);
                --num;
            }
            Console.WriteLine("Nice!");


            Console.WriteLine("Enter a postive integer to count up to: ");
            num = int.Parse(Console.ReadLine());

            int i = 1;
            while (num >= i)
            {
                Console.WriteLine(i);
                i++;
            }

            int number;

            Console.WriteLine("Enter an integer less than 100: ");
            number = int.Parse(Console.ReadLine());

            while (number >= 100)
            {  // !(number < 100)
                Console.WriteLine("Enter an integer less than 100: ");
                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Thanks");

            bool done = false;


            while (!done)
            {
                Console.WriteLine("Enter an integer between 1 and 5: ");
                number = int.Parse(Console.ReadLine());
                if (number <= 1 || number >= 5)
                    Console.WriteLine("Out of range, try again");
                else
                {
                    Console.WriteLine("Thanks!");
                    done = true;
                }
            }

            Console.WriteLine();
            return;
        }

    }
}