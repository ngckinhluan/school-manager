using BusinessObjects.Entities;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace SchoolManager.Controllers;
[Route("api/[controller]")]
[ApiController]
public class StudentsController(IStudentService studentService) : ControllerBase
{
    public IStudentService StudentService { get; set; } = studentService;
    
    [HttpGet("GetStudents")]
    public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
    {
        try
        {
            var students = await StudentService.GetAllStudentsAsync();
            return Ok(students);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
    [HttpGet("GetStudentById/{id}")]
    public async Task<ActionResult<Student>> GetStudentById(int id)
    {
        try
        {
            var student = await StudentService.GetStudentByIdAsync(id);
            if (student == null) return NotFound();
            return Ok(student);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
    [HttpPost("CreateStudent")]
    public async Task<ActionResult<int>> CreateStudent(Student student)
    {
        try
        {
            return Ok(await StudentService.CreateStudentAsync(student));
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
    [HttpPut("UpdateStudent/{id}")]
    public async Task<ActionResult<int>> UpdateStudent(int id, Student student)
    {
        try
        {
            return Ok(await StudentService.UpdateStudentAsync(id, student));
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
    [HttpDelete("DeleteStudent/{id}")]
    public async Task<ActionResult<int>> DeleteStudent(int id)
    {
        try
        {
            return Ok(await StudentService.DeleteStudentAsync(id));
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
    
}