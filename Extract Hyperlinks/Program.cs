using System;
using System.Text;
using System.Text.RegularExpressions;

class ExtractHyperlinks
{
    static void Main()
    {
        StringBuilder input = new StringBuilder();
        byte lineCounter = 0;
        while (true)
        {
            string line = Console.ReadLine();
            lineCounter++;
            if (line == "END" || lineCounter == 100)
            {
                input.Append(line);
                break;
            }
            else
            {
                input.Append(line + "\n");
            }
        }
        string pattern1 = @"<a(.|\n)*?a>";
        Regex rgx1 = new Regex(pattern1);
        MatchCollection matches = rgx1.Matches(input.ToString());

        string pattern2 = @"(?<=\s)(href)(=|\s)+(?<quotes>""|\')(?<essence>((.|\n)*?))(\k<quotes>)";
        Regex rgx2 = new Regex(pattern2);
        Match match;

        foreach (var m in matches)
        {
            //Console.WriteLine(m);
            match = rgx2.Match(m.ToString());
            Console.WriteLine(match.Groups["essence"]);
        }
    }
}