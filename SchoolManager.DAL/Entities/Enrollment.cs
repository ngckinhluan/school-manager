using System.ComponentModel.DataAnnotations;

namespace SchoolManager.DAL.Entities;

public class Enrollment
{
    [MaxLength(6)]
    public required string EnrollmentId { get; set; }
    public required string StudentId { get; set; }
    public required string CourseId { get; set; }
    public DateTime EnrollmentDate { get; set; }
    
    // Navigation properties
    public virtual Student? Student { get; set; }
    public virtual Course? Course { get; set; }
    
}