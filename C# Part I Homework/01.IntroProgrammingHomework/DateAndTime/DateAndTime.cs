// Exercise 7: 
// Create a console application 
// that prints the current date and time.

using System;

class DateAndTime
{
    static void Main()
    {
        Console.Title = "Date And Time";

        // Using DateTime.Now property which gets the date and time for the current moment
        DateTime dateAndTime = DateTime.Now;
        Console.WriteLine("Exact date and time {0}.", dateAndTime);
    }
}