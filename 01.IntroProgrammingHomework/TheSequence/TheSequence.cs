// Exercise 9: 
// Write a program that prints the first 
// 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;

class TheSequence
{
    static void Main()
    {
        Console.Title = "Sequence";
        int seq;
        Console.Write("The first 10 members of the sequence are : ");

        // using a for loop construction to display values from 2 to 11, 
        // defining the 10 elements of the sequence

        for (int i = 2; i <= 11; i++)
        {
            //  check for odd or even number.
            // the odd ones are positive, the even negative

            if (i % 2 != 0)
            {
                seq = -i;
            }
            else
            {
                seq = i;
            }

            // if condition used to display commas between the numbers
            // except the last one
            if (i != 11)
            {
                Console.Write(seq + ", ");
            }
            else
            {
                Console.Write(seq);
            }
        }
        Console.WriteLine();
    }
}