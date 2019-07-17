using System;

namespace HomeWork1.FbImplementation
{
    class FizzBuzzProcessing
    {      
        public static void PrintFizzBuzzWithParams()
        {
            while (true)
            {
                Console.WriteLine("Enter 'q' for exit.");

                var minNumber = GetMinNumber();
                if (minNumber == int.MinValue) break;

                var maxNumber = GetMaxNumber();
                if (maxNumber == int.MinValue) break;

                var firstDivisor = GetFirstDivisor();
                if (firstDivisor == int.MinValue) break;

                var secondDivisor = GetSecondDivisor();
                if (secondDivisor == int.MinValue) break;

                FizzBuzz.PrintAndReturnResult(minNumber, maxNumber, firstDivisor, secondDivisor);

                Console.WriteLine("-----------------------");
                Console.WriteLine("The end and start again.");
                Console.WriteLine("-----------------------");
            }
        }

        private static bool UserWantsToQuit(string readValue) 
            => (readValue != null && readValue.Equals("q", StringComparison.OrdinalIgnoreCase));

        private static int GetNumber(string readValue)
        {
            if (UserWantsToQuit(readValue)) return int.MinValue;
            if (int.TryParse(readValue, out var divisorFirst)) return divisorFirst;

            Console.WriteLine("You entered invalid number.");
            return int.MinValue;
        }

        private static int GetMinNumber()
        {
            Console.WriteLine("-----------------------");
            Console.Write($"Enter min number from '{int.MinValue+1}' to '{int.MaxValue-1}': ");
            return GetNumber(Console.ReadLine());
        }

        private static int GetMaxNumber()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Max number should be greater than the min number!");
            Console.Write($"Enter max number from '{int.MinValue+1}' to '{int.MaxValue-1}': ");
            return GetNumber(Console.ReadLine());
        }

        private static int GetFirstDivisor()
        {
            Console.WriteLine("-----------------------");
            Console.Write($"Enter divisor1 number from '{int.MinValue+1}' to '{int.MaxValue-1}': ");
            return GetNumber(Console.ReadLine());
        }

        private static int GetSecondDivisor()
        {
            Console.WriteLine("-----------------------");
            Console.Write($"Enter divisor2 number from '{int.MinValue+1}' to '{int.MaxValue-1}': ");
            return GetNumber(Console.ReadLine());
        }
    }
}
