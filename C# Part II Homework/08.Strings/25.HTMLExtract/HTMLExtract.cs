// 25.Write a program that extracts from given HTML file its title (if available),
// and its body text without the HTML tags. 

using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class HTMLExtract
{
    const string readFile = @"..\..\Html.html";
    static void Main()
    {
        Console.Title = "HTML Extract";
        StreamReader reader = new StreamReader(readFile);
        string line;
        string regex = @"(?<=^|>)[^><]+?(?=<|$)";
        StringBuilder content = new StringBuilder();
        string result;
        while ((line = reader.ReadLine()) != null)
        {
            MatchCollection matches = Regex.Matches(line, regex);
            foreach (Match match in matches)
            {
                content.Append(match);
                content.Append(Environment.NewLine);
            }
        }
        result = content.ToString();
        result = System.Text.RegularExpressions.Regex.Replace(result, @"[^\S\r\n]{2,}\s+", " ");
        Console.WriteLine(result);
    }
}
