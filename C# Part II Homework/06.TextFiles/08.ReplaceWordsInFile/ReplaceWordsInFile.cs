// 08. Modify the solution of the previous problem to replace only whole words (not substrings).

using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceWordsInFile
{
    static void Main(string[] args)
    {
        Console.Title = "Replace Words In File";
        Console.WriteLine("Replacing...");

        string workingFile = File.ReadAllText(@"..\..\InputText.txt"); // reading the file

        // writing in the same file replacing the exact word "start" with "finish" using regular expressions
        File.WriteAllText(@"..\..\InputText.txt", Regex.Replace(workingFile, @"\b(start)\b", "finish"));

    }
}
