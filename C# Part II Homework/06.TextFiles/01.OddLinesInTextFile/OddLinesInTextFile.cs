// 01. Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;

class OddLinesInTextFile
{
    static void Main(string[] args)
    {
        Console.Title = "Odd Lines In Text File";

        try
        {
            StreamReader streamReader = new StreamReader(@"..\..\OddLinesInTextFile.txt");

            using (streamReader)
            {
                int lineNumber = 1;
                string line = streamReader.ReadLine();

                while (line != null)
                {
                    if (lineNumber % 2 != 0 && line != null) // checks if the line is odd and there are still lines in file
                    {
                        Console.WriteLine("{0}.  {1}", lineNumber, line);
                    }

                    line = streamReader.ReadLine(); // reads the next line
                    lineNumber++; // increment the line counter
                }
            }
        }
        catch (System.NullReferenceException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (System.IO.FileNotFoundException ex)
        {
            Console.WriteLine("File {0} is not found!", ex.FileName);
        }
        catch
        {
            Console.WriteLine("Fatal error occurred.");
        }
    }
}