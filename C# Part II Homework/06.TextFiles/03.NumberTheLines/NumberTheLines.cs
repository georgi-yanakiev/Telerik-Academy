// 03.Write a program that reads a text file and inserts line numbers in 
// front of each of its lines. The result should be written to another text file.

using System;
using System.IO;

class NumberTheLines
{
    static void Main(string[] args)
    {
        Console.Title = "Number The Lines";
        StreamReader textFileOriginal = new StreamReader(@"..\..\TextFileOriginal.txt");
        StreamWriter textFileWithNumbers = new StreamWriter(@"..\..\TextFileWithNumbers.txt"); // file is located in the project folder
        Console.WriteLine("Numerations of lines...");

        try
        {
            using (textFileWithNumbers) // open streamwriter
            {
                using (textFileOriginal) // open streamreader
                {
                    int lineNumber = 1;
                    string lineRead = string.Empty;

                    while (lineRead != null)
                    {
                        lineRead = textFileOriginal.ReadLine(); // reads the next line
                        if (lineRead != null)
                        {
                            textFileWithNumbers.WriteLine(string.Format("{0}. {1}", lineNumber, lineRead)); // writes the line number and the line to the file
                        }

                        lineNumber++; // increment the line counter
                    }
                }
            }
        }
        catch (System.IO.FileNotFoundException ex)
        {
            Console.WriteLine("File {0} is not found!", ex.FileName);
        }
    }
}