using System.Collections.Generic;
using System.Diagnostics;
using System;

namespace Comparaison
{
    public class Program
    {
        public static void Main()
        {

            int number_1 = CreateNumbers();
            int number_2 = CreateNumbers();
            List<int> list_1 = CreateFactors( number_1);   //Dr.Brazil
            List<int> list_2 = CreateFactors(number_2);

            
            int sum_1 = TheSum(list_1); //Dr.Bruno with correction of Dr.Brazil
            int sum_2 = TheSum(list_2);

            
            if (CheckRelation(sum_1, sum_2, number_1, number_2))
                Console.WriteLine(number_1 + " " + number_2 + " Yoopi ! relation !");
            else
                Console.WriteLine(number_1 + " " + number_2 + " not yoopi ! not relation");

        }

        public static bool CheckRelation(int sum_1,int sum_2,int number_1,int number_2)
        {
            bool relation = false;

            if (sum_1 == number_2 && sum_2 == number_1)
                relation = true;
            
            return relation;
        }
        public static int TheSum(List<int> lst)
        {
            int sum = 0;
            for (int i = 0; i < lst.Count; i++)            
                    sum=sum+lst[i];
            return sum;
        }
        public static List<int> CreateFactors(int number)
        {
            List<int> list = new List<int>();
            
            for (int div = 1; div < (number / 2 + 1); div++)
            {  
                if (number % div == 0)
                { 
                    list.Add(div);
                    Console.WriteLine(div);                   
                }
            }
            return list;
        }
        public static int CreateNumbers()
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 1000);
            return number;
        }
    }
}


/* 
 * 
 * the sum of factors including 1 (but not the number itself) of one number
is equal to the other number and vice versa.
for example, (220, 284) have such a relation. the factors of 220 are
1,2,4,5,10,11,20,22,44,55, and 110 whose sum equals 284. the factors of 284
are 1,2,4,71,142 whose sum equals 220.
Write a function checkRelation which you call from main() and checks
whether a pair of numbers entered has this relation or has not. Display
the factors of each number to confirm your answer.

do the following twice:
step 1: get the number (user input or random)   220
step 2: create the limit (the number / 2   + 1 )  220/2=110 + 1 = 111
step 3: start dividing by 1 to 111 
        you push any of the factors to your list of factors for that number


now, you have 2 lists of factors.get a sum of the numbers for each list.
compare the sumS.if equal, then has relation, else do not have relation.*/