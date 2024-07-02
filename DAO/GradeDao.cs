using BusinessObjects.Context;
using BusinessObjects.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAO;

public class GradeDao
{
    private readonly SchoolManagementContext _context = new();

    public async Task<IEnumerable<Grade>> GetGradesAsync()
    {
        return await _context.Grades
            .Include(g => g.Student)
            .Include(g => g.Subject)
            .ToListAsync();
    }

    public async Task<Grade?> GetGradeByIdAsync(int id)
    {
        return await _context.Grades
            .Include(g => g.Student)
            .Include(g => g.Subject)
            .FirstOrDefaultAsync(g => g.GradeId == id);
    }

    public async Task<int> AddGradeAsync(Grade grade)
    {
        _context.Grades.Add(grade);
        return await _context.SaveChangesAsync();
    }

    public async Task<int> UpdateGradeAsync(int id, Grade grade)
    {
        if (id != grade.GradeId)
        {
            throw new ArgumentException("Grade ID mismatch");
        }

        _context.Entry(grade).State = EntityState.Modified;

        try
        {
            return await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!GradeExists(id))
            {
                return 0; 
            }
            else
            {
                throw;
            }
        }
    }
    
    public async Task<int> DeleteGradeAsync(int id)
    {
        var grade = await _context.Grades.FindAsync(id);
        if (grade == null)
        {
            return 0;
        }

        _context.Grades.Remove(grade);
        return await _context.SaveChangesAsync();
    }

    private bool GradeExists(int id)
    {
        return _context.Grades.Any(e => e.GradeId == id);
    }
}