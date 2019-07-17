using System;

namespace HomeWork1.FbImplementation
{
    public class FizzBuzz
    {
        public static string PrintAndReturnResult(int min, int max, int divisorFirst, int divisorSecond)
        {
            var leastCommonMultiple = CalculateLeastCommonMultiple(divisorFirst, divisorSecond);
            string result = null;
            for (var i = min; i <= max; i++)
                if (i % leastCommonMultiple == 0)
                    result = "FizzBuzz";
                else if (i % divisorFirst == 0)
                    result = "Fizz";
                else if (i % divisorSecond == 0)
                    result ="Buzz";
                else
                {
                    Console.WriteLine(i);
                    result = $"No Least Common Multiple for combination: {min}, {max}, {divisorFirst}, {divisorSecond}."; 
                }
            return result;
        }

        static int CalculateLeastCommonMultiple(int a, int b) 
            => a / CalculateGreatestCommonDivisor(a, b) * b;

        static int CalculateGreatestCommonDivisor(int a, int b) 
            => b == 0 ? a : CalculateGreatestCommonDivisor(b, a % b);
    }
}
