using System;
using System.Collections.Generic;

namespace BusinessObjects.Entities;

public partial class Subject
{
    public int SubjectId { get; set; }

    public string SubjectName { get; set; } = null!;

    public virtual ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();
}
