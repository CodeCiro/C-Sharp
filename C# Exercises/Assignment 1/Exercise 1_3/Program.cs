
namespace temperature
{
    public class Program
    {
        public static void Main()
        {
            // the conversion of degree Farenheit into Celsius

            //step=1 get user input
            Console.WriteLine("Please put the degree  in F");
            float degreeFrenheit = float.Parse(Console.ReadLine());

            //step=2 do the calculation
            float C = ((degreeFrenheit - 32) / 9);
            float result = C * 5;

            //step=3 display the result
            Console.WriteLine("the temperature in celsius is " + result);


        }

    }

}