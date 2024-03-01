

namespace electricity
{
    public class Program
    {
        public static void Main()

        //calculating the bill for the client if number of days and electricity consumed is given
        // electricity is consumed in kilowatt
        //condition is if client consume more than 200 kw then rate is reduced from $0.30 to $0.20 per kw
        {
            //step 1= user input
            Console.WriteLine("please put the num of days");
            int numDay = int.Parse(Console.ReadLine());

            Console.WriteLine("please put the electricity in kiloWatt");
            int kiloWatt = int.Parse(Console.ReadLine());

            //step 2 = calculation
            if (kiloWatt <= 200)
                Console.WriteLine("bill is CAD$ " + (numDay * 0.50 + kiloWatt * 0.30));

            else
                Console.WriteLine("bill is CAD$ " + (numDay * 0.50 + 60 + (kiloWatt - 200) * 0.20));


        }
    }
}
