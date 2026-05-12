using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using StudentEF.Data;
using StudentEF.Model;
using System.Text.Json.Serialization;
namespace StudentEF.Services
{
    public class StudentService
    {
        public void AddStudent()
        {
            using var context = new AppDbContext();

            Console.Write("Enter Student Name :");
            string name = Console.ReadLine();

            Console.Write("Enter Student Marks :");
            int marks = int.Parse(Console.ReadLine());

            var student = new Student
            {
                Name = name,
                Marks = marks
            };
            context.Students.Add(student);
            context.SaveChanges();

            Console.WriteLine("Student Added Succesfully ! ");
        }

        public void ViewStudent()
        {
            using var context = new AppDbContext();
            var students = context.Students.ToList();

            foreach (var s in students)
            {
                Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Marks: {s.Marks}");
            }
        }
    }

}