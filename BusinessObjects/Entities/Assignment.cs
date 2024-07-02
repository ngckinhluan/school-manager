using System;
using System.Collections.Generic;

namespace BusinessObjects.Entities;

public partial class Assignment
{
    public int AssignmentId { get; set; }

    public int TeacherId { get; set; }

    public int ClassId { get; set; }

    public int SubjectId { get; set; }

    public virtual Class Class { get; set; } = null!;

    public virtual Subject Subject { get; set; } = null!;

    public virtual Teacher Teacher { get; set; } = null!;
}
