namespace StudentSystem
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    public class Class : ICommentable, IComparable<Class>
    {
        // readonly fields
        private readonly SortedSet<Student> students = new SortedSet<Student>();
        private readonly SortedSet<Teacher> teachers = new SortedSet<Teacher>();

        // properties
        public string Name { get; private set; }

        public string Comment { get; set; }

        // constructor
        public Class(string name)
        {
            this.Name = name;
        }


        // method for adding students
        public Class AddStudent(params Student[] students)
        {
            foreach (Student student in students)
                this.students.Add(student);

            return this;
        }


        // method for removing students
        public Class RemoveStudent(Student student)
        {
            this.students.Remove(student);

            return this;
        }

        // method for adding teachers

        public Class AddTeacher(params Teacher[] teachers)
        {
            foreach (Teacher teacher in teachers)
                this.teachers.Add(teacher);

            return this;
        }

        // method for removing teachers
        public Class RemoveTeacher(Teacher teacher)
        {
            this.teachers.Remove(teacher);

            return this;
        }


        // method for comparison
        public int CompareTo(Class other)
        {
            return this.Name.CompareTo(other.Name);
        }


        // printing method
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();

            info.AppendLine("# Class name: " + this.Name);

            info.AppendLine("# Teachers:");
            info.AppendLine(this.teachers.ToString<Teacher>());

            info.AppendLine("# Students:");
            info.AppendLine(this.students.ToString<Student>());

            return info.TrimEnd().ToString();
        }
    }
}