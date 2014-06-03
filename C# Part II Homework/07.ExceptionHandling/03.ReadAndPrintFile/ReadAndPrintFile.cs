// 03. Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
// reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). 
// Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;

class ReadAndPrintFile
{
    static void Main(string[] args)
    {
        Console.Title = "Read And Print File";
        Console.Write("Enter the path of the file: ");

        string path = Console.ReadLine();
        string pathString = path.Replace("\\", "\\\\"); // converts / to // in the path

        try
        {
            string readText = File.ReadAllText(pathString); // reads the whole file
            Console.WriteLine("\nContents of the file: \n\n {0}", readText); // prints the whole file
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid path");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The path is too long. Must be less than 248 characters");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The specified path is invalid");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occurred while opening the file.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Path is in an invalid format.");
        }
    }
}
