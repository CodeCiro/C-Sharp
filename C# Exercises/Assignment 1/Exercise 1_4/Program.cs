
namespace RectangularPrism
{
    public class Program
    {
        public static void Main()
        {
            //rectangular prism has length l, width b and height h
            //volume of rectangular prism

            //step 1 = get user input for length, width and height of rectangular prism
            Console.WriteLine("Please put the length of rectangular prism ");
            float length = float.Parse(Console.ReadLine());
            Console.WriteLine("Please put the width of rectangular prism");
            float width = float.Parse(Console.ReadLine());
            Console.WriteLine("Please put the height 0f rectangular prism");
            float height = float.Parse(Console.ReadLine());

            //step 2 = using formula of volume
            float volume = length * width * height;

            //step 3 = display of result
            Console.WriteLine("the volume of rectangular prism is " + volume);


        }
    }
}