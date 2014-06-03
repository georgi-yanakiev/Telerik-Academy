using System;
using System.IO;
using System.Text.RegularExpressions;

class DeleteTestWords
{
    static void Main(string[] args)
    {
        Console.Title = "Delete Test Words";
        Console.WriteLine("Removing words...");

        string workingFile = File.ReadAllText(@"..\..\TextFile.txt"); // reading the file

        // writing in the same file replacing the exact word "start" with "finish" using regular expressions
        File.WriteAllText(@"..\..\TextFile.txt", Regex.Replace(workingFile, @"\btest\w*\b", string.Empty)); // with this pattern we remove words starting with test and has (ex testA, testc, test_one)
    }
}
