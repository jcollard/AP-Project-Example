using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace AP_Project_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Quote Generator!");
            Console.WriteLine("How many quotes would you like to generate?");
            string userInput = Console.ReadLine();
            int numQuotes = int.Parse(userInput);
            int currQuote = 1;
            while (currQuote <= numQuotes)
            {
                Console.Clear();
                string quote = GenerateQuote("quotes.txt");
                Console.WriteLine($"{currQuote}. {quote}");
                currQuote = currQuote + 1;
                Console.WriteLine("Press Enter To Continue...");
                Console.ReadLine();
            }
        }

        /// <summary>
        /// Given a file containing Quotes, randomly generate a quote
        /// from the list.
        /// </summary>
        /// <param name="filename">The file to select a quote from</param>
        /// <returns>A string containing a quote</returns>
        public static string GenerateQuote(string filename)
        {
            // 1. Validate that the filename exists
            // 2. If it does not exist, throw an exception
            // 3. If it does exist:
            // 4. Create a list to store the quotes
            // 5. Iterate through the file adding each line to the list
            // 6. Generate a random number between 0 and the size of the list
            // 7. Use the randomly generated number as an index to select a quote
            // 8. Return the selected quote
            if (!File.Exists(filename)) throw new FileNotFoundException($"No such file {filename}.");
            List<string> quotes = new List<string>();
            foreach(string quote in File.ReadAllLines(filename))
            {
                quotes.Add(quote);
            }
            Random generator = new Random();
            int index = generator.Next(0, quotes.Count);
            return quotes[index];
        }
    }
}
