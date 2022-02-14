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
            GetQuotes(numQuotes);
        }

        public static string LoadQuote(string filename)
        {
            if (!File.Exists(filename)) throw new FileNotFoundException($"No such file {filename}.");
            List<string> quotes = File.ReadAllLines(filename).ToList();
            Random generator = new Random();
            int index = generator.Next(0, quotes.Count);
            return quotes[index];
        }

        /// <summary>
        /// Given a positive number of quotes to generate, displays a list of quotes.
        /// </summary>
        /// <param name="numQuotes">The number of quotes to generate</param>
        public static void GetQuotes(int numQuotes)
        {
            // 1. Verify that the number of quotes to generate is positive.
            // 2. If it not positive, throw an exception 
            // 3. If we have no quotes left to generate, we are finished, exit the method
            // 4. If there are more quotes to generate:
            // 4 a. Generate a random quote
            // 4 b. Display the random quote
            // 4 c. Decrement the number of quotes left to generate
            // 4 d. Go to step 3

            if (numQuotes < 1)
            {
                throw new ArgumentException("The number of quotes to generate must be at least 1.");
            }

            while (numQuotes > 0)
            {
                string quote = LoadQuote("quotes.txt");
                Console.WriteLine($"{numQuotes}. {quote}");
                numQuotes = numQuotes - 1;
            }
        }
    }
}
