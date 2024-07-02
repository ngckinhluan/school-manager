using System;
using System.Collections.Generic;

namespace BusinessObjects.Entities;

public partial class Student
{
    public int StudentId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

    public string? Address { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();
}
