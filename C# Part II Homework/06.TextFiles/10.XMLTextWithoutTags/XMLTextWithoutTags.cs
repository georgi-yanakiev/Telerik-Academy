// 10. Write a program that extracts from given XML file all the text without the tags. 
// Example: <?xmlversion="1.0"><student><name>Pesho</name><age>21</age><interestscount="3"><interest>Games</instrest>
// <interest>C#</instrest><interest>Java</instrest></interests></student>
using System;
using System.IO;
using System.Text.RegularExpressions;

class XMLTextWithoutTags
{
    static void Main(string[] args)
    {
        Console.Title = "XML Text Without Tags";
        Console.WriteLine("Removing tags...");

        string workingFile = File.ReadAllText(@"..\..\XMLFile.xml"); // reading the file

        File.WriteAllText(@"..\..\OutputText.txt", Regex.Replace(workingFile, @"<[^<]+?>", " ")); // extracts  only the words in the xml file using regex pattern "<[^<]+?>"
    }
}
