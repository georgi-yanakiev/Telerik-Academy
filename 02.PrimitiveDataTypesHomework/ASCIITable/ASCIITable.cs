using System;
using System.Text;

class ASCIITable
{
    static void Main(string[] args)
    {
        Console.Title = "ASCII Table";
        Console.OutputEncoding = Encoding.ASCII;
        for (int i = 1; i <= 127; i++)
        {
            Console.Write((char)i + ", ");
        }
        Console.WriteLine("\n");
    }
}