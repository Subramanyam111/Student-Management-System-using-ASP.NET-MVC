using System;
using System.Collections.Generic;

namespace EntityAspMvcFirst.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string FullName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int? Age { get; set; }

    public string? Gender { get; set; }

    public string? Department { get; set; }

    public DateOnly DateOfAdmission { get; set; }
}
