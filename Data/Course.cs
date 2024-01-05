using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagementApp.MVC.Data;

public partial class Course
{
    public int Id { get; set; }
    [Display(Name = "Course Name")]
    public string Name { get; set; } = null!;
    [Display(Name = "Course Code")]
    public string Code { get; set; } = null!;
    [Display(Name = "Number of Credits")]
    public int? Credits { get; set; }
}
