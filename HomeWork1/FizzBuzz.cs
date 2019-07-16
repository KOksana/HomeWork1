using System;

namespace HomeWork1
{
    public class FizzBuzz
    {
        public static void PrintResult(int min, int max, int divisor1, int divisor2)
        {
            int lcm = CulcLcm(divisor1, divisor2);

            for (int i = min; i <= max; i++)
            {
                if (i % lcm == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % divisor1 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % divisor2 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        static int CulcLcm(int a, int b)
        {
            return a / CulcGcd(a, b) * b;
        }

        static int CulcGcd(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            return CulcGcd(b, a % b);
        }
    }
}
