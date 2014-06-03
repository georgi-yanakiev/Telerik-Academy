// 17. Write a program that reads a date and time given in the 
//  format: day.month.year hour:minute:second and prints the 
//  date and time after 6 hours and 30 minutes (in the same format)
//  along with the day of week in Bulgarian.

using System;

class TimeInSixHours
{
    static void Main()
    {
        Console.Title = "TimeInSixHours";
        Console.WriteLine("Please enter date and time in format as in the example"); // Example "27.3.2014 16:32:15"
        string input = Console.ReadLine();

        // Date
        DateTime inputDate = new DateTime();

        DateTime.TryParse(input, System.Globalization.CultureInfo.CreateSpecificCulture("en-GB"),
            System.Globalization.DateTimeStyles.None, out inputDate);
        DateTime after6 = inputDate.AddHours(6.30);

        Console.WriteLine("6:30 hours after your input will be: {0:dd.MM.yyyy hh:MM:ss}", after6);
    }
}
