// 03. Write a program to convert decimal numbers to their hexadecimal representation.

using System;

class DecimalToHexadecimal
{
    private static string[] DecToHex(int decNum)
    {
        string[] numArr = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" }; // an array with all the hexadecimal symbols
        string[] strArr = new string[(decNum.ToString()).Length];

        int temp = decNum;
        int rem = 0;
        int i = 0;

        do
        {
            rem = temp % 16;
            strArr[i] = (numArr[rem]); // the remainder of division is the index of numArr array
            temp /= 16;
            i++;
        }
        while (temp > 0);

        Array.Reverse(strArr);

        return strArr;
    }

    static void Main(string[] args)
    {
        Console.Title = "Decimal To Hexadecimal";
        Console.Write("Enter a decimal number: ");
        int decNum = int.Parse(Console.ReadLine());

        Console.WriteLine("The number {0} in hexadecimal representation is: {1}", decNum, string.Join("", DecToHex(decNum)));
    }
}