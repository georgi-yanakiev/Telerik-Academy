// Testing matrix

namespace Matrix
{
    using System;
    class MatrixTest
    {
        static void Main(string[] args)
        {
            Matrix<int> matrixOne = new Matrix<int>(2, 3);
            Matrix<int> matrixTwo = new Matrix<int>(2, 3);

            matrixOne[0, 0] = 1;
            matrixOne[0, 1] = 2;
            matrixOne[0, 2] = 3;
            matrixOne[1, 0] = 4;
            matrixOne[1, 1] = 5;
            matrixOne[1, 2] = 6;


            matrixTwo[0, 0] = 7;
            matrixTwo[0, 1] = 8;
            matrixTwo[0, 2] = 9;
            matrixTwo[1, 0] = 10;
            matrixTwo[1, 1] = 11;
            matrixTwo[1, 2] = 12;



            Matrix<int> matrixSum = new Matrix<int>(matrixOne.Rows, matrixTwo.Cols);
            matrixSum = matrixOne + matrixTwo;
            for (int row = 0; row < matrixSum.Rows; row++)
            {
                for (int col = 0; col < matrixSum.Cols; col++)
                {
                    Console.Write("{0} ", matrixSum[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Matrix<int> matrixSubtract = new Matrix<int>(matrixOne.Rows, matrixTwo.Cols);
            matrixSubtract = matrixOne - matrixTwo;
            for (int row = 0; row < matrixSubtract.Rows; row++)
            {
                for (int col = 0; col < matrixSubtract.Cols; col++)
                {
                    Console.Write("{0} ", matrixSubtract[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
    }
}