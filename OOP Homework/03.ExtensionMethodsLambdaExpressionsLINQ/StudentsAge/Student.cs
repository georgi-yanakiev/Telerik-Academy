namespace StudentsAge
{
    public class Student
    {
        // properties
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int StudentAge { get; set; }


        // constructor
        public Student(string firstName, string lastName, int studentAge)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.StudentAge = studentAge;
        }
    }
}