
namespace First
{
    public class Program
    {
        public static void Main()
        {
            //tells us if a number is odd or even
            for (int i = 0; i < 3; i++)
            {
                //step 1: get user input 
                Console.WriteLine("enter the number : ");
                int theNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("the number you entered is : " + theNumber);

                //step 2: test if the number is even number 
                if (theNumber % 2 == 0)
                {
                    Console.WriteLine(theNumber + " is even.");
                    Console.WriteLine(" por favor");
                }
                else
                    Console.WriteLine(theNumber + " is odd.");
            }
          /*  int counter = 0;
            for (int i = 0; i < 1000; i++) {
                counter = 0;
                Console.WriteLine("helping ppl is a good behavior.");
                counter = counter + 1;
            }
            Console.WriteLine("we are done " + counter );
            */
        }
    }
}