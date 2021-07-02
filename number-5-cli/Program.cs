using number_5_core;
using System;

namespace number_5_cli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome\n");
            RunBetweenInputAnd5();
        }

        static void RunBetweenInputAnd5()
        {
            var numberChecker = new NumberChecker();
            var userPrompt = "\nPlease enter a number below 5 to get the difference of the input to 5 or 'q' to quit: ";

            string input = getUserInput(userMessage: userPrompt);


            while (input != "q")
            {
                var result = numberChecker.DifferenceBetweenInputAnd5(input);
                if (result.Valid)
                {
                    positiveOutput(message: $"Difference of '{input}' to 5 is: {result.Difference}");
                }
                else
                {
                    negativeOutput(message: $"Error: {result.Error}");
                }

                input = getUserInput(userMessage: userPrompt);
            }

            Console.WriteLine("\nExiting...");
        }

        static string getUserInput(string userMessage)
        {
            Console.WriteLine(userMessage);
            return Console.ReadLine();
        }

        static void positiveOutput(string message)
        {
            writeOutput(message: message, consoleColor: ConsoleColor.Green);
        }
        static void negativeOutput(string message)
        {
            writeOutput(message: message, consoleColor: ConsoleColor.Red);
        }

        static ConsoleColor defaultConsoleColor = ConsoleColor.Gray;
        static void writeOutput(string message, ConsoleColor? consoleColor = null)
        {
            Console.ForegroundColor = consoleColor ?? defaultConsoleColor;
            Console.WriteLine(message);
            Console.ForegroundColor = defaultConsoleColor;
        }
    }
}
