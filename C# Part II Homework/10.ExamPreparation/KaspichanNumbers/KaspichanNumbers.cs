using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class KaspichanNumbers
{
    static void Main()
    {
        ulong decNum = ulong.Parse(Console.ReadLine());


        Console.WriteLine(string.Join("", DecToHex(decNum)));
    }

    private static string[] DecToHex(ulong decNum)
    {
        List<string> digits = new List<string>();

        for (char x = 'A'; x <= 'Z'; x++)
        {
            digits.Add(x.ToString());
        }

        for (char q = 'a'; q <= 'i'; q++)
        {
            for (char z = 'A'; z <= 'Z'; z++)
            {
                digits.Add(q.ToString() + z.ToString());
            }

        }

        string[] strArr = new string[(decNum.ToString()).Length];

        ulong temp = decNum;
        ulong rem = 0;
        int i = 0;

        do
        {
            rem = temp % 256;
            strArr[i] = (digits[Convert.ToInt32(rem)]);
            temp /= 256;
            i++;
        }
        while (temp > 0);

        Array.Reverse(strArr);

        return strArr;
    }
}
