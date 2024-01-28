using System;
using System.Collections.Generic;

namespace Labb_3___Anropa_databasen.Models;

public partial class Staff
{
    public int StaffId { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public string? Position { get; set; }

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();
}
