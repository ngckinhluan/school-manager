using BusinessObjects.Entities;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace SchoolManager.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AssignmentsController(IAssignmentService assignmentService) : ControllerBase
{
    public IAssignmentService AssignmentService { get; set; } = assignmentService;
    
    [HttpGet("GetAssignments")]
    public async Task<ActionResult<IEnumerable<Assignment>>> GetAssignments()
    {
        try
        {
            var assignments = await AssignmentService.GetAllAssignmentsAsync();
            return Ok(assignments);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
    [HttpGet("GetAssignmentById/{id}")]
    public async Task<ActionResult<Assignment>> GetAssignmentById(int id)
    {
        try
        {
            var assignment = await AssignmentService.GetAssignmentByIdAsync(id);
            if (assignment == null) return NotFound();
            return Ok(assignment);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
    [HttpPost("CreateAssignment")]
    public async Task<ActionResult<int>> CreateAssignment(Assignment assignment)
    {
        try
        {
            return Ok(await AssignmentService.AddAssignmentAsync(assignment));
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
    [HttpPut("UpdateAssignment/{id}")]
    public async Task<ActionResult<int>> UpdateAssignment(int id, Assignment assignment)
    {
        try
        {
            return Ok(await AssignmentService.UpdateAssignmentAsync(id, assignment));
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
    [HttpDelete("DeleteAssignment/{id}")]
    public async Task<ActionResult<int>> DeleteAssignment(int id)
    {
        try
        {
            return Ok(await AssignmentService.DeleteAssignmentAsync(id));
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
    
    
    
    
}