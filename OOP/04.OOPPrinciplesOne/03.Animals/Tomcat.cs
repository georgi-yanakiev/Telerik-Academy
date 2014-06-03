namespace Animals
{
    using System;

    public class Tomcat : Cat
    {
        public Tomcat(string name, int age) : base(name, age, Sex.Male) // tomcat is always male
        {
        }

        public override string ProduceSound()
        {
            return "Tomcat purred.";
        }
    }
}