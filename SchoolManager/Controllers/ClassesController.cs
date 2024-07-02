using BusinessObjects.Entities;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace SchoolManager.Controllers;

public class ClassesController(IClassService classService) : ControllerBase
{
    public IClassService ClassService { get; set; } = classService;
    
    [HttpGet("GetClasses")]
    public async Task<ActionResult<IEnumerable<Class>>> GetClasses()
    {
        try
        {
            var classes = await ClassService.GetAllClassesAsync();
            return Ok(classes);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
    [HttpGet("GetClassById/{id}")]
    public async Task<ActionResult<Class>> GetClassById(int id)
    {
        try
        {
            var classObj = await ClassService.GetClassByIdAsync(id);
            if (classObj == null) return NotFound();
            return Ok(classObj);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
    [HttpPost("CreateClass")]
    public async Task<ActionResult<int>> CreateClass(Class classObj)
    {
        try
        {
            return Ok(await ClassService.AddClassAsync(classObj));
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
    [HttpPut("UpdateClass/{id}")]
    public async Task<ActionResult<int>> UpdateClass(int id, Class classObj)
    {
        try
        {
            return Ok(await ClassService.UpdateClassAsync(id, classObj));
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
    [HttpDelete("DeleteClass/{id}")]
    public async Task<ActionResult<int>> DeleteClass(int id)
    {
        try
        {
            return Ok(await ClassService.DeleteClassAsync(id));
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
   
    
    
}