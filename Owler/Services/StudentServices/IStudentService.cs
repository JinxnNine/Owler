namespace Owler.Services.StudentServices;

interface IStudentService
{

    public void ViewFeed();

    public void AttendLectures(string classId);
    public void SolveQuizzes(string quizId);

    public void SubmitAssignments(string assignmentId);

    public void ViewTimetables(string classId);

    public void ViewGrades(string classId);
}