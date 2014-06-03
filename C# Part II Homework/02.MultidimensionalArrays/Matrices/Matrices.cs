// 01. Write a program that fills and prints a matrix of size (n, n)

using System;

internal class Matrices
{
    private static void Main(string[] args)
    {
        Console.Title = "Matrices";
        Console.Write("Enter the size of the matrix: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        Console.WriteLine("\nSubtask A: ");
        MatrixA(n, matrix);
        PrintMatrix(n, matrix);
        Console.WriteLine("\nSubtask B: ");
        MatrixB(n, matrix);
        PrintMatrix(n, matrix);
        Console.WriteLine("\nSubtask C: ");
        MatrixC(n, matrix);
        PrintMatrix(n, matrix);
    }

    // method for subtask A
    private static void MatrixA(int n, int[,] matrix)
    {
        int values = 1;

        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                matrix[row, col] = values;
                values++;
            }
        }
    }

    // method for subtask B
    private static void MatrixB(int n, int[,] matrix)
    {
        int values = 1;
        bool lastRow = false; // flag for last row reached

        for (int col = 0; col < n; col++)
        {
            if (lastRow == false)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = values;
                    values++;
                }
                lastRow = true; // last row reached, flag is changed 
            }
            else
            {
                for (int row = n - 1; row >= 0; row--) // fill the columns backwards
                {
                    matrix[row, col] = values;
                    values++;
                }
                lastRow = false;
            }
        }
    }

    // method for subtask C
    private static void MatrixC(int n, int[,] matrix)
    {
        int values = 1;

        for (int row = n - 1; row >= 0; row--)
        {
            for (int col = 0; col < n - row; col++)
            {
                matrix[(row + col), col] = values;
                values++;
            }
        }
        for (int col = 1; col < n; col++)
        {
            for (int row = 0; row < n - col; row++)
            {
                matrix[row, (row + col)] = values;
                values++;
            }
        }
    }


    // method for printing the matrix on the console
    private static void PrintMatrix(int n, int[,] matrix)
    {
        for (int rows = 0; rows < n; rows++)
        {
            for (int cols = 0; cols < n; cols++)
            {
                Console.Write(matrix[rows, cols] + "    ");
            }
            Console.WriteLine();
        }
    }
}