using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
namespace Owler.Models;

[PrimaryKey(nameof(UserId), nameof(ClassCode))]
public class UserClass
{
    [ForeignKey(nameof(User))]
    public required string UserId { get; set; }
    public User? User { get; set; }

    [ForeignKey(nameof(Class))]
    public int ClassCode { get; set; }
    public Class? Class { get; set; }

    public DateTime JoiningDate { get; set; } = DateTime.UtcNow;

}
