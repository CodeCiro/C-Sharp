using System;
using System.Reflection.Metadata.Ecma335;

//Write an algorithm that reads two integers m and n and determines whether m is a multiple of n.

namespace exercise_18
{

    class integercalculator
    {
       static void Main()
        {
            Console.WriteLine("Please Insert M value: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Insert N value: ");
            int b = int.Parse(Console.ReadLine());

            if (a % b == 0)
            {
                Console.Write("M is a Multiple number of N");
            }
         
            else
            {
                Console.Write("M is not Multiple number of N");
             
                
            }

            Console.WriteLine(               );
        }

    }
}
