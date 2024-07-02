using System;
using System.Collections.Generic;

namespace BusinessObjects.Entities;

public partial class Teacher
{
    public int TeacherId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

    public string? Address { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public DateTime HireDate { get; set; }

    public virtual ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();
}
