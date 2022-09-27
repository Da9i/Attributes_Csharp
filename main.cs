using System;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true)]

class InformationAttribute : Attribute
{
    public string InformationString { get; set; }
}

[Information(InformationString = "Class")]
public class Student
{
    private int rollno;
    private char section;
    private string name, institute;

    [Information(InformationString = "Constructor")]
    public Student(string name, int rollno, char section, string institute)
    {
        this.name = name;
        this.rollno = rollno;
        this.section = section;
        this.institute = institute;

    }

    [Information(InformationString = "Method")]
    public void display()
    {
        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Roll Number: {0}", rollno);
        Console.WriteLine("Section: {0}", section);
        Console.WriteLine("Institute: {0}", institute);
    }
}

public class GFG
{
    public static void Main(string[] args)
    {
        Student std = new Student("Danish Ibrahim", 0170, 'A', "NUCES");
        std.display();
        Console.ReadKey();
    }
}
