using BusinessObjects.Context;
using BusinessObjects.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAO;

public class EnrollmentDao()
{
    private readonly SchoolManagementContext _context = new();

    public async Task<IEnumerable<Enrollment>> GetEnrollmentsAsync()
    {
        return await _context.Enrollments.Include(e => e.Student)
            .Include(e => e.Class)
            .ToListAsync();
    }
    
    public async Task<Enrollment?> GetEnrollmentByIdAsync(int id)
    {
        return await _context.Enrollments
            .Include(e => e.Student)
            .Include(e => e.Class)
            .FirstOrDefaultAsync(e => e.EnrollmentId == id);
    }
    
    public async Task<IEnumerable<Enrollment>> GetByStudentId(int studentId)
    {
        return await _context.Enrollments
            .Include(e => e.Class)
            .Where(e => e.StudentId == studentId)
            .ToListAsync();
    }
    
    public async Task<IEnumerable<Enrollment>> GetByClassId(int classId)
    {
        return await _context.Enrollments
            .Include(e => e.Student)
            .Where(e => e.ClassId == classId)
            .ToListAsync();
    }
    public async Task<int> AddEnrollmentAsync(Enrollment enrollment)
    {
        _context.Enrollments.Add(enrollment);
        return await _context.SaveChangesAsync();
    }
    
    public async Task<int> UpdateEnrollmentAsync(int id, Enrollment enrollment)
    {
        _context.Entry(enrollment).State = EntityState.Modified;
        return await _context.SaveChangesAsync();
    }
    
    public async Task<int> DeleteEnrollmentAsync(int id)
    {
        var enrollment = await GetEnrollmentByIdAsync(id);
        if (enrollment == null)
        {
            return 0; 
        }
        _context.Enrollments.Remove(enrollment);
        return await _context.SaveChangesAsync();
    }
}