using BusinessObjects.Context;
using BusinessObjects.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAO;

public class SubjectDao
{
    private readonly SchoolManagementContext _context = new();
    
    public async Task<IEnumerable<Subject>> GetSubjects()
    {
        return await _context.Subjects.ToListAsync();
    }

    public async Task<Subject?> GetSubjectById(int id)
    {
        return await _context.Subjects.FindAsync(id);
    }
    
    public async Task<int> AddSubjectAsync(Subject subject)
    {
        _context.Subjects.Add(subject);
        return await _context.SaveChangesAsync();
    }
    
    public async Task<int> UpdateSubjectAsync(int id, Subject subject)
    {
        _context.Entry(subject).State = EntityState.Modified;
        return await _context.SaveChangesAsync();
    }
    
    public async Task<int> DeleteSubjectAsync(int id)
    {
        var subject = await GetSubjectById(id);
        if (subject == null)
        {
            return 0; 
        }
        _context.Subjects.Remove(subject);
        return await _context.SaveChangesAsync();
    }
    
    
}