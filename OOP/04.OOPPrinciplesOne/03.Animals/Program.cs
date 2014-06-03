// 03. Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. 
// Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). 
// Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only
// female and tomcats can be only male. Each animal produces a specific sound. Create arrays of 
// different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).

namespace Animals
{
    using System;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            Animal[] animals = new Animal[]
            {
                new Tomcat("Tom", 2), // creating new animals
                new Kitten("Toodles Galore", 4),
                new Dog("Kudjo", 3, Sex.Male),
                new Frog("Kermit", 5, Sex.Male)
            };

            Cat[] cats = new Cat[]
            {
                new Kitten("Toodles Galore", 2),
                new Tomcat("Tom", 6)
            };

            Console.WriteLine("# Animals");
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine("\n# Sounds");
            foreach (ISound animal in animals)
            {
                Console.WriteLine(animal.ProduceSound());
            }

            Console.WriteLine("\n# Average age");
            Console.WriteLine(animals.Average(animal => animal.Age) + " years");
            Console.WriteLine(cats.Average(cat => cat.Age) + " years");
        }
    }
}