// 02. Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
// If an invalid number or non-number text is entered, the method should throw an exception. 
// Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;

class ReadNumbersInRange
{
    private static int ReadNumber(int start, int end)
    {
        int num = int.Parse(Console.ReadLine());

        if (!(start < num && num < end)) // checks the number is it in range
        {
            throw new ArgumentOutOfRangeException();
        }
        return num;
    }
    static void Main(string[] args)
    {
        Console.Title = "Read Numbers In Range";
        int start = 1;
        int end = 100;

        try
        {
            for (int i = 1; i <= 10; i++) // 10 numbers loop
            {
                Console.Write("Enter an integer between {0} and {1}: ", start, end);
                start = ReadNumber(start, end); // each time the method returns the new start point
            }
        }
        catch (ArgumentOutOfRangeException) // if its out of start - end range
        {
            Console.WriteLine("Your number is out of range {0} - {1}", start, end);
        }
        catch (FormatException) // if no value is entered
        {
            Console.WriteLine("Number cannot be null");
        }
        catch (OverflowException) // if the number is too big or small (integer)
        {
            Console.WriteLine("Your number is out of capacity of integer!");
        }
    }
}
