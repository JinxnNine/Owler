using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
namespace Owler.Models;
public class User : IdentityUser
{
    [MaxLength(100)]
    public required string Name { get; set; }
    public DateTime CreationDate { get; set; } = DateTime.UtcNow;
    public List<Class> Classes { get; set; } = new();
    public List<Quiz> Quizzes { get; set; } = new();
    public List<Assignment> Assignments { get; set; } = new();

}
