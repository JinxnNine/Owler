using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Owler.Models;
public class Assignment
{
    [Key]
    public int Id { get; set; }
    [MaxLength(1000)]
    public string? Description { get; set; }
    public DateTime CreationDate { get; set; } = DateTime.UtcNow;
    public required DateTime DeadLine { get; set; }
    public int Mark { get; set; }

    [ForeignKey(nameof(Teacher))]
    public required string TeacherId { get; set; }
    public User? Teacher { get; set; }

    [ForeignKey(nameof(Class))]
    public int ClassCode { get; set; }
    public Class? Class { get; set; }
    public List<User> Users { get; set; } = new();

}

