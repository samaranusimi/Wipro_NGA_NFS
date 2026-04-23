using System;

namespace reflection_Demo
{
    internal class Student{
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Description { get; set;}
        public void Display(){
            Console.WriteLine("Student Details");
        }
        public void Exams(){
            Console.WriteLine("Exam");
        }
    }
}
