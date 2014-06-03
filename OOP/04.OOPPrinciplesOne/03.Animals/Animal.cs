namespace Animals
{
    using System;
    using System.Collections.Generic;

    public abstract class Animal : ISound
    {
        // properties
        public string Name { get; private set; }

        public int Age { get; private set; }

        public Sex Sex { get; private set; }

        // animal constructor
        public Animal(string name, int age, Sex sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public abstract string ProduceSound();

        // printing animal data
        public override string ToString()
        {
            List<string> info = new List<string>();

            info.Add("Type: " + this.GetType().Name);
            info.Add("Name: " + this.Name);
            info.Add("Age: " + this.Age);
            info.Add("Sex: " + this.Sex);

            return String.Join("; ", info);
        }
    }
}