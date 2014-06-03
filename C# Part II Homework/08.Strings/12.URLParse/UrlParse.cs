// 12. Write a program that parses an URL address given in the format:
//  and extracts from it the [protocol], [server] and [resource] elements. 
// For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
// [protocol] = "http"
// [server] = "www.devbg.org"
// [resource] = "/forum/index.php"

using System;

class UrlParse
{
    static void Main(string[] args)
    {
        Console.Title = "URL Parse";

        Console.Write("Enter an URL: ");
        Uri url = new Uri(Console.ReadLine());

        Console.WriteLine("Protocol = {0}", url.Scheme); // protocol
        Console.WriteLine("Server = {0}", url.Host); // server
        Console.WriteLine("Resource = {0}", url.AbsolutePath); // resource
    }
}
