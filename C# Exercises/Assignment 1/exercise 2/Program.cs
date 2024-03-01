using System;


/*An aircraft pilot wants to know the atmospheric pressure, expressed in atmosphere units (atm), 
 * as the weather station only provides pressure data in kilopascal units (kPa).
 * 1 atm is equivalent to 101.325 kPa.Make a program that performs the conversion.*/

namespace exercise_3
{

    class atmCalculation
    {
        static void Main()
        {

            Console.WriteLine("-------AIRCRAFT---------");
            Console.WriteLine("----ATM TO PASCAL-------");
            Console.WriteLine("                        ");


            Console.WriteLine("Please Insert kPa value: ");
            float kpa_value= float.Parse(Console.ReadLine());

            double atm = 1;
            float kpa = 101.325f;
            double result_1 = (kpa_value) / (atm = kpa);

            Console.WriteLine("                        ");
            Console.WriteLine("                        ");

            Console.WriteLine("The Atm value is : " + result_1 / 1000 + "  Captain, Sir.  ");

            Console.WriteLine("                        ");
            Console.WriteLine("                        ");
            Console.WriteLine("                        ");


            return;

           

            
        }

    }

}

