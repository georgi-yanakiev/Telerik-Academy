// 04.Write a program that finds how many times a substring is 
// contained in a given text (perform case insensitive search).

using System;
using System.IO;
using System.Text.RegularExpressions;

class SubstringsInText
{
    static void Main(string[] args)
    {
        Console.Title = "Substrings In Text";
        Console.Write("Enter a substring to be found: ");

        try
        {
            string substr = Console.ReadLine();
            string workingFile = File.ReadAllText(@"..\..\InputText.txt"); // reading the file
            Console.WriteLine("The result is: {0}", Regex.Matches(workingFile.ToLower(), substr.ToLower()).Count); // convert the substring and the text to lowercase and match case insensitive
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found!");
        }
        
    }
}