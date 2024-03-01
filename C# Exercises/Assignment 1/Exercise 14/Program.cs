using System.Diagnostics;

namespace exercise_14
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please, enter the number of prints: ");
            int prints = int.Parse(Console.ReadLine());


            float price = prints * 0.05f;
            if (prints <= 100 && prints > 0)
            {

                Console.WriteLine("The total price is " + price + " dollars.");
            }
            else
            {
                float price2 = (prints - 100) * 0.03f + 5f;
                Console.WriteLine("The total price is " + price2 + " dollars.");
            }
        }
    }
}