using System;
using System.Collections.Generic;

namespace Labb_3___Anropa_databasen.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public string? Ssn { get; set; }

    public string? Class { get; set; }

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();
}
