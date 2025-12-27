using Microsoft.VisualBasic;
using System.Runtime.InteropServices.Marshalling;

namespace FlipKey
{
    public class Program
    {


        /// <summary>
        /// Processes the specified input string by validating its format, reversing it, filtering out characters with
        /// even ASCII values, and applying alternating casing to the result.
        /// </summary>
        /// <remarks>Characters with even ASCII values are excluded from the result. The first character
        /// of the output is uppercase, with casing alternating for each subsequent character. The method does not
        /// modify the original input string.</remarks>
        /// <param name="input">The input string to be cleansed and inverted. Must be at least 6 characters long, contain no spaces, digits,
        /// or special characters (!@#$%^&*(){}[]), and cannot be null or empty.</param>
        /// <returns>A new string containing the processed result with alternating casing applied to the filtered, reversed
        /// input. Returns "Invalid Input" if the input does not meet the required criteria.</returns>
        public static string CleanseAndInvert(string input)
        {

            /// Validate input
            string specialChars = "!@#$%^&*(){}[]";
            if (string.IsNullOrEmpty(input) 
                || input.Length < 6 
                || input.Contains(" ") 
                || input.Any(char.IsDigit) 
                || input.Any(c => specialChars.Contains(c))
                )
            {
                return "Invalid Input";
            }

            // Convert input string to character array
            char[] charArray = input.ToCharArray();

            // Initialize result string
            string result = "";


            // Reverse the character array and filter out characters with even ASCII values
            for (int i = charArray.Length - 1; i >= 0 ; i--)
            {
               
                int asciiValue = (int)charArray[i];

                if (asciiValue % 2 == 0)
                {
                    continue;
                }
                else
                {
                    result += charArray[i];
                }
            }

            // Convert result to lowercase
            result.ToLower();

            // Initialize final answer string to store the alternating case result
            string finalAns = " ";

            // Apply alternating casing to the result
            for (int i = 0; i < result.Length; i++)
            {
                
                if (i % 2 == 0)
                {
                  
                    finalAns += Char.ToUpper(result[i]); ;

                }
                else
                {
                    finalAns += result[i];
                }
            }

            return finalAns;


        }

        /// <summary>
        /// Serves as the entry point for the application.
        /// </summary>
        /// <param name="args">An array of command-line arguments supplied to the application.</param>
        public static void Main(string[] args)
        {
            /// Prompt user for password input
            Console.WriteLine("Enter password");
            string pass = Console.ReadLine();

            string ans = CleanseAndInvert(pass);
            Console.WriteLine(ans);
        }
    }
}
