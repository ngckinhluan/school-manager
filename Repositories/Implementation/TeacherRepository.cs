using BusinessObjects.Entities;
using DAO;
using Repositories.Interface;

namespace Repositories.Implementation;

public class TeacherRepository(TeacherDao teacherDao) : ITeacherRepository
{
    public TeacherDao TeacherDao { get; set; } = teacherDao;

    public async Task<int> Create(Teacher teacher)
    {
        return await TeacherDao.AddTeacherAsync(teacher);
    }

    public async Task<int> Update(int id, Teacher teacher)
    {
        return await TeacherDao.UpdateTeacherAsync(id, teacher);
    }

    public async Task<int> Delete(int id)
    {
        return await TeacherDao.DeleteTeacherAsync(id);
    }

    public async Task<IEnumerable<Teacher>?> GetAll()
    {
        return await TeacherDao.GetTeachersAsync();
    }

    public async Task<Teacher?> GetById(int id)
    {
        return await TeacherDao.GetTeacherByIdAsync(id);
    }
}