using System;
using System.Collections.Generic;
using System.Text;

class DecodeAndDecrypt
{
    private static string Decrypt(string encodedMsg, string cypher)
    {
        StringBuilder decryptedMessage = new StringBuilder();

        if (encodedMsg.Length >= cypher.Length)
        {
            for (int i = 0; i < encodedMsg.Length; i++)
            {
                decryptedMessage.Append(GetValue((Convert.ToInt32(encodedMsg[i]) - 65) ^ (Convert.ToInt32(cypher[i % cypher.Length]) - 65)));
            }
            return decryptedMessage.ToString();
        }
        else
        {
            int diff = cypher.Length - encodedMsg.Length;
            int temp = 0;

            for (int i = 0; i < encodedMsg.Length; i++)
            {
                if (i < diff)
                {
                    temp = (Convert.ToInt32(encodedMsg[i]) - 65) ^ (Convert.ToInt32(cypher[i] - 65)) ^ (Convert.ToInt32(cypher[i + encodedMsg.Length] - 65));
                    decryptedMessage.Append(GetValue(temp));
                }
                else
                {
                    decryptedMessage.Append(GetValue((Convert.ToInt32(encodedMsg[i]) - 65) ^ (Convert.ToInt32(cypher[i] - 65))));
                }
            }

            return decryptedMessage.ToString();
        }
    }

    private static string GetValue(int toInt32)
    {
        string letter = string.Empty;

        switch (toInt32)
        {
            case 0:
                letter = "A";
                break;
            case 1:
                letter = "B";
                break;
            case 2:
                letter = "C";
                break;
            case 3:
                letter = "D";
                break;
            case 4:
                letter = "E";
                break;
            case 5:
                letter = "F";
                break;
            case 6:
                letter = "G";
                break;
            case 7:
                letter = "H";
                break;
            case 8:
                letter = "I";
                break;
            case 9:
                letter = "J";
                break;
            case 10:
                letter = "K";
                break;
            case 11:
                letter = "L";
                break;
            case 12:
                letter = "M";
                break;
            case 13:
                letter = "N";
                break;
            case 14:
                letter = "O";
                break;
            case 15:
                letter = "P";
                break;
            case 16:
                letter = "Q";
                break;
            case 17:
                letter = "R";
                break;
            case 18:
                letter = "S";
                break;
            case 19:
                letter = "T";
                break;
            case 20:
                letter = "U";
                break;
            case 21:
                letter = "V";
                break;
            case 22:
                letter = "W";
                break;
            case 23:
                letter = "X";
                break;
            case 24:
                letter = "Y";
                break;
            case 25:
                letter = "Z";
                break;
            default:
                letter = toInt32.ToString();
                break;
        }
        return letter;
    }

    static void Main(string[] args)
    {
        string encryptedInput = Console.ReadLine().ToUpper();
        List<char> cypherLenList = new List<char>();

        for (int i = encryptedInput.Length - 1; i >= 0; i--)
        {
            if (char.IsNumber(encryptedInput[i]))
            {
                cypherLenList.Add(encryptedInput[i]);
            }
            else
            {
                break;
            }
        }

        cypherLenList.Reverse();
        string cypherLen = string.Join("", cypherLenList);

        int cypherLength = Convert.ToInt32(cypherLen);
        StringBuilder sb = new StringBuilder();
        StringBuilder digit = new StringBuilder();

        for (int i = 0; i < encryptedInput.Length - cypherLen.Length; i++)
        {
            if (Char.IsNumber(encryptedInput[i]))
            {
                digit.Append(encryptedInput[i]);
            }
            else
            {
                if (digit.Length == 0)
                {
                    sb.Append(encryptedInput[i]);
                }
                else
                {
                    sb.Append(new string(encryptedInput[i], int.Parse(digit.ToString())));
                    digit.Clear();
                }
            }
        }
        string cypher = sb.ToString().Substring(sb.Length - cypherLength, cypherLength);
        string encodedMsg = sb.ToString().Substring(0, sb.Length - cypherLength);
        Console.WriteLine(Decrypt(encodedMsg, cypher));
    }
}
