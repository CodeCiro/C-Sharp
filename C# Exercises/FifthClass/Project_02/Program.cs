
// Switch with enumeration

namespace Project_02
{
    public class Program
    {
        enum Direction
        {
            left, right, up, down
        };
        public static void Main()
        {


            Direction heading = Direction.up;


            switch (heading)
            {
                case Direction.left:
                    {
                        Console.WriteLine("Going left");
                        break;
                    }
                case Direction.right:
                    {
                        Console.WriteLine("Going right");
                        break;
                    }

                case Direction.up:
                    {
                        Console.WriteLine("Going up");
                        break;
                    }
                case Direction.down:
                    {
                        Console.WriteLine("Going down");
                        break;
                    }
                default:
                    Console.WriteLine("OK");
                    break;
            }

            Console.WriteLine();
            return;
        }
    }
}

