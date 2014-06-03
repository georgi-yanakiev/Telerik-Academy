﻿namespace Person
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Person per = new Person("lala", 36);
            Person per1 = new Person("lala", null);
            Person per2 = new Person("fafa");
            Console.WriteLine(per);
            Console.WriteLine(per1);
            Console.WriteLine(per2);
        }
    }

    public class Person
    {
        string name;
        int? age;

        public Person(string name, int? age = null)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            string msg = name + " ";
            if (age == null)
            {
                msg += "age not specified";
            }
            else
                msg += age;

            return msg;
        }
    }
}