using Owler.Data;
using Owler.Models;

namespace Owler.Services.StudentServices;

class StudentService : IStudentService
{

    private readonly ApplicationDbContext  applicationDbContext;
    public StudentService(ApplicationDbContext applicationDbContext)
    {
        this.applicationDbContext = applicationDbContext;
    }
    public void AttendLectures(string classId)
    {
        throw new NotImplementedException();
    }

    public void SolveQuizzes(string quizId)
    {
        throw new NotImplementedException();
    }

    public void SubmitAssignments(string assignmentId)
    {
        throw new NotImplementedException();
    }

    public void ViewFeed()
    {
        throw new NotImplementedException();
    }

    public void ViewGrades(string classId)
    {
        throw new NotImplementedException();
    }

    public void ViewTimetables(string classId)
    {
        throw new NotImplementedException();
    }
}