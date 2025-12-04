using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;

namespace EntityAspMvcFirst.Models;

public partial class Student
{
    [Required]
    public int StudentId { get; set; }
    [Required]
    public string FullName { get; set; } = null!;
    [Required]
    public string Email { get; set; } = null!;
    [Required]
    public int? Age { get; set; }
    [Required]
    public string? Gender { get; set; }
    [Required]
    public string? Department { get; set; }
    [Required]
    public DateOnly DateOfAdmission { get; set; }
}
