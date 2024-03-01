using System;
using System.Reflection.Metadata.Ecma335;



namespace exercise_19
{

    class integercalculator
    {
        static void Main()
        {
            Console.WriteLine("Please Insert A value: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Insert B value: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Insert C value: ");
            int c = int.Parse(Console.ReadLine());


            if (a + b == c)
            
                Console.Write("C is equal to " + (a + b));
           

            else if (a + c == b)
                
               Console.Write("B is equal to " + (a + c));
            

            else if (c + b == a)
            
                Console.Write("A is equal to " + (c + b));
            

            else

            Console.Write(" ||| No solution ||| ");
           




        }

    }
}
