// 09. * Write a program that shows the internal binary representation of given 32-bit signed floating-point number in 
// IEEE 754 format (the C# type float). Example: -27,25 -> sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.

using System;
using System.Text;

class FloatToBinary
{
    public static string ConvertToHex(float floatNo)
    {
        byte[] byteArray = BitConverter.GetBytes(floatNo);
        Array.Reverse(byteArray);
        string hexNo = BitConverter.ToString(byteArray);

        return hexNo;
    }

    public static void Main()
    {
        Console.Title = "Float To Binary";
        Console.Write("Enter 32-bit floating point number: ");
        float floatNo = Single.Parse(Console.ReadLine());

        string hexNo = ConvertToHex(floatNo);

        StringBuilder binNo = new StringBuilder();

        for (int i = 0; i < hexNo.Length; i++)
        {
            binNo.Append(HexToBin(hexNo[i])); // invocation of the method with each digit/letter from the hex number
        }

        string binNoStr = binNo.ToString();

        Console.Write("Sign = {0}, ", binNoStr[0]); // sign
        Console.Write("Exponent = {0}, ", binNoStr.Substring(1, 8)); // exponent
        Console.WriteLine("Mantissa = {0}", binNoStr.Substring(9, 23)); // mantissa
    }

    private static string HexToBin(char hex)
    {
        string fourBits = string.Empty;
        switch (hex) // switch case corresponding to the digits in binary
        {
            case '0':
                fourBits = "0000";
                break;
            case '1':
                fourBits = "0001";
                break;
            case '2':
                fourBits = "0010";
                break;
            case '3':
                fourBits = "0011";
                break;
            case '4':
                fourBits = "0100";
                break;
            case '5':
                fourBits = "0101";
                break;
            case '6':
                fourBits = "0110";
                break;
            case '7':
                fourBits = "0111";
                break;
            case '8':
                fourBits = "1000";
                break;
            case '9':
                fourBits = "1001";
                break;
            case 'A':
                fourBits = "1010";
                break;
            case 'B':
                fourBits = "1011";
                break;
            case 'C':
                fourBits = "1100";
                break;
            case 'D':
                fourBits = "1101";
                break;
            case 'E':
                fourBits = "1110";
                break;
            case 'F':
                fourBits = "1111";
                break;
            default:
                fourBits = string.Empty;
                break;
        }
        return fourBits;
    }
}