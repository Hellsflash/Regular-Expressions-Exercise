using System;
using System.Text.RegularExpressions;

namespace Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();


            while (input!="end")
            {
                Regex regex = new Regex(@"\b[A-Z][a-z]{1,} [A-Z][a-z]{1,}\b");

                var matches = regex.Matches(input);

                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Value);
                }

                input = Console.ReadLine();
            }
        }
    }
}
