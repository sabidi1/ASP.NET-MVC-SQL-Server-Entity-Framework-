using System;
using System.Collections.Generic;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            
            var adding = true;

            while (adding)
            {
                var newStudent = new Student();

                newStudent.Name = Util.console.Ask("Student Name: ");

                newStudent.Grade = int.Parse(Util.console.Ask("Student Grade: "));

                newStudent.Birthday = Util.console.Ask("Student Birthday: ");

                newStudent.Address = Util.console.Ask("Student Address: ");

                newStudent.Phone = int.Parse(Util.console.Ask("Student Phone: "));

                students.Add(newStudent);

                Console.WriteLine("Add another? (y/n)");

                if (Console.ReadLine() != "y")
                    adding = false;

            }

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1}, Birthday: {2}, Address: {3}, Phone: {4}", student.Name, student.Grade,student.Birthday,student.Address,student.getPhone());
            }
           
        }
    }
}

class Student
{
    public string Name;
    public int Grade;
    public string Birthday;
    public string Address;
    public int Phone;

    public void SetPhone(int number)
    {
        Phone = number; 
    }
    public int getPhone()
    {
        return Phone;
    }
}