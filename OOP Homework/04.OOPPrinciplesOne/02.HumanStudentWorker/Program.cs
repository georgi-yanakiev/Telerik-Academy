// 02. Define abstract class Human with first name and last name. 
// Define new class Student which is derived from Human and has new field – grade. 
// Define class Worker derived from Human with new property WeekSalary and 
// WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker. 
// Define the proper constructors and properties for this hierarchy. Initialize a list of 10 students and 
// sort them by grade in ascending order (use LINQ or OrderBy() extension method). 
// Initialize a list of 10 workers and sort them by money per hour in descending order. 
// Merge the lists and sort them by first name and last name.

namespace HumanStudentWorker
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Светлин", "Иванов", "08 А"),
                new Student("Пешо", "Иванов", "08 А"),
                new Student("Гошо", "Иванов", "10 А"),
                new Student("Преслав", "Иванов", "10 А"),
                new Student("Александър", "Иванов", "10 Б"),
                new Student("Антоний", "Иванов", "08 Б"),
                new Student("Владислав", "Иванов", "10 Б"),
                new Student("Владислав", "Иванов", "12 А"),
                new Student("Гошо", "Иванов", "12 А"),
                new Student("Преслав", "Иванов", "12 Б"),
                new Student("Филип", "Иванов", "12 Б")
            };

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Владислав", "Иванов", 22, 26),
                new Worker("Светлин", "Иванов", 73, 26),
                new Worker("Гошо", "Иванов", 233, 25),
                new Worker("Преслав", "Иванов", 97, 45),
                new Worker("Владислав", "Иванов", 261, 44),
                new Worker("Александър", "Иванов", 173, 52),
                new Worker("Пешо", "Иванов", 172, 36),
                new Worker("Антоний", "Иванов", 172, 35),
                new Worker("Преслав", "Иванов", 57, 43),
                new Worker("Гошо", "Иванов", 108, 51),
                new Worker("Филип", "Иванов", 107, 35)
            };

            {
                students.OrderBy(
                    student => student.Grade).Print();

                workers.OrderByDescending(
                    worker => worker.GetMoneyPerHour()).Print();
            }

            {
                List<Human> humans = new List<Human>();
                humans.AddRange(students);
                humans.AddRange(workers);
                humans.OrderBy(
                    human => human.FirstName
                ).ThenBy(
                    human => human.LastName
                ).Print();
            }
        }
    }
}