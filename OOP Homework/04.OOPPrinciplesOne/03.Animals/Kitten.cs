namespace Animals
{
    using System;

    public class Kitten : Cat
    {
        public Kitten(string name, int age) : base(name, age, Sex.Female) // kittens are always female
        {
        }

        public override string ProduceSound()
        {
            return "Kitten meowed.";
        }
    }
}