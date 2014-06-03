namespace StudentsDescending
{
    using System;
    using System.Linq;

    class StudentsDescendingTest
    {
        static void Main(string[] args)
        {
            Student[] students = 
            {
                new Student("Zahari","Petrov"),
                new Student("Angel","Ivanov"),
                new Student("Todor","Stoyanov"),
                new Student("Misho","Zaichev"),
                new Student("Borislav","Chepkov")
            };

            //using lambda expressions
            Console.WriteLine("******Sort using lambda expressions******");
            var sortedNamesLambda = students
                                            .OrderByDescending(fn => fn.FirstName)
                                            .ThenByDescending(ln => ln.LastName);

            foreach (var item in sortedNamesLambda)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            // using LINQ
            Console.WriteLine("\n******Sort using LINQ******");
            var sortedNamesLinq = from student in students
                                  orderby student.FirstName descending, student.LastName descending
                                  select student;

            foreach (var item in sortedNamesLinq)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
            Console.WriteLine();
        }
    }
}