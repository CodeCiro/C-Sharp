

namespace Exercise_12
{
    public class Program
{
    public static void Main()
    {
        Console.WriteLine("How much is the bill?");
        float bill = float.Parse(Console.ReadLine());

        if (bill >= 1)
        {
            float tips = bill * 0.15f;
            Console.WriteLine("The tips will be: " + tips);
        }
        else
        {
            Console.WriteLine("The bill must be at least 1 dollar.");
        }
    }
}
}
