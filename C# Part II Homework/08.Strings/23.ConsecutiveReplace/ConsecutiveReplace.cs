// 23. Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

using System;
using System.Text.RegularExpressions;


class ConsecutiveReplace
{
    static void Main()
    {

        Console.Title = "ConsecutiveReplace";

        string input = "Bill Gaaaatees is the managerrr of Miiicrosoftt.";

        var regex = new Regex("(.)\\1+");

        Console.WriteLine(regex.Replace(input, "$1"));
    }
}
