using BusinessObjects.Entities;
using DAO;
using Repositories.Interface;

namespace Repositories.Implementation;

public class ClassRepository(ClassDao classDao) : IClassRepository
{
    public ClassDao ClassDao { get; set; } = classDao;
    public async Task<int> Create(Class @class)
    {
        return await ClassDao.AddClassAsync(@class);
    }

    public async Task<int> Update(int id, Class @class)
    {
        return await ClassDao.UpdateClassAsync(id, @class);
    }

    public async Task<int> Delete(int id)
    {
        return await ClassDao.DeleteClassAsync(id);
    }

    public async Task<IEnumerable<Class>?> GetAll()
    {
        return await ClassDao.GetClassesAsync();
    }

    public async Task<Class?> GetById(int id)
    {
        return await ClassDao.GetClassByIdAsync(id);
    }
}