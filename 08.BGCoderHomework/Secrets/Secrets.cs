// Task 02. "Telerik Academy Exam 1 @ 24 June 2013 Evening"
using System;
using System.Text;
using System.Numerics;

class Secrets
{
    public static void Main(string[] args)
    {
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        string numStr = BigInteger.Abs(number).ToString();
        char[] numArr = numStr.ToCharArray();
        BigInteger specSum = 0;
        Array.Reverse(numArr);
        BigInteger r = 0;

        for (int i = 1; i < numArr.Length + 1; i++)
        {
            BigInteger numNum = Convert.ToInt32(numArr[i - 1] - 48);
            if (i % 2 != 0)
            {
                specSum += numNum * (i * i);
            }
            if (i % 2 == 0)
            {
                specSum += (numNum * numNum) * i;
            }
        }
        Console.WriteLine(specSum);
        BigInteger seqLength = specSum % 10;
        if (seqLength == 0)
        {
            Console.WriteLine("{0} has no secret alpha-sequence", number);
            return;
        }
        r = specSum % 26;
        StringBuilder sb = new StringBuilder();
        int alp = 65;
        for (int q = 0; q < seqLength; q++)
        {
            if ((r + alp + q) == 91)
            {
                alp = 39;
            }
            Console.Write((char)((r + alp + q)));
        }
        Console.WriteLine();
    }
}