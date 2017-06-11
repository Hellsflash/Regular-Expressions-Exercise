using System;
using System.Text.RegularExpressions;

namespace Series_Of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();

            for (int i = 97; i < 123; i++)
            {
                var ch = (char)i;
                var word = ch.ToString() + "+";
                Regex regex = new Regex(@word);
                Match match = regex.Match(input);


                while (match!=Match.Empty)
                {
                    input = input.Replace(match.Value, ch.ToString());
                    match = match.NextMatch();
                }

            }
            Console.WriteLine(input);
        }
    }
}
