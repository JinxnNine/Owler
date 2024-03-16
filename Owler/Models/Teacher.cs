using System;
using System.Collections.Generic;
namespace Owler.Models;

public class Teacher
{
    public List<DateTime> Appointments { get; set; } = new();
    public List<Class> Classes { get; set; } = new();

   
}
