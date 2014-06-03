using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace Zerg
{
    class Zerg
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] symbols =
            {
                "Rawr",
                "Rrrr",
                "Hsst",
                "Ssst",
                "Grrr",
                "Rarr",
                "Mrrr",
                "Psst",
                "Uaah",
                "Uaha",
                "Zzzz",
                "Bauu",
                "Djav",
                "Myau",
                "Gruh"
            };

            StringBuilder digits = new StringBuilder();

            var pattern = "[A-Z][a-z]+";
            System.Text.RegularExpressions.Regex regex = new Regex(pattern);
            var matches = regex.Matches(input);
            StringBuilder value = new StringBuilder();
            foreach (Match item in matches)
            {
                value.AppendFormat("{0} ", item.Value);
            }

            string[] numArr = value.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            numArr.Reverse();

            List<string> numDigits = new List<string>();

            for (int i = 0; i < numArr.Length; i++)
            {
                numDigits.Add(Array.IndexOf(symbols, numArr[i]).ToString());
            }

            Console.WriteLine(SourceToDecimal(numDigits.ToArray(), 15));
        }

        private static BigInteger SourceToDecimal(string[] sourceNum, int inSystem) // method for conversion of the input number to decimal numeral system
        {
            BigInteger resNo = 0;
            for (int i = 0; i < sourceNum.Length; i++)
            {
                long pow = (sourceNum.Length - i - 1);
                resNo += Convert.ToInt64(sourceNum[i]) * (long)Math.Pow(inSystem, pow);
            }
            return resNo;
        }
    }
}
