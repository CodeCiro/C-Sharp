
namespace numberFifteen
{
    public class Program
    {
        public static void Main()
        {
            //get the current balance as curAmt and withdrawl balance as WithAmt
            //calculate error if withdrawl>current else it is a new balance


            Console.WriteLine("please put the current amount : ");
            int curAmt = int.Parse(Console.ReadLine());

            Console.WriteLine("Please put the withdrawl amount : ");
            int withAmt = int.Parse(Console.ReadLine());

            if (curAmt > withAmt)

                Console.WriteLine(" Your new balance is CAD$ " + (curAmt - withAmt));

            else
                Console.WriteLine("you cant get your money");
        }










    }


}
