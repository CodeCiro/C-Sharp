using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Logical Operators



            int num = 0;
            const int lower = 10;
            const int upper = 20;



            // Determine if an entered integer is between two other integers
            // assume lower < upper
            Console.WriteLine("Enter an integer - the bounds are " +
                lower + " and " + upper + " : ");
            num = int.Parse(Console.ReadLine());

            bool within_bounds = false;

            within_bounds = (num > lower && num < upper);
            Console.WriteLine(num + " is between " + lower + " and " + upper +
                " : " + within_bounds);

            // Determine if an entered integer is outside two other integers
            // assume lower < upper
            Console.WriteLine("\nEnter an integer - the bounds are " + lower +
                " and " + upper + " : ");
            num = int.Parse(Console.ReadLine());

            bool outside_bounds = false;
            outside_bounds = (num < lower || num > upper);
            Console.WriteLine(num + " is outside " + lower + " and " + upper +
                " : " + outside_bounds);

            // Determine if an entered integer is exactly on the boundary
            // assume lower < upper
            Console.WriteLine("\nEnter an integer - the bounds are " +
                lower + " and " + upper + " : ");
            num = int.Parse(Console.ReadLine());

            bool on_bounds = false;
            on_bounds = (num == lower || num == upper);
            Console.WriteLine(num + " is on one of the bounds which are " +
                lower + " and " + upper + " : " + on_bounds);

            //   Determine is you need to wear a coat based on temperature and wind speed    
            bool wear_coat = false;
            double temperature = 0;
            int wind_speed = 0;

            const int wind_speed_for_coat = 25;       // wind over this value requires a coat
            const double temperature_for_coat = 45; // temperature below this value requires a coat

            // Require a coat if either wind is too high OR temperature is too low
            Console.WriteLine("\nEnter the current temperature in (F) :");
            temperature = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter windspeed in (mph): ");
            wind_speed = int.Parse(Console.ReadLine());


            wear_coat = (temperature < temperature_for_coat || wind_speed > wind_speed_for_coat);
            Console.WriteLine("Do you need to wear a coat using OR? " + wear_coat);


            // Require a coat if BOTH the windspeed is too high AND temperature is too low
            wear_coat = (temperature < temperature_for_coat && wind_speed > wind_speed_for_coat);
            Console.WriteLine("Do you need to wear a coat using AND? " + wear_coat);


            Console.WriteLine();

        }


    }
}

