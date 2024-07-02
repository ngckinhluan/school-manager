using BusinessObjects.Entities;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace SchoolManager.Controllers;
[Route("api/[controller]")]
[ApiController]
public class SubjectsController(ISubjectService subjectService) : ControllerBase
{
    public ISubjectService SubjectService {get;} = subjectService;
    
    [HttpGet("GetSubjects")]
    public async Task<ActionResult<IEnumerable<Subject>>> GetSubjects()
    {
        try
        {
            var subjects = await SubjectService.GetAllSubjectsAsync();
            return Ok(subjects);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
    [HttpGet("GetSubjectById/{id}")]
    public async Task<ActionResult<Subject>> GetSubjectById(int id)
    {
        try
        {
            var subject = await SubjectService.GetSubjectByIdAsync(id);
            if (subject == null) return NotFound();
            return Ok(subject);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
    [HttpPost("CreateSubject")]
    public async Task<ActionResult<int>> CreateSubject(Subject subject)
    {
        try
        {
            return Ok(await SubjectService.CreateSubjectAsync(subject));
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
    [HttpPut("UpdateSubject/{id}")]
    public async Task<ActionResult<int>> UpdateSubject(int id, Subject subject)
    {
        try
        {
            return Ok(await SubjectService.UpdateSubjectAsync(id, subject));
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
    [HttpDelete("DeleteSubject/{id}")]
    public async Task<ActionResult<int>> DeleteSubject(int id)
    {
        try
        {
            return Ok(await SubjectService.DeleteSubjectAsync(id));
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
}