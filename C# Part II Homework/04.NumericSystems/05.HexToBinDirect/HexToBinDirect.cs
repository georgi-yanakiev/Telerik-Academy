// 05. Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;
using System.Text;

class HexToBinDirect
{

    private static string HexToBin(char hex)
    {
        string bin = string.Empty;
        switch (hex) // switch case corresponding to the digits in binary
        {
            case '0':
                bin = "0000";
                break;
            case '1':
                bin = "0001";
                break;
            case '2':
                bin = "0010";
                break;
            case '3':
                bin = "0011";
                break;
            case '4':
                bin = "0100";
                break;
            case '5':
                bin = "0101";
                break;
            case '6':
                bin = "0110";
                break;
            case '7':
                bin = "0111";
                break;
            case '8':
                bin = "1000";
                break;
            case '9':
                bin = "1001";
                break;
            case 'A':
                bin = "1010";
                break;
            case 'B':
                bin = "1011";
                break;
            case 'C':
                bin = "1100";
                break;
            case 'D':
                bin = "1101";
                break;
            case 'E':
                bin = "1110";
                break;
            case 'F':
                bin = "1111";
                break;
            default:
                bin = string.Empty;
                break;
        }
        return bin;
    }

    static void Main(string[] args)
    {
        Console.Title = "Hex To Bin Direct";
        Console.Write("Enter a hexadecimal number: ");
        string hexNo = Console.ReadLine().ToUpper();
        StringBuilder binNo = new StringBuilder();

        for (int i = 0; i < hexNo.Length; i++)
        {
            binNo.Append(HexToBin(hexNo[i])); // invocation of the method with each digit/letter from the hex number
        }
        Console.WriteLine("The number {0} in binary numeral system is {1}", hexNo, (binNo.ToString()).TrimStart('0')); // printing the number removing leading zeroes
    }
}
