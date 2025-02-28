using System;
using System.Collections.Generic;

namespace FirstApp.Models;

public interface IStudentRepository
{
    Student GetStudentById(int studentId);
    List<Student> GetAllStudents();
}
