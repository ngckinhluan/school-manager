using System.ComponentModel.DataAnnotations;

namespace SchoolManager.DAL.Entities;

public class Course
{
    [StringLength(6)]
    [Required]
    public required string CourseId { get; set; }
    [StringLength(100)]
    public required string CourseName { get; set; }

    public int Credit { get; set; }
    
    
    // Navigation properties
    public virtual ICollection<Enrollment>? Enrollments { get; set; }
}