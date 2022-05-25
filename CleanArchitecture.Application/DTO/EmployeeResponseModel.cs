using CleanArchitecture.Core.Entities;

public class EmployeeResponseModel
{

    public Int64 Id
    {
        get;
        set;
    }

    public string FirstName
    {
        get;
        set;
    }

    public string LastName
    {
        get;
        set;
    }

    public DateTime DateOfBirth
    {
        get;
        set;
    }

    public string PhoneNumber
    {
        get;
        set;
    }

    public string Email
    {
        get;
        set;
    }

    public string Email2
    {
        get;
        set;
    }

    public Departments Departments { get; set; }
}