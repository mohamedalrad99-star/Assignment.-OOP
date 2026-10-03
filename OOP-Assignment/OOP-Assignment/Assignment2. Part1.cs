using System;
using System.Collections.Generic;

class Person
{
    public string Name;
    public Person(string n) => Name = n;
    public virtual void DisplayInfo() => Console.WriteLine($"Name: {Name}");
}

class Student : Person
{
    public int StudentId;
    public Student(string n, int id) : base(n) => StudentId = id;
    public override void DisplayInfo() => Console.WriteLine($"Student: {Name}, ID: {StudentId}");
}

class Employee : Person
{
    public double Salary;
    public Employee(string n, double s) : base(n) => Salary = s;
    public override void DisplayInfo() => Console.WriteLine($"Employee: {Name}, Salary: {Salary}");
}

class Teacher : Person
{
    public string CourseName;
    public Teacher(string n, string c) : base(n) => CourseName = c;
    public override void DisplayInfo() => Console.WriteLine($"Teacher: {Name}, Course: {CourseName}");
}

class Program
{
    static void Show(Person p) => p.DisplayInfo();

    static void Main()
    {
        var list = new List<Person>
        {
            new Student("Ali", 101),
            new Employee("Sara", 5000),
            new Teacher("Omar", "OOP")
        };

        foreach (var p in list)
        {
            Console.WriteLine(p.GetType().Name);
            Show(p);
        }
    }
}
