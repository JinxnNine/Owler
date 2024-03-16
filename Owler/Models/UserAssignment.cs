using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
namespace Owler.Models;

[PrimaryKey(nameof(UserId), nameof(AssignmentId))]
public class UserAssignment
{
    [ForeignKey(nameof(User))]
    public required string UserId { get; set; }
    public User? User { get; set; }

    [ForeignKey(nameof(Assignment))]
    public int AssignmentId { get; set; }
    public Assignment? Assignment { get; set; }
    public int Mark { get; set; }
    public DateTime SubmitionDate { get; set; } = DateTime.UtcNow;
    
}
