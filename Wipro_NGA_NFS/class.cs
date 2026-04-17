using System;

class Student
{
    public string name;
    
}
class program
{
    public static void Main(string[] args){
        Student s = new Student();
        s.name = "Samar";
        Console.WriteLine($"Student Name: {s.name}");
    }
}