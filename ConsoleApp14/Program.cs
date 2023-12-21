using System;

namespace SumBetweenConstants
{
    class Program
    {
        static void Main(string[] args)
        {
            const int X = 5;
            const int Y = 10;

            int sum = CalculateSumBetween(X, Y);

            Console.WriteLine($"Sum of numbers between {X} and {Y} is: {sum}");
        }

        static int CalculateSumBetween(int start, int end)
        {
            if (start == end)
            {
                return start;
            }
  
            int sum = 0;
      
            for (int i = Math.Min(start, end); i <= Math.Max(start, end); i++)
            {
                sum += i;
            }

            return sum;
        }
    }
}
