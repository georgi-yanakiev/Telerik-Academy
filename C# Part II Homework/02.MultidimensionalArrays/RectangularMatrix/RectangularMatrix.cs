// 02. Write a program that reads a rectangular matrix of size N x M 
// and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

internal class RectangularMatrix
{
    private static void Main(string[] args)
    {
        Console.Title = "Rectangular Matrix";
        Console.Write("Enter the number of rows N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of colums M: ");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int[,] matrix = new int[n, m];
        long maxSum = long.MinValue;
        long sum = 0;
        int maxRow = 0;
        int maxCol = 0;

        for (int rows = 0; rows < n; rows++)
        {
            for (int cols = 0; cols < m; cols++)
            {
                Console.Write("Enter the element on [{0}, {1}]: ", rows, cols);
                matrix[rows, cols] = int.Parse(Console.ReadLine()); // filling the matrix
            }
        }
        Console.WriteLine();

        for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1) - 1; cols++)
            {
                sum = matrix[rows, cols] + matrix[rows, cols + 1] + matrix[rows + 1, cols] + matrix[rows + 1, cols + 1]; // sum the current element and the three around it

                if (maxSum < sum) // keeps the biggest sum and indexes for row and column of the elements
                {
                    maxSum = sum;
                    maxRow = rows;
                    maxCol = cols;
                }
            }
        }

        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                Console.Write(matrix[rows, cols] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("The maximal sum of elements is: {0}", maxSum);
        Console.WriteLine("{0} {1}", matrix[maxRow, maxCol], matrix[maxRow, maxCol + 1]);
        Console.WriteLine("{0} {1}", matrix[maxRow + 1, maxCol], matrix[maxRow + 1, maxCol + 1]);
    }
}