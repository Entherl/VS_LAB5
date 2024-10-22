using System;

public enum Department
{
    ComputerScience,
    SoftwareEngineering,
    CyberSecurity
}

public class Person
{
    public string Name { get; set; }

    // No argument constructor
    public Person()
    {
        Name = "Null";
    }

    // Multi-argument constructor
    public Person(string name)
    {
        Name = name;
    }
}

public class Student : Person
{
    public string RegNo { get; set; }
    public int Age { get; set; }
    public Department Program { get; set; }

    // No argument constructor
    public Student() : base()
    {
        RegNo = "Null";
        Age = 0;
        Program = Department.ComputerScience;
    }

    // Multi-argument constructor
    public Student(string name, string regNo, int age, Department program) : base(name)
    {
        RegNo = regNo;
        Age = age;
        Program = program;
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student();
        Console.WriteLine($"Student1: Name = {student1.Name}, RegNo = {student1.RegNo}, Age = {student1.Age}, Program = {student1.Program}");

        Student student2 = new Student("Musa", "233598", 20, Department.ComputerScience);
        Console.WriteLine($"Student2: Name = {student2.Name}, RegNo = {student2.RegNo}, Age = {student2.Age}, Program = {student2.Program}");
    }
}



