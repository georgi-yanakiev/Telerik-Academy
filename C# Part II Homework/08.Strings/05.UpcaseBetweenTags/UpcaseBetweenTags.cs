// 05.You are given a text. Write a program that changes the text in all regions surrounded
// by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. 

using System;
using System.IO;
using System.Text.RegularExpressions;

class UpcaseBetweenTags
{
    static void Main(string[] args)
    {
        Console.Title = "Upcase Between Tags";
        try
        {
            string workingFile = File.ReadAllText(@"..\..\InputText.txt"); // reading the file

            string pattern = @"<upcase>(.*?)</upcase>"; // a regex pattern matches the values between the tags
            Console.WriteLine(Regex.Replace(workingFile, pattern, match => match.Groups[1].Value.ToUpper())); // replace strings using MatchEvaluator 
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found!");
        }
    }
}