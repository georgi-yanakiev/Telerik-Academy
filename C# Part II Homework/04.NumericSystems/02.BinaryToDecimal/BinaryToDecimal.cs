// 02. Write a program to convert binary numbers to their decimal representation.

using System;

class BinaryToDecimal
{
    private static object BinToDec(string binNum) // method for conversion of binary to decimal
    {
        int decNum = 0;
        int convNo = 0;

        for (int i = 0; i < binNum.Length; i++) // logic for conversion
        {
            int pow = (binNum.Length - i - 1);
            convNo = Convert.ToInt32(binNum[i] - 48);
            decNum += convNo * (int)Math.Pow(2, pow);
        }
        return decNum;
    }
    static void Main(string[] args)
    {
        Console.Title = "Binary To Decimal";
        Console.Write("Enter a binary number: ");
        string binNum = Console.ReadLine();

        Console.WriteLine("The number {0} in decimal representation is: {1}", binNum, BinToDec(binNum));
    }
}
