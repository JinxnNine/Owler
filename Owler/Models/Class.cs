using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace Owler.Models;
public class Class
{
    [Key]
    public int ClassCode { get; set; }
    public required string Name { get; set; }
    public string? Subject { get; set; }
    public int TeacherID { get; set; }
    public Teacher? Teacher { get; set; }
    public DateTime CreationDate { get; set; } = DateTime.UtcNow;
    public List<User> Users { get; set; } = new();
}

