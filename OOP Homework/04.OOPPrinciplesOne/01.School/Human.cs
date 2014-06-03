namespace StudentSystem
{
    using System;

    public class Human : IComparable<Human>
    {

        // properties
        public string FirstName { get; private set; }

        public string MiddleName { get; private set; }

        public string LastName { get; private set; }


        // constructor
        public Human(string firstName, string middleName, string lastName)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
        }

        // method for comparison
        public int CompareTo(Human other)
        {
            return this.FirstName.CompareTo(other.FirstName);
        }

        // printing method
        public override string ToString()
        {
            return String.Format("{0} {1} {2}", this.FirstName, this.MiddleName, this.LastName);
        }
    }
}