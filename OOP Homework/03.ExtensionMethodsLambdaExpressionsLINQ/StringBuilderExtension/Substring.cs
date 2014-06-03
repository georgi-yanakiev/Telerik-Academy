// 01.Implement an extension method Substring(int index, int length) 
// for the class StringBuilder that returns new StringBuilder and has 
// the same functionality as Substring in the class String.

namespace StringBuilderExtension
{
    using System;
    using System.Text;
    
    public static class Substring
    {
        public static StringBuilder SubstringExtended(this string input, int index, int length)
        {
            StringBuilder newTextBuilder = new StringBuilder();
            int lengthIndex = index + length;

            if (index >= 0 && lengthIndex <= input.Length)
            {
                for (int i = index; i < lengthIndex; i++)
                {
                    newTextBuilder.Append(input[i]);
                }

                return newTextBuilder;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}