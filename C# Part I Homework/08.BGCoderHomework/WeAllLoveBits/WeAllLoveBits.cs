// Task 04. "Telerik Academy Exam 1 @ 6 Dec 2011 Morning"
using System;
using System.Text;

class WeAllLoveBits
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int p = 0;
        int pDot = 0;
        int pTilde = 0;
        int[] pArr = new int[n];
        int[] pTildeArr = new int[n];
        int[] pInvArr = new int[n];

        for (int i = 0; i < n; i++)
        {
            p = int.Parse(Console.ReadLine());
            pArr[i] = p;
        }

        for (int k = 0; k < n; k++)
        {
            StringBuilder sbOne = new StringBuilder();
            string str = (Convert.ToString(pArr[k], 2));
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '1')
                {
                    char nula = '0';
                    sbOne.Append(nula);
                }

                if (str[i] == '0')
                {
                    char edno = '1';
                    sbOne.Append(edno);
                }
            }
            pTildeArr[k] = Convert.ToInt32(sbOne.ToString(), 2);
        }

        for (int k = 0; k < n; k++)
        {
            StringBuilder sbTwo = new StringBuilder();
            string str = (Convert.ToString(pArr[k], 2));
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sbTwo.Append(str[i]);
            }
            pInvArr[k] = Convert.ToInt32(sbTwo.ToString(), 2);
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine((pArr[i] ^ pTildeArr[i]) & pInvArr[i]);
        }
    }
}