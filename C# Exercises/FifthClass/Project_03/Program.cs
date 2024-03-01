
// Grades

/*
    Calculate a sudent's grade on an exam given their score
    and tell them if they passed the course

*/

namespace Project_03
{
    public class Program
    {

        public static void Main()
        {

            int score;
            Console.WriteLine("Enter your score on the exam (0-100) : ");
            score=int.Parse(Console.ReadLine());
            char letter_grade;

            if (score >= 0 && score <= 100)
            {
                if (score >= 90)
                    letter_grade = 'A';
                else if (score >= 80)
                    letter_grade = 'B';
                else if (score >= 70)
                    letter_grade = 'C';
                else if (score >= 60)
                    letter_grade = 'D';
                else
                    letter_grade = 'F';

                Console.WriteLine("Your grade is : " + letter_grade );
                if (letter_grade == 'F')
                    Console.WriteLine("Sorry, you must repeat the class" );
                else
                    Console.WriteLine("Congrats!" );

            }
            else
            {
                Console.WriteLine("Sorry, " + score + " is not in range" );
            }


            Console.WriteLine();
            return;
        }

    }
}