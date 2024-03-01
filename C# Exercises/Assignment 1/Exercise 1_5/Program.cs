namespace exercise1_5
{
    public class Program
    {
        public static void Main()
        {
            // 400 is the basesalary 
            // 200 is commission for each car sold
            // 5% is bonus B
            //finding the compensation paid to the salesperson

            //step 1 = user input for the compensation of the salesperson
            Console.WriteLine("Please put the total amount sold from cars");
            int amtCar = int.Parse(Console.ReadLine());
            Console.WriteLine("Please put the num of car sold");
            int numCar = int.Parse(Console.ReadLine());

            //step 2 = caculation for compensation of salesperson
            double B = 0.05;
            double compensation_1 = 400 + 200 * numCar + amtCar * B;

            //step 3 =  display compensation price  to the user
            Console.WriteLine(" The compensation of the salesperson is CAD$ " + compensation_1);



        }
    }
}