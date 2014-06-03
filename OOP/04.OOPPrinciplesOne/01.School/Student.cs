namespace StudentSystem
{
    using System;

   public  class Student : Human, ICommentable
    {
       // properties
        public int ClassNumber { get; private set; }

        public string Comment { get; set; }


       // constructor
        public Student(string firstName, string middleName, string lastName) : base(firstName, middleName, lastName)
        {
        }
    }
}