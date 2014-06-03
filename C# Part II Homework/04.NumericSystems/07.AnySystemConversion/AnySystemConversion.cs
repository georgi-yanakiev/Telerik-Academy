// 07. Write a program to convert from any numeral system of given
// base s to any other numeral system of base d (2 ≤ s, d ≤  16).

using System;
using System.Collections.Generic;

class AnySystemConversion
{
    private static string[] DecimalToCustom(int decNum, int outSystem) // method used to convert from decimal to desired numeral system
    {
        string[] numArr = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" }; // an array with all the hexadecimal symbols
        List<string> strArr = new List<string>();

        int temp = decNum;
        int rem = 0;
        int i = 0;

        do
        {
            rem = temp % outSystem;
            strArr.Add(numArr[rem]); // the remainder of division is the index of numArr array
            temp /= outSystem;
            i++;
        }
        while (temp > 0);

        string[] resArr = strArr.ToArray();
        Array.Reverse(resArr);

        return resArr;
    }

    private static int SourceToDecimal(string sourceNum, int inSystem) // method for conversion of the input number to decimal numeral system
    {
        int decNum = 0;
        for (int i = 0; i < sourceNum.Length; i++)
        {
            int pow = (sourceNum.Length - i - 1);
            decNum += CheckNumber(sourceNum[i], pow, inSystem);
        }
        return decNum;
    }

    private static int CheckNumber(char digit, int pow, int inSystem) // method for conversion of digits to characters
    {
        int convNo = 0;
        int resNo = 0;

        switch (digit)
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
                convNo = Convert.ToInt32(digit - 48);
                break;
        }

        resNo += convNo * (int)Math.Pow(inSystem, pow);
        return resNo;
    }

    static void Main(string[] args)
    {
        Console.Title = "Any System Conversion";
        Console.Write("Enter the base of the input numeral system (S >= 2): ");
        int inSystem = int.Parse(Console.ReadLine());
        Console.Write("Enter the base of the output numeral system (D <= 16): ");
        int outSystem = int.Parse(Console.ReadLine());
        Console.Write("Enter the number: ");
        string sourceNum = Console.ReadLine().ToUpper();

        Console.WriteLine("The result number from base {0} to base {1} is: {2}", inSystem, outSystem, String.Join("", DecimalToCustom(SourceToDecimal(sourceNum, inSystem), outSystem)));

    }
}
