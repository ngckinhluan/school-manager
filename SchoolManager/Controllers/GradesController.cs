using BusinessObjects.Entities;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace SchoolManager.Controllers;

public class GradesController(IGradeService gradeService) : Controller
{
    public IGradeService GradeService { get; set; } = gradeService;
    
    [HttpGet("GetGrades")]
    public async Task<ActionResult<IEnumerable<Grade>>> GetGrades()
    {
        try
        {
            var grades = await GradeService.GetAllGradesAsync();
            return Ok(grades);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
    [HttpGet("GetGradeById/{id}")]
    public async Task<ActionResult<Grade>> GetGradeById(int id)
    {
        try
        {
            var grade = await GradeService.GetGradeByIdAsync(id);
            if (grade == null) return NotFound();
            return Ok(grade);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
    [HttpPost("CreateGrade")]
    public async Task<ActionResult<int>> CreateGrade(Grade grade)
    {
        try
        {
            return Ok(await GradeService.CreateGradeAsync(grade));
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
    [HttpPut("UpdateGrade/{id}")]
    public async Task<ActionResult<int>> UpdateGrade(int id, Grade grade)
    {
        try
        {
            return Ok(await GradeService.UpdateGradeAsync(id, grade));
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
    [HttpDelete("DeleteGrade/{id}")]
    public async Task<ActionResult<int>> DeleteGrade(int id)
    {
        try
        {
            return Ok(await GradeService.DeleteGradeAsync(id));
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    } 
}