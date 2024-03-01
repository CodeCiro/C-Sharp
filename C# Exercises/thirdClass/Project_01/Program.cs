using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Project_01
{
    public class Program
    {
        public static void Main()
        {
            //this app will convert the number of meters to centimers
            //step 1: get user input
            Console.WriteLine("enter the number of meters por favor : ");
            float meters = float.Parse(Console.ReadLine());

            //step 2: do the conversion or calculation
            float centimeters = meters * 100;
            //step 3: display the result to the user
            Console.WriteLine(meters + " meters are " + centimeters + " centimeters.");
            float x = Calculation();
            int y = Add(3, 4);
                        
            return;
        }

        public static float Calculation()
        {
            float result = 45;
            return result;
        }

        public static int Add(int x,int y)
        {
            int result = x + y;
            return result ;
        }
    }
}
