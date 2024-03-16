using Owler.Models;

namespace Owler.Services.TeacherServices;

interface ITeacherServices
{




   public void CreateClass();

   public void CreatePosts();

   public void AddStudents(List<Student> students);

   public void CreateQuizzes(Quiz quiz);

   public void SetAssignments(Assignment assignment);

   public void AddGrades(Student studentGrade);

   public void Attendance(string studentId);
   public void AddStudents(string studentId);
   public void RemoveStudents(string studentId);

}