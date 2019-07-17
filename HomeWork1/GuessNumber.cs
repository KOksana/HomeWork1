using System;

namespace HomeWork1
{
    class GuessNumber
    {
        static int GenerateRandomNumber(int minValue, int maxValue)
        {
            Random random = new Random();
            return random.Next(minValue, maxValue);
        }

        public static void Processing()
        {
            int numberToGuess;
            int usersNumber;

            string readValue;
            bool isParsed = false;

            int minValue = 0;
            int maxValue = 100;

            numberToGuess = GenerateRandomNumber(minValue, maxValue);

            Console.WriteLine($"Guess number from {minValue} to {maxValue}");
            while (true)
            {
                readValue = Console.ReadLine();
                isParsed = int.TryParse(readValue, out usersNumber);
                if (!isParsed)
                {
                    Console.WriteLine("You entered invalid number. Try again.");
                    continue;
                }
                else if (usersNumber < numberToGuess)
                {
                    Console.WriteLine("Your input is less, than program’s number");
                    continue;
                }
                else if (usersNumber > numberToGuess)
                {
                    Console.WriteLine("Your input is greater, than program’s number");
                    continue;
                }
                else
                {
                    Console.WriteLine("You win!");
                    Console.ReadLine();
                    break;
                }
            }
        }

    }
}