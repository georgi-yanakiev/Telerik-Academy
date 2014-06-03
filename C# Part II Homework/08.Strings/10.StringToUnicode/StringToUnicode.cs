// 10.Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings.

using System;

class StringToUnicode
{
    static void Main(string[] args)
    {
        Console.Title = "String To Unicode";

        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        for (int index = 0; index < input.Length; index++)
        {
            Console.WriteLine("\\u{0:X4}", (int)input[index]);
        }
    }
}
