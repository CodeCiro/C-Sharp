using System;

/*In a computer technology course, the following evaluation weights are used:

Laboratory work counts for 40% of the grade
The midterm exam counts for 25%
The final exam counts for 35%

Make a program that calculates the final grade of a student, assuming that each of the three grades the user inputs is out of 100.

*/
namespace exercise_4

{
    class gradeCalculation
    {
        static void Main()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Student's FINAL GRADE ");
            Console.WriteLine("-----------------------");


            int lab_weight = 40;

            int mid_weight = 25;

            int final_weight = 35;

            int perfectgrade = 100;

            //int almostgrade = 60;

            int needtofocus = 99;


            if ((lab_weight + mid_weight + final_weight) != 100)
            {
                Console.WriteLine("Sum is not equal to 100.");
                return;
            }

            Console.WriteLine("1. Enter Laboratory grade : ");
            double lab_grade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. Enter Midterm Exam grade : ");
            double mid_grade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("3. Enter Final Exam grade : ");
            double final_grade = Convert.ToInt32(Console.ReadLine());

            double grade = (mid_weight * mid_grade + final_weight * final_grade + lab_weight * lab_grade) / 100.0;

            Console.WriteLine("                   ");
            Console.WriteLine(" Your grade is {0}", grade);
            Console.WriteLine("                   ");

            if (grade == perfectgrade)
            {
                Console.WriteLine("                   ");
                Console.WriteLine(" |||| YOU'RE OVER THE TOP ||||");
                Console.WriteLine("                   ");
            }


            if (grade < needtofocus)
            {
                Console.WriteLine("                   ");
                Console.WriteLine("    |||| TO FOCUS, YOU NEED. |||| ");
                Console.WriteLine(" |||| BETTER GRADE YOU'LL HAVE. ||||");
                Console.WriteLine("                   ");
            }

            /*if (grade < almostgrade)
            {
                Console.WriteLine("                   ");
                Console.WriteLine("    |||| DANGER, DANGER. |||| ");
                Console.WriteLine(" |||| HULL IS HALF DAMAGED NEED REPAIRS ||||");
                Console.WriteLine("                   ");
            }
            */

        }
    }
}
