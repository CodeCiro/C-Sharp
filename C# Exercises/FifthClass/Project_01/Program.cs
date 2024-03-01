// Switch Statement

/*
    Ask the user what grade they expect on an exam and
    tell them what they need to score to get it.
*/


namespace Project_01
{
    public class Program
    {
        public static void Main()
        {

            char letter_grade;

            Console.WriteLine("Enter the letter grade you expect on the exam: ");
            letter_grade= char.Parse(Console.ReadLine());

            switch (letter_grade)
            {
                case 'a':
                case 'A':
                    Console.WriteLine("You need a 90 or above, study hard!");
                    break;
                case 'b':
                case 'B':
                    Console.WriteLine("You need 80-89 for a B, go study!");
                    break;
                case 'c':
                case 'C':
                    Console.WriteLine("You need 70-79 for an average grade" );
                    break;
                case 'd':
                case 'D':
                    Console.WriteLine("Hmm, you should strive for a better grade. All you need is 60-69");
                    break;
                case 'f':
                case 'F':
                    {
                        char confirm;
                        Console.WriteLine("Are you sure (Y/N)? ");
                        confirm = char.Parse(Console.ReadLine());
                        if (confirm == 'y' || confirm == 'Y')
                            Console.WriteLine("OK, I guess you didn't study..." );
                        else if (confirm == 'n' || confirm == 'N')
                            Console.WriteLine("Good- go study!" );
                        else
                            Console.WriteLine("Illegal choice" );
                        break;
                    }

                default:
                    Console.WriteLine("Sorry, not a valid grade" );
                    break;
            }



            Console.WriteLine();
            return;
        }
    }
}

