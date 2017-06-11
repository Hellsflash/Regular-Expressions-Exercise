using System;
using System.Text.RegularExpressions;

namespace Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(?<=[\\\/\(\)\s])[a-zA-Z]{1}\w{2,24}(?=[\\\/\(\)\s])|^[a-zA-Z]{1}\w{2,24}(?=[\\\/\(\)\s])|(?<=[\\\/\(\)\s])[a-zA-Z]{1}\w{2,24}$";
            Regex rgx = new Regex(pattern);
            MatchCollection matches = rgx.Matches(text);
            int sum = 0;
            int biggestSum = 0;
            int index = -3;

            for (int i = 0; i < matches.Count - 1; i++)
            {
                sum = matches[i].Length + matches[i + 1].Length;
                if (sum > biggestSum)
                {
                    biggestSum = sum;
                    index = i;
                }
            }

            Console.WriteLine(matches[index]);
            Console.WriteLine(matches[index + 1]);
        }
    }
}
