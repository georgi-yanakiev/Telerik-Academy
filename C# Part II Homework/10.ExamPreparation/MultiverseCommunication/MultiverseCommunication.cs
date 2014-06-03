using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MultiverseCommunication
{
    static void Main(string[] args)
    {
        string textInput = Console.ReadLine();
        string[] wordArr = new string[textInput.Length];
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < wordArr.Length; i += 3)
        {
            wordArr[i] = textInput.Substring(i, 3);
        }

        foreach (var x in wordArr)
        {
            sb.Append(ConvertToNumber(x));
        }

        long decimalNo = SourceToDecimal(sb.ToString());
        Console.WriteLine(decimalNo);
    }

    private static string ConvertToNumber(string x)
    {
        string num = string.Empty;
        switch (x)
        {
            case "CHU":
                num = "0";
                break;
            case "TEL":
                num = "1";
                break;
            case "OFT":
                num = "2";
                break;
            case "IVA":
                num = "3";
                break;
            case "EMY":
                num = "4";
                break;
            case "VNB":
                num = "5";
                break;
            case "POQ":
                num = "6";
                break;
            case "ERI":
                num = "7";
                break;
            case "CAD":
                num = "8";
                break;
            case "K-A":
                num = "9";
                break;
            case "IIA":
                num = "A";
                break;
            case "YLO":
                num = "B";
                break;
            case "PLA":
                num = "C";
                break;
        }
        return num;
    }

    private static long SourceToDecimal(string sourceNum) // method for conversion of the input number to decimal numeral system
    {
        long decNum = 0;
        int inSystem = 13;
        for (int i = 0; i < sourceNum.Length; i++)
        {
            long pow = (sourceNum.Length - i - 1);
            decNum += CheckNumber(sourceNum[i], pow, inSystem);
        }
        return decNum;
    }

    private static long CheckNumber(char digit, long pow, int inSystem) // method for conversion of digits to characters
    {
        long convNo = 0;
        long resNo = 0;

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
            default:
                convNo = Convert.ToInt32(digit - 48);
                break;
        }

        resNo += convNo * (int)Math.Pow(inSystem, pow);
        return resNo;
    }
}