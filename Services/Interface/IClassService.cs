using BusinessObjects.Entities;

namespace Services.Interface;

public interface IClassService
{
    public Task<IEnumerable<Class>> GetAllClassesAsync();
    public Task<Class?> GetClassByIdAsync(int id);
    public Task<int> AddClassAsync(Class @class);
    public Task<int> UpdateClassAsync(int id, Class @class);
    public Task<int> DeleteClassAsync(int id);
}