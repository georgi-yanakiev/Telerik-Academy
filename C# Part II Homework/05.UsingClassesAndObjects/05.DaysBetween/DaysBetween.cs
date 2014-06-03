using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class DaysBetween
{
    static void Main(string[] args)
    {
        Console.Title = "Days Between";
        DateTime dtToday = DateTime.Today;
        DateTime periodDate = DateTime.Parse(Console.ReadLine());

        var holidays = new List<DateTime>();

        holidays.Add(new DateTime(2013, 01, 30));
        holidays.Add(new DateTime(2013, 01, 31));
        holidays.Add(new DateTime(2013, 02, 05));
        holidays.Add(new DateTime(2013, 02, 07));

        CheckDaysBetween(dtToday, periodDate, holidays);


    }

    private static void CheckDaysBetween(DateTime dtToday, DateTime periodDate, List<DateTime> holidays)
    {
        DaysBetween();
    }
}

// http://www.c-sharpcorner.com/uploadfile/dbd951/calculate-the-working-days-between-two-given-days-in-C-Sharp/