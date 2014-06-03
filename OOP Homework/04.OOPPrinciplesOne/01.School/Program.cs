// 01. We are given a school. In the school there are classes of students. 
//Each class has a set of teachers. Each teacher teaches a set of disciplines.
// Students have name and unique class number. Classes have unique text identifier. 
// Teachers have name. Disciplines have name, number of lectures and number of exercises. 
// Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments (free text block).
//	Your task is to identify the classes (in terms of  OOP) and their attributes and operations, 
// encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.

namespace StudentSystem
{
    using System;

    public class Program
    {
        static void Main()
        {
            Console.WriteLine(new School("ФМИ")
            {
                new Class("Компютърни науки").AddStudent(
                    new Student("Светлин", "Иванов", "Наков"),
                    new Student("Пешо", "Иванов", "Наков"),
                    new Student("Гошо", "Иванов", "Наков"),
                    new Student("Преслав", "Иванов", "Георгиев"),
                    new Student("Преслав", "Иванов", "Георгиев"),
                    new Student("Преслав", "Иванов", "Георгиев"),
                    new Student("Преслав", "Иванов", "Георгиев"),
                    new Student("Преслав", "Иванов", "Георгиев"),
                    new Student("Преслав", "Иванов", "Георгиев")).RemoveStudent(
                    new Student("Гошо", "Иванов", "Наков")).AddTeacher(
                    new Teacher("Николай", "Иванов", "Костов").AddDiscipline(
                    new Discipline("Анализ", 3, 3),
                    new Discipline("Геометрия", 1, 2),
                    new Discipline("Алгебра", 1, 1),
                    new Discipline("Алгебра", 1, 1),
                    new Discipline("Алгебра", 1, 1)).RemoveDiscipline(
                    new Discipline("Геометрия"))),
                new Class("Информатика").AddStudent(
                    new Student("Александър", "Иванов", "Наков"),
                    new Student("Антоний", "Иванов", "Наков"),
                    new Student("Владислав", "Иванов", "Наков")).AddTeacher(
                    new Teacher("Преслав", "Иванов", "Костов").AddDiscipline(
                    new Discipline("Алгебра", 3, 3)),
                    new Teacher("Филип", "Иванов", "Георгиев").AddDiscipline(
                    new Discipline("Дискретна математика", 3, 3)))
            });
        }
    }
}