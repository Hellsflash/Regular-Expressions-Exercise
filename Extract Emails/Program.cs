using System;
using System.Text.RegularExpressions;

namespace Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var pattern = @"([\w-.]+)+\@+[a-zA-Z-]+(\.[a-zA-Z-]+)+";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                string matchString = match.ToString();

                if (!(matchString.StartsWith("-") || matchString.StartsWith("_") || matchString.StartsWith(".")
                      || matchString.EndsWith("-") || matchString.EndsWith("_") || matchString.EndsWith(".")))
                {
                    Console.WriteLine(matchString);
                }

            }
        }
    }
}
