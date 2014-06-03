namespace Bank
{
    using System;

    public abstract class Customer
    {
        // name property
        public string Name { get; private set; }


        // constructor
        public Customer(string name)
        {
            this.Name = name;
        }

        // printing 
        public override string ToString()
        {
            return String.Format("Type: {0}; Name: {1}", this.GetType().Name, this.Name);
        }
    }
}