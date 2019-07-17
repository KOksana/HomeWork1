using System;

namespace HomeWork1
{
    public class FizzBuzz
    {
        public static void PrintResult(int min, int max, int divisorFirst, int divisorSecond)
        {
            int leastCommonMultiple = CulculateLeastCommonMultiple(divisorFirst, divisorSecond);

            for (int i = min; i <= max; i++)
            {
                if (i % leastCommonMultiple == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % divisorFirst == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % divisorSecond == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        static int CulculateLeastCommonMultiple(int a, int b)
        {
            return a / CulculateGreatestCommonDivisor(a, b) * b;
        }

        static int CulculateGreatestCommonDivisor(int a, int b)
        {
            if (b == 0)
                return a;
            return CulculateGreatestCommonDivisor(b, a % b);
        }
    }
}
