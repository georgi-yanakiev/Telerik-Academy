// 03. We are given a matrix of strings of size N x M. Sequences in the matrix 
// we define as sets of several neighbor elements located on the same line, 
// column or diagonal. Write a program that finds the longest sequence of 
// equal strings in the matrix. 

using System;

internal class MatrixSequences
{
    private static void Main()
    {
        Console.Title = "Matrix Sequences";
        Console.Write("Enter the number of rows N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of colums M: ");
        int m = int.Parse(Console.ReadLine());
        int strLen = 1;
        Console.WriteLine();
        string[,] matrix = new string[n, m];

        for (int rows = 0; rows < n; rows++)
        {
            for (int cols = 0; cols < m; cols++)
            {
                Console.Write("Enter the element on [{0}, {1}]: ", rows, cols);
                matrix[rows, cols] = Console.ReadLine();
                if (matrix[rows, cols].Length > strLen)
                {
                    strLen = matrix[rows, cols].Length; // used for matrix formatting
                }
            }
        }
        Console.WriteLine();

        // visualization of the matrix
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                Console.Write(matrix[rows, cols].PadRight(strLen + 2, ' '));
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        int highCount = 0; // counter for string appearances
        string resString = ""; // the string with highest number of appearances

        Rows(matrix, out highCount, out resString); // method for searching through the rows of matrix
        Columns(matrix, ref highCount, ref resString); // method for searching through the columns of matrix
        DownRight(matrix, ref highCount, ref resString); // method for searching through the diagonal down right of matrix
        DownLeft(matrix, ref highCount, ref resString); //  method for searching through the diagonal down left of matrix

        Console.Write("The longest sequence of equal strings is: ");

        Console.Write("(");
        for (int i = 1; i <= highCount; i++)
        {
            Console.Write(resString + ", ");
        }
        Console.WriteLine("\b\b}\n");


        //check diagonals up-right
    }

    private static void Rows(string[,] matrix, out int highCount, out string resString)
    {
        //check Rows
        int count = 1;
        highCount = 1;
        resString = "";
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                for (int i = col; i < matrix.GetLength(1) - 1; i++)
                {
                    if (matrix[row, i] == matrix[row, i + 1])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (count > highCount)
                {
                    highCount = count;
                    resString = matrix[row, col];
                }
                count = 1;
            }
        }
    }

    private static void Columns(string[,] matrix, ref int highCount, ref string resString)
    {
        //check columns
        int count = 1;
        ;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int i = row; i < matrix.GetLength(0) - 1; i++)
                {
                    if (matrix[i, col] == matrix[i + 1, col])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (count > highCount)
                {
                    highCount = count;
                    resString = matrix[row, col];
                }
                count = 1;
            }
        }
    }

    private static void DownRight(string[,] matrix, ref int highCount, ref string resString)
    {
        //check diagonals down-right
        int count = 1;
        for (int rows = 0; rows < matrix.GetLength(0) - 2; rows++) //moves diagonal to left and down
        {
            for (int row = rows, col = 0; row < matrix.GetLength(0) - 1; row++, col++)
            {
                if ((row == matrix.GetLength(0) - 1) || (col == matrix.GetLength(1) - 1)) break;
                if (matrix[row, col] == matrix[row + 1, col + 1])
                {
                    count++;
                    if (count > highCount)
                    {
                        highCount = count;
                        resString = matrix[row, col];
                    }
                }
                else count = 1;
            }
            count = 1;
        }
        for (int cols = 1; cols < matrix.GetLength(0) - 2; cols++) //moves diagonal to right
        {
            for (int row = 0, col = cols; row < matrix.GetLength(0) - 1; row++, col++)
            {
                if ((row == matrix.GetLength(0) - 1) || (col == matrix.GetLength(1) - 1)) break;
                if (matrix[row, col] == matrix[row + 1, col + 1])
                {
                    count++;
                    if (count > highCount)
                    {
                        highCount = count;
                        resString = matrix[row, col];
                    }
                }
                else count = 1;
            }
            count = 1;
        }
    }

    private static void DownLeft(string[,] matrix, ref int highCount, ref string resString)
    {
        //check diagonals down-left
        int count = 1;
        for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++) //moves diagonal to left and down
        {
            for (int row = rows, col = matrix.GetLength(1) - 1; row < matrix.GetLength(0) - 1; row++, col--)
            {
                if ((row == matrix.GetLength(0) - 1) || (col == 0)) break;
                if (matrix[row, col] == matrix[row + 1, col - 1])
                {
                    count++;
                    if (count > highCount)
                    {
                        highCount = count;
                        resString = matrix[row, col];
                    }
                }
                else count = 1;
            }
            count = 1;
        }
        for (int cols = matrix.GetLength(1) - 2; cols >= 1; cols--) //moves diagonal to right
        {
            for (int row = 0, col = cols; row < matrix.GetLength(0) - 1; row++, col--)
            {
                if ((row == matrix.GetLength(0) - 1) || (col == 0)) break;
                if (matrix[row, col] == matrix[row + 1, col - 1])
                {
                    count++;
                    if (count > highCount)
                    {
                        highCount = count;
                        resString = matrix[row, col];
                    }
                }
                else count = 1;
            }
            count = 1;
        }
    }
}