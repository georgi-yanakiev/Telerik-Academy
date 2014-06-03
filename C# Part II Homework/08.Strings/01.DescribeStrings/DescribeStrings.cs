class DescribeStrings
{
    static void Main(string[] args)
    {
        // The string type represents a sequence of zero or more Unicode characters. string is an alias for String in the .NET Framework.
        // Although string is a reference type, the equality operators (== and !=) are defined to compare the values of string objects, not references. This makes testing for string equality more intuitive.
        // Strings are immutable--the contents of a string object cannot be changed after the object is created, although the syntax makes it appear as if you can do this. 
        // The [] operator can be used for readonly access to individual characters of a string:
        // String literals are of type string and can be written in two forms, quoted and @-quoted. Quoted string literals are enclosed in double quotation marks ("):
        // String literals can contain any character literal. Escape sequences are included. The following example uses escape sequence \\ for backslash, \u0066 for the letter f, and \n for newline.

        // Methods:
        // IndexOf(Char) - Reports the zero-based index of the first occurrence of the specified Unicode character in this string.
        // Join(String, String[]) - Concatenates all the elements of a string array, using the specified separator between each element. 
        // PadLeft(Int32) - Returns a new string that right-aligns the characters in this instance by padding them with spaces on the left, for a specified total length.
        // Split(Char[]) - Returns a string array that contains the substrings in this instance that are delimited by elements of a specified Unicode character array.
        // ToCharArray() - Copies the characters in this instance to a Unicode character array.
        // ToLower() - Returns a copy of this string converted to lowercase.
        // ToUpper() - Returns a copy of this string converted to uppercase.
        // Trim() - Removes all leading and trailing white-space characters from the current String object.
    }
}
