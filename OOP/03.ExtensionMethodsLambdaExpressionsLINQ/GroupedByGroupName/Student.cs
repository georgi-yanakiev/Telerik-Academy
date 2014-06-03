namespace GroupedByGroupName
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Student
    {
        private string firstName;
        private string lastName;
        private string fn;
        private string email;
        private int groupNumber;
        private Group groupName;


        // constructor
        public Student(string firstName, string lastName, string fn, string tel, string email, List<int> marks, Group groupName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.Group = groupName;
        }



        // properties with value validation
        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                if (value == null || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First name can't be null, whitespace or empty!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (value == null || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Last name can't be null, whitespace or empty!");
                }
                this.lastName = value;
            }
        }

        public string FN
        {
            get { return this.fn; }
            private set
            {
                if (value == null || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("FN can't be null, whitespace or empty!");
                }
                this.fn = value;
            }
        }

        public Group Group
        {
            get
            {
                return this.groupName;
            }
            set
            {
                this.groupName = value;
            }
        }
        public string Tel { get; private set; }

        public string Email
        {
            get { return this.email; }
            private set
            {
                if (value == null || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Email can't be null, whitespace or empty!");
                }
                this.email = value;
            }
        }

        public int GroupNumber
        {
            get { return this.groupNumber; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Group number can't be negative!");
                }
                this.groupNumber = value;
            }
        }

        public List<int> Marks { get; private set; }

        public int MarksCount
        {
            get { return this.Marks.Count; }
        }

        public override string ToString()
        {
            StringBuilder resultText = new StringBuilder();

            resultText.AppendFormat("Name: {0} {1}\n", this.FirstName, this.LastName);
            resultText.AppendLine(string.Format("Faculty Number: {0}", this.FN));
            resultText.AppendLine(string.Format("Tel: {0}", this.Tel));
            resultText.AppendLine(string.Format("Email: {0}", this.Email));
            resultText.AppendLine(string.Format("Marks: {0}", string.Join(", ", this.Marks)));
            resultText.AppendFormat("Group name: {0}", this.Group);

            return resultText.ToString();
        }

        public void AddMark(int mark)
        {
            if (mark >= 2 && mark <= 6)
            {
                this.Marks.Add(mark);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Mark value must be between 2 - 6!");
            }
        }

        public void RemoveMarkAt(int position)
        {
            if (position < 0 || position >= this.MarksCount)
            {
                throw new IndexOutOfRangeException(string.Format("Can't remove mark at position: {0} Index is out of range!", position));
            }

            this.Marks.RemoveAt(position);
        }

        public bool ContainMark(int mark)
        {
            return this.Marks.Contains(mark);
        }

        public string GetMarks()
        {
            return string.Join(", ", this.Marks);
        }
    }
}