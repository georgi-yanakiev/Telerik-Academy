namespace GroupedByGroupName
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class ListExtension
    {
        public static List<Student> GroupStudents(this List<Student> students)
        {
            var stByGroupName = students.OrderBy(st => st.Group.DepartmentName);
            foreach (var student in stByGroupName)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }
            return stByGroupName.ToList();
        }
    }
}