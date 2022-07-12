using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharrpApplication
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int TotalMarks { get; set; }
        public string Grades { get; set; }
        public static void ShowStudentDetail()
        {
            List<Student> students = new List<Student>()
            {
                new Student { Id = 11, Name = "nisha", Department ="cse",TotalMarks=68,Grades="C" },
                new Student { Id = 12, Name = "Utpal", Department = "Civil", TotalMarks = 66, Grades = "C" },
                new Student { Id = 13, Name = "Aish", Department = "cse", TotalMarks = 95, Grades = "A" },
                new Student { Id = 14, Name = "Devesh", Department ="cse",TotalMarks=92,Grades="A" },
                new Student { Id = 15, Name = "Venu", Department ="EEE",TotalMarks=90,Grades="A" },
                new Student { Id = 16, Name = "Rishika", Department ="IT",TotalMarks=85,Grades="B" },
                new Student { Id = 17, Name = "Pratik", Department ="Mech",TotalMarks=20,Grades="F" },
            };
            //select top 1* from table where marks>85
            var result =( from StudentData in students //If result isIEnumerable we r suppose to use foreach statement
                         where StudentData.TotalMarks>80
                         orderby StudentData.TotalMarks descending
                         
                            select new Student()
                            {
                                Id = StudentData.Id,
                                Name = StudentData.Name,
                            }).Take(3).ToList();// ToList()- Query will be executed on its own
            foreach (var item in result)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Name);

            }
            //Student Studobj = new Student();//Everytime we have to create a new object to store list for new memeory 
            //Studobj.Id = 111;
            //Studobj.Name = "Riya";
            //Studobj.Department = "CSE";
            //Studobj.TotalMarks = "80";
            //Studobj.Grades = "A";

            //students.Add(Studobj);

            //Studobj = new Student();
            //Studobj.Id = 112;
            //Studobj.Name = "Raj";
            //Studobj.Department = "IT";
            //Studobj.TotalMarks = "75";
            //Studobj.Grades = "B";
            //students.Add(Studobj);
            Console.ReadLine();
        }
    }
}
