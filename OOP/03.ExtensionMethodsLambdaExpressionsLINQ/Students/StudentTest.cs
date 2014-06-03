// 02. Write a method that from a given array of students finds all students whose 
// first name is before its last name alphabetically. Use LINQ query operators.

namespace Students
{
    using System;
    using System.Linq;

    public class StudentTest
    {
        static void Main()
        {
            // array of students
            Student[] students = 
            {
                new Student("Zahari","Petrov"),
                new Student("Angel","Ivanov"),
                new Student("Todor","Stoyanov"),
                new Student("Misho","Zaichev"),
                new Student("Borislav","Chepkov")
            };

            // getting the names which first names are alphabetically before their last names
            var firstNameBeforeLast = from student in students
                                      where student.FirstName.CompareTo(student.LastName) < 0 // if the index is -1 means before 
                                      select student;                                                                                    // 0 - equal / 1 - first name is after the last

            foreach (var name in firstNameBeforeLast)
            {
                Console.WriteLine(name.FirstName + " " + name.LastName);
            }
        }
    }
}