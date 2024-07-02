using BusinessObjects.Entities;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace SchoolManager.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TeachersController(ITeacherService teacherService) : ControllerBase
{
    public ITeacherService TeacherService { get; set; } = teacherService;
    
    [HttpGet("GetTeachers")]
    public async Task<ActionResult<IEnumerable<Teacher>>> GetTeachers()
    {
        try
        {
            var teachers = await TeacherService.GetAllTeachersAsync();
            return Ok(teachers);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
    [HttpGet("GetTeacherById/{id}")]
    public async Task<ActionResult<Teacher>> GetTeacherById(int id)
    {
        try
        {
            var teacher = await TeacherService.GetTeacherByIdAsync(id);
            if (teacher == null) return NotFound();
            return Ok(teacher);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
    [HttpPost("CreateTeacher")]
    public async Task<ActionResult<int>> CreateTeacher(Teacher teacher)
    {
        try
        {
            return Ok(await TeacherService.CreateTeacherAsync(teacher));
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
    [HttpPut("UpdateTeacher/{id}")]
    public async Task<ActionResult<int>> UpdateTeacher(int id, Teacher teacher)
    {
        try
        {
            return Ok(await TeacherService.UpdateTeacherAsync(id, teacher));
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
    
}