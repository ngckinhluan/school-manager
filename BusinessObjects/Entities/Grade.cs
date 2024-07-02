using System;
using System.Collections.Generic;

namespace BusinessObjects.Entities;

public partial class Grade
{
    public int GradeId { get; set; }

    public int StudentId { get; set; }

    public int SubjectId { get; set; }

    public string Grade1 { get; set; } = null!;

    public DateTime Date { get; set; }

    public virtual Student Student { get; set; } = null!;

    public virtual Subject Subject { get; set; } = null!;
}
