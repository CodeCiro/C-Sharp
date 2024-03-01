
namespace Exercise_1_2
{
    public class Program
    {
        public static void Main()
        {
            //employeeSalary is the hourly rate and numberHours is the no. of hours worked
            //find the gross salary of employee

            Console.WriteLine("Please put the employee's gross hourly salary");
            float employeeSalary = float.Parse(Console.ReadLine());
            Console.WriteLine("Please put the number of hours");
            float numberHours = float.Parse(Console.ReadLine());

            Console.WriteLine("the employee gross salary is " + employeeSalary * numberHours + "$");

        }
    }
}
