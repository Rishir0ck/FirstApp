using System;
using System.Linq;
namespace FirstApp.Models;

public class StudentRepository : IStudentRepository
{
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

    public Student GetStudentById(int studentId)
    {
       return DataSource().FirstOrDefault(x => x.StudentId == studentId) ?? new Student();  
    }
}
