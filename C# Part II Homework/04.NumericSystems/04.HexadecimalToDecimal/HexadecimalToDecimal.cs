// 04. Write a program to convert hexadecimal numbers to their decimal representation.

using System;

class HexadecimalToDecimal
{
    private static int HexToDec(string hexNum)
    {
        int decNum = 0;
        for (int i = 0; i < hexNum.Length; i++)
        {
            int pow = (hexNum.Length - i - 1);
            decNum += CheckNumber(hexNum[i], pow);
        }
        return decNum;
    }

    private static int CheckNumber(char digit, int pow)
    {
        int convNo = 0;
        int resNo = 0;

        switch (digit) // switch case for hexadecimal representation of numbers (10-15)
        {
            case 'A':
                convNo = 10;
                break;
            case 'B':
                convNo = 11;
                break;
            case 'C':
                convNo = 12;
                break;
            case 'D':
                convNo = 13;
                break;
            case 'E':
                convNo = 14;
                break;
            case 'F':
                convNo = 15;
                break;
            default:
                convNo = Convert.ToInt32(digit - 48); // the digits from 1 to 9
                break;
        }

        resNo += convNo * (int)Math.Pow(16, pow);
        return resNo;
    }

    static void Main(string[] args)
    {
        Console.Title = "Hexadecimal To Decimal";
        Console.Write("Enter a hexadecimal number: ");
        string hexNum = Console.ReadLine().ToUpper();

        Console.WriteLine("The number {0} in decimal representation is: {1}", hexNum, HexToDec(hexNum));
    }
}