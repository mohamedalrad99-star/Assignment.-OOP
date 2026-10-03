
using System;

class Person
{
    public string Name;
    public string Email;

    public Person(string name, string email)
    {
        Console.WriteLine("Person Constructor");
        Name = name;
        Email = email;
    }

    public void DisplayBasicInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Email: " + Email);
    }
}

class Student : Person
{
    public string StudentId;
    public double GPA;

    public Student(string name, string email,
                   string id, double gpa)
        : base(name, email)
    {
        Console.WriteLine("Student Constructor");
        StudentId = id;
        GPA = gpa;
    }
}

class Employee : Person
{
    public string EmployeeId;
    public double Salary;

    public Employee(string name, string email,
                    string id, double salary)
        : base(name, email)
    {
        Console.WriteLine("Employee Constructor");
        EmployeeId = id;
        Salary = salary;
    }
}

class Teacher : Employee
{
    public string CourseName;

    public Teacher(string name, string email,
                   string id, double salary,
                   string course)
        : base(name, email, id, salary)
    {
        Console.WriteLine("Teacher Constructor");
        CourseName = course;
    }

    public void Teach()
    {
        Console.WriteLine("Teaching: " + CourseName);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Student ---");

        Student student = new Student(
            "Ahmed", "ahmed@gmail.com",
            "S101", 3.8);

        student.DisplayBasicInfo();
        Console.WriteLine("Student ID: " + student.StudentId);
        Console.WriteLine("GPA: " + student.GPA);

        Console.WriteLine();

        Console.WriteLine("--- Teacher ---");

        Teacher teacher = new Teacher(
            "Mohammed", "m@gmail.com",
            "E101", 5000, "OOP");

        teacher.DisplayBasicInfo();
        Console.WriteLine("Employee ID: " + teacher.EmployeeId);
        Console.WriteLine("Salary: " + teacher.Salary);
        teacher.Teach();
    }
}
