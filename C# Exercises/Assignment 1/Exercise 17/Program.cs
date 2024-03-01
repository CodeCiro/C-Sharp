



namespace evenOdd
{
    public class Program
    {
        public static void Main()
        {
            // tell us if a number is odd or even
            for (int i = 0; i < 3; i++)
            {
                //step 1: get user input 
                Console.WriteLine("enter the number : ");
                int theNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("the number you entered is : " + theNumber);

                //step 2: test if the number is even or even number 
                if (theNumber % 2 == 0)
                    Console.WriteLine(theNumber + " is even.");

                else
                    Console.WriteLine(theNumber + " is odd.");
            }
        }
    }
}