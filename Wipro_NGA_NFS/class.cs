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

// class Student
// {
//     public string Name;
//     public int Id;

//     public Student(string name, int id)
//     {
//         Name = name;
//         Id = id;
//     }

//     public void DisplayInfo()
//     {
//         Console.WriteLine("Name: " + Name + ", Id: " + Id);
//     }

//     public void UpdateName(string newName)
//     {
//         Name = newName;
//     }

//     public void UpdateId(int newId)
//     {
//         Id = newId;
//     }
// }

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Student s1 = new Student("Samar", 101);
//         Student s2 = new Student("Ashutosh", 102);

//         s1.DisplayInfo();
//         s2.DisplayInfo();

//         // Update values
//         s1.UpdateName("Arnav");
//         s1.UpdateId(201);

//         Console.WriteLine("After Update:");
//         s1.DisplayInfo();
//     }
// }