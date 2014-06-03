// 18. Create a program that extracts all students grouped by GroupName and then prints them to the console. Use LINQ.
namespace GroupedByGroupName
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class GroupedByGroupName
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("***Students by group name***\n");

            List<Student> newStudents = new List<Student>()
            {
                new Student("Gosho", "Pandurov", "506762", "0895369456", "goshootpochivka@abv.bg", new List<int> { 3, 4 }, new Group(3, "Mathematics")),
                new Student("Kolyo", "Vasilev", "201536", "02335954", "koleto@yahoo.com", new List<int> { 6, 5, 6, 6 }, new Group(2, "IT")),
                new Student("Trayan", "Tejkarski", "159306", "0965459654", "tejkar_t@abv.bg", new List<int> { 6, 5, 6 }, new Group(4, "Medicine")),
                new Student("Donka", "Kokosheva", "395103", "02654318", "donnie@outlook.com", new List<int> { 6, 6 }, new Group(4, "Medicine")),
                new Student("Silva", "Zurleva", "168906", "0899137581", "sil_zur@abv.bg", new List<int> { 2, 2, 3, 3 },new Group(1, "Geometry")),
                new Student("Konstantin", "Bajdekov", "654987", "0999456487", "bajdek_k@mail.com", new List<int> { 2, 2, 3, 3, 4 }, new Group(2, "IT"))
            };
            var stByGroupName = newStudents.OrderBy(st => st.Group.DepartmentName);
            PrintStudentData(stByGroupName);

            Console.WriteLine();
            Console.WriteLine("****Students by group name with  extension****\n");
            List<Student> groupedStudents = newStudents.GroupStudents();
        }

        static void PrintStudentData(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }
        }
    }
}