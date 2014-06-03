// 17. Write a program to return the string with maximum length from an array of strings. Use LINQ.

namespace MaximumLenghtString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MaximumLenghtString
    {
        static void Main(string[] args)
        {
            List<string> listOfStrings = new List<string>()
            {
                "Kufar",
                "Chanta",
                "Torta",
                "Televizor",
                "Paralelepiped"
            };

            var longestString = listOfStrings.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur);
            Console.WriteLine(longestString);
        }
    }
}