using BusinessObjects.Entities;
using Services.Interface;

namespace Services.Implementation;

public class ClassService : IClassService
{
    public Task<IEnumerable<Class>> GetAllClassesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Class?> GetClassByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<int> AddClassAsync(Class @class)
    {
        throw new NotImplementedException();
    }

    public Task<int> UpdateClassAsync(int id, Class @class)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeleteClassAsync(int id)
    {
        throw new NotImplementedException();
    }
}