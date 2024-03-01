
namespace Second
{
    public class Program
    {
        public static void Main()
        {
            //step 1: getting the user input
            Console.WriteLine("please enter first number : ");
            //first number
            int  firstNumber = int.Parse(Console.ReadLine());
            //second number
            Console.WriteLine("please enter second number : ");
            int secondNumber = int.Parse(Console.ReadLine());
            //third number
            Console.WriteLine("please enter third number : ");
            int thirdNumber = int.Parse(Console.ReadLine());


            Console.WriteLine("first Number is : " + firstNumber);
            Console.WriteLine("second Number is : " + secondNumber);
            Console.WriteLine("third Number is : " + thirdNumber);
            Console.WriteLine();

            //step 2: find the biggest number
            //if first is bigger than both second and third => biggest is first
            if (firstNumber > secondNumber && firstNumber > thirdNumber)
                Console.WriteLine(firstNumber + " is the biggest");

            //if second is bigger than both first and third => biggest is second
           else  if (firstNumber < secondNumber && secondNumber > thirdNumber)
                Console.WriteLine(secondNumber + " is the biggest");

            //if third is bigger than both first and second => biggest is third
           else  if (firstNumber < thirdNumber && secondNumber < thirdNumber)
                Console.WriteLine(thirdNumber + " is the biggest");

        }
    }
}