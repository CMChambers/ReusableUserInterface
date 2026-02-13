// Author: Chad Chambers
// Class: CIS 237
// Date: 2026-02-10

using System;

namespace CMC.Input
{
    // a class to handle getting cli input.
    public class GetInput
    {

        /// <summary>
        /// Prompts the user with the specified message and returns the input as an integer.
        /// </summary>
        /// <param name="prompt">The message displayed to the user before reading input.</param>
        /// <returns>The integer value entered by the user.</returns>
        public static int AsInt(string prompt)                                      // static method to show a given prompt and return input as an int
        {
            while (true)                                                            // loop until valid input
            {
                Console.Write($"{prompt}: ");                                       // print the prompt
                string input = Console.ReadLine() ?? "";                            // get input

                if (int.TryParse(input, out int value))                             // try to parse input to int
                { return value; }                                                   // return the int

                Console.WriteLine("Invalid number. Please enter a valid integer."); // or print error
            }
        }

        /// <summary>
        /// Prompts the user to enter an integer within the specified range.
        /// </summary>
        /// <param name="prompt">The message displayed to the user.</param>
        /// <param name="min">The minimum acceptable integer value.</param>
        /// <param name="max">The maximum acceptable integer value.</param>
        /// <returns>The integer value entered by the user within the specified range.</returns>
        public static int AsInt(string prompt, int min, int max)                    // static method to get int between given min and max
        {
            while (true)                                                            // loop until valid input
            {
                int value = AsInt($"{prompt} ({min} - {max})");                     // call regular int input method

                if (value >= min && value <= max)                                   // check if input in bounds
                { return value; }                                                   // return the int

                Console.WriteLine($"Value must be between {min} and {max}.");       // or print out of bounds error
            }
        }

        /// <summary>
        /// Prompts the user for input and returns the entered value as a double.
        /// </summary>
        /// <param name="prompt">The message displayed to the user before input.</param>
        /// <returns>The double value entered by the user.</returns>
        public static double AsDouble(string prompt)                                // static method to return input as a double
        {
            while (true)
            {
                Console.Write($"{prompt}: ");
                string input = Console.ReadLine() ?? "";

                if (double.TryParse(input, out double value))
                { return value; }

                Console.WriteLine("Invalid number. Please enter a valid decimal value.");
            }
        }

        /// <summary>
        /// Prompts the user to enter a double value within the specified bounds.
        /// </summary>
        /// <param name="prompt">The message displayed to the user when requesting input.</param>
        /// <param name="min">The minimum acceptable value.</param>
        /// <param name="max">The maximum acceptable value.</param>
        /// <returns>A double value entered by the user that falls within the specified range.</returns>
        public static double AsDouble(string prompt, int min, int max)              // static method to get double within given bounds
        {
            while (true)
            {
                double value = AsDouble($"{prompt} ({min} - {max})");

                if (value >= min && value <= max)
                { return value; }

                Console.WriteLine($"Value must be between {min} and {max}.");
            }
        }

        /// <summary>
        /// Prompts the user for input and returns the entered value as a decimal.
        /// </summary>
        /// <param name="prompt">The message displayed to the user before input.</param>
        /// <returns>The decimal value entered by the user.</returns>
        public static decimal AsDecimal(string prompt)                              // static method to return input as decimal
        {
            while (true)
            {
                Console.Write($"{prompt}: ");
                string input = Console.ReadLine() ?? "";

                if (decimal.TryParse(input, out decimal value))
                { return value; }

                Console.WriteLine("Invalid number. Please enter a valid decimal value.");
            }
        }

        /// <summary>
        /// Prompts the user to enter a decimal value within the specified bounds.
        /// </summary>
        /// <param name="prompt">The message displayed to the user.</param>
        /// <param name="min">The minimum acceptable value.</param>
        /// <param name="max">The maximum acceptable value.</param>
        /// <returns>A decimal value entered by the user that falls within the specified range.</returns>
        public static decimal AsDecimal(string prompt, int min, int max)            // static method to get decimal within bounds
        {
            while (true)
            {
                decimal value = AsDecimal($"{prompt} ({min} - {max})");

                if (value >= min && value <= max)
                { return value; }

                Console.WriteLine($"Value must be between {min} and {max}.");
            }
        }

        /// <summary>
        /// Prompts the user for input and returns a non-empty string.
        /// </summary>
        /// <param name="prompt">The message displayed to the user when requesting input.</param>
        /// <returns>A non-empty string entered by the user.</returns>
        public static string AsString(string prompt)                                // static method to return string
        {
            while (true)                                                            // loop until valid input
            {
                Console.Write($"{prompt}: ");                                       // print prompt
                string input = Console.ReadLine() ?? "";                            // get input

                if (!string.IsNullOrWhiteSpace(input))                              // check if null or whitespace
                { return input; }                                                   // return string

                Console.WriteLine("Input cannot be empty. Please try again.");      // or print error message
            }
        }

        /// <summary>
        /// Prompts the user to enter a boolean value and returns the parsed result.
        /// </summary>
        /// <param name="prompt">The message displayed to the user when requesting input.</param>
        /// <returns>The boolean value entered by the user.</returns>
        public static bool AsBool(string prompt)
        {
            while (true)
            {
                Console.Write($"{prompt} (true/false): ");
                string input = Console.ReadLine() ?? "";

                if (bool.TryParse(input, out bool value))
                { return value; }

                Console.WriteLine("Invalid input. Please enter 'true' or 'false'.");
            }
        }
    }
}
