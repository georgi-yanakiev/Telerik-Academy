namespace Animals
{
    using System;

    public abstract class Cat : Animal
    {
        public Cat(string name, int age, Sex sex) : base(name, age, sex)
        {
        }
    }
}