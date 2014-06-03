// 04. Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg)
// and stores it the current directory. Find in Google how to download files in C#. 
//Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;

internal class InternetFileDownload
{
    private static void Main(string[] args)
    {
        Console.Title = "Internet File Download";
        Console.Write("Enter the URL of the file: ");

        try
        {
            string url = Console.ReadLine();
            string fileName = System.IO.Path.GetFileName(url); // gets the file from the url
            WebClient Client = new WebClient();

            using (Client)
            {
                Client.DownloadFile(url, @"..\..\" + fileName); // downloads the file in the project folder
                Console.WriteLine("Downloading file {0}", fileName);
            }

        }
        catch (WebException)
        {
            Console.WriteLine("Address is invalid.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The address parameter is null.");
        }
        catch (NotSupportedException)
        {
            Console.Error.WriteLine("The method has been called simultaneously on multiple threads.");
        }

    }
}