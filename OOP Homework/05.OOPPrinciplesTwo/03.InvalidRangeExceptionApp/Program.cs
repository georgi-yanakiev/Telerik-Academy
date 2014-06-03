// 03. Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range.
// It should hold error message and a range definition [start … end]. Write a sample application that demonstrates the 
// InvalidRangeException<int> and InvalidRangeException<DateTime> by entering numbers in the range [1..100] and 
// dates in the range [1.1.1980 … 31.12.2013].

namespace InvalidRangeExceptionApp
{
    using System;

    class Program
    {
        public static void Main()
        {
            // testing with numbers
            try
            {
                int start = 1;
                int end = 100;

                int number = 236;

                if (!(start < number && number < end))
                {
                    throw new InvalidRangeException<int>(start, end);
                }
                else
                {
                    Console.WriteLine("The number {0} is in range [1- 100]", number);
                }
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Range is {0} - {1};", ex.Start, ex.End);
                Console.WriteLine();
            }

          
            // testing with dates
            try
            {
                DateTime start = new DateTime(1980, 1, 1);
                DateTime end = new DateTime(2013, 12, 31);

                DateTime date =  new DateTime(1979, 1, 1);

                if (!(start < date && date < end))
                {
                    throw new InvalidRangeException<DateTime>(start, end);
                }
                else
                {
                    Console.WriteLine("The date {0} is in range", date);
                }
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Range is {0} - {1};", ex.Start, ex.End);
                Console.WriteLine();
            }
        }
    }
}