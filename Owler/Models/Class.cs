using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace Owler.Models;
public class Class
{
    [Key]
    public int ClassCode { get; set; }
    public required string Name { get; set; }
    [MaxLength(1000)]
    public string? Description { get; set; }
    public string? Subject { get; set; }
    
    [ForeignKey(nameof(Teacher))]
    public required string TeacherId { get; set; }
    public User? Teacher { get; set; }
    public DateTime CreationDate { get; set; } = DateTime.UtcNow;
    public List<User> Users { get; set; } = new();
}

