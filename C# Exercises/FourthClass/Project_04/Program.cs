// For Loop
namespace Project_03
{
    public class Program
    {
        public static void Main()
        {

            for (int i = 1; i <= 10; ++i)
                Console.WriteLine(i);
            Console.WriteLine();

            for (int i = 1; i <= 10; i += 2)  //increment by 2
                Console.WriteLine(i);
            Console.WriteLine();

            for (int i = 10; i > 0; --i)   //count down
                Console.WriteLine(i);
            Console.WriteLine("Hoora!");   //this cout is not in the loop. carreful with indentation

            Console.WriteLine();

            for (int i = 10; i <= 100; i += 10)
            {
                if (i % 15 == 0)
                    Console.WriteLine(i);
            }

            Console.WriteLine();

            for (int i = 1, j = 5; i <= 5; ++i, ++j)   //comma operator
                Console.WriteLine(i + " + " + j + " = " + (i + j));

            Console.WriteLine();

            for (int i = 1; i <= 100; ++i)
            {
                Console.WriteLine(i);
                if (i % 5 == 0)
                    Console.WriteLine();
                else
                    Console.WriteLine(" ");
            }

            Console.WriteLine();

            for (int i = 1; i <= 100; ++i)
            {
                Console.WriteLine(i + ((i % 10 == 0) ? "\n" : " "));  //written on a single line
            }

            Console.WriteLine();

            int[] nums = new int[5] { 10, 20, 30, 40, 50 };

            for (uint i = 0; i < nums.Length; ++i)
                Console.WriteLine(nums[i]);


            Console.WriteLine();
            return;
        }


    }
}