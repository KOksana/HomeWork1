using System;

namespace HomeWork1
{
    public class FizzBuzz
    {
        public static void PrintResult(int min, int max, int divisorFirst, int divisorSecond)
        {
            var leastCommonMultiple = CalculateLeastCommonMultiple(divisorFirst, divisorSecond);

            for (var i = min; i <= max; i++)
                if (i % leastCommonMultiple == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % divisorFirst == 0)
                    Console.WriteLine("Fizz");
                else if (i % divisorSecond == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
        }

        static int CalculateLeastCommonMultiple(int a, int b) 
            => a / CalculateGreatestCommonDivisor(a, b) * b;

        static int CalculateGreatestCommonDivisor(int a, int b) 
            => b == 0 ? a : CalculateGreatestCommonDivisor(b, a % b);
    }
}
