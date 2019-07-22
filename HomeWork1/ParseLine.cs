using System;

namespace HomeWork1
{
    class ParseLine
    {
        private static string numberIdentifier = "--number";
        private static string flagIdentifier = "--flag";
        private static string stringIdentifier = "--string";

        private static string outputResult;
        private static bool invalidInput = false;

        public static void ReadAndParse()
        {
            string inputLine;
            Console.WriteLine("Enter line to parse.");
            inputLine = Console.ReadLine();
            string line = inputLine.Trim();

            while (!line.Equals(string.Empty) && !invalidInput)
            {
                line = line.Trim();
                if (line.StartsWith(numberIdentifier))
                {
                    line = line.Remove(0, numberIdentifier.Length);
                    line = ProcessNumber(line);
                    continue;
                }

                if (line.StartsWith(flagIdentifier))
                {
                    line = line.Remove(0, flagIdentifier.Length);
                    line = ProcessFlag(line);
                    continue;
                }

                if (line.StartsWith(stringIdentifier))
                {
                    line = line.Remove(0, stringIdentifier.Length);
                    line = ProcessString(line);
                    continue;
                }

                invalidInput = true;
                break;
            }

            UpdateOutputResults();
            PrintResults();
        }

        public static string ProcessNumber(string line)
        {
            if (line.StartsWith(" ") || line.StartsWith("="))
            {
                line = line.Remove(0, 1);
                int nextValueIndex = line.IndexOf("--");
                string numberString;
                if (nextValueIndex > 0)
                {
                    numberString = line.Substring(0, nextValueIndex);
                    line = line.Remove(0, nextValueIndex);
                }
                else
                {
                    numberString = line;
                    line = string.Empty;
                }
                numberString = numberString.Trim();
                int number;

                if (int.TryParse(numberString, out number))
                {
                    outputResult = outputResult + $"number: {number}" + "\n";
                    return line;
                }
            }

            invalidInput = true;
            return string.Empty;
        }

        public static string ProcessFlag(string line)
        {
            if (line.StartsWith(" ") || line.StartsWith("=") || line.Trim().Equals(string.Empty))
            {
                if (!line.Equals(string.Empty))
                    line = line.Remove(0, 1);
                int nextValueIndex = line.IndexOf("--");
                string flagString;
                if (nextValueIndex >= 0)
                {
                    flagString = line.Substring(0, nextValueIndex);
                    line = line.Remove(0, nextValueIndex);
                }
                else
                {
                    flagString = line;
                    line = string.Empty;
                }
                flagString = flagString.Trim();
                bool flag = true;

                if (flagString.Equals(string.Empty) || bool.TryParse(flagString, out flag))
                {
                    outputResult = outputResult + $"flag: {flag}" + "\n";
                    return line;
                }
            }
            invalidInput = true;
            return string.Empty;
        }

        public static string ProcessString(string line)
        {
            if (line.StartsWith(" ") || line.StartsWith("="))
            {
                string stringValue;
                line = line.Remove(0, 1);
                line = line.Trim();
                if (line.StartsWith("\""))
                {
                    line = line.Remove(0, 1);
                    int indexOfLastQuote = line.IndexOf("\"");
                    stringValue = line.Substring(0, indexOfLastQuote);
                    line = line.Remove(0, indexOfLastQuote + 1);

                    outputResult = outputResult + $"string: {stringValue}" + "\n";
                    return line;
                }
            }
            invalidInput = true;
            return string.Empty;
        }

        private static void UpdateOutputResults()
        {
            if (!invalidInput)
            {
                if (!outputResult.Contains("number"))
                {
                    invalidInput = true;
                    return;
                }
                if (!outputResult.Contains("flag"))
                {
                    outputResult = outputResult + "flag: False" + "\n";
                }
                if (!outputResult.Contains("string"))
                {
                    outputResult = outputResult + "string: was skipped" + "\n";
                }
            }
        }

        private static void PrintResults()
        {
            Console.WriteLine("Output:");
            if (invalidInput)
            {
                Console.WriteLine("Invalid input. See brief help below:");
                Console.WriteLine("Accepted parameters:");
                Console.WriteLine("--number: takes any integer number, mandatory parameter! E.g. \"--number 21\"");
                Console.WriteLine("--flag: Boolean flag, optional. Given without value sets flag to true, can be passed with value. E.g. \"--flag\" or \"--flag true\" or \"--flag false\"");
                Console.WriteLine("--string:  accepts any non-empty double-quoted string without quotes inside, optional. E.g. \"--string \"asdkjb\" \"");
                Console.WriteLine("Parameter starts with \"--\", value is divided from parameter with space or \"=\". ");
            }
            else
                Console.Write(outputResult);

            Console.ReadLine();
        }
    }
}