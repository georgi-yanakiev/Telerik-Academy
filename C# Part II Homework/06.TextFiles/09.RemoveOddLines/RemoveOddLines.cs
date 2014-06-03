// 09. Write a program that deletes from given text file all odd lines. The result should be in the same file.

using System;
using System.IO;

class RemoveOddLines
{
    static void Main(string[] args)
    {
        Console.Title = "Remove Odd Lines";
        Console.WriteLine("Removing odd lines...");

        string line = string.Empty;
        int lineNumber = 0;

        try
        {
            using (StreamReader readFIle = new StreamReader(@"..\..\TextFile.txt"))
            {
                using (StreamWriter tempFile = new StreamWriter(@"..\..\temp.txt")) // a temp file
                {
                    while ((line = readFIle.ReadLine()) != null)
                    {
                        lineNumber++;

                        if (lineNumber % 2 == 0)
                        {
                            tempFile.WriteLine(line); // write the even lines only into a temp file
                        }
                    }

                }
            }
        }
        catch (System.IO.FileNotFoundException ex)
        {
            Console.WriteLine("File {0} is not found!", ex.FileName);
        }


        if (File.Exists(@"..\..\temp.txt"))
        {
            File.Delete(@"..\..\TextFile.txt"); // removes the original file
            File.Move(@"..\..\temp.txt", @"..\..\TextFile.txt"); // moves the temp file with the original name
        }
    }
}
