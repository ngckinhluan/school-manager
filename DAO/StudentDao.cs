using BusinessObjects.Context;
using BusinessObjects.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAO;

public class StudentDao()
{
    private readonly SchoolManagementContext _context = new();

    public async Task<IEnumerable<Student>> GetStudentsAsync()
    {
        return await _context.Students.ToListAsync();
    }

    public async Task<Student?> GetStudentByIdAsync(int id)
    {
        return await _context.Students.FindAsync(id);
    }
    
    public async Task<int> AddStudentAsync(Student student)
    {
        _context.Students.Add(student);
        return await _context.SaveChangesAsync();
    }
    
    public async Task<int> UpdateStudentAsync(int id, Student student)
    {
        _context.Entry(student).State = EntityState.Modified;
        return await _context.SaveChangesAsync();
    }

    public async Task<int> DeleteStudentAsync(int id)
    {
        var student = await _context.Students.FindAsync(id);
        if (student == null)
        {
            return 0; 
        }
        _context.Students.Remove(student);
        return await _context.SaveChangesAsync();
    }
}