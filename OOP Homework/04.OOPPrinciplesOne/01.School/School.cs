namespace StudentSystem
{
    using System;
    using System.Text;
    using System.Collections;
    using System.Collections.Generic;

    public class School : IEnumerable
    {
        private readonly SortedSet<Class> classes = new SortedSet<Class>();


        // property
        public string Name { get; private set; }

        // constructor
        public School(string name)
        {
            this.Name = name;
        }


        // method for adding classes
        public School AddClass(params Class[] classes)
        {
            foreach (Class _class in classes)
            {
                this.classes.Add(_class);
            }

            return this;
        }


        // method for removing classes
        public School RemoveClass(Class _class)
        {
            this.classes.Remove(_class);

            return this;
        }

        // The next two methods are for creating a School with: new School(name) { ... }
        public void Add(Class _class)
        {
            this.AddClass(_class);
        }


       
        public IEnumerator GetEnumerator()
        {
            return this.classes.GetEnumerator();
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();

            info.AppendLine("# School: " + this.Name);
            info.AppendLine(this.classes.ToString<Class>());

            return info.TrimEnd().ToString();
        }
    }
}