// 07. Write a program that encodes and decodes a string using given encryption key (cipher). 
// The key consists of a sequence of characters. The encoding/decoding is done by performing 
// XOR (exclusive or) operation over the first letter of the string with the first of the key, the second 
// – with the second, etc. When the last key character is reached, the next is the first.

using System;
using System.Text;
using System.IO;

class EncodingDecoding
{
    static void Main(string[] args)
    {
        Console.Title = "Encoding Decoding";
        Console.Write("Enter the encryption key: ");
        string key = Console.ReadLine();

        try
        {
            string workingFile = File.ReadAllText(@"..\..\InputText.txt"); // reading the file
            StringBuilder largeKey = new StringBuilder();
            StringBuilder encryptedString = new StringBuilder();

            while (largeKey.Length <= workingFile.Length)
            {
                largeKey.Append(key); // filling the stringbuilder with the cipher key in repeat one after another to get the length of the string to encrypt
            }

            for (int i = 0; i < workingFile.Length; i++)
            {
                encryptedString.Append((char)(largeKey[i] ^ workingFile[i])); // XOR each character into another stringbuilder, keeping the encoded symbols
            }

            string encoded = encryptedString.ToString();

            Console.WriteLine("Encoded text: \n{0}",encoded);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found!");
        }
    }
}