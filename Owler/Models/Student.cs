using System;
using System.Collections.Generic;
namespace Owler.Models;
public class Student
{
    // Attributes
    public List<Class> Classes { get; set; }

    // Constructor
    public Student()
    {
        Classes = new List<Class>();
    }

    // Methods
    public void ViewFeed()
    {
        
    }

    public void AttendLectures(string classId)
    {
       
    }

    public void SolveQuizzes(string quizId)
    {
        
    }

    public void SubmitAssignments(string assignmentId)
    {
        
    }

    public void ViewTimetables(string classId)
    {
        
    }

    public void ViewGrades(string classId)
    {
        
    }
}
