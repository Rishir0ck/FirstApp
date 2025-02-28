using System;
using System.Linq;
using System.IO;
namespace FirstApp.Models;

public class StudentRepository : IStudentRepository
{
    //When a new instance of StudentRepository is created,
    //we need to log the Date and time into a text file
    //using the constructor
    public StudentRepository()
    {
        string filePath = @"D:\Rishi Practice\Core Practice\Tutorial\FirstApp\Log\Log.txt";
        string contentToWrite = $"StudentRepository instance created at : {DateTime.Now}";

        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine(contentToWrite);
        }
    }   

    public List<Student> DataSource()
    {
        return new List<Student>
        {
            new Student()
            {
                StudentId = 1,
                Name = "John",
                Branch = "Computer Science",
                Section = "A",
                Gender = "Male"
            },
            new Student
            {
                StudentId = 2,
                Name = "Steve",
                Branch = "Computer Science",
                Section = "B",
                Gender = "Male"
            },
            new Student
            {
                StudentId = 3,
                Name = "Bill",
                Branch = "Computer Science",
                Section = "A",
                Gender = "Male"
            },
            new Student
            {
                StudentId = 4,
                Name = "Ram",
                Branch = "Computer Science",
                Section = "B",
                Gender = "Male"
            },
            new Student
            {
                StudentId = 5,
                Name = "Ronika",
                Branch = "Computer Science",
                Section = "A",
                Gender = "Female"
            },
        };
        
    }

    public List<Student> GetAllStudents()
    {
        return DataSource();
    }

    public Student GetStudentById(int studentId)
    {
       return DataSource().FirstOrDefault(x => x.StudentId == studentId) ?? new Student();  
    }
}
