using System;
using System.Text.RegularExpressions;

namespace Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            while (input!="end")
            {
                Regex regex = new Regex("^\\+359( |-)2\\1[\\d]{3}\\1[\\d]{4}$");

                var matches = regex.Matches(input);

                foreach (Match match in matches)
                {
                    Console.WriteLine(match);
                }

                input = Console.ReadLine();
            }
        }
    }
}
