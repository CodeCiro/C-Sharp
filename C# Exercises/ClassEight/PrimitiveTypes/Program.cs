using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Primitive Types

            /***********************************************
             *  Character type
             **********************************************/
            char middle_initial = 'J';  // Notice the single quotes around characters
            Console.WriteLine("My middle initial is " + middle_initial);

            /***********************************************
            *  Integer types
            **********************************************/
            ushort exam_score = 55;  // same as unsigned short exam_score {55};
            Console.WriteLine("My exam score was " + exam_score);

            int countries_represented = 65;
            Console.WriteLine("There were " + countries_represented + " countries represented in my meeting");

            long people_in_florida = 20610000;
            Console.WriteLine("There are about " + people_in_florida + " people in Florida");

            //  long people_on_earth  =7'600'000'000;    example of overflow 
            //  Console.WriteLine ( "There are about " << people_on_earth << " people on earth" );


            //   long people_on_earth  {7'600'000'000};     // make sure this is a long long and not just a long
            //  Console.WriteLine ( "There are about " << people_on_earth << " people on earth" );

            ulong distance_to_alpha_centauri = 9461000000000;
            Console.WriteLine("The distance to alpha centauri is " + distance_to_alpha_centauri + " kilometers");


            /***********************************************
            *  Floating point types
            **********************************************/
            float car_payment = 401.23f;
            //int car_payment = 401.23;  //try it with int to see the truncated 40
            Console.WriteLine("My car payment is " + car_payment);

            double pi = 3.14159;
            Console.WriteLine("PI is " + pi);

           long large_amount = 2747563333120;  //very large and very small numbers
            Console.WriteLine(large_amount + " is a very big number");

            /***********************************************
            *  Boolean type
            **********************************************/
            bool game_over = false;
            Console.WriteLine("The value of gameOver is " + game_over);

            /***********************************************
            *  Overflow example
            **********************************************/
            short value1 = 30000;
            short value2 = 1000;
            //short product = value1 * value2;

          //  Console.WriteLine("The product of " + value1 + " and " + value2 + " is " + product);


        }


    }
}

