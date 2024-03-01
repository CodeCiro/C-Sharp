namespace Tableau
{
    public class Program
    {
        public static void Main()
        {

            int[] tab_3 = { 4, 5, 6,7 };
            for (int i = 0; i <tab_3.Length; i++)
                Console.WriteLine(tab_3[i]);

            Random rand = new Random();
            int number_1 = rand.Next();
            
            int[] tab_1 = new int[1000];
            for(int i=0;i<1000;i++)
                tab_1[i]=i*100;
           


            Console.WriteLine();
            List<int> list_1 = new List<int>();
            List<int> list_2 = new List<int>() { 2, 3, 4 };
            
            list_1.Add(2);
            list_2.Add(3000);
            for(int i=0;i<2;i++)
                Console.WriteLine(list_1[i]);


        }
    }
}