namespace Students
{
    public class Student
    {
        // properties
        public string FirstName { get; set; }

        public string LastName { get; set; }


        // constructor
        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}