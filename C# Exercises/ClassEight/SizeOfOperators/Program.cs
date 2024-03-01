using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SizeOfOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // The sizeof operator



            //https://docs.microsoft.com/en-us/cpp/c-language/cpp-integer-limits?view=msvc-160
            //https://docs.microsoft.com/en-us/cpp/cpp/floating-limits?view=msvc-160



        Console.WriteLine( "sizeof information" );
        Console.WriteLine( "========================" );

        Console.WriteLine( "char: " + sizeof(char) + " bytes." );
        Console.WriteLine( "int : " + sizeof(int) + " bytes." );
        Console.WriteLine( "unsigned int: " + sizeof(uint) + " bytes." );
        Console.WriteLine( "short: " + sizeof(short) + " bytes." );
        Console.WriteLine( "long: " + sizeof(long) + " bytes." );
        Console.WriteLine( "unsigned long: " + sizeof(ulong) + " bytes." );

        Console.WriteLine( "========================" );

        Console.WriteLine( "float: " + sizeof(float) + " bytes." );
        Console.WriteLine( "float:" + float.MaxValue );
        Console.WriteLine( "float:" + float.MinValue );
        Console.WriteLine( "double: " + sizeof(double) + " bytes." );
     

        // use values defined in <climits>
        Console.WriteLine( "========================" );

        Console.WriteLine( "Minimum values:" );
        Console.WriteLine( "char: " + char.MinValue );
        Console.WriteLine( "int: " + int.MinValue );
        Console.WriteLine( "short: " + short.MinValue );
        Console.WriteLine( "long: " + long.MinValue );
        Console.WriteLine( "unsignedlong: " + ulong.MinValue );

        Console.WriteLine( "========================" );

        Console.WriteLine( "Maximum values:" );
            Console.WriteLine("char: " + char.MaxValue);
            Console.WriteLine("int: " + int.MaxValue);
            Console.WriteLine("short: " + short.MaxValue);
            Console.WriteLine("long: " + long.MaxValue);
            Console.WriteLine("unsignedlong: " + ulong.MaxValue);

            // sizeof can also be used with variable names
            Console.WriteLine( "========================" );

        Console.WriteLine( "sizeof using variable names" );
        int age= 21 ;
      /*  Console.WriteLine( "age is " + sizeof(age) + " bytes." );
        // or
        Console.WriteLine( "age is " + sizeof (age) + " bytes." );

        double wage= 22.24 ;
        Console.WriteLine( "wage is " + sizeof(wage) + " bytes." );
        // or
        Console.WriteLine( "wage is " + sizeof wage + " bytes." ); */


        //std::Console.WriteLine( std::fixed;
        //Console.WriteLine( std::setprecision(10);
        
    }


}
    }

