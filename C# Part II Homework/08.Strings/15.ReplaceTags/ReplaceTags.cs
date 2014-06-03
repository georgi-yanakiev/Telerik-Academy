﻿// 15. Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL]. Sample HTML fragment:
//  Example input: <p>Please visit <a href="http://academy.telerik.com"> our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
//  Example output: p>Please visit [URL=http://academy.telerik.com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>

using System;
using System.Text.RegularExpressions;

class ReplaceTags
{
    static void Main()
    {
        Console.Title = "ReplaceTags";
        string text = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
        string result = Regex.Replace(text, @"<\s*a\s*href\s*=\s*\""\s*(.+?)\"">(.+?)</a>", "[URL=$1]$2[/URL]");
        Console.WriteLine(result);
    }
}
