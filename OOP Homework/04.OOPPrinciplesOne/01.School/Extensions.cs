namespace StudentSystem
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    public static class Extensions
    {
        public static string ToString<T>(this IEnumerable<T> input)
        {
            return String.Join(Environment.NewLine, input);
        }

        public static StringBuilder TrimEnd(this StringBuilder input)
        {
            while (Char.IsWhiteSpace(input[input.Length - 1]))
                input.Remove(input.Length - 1, 1);

            return input;
        }
    }
}