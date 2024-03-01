
namespace Project_02
{
    public class Program
    {
        public static void Main()
        {
            //remember in physics we had a formula to calculate the falling distance
            //of an object : h =(1/2)*g*t*t
            // calculate the distance for the 10 first second.

            for (int t = 1; t < 11; t++)
                PrintDistance(CalculateDistance(t));

        }

        public static double CalculateDistance(int t)
        {
            double distance = (.5) * 9.81 * t * t;
            distance = Math.Round(distance, 2);
            return distance;
        }

        public static void PrintDistance(double distance)
        {
            Console.WriteLine(distance);
        }

    }
}