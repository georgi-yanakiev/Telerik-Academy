// Task 03. "Telerik Academy Exam 1 @ 7 Dec 2011 Morning"
using System;

class SandGlass
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        char asterisk = '*';
        char dot = '.';
        string tempString = null;
        int crt = n - 2;
        string firstLastRow = new string(asterisk, n);
        Console.WriteLine(firstLastRow);

        for (int i = 0; i < n / 2; i++)
        {
            tempString = new string(dot, i + 1) + new string(asterisk, crt) + new string(dot, i + 1);
            crt = crt - 2;
            Console.WriteLine(tempString);
        }

        crt = 3;
        for (int j = n / 2; j > 1; j--)
        {
            tempString = new string(dot, j - 1) + new string(asterisk, crt) + new string(dot, j - 1);
            crt = crt + 2;
            Console.WriteLine(tempString);
        }
        Console.WriteLine(firstLastRow);
    }
}