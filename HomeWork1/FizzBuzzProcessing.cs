using System;

namespace HomeWork1
{
    class FizzBuzzProcessing
    {      
        public static void PrintFizzBuzzWithParams()
        {
            int min;
            int max;
            int divisor1;
            int divisor2;

            string readValue;
            bool isParsed = false;

            Console.WriteLine("Enter 'q' for exit.");

            while (true)
            {
                Console.WriteLine("-----------------------");
                Console.Write("Enter min number:  ");
                readValue = Console.ReadLine();
                if (readValue == "q" || readValue == "Q")
                {
                    break;
                }
                isParsed = int.TryParse(readValue, out min);
                if (!isParsed)
                {
                    Console.WriteLine("You entered invalid number.");
                    continue;
                }

                Console.Write("Enter max number:  ");
                readValue = Console.ReadLine();
                if (readValue == "q" || readValue == "Q")
                {
                    break;
                }
                isParsed = int.TryParse(readValue, out max);
                if (!isParsed)
                {
                    Console.WriteLine("You entered invalid number.");
                    continue;
                }

                Console.Write("Enter divisor1 number: ");
                readValue = Console.ReadLine();
                if (readValue == "q" || readValue == "Q")
                {
                    break;
                }
                isParsed = int.TryParse(readValue, out divisor1);
                if (!isParsed)
                {
                    Console.WriteLine("You entered invalid number.");
                    continue;
                }

                Console.Write("Enter divisor2 number:  ");
                readValue = Console.ReadLine();
                if (readValue == "q" || readValue == "Q")
                {
                    break;
                }
                isParsed = int.TryParse(readValue, out divisor2);
                if (!isParsed)
                {
                    Console.WriteLine("You entered invalid number.");
                    continue;
                }
                                                                          
                FizzBuzz.PrintResult(min, max, divisor1, divisor2);
            }
        }
    }
}
