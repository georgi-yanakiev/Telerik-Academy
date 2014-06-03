// 04. Write an expression that checks for given integer 
// if its third digit (right-to-left) is 7. E. g. 1732 --> true.

using System;

class ThirdDigitCheck
{
    static void Main(string[] args)
    {
        Console.Title = "Third Digit Check";
        Console.Write("Enter an integer: ");
        int num = int.Parse(Console.ReadLine());

        // division to 100 in case the third digit is 7 
        // it should be 1st after division i.e. 1735/100 = 17

        int tempNum = num / 100; 

        // if the remainder of division to 10 is 7, then the third digit is 7.
        if (tempNum % 10 == 7)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}