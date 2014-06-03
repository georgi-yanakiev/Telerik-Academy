// 12. Write a program that reads from the console a
//  positive integer number N (N < 20) and outputs a matrix

using System;

class Matrices
{
    static void Main()
    {
        Console.Write("Enter a size of the matrix (must be > 0 and < 20): ");
        byte size = byte.Parse(Console.ReadLine());
        int n = 1;

        for (int i = 0; i < size; i++)
        {
            n = i + 1;
            for (int j = 0; j < size; j++)
            {
                Console.Write("  {0}  ", n);
                n++;
            }
            Console.WriteLine(); // breaks each row
        }
    }
}
