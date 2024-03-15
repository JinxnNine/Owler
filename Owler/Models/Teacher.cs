using System;
using System.Collections.Generic;
namespace Owler.Models;

public class Teacher
{
    // Attributes
    public List<DateTime> Appointments { get; set; }
    public List<Class> Classes { get; set; }

    // Constructor
    public Teacher()
    {
        Appointments = new List<DateTime>();
        Classes = new List<Class>();
    }

    // Methods
    public void CreateClass()
    {

    }

    public void CreatePosts()
    {

    }

    public void AddStudents(List<Student> students)
    {

    }

    public void CreateQuizzes(Quiz quiz)
    {

    }

    public void SetAssignments(Assignment assignment)
    {

    }

    public void AddGrades(StudentGrade studentGrade)
    {

    }

    public void Attendance(string studentId)
    {

    }

    public void AddStudents(string studentId)
    {

    }

    public void RemoveStudents(string studentId)
    {

    }
}
