using BusinessObjects.Entities;
using Repositories.Implementation;
using Repositories.Interface;
using Services.Interface;

namespace Services.Implementation;

public class ClassService(IClassRepository classRepository) : IClassService
{
    public IClassRepository ClassRepository { get; set; } = classRepository;
    public async Task<IEnumerable<Class?>?> GetAllClassesAsync()
    {
        return await ClassRepository.GetAll();
    }

    public async Task<Class?> GetClassByIdAsync(int id)
    {
        return await ClassRepository.GetById(id);
    }

    public async Task<int> AddClassAsync(Class @class)
    {
        return await ClassRepository.Create(@class);
    }

    public async Task<int> UpdateClassAsync(int id, Class @class)
    {
        return await ClassRepository.Update(id, @class);
    }

    public async Task<int> DeleteClassAsync(int id)
    {
        return await ClassRepository.Delete(id);
    }
}