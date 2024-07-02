using System;
using System.Collections.Generic;

namespace BusinessObjects.Entities;

public partial class Class
{
    public int ClassId { get; set; }

    public string ClassName { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public virtual ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
}
