using System;

namespace FirstApp.Models;

public class SomeOtherService
{
    //create a referance variable of IStudentRepository
    private readonly IStudentRepository? _repository = null;

    //initialize the repository in the constructor
    public SomeOtherService(IStudentRepository repository)
    {
        _repository = repository;
    }

    public void someMethod()
    {
        //call the method of the repository
        // _repository?.GetAllStudents();
    }


}
