// 03. A company has name, address, phone number, fax number, web site and manager. 
// The manager has first name, last name, age and a phone number. 
// Write a program that reads the information about a company 
// and its manager and prints them on the console.

using System;

class CompanyDetails
{
    static void Main(string[] args)
    {
        Console.Title = "Company Details";
        Console.Write("Company's name: ");
        string company = Console.ReadLine();
        Console.Write("Company's address: ");
        string address = Console.ReadLine();
        Console.Write("Company's phone number: ");
        string phone = Console.ReadLine(); // used in string format because of the special symbols or spaces i.e. +359 898 123 456
        Console.Write("Company's fax number: ");
        string fax = Console.ReadLine();
        Console.Write("Company's website: ");
        string website = Console.ReadLine();
        Console.Write("Manager's first name: ");
        string mngFirstName = Console.ReadLine();
        Console.Write("Manager's last name: ");
        string mngLastName = Console.ReadLine();
        Console.Write("Manager's age: ");
        byte mngAge = byte.Parse(Console.ReadLine());
        Console.Write("Manager's phone number: ");
        string mngPhone = Console.ReadLine();

        Console.WriteLine("\n" + company);
        Console.WriteLine(address);
        Console.WriteLine(phone);
        Console.WriteLine(fax);
        Console.WriteLine(website);
        Console.WriteLine(mngFirstName);
        Console.WriteLine(mngLastName);
        Console.WriteLine(mngAge);
        Console.WriteLine(mngPhone + "\n");
    }
}