namespace StudentData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentDataTest
    {
        static List<Student> students;

        // task 9 Select only the students that are from group number 2 with Linq
        static void StudentsFromSecondGroupLinq()
        {
            Console.WriteLine("***Selected students from group 2 with LINQ***\n");
            var studentsFromSecondGroupLinq =
                                             from student in students
                                             where student.GroupNumber == 2
                                             orderby student.FirstName
                                             select student;

            PrintStudentData(studentsFromSecondGroupLinq);
        }

        // task 10 Implement the previous using the same query expressed with extension methods.
        static void StudentsFromSecondGroupLambda()
        {
            Console.WriteLine("***Selected students from group 2 with Lambda***\n");

            var studentsFromSecondGroupLambda = students.Where(x => x.GroupNumber == 2).OrderBy(x => x.FirstName);

            PrintStudentData(studentsFromSecondGroupLambda);
        }

        // task 11 Extract all students that have email in abv.bg. Use string methods and LINQ.
        static void StudentsEmailAbv()
        {
            Console.WriteLine("***Selected students with mail in abv.bg***\n");

            var studentEmailAbv =
                                 from student in students
                                 where student.Email.EndsWith("abv.bg")
                                 select student;

            PrintStudentData(studentEmailAbv);
        }

        // task 12 Extract all students with phones in Sofia. Use LINQ.
        static void SofiaPhoneNumbers()
        {
            Console.WriteLine("***Selected students with numbers in Sofia***\n");

            var sofiaPhoneNumbers =
                                   from student in students
                                   where student.Tel.StartsWith("02")
                                   select student;

            PrintStudentData(sofiaPhoneNumbers);
        }

        // task 13 Select all students that have at least one mark Excellent (6) into a 
        // new anonymous class that has properties – FullName and Marks. Use LINQ.
        static void AtLeastOneExcellentMark()
        {
            Console.WriteLine("***Selected students with excellent mark***\n");

            var studentsExcellentMark =
                                       from student in students
                                       where student.ContainMark(6)
                                       select new { FullName = student.FirstName + " " + student.LastName, Marks = student.GetMarks() };

            foreach (var student in studentsExcellentMark)
            {
                Console.WriteLine("{0} -> {1}\n", student.FullName, student.Marks);
            }
        }

        // task 14 Write down a similar program that extracts the students with exactly  two marks "2". Use extension methods.
        static void ExactlyTwoMarks2()
        {
            Console.WriteLine("***Selected students with two marks***\n");

            var exactlyTwoMarks2 =
                                  from student in students
                                  where student.Marks.Count(x => x == 2) == 2
                                  select new { FullName = student.FirstName + " " + student.LastName, Marks = student.GetMarks() };

            foreach (var student in exactlyTwoMarks2)
            {
                Console.WriteLine("{0} -> {1}", student.FullName, student.Marks);
            }
            Console.WriteLine();
        }

        // task 15 Extract all Marks of the students that enrolled in 2006. 
        // (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
        static void StudentsEnrolled2006()
        {
            Console.WriteLine("***Selected students enrolled 2006***\n");

            var studentsEnrolled2006 =
                                      from student in students
                                      where student.FN.Substring(4, 2) == "06"
                                      select new { FullName = student.FirstName + " " + student.LastName, FN = student.FN, Marks = student.GetMarks() };

            foreach (var student in studentsEnrolled2006)
            {
                Console.WriteLine("{0} ; Faculty Number: {1} ; Student Marks {2}", student.FullName, student.FN, student.Marks);
            }
            Console.WriteLine();
        }

        // student data
        static void Main()
        {
            students = new List<Student>()
            {
                new Student("Gosho", "Pandurov", "506762", "0895369456", "goshootpochivka@abv.bg", new List<int>
                {
                    3,
                    4
                }, 2),
                new Student("Kolyo", "Vasilev", "201536", "02335954", "koleto@yahoo.com", new List<int>
                {
                    6,
                    5,
                    6,
                    6
                }, 2),
                new Student("Trayan", "Tejkarski", "159306", "0965459654", "tejkar_t@abv.bg", new List<int>
                {
                    6,
                    5,
                    6
                }, 4),
                new Student("Donka", "Kokosheva", "395103", "02654318", "donnie@outlook.com", new List<int>
                {
                    6,
                    6
                }, 2),
                new Student("Silva", "Zurleva", "168906", "0899137581", "sil_zur@abv.bg", new List<int>
                {
                    2,
                    2,
                    3,
                    3
                }, 5),
                new Student("Konstantin", "Bajdekov", "654987", "0999456487", "bajdek_k@mail.com", new List<int>
                {
                    2,
                    2,
                    3,
                    3,
                    4
                }, 1)
            };

            // Execution of task tests methods
            StudentsFromSecondGroupLinq();

            StudentsFromSecondGroupLambda();

            StudentsEmailAbv();

            SofiaPhoneNumbers();

            AtLeastOneExcellentMark();

            ExactlyTwoMarks2();

            StudentsEnrolled2006();
        }

        // printing results
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