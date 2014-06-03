// 05. Write a program that reads a text file containing a square matrix of numbers 
// finds in the matrix an area of size 2 x 2 with a maximal sum of its elements. 
// The first line in the input file contains the size of matrix N. Each of the next N lines 
// contain N numbers separated by space. The output should be a single number in a separate text file.

using System;
using System.IO;

class TextFileMatrix
{
    static void Main(string[] args)
    {
        Console.Title = "Text File Matrix";

        try
        {
            StreamReader inputFile = new StreamReader(@"..\..\Matrix.txt");
            StreamWriter resultFile = new StreamWriter(@"..\..\ResultFile.txt"); // file is located in the project folder

            using (resultFile)
            {
                using (inputFile)
                {
                    int firstLine = int.Parse(inputFile.ReadLine());
                    string temp = string.Empty;
                    string[] stringNums = new string[firstLine];
                    int[,] matrix = new int[firstLine, firstLine];

                    long maxSum = long.MinValue;
                    long sum = 0;

                    for (int lineNumber = 0; lineNumber < firstLine; lineNumber++)
                    {
                        stringNums[lineNumber] = inputFile.ReadLine();
                    }

                    for (int i = 0; i < firstLine; i++)
                    {
                        for (int j = 0; j < firstLine; j++)
                        {
                            matrix[i, j] = Convert.ToInt32(stringNums[i][j] - 48);
                        }
                    }


                    for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
                    {
                        for (int cols = 0; cols < matrix.GetLength(1) - 1; cols++)
                        {
                            sum = matrix[rows, cols] + matrix[rows, cols + 1] + matrix[rows + 1, cols] + matrix[rows + 1, cols + 1]; // sum the current element and the three around it

                            if (maxSum < sum) // keeps the biggest sum and indexes for row and column of the elements
                            {
                                maxSum = sum;
                            }
                        }
                    }

                    Console.WriteLine("Finding the greatest 2x2 sum in the matrix...\n");

                    for (int rows = 0; rows < matrix.GetLength(0); rows++)
                    {
                        for (int cols = 0; cols < matrix.GetLength(1); cols++)
                        {
                            Console.Write(matrix[rows, cols] + " ");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine();

                    resultFile.WriteLine(maxSum);
                    Console.WriteLine("Check the file in the project directory.\n");
                }
            }
        }
        catch (System.IO.FileNotFoundException ex)
        {
            Console.WriteLine("File {0} is not found!", ex.FileName);
        }
    }
}