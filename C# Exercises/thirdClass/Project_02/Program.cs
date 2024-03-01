//we want to create an app which calculates how many odd and how many
//even numbers we have out of 100 random numbers

namespace Project_02
{

    public class Program
    {
            public static void Main()
            {
                //we want to create an app which calculates how many odd and how many
                //even numbers we have out of 100 random numbers

                int counter = CountEvenNumber();

                Console.WriteLine("even numbers : " + counter);
                Console.WriteLine("odd numbers : " + (100 - counter));
            }

            public static int CountEvenNumber()
            {
                int theNumber = 0;
                int counter = 0;
                Random random = new Random();
                for (int i = 0; i < 100; i++)
                {
                    theNumber = random.Next(1, 1000);
                    if (theNumber % 2 == 0)
                        counter++;
                }
                return counter;
            }

        }
}