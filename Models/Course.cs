using System;
using System.Collections.Generic;

namespace Labb_3___Anropa_databasen.Models;

public partial class Course
{
    public int CourseId { get; set; }

    public string? CourseName { get; set; }

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();
}
