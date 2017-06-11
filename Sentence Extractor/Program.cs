using System;
using System.Text.RegularExpressions;

namespace Sentence_Extractor
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var text = Console.ReadLine();
            var pattern = @"\b[^.?!]+\b" + word + @"\b.*?[!.?]";
            Regex regex = new Regex(pattern);

            var matches = regex.Matches(text);

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
