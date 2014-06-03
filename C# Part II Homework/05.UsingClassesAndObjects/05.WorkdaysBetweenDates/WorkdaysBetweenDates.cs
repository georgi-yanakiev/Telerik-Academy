// 05. Write a method that calculates the number of workdays between today and given date, passed as parameter. 
// Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;
using System.Collections.Generic;

class WorkdaysBetweenDates
{
    static void Main(string[] args)
    {
        Console.Title = "Workdays Between Dates";
        Console.Write("Enter the start date (YYYY-MM-DD): ");
        DateTime startDate = DateTime.Parse(Console.ReadLine());
        DateTime currDate = DateTime.Today;

        List<DateTime> holidays = new List<DateTime>();

        holidays.Add(new DateTime(2014, 03, 03));
        holidays.Add(new DateTime(2014, 04, 18));
        holidays.Add(new DateTime(2014, 05, 01));
        holidays.Add(new DateTime(2014, 05, 02));
        holidays.Add(new DateTime(2014, 05, 05));
        holidays.Add(new DateTime(2014, 05, 06));
        holidays.Add(new DateTime(2014, 09, 22));
        holidays.Add(new DateTime(2014, 12, 24));
        holidays.Add(new DateTime(2014, 12, 25));
        holidays.Add(new DateTime(2014, 12, 26));
        holidays.Add(new DateTime(2014, 12, 31));


        int workdaysCounter = 0;

        for (DateTime date = currDate; date.Date <= startDate.Date; date = date.AddDays(1))
        {
            if ((date.DayOfWeek != DayOfWeek.Saturday) && (date.DayOfWeek != DayOfWeek.Sunday))
            {
                if (holidays.Contains(date))
                {
                    continue;
                }

                workdaysCounter++;
            }
        }
        Console.WriteLine(workdaysCounter);
    }
}
