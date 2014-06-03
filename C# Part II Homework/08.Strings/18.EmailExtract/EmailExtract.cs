// 18. Write a program for extracting all email addresses from given text. 
//  All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.
//  Example input: Lorem ipsum dolor sit amet, consectetur - massa-my.na.me@googlemail.com adipiscing elit. Maecenas vestibulum, na.GoshKo-Petkov.Maila@abv.bg lorem eu varius pellentesque, eros erat imperdiet elit, non tincidunt;OshteNqkuv@mail.it mi ante a dui. Aenean dignissim lectus nulla, pulvinar my.na.me@googlemail.com ornare nibh molestie et. Aenean eleifend:myname+123abc@gmail.com vestibulum risus, nec euismod magna. Vestibulum non mi ac myname@pekov.bg mauris imperdiet consequat. Donec metus massa-my.na.me@googlemail.com. 


using System;
using System.Text.RegularExpressions;

class EmailExtract
{
    static void Main()
    {
        Console.Title = "Email Extract";
        string input = "Lorem ipsum dolor sit amet, consectetur - massa-my.na.me@googlemail.com adipiscing elit. Maecenas vestibulum, na.GoshKo-Petkov.Maila@abv.bg lorem eu varius pellentesque, eros erat imperdiet elit, non tincidunt;OshteNqkuv@mail.it mi ante a dui. Aenean dignissim lectus nulla, pulvinar my.na.me@googlemail.com ornare nibh molestie et. Aenean eleifend:myname+123abc@gmail.com vestibulum risus, nec euismod magna. Vestibulum non mi ac myname@pekov.bg mauris imperdiet consequat. Donec metus massa-my.na.me@googlemail.com. ";
        string regex = @"([\w-\.]+)@((?:[\w]+\.)+)([a-zA-Z]{2,4})";
        MatchCollection matches = Regex.Matches(input, regex);
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
        Console.WriteLine();
    }
}
