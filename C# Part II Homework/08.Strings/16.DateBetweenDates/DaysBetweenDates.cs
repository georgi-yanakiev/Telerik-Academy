// 16. Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. 
// Example: Enter the first date: 27.02.2006
//  Enter the second date: 3.03.2004
//  Distance: 4 days

using System;

class DaysBetweenDates
{
    static void Main()
    {
        Console.Title = "Days Between Dates";

        Console.Write("Input start date: "); // format day.month.year
        string firstDate = Console.ReadLine();
        Console.Write("Input end date: ");
        string secondDate = Console.ReadLine();

        DateTime startDate = new DateTime();
        DateTime.TryParse(firstDate, System.Globalization.CultureInfo.CreateSpecificCulture("en-GB"), System.Globalization.DateTimeStyles.None, out startDate);

        DateTime endDate = new DateTime();
        DateTime.TryParse(secondDate, System.Globalization.CultureInfo.CreateSpecificCulture("en-GB"), System.Globalization.DateTimeStyles.None, out endDate);

        if (startDate < endDate)
        {
            TimeSpan diff = endDate - startDate;
            Console.WriteLine("Days between the two dates: {0}", diff.Days);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("The second date is before the first date");
        }
    }
}
