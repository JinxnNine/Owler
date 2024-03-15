using System;
namespace Owler.Models;
public class Class
{
    // Attributes
    public string Name { get; set; }
    public int TeacherID { get; set; }
    public DateTime DateCreated { get; set; }
    public string Code { get; set; }
    public Student[] Students { get; set; }
    public string Subject { get; set; }

    // Constructor
    public Class(string name, int teacherID, DateTime dateCreated, string code, Student[] students, string subject)
    {
        Name = name;
        TeacherID = teacherID;
        DateCreated = dateCreated;
        Code = code;
        Students = students;
        Subject = subject;
    }
}

