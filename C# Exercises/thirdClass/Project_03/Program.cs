namespace Project_03
{
    public class Program
    {
        public static void Main()
        {
            Random rnd = new Random();
            int theNumber = rnd.Next(100000, 1000000);
            int theLimit = (int)(theNumber / 2) + 1;
            Console.WriteLine(theNumber + " is the random");
            for (int i = 2; i <= theLimit; i++) { 
                if(theNumber % i == 0) { 
                    Console.WriteLine("dividable by " + i + " it is NOT a Prime number");
                    return;
                }
            }

            Console.WriteLine("its a prime number");
        }
    }
}