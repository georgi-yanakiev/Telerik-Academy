// Tasks 8,9,10

namespace Matrix
{
    using System;

    public class Matrix<T>
    {
        private int rows;
        private int cols;
        private readonly T[,] matrix;
        public Matrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.matrix = new T[rows, cols];
        }

        public T this[int row, int col] // indexer
        {
            get
            {
                if (row <= this.rows && col <= this.cols)
                {
                    return matrix[row, col];
                }
                else
                {
                    throw new IndexOutOfRangeException("The row or column is out of range!");
                }
            }
            set
            {
                if (row <= this.rows && col <= this.cols)
                {
                    this.matrix[row, col] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("The row or column is out of range!");
                }
            }
        }

        public int Rows // rows property
        {
            get { return this.rows; }
            set
            {
                if (value > 0 && value <= int.MaxValue)
                {
                    this.rows = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public int Cols // columns property
        {
            get { return this.cols; }
            set
            {
                if (value > 0 && value <= int.MaxValue)
                {
                    this.cols = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        // operator for Addition
        public static Matrix<T> operator +(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            Matrix<T> matrixSum = new Matrix<T>(matrixOne.rows, matrixOne.cols);

            if (matrixOne.cols == matrixTwo.cols && matrixOne.rows == matrixTwo.rows)
            {
                for (int i = 0; i < matrixOne.rows; i++)
                {
                    for (int j = 0; j < matrixOne.cols; j++)
                    {
                        matrixSum[i, j] = (dynamic)matrixOne[i, j] + (dynamic)matrixTwo[i, j];
                    }
                }
            }
            else
            {
                throw new ArgumentException("Operation cannot be performed");
            }
            return matrixSum;
        }

        // operator for Subtraction
        public static Matrix<T> operator -(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            Matrix<T> matrixSubtract = new Matrix<T>(matrixOne.rows, matrixOne.cols);

            if (matrixOne.cols == matrixTwo.cols && matrixOne.rows == matrixTwo.rows)
            {
                for (int i = 0; i < matrixOne.rows; i++)
                {
                    for (int j = 0; j < matrixOne.cols; j++)
                    {
                        matrixSubtract[i, j] = (dynamic)matrixOne[i, j] - (dynamic)matrixTwo[i, j];
                    }
                }
            }
            else
            {
                throw new ArgumentException("Operation cannot be performed");
            }
            return matrixSubtract;
        }

        // operator for Product
        public static Matrix<T> operator *(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            Matrix<T> matrixProduct = new Matrix<T>(matrixOne.rows, matrixTwo.cols);

            if (matrixOne.cols == matrixTwo.cols && matrixOne.rows == matrixTwo.rows)
            {
                for (int i = 0; i < matrixOne.rows; i++)
                {
                    for (int j = 0; j < matrixTwo.cols; j++)
                    {
                        dynamic product = 0;
                        for (int k = 0; k < matrixTwo.cols + 1; k++)
                        {
                            product += (dynamic)matrixOne[i, k] * (dynamic)matrixTwo[k, j];
                        }
                        matrixProduct.matrix[i, j] = product;
                    }
                }
            }
            else
            {
                throw new ArgumentException("Operation cannot be performed");
            }
            return matrixProduct;
        }
    }
}