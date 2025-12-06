using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityAspMvcFirst.Models;

public partial class Student
{
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = " StudentId is required")]
    public int StudentId { get; set; }

    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [RegularExpression(@"^[A-Za-z]+(?: [A-Za-z]+)*$",ErrorMessage = "Name must contain only letters and spaces")] 
    public string FullName { get; set; }

    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@gmail\.com$", ErrorMessage = "Name must contain only letters and spaces")]
    public string Email { get; set; }

    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Age is required")]
    [Range(18,100,ErrorMessage ="please provide valid Age(between 18 to 100)")]
    public int Age { get; set; }

    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Gender is required")]
    public string Gender { get; set; }

    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Department is required")]
    public string Department { get; set; }

    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DateOfAdmission is required")]
    public DateOnly DateOfAdmission { get; set; }
}
