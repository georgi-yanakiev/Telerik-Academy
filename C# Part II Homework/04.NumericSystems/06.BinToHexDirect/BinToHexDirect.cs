// 06.Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;
using System.Text;

class BinToHexDirect
{
    private static string BinToHex(string binaryDigit)
    {
        string hexDigit = string.Empty;

        switch (binaryDigit)
        {
            case "0000":
                hexDigit = "0";
                break;
            case "0001":
                hexDigit = "1";
                break;
            case "0010":
                hexDigit = "2";
                break;
            case "0011":
                hexDigit = "3";
                break;
            case "0100":
                hexDigit = "4";
                break;
            case "0101":
                hexDigit = "5";
                break;
            case "0110":
                hexDigit = "6";
                break;
            case "0111":
                hexDigit = "7";
                break;
            case "1000":
                hexDigit = "8";
                break;
            case "1001":
                hexDigit = "9";
                break;
            case "1010":
                hexDigit = "A";
                break;
            case "1011":
                hexDigit = "B";
                break;
            case "1100":
                hexDigit = "C";
                break;
            case "1101":
                hexDigit = "D";
                break;
            case "1110":
                hexDigit = "E";
                break;
            case "1111":
                hexDigit = "F";
                break;
            default:
                Console.WriteLine("Wrong character");
                break;
        }
        return hexDigit;
    }
    static void Main(string[] args)
    {
        Console.Title = "Bin To Hex Direct";
        Console.Write("Enter a binary number: ");
        string binaryNo = Console.ReadLine();
        string tempNo = binaryNo;
        StringBuilder hexNum = new StringBuilder();

        while (binaryNo.Length % 4 != 0)
        {
            binaryNo = "0" + binaryNo; // fills the string with zeroes to be presented as 4 digits blocks
        }

        for (int i = 0; i < binaryNo.Length; i += 4)
        {
            hexNum.Append(BinToHex(binaryNo.Substring(i, 4))); // spit in block of 4 binary digits and invokes the method which returns the hexadecimal value
        }

        Console.WriteLine("The number {0} in decimal representation is: {1}", tempNo, hexNum);
    }
}