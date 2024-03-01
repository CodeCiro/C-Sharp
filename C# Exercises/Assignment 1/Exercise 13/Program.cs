namespace exercise_13
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Inform the number of diskettes purchased: ");
            double diskettes = int.Parse(Console.ReadLine());

            double price = int.Parse(Console.ReadLine());
            if (diskettes < 25)
            {
                price = diskettes;
                Console.WriteLine("The price is: " + price);
            }
            else
            {
                price = diskettes * 0.70;
                Console.WriteLine("The price is: " + price);
            }

            Console.WriteLine("Are you a Club Z member? Write 1 for yes or 2 for no. ");
            int club = int.Parse(Console.ReadLine());

            double newPrice = int.Parse(Console.ReadLine());

            if (club == 1)
            {
                newPrice = price * 0.98;
                Console.WriteLine("The total price is: " + newPrice + " with the discount");
            }
            else if (club == 2)
            {
                newPrice = price;
                Console.WriteLine("The total price is: " + price);
            }
            else
            {
                Console.WriteLine("The answer was not accept.");
            }
        }
    }
}
