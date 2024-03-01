

namespace Project_03
{
    public class Program
    {
        public static void Main()
        {
            //write an app to find out if a number is a prime number.
            int theNumber = 0;
            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                theNumber = random.Next(1, 1000);

                if (IsItPrime(theNumber))
                    Console.WriteLine(theNumber + " is not a prime");
                else
                    Console.WriteLine(theNumber + " is  a prime");
            }

        }

        public static bool IsItPrime(int theNumber)
        {

            int theLimit = (int)((theNumber / 2) + 1);
            for (int i = 2; i < theLimit; i++)
            {
                if (theNumber % i == 0)
                    return true;
            }


            return false;
        }

    }
}