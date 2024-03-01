using System;
using System.Runtime.InteropServices;

namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] myArray_1 =
                {//first dim
                   {//second dim
                    {1,2,3,4 } , {4,5,6,7 }, {7,8,9,10 } //third dim
                },
                   {
                    {10,20,30,40 } , {40,50,60,70 }, {70,80,90,100 }
                }
            };

            //displays the first matrix
            for (int row = 0; row < 2; row++) //outer loop
            { //row = 0 
                for(int col = 0; col < 3; col++)  //inner loop
                {
                    for(int third=0; third < 4; third++)
                    {
                        Console.Write(myArray_1[row, col, third] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\n");

            int[,,] myArray_2 =
                {//first dim
                   {//second dim
                    {1,2,3,4 } , {4,5,6,7 }, {7,8,9,10 } //third dim
                },
                   {
                    {30,10,30,40 } , {50,80,60,70 }, {70,80,90,110 }
                }
            };

            //displays the first matrix
            for (int row = 0; row < 2; row++) //outer loop
            { //row = 0 
                for (int col = 0; col < 3; col++)  //inner loop
                {
                    for (int third = 0; third < 4; third++)
                    {
                        Console.Write(myArray_2[row, col, third] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\n");

            

            Console.WriteLine("\n\n");
            Console.WriteLine("my matrix result : ");
            int[,,] result = new int[2,3,4];
            //do the sum of the 2 matrix
            for (int row = 0; row < 2; row++) //outer loop
            { //row = 0 
                for (int col = 0; col < 3; col++)  //inner loop
                {
                    for (int third = 0; third < 4; third++)
                    {
                        result[row, col, third] = myArray_1[row, col, third] + myArray_2[row, col, third];
                        
                        Console.Write(result[row, col, third] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\n");
        }
    }
}
