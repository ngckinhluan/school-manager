using BusinessObjects.Context;
using BusinessObjects.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAO;

public class ClassDao
{
    private readonly SchoolManagementContext _context = new();

    public async Task<IEnumerable<Class>> GetClassesAsync()
    {
        return await _context.Classes.ToListAsync();
    }
    
    public async Task<Class?> GetClassByIdAsync(int id)
    {
        return await _context.Classes.FindAsync(id);
    }
    
    public async Task<int> AddClassAsync(Class @class)
    {
        _context.Classes.Add(@class);
        return await _context.SaveChangesAsync();
    }
    
    public async Task<int> UpdateClassAsync(int id, Class @class)
    {
        if (id != @class.ClassId)
        {
            throw new ArgumentException("Class ID mismatch");
        }

        _context.Entry(@class).State = EntityState.Modified;
        try
        {
            return await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!ClassExists(id))
            {
                return 0; 
            }
            else
            {
                throw;
            }
        }
    }
        
    public async Task<int> DeleteClassAsync(int id)
    {
        var @class = await _context.Classes.FindAsync(id);
        if (@class == null)
        {
            return 0; 
        }
        _context.Classes.Remove(@class);
        return await _context.SaveChangesAsync();
    }

    private bool ClassExists(int id)
    {
        return _context.Classes.Any(e => e.ClassId == id);
    }
}