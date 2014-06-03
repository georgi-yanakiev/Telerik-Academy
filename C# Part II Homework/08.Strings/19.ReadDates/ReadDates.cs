//19. Write a program that extracts from a given text all dates that match
//the format DD.MM.YYYY. Display them in the standard date format for Canada.

using System;
using System.Text.RegularExpressions;

class ReadDates
{
    static void Main()
    {
        Console.Title = "ReadDates";
        // Important: monts should be with 2 symbols
        string input = "Lorem ipsum dolor sit amet, 10-12-1990 or 26/19/1990 or:26//10//1990 or 10//26/1990 adipiscing elit. Praesent18/05/2001, at commodo:2014.25.08 purus velit:09.25.2014 . Integer-05.6.2010 lacus 5.05.2013 magna 5.5.2012 sit amet, tempus 27.12.2013 or 12.27.2013 id lacus";
        string regex = @"([0-9]{1,})(\.|\-|\/{1,})(01|02|03|04|05|06|07|08|09|10|11|12{1})(\.|\-|\/{1,})([0-9]{1,4})";
        MatchCollection matches = Regex.Matches(input, regex);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
        Console.WriteLine();
    }
}
