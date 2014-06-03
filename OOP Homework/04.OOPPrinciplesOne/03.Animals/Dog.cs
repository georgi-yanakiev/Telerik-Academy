namespace Animals
{
    using System;

    public class Dog : Animal
    {
        public Dog(string name, int age, Sex sex) : base(name, age, sex) // inherits from the base (Animal) class
        {
        }

        public override string ProduceSound()
        {
            return "Dog barked.";
        }
    }
}