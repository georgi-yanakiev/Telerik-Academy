namespace GroupedByGroupName
{
    using System;

    public class Group
    {
        private byte groupGroupNumber;
        private string departmentName;

        public Group(byte group, string depart)
        {
            this.GroupGroupNumber = group;
            this.DepartmentName = depart;
        }

        public byte GroupGroupNumber
        {
            get
            {
                return this.groupGroupNumber;
            }
            set
            {
                if (value < 0 || value > 9)
                {
                    throw new ArgumentException("Group must be 1 digit between 1 and 9 (including)");
                }
                this.groupGroupNumber = value;
            }
        }
        public string DepartmentName
        {
            get
            {
                return this.departmentName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Department name cannot be empty");
                }
                this.departmentName = value;
            }
        }

        public override string ToString()
        {
            return this.departmentName;
        }
    }
}
