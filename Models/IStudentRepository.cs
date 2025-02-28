using System;

namespace FirstApp.Models;

public interface IStudentRepository
{
    Student GetStudentById(int studentId);
}
