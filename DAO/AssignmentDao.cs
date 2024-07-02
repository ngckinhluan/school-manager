using BusinessObjects.Context;
using BusinessObjects.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAO;

public class AssignmentDao
{
    private readonly SchoolManagementContext _context = new();

    public async Task<IEnumerable<Assignment>> GetAssignmentsAsync()
    {
        return await _context.Assignments
            .Include(a => a.Class)
            .Include(a => a.Subject)
            .Include(a => a.Teacher)
            .ToListAsync();
    }

    public async Task<Assignment?> GetAssignmentByIdAsync(int id)
    {
        return await _context.Assignments
            .Include(a => a.Class)
            .Include(a => a.Subject)
            .Include(a => a.Teacher)
            .FirstOrDefaultAsync(a => a.AssignmentId == id);
    }
    
    public async Task<int> AddAssignmentAsync(Assignment assignment)
    {
        _context.Assignments.Add(assignment);
        return await _context.SaveChangesAsync();
    }

    public async Task<int> UpdateAssignmentAsync(int id, Assignment assignment)
    {
        if (id != assignment.AssignmentId)
        {
            throw new ArgumentException("Assignment ID mismatch");
        }
        _context.Entry(assignment).State = EntityState.Modified;
        try
        {
            return await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!AssignmentExists(id))
            {
                return 0; 
            }
            else
            {
                throw;
            }
        }
    }

    public async Task<int> DeleteAssignmentAsync(int id)
    {
        var assignment = await _context.Assignments.FindAsync(id);
        if (assignment == null)
        {
            return 0;
        }

        _context.Assignments.Remove(assignment);
        return await _context.SaveChangesAsync();
    }

    private bool AssignmentExists(int id)
    {
        return _context.Assignments.Any(e => e.AssignmentId == id);
    }
}