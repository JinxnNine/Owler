using System;
namespace Owler.Models;
public class User
{
    // Attributes 
    private string Name;
    private string Email;
    private string Password;
    private int DateOfBirth;
    private int Id;

    //Constructor
    public User(string Name, string Email, string Password, int DateOfBirth, int Id)
    {
        this.Name = Name;
        this.Email = Email;
        this.Password = Password;
        this.DateOfBirth = DateOfBirth;
        this.Id = Id;
    }

    //Methods
    public string Register()
    {
        return $"{Email} {Password}";
    }
    public string Login()
    {
        return $"{Email} {Password}";
    }
    public string Contact()
    {
        return Email;
    }
}
