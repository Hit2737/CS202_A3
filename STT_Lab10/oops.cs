using System;

public class Student
{
    public string Name { get; set; }
    public string ID { get; set; }
    public double Marks { get; set; }

    public Student(string name, string id, double marks)
    {
        Name = name;
        ID = id;
        Marks = marks;
    }

    public string GetGrade()
    {
        if (Marks >= 90)
            return "A";
        else if (Marks >= 80)
            return "B";
        else if (Marks >= 70)
            return "C";
        else if (Marks >= 60)
            return "D";
        else
            return "F";
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Marks: {Marks}");
        Console.WriteLine($"Grade: {GetGrade()}");
    }
}

public class StudentIITGN : Student
{
    public string Hostel_Name_IITGN { get; set; }

    public StudentIITGN(string name, string id, double marks, string hostelName)
        : base(name, id, marks)
    {
        Hostel_Name_IITGN = hostelName;
    }

    public new void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Hostel Name: {Hostel_Name_IITGN}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter student details:");

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter ID: ");
        string id = Console.ReadLine();

        Console.Write("Enter Marks: ");
        double marks = Convert.ToDouble(Console.ReadLine());

        Student student = new Student(name, id, marks);
        Console.WriteLine("\n---- Student Details ----");
        student.DisplayDetails();

        Console.WriteLine("\nEnter IITGN student details:");

        Console.Write("Enter Hostel Name: ");
        string hostelName = Console.ReadLine();

        StudentIITGN iitgnStudent = new StudentIITGN(name, id, marks, hostelName);
        Console.WriteLine("\n---- IITGN Student Details ----");
        iitgnStudent.DisplayDetails();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
