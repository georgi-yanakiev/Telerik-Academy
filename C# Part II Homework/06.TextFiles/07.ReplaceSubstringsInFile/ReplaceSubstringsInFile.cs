// 07. Write a program that replaces all occurrences of the substring "start" with 
// the substring "finish" in a text file. Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;

class ReplaceSubstringsInFile
{
    static void Main(string[] args)
    {
        Console.Title = "Replace Substrings In File";

        string workingFile = File.ReadAllText(@"..\..\InputText.txt"); // reading the file
        // writing in the same file replacing the substring "start" with "finish"
        File.WriteAllText(@"..\..\InputText.txt", workingFile.Replace("start", "finish"));
    }
}
