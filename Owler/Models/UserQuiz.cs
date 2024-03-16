using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
namespace Owler.Models;

[PrimaryKey(nameof(UserId), nameof(QuizId))]
public class UserQuiz
{
    [ForeignKey(nameof(User))]
    public required string UserId { get; set; }
    public User? User { get; set; }

    [ForeignKey(nameof(Quiz))]
    public int QuizId { get; set; }
    public Quiz? Quiz { get; set; }
    public int Mark { get; set; }
    public DateTime SubmitionDate { get; set; } = DateTime.UtcNow;

}
