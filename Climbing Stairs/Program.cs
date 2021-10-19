using System;

namespace Climbing_Stairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ClimbStairs(11));
        }

        static int ClimbStairs(int n)
        {
            if (n == 0 || n == 1) return 1;
            var maxCountOf2 = n / 2;
            var sum = 0;
            for (var i = 0; i < maxCountOf2 + 1; i++)
            {
                var countOf2 = maxCountOf2 - i;
                var countOf1 = n - (2 * countOf2);
                sum += Factorial(countOf2 + countOf1) /
                    (Factorial(countOf2) * Factorial(countOf1));
            }
            return sum;
        }

        static int Factorial(int number)
        {
            var factorial = 1;

            for (var i = number; i >= 1; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
