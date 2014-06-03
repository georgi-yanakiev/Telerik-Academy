// 03. Write a program that prints to the console which day of the week is today. Use System.DateTime.

using System;

class WhatDayIsToday
{
    static void Main(string[] args)
    {
        Console.Title = "What Day Is Today";

        Console.WriteLine("Today is {0}.", DateTime.Now.DayOfWeek); // prints what day of the week is at this moment
    }
}