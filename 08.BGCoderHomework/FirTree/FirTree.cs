// Task 03. "Telerik Academy Exam 1 @ 6 Dec 2011 Morning"
using System;

class FirTree
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        char asterisk = '*';
        char dot = '.';
        string tempString = null;
        int crt = 1;
        string lastLine = new string(dot, n - 2) + asterisk + new string(dot, n - 2);

        for (int i = 2; i <= n; i++)
        {
            tempString = new string(dot, n - i) + new string(asterisk, crt) + new string(dot, n - i);
            crt = crt + 2;
            Console.WriteLine(tempString);
        }
        Console.WriteLine(lastLine);
    }
}