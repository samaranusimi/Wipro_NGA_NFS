using System;
using System.Collections.Generic;

class Student
{
    public string Name;
    public int Marks;
    public int Attendance;
    public int Participation;
}
delegate void StudentDelegate(Student s);

class Program
{
    public static void Main()
    {
        List<Student> students = new List<Student>()
        {
        new Student { Name = "Samar", Marks = 60, Attendance = 80, Participation = 70 },
        new Student { Name = "Rahul", Marks = 40, Attendance = 75, Participation = 60 }
        };

        StudentDelegate evaluate = delegate (Student s)
        {
          int total = s.Marks+s.Attendance+s.Participation;

          Console.WriteLine();  
        };

        Predicate<Student> isEligible = s => s.Marks >50;
        foreach(Student s in students)
        {
            if (isEligible(s))
            {
                Console.WriteLine($"Eligible:{s.Name}");
            }
        }

        
    }
}