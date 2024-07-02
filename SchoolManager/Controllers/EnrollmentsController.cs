using BusinessObjects.Entities;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace SchoolManager.Controllers;

public class EnrollmentsController(IEnrollmentService enrollmentService) : Controller
{
    public IEnrollmentService EnrollmentService { get; set; } = enrollmentService;
    
    [HttpGet("GetEnrollments")]
    public async Task<ActionResult<IEnumerable<Enrollment>>> GetEnrollments()
    {
        try
        {
            var enrollments = await EnrollmentService.GetAllEnrollmentsAsync();
            return Ok(enrollments);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
    [HttpGet("GetEnrollmentById/{id}")]
    public async Task<ActionResult<Enrollment>> GetEnrollmentById(int id)
    {
        try
        {
            var enrollment = await EnrollmentService.GetEnrollmentByIdAsync(id);
            if (enrollment == null) return NotFound();
            return Ok(enrollment);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
    [HttpPost("CreateEnrollment")]
    public async Task<ActionResult<int>> CreateEnrollment(Enrollment enrollment)
    {
        try
        {
            return Ok(await EnrollmentService.AddEnrollmentAsync(enrollment));
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
    [HttpPut("UpdateEnrollment/{id}")]
    public async Task<ActionResult<int>> UpdateEnrollment(int id, Enrollment enrollment)
    {
        try
        {
            return Ok(await EnrollmentService.UpdateEnrollmentAsync(id, enrollment));
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
    [HttpDelete("DeleteEnrollment/{id}")]
    public async Task<ActionResult<int>> DeleteEnrollment(int id)
    {
        try
        {
            return Ok(await EnrollmentService.DeleteEnrollmentAsync(id));
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
    
}