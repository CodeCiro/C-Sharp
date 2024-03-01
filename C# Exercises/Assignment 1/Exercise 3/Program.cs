using System;
/*We want to determine the height of a building of n floors, knowing that the ground floor has a height
of 6 meters and that the other floors each have a height of 4 meters.*/

namespace exercise_2
{

    class heightcalculation
    {

        static void Main()
        {
            Console.WriteLine("--------HOW HIGH IS IT?---------");
            Console.WriteLine("---BUILDING HEIGHT CALCULATOR---");
            Console.WriteLine("                                ");
            Console.WriteLine("                                ");

            Console.WriteLine("INSERT NUMBER OF FLOORS:   ");
            int quantfloors = int.Parse(Console.ReadLine());


            int otherfloors = 4;
            int result_1 = quantfloors * otherfloors + 6;
            int wowhigh = 200;
            

            Console.WriteLine( "The Height is :  "  + result_1 + " meters " );

                if ( result_1 > wowhigh )
                {

                Console.WriteLine("                             ");
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                Console.WriteLine("||| WOW THATs REALLY HIGH |||");
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                Console.WriteLine("                             ");

            }
         

            return;
        }
    }
}