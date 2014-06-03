namespace HumanStudentWorker
{
    public class Student : Human
    {
        public string Grade { get; private set; }

        public Student(string firstName, string lastName, string grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public override string ToString() // printing grade
        {
            return base.ToString("Grade: " + this.Grade);
        }
    }
}