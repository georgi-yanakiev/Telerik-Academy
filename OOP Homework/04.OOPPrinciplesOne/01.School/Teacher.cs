namespace StudentSystem
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    public class Teacher : Human, ICommentable
    {
        private readonly SortedSet<Discipline> disciplines = new SortedSet<Discipline>(); // sorted set of disciplines

        // property
        public string Comment { get; set; }


        // constructor
        public Teacher(string firstName, string middleName, string lastName) : base(firstName, middleName, lastName)
        {
        }


        // method for add discipline
        public Teacher AddDiscipline(params Discipline[] disciplines)
        {
            foreach (Discipline discipline in disciplines)
                this.disciplines.Add(discipline);

            return this;
        }


        // method for remove discipline
        public Teacher RemoveDiscipline(Discipline discipline)
        {
            this.disciplines.Remove(discipline);

            return this;
        }


        // printing method
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();

            info.AppendLine(base.ToString());

            info.AppendLine(this.disciplines.ToString<Discipline>());

            return info.TrimEnd().ToString();
        }
    }
}