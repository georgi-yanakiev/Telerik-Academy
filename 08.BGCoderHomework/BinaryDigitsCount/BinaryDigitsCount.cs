// Task 04. "C# Fundamentals 2011/2012 Part 1 - Sample Exam"
using System;
using System.Text.RegularExpressions;

class BinaryDigitsCount
{
    static void Main(string[] args)
    {
        string b = Console.ReadLine();
        ushort n = ushort.Parse(Console.ReadLine());
        string[] nums = new string[n];
        string binary = null;
        uint value = 0;
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            value = uint.Parse(Console.ReadLine());
            binary = Convert.ToString(value, 2);
            nums[i] = binary;
        }

        foreach (string x in nums)
        {
            int cnt = Regex.Matches(x, b).Count;
            Console.WriteLine(cnt);
        }
    }
}