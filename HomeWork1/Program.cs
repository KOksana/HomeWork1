using System;

namespace HomeWork1
{
    class Program
    {
        static void FizzBuzz(int limit)
        {
            for (int i = 1; i <= limit; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void FizzBuzzProcessing()
        {
            int upperLimit;
            String readValue;
            bool isParsed = false;

            Console.WriteLine("Enter upper limit number for FizzBuzz. Enter 'q' for exit.");
            readValue = Console.ReadLine();

            while (readValue != "q" && readValue != "Q")
            {
                isParsed = int.TryParse(readValue, out upperLimit);
                if (isParsed)
                {
                    FizzBuzz(upperLimit);
                }
                else
                {
                    Console.WriteLine("You entered invalid number. Try again.");
                }
                Console.WriteLine("Enter upper limit number for FizzBuzz. Enter 'q' for exit.");
                readValue = Console.ReadLine();
            }
        }

        static void Main(string[] args)
        {
            FizzBuzzProcessing();
        }
    }
}
