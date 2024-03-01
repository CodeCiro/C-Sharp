using System;
using System.Runtime.ConstrainedExecution;


/*Monique want to have a little program that allows her to evaluate the total amount of her expenses for a month, as well as the amount of money she can allocate for her leisure activities and non-essential spending. The program should read her projections for expenses in the following categories: 

Weekly expenses(one time per week; assuming that 1 month = 4 weeks) 

Food expenses and household expenses 

Common expenses 

 
Monthly expenses (one time per month) 

Public transit pass 

Rent 

Total of monthly bills 

 
The program should also read the amount of her paycheques. Monique receives two paycheques per month. 
 
The program should then display her total expenses, her total income, and the difference.*/

namespace Exercise_5
{
    class budgetcalculator
    {
        static void Main()
        {
            Console.WriteLine("-------BUDGET CALCULATOR-------");
            Console.WriteLine("-------------2022--------------");
            Console.WriteLine("-------------------------------");

            //Weekly expenses(one time per week; assuming that 1 month = 4 weeks) 
            //Food expenses and household expenses 
            //Common expenses 

            Console.WriteLine("Please insert Food Expenses:  ");
            float foodExpense = float.Parse(Console.ReadLine());

            Console.WriteLine("                        ");

            Console.WriteLine("Please insert Household Expenses:  ");
            float houseExpense = float.Parse(Console.ReadLine());

            Console.WriteLine("                        ");

            Console.WriteLine("Please insert Common Expenses:  ");
            float comexpenses = float.Parse(Console.ReadLine());

            Console.WriteLine("                        ");

            float Weekly_expenses = (foodExpense + houseExpense + comexpenses);


            Console.WriteLine("                        ");

            Console.WriteLine("The Weekly expense is CAD$ " + Weekly_expenses + " So far " );

            Console.WriteLine("                        ");

            //Monthly expenses (one time per month) 

            //Public transit pass

            //Rent

            // Total of Monthly bills

            Console.WriteLine(" |||| Fixed Monthly bills |||| ");
            Console.WriteLine("                     ");

            Console.WriteLine("Public transit pass :  ");
            float transExpence =  float.Parse(Console.ReadLine());
                
            Console.WriteLine("Rent :  ");
            float rentExpense = float.Parse(Console.ReadLine());
            Console.WriteLine("                     ");
            float WMonthly_expenses = (rentExpense + transExpence );
            Console.WriteLine("                     ");
            float weeklytomonth = (foodExpense + houseExpense + comexpenses);
            float monweek = weeklytomonth * 4;
            Console.WriteLine("                     ");
            Console.WriteLine("The Monthly expense is CAD$ " + (monweek + WMonthly_expenses) );

            Console.WriteLine("                        ");

            //The program should also read the amount of her paycheques. Monique receives two paycheques per month.

            Console.WriteLine("          INCOME:          ");
            Console.WriteLine("                        ");
            Console.WriteLine("PayCheck :  ");
            float paycheck = float.Parse(Console.ReadLine());

            float monthlypay = paycheck * 2;
            Console.WriteLine("                     ");
            Console.WriteLine("Your Monthly Revenue is CAD$ " + monthlypay );
            Console.WriteLine("                        ");

            Console.WriteLine("        |||  BALANCE  |||            ");

            Console.WriteLine("                        ");

            //The program should then display her total expenses, her total income, and the difference.

            Console.WriteLine(" Your total Income is CAD$ " + monthlypay );
            Console.WriteLine("                     ");
            Console.WriteLine(" Your total Expenses are CAD$ " + (monweek + WMonthly_expenses));
            Console.WriteLine("                     ");
            Console.WriteLine(" Balance Total CAD$ " + ( monthlypay - (monweek + WMonthly_expenses)));
            Console.WriteLine("                     ");

            float totalmonth = (monthlypay - (monweek + WMonthly_expenses) );

            if (totalmonth > 0)
            {
                Console.WriteLine("  This Month you manage to save CAD$ " + totalmonth + 
                    " |||| Congratulations |||| ");
            }

            if (totalmonth <= 0)
            {
            Console.WriteLine("  ||| Hang ON! Next Month will be better  |||  ");
            }

            Console.WriteLine("                     ");
            

        }
    }
}



