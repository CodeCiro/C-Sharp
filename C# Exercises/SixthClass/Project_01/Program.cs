
namespace Project_01
{
    public class Program
    {
        public static void Main()
        {
            //make an app which finds the max of two integers

            float first, second;
            //getting user inputs
            Console.WriteLine("please enter the first number : ");
            first = float.Parse(Console.ReadLine());
            Console.WriteLine("please enter the second number : ");
            second = float.Parse(Console.ReadLine());

            compare(first, second);

        }

        public static void compare(float first, float second)
        {
            //compare numbers
            if (first > second)
                Console.WriteLine(first + " is bigger.");
            else if (first < second)
                Console.WriteLine(second + " is bigger.");
            else Console.WriteLine(first + " is equal to " + second);

        }

    }
}