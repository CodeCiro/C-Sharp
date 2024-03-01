using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

    Write a C# program as follows:

    Declare 2 empty lists of integers named
    list1 and list2, respectively.

    Add 10 and 20 to list1 dynamically using Add
    Display the elements in list1  as well as its size 

    Add 100 and 200 to list2 dynamically using Add
    Display the elements in list2 its size 

    Declare an empty 2D list called list_2d
    Remember, that a 2D list is a list of list<int>

    Add list1 to list_2d dynamically using Add
    Add list2 to list_2d dynamically using Add

    Display the elements in list_2d using the at() method

    Change list1.at(0) to 1000

    Display the elements in list_2d again using the at() method

    Display the elements in list1

    What did you expect? Did you get what you expected? What do you think happended?
*/



        //     Declare 2 empty lists of integers named
        //     list1 and list 2, respectively.

        List<int> list1=new List<int>();
        List<int> list2 = new List<int>();

        //    Add 10 and 20 to list1 dynamically using push_back

        list1.Add(10);
        list1.Add(20);

        //    Display the elements in list1 using the at() method as well as its size using the size() method

        Console.WriteLine( "\nlist1: " );
        Console.WriteLine( list1[0] );
        Console.WriteLine( list1[1] );
        Console.WriteLine( "list1 contains " + list1.Count + " elements" );

        //    Add 100 and 200 to list2 dynamically using push_back

        list2.Add(100);
        list2.Add(200);

        //    Display the elements in list2 using the at() method as well as its size using the size() method

        Console.WriteLine( "\nlist2: " );
        Console.WriteLine( list2[0] );
        Console.WriteLine( list2[1] );
        Console.WriteLine( "list2 contains " + list2.Count + " elements" );

        //   Declare an empty 2D list called list_2d
        //   Remember, that a 2D list is a list of list<int>

        List<List<int>> list_2d=new List<List<int>>();

        //    Add list1 to list_2d dynamically using push_back
        //    Add list2 to list_2d dynamically using push_back

        list_2d.Add(list1);
        list_2d.Add(list2);

        //    Display the elements in list_2d using the at() method

        Console.WriteLine( "\nlist_2d:" );
        Console.WriteLine( list_2d[0][0] + "  " + list_2d[0][1] );
        Console.WriteLine( list_2d[1][0] + "  " +list_2d[1][1]);

        //   Change list1.at(0) to 1000

        list1[0] = 1000;

        //    Display the elements in list_2d again using the at() method

        Console.WriteLine( "\nlist_2d:" );
        Console.WriteLine( list_2d[0][0] + "  " + list_2d[0][1] );
        Console.WriteLine( list_2d[1][0] + "  " + list_2d[1][1] );

        //    Display the elements in list1 

        Console.WriteLine( "\nlist1: " );
        Console.WriteLine( list1[0] );
        Console.WriteLine( list1[1] );
        Console.WriteLine( "list1 contains " + list1.Count + " elements" );

        /*
                What did you expect?
                Did you expect to see the 1000 in the list_2d after you changed list1?

                Did you get what you expected?

                What do you think happended?
                It looks like copies are being made, right?

        */
        Console.WriteLine( );
        
    }


}
    }

