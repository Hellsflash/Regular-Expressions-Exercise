using System;
using System.Text.RegularExpressions;

namespace Replace_anchor_tag
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            while (input!="end")
            {
                var pattern = @"<a.?href.*?=(.*)>(.*?)<\/a>";

                var replace = @"[URL href=$1]$2[/URL]";

                var replaced = Regex.Replace(input, pattern, replace);

                Console.WriteLine(replaced);

                input = Console.ReadLine();

            }
        }
    }
}
