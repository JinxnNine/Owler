using System;
using System.CodeDom;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Identity;
namespace Owler.Models;
public class User : IdentityUser
{
    public enum UserType{
        Teacher,
        Student
    }
    

    [MaxLength(100)]
    public required string Name { get; set; }
    public DateTime CreationDate { get; set; } = DateTime.UtcNow;
    public List<Class> TeacherClasses { get; set; } = new();
    public List<Class> StudentClasses { get; set; } = new();
    public List<Quiz> TeacherQuizzes { get; set; } = new();
    public List<Quiz> StudentQuizzes { get; set; } = new();
    public List<Assignment> TeacherAssignments { get; set; } = new();
    public List<Assignment> StudentAssignments { get; set; } = new();
    
    [JsonConverter(typeof(JsonStringEnumConverter))]    
    public required UserType Type { get; set; }

}
