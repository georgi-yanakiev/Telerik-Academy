namespace StudentsAge
{
    using System;
    using System.Linq;

    public class StudentsAgeTest
    {
        static void Main(string[] args)
        {
            Student[] students = 
            {
                new Student("Zahari","Petrov",26),
                new Student("Angel","Ivanov",10),
                new Student("Todor","Stoyanov",18),
                new Student("Misho","Zaichev", 35),
                new Student("Borislav","Chepkov",23)
            };

            var between18And24 = from student in students
                                 where (student.StudentAge >= 18 && student.StudentAge <= 24)
                                 select student;

            foreach (var name in between18And24)
            {
                Console.WriteLine(name.FirstName + " " + name.LastName);
            }
        }
    }
}