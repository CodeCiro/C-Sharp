
using System.Diagnostics;

namespace Project_04
{
    public class Program
    {
        public static void Main()
        {
            // generating a random number (1,100)
            // asking the user to guess this number
            // guiding the user through the game by telling him if his guess is less or bigger than the number
            // playGuessingGame

            Random random = new Random();
            int theNumber = 0;
            int guess = -1;
            char play = 'Y';

            while (play == 'Y')
            {
                theNumber = random.Next(1, 100);
                guess = -1;
                while (theNumber != guess)
                {
                    Console.WriteLine("please guess a number : ");
                    guess = int.Parse(Console.ReadLine());

                    if (guess > theNumber)
                        Console.WriteLine("your guess : " + guess + " is bigger than the Number !");
                    else if (guess < theNumber)
                        Console.WriteLine("your guess : " + guess + " is smaller than the Number !");
                    else
                        Console.WriteLine("CGR ! you won ! the number is " + guess);
                }

                Console.WriteLine("would you like to play again? Y/N");
                play = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("thanks for stopping by. see you soon !");

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