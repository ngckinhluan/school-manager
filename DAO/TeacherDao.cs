using BusinessObjects.Context;
using BusinessObjects.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAO;

public class TeacherDao
{
    private readonly SchoolManagementContext _context = new();

    public async Task<IEnumerable<Teacher>> GetTeachersAsync()
    {
        return await _context.Teachers.ToListAsync();
    }

    public async Task<Teacher?> GetTeacherByIdAsync(int id)
    {
        return await _context.Teachers.FindAsync(id);
    }
    
    public async Task<int> AddTeacherAsync(Teacher teacher)
    {
        _context.Teachers.Add(teacher);
        return await _context.SaveChangesAsync();
    }
    
    public async Task<int> UpdateTeacherAsync(int id, Teacher teacher)
    {
        _context.Entry(teacher).State = EntityState.Modified;
        return await _context.SaveChangesAsync();
    }
    
    public async Task<int> DeleteTeacherAsync(int id)
    {
        var teacher = await GetTeacherByIdAsync(id);
        if (teacher == null)
        {
            return 0; 
        }
        _context.Teachers.Remove(teacher);
        return await _context.SaveChangesAsync();
    }
}