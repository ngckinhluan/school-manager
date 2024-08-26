using System.ComponentModel.DataAnnotations;

namespace SchoolManager.DAL.Entities;

public class Student
{
    [StringLength(6)]
    public required string StudentId { get; set; }
    [StringLength(50)]
    public string? FirstName { get; set; }
    [StringLength(50)]
    public string? LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    [StringLength(100)]
    public string? Email { get; set; }
    
    // Navigation properties
    public virtual ICollection<Enrollment>? Enrollments { get; set; }
}