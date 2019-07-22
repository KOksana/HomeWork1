using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose task: 1 - FizzBuzz; 2 - Guess number; 3 - Parse line");

            string inputValue = Console.ReadLine();
            if (int.TryParse(inputValue, out int taskNumber))
            {
                switch (taskNumber)
                {
                    case 1:
                        FizzBuzzProcessing.PrintFizzBuzzWithParams();
                        break;
                    case 2:
                        GuessNumber.Processing();
                        break;
                    case 3:
                        ParseLine.ReadAndParse();
                        break;
                    default:
                        Console.WriteLine("There are no task with this number");
                        break;
                }
            }
            else
                Console.WriteLine("Wrong task number");
        }
    }
}
