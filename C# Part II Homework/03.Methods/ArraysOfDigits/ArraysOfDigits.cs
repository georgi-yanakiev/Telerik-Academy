// 08. Write a method that adds two positive integer numbers represented as arrays of digits 
// (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
// Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Numerics;

class ArraysOfDigits
{
    static int[] ArrayDigitsSum(int[] arrayOne, int[] arrayTwo, int length)
    {

        Array.Reverse(arrayOne); // reversing the arrays
        Array.Reverse(arrayTwo);

        int[] sumArray = new int[length + 1]; // the result array has one more element because of the additional number 

        int minder = 0;
        int i;

        for (i = 0; i < length; i++)
        {
            sumArray[i] = (arrayOne[i] + arrayTwo[i] + minder); // filling the new array with the sum

            minder = sumArray[i] / 10; // if the sum is bigger than 10 the minder is 1
            sumArray[i] %= 10; // if it bigger than 10 the remainder is populated
        }

        if (minder == 1) // if the last sum is bigger than 10
        {
            sumArray[i] = 1;
        }

        return sumArray;
    }

    static void Main(string[] args)
    {
        Console.Title = "Arrays Of Digits";
        Console.Write("Enter the first positive number:  ");
        BigInteger numOne = BigInteger.Parse(Console.ReadLine());
        Console.Write("Enter the second positive number: ");
        BigInteger numTwo = BigInteger.Parse(Console.ReadLine());

        int numOneLen = numOne.ToString().Length; // get the length in digits of the first number
        int numTwoLen = numTwo.ToString().Length; // get the length in digits of the second number

        int arrLen = Math.Max(numOneLen, numTwoLen); // arrLen keeps the length of the biggest number

        int[] arrOne = new int[arrLen]; // initially the arrays elements are zeroes
        int[] arrTwo = new int[arrLen];

        int lenDiff = Math.Abs((numOneLen - numTwoLen)); // the difference between the lengths


        if (numOneLen > numTwoLen)
        {
            for (int i = 0; i < arrLen; i++)
            {
                arrOne[i] = (numOne.ToString()[i] - 48);
            }

            // the array of the shorter in length number is filled from the position of 
            // the length difference ex: (if a = 10341; b = 356)  b is presented as 00356 in the array
            // so the arrays to be equal in length
            for (int j = lenDiff; j < arrLen; j++)
            {
                arrTwo[j] = (numTwo.ToString()[j - lenDiff] - 48);
            }

        }
        else if (numOneLen < numTwoLen)
        {
            for (int i = lenDiff; i < arrLen; i++)
            {
                arrOne[i] = (numOne.ToString()[i - lenDiff] - 48);
            }

            for (int j = 0; j < arrLen; j++)
            {
                arrTwo[j] = (numTwo.ToString()[j] - 48);
            }
        }
        else
        {
            for (int i = 0; i < arrLen; i++)
            {
                arrOne[i] = (numOne.ToString()[i] - 48);
            }

            for (int j = 0; j < arrLen; j++)
            {
                arrTwo[j] = (numTwo.ToString()[j] - 48);
            }
        }

        int[] sumArr = ArrayDigitsSum(arrOne, arrTwo, arrLen); // invocation of the method with the two arrays and the length as parameters

        Array.Reverse(sumArr);

        string resNum = string.Join("", sumArr);
        Console.WriteLine("\nThe sum of the numbers is: {0} \n", resNum.TrimStart('0'));
    }
}
