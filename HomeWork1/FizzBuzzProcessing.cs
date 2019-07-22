using System;

namespace HomeWork1
{
    class FizzBuzzProcessing
    {      
        public static void PrintFizzBuzzWithParams()
        {
            int min;
            int max;
            int divisorFirst;
            int divisorSecond;

            string readValue;
            bool isParsed = false;

            Console.WriteLine("Enter 'q' for exit.");

            while (true)
            {
                Console.WriteLine("-----------------------");
                Console.Write("Enter min number:  ");
                readValue = Console.ReadLine();
                if (readValue.Equals("q", StringComparison.OrdinalIgnoreCase))
                    break;
                isParsed = int.TryParse(readValue, out min);
                if (!isParsed)
                {
                    Console.WriteLine("You entered invalid number.");
                    continue;
                }

                Console.Write("Enter max number:  ");
                readValue = Console.ReadLine();
                if (readValue.Equals("q", StringComparison.OrdinalIgnoreCase))
                    break;
                isParsed = int.TryParse(readValue, out max);
                if (!isParsed)
                {
                    Console.WriteLine("You entered invalid number.");
                    continue;
                }

                Console.Write("Enter first divisor: ");
                readValue = Console.ReadLine();
                if (readValue.Equals("q", StringComparison.OrdinalIgnoreCase))
                    break;
                isParsed = int.TryParse(readValue, out divisorFirst);
                if (!isParsed)
                {
                    Console.WriteLine("You entered invalid number.");
                    continue;
                }

                Console.Write("Enter second divisor:  ");
                readValue = Console.ReadLine();
                if (readValue.Equals("q", StringComparison.OrdinalIgnoreCase))
                    break;
                isParsed = int.TryParse(readValue, out divisorSecond);
                if (!isParsed)
                {
                    Console.WriteLine("You entered invalid number.");
                    continue;
                }
                                                                          
                FizzBuzz.PrintResult(min, max, divisorFirst, divisorSecond);
            }
        }
    }
}
