using System;

class EmployeeRecord
{
    static void Main(string[] args)
    {
        Console.Title = "Employee Record";
        string firstName = "Tony";
        string lastName = "Montana";
        byte age = 35;
        char gender = 'M';
        ulong idNumber = 1172368478; // could be longer than 10 digits, thats why ulong is used
        uint empNumber = 27561234;
        Console.WriteLine("First Name: "+firstName);
        Console.WriteLine("Last Name: "+lastName);
        Console.WriteLine("Age: "+age);
        Console.WriteLine("Gender: "+gender);
        Console.WriteLine("ID Number: "+idNumber);
        Console.WriteLine("Employee Number: "+empNumber);
    }
}
