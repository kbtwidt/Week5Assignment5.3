namespace Week5Assignment5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1
            Console.WriteLine("Part 1\n");
            Console.Write("Enter a length for the flower bed: ");
            int n = int.Parse(Console.ReadLine());
            int[] flowerBed = new int[n];
            Console.WriteLine("\n Flowers must have an empty plot next to them. Enter the current flower bed layout. (1 for planted, 0 for empty)");
            for (int i = 0; i < flowerBed.Length; i++)
            {
                Console.Write($"Plot [{i + 1}]: ");
                flowerBed[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter the number of flowers you would like to add: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write($"\nCan the flower bed support the requested additions: {FlowerBed(flowerBed, target)}");
            #endregion

            #region Part 2
            Console.WriteLine("\nPart 2\n");
            Console.Write($"How many steps are their on the staircase: ");
            int steps = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nThere are {ClimbStairs(steps)} ways to climb the stairs."); 
            #endregion
        }

        static bool FlowerBed(int[] plot, int target)
        {
            int count = 0;

            for (int i = 0; i < plot.Length; i++)
            {
                if (plot[i] == 0 &&
                    (i == 0 || plot[i - 1] == 0) &&
                    (i == plot.Length - 1 || plot[i + 1] == 0))
                {

                    plot[i] = 1;
                    count++;
                }
            }

            return count >= target;
        }

        static int ClimbStairs(int steps)
        {
            int previous = 1, current = 2;
            if (steps <= 2)
                return steps;
            for (int i = 3;  i <= steps; i++)
            {
                int next = previous + current;
                previous = current;
                current = next;
            }

            return current;
        }
    }
}
